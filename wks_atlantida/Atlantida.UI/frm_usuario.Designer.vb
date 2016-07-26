<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuario))
        Me.lbl_usuarioUs = New System.Windows.Forms.Label()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.txtbxUsuario = New System.Windows.Forms.TextBox()
        Me.txtbxContrasena = New System.Windows.Forms.TextBox()
        Me.lbl_legajo = New System.Windows.Forms.Label()
        Me.txtbxLegajo = New System.Windows.Forms.TextBox()
        Me.lbl_nombreUs = New System.Windows.Forms.Label()
        Me.lbl_apellidoUs = New System.Windows.Forms.Label()
        Me.txtbxNombre = New System.Windows.Forms.TextBox()
        Me.txtbxApellido = New System.Windows.Forms.TextBox()
        Me.btn_GenerarUsuario = New System.Windows.Forms.Button()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txtbxTelefono = New System.Windows.Forms.TextBox()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.lbl_fecNac = New System.Windows.Forms.Label()
        Me.txtbxDomicilio = New System.Windows.Forms.TextBox()
        Me.txtbxFechaNac = New System.Windows.Forms.TextBox()
        Me.lbl_idUsuario = New System.Windows.Forms.Label()
        Me.txtbxIdUsuario = New System.Windows.Forms.TextBox()
        Me.lstbx_Grupos = New System.Windows.Forms.ListBox()
        Me.lbl_grupoDispo = New System.Windows.Forms.Label()
        Me.lbl_descGrupo = New System.Windows.Forms.Label()
        Me.lstbx_DescGrupo = New System.Windows.Forms.ListBox()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_HabilitarBusqueda = New System.Windows.Forms.Button()
        Me.gpx_nuevoUs = New System.Windows.Forms.GroupBox()
        Me.gpx_buscarUs = New System.Windows.Forms.GroupBox()
        Me.btn_BorrarVendedor = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.grp_Estado = New System.Windows.Forms.GroupBox()
        Me.chk_Inactivo = New System.Windows.Forms.RadioButton()
        Me.chk_Activo = New System.Windows.Forms.RadioButton()
        Me.gpx_Idioma = New System.Windows.Forms.GroupBox()
        Me.lstbx_idioma = New System.Windows.Forms.ListBox()
        Me.gpx_nuevoUs.SuspendLayout()
        Me.gpx_buscarUs.SuspendLayout()
        Me.grp_Estado.SuspendLayout()
        Me.gpx_Idioma.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_usuarioUs
        '
        Me.lbl_usuarioUs.AutoSize = True
        Me.lbl_usuarioUs.Location = New System.Drawing.Point(285, 39)
        Me.lbl_usuarioUs.Name = "lbl_usuarioUs"
        Me.lbl_usuarioUs.Size = New System.Drawing.Size(46, 13)
        Me.lbl_usuarioUs.TabIndex = 0
        Me.lbl_usuarioUs.Text = "Usuario:"
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Location = New System.Drawing.Point(285, 65)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(67, 13)
        Me.lbl_contrasena.TabIndex = 1
        Me.lbl_contrasena.Text = "Contraseña: "
        '
        'txtbxUsuario
        '
        Me.txtbxUsuario.Location = New System.Drawing.Point(356, 36)
        Me.txtbxUsuario.Name = "txtbxUsuario"
        Me.txtbxUsuario.Size = New System.Drawing.Size(151, 20)
        Me.txtbxUsuario.TabIndex = 2
        '
        'txtbxContrasena
        '
        Me.txtbxContrasena.Location = New System.Drawing.Point(356, 62)
        Me.txtbxContrasena.Name = "txtbxContrasena"
        Me.txtbxContrasena.Size = New System.Drawing.Size(151, 20)
        Me.txtbxContrasena.TabIndex = 3
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(11, 13)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_legajo.TabIndex = 4
        Me.lbl_legajo.Text = "Legajo:"
        '
        'txtbxLegajo
        '
        Me.txtbxLegajo.Location = New System.Drawing.Point(110, 10)
        Me.txtbxLegajo.Name = "txtbxLegajo"
        Me.txtbxLegajo.Size = New System.Drawing.Size(151, 20)
        Me.txtbxLegajo.TabIndex = 5
        '
        'lbl_nombreUs
        '
        Me.lbl_nombreUs.AutoSize = True
        Me.lbl_nombreUs.Location = New System.Drawing.Point(11, 65)
        Me.lbl_nombreUs.Name = "lbl_nombreUs"
        Me.lbl_nombreUs.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombreUs.TabIndex = 6
        Me.lbl_nombreUs.Text = "Nombre:"
        '
        'lbl_apellidoUs
        '
        Me.lbl_apellidoUs.AutoSize = True
        Me.lbl_apellidoUs.Location = New System.Drawing.Point(11, 39)
        Me.lbl_apellidoUs.Name = "lbl_apellidoUs"
        Me.lbl_apellidoUs.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellidoUs.TabIndex = 7
        Me.lbl_apellidoUs.Text = "Apellido:"
        '
        'txtbxNombre
        '
        Me.txtbxNombre.Location = New System.Drawing.Point(110, 62)
        Me.txtbxNombre.Name = "txtbxNombre"
        Me.txtbxNombre.Size = New System.Drawing.Size(151, 20)
        Me.txtbxNombre.TabIndex = 8
        '
        'txtbxApellido
        '
        Me.txtbxApellido.Location = New System.Drawing.Point(110, 36)
        Me.txtbxApellido.Name = "txtbxApellido"
        Me.txtbxApellido.Size = New System.Drawing.Size(151, 20)
        Me.txtbxApellido.TabIndex = 9
        '
        'btn_GenerarUsuario
        '
        Me.btn_GenerarUsuario.Location = New System.Drawing.Point(122, 20)
        Me.btn_GenerarUsuario.Name = "btn_GenerarUsuario"
        Me.btn_GenerarUsuario.Size = New System.Drawing.Size(91, 34)
        Me.btn_GenerarUsuario.TabIndex = 10
        Me.btn_GenerarUsuario.Text = "Generar Usuario"
        Me.btn_GenerarUsuario.UseVisualStyleBackColor = True
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(11, 91)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 11
        Me.lbl_telefono.Text = "Telefono:"
        '
        'txtbxTelefono
        '
        Me.txtbxTelefono.Location = New System.Drawing.Point(110, 88)
        Me.txtbxTelefono.Name = "txtbxTelefono"
        Me.txtbxTelefono.Size = New System.Drawing.Size(151, 20)
        Me.txtbxTelefono.TabIndex = 12
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(11, 117)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(52, 13)
        Me.lbl_domicilio.TabIndex = 13
        Me.lbl_domicilio.Text = "Domicilio:"
        '
        'lbl_fecNac
        '
        Me.lbl_fecNac.AutoSize = True
        Me.lbl_fecNac.Location = New System.Drawing.Point(11, 143)
        Me.lbl_fecNac.Name = "lbl_fecNac"
        Me.lbl_fecNac.Size = New System.Drawing.Size(78, 13)
        Me.lbl_fecNac.TabIndex = 14
        Me.lbl_fecNac.Text = "Fecha de Nac:"
        '
        'txtbxDomicilio
        '
        Me.txtbxDomicilio.Location = New System.Drawing.Point(110, 114)
        Me.txtbxDomicilio.Name = "txtbxDomicilio"
        Me.txtbxDomicilio.Size = New System.Drawing.Size(151, 20)
        Me.txtbxDomicilio.TabIndex = 15
        '
        'txtbxFechaNac
        '
        Me.txtbxFechaNac.Location = New System.Drawing.Point(110, 140)
        Me.txtbxFechaNac.Name = "txtbxFechaNac"
        Me.txtbxFechaNac.Size = New System.Drawing.Size(151, 20)
        Me.txtbxFechaNac.TabIndex = 16
        '
        'lbl_idUsuario
        '
        Me.lbl_idUsuario.AutoSize = True
        Me.lbl_idUsuario.Location = New System.Drawing.Point(285, 13)
        Me.lbl_idUsuario.Name = "lbl_idUsuario"
        Me.lbl_idUsuario.Size = New System.Drawing.Size(51, 13)
        Me.lbl_idUsuario.TabIndex = 20
        Me.lbl_idUsuario.Text = "idUsuario"
        '
        'txtbxIdUsuario
        '
        Me.txtbxIdUsuario.Location = New System.Drawing.Point(356, 10)
        Me.txtbxIdUsuario.Name = "txtbxIdUsuario"
        Me.txtbxIdUsuario.Size = New System.Drawing.Size(151, 20)
        Me.txtbxIdUsuario.TabIndex = 21
        '
        'lstbx_Grupos
        '
        Me.lstbx_Grupos.FormattingEnabled = True
        Me.lstbx_Grupos.Location = New System.Drawing.Point(14, 230)
        Me.lstbx_Grupos.Name = "lstbx_Grupos"
        Me.lstbx_Grupos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstbx_Grupos.Size = New System.Drawing.Size(247, 134)
        Me.lstbx_Grupos.TabIndex = 22
        '
        'lbl_grupoDispo
        '
        Me.lbl_grupoDispo.AutoSize = True
        Me.lbl_grupoDispo.Location = New System.Drawing.Point(12, 214)
        Me.lbl_grupoDispo.Name = "lbl_grupoDispo"
        Me.lbl_grupoDispo.Size = New System.Drawing.Size(101, 13)
        Me.lbl_grupoDispo.TabIndex = 23
        Me.lbl_grupoDispo.Text = "Grupos Disponibles:"
        '
        'lbl_descGrupo
        '
        Me.lbl_descGrupo.AutoSize = True
        Me.lbl_descGrupo.Location = New System.Drawing.Point(285, 328)
        Me.lbl_descGrupo.Name = "lbl_descGrupo"
        Me.lbl_descGrupo.Size = New System.Drawing.Size(98, 13)
        Me.lbl_descGrupo.TabIndex = 24
        Me.lbl_descGrupo.Text = "Descripcion Grupo:"
        '
        'lstbx_DescGrupo
        '
        Me.lstbx_DescGrupo.FormattingEnabled = True
        Me.lstbx_DescGrupo.Location = New System.Drawing.Point(288, 344)
        Me.lstbx_DescGrupo.Name = "lstbx_DescGrupo"
        Me.lstbx_DescGrupo.Size = New System.Drawing.Size(219, 69)
        Me.lstbx_DescGrupo.TabIndex = 25
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Location = New System.Drawing.Point(6, 20)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(91, 34)
        Me.btn_Nuevo.TabIndex = 26
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_HabilitarBusqueda
        '
        Me.btn_HabilitarBusqueda.Location = New System.Drawing.Point(6, 19)
        Me.btn_HabilitarBusqueda.Name = "btn_HabilitarBusqueda"
        Me.btn_HabilitarBusqueda.Size = New System.Drawing.Size(89, 34)
        Me.btn_HabilitarBusqueda.TabIndex = 27
        Me.btn_HabilitarBusqueda.Text = "Habilitar Busqueda"
        Me.btn_HabilitarBusqueda.UseVisualStyleBackColor = True
        '
        'gpx_nuevoUs
        '
        Me.gpx_nuevoUs.Controls.Add(Me.btn_GenerarUsuario)
        Me.gpx_nuevoUs.Controls.Add(Me.btn_Nuevo)
        Me.gpx_nuevoUs.Location = New System.Drawing.Point(288, 151)
        Me.gpx_nuevoUs.Name = "gpx_nuevoUs"
        Me.gpx_nuevoUs.Size = New System.Drawing.Size(219, 66)
        Me.gpx_nuevoUs.TabIndex = 28
        Me.gpx_nuevoUs.TabStop = False
        Me.gpx_nuevoUs.Text = "Nuevo Usuario"
        '
        'gpx_buscarUs
        '
        Me.gpx_buscarUs.Controls.Add(Me.btn_BorrarVendedor)
        Me.gpx_buscarUs.Controls.Add(Me.btn_Buscar)
        Me.gpx_buscarUs.Controls.Add(Me.btn_Modificar)
        Me.gpx_buscarUs.Controls.Add(Me.btn_HabilitarBusqueda)
        Me.gpx_buscarUs.Location = New System.Drawing.Point(288, 223)
        Me.gpx_buscarUs.Name = "gpx_buscarUs"
        Me.gpx_buscarUs.Size = New System.Drawing.Size(217, 102)
        Me.gpx_buscarUs.TabIndex = 29
        Me.gpx_buscarUs.TabStop = False
        Me.gpx_buscarUs.Text = "Buscar Usuario"
        '
        'btn_BorrarVendedor
        '
        Me.btn_BorrarVendedor.Location = New System.Drawing.Point(6, 59)
        Me.btn_BorrarVendedor.Name = "btn_BorrarVendedor"
        Me.btn_BorrarVendedor.Size = New System.Drawing.Size(89, 34)
        Me.btn_BorrarVendedor.TabIndex = 30
        Me.btn_BorrarVendedor.Text = "Borrar Vendedor"
        Me.btn_BorrarVendedor.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(120, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(91, 34)
        Me.btn_Buscar.TabIndex = 29
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(120, 59)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(91, 34)
        Me.btn_Modificar.TabIndex = 28
        Me.btn_Modificar.Text = "Guardar Cambios"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(412, 419)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(91, 23)
        Me.btn_salir.TabIndex = 31
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'grp_Estado
        '
        Me.grp_Estado.Controls.Add(Me.chk_Inactivo)
        Me.grp_Estado.Controls.Add(Me.chk_Activo)
        Me.grp_Estado.Location = New System.Drawing.Point(14, 171)
        Me.grp_Estado.Name = "grp_Estado"
        Me.grp_Estado.Size = New System.Drawing.Size(247, 37)
        Me.grp_Estado.TabIndex = 32
        Me.grp_Estado.TabStop = False
        Me.grp_Estado.Text = "Estado"
        '
        'chk_Inactivo
        '
        Me.chk_Inactivo.AutoSize = True
        Me.chk_Inactivo.Location = New System.Drawing.Point(178, 14)
        Me.chk_Inactivo.Name = "chk_Inactivo"
        Me.chk_Inactivo.Size = New System.Drawing.Size(63, 17)
        Me.chk_Inactivo.TabIndex = 1
        Me.chk_Inactivo.TabStop = True
        Me.chk_Inactivo.Text = "Inactivo"
        Me.chk_Inactivo.UseVisualStyleBackColor = True
        '
        'chk_Activo
        '
        Me.chk_Activo.AutoSize = True
        Me.chk_Activo.Location = New System.Drawing.Point(96, 14)
        Me.chk_Activo.Name = "chk_Activo"
        Me.chk_Activo.Size = New System.Drawing.Size(55, 17)
        Me.chk_Activo.TabIndex = 0
        Me.chk_Activo.TabStop = True
        Me.chk_Activo.Text = "Activo"
        Me.chk_Activo.UseVisualStyleBackColor = True
        '
        'gpx_Idioma
        '
        Me.gpx_Idioma.Controls.Add(Me.lstbx_idioma)
        Me.gpx_Idioma.Location = New System.Drawing.Point(294, 88)
        Me.gpx_Idioma.Name = "gpx_Idioma"
        Me.gpx_Idioma.Size = New System.Drawing.Size(213, 57)
        Me.gpx_Idioma.TabIndex = 33
        Me.gpx_Idioma.TabStop = False
        Me.gpx_Idioma.Text = "Idioma"
        '
        'lstbx_idioma
        '
        Me.lstbx_idioma.FormattingEnabled = True
        Me.lstbx_idioma.Location = New System.Drawing.Point(62, 12)
        Me.lstbx_idioma.Name = "lstbx_idioma"
        Me.lstbx_idioma.Size = New System.Drawing.Size(57, 30)
        Me.lstbx_idioma.TabIndex = 2
        '
        'frm_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 454)
        Me.Controls.Add(Me.gpx_Idioma)
        Me.Controls.Add(Me.grp_Estado)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.gpx_buscarUs)
        Me.Controls.Add(Me.gpx_nuevoUs)
        Me.Controls.Add(Me.lstbx_DescGrupo)
        Me.Controls.Add(Me.lbl_descGrupo)
        Me.Controls.Add(Me.lbl_grupoDispo)
        Me.Controls.Add(Me.lstbx_Grupos)
        Me.Controls.Add(Me.txtbxIdUsuario)
        Me.Controls.Add(Me.lbl_idUsuario)
        Me.Controls.Add(Me.txtbxFechaNac)
        Me.Controls.Add(Me.txtbxDomicilio)
        Me.Controls.Add(Me.lbl_fecNac)
        Me.Controls.Add(Me.lbl_domicilio)
        Me.Controls.Add(Me.txtbxTelefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txtbxApellido)
        Me.Controls.Add(Me.txtbxNombre)
        Me.Controls.Add(Me.lbl_apellidoUs)
        Me.Controls.Add(Me.lbl_nombreUs)
        Me.Controls.Add(Me.txtbxLegajo)
        Me.Controls.Add(Me.lbl_legajo)
        Me.Controls.Add(Me.txtbxContrasena)
        Me.Controls.Add(Me.txtbxUsuario)
        Me.Controls.Add(Me.lbl_contrasena)
        Me.Controls.Add(Me.lbl_usuarioUs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_usuario"
        Me.Text = "Usuario"
        Me.gpx_nuevoUs.ResumeLayout(False)
        Me.gpx_buscarUs.ResumeLayout(False)
        Me.grp_Estado.ResumeLayout(False)
        Me.grp_Estado.PerformLayout()
        Me.gpx_Idioma.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuarioUs As System.Windows.Forms.Label
    Friend WithEvents lbl_contrasena As System.Windows.Forms.Label
    Friend WithEvents txtbxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtbxContrasena As System.Windows.Forms.TextBox
    Friend WithEvents lbl_legajo As System.Windows.Forms.Label
    Friend WithEvents txtbxLegajo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombreUs As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidoUs As System.Windows.Forms.Label
    Friend WithEvents txtbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtbxApellido As System.Windows.Forms.TextBox
    Friend WithEvents btn_GenerarUsuario As System.Windows.Forms.Button
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txtbxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_fecNac As System.Windows.Forms.Label
    Friend WithEvents txtbxDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtbxFechaNac As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idUsuario As System.Windows.Forms.Label
    Friend WithEvents txtbxIdUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lstbx_Grupos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_grupoDispo As System.Windows.Forms.Label
    Friend WithEvents lbl_descGrupo As System.Windows.Forms.Label
    Friend WithEvents lstbx_DescGrupo As System.Windows.Forms.ListBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_HabilitarBusqueda As System.Windows.Forms.Button
    Friend WithEvents gpx_nuevoUs As System.Windows.Forms.GroupBox
    Friend WithEvents gpx_buscarUs As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_BorrarVendedor As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents grp_Estado As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Inactivo As System.Windows.Forms.RadioButton
    Friend WithEvents chk_Activo As System.Windows.Forms.RadioButton
    Friend WithEvents gpx_Idioma As System.Windows.Forms.GroupBox
    Friend WithEvents lstbx_idioma As System.Windows.Forms.ListBox
End Class
