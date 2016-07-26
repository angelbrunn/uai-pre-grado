Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_usuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private idUsuario As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private idioma As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim interfazNegMultiUsuario As INegMultiUsuario = New NegMultiUsuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim listadoGrupos As New List(Of Grupo)
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormABMUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)
        Me.txtbxLegajo.ReadOnly = True
        Me.txtbxApellido.ReadOnly = True
        Me.txtbxNombre.ReadOnly = True
        Me.txtbxTelefono.ReadOnly = True
        Me.txtbxDomicilio.ReadOnly = True
        Me.txtbxFechaNac.ReadOnly = True

        Me.txtbxIdUsuario.ReadOnly = True
        Me.txtbxUsuario.ReadOnly = True
        Me.txtbxContrasena.ReadOnly = True

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idioma"></param>
    ''' <remarks></remarks>
    Private Sub modificarIdiomaSegunPreferencias(ByVal idioma As String)
        'Obtengo el listado de nombre de los componentes en ambos idiomas.
        Dim interfazMultiIdioma As INegMultiIdioma = New NegMultiIdioma
        Dim listadoMultiIdioma As New List(Of MultiIdioma)
        listadoMultiIdioma = interfazMultiIdioma.obtenerTablaMultiIdioma(idioma)

        Dim enu As IEnumerator(Of MultiIdioma) = listadoMultiIdioma.GetEnumerator
        While enu.MoveNext
            If enu.Current.componente = "lbl_legajo" Then
                Me.lbl_legajo.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_apellidoUs" Then
                Me.lbl_apellidoUs.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_nombreUs" Then
                Me.lbl_nombreUs.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_telefono" Then
                Me.lbl_telefono.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_fecNac" Then
                Me.lbl_fecNac.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_idUsuario" Then
                Me.lbl_idUsuario.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_usuarioUs" Then
                Me.lbl_usuarioUs.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_contrasena" Then
                Me.lbl_contrasena.Text = enu.Current.value
            End If
            If enu.Current.componente = "grp_Estado" Then
                Me.grp_Estado.Text = enu.Current.value
            End If
            If enu.Current.componente = "chk_Activo" Then
                Me.chk_Activo.Text = enu.Current.value
            End If
            If enu.Current.componente = "chk_Inactivo" Then
                Me.chk_Inactivo.Text = enu.Current.value
            End If
            If enu.Current.componente = "gpx_Idioma" Then
                Me.gpx_Idioma.Text = enu.Current.value
            End If
            If enu.Current.componente = "gpx_nuevoUs" Then
                Me.gpx_nuevoUs.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_Nuevo" Then
                Me.btn_Nuevo.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_GenerarUsuario" Then
                Me.btn_GenerarUsuario.Text = enu.Current.value
            End If
            If enu.Current.componente = "gpx_buscarUs" Then
                Me.gpx_buscarUs.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_HabilitarBusqueda" Then
                Me.btn_HabilitarBusqueda.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_Buscar" Then
                Me.btn_Buscar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_BorrarVendedor" Then
                Me.btn_BorrarVendedor.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_Modificar" Then
                Me.btn_Modificar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_Salir" Then
                Me.btn_salir.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_grupoDispo" Then
                Me.lbl_grupoDispo.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_descGrupo" Then
                Me.lbl_descGrupo.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_usuario" Then
                Me.Text = enu.Current.value
            End If
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGenerarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GenerarUsuario.Click
        Dim bandera As String = True
        Dim oVendedor As New Vendedor
        Dim oUsuario As New Usuario

        Dim resultado As Boolean
        resultado = interfazNegMultiUsuario.validarExistenciaUsuario(Me.txtbxUsuario.Text)
        If resultado = False Then
            bandera = False
            MsgBox("El Usuario ya existe en la BD")
        End If

        'Grupo para el usuario
        oVendedor.legajo = Me.txtbxLegajo.Text
        oVendedor.apellido = Me.txtbxApellido.Text
        oVendedor.nombre = Me.txtbxNombre.Text
        oVendedor.telefono = Me.txtbxTelefono.Text
        oVendedor.domicilio = Me.txtbxDomicilio.Text
        oVendedor.fechaNacimiento = CType(Me.txtbxFechaNac.Text, Date)

        If chk_Activo.Checked Then
            oVendedor.activo = True
        ElseIf chk_Inactivo.Checked Then
            oVendedor.activo = False
        Else
            MsgBox("Debe Seleccionar un estado para el vendedor")
            bandera = False
        End If

        oUsuario.idUsuario = CType(Me.txtbxIdUsuario.Text, Integer)
        oUsuario.usuario = Me.txtbxUsuario.Text
        oUsuario.password = Me.txtbxContrasena.Text
        oUsuario.legajo = oVendedor.legajo

        ''If btn_Espanol.Checked Then
        '' oUsuario.idioma = "es"
        ''ElseIf btn_Ingles.Checked Then
        '' oUsuario.idioma = "en"
        '' Else
        ''MsgBox("Debe Seleccionar un Idioma preferido")
        ''bandera = False
        ''End If


        If lstbx_idioma.SelectedItems.Count = 0 Then
            MsgBox("Debe Seleccionar un Idioma preferido")
            bandera = False
        Else
            For indice = 0 To lstbx_idioma.SelectedItems.Count - 1
                oUsuario.idioma = lstbx_idioma.SelectedItems(indice)
            Next
        End If

        Dim listadoGruposSeleccionados As New List(Of Grupo)

        If lstbx_Grupos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar al menos un grupo")
            bandera = False
        Else
            For indice = 0 To lstbx_Grupos.SelectedItems.Count - 1
                Dim grupo As String = lstbx_Grupos.SelectedItems(indice)
                Dim oGrupo As New Grupo
                oGrupo = interfazNegMultiUsuario.obtenerGrupoPorNombre(grupo)
                listadoGruposSeleccionados.Add(oGrupo)
            Next

            oUsuario.listadoGrupos = listadoGruposSeleccionados

        End If

        If bandera = True Then
            interfazNegMultiUsuario.insertarUsuario(oUsuario)
            interfazNegMultiUsuario.insertarVendedor(oVendedor)

            'Limpio todos los textbox´s
            Me.limpiarCasilleros()
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub limpiarCasilleros()
        Me.txtbxLegajo.Clear()
        Me.txtbxApellido.Clear()
        Me.txtbxNombre.Clear()
        Me.txtbxTelefono.Clear()
        Me.txtbxDomicilio.Clear()
        Me.txtbxFechaNac.Clear()
        Me.txtbxIdUsuario.Clear()
        Me.txtbxUsuario.Clear()
        Me.txtbxContrasena.Clear()

        Me.txtbxLegajo.ReadOnly = True
        Me.txtbxApellido.ReadOnly = True
        Me.txtbxNombre.ReadOnly = True
        Me.txtbxTelefono.ReadOnly = True
        Me.txtbxDomicilio.ReadOnly = True
        Me.txtbxFechaNac.ReadOnly = True
        Me.txtbxIdUsuario.ReadOnly = True
        Me.txtbxUsuario.ReadOnly = True
        Me.txtbxContrasena.ReadOnly = True
        Me.chk_Activo.Checked = False
        Me.chk_Inactivo.Checked = False
        'Me.btn_Espanol.Checked = False
        'Me.btn_Ingles.Checked = False

        Me.lstbx_Grupos.Items.Clear()
        Me.lstbx_DescGrupo.Items.Clear()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Me.limpiarCasilleros()

        Dim interfazMultiIdioma As INegMultiIdioma = New NegMultiIdioma
        Dim listadoIdiomas As New List(Of MultiIdioma)
        listadoIdiomas = interfazMultiIdioma.obtenerIdiomasDisponibles()

        Dim enumerator As IEnumerator(Of MultiIdioma) = listadoIdiomas.GetEnumerator
        While enumerator.MoveNext
            lstbx_idioma.Items.Add(enumerator.Current.iKey)
        End While
        'Agregado para pruebas, para no tener que cargar todo cada vez
        'BORRAR EN EL ESQUEMA DEFINITIVO ### SOLO TEST: FIXME ###
        ' Me.txtbxApellido.Text = "Prado"
        ' Me.txtbxNombre.Text = "Angel"
        ' Me.txtbxTelefono.Text = "4545-4545"
        ' Me.txtbxDomicilio.Text = "Superi 1245"
        ' Me.txtbxFechaNac.Text = "01/01/1983"
        ' Me.rbtnActivo.Select()

        'PROCEDIMIENTOS PRODUCTIVOS
        'HABILITO TODOS LOS CONTROLES
        Me.txtbxLegajo.ReadOnly = False
        Me.txtbxApellido.ReadOnly = False
        Me.txtbxNombre.ReadOnly = False
        Me.txtbxTelefono.ReadOnly = False
        Me.txtbxDomicilio.ReadOnly = False
        Me.txtbxFechaNac.ReadOnly = False

        Me.txtbxIdUsuario.ReadOnly = False
        Me.txtbxUsuario.ReadOnly = False
        Me.txtbxContrasena.ReadOnly = False

        Me.lstbx_Grupos.Items.Clear()
        Me.lstbx_DescGrupo.Items.Clear()

        Try

            Me.txtbxLegajo.Text = CType(interfazNegMultiUsuario.obtenerIdParaVendedor, String)
            Me.txtbxLegajo.ReadOnly = True

            Me.txtbxIdUsuario.Text = CType(interfazNegMultiUsuario.obtenerIdParaUsuario, String)
            Me.txtbxIdUsuario.ReadOnly = True

            listadoGrupos = interfazNegMultiUsuario.obtenerGrupos()

            Dim enu As IEnumerator(Of Grupo) = listadoGrupos.GetEnumerator

            While enu.MoveNext
                lstbx_Grupos.Items.Add(enu.Current.grupo)
            End While

        Catch ex As Exception
            interfazNegocioBitacora.registrarEnBitacora_BLL(UsuarioId, ex)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstbxGrupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbx_Grupos.SelectedIndexChanged
        Dim nombreGrupo As String = lstbx_Grupos.SelectedItem
        Dim descripcionGrupo As String
        If lstbx_Grupos.SelectedItems.Count = 1 Then
            descripcionGrupo = interfazNegMultiUsuario.obtenerDescripcionGrupoPorNombre(nombreGrupo)
            lstbx_DescGrupo.Items.Clear()
            lstbx_DescGrupo.Items.Add(descripcionGrupo)
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HabilitarBusqueda.Click
        Me.limpiarCasilleros()
        Me.txtbxLegajo.ReadOnly = False
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Dim bandera As Boolean = False

        If Me.txtbxLegajo.Text.Length = 0 Then
            MsgBox("Debe ingresar un legajo")
        Else
            bandera = True
        End If

        If bandera = True Then
            Dim oVendedor As New Vendedor
            oVendedor = interfazNegMultiUsuario.obtenerVendedorPorLegajo(CType(Me.txtbxLegajo.Text, Integer))

            Me.txtbxLegajo.Text = oVendedor.legajo
            Me.txtbxApellido.Text = oVendedor.apellido
            Me.txtbxNombre.Text = oVendedor.nombre
            Me.txtbxTelefono.Text = oVendedor.telefono
            Me.txtbxDomicilio.Text = oVendedor.domicilio
            Me.txtbxFechaNac.Text = oVendedor.fechaNacimiento.ToString

            If oVendedor.activo = True Then
                Me.chk_Activo.Checked = True

                'HABILITO TODOS LOS CONTROLES PARA MODIFICAR
                Me.txtbxLegajo.ReadOnly = False
                Me.txtbxApellido.ReadOnly = False
                Me.txtbxNombre.ReadOnly = False
                Me.txtbxTelefono.ReadOnly = False
                Me.txtbxDomicilio.ReadOnly = False
                Me.txtbxFechaNac.ReadOnly = False

                Me.txtbxIdUsuario.ReadOnly = False
                Me.txtbxUsuario.ReadOnly = False
                Me.txtbxContrasena.ReadOnly = False


            Else
                Me.chk_Inactivo.Checked = True

                Me.txtbxLegajo.ReadOnly = False
                Me.txtbxApellido.ReadOnly = True
                Me.txtbxNombre.ReadOnly = True
                Me.txtbxTelefono.ReadOnly = True
                Me.txtbxDomicilio.ReadOnly = True
                Me.txtbxFechaNac.ReadOnly = True

                Me.txtbxIdUsuario.ReadOnly = True
                Me.txtbxUsuario.ReadOnly = True
                Me.txtbxContrasena.ReadOnly = True
            End If

            Dim oUsuario As New Usuario
            oUsuario = interfazNegMultiUsuario.obtenerUsuarioPorLegajo(oVendedor.legajo)

            Me.txtbxIdUsuario.Text = oUsuario.idUsuario.ToString
            Me.txtbxUsuario.Text = oUsuario.usuario.ToString
            Me.txtbxContrasena.Text = oUsuario.password.ToString

            lstbx_idioma.Items.Add(oUsuario.idioma)
            'If oUsuario.idioma = "es" Then
            'Me.btn_Espanol.Checked = True
            'Else
            'Me.btn_Ingles.Checked = True
            'End If

            Me.lstbx_Grupos.Items.Clear()
            Me.lstbx_DescGrupo.Items.Clear()

            Dim listaGrupos As List(Of Grupo)
            listaGrupos = oUsuario.listadoGrupos

            Dim enu As IEnumerator(Of Grupo) = listaGrupos.GetEnumerator
            While enu.MoveNext
                lstbx_Grupos.Items.Add(enu.Current.grupo)
                lstbx_DescGrupo.Items.Add(enu.Current.descripcion)
            End While

            Me.txtbxIdUsuario.ReadOnly = True
            Me.txtbxUsuario.ReadOnly = True
            Me.txtbxContrasena.ReadOnly = True
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardarCambiosModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        Dim oVendedor As New Vendedor

        'AGREGAR TODAS LAS VALIDACIONES LOCAS
        oVendedor.legajo = Me.txtbxLegajo.Text
        oVendedor.apellido = Me.txtbxApellido.Text
        oVendedor.nombre = Me.txtbxNombre.Text
        oVendedor.telefono = Me.txtbxTelefono.Text
        oVendedor.domicilio = Me.txtbxDomicilio.Text
        oVendedor.fechaNacimiento = CType(Me.txtbxFechaNac.Text, Date)

        If chk_Activo.Checked Then
            oVendedor.activo = True
        ElseIf chk_Inactivo.Checked Then
            oVendedor.activo = False
        Else
            MsgBox("Debe Seleccionar un estado para el vendedor")
        End If

        interfazNegMultiUsuario.actualizarVendedor(oVendedor)

        Me.limpiarCasilleros()

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardarCambiosBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BorrarVendedor.Click

        Dim legajo As Integer = CType(Me.txtbxLegajo.Text, Integer)
        interfazNegMultiUsuario.marcarVendedorComoInactivo(legajo)

        Me.limpiarCasilleros()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UsuarioId() As String
        Get
            Return idUsuario
        End Get
        Set(ByVal value As String)
            idUsuario = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UsuarioIdioma() As String
        Get
            Return idioma
        End Get
        Set(ByVal value As String)
            idioma = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lbl_idioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbx_idioma.SelectedIndexChanged
    End Sub
End Class