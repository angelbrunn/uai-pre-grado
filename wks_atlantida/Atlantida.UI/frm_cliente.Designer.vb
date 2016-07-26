<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.box_cliente = New System.Windows.Forms.GroupBox()
        Me.btn_baja = New System.Windows.Forms.Button()
        Me.btn_modificacion = New System.Windows.Forms.Button()
        Me.btn_alta = New System.Windows.Forms.Button()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_nrodni = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.box_cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'box_cliente
        '
        Me.box_cliente.Controls.Add(Me.btn_baja)
        Me.box_cliente.Controls.Add(Me.btn_modificacion)
        Me.box_cliente.Controls.Add(Me.btn_alta)
        Me.box_cliente.Controls.Add(Me.btn_validar)
        Me.box_cliente.Controls.Add(Me.txt_email)
        Me.box_cliente.Controls.Add(Me.lbl_email)
        Me.box_cliente.Controls.Add(Me.lbl_nrodni)
        Me.box_cliente.Controls.Add(Me.txt_dni)
        Me.box_cliente.Controls.Add(Me.txt_ape)
        Me.box_cliente.Controls.Add(Me.txt_nom)
        Me.box_cliente.Controls.Add(Me.lbl_nombre)
        Me.box_cliente.Controls.Add(Me.lbl_apellido)
        Me.box_cliente.Location = New System.Drawing.Point(9, 46)
        Me.box_cliente.Name = "box_cliente"
        Me.box_cliente.Size = New System.Drawing.Size(392, 223)
        Me.box_cliente.TabIndex = 15
        Me.box_cliente.TabStop = False
        Me.box_cliente.Text = "Datos del pasajero"
        '
        'btn_baja
        '
        Me.btn_baja.Location = New System.Drawing.Point(252, 191)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja.TabIndex = 17
        Me.btn_baja.Text = "Baja"
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'btn_modificacion
        '
        Me.btn_modificacion.Location = New System.Drawing.Point(171, 191)
        Me.btn_modificacion.Name = "btn_modificacion"
        Me.btn_modificacion.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificacion.TabIndex = 16
        Me.btn_modificacion.Text = "Modificacion"
        Me.btn_modificacion.UseVisualStyleBackColor = True
        '
        'btn_alta
        '
        Me.btn_alta.Location = New System.Drawing.Point(90, 191)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta.TabIndex = 15
        Me.btn_alta.Text = "Alta"
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'btn_validar
        '
        Me.btn_validar.Location = New System.Drawing.Point(9, 191)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(75, 23)
        Me.btn_validar.TabIndex = 14
        Me.btn_validar.Text = "Validar"
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(94, 114)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(292, 20)
        Me.txt_email.TabIndex = 13
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(6, 121)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(32, 13)
        Me.lbl_email.TabIndex = 12
        Me.lbl_email.Text = "Email"
        '
        'lbl_nrodni
        '
        Me.lbl_nrodni.AutoSize = True
        Me.lbl_nrodni.Location = New System.Drawing.Point(6, 41)
        Me.lbl_nrodni.Name = "lbl_nrodni"
        Me.lbl_nrodni.Size = New System.Drawing.Size(41, 13)
        Me.lbl_nrodni.TabIndex = 0
        Me.lbl_nrodni.Text = "Nro dni"
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(94, 34)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(292, 20)
        Me.txt_dni.TabIndex = 3
        '
        'txt_ape
        '
        Me.txt_ape.Location = New System.Drawing.Point(94, 88)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(292, 20)
        Me.txt_ape.TabIndex = 5
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(94, 62)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(292, 20)
        Me.txt_nom.TabIndex = 4
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 69)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(6, 95)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 2
        Me.lbl_apellido.Text = "Apellido"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(9, 293)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 18
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 328)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.box_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar cliente"
        Me.box_cliente.ResumeLayout(False)
        Me.box_cliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents box_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_baja As System.Windows.Forms.Button
    Friend WithEvents btn_modificacion As System.Windows.Forms.Button
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_nrodni As System.Windows.Forms.Label
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_ape As System.Windows.Forms.TextBox
    Friend WithEvents txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
End Class
