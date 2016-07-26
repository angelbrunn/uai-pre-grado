Imports Atlantida.Seguridad.SIS.Seguridad
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL
Imports Atlantida.Excepcion.SIS.Excepcion

Namespace SIS.BLL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class NegMultiUsuario
        Implements INegMultiUsuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazHash As IHash = New Hash
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
        '##### USUARIO ######
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oUsuario"></param>
        ''' <remarks></remarks>
        Public Sub insertarUsuario(ByVal oUsuario As Usuario) Implements INegMultiUsuario.insertarUsuario

            Dim passHasheada As String
            Dim digiVerificador As String
            Dim IdHASH As String = "HASH"
            'passHasheada = interfazHash.obtenerHash(oUsuario.password)
            'oUsuario.password = passHasheada

            'digiVerificador = interfazHash.obtenerHashUsuario(oUsuario)
            'oUsuario.digitoVerificador = digiVerificador
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                passHasheada = interfazHash.obtenerHash(oUsuario.password)
                oUsuario.password = passHasheada

                digiVerificador = interfazHash.obtenerHashUsuario(oUsuario)
                oUsuario.digitoVerificador = digiVerificador
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(IdHASH, ex)
            End Try
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim listaUsuarios As New List(Of Usuario)
            Dim oDalUsuaio As New DALUsuario
            listaUsuarios = oDalUsuaio.obtenerTablaUsuario()
            If listaUsuarios.Count = 0 Then
                Dim oUsuarioColumnHash As New Usuario
                oUsuarioColumnHash.idUsuario = 1
                oUsuarioColumnHash.usuario = "a"
                oUsuarioColumnHash.password = "a"
                oUsuarioColumnHash.legajo = "a"
                oUsuarioColumnHash.idioma = True
                listaUsuarios.Add(oUsuarioColumnHash)
            End If

            listaUsuarios.Add(oUsuario)

            Dim listaUsuariosConDigitosVerif As New List(Of Usuario)
            listaUsuariosConDigitosVerif = interfazHash.calcularHashTablaUsuario(listaUsuarios)

            oDalUsuaio.insertarUsuario(listaUsuariosConDigitosVerif)

            Dim oDalUsuarioGrupo As New DALUsuarioGrupo
            Dim listadoGruposAUsuario As List(Of Grupo) = oUsuario.listadoGrupos
            Dim enu As IEnumerator(Of Grupo) = listadoGruposAUsuario.GetEnumerator
            While enu.MoveNext
                Dim oUsuarioGrupo As New UsuarioGrupo
                oUsuarioGrupo.idUsuario = oUsuario.idUsuario
                oUsuarioGrupo.idGrupo = enu.Current.idGrupo
                oDalUsuarioGrupo.insertarUsuarioGrupo(oUsuarioGrupo)
            End While
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerIdParaUsuario() As Integer Implements INegMultiUsuario.obtenerIdParaUsuario
            Dim ultimoIdUsuario As Integer

            Dim oDalUsuario As New DALUsuario
            ultimoIdUsuario = oDalUsuario.obtenerUltimoId

            If ultimoIdUsuario = 0 Then
                ultimoIdUsuario = 1
            End If

            ultimoIdUsuario = ultimoIdUsuario + 1

            Return ultimoIdUsuario
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idUsuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerUsuario(ByVal idUsuario As Integer) As Usuario Implements INegMultiUsuario.obtenerUsuario
            'Instancio el usuario que voy a pasar por parametro
            Dim oUsuario As New Usuario

            'Instancio DAL Usuario para obtener el usuario
            Dim oDalUsuario As New DALUsuario
            oUsuario = oDalUsuario.obtenerUsuarioPorId(idUsuario)

            'Instancio el objeto UsuarioGrupo para buscar los grupos de ese usuario
            Dim oDalUsuarioGrupo As New DALUsuarioGrupo
            Dim listaUsuarioGrupo As List(Of UsuarioGrupo)
            listaUsuarioGrupo = oDalUsuarioGrupo.obtenerGrupoPorIdUsuario(idUsuario)

            ' Instancio una lista de grupos para el usuario
            Dim listaGrupo As New List(Of Grupo)
            Dim listaPermisos As New List(Of Permiso)

            'Recorro la lista y obtengo los objetos Grupo
            Dim enu As IEnumerator(Of UsuarioGrupo) = listaUsuarioGrupo.GetEnumerator
            While enu.MoveNext
                Dim oGrupo As New Grupo
                Dim oDalGrupo As New DALGrupo
                oGrupo = oDalGrupo.obtenerGrupoPorId(enu.Current.idGrupo)

                Dim oDalGrupoPermiso As New DALGrupoPermiso
                Dim listadoGrupoPermisos As New List(Of GrupoPermiso)
                listadoGrupoPermisos = oDalGrupoPermiso.obtenerPermisosPorIdGrupo(oGrupo.idGrupo)

                Dim enu2 As IEnumerator(Of GrupoPermiso) = listadoGrupoPermisos.GetEnumerator
                While enu2.MoveNext
                    Dim oDalPermiso As New DALPermiso
                    Dim oPermiso As Permiso
                    oPermiso = oDalPermiso.obtenerPermisoPorId(enu2.Current.idPermiso)
                    listaPermisos.Add(oPermiso)
                    oGrupo.listadoPermisos = listaPermisos
                End While
                listaGrupo.Add(oGrupo)
            End While
            oUsuario.listadoGrupos = listaGrupo

            Return oUsuario
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerUsuarioPorLegajo(ByVal legajo As Integer) As Usuario Implements INegMultiUsuario.obtenerUsuarioPorLegajo
            Dim oUsuario As New Usuario
            Dim oDalUsuario As New DALUsuario

            oUsuario = oDalUsuario.obtenerUsuarioPorLegajo(legajo)

            'Instancio el objeto UsuarioGrupo para buscar los grupos de ese usuario
            Dim oDalUsuarioGrupo As New DALUsuarioGrupo
            Dim listaUsuarioGrupo As List(Of UsuarioGrupo)
            listaUsuarioGrupo = oDalUsuarioGrupo.obtenerGrupoPorIdUsuario(oUsuario.idUsuario)

            ' Instancio una lista de grupos para el usuario
            Dim listaGrupo As New List(Of Grupo)
            Dim listaPermisos As New List(Of Permiso)

            'Recorro la lista y obtengo los objetos Grupo
            Dim enu As IEnumerator(Of UsuarioGrupo) = listaUsuarioGrupo.GetEnumerator
            While enu.MoveNext
                Dim oGrupo As New Grupo
                Dim oDalGrupo As New DALGrupo
                oGrupo = oDalGrupo.obtenerGrupoPorId(enu.Current.idGrupo)

                Dim oDalGrupoPermiso As New DALGrupoPermiso
                Dim listadoGrupoPermisos As New List(Of GrupoPermiso)
                listadoGrupoPermisos = oDalGrupoPermiso.obtenerPermisosPorIdGrupo(oGrupo.idGrupo)

                Dim enu2 As IEnumerator(Of GrupoPermiso) = listadoGrupoPermisos.GetEnumerator
                While enu2.MoveNext
                    Dim oDalPermiso As New DALPermiso
                    Dim oPermiso As Permiso
                    oPermiso = oDalPermiso.obtenerPermisoPorId(enu2.Current.idPermiso)
                    listaPermisos.Add(oPermiso)
                    oGrupo.listadoPermisos = listaPermisos
                End While
                listaGrupo.Add(oGrupo)
            End While
            oUsuario.listadoGrupos = listaGrupo

            Return oUsuario
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuario"></param>
        ''' <param name="password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function login(ByVal usuario As String, ByVal password As String) As Integer Implements INegMultiUsuario.login
            'Cifro la password
            Dim passHasheada As String
            Dim resultadoValidacion As Integer = 0
            Dim oDalUsuario As New DALUsuario
            Dim IdDB As String = "DB"

            Try
                passHasheada = interfazHash.obtenerHash(password)
                resultadoValidacion = oDalUsuario.validarUsuario(usuario, passHasheada)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(IdDB, ex)
            End Try
            Return resultadoValidacion
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function validarExistenciaUsuario(ByVal usuario As String) As Boolean Implements INegMultiUsuario.validarExistenciaUsuario
            Dim resultado As Boolean = False

            Dim oDalUsuario As New DALUsuario
            resultado = oDalUsuario.validarExistenciaUsuario(usuario)

            Return resultado
        End Function
        '##### VENDEDOR #####
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oVendedor"></param>
        ''' <remarks></remarks>
        Public Sub insertarVendedor(ByVal oVendedor As Vendedor) Implements INegMultiUsuario.insertarVendedor
            Dim oDalVendedor As New DALVendedor
            oDalVendedor.insertarVendedor(oVendedor)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerIdParaVendedor() As Integer Implements INegMultiUsuario.obtenerIdParaVendedor
            Dim ultimoIdVendedor As Integer

            Dim oDalVendedor As New DALVendedor
            ultimoIdVendedor = oDalVendedor.obtenerUltimoId

            ultimoIdVendedor = ultimoIdVendedor + 1

            Return ultimoIdVendedor
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerVendedorPorLegajo(ByVal legajo As Integer) As Vendedor Implements INegMultiUsuario.obtenerVendedorPorLegajo
            Dim oVendedor As New Vendedor

            Dim oDalVendedor As New DALVendedor
            oVendedor = oDalVendedor.obtenerVendedorPorLegajo(legajo)

            Return oVendedor
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oVendedor"></param>
        ''' <remarks></remarks>
        Sub actualizarVendedor(ByVal oVendedor As Vendedor) Implements INegMultiUsuario.actualizarVendedor

            Dim oDalVendedor As New DALVendedor
            oDalVendedor.actualizarVendedor(oVendedor)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <remarks></remarks>
        Sub marcarVendedorComoInactivo(ByVal legajo As Integer) Implements INegMultiUsuario.marcarVendedorComoInactivo
            Dim oDalVendedor As New DALVendedor
            oDalVendedor.marcarVendedorInactivo(legajo)
        End Sub
        '##### GRUPO #####
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idGrupo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerGrupoPorId(ByVal idGrupo As Integer) As Grupo Implements INegMultiUsuario.obtenerGrupoPorId
            Dim oGrupo As New Grupo

            Dim oDalGrupo As New DALGrupo
            oGrupo = oDalGrupo.obtenerGrupoPorId(idGrupo)

            Return oGrupo
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerGrupos() As List(Of Grupo) Implements INegMultiUsuario.obtenerGrupos
            Dim listadoGrupos As New List(Of Grupo)

            Dim oDalGrupo As New DALGrupo
            listadoGrupos = oDalGrupo.obtenerGrupos

            Return listadoGrupos
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nombreGrupo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerDescripcionGrupoPorNombre(ByVal nombreGrupo As String) As String Implements INegMultiUsuario.obtenerDescripcionGrupoPorNombre
            Dim descripcionGrupo As String

            Dim oDalGrupo As New DALGrupo
            descripcionGrupo = oDalGrupo.obtenerDescripcionGrupoPorNombreGrupo(nombreGrupo)

            Return descripcionGrupo
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nombreGrupo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerGrupoPorNombre(ByVal nombreGrupo As String) As Grupo Implements INegMultiUsuario.obtenerGrupoPorNombre
            Dim oGrupo As New Grupo

            Dim oDalGrupo As New DALGrupo
            oGrupo = oDalGrupo.obtenerGrupoPorNombreGrupo(nombreGrupo)

            Return oGrupo
        End Function
        '##### PERMISO #####
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPermiso"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPermisoPorId(ByVal idPermiso As Integer) As Permiso Implements INegMultiUsuario.obtenerPermisoPorId
            Dim oPermiso As New Permiso

            Dim oDalPermiso As New DALPermiso
            oPermiso = oDalPermiso.obtenerPermisoPorId(idPermiso)

            Return oPermiso
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function verificarConsistenciaBD() As Boolean Implements INegMultiUsuario.verificarConsistenciaBD
            Dim estado As Boolean
            Dim IdDB As String = "DB"
            Try
                estado = interfazHash.verificarConsistenciaBD()
            Catch ex As SEGExcepcion
                interfazNegocioBitacora.registrarEnBitacora_SEG(IdDB, ex)
            End Try
            Return estado
        End Function
    End Class
End Namespace
