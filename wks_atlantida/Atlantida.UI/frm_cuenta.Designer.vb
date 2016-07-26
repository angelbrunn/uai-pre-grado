<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuenta
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.box_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_ori_tcuenta = New System.Windows.Forms.TextBox()
        Me.lbl_tipo_cuenta = New System.Windows.Forms.Label()
        Me.txt_ori_nro_cuenta = New System.Windows.Forms.TextBox()
        Me.txt_ori_banco = New System.Windows.Forms.TextBox()
        Me.lbl_banco = New System.Windows.Forms.Label()
        Me.lbl_num_cuenta = New System.Windows.Forms.Label()
        Me.box_bank = New System.Windows.Forms.GroupBox()
        Me.txt_des_tcuenta = New System.Windows.Forms.TextBox()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.txt_des_email = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_des_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_tipo_cuenta_b = New System.Windows.Forms.Label()
        Me.txt_des_nro_cuenta = New System.Windows.Forms.TextBox()
        Me.txt_des_banco = New System.Windows.Forms.TextBox()
        Me.lbl_banco_b = New System.Windows.Forms.Label()
        Me.lbl_num_cuenta_b = New System.Windows.Forms.Label()
        Me.box_cliente.SuspendLayout()
        Me.box_bank.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(9, 289)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 20
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'box_cliente
        '
        Me.box_cliente.Controls.Add(Me.txt_ori_tcuenta)
        Me.box_cliente.Controls.Add(Me.lbl_tipo_cuenta)
        Me.box_cliente.Controls.Add(Me.txt_ori_nro_cuenta)
        Me.box_cliente.Controls.Add(Me.txt_ori_banco)
        Me.box_cliente.Controls.Add(Me.lbl_banco)
        Me.box_cliente.Controls.Add(Me.lbl_num_cuenta)
        Me.box_cliente.Location = New System.Drawing.Point(9, 12)
        Me.box_cliente.Name = "box_cliente"
        Me.box_cliente.Size = New System.Drawing.Size(392, 107)
        Me.box_cliente.TabIndex = 19
        Me.box_cliente.TabStop = False
        Me.box_cliente.Text = "Origen"
        '
        'txt_ori_tcuenta
        '
        Me.txt_ori_tcuenta.Location = New System.Drawing.Point(171, 20)
        Me.txt_ori_tcuenta.Name = "txt_ori_tcuenta"
        Me.txt_ori_tcuenta.Size = New System.Drawing.Size(215, 20)
        Me.txt_ori_tcuenta.TabIndex = 6
        '
        'lbl_tipo_cuenta
        '
        Me.lbl_tipo_cuenta.AutoSize = True
        Me.lbl_tipo_cuenta.Location = New System.Drawing.Point(86, 27)
        Me.lbl_tipo_cuenta.Name = "lbl_tipo_cuenta"
        Me.lbl_tipo_cuenta.Size = New System.Drawing.Size(79, 13)
        Me.lbl_tipo_cuenta.TabIndex = 0
        Me.lbl_tipo_cuenta.Text = "Tipo de cuenta"
        '
        'txt_ori_nro_cuenta
        '
        Me.txt_ori_nro_cuenta.Location = New System.Drawing.Point(94, 72)
        Me.txt_ori_nro_cuenta.Name = "txt_ori_nro_cuenta"
        Me.txt_ori_nro_cuenta.Size = New System.Drawing.Size(292, 20)
        Me.txt_ori_nro_cuenta.TabIndex = 5
        '
        'txt_ori_banco
        '
        Me.txt_ori_banco.Location = New System.Drawing.Point(94, 46)
        Me.txt_ori_banco.Name = "txt_ori_banco"
        Me.txt_ori_banco.Size = New System.Drawing.Size(292, 20)
        Me.txt_ori_banco.TabIndex = 4
        '
        'lbl_banco
        '
        Me.lbl_banco.AutoSize = True
        Me.lbl_banco.Location = New System.Drawing.Point(3, 53)
        Me.lbl_banco.Name = "lbl_banco"
        Me.lbl_banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_banco.TabIndex = 1
        Me.lbl_banco.Text = "Banco"
        '
        'lbl_num_cuenta
        '
        Me.lbl_num_cuenta.AutoSize = True
        Me.lbl_num_cuenta.Location = New System.Drawing.Point(3, 79)
        Me.lbl_num_cuenta.Name = "lbl_num_cuenta"
        Me.lbl_num_cuenta.Size = New System.Drawing.Size(80, 13)
        Me.lbl_num_cuenta.TabIndex = 2
        Me.lbl_num_cuenta.Text = "Numero cuenta"
        '
        'box_bank
        '
        Me.box_bank.Controls.Add(Me.txt_des_tcuenta)
        Me.box_bank.Controls.Add(Me.lbl_mail)
        Me.box_bank.Controls.Add(Me.txt_des_email)
        Me.box_bank.Controls.Add(Me.lbl_nombre)
        Me.box_bank.Controls.Add(Me.txt_des_nombre)
        Me.box_bank.Controls.Add(Me.lbl_tipo_cuenta_b)
        Me.box_bank.Controls.Add(Me.txt_des_nro_cuenta)
        Me.box_bank.Controls.Add(Me.txt_des_banco)
        Me.box_bank.Controls.Add(Me.lbl_banco_b)
        Me.box_bank.Controls.Add(Me.lbl_num_cuenta_b)
        Me.box_bank.Location = New System.Drawing.Point(9, 125)
        Me.box_bank.Name = "box_bank"
        Me.box_bank.Size = New System.Drawing.Size(392, 158)
        Me.box_bank.TabIndex = 20
        Me.box_bank.TabStop = False
        '
        'txt_des_tcuenta
        '
        Me.txt_des_tcuenta.Location = New System.Drawing.Point(171, 19)
        Me.txt_des_tcuenta.Name = "txt_des_tcuenta"
        Me.txt_des_tcuenta.Size = New System.Drawing.Size(215, 20)
        Me.txt_des_tcuenta.TabIndex = 7
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Location = New System.Drawing.Point(3, 131)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(32, 13)
        Me.lbl_mail.TabIndex = 22
        Me.lbl_mail.Text = "Email"
        '
        'txt_des_email
        '
        Me.txt_des_email.Location = New System.Drawing.Point(94, 124)
        Me.txt_des_email.Name = "txt_des_email"
        Me.txt_des_email.Size = New System.Drawing.Size(292, 20)
        Me.txt_des_email.TabIndex = 21
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(3, 105)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 20
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_des_nombre
        '
        Me.txt_des_nombre.Location = New System.Drawing.Point(94, 98)
        Me.txt_des_nombre.Name = "txt_des_nombre"
        Me.txt_des_nombre.Size = New System.Drawing.Size(292, 20)
        Me.txt_des_nombre.TabIndex = 19
        '
        'lbl_tipo_cuenta_b
        '
        Me.lbl_tipo_cuenta_b.AutoSize = True
        Me.lbl_tipo_cuenta_b.Location = New System.Drawing.Point(86, 27)
        Me.lbl_tipo_cuenta_b.Name = "lbl_tipo_cuenta_b"
        Me.lbl_tipo_cuenta_b.Size = New System.Drawing.Size(79, 13)
        Me.lbl_tipo_cuenta_b.TabIndex = 0
        Me.lbl_tipo_cuenta_b.Text = "Tipo de cuenta"
        '
        'txt_des_nro_cuenta
        '
        Me.txt_des_nro_cuenta.Location = New System.Drawing.Point(94, 72)
        Me.txt_des_nro_cuenta.Name = "txt_des_nro_cuenta"
        Me.txt_des_nro_cuenta.Size = New System.Drawing.Size(292, 20)
        Me.txt_des_nro_cuenta.TabIndex = 5
        '
        'txt_des_banco
        '
        Me.txt_des_banco.Location = New System.Drawing.Point(94, 46)
        Me.txt_des_banco.Name = "txt_des_banco"
        Me.txt_des_banco.Size = New System.Drawing.Size(292, 20)
        Me.txt_des_banco.TabIndex = 4
        '
        'lbl_banco_b
        '
        Me.lbl_banco_b.AutoSize = True
        Me.lbl_banco_b.Location = New System.Drawing.Point(3, 53)
        Me.lbl_banco_b.Name = "lbl_banco_b"
        Me.lbl_banco_b.Size = New System.Drawing.Size(38, 13)
        Me.lbl_banco_b.TabIndex = 1
        Me.lbl_banco_b.Text = "Banco"
        '
        'lbl_num_cuenta_b
        '
        Me.lbl_num_cuenta_b.AutoSize = True
        Me.lbl_num_cuenta_b.Location = New System.Drawing.Point(3, 79)
        Me.lbl_num_cuenta_b.Name = "lbl_num_cuenta_b"
        Me.lbl_num_cuenta_b.Size = New System.Drawing.Size(80, 13)
        Me.lbl_num_cuenta_b.TabIndex = 2
        Me.lbl_num_cuenta_b.Text = "Numero cuenta"
        '
        'frm_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 324)
        Me.Controls.Add(Me.box_bank)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.box_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingrese datos de la cuenta"
        Me.box_cliente.ResumeLayout(False)
        Me.box_cliente.PerformLayout()
        Me.box_bank.ResumeLayout(False)
        Me.box_bank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents box_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_tipo_cuenta As System.Windows.Forms.Label
    Friend WithEvents txt_ori_nro_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents txt_ori_banco As System.Windows.Forms.TextBox
    Friend WithEvents lbl_banco As System.Windows.Forms.Label
    Friend WithEvents lbl_num_cuenta As System.Windows.Forms.Label
    Friend WithEvents box_bank As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents txt_des_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_des_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipo_cuenta_b As System.Windows.Forms.Label
    Friend WithEvents txt_des_nro_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_banco As System.Windows.Forms.TextBox
    Friend WithEvents lbl_banco_b As System.Windows.Forms.Label
    Friend WithEvents lbl_num_cuenta_b As System.Windows.Forms.Label
    Friend WithEvents txt_ori_tcuenta As System.Windows.Forms.TextBox
    Friend WithEvents txt_des_tcuenta As System.Windows.Forms.TextBox
End Class
