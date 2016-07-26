<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_backup))
        Me.a = New System.Windows.Forms.GroupBox()
        Me.chkbxPermiso = New System.Windows.Forms.CheckBox()
        Me.chkbxGrupoPermiso = New System.Windows.Forms.CheckBox()
        Me.chkbxUsuarioGrupo = New System.Windows.Forms.CheckBox()
        Me.chkbxGrupo = New System.Windows.Forms.CheckBox()
        Me.btn_DesSeleccionarTodo = New System.Windows.Forms.Button()
        Me.btn_SeleccionarTodo = New System.Windows.Forms.Button()
        Me.chkbxBitacora = New System.Windows.Forms.CheckBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.chkbxUsuario = New System.Windows.Forms.CheckBox()
        Me.btn_Importar = New System.Windows.Forms.Button()
        Me.chkbxVendedor = New System.Windows.Forms.CheckBox()
        Me.txtbxRuta = New System.Windows.Forms.TextBox()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.txtbxDelimitador = New System.Windows.Forms.TextBox()
        Me.lbl_del = New System.Windows.Forms.Label()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.chkbxMultiIdioma = New System.Windows.Forms.CheckBox()
        Me.a.SuspendLayout()
        Me.SuspendLayout()
        '
        'a
        '
        Me.a.Controls.Add(Me.chkbxMultiIdioma)
        Me.a.Controls.Add(Me.chkbxPermiso)
        Me.a.Controls.Add(Me.chkbxGrupoPermiso)
        Me.a.Controls.Add(Me.chkbxUsuarioGrupo)
        Me.a.Controls.Add(Me.chkbxGrupo)
        Me.a.Controls.Add(Me.btn_DesSeleccionarTodo)
        Me.a.Controls.Add(Me.btn_SeleccionarTodo)
        Me.a.Controls.Add(Me.chkbxBitacora)
        Me.a.Controls.Add(Me.btn_salir)
        Me.a.Controls.Add(Me.chkbxUsuario)
        Me.a.Controls.Add(Me.btn_Importar)
        Me.a.Controls.Add(Me.chkbxVendedor)
        Me.a.Controls.Add(Me.txtbxRuta)
        Me.a.Controls.Add(Me.lbl_ruta)
        Me.a.Controls.Add(Me.txtbxDelimitador)
        Me.a.Controls.Add(Me.lbl_del)
        Me.a.Controls.Add(Me.btn_Exportar)
        Me.a.Location = New System.Drawing.Point(8, 12)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(478, 224)
        Me.a.TabIndex = 0
        Me.a.TabStop = False
        '
        'chkbxPermiso
        '
        Me.chkbxPermiso.AutoSize = True
        Me.chkbxPermiso.Location = New System.Drawing.Point(19, 197)
        Me.chkbxPermiso.Name = "chkbxPermiso"
        Me.chkbxPermiso.Size = New System.Drawing.Size(83, 17)
        Me.chkbxPermiso.TabIndex = 17
        Me.chkbxPermiso.Text = "TB_Permiso"
        Me.chkbxPermiso.UseVisualStyleBackColor = True
        '
        'chkbxGrupoPermiso
        '
        Me.chkbxGrupoPermiso.AutoSize = True
        Me.chkbxGrupoPermiso.Location = New System.Drawing.Point(19, 174)
        Me.chkbxGrupoPermiso.Name = "chkbxGrupoPermiso"
        Me.chkbxGrupoPermiso.Size = New System.Drawing.Size(112, 17)
        Me.chkbxGrupoPermiso.TabIndex = 16
        Me.chkbxGrupoPermiso.Text = "TB_GrupoPermiso"
        Me.chkbxGrupoPermiso.UseVisualStyleBackColor = True
        '
        'chkbxUsuarioGrupo
        '
        Me.chkbxUsuarioGrupo.AutoSize = True
        Me.chkbxUsuarioGrupo.Location = New System.Drawing.Point(19, 128)
        Me.chkbxUsuarioGrupo.Name = "chkbxUsuarioGrupo"
        Me.chkbxUsuarioGrupo.Size = New System.Drawing.Size(111, 17)
        Me.chkbxUsuarioGrupo.TabIndex = 15
        Me.chkbxUsuarioGrupo.Text = "TB_UsuarioGrupo"
        Me.chkbxUsuarioGrupo.UseVisualStyleBackColor = True
        '
        'chkbxGrupo
        '
        Me.chkbxGrupo.AutoSize = True
        Me.chkbxGrupo.Location = New System.Drawing.Point(19, 151)
        Me.chkbxGrupo.Name = "chkbxGrupo"
        Me.chkbxGrupo.Size = New System.Drawing.Size(75, 17)
        Me.chkbxGrupo.TabIndex = 14
        Me.chkbxGrupo.Text = "TB_Grupo"
        Me.chkbxGrupo.UseVisualStyleBackColor = True
        '
        'btn_DesSeleccionarTodo
        '
        Me.btn_DesSeleccionarTodo.Location = New System.Drawing.Point(367, 118)
        Me.btn_DesSeleccionarTodo.Name = "btn_DesSeleccionarTodo"
        Me.btn_DesSeleccionarTodo.Size = New System.Drawing.Size(97, 35)
        Me.btn_DesSeleccionarTodo.TabIndex = 13
        Me.btn_DesSeleccionarTodo.Text = "Des-Seleccionar Todo"
        Me.btn_DesSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'btn_SeleccionarTodo
        '
        Me.btn_SeleccionarTodo.Location = New System.Drawing.Point(367, 78)
        Me.btn_SeleccionarTodo.Name = "btn_SeleccionarTodo"
        Me.btn_SeleccionarTodo.Size = New System.Drawing.Size(97, 35)
        Me.btn_SeleccionarTodo.TabIndex = 12
        Me.btn_SeleccionarTodo.Text = "Seleccionar Todo"
        Me.btn_SeleccionarTodo.UseVisualStyleBackColor = True
        '
        'chkbxBitacora
        '
        Me.chkbxBitacora.AutoSize = True
        Me.chkbxBitacora.Location = New System.Drawing.Point(19, 82)
        Me.chkbxBitacora.Name = "chkbxBitacora"
        Me.chkbxBitacora.Size = New System.Drawing.Size(85, 17)
        Me.chkbxBitacora.TabIndex = 11
        Me.chkbxBitacora.Text = "TB_Bitacora"
        Me.chkbxBitacora.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(367, 191)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(97, 26)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'chkbxUsuario
        '
        Me.chkbxUsuario.AutoSize = True
        Me.chkbxUsuario.Location = New System.Drawing.Point(19, 105)
        Me.chkbxUsuario.Name = "chkbxUsuario"
        Me.chkbxUsuario.Size = New System.Drawing.Size(82, 17)
        Me.chkbxUsuario.TabIndex = 6
        Me.chkbxUsuario.Text = "TB_Usuario"
        Me.chkbxUsuario.UseVisualStyleBackColor = True
        '
        'btn_Importar
        '
        Me.btn_Importar.Location = New System.Drawing.Point(367, 46)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(97, 26)
        Me.btn_Importar.TabIndex = 10
        Me.btn_Importar.Text = "Importar"
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'chkbxVendedor
        '
        Me.chkbxVendedor.AutoSize = True
        Me.chkbxVendedor.Location = New System.Drawing.Point(249, 82)
        Me.chkbxVendedor.Name = "chkbxVendedor"
        Me.chkbxVendedor.Size = New System.Drawing.Size(92, 17)
        Me.chkbxVendedor.TabIndex = 5
        Me.chkbxVendedor.Text = "TB_Vendedor"
        Me.chkbxVendedor.UseVisualStyleBackColor = True
        '
        'txtbxRuta
        '
        Me.txtbxRuta.Location = New System.Drawing.Point(109, 52)
        Me.txtbxRuta.Name = "txtbxRuta"
        Me.txtbxRuta.Size = New System.Drawing.Size(229, 20)
        Me.txtbxRuta.TabIndex = 4
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(16, 55)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(33, 13)
        Me.lbl_ruta.TabIndex = 3
        Me.lbl_ruta.Text = "Ruta:"
        '
        'txtbxDelimitador
        '
        Me.txtbxDelimitador.Location = New System.Drawing.Point(109, 24)
        Me.txtbxDelimitador.Name = "txtbxDelimitador"
        Me.txtbxDelimitador.Size = New System.Drawing.Size(57, 20)
        Me.txtbxDelimitador.TabIndex = 2
        '
        'lbl_del
        '
        Me.lbl_del.AutoSize = True
        Me.lbl_del.Location = New System.Drawing.Point(16, 27)
        Me.lbl_del.Name = "lbl_del"
        Me.lbl_del.Size = New System.Drawing.Size(62, 13)
        Me.lbl_del.TabIndex = 1
        Me.lbl_del.Text = "Delimitador:"
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Location = New System.Drawing.Point(367, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(97, 26)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'chkbxMultiIdioma
        '
        Me.chkbxMultiIdioma.AutoSize = True
        Me.chkbxMultiIdioma.Location = New System.Drawing.Point(249, 105)
        Me.chkbxMultiIdioma.Name = "chkbxMultiIdioma"
        Me.chkbxMultiIdioma.Size = New System.Drawing.Size(99, 17)
        Me.chkbxMultiIdioma.TabIndex = 18
        Me.chkbxMultiIdioma.Text = "TB_MultiIdioma"
        Me.chkbxMultiIdioma.UseVisualStyleBackColor = True
        '
        'frm_backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 250)
        Me.Controls.Add(Me.a)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_backup"
        Me.Text = "Resguardo"
        Me.a.ResumeLayout(False)
        Me.a.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents a As System.Windows.Forms.GroupBox
    Friend WithEvents txtbxDelimitador As System.Windows.Forms.TextBox
    Friend WithEvents lbl_del As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents chkbxVendedor As System.Windows.Forms.CheckBox
    Friend WithEvents txtbxRuta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ruta As System.Windows.Forms.Label
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents chkbxUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxBitacora As System.Windows.Forms.CheckBox
    Friend WithEvents btn_SeleccionarTodo As System.Windows.Forms.Button
    Friend WithEvents btn_DesSeleccionarTodo As System.Windows.Forms.Button
    Friend WithEvents chkbxGrupoPermiso As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxUsuarioGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxPermiso As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxMultiIdioma As System.Windows.Forms.CheckBox
End Class
