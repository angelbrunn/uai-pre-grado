Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class NegBackup
        Implements INegBackup
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazNegMultiUsuario As INegMultiUsuario = New NegMultiUsuario
        ' ##### EXPORTAR #####
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoVendedor(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoVendedor
            Dim oIOBackup As New IOBackup
            Dim listaVendedor As New List(Of Vendedor)
            Dim oDalVendedor As New DALVendedor

            Try
                listaVendedor = oDalVendedor.obtenerTablaVendedor()
                oIOBackup.escribirArchivoVendedor(ruta, delim, listaVendedor)
            Catch ex As IOException
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoUsuario(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoUsuario
            Dim oIOBackup As New IOBackup
            Dim listaUsuario As New List(Of Usuario)
            Dim oDalUsuario As New DALUsuario

            Try
                listaUsuario = oDalUsuario.obtenerTablaUsuario()
                oIOBackup.escribirArchivoUsuario(ruta, delim, listaUsuario)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoBitacora(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoBitacora
            Dim oIOBackup As New IOBackup
            Dim listaEventos As New List(Of Entidades.SIS.Entidades.Bitacora)
            Dim oDalBitacora As New DALBitacora

            Try
                listaEventos = oDalBitacora.obtenerEventos()
                oIOBackup.escribirArchivoBitacora(ruta, delim, listaEventos)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoUsuarioGrupo(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoUsuarioGrupo
            Dim oIOBackup As New IOBackup
            Dim listaUsuarioGrupo As New List(Of UsuarioGrupo)
            Dim oDalUsuarioGrupo As New DALUsuarioGrupo

            Try
                listaUsuarioGrupo = oDalUsuarioGrupo.obtenerTablaUsuarioGrupo()
                oIOBackup.escribirArchivoUsuarioGrupo(ruta, delim, listaUsuarioGrupo)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoGrupo(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoGrupo
            Dim oIOBackup As New IOBackup
            Dim listaGrupo As New List(Of Grupo)
            Dim oDalGrupo As New DALGrupo

            Try
                listaGrupo = oDalGrupo.obtenerGrupos()
                oIOBackup.escribirArchivoGrupo(ruta, delim, listaGrupo)
            Catch ex As IOException
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoGrupoPermisos(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoGrupoPermisos
            Dim oIOBackup As New IOBackup
            Dim listaGrupoPermiso As New List(Of GrupoPermiso)
            Dim oDalGrupoPermiso As New DALGrupoPermiso

            Try
                listaGrupoPermiso = oDalGrupoPermiso.obtenerGrupoPermiso()
                oIOBackup.escribirArchivoGrupoPermiso(ruta, delim, listaGrupoPermiso)
            Catch ex As IOException
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoPermisos(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoPermisos
            Dim oIOBackup As New IOBackup
            Dim listaPermiso As New List(Of Permiso)
            Dim oDalPermiso As New DALPermiso

            Try
                listaPermiso = oDalPermiso.obtenerPermiso()
                oIOBackup.escribirArchivoPermiso(ruta, delim, listaPermiso)
            Catch ex As IOException
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoMultiIdioma(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoMultiIdioma
            Dim oIOBackup As New IOBackup
            Dim listaMultiIdioma As New List(Of MultiIdioma)
            Dim oDalMultiIdioma As New DALMultiIdioma

            Try
                listaMultiIdioma = oDalMultiIdioma.obtenerTablaMultiIdiomaAll()
                oIOBackup.escribirArchivoMultiIdioma(ruta, delim, listaMultiIdioma)
            Catch ex As IOException
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoCobro(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoCobro
            Dim oIOCobro As New IOCobro
            Dim listaCobro As New List(Of Cobro)
            Dim oDalCobro As New DALCobro
            Try
                listaCobro = oDalCobro.obtenerTablaCobro()
                oIOCobro.escribirArchivoCobro(ruta, delim, listaCobro)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoPago(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoPago
            Dim oIOPago As New IOPago
            Dim listaPago As New List(Of Pago)
            Dim oDalPago As New DALPago
            Try
                listaPago = oDalPago.obtenerTablaPago()
                oIOPago.escribirArchivoCobro(ruta, delim, listaPago)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoPresupuesto(ByVal ruta As String, ByVal delim As String) Implements INegBackup.exportarAArchivoPresupuesto
            Dim oIOPresupuesto As New IOPresupuesto
            Dim listaPresupuesto As New List(Of Presupuesto)
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                listaPresupuesto = oDalPresupuesto.obtenerTablaPresupuesto()
                oIOPresupuesto.escribirArchivoPresupuesto(ruta, delim, listaPresupuesto)
            Catch ex As Exception
            End Try
        End Sub
        ' ##### IMPORTAR #####
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoVendedor(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoVendedor
            Dim oIOBackup As New IOBackup
            Dim oDalVendedor As New DALVendedor
            Dim listaVendedor As New List(Of Vendedor)

            listaVendedor = oIOBackup.leerArchivoVendedor(ruta, delim)

            Dim enu As IEnumerator(Of Vendedor) = listaVendedor.GetEnumerator
            While enu.MoveNext
                oDalVendedor.insertarVendedor(enu.Current)
            End While
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoUsuario(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoUsuario
            Dim oIOBackup As New IOBackup
            Dim listaUsuario As New List(Of Usuario)

            listaUsuario = oIOBackup.leerArchivoUsuario(ruta, delim)

            Me.insertarUsuarioDesdeBackup(listaUsuario)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoBitacora(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoBitacora
            Dim oIOBackup As New IOBackup
            Dim listaBitacora As New List(Of Entidades.SIS.Entidades.Bitacora)

            listaBitacora = oIOBackup.leerArchivoBitacora(ruta, delim)

            Me.insertarBitacoraDesdeBackup(listaBitacora)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoGrupo(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoGrupo
            Dim oIOBackup As New IOBackup
            Dim listaGrupo As New List(Of Entidades.SIS.Entidades.Grupo)

            listaGrupo = oIOBackup.leerArchivoGrupo(ruta, delim)

            Me.insertarGrupoDesdeBackup(listaGrupo)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoGrupoPermiso(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoGrupoPermiso
            Dim oIOBackup As New IOBackup
            Dim listaGrupoPermiso As New List(Of Entidades.SIS.Entidades.GrupoPermiso)

            listaGrupoPermiso = oIOBackup.leerArchivoGrupoPermiso(ruta, delim)

            Me.insertarGrupoPermisoDesdeBackup(listaGrupoPermiso)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoPermiso(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoPermiso
            Dim oIOBackup As New IOBackup
            Dim listaPermiso As New List(Of Entidades.SIS.Entidades.Permiso)

            listaPermiso = oIOBackup.leerArchivoPermiso(ruta, delim)

            Me.insertarPermisoDesdeBackup(listaPermiso)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoMultiIdioma(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoMultiIdioma
            Dim oIOBackup As New IOBackup
            Dim listaMultiIdioma As New List(Of Entidades.SIS.Entidades.MultiIdioma)

            listaMultiIdioma = oIOBackup.leerArchivoMultiIdioma(ruta, delim)

            Me.insertarMultiIdiomaDesdeBackup(listaMultiIdioma)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoUsuarioGrupo(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoUsuarioGrupo
            Dim oIOBackup As New IOBackup
            Dim listaUsuarioGrupo As New List(Of Entidades.SIS.Entidades.UsuarioGrupo)

            listaUsuarioGrupo = oIOBackup.leerArchivoUsuarioGrupo(ruta, delim)

            Me.insertarUsuarioGrupoDesdeBackup(listaUsuarioGrupo)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaUsuarios"></param>
        ''' <remarks></remarks>
        Public Sub insertarUsuarioDesdeBackup(ByVal listaUsuarios As List(Of Usuario)) Implements INegBackup.insertarUsuarioDesdeBackup
            Dim oDalUsuario As New DALUsuario

            oDalUsuario.insertarUsuarioDesdeBackup(listaUsuarios)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaEventos"></param>
        ''' <remarks></remarks>
        Public Sub insertarBitacoraDesdeBackup(ByVal listaEventos As List(Of Entidades.SIS.Entidades.Bitacora)) Implements INegBackup.insertarBitacoraDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarBitacoraDesdeBackup(listaEventos)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaGrupo"></param>
        ''' <remarks></remarks>
        Public Sub insertarGrupoDesdeBackup(ByVal listaGrupo As List(Of Entidades.SIS.Entidades.Grupo)) Implements INegBackup.insertarGrupoDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarGrupoDesdeBackup(listaGrupo)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaVendedor"></param>
        ''' <remarks></remarks>
        Public Sub insertarVendedorDesdeBackup(ByVal listaVendedor As List(Of Entidades.SIS.Entidades.Vendedor)) Implements INegBackup.insertarVendedorDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarVendedorDesdeBackup(listaVendedor)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaGrupoPermiso"></param>
        ''' <remarks></remarks>
        Public Sub insertarGrupoPermisoDesdeBackup(ByVal listaGrupoPermiso As List(Of Entidades.SIS.Entidades.GrupoPermiso)) Implements INegBackup.insertarGrupoPermisoDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarGrupoPermisoDesdeBackup(listaGrupoPermiso)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaPermiso"></param>
        ''' <remarks></remarks>
        Public Sub insertarPermisoDesdeBackup(ByVal listaPermiso As List(Of Entidades.SIS.Entidades.Permiso)) Implements INegBackup.insertarPermisoDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarPermisoDesdeBackup(listaPermiso)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaMultiIdioma"></param>
        ''' <remarks></remarks>
        Public Sub insertarMultiIdiomaDesdeBackup(ByVal listaMultiIdioma As List(Of Entidades.SIS.Entidades.MultiIdioma)) Implements INegBackup.insertarMultiIdiomaDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarMultiIdiomaDesdeBackup(listaMultiIdioma)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaUsuarioGrupo"></param>
        ''' <remarks></remarks>
        Public Sub insertarUsuarioGrupoDesdeBackup(ByVal listaUsuarioGrupo As List(Of Entidades.SIS.Entidades.UsuarioGrupo)) Implements INegBackup.insertarUsuarioGrupoDesdeBackup
            Dim oDalBitacora As New DALBitacora

            oDalBitacora.insertarUsuarioGrupoDesdeBackup(listaUsuarioGrupo)

        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoCobro(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoCobro
            Dim oIOCobro As New IOCobro
            Dim oDalCobro As New DALCobro
            Dim listaCobro As New List(Of Cobro)

            listaCobro = oIOCobro.leerArchivoCobro(ruta, delim)

            Dim enu As IEnumerator(Of Cobro) = listaCobro.GetEnumerator
            While enu.MoveNext
                oDalCobro.insertarCobro(enu.Current)
            End While
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoPago(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoPago
            Dim oIOPago As New IOPago
            Dim oDalPago As New DALPago
            Dim listaPago As New List(Of Pago)

            listaPago = oIOPago.leerArchivoCobro(ruta, delim)

            Dim enu As IEnumerator(Of Pago) = listaPago.GetEnumerator
            While enu.MoveNext
                oDalPago.insertarPago(enu.Current)
            End While
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoPresupuesto(ByVal ruta As String, ByVal delim As String) Implements INegBackup.importarDesdeArchivoPresupuesto
            Dim oIOPresupuesto As New IOPresupuesto
            Dim oDalPresupuesto As New DALPresupuesto
            Dim listaPresupuesto As New List(Of Presupuesto)

            listaPresupuesto = oIOPresupuesto.leerArchivoPresupuesto(ruta, delim)

            Dim enu As IEnumerator(Of Presupuesto) = listaPresupuesto.GetEnumerator
            While enu.MoveNext
                oDalPresupuesto.insertarPresupuesto(enu.Current, 0)
            End While
        End Sub
    End Class
End Namespace