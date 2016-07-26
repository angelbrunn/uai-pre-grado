<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tarjeta
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
        Me.box_central = New System.Windows.Forms.GroupBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.txt_fech_venc = New System.Windows.Forms.TextBox()
        Me.lbl_banco = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.txt_cod_segu = New System.Windows.Forms.TextBox()
        Me.lbl_nrotarjeta = New System.Windows.Forms.Label()
        Me.txt_banco = New System.Windows.Forms.TextBox()
        Me.txt_nro_tarjeta = New System.Windows.Forms.TextBox()
        Me.lbl_codseguridad = New System.Windows.Forms.Label()
        Me.lbl_fechvenc = New System.Windows.Forms.Label()
        Me.box_central.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(21, 275)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 20
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'box_central
        '
        Me.box_central.Controls.Add(Me.txt_tipo)
        Me.box_central.Controls.Add(Me.txt_fech_venc)
        Me.box_central.Controls.Add(Me.lbl_banco)
        Me.box_central.Controls.Add(Me.lbl_tipo)
        Me.box_central.Controls.Add(Me.btn_validar)
        Me.box_central.Controls.Add(Me.txt_cod_segu)
        Me.box_central.Controls.Add(Me.lbl_nrotarjeta)
        Me.box_central.Controls.Add(Me.txt_banco)
        Me.box_central.Controls.Add(Me.txt_nro_tarjeta)
        Me.box_central.Controls.Add(Me.lbl_codseguridad)
        Me.box_central.Controls.Add(Me.lbl_fechvenc)
        Me.box_central.Location = New System.Drawing.Point(12, 25)
        Me.box_central.Name = "box_central"
        Me.box_central.Size = New System.Drawing.Size(392, 223)
        Me.box_central.TabIndex = 19
        Me.box_central.TabStop = False
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(283, 70)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(103, 20)
        Me.txt_tipo.TabIndex = 20
        '
        'txt_fech_venc
        '
        Me.txt_fech_venc.Location = New System.Drawing.Point(94, 152)
        Me.txt_fech_venc.Name = "txt_fech_venc"
        Me.txt_fech_venc.Size = New System.Drawing.Size(292, 20)
        Me.txt_fech_venc.TabIndex = 19
        '
        'lbl_banco
        '
        Me.lbl_banco.AutoSize = True
        Me.lbl_banco.Location = New System.Drawing.Point(46, 41)
        Me.lbl_banco.Name = "lbl_banco"
        Me.lbl_banco.Size = New System.Drawing.Size(38, 13)
        Me.lbl_banco.TabIndex = 18
        Me.lbl_banco.Text = "Banco"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(249, 77)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo.TabIndex = 12
        Me.lbl_tipo.Text = "Tipo"
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
        'txt_cod_segu
        '
        Me.txt_cod_segu.Location = New System.Drawing.Point(283, 126)
        Me.txt_cod_segu.Name = "txt_cod_segu"
        Me.txt_cod_segu.Size = New System.Drawing.Size(103, 20)
        Me.txt_cod_segu.TabIndex = 13
        '
        'lbl_nrotarjeta
        '
        Me.lbl_nrotarjeta.AutoSize = True
        Me.lbl_nrotarjeta.Location = New System.Drawing.Point(6, 107)
        Me.lbl_nrotarjeta.Name = "lbl_nrotarjeta"
        Me.lbl_nrotarjeta.Size = New System.Drawing.Size(82, 13)
        Me.lbl_nrotarjeta.TabIndex = 0
        Me.lbl_nrotarjeta.Text = "Nro de la tarjeta"
        '
        'txt_banco
        '
        Me.txt_banco.Location = New System.Drawing.Point(94, 34)
        Me.txt_banco.Name = "txt_banco"
        Me.txt_banco.Size = New System.Drawing.Size(292, 20)
        Me.txt_banco.TabIndex = 3
        '
        'txt_nro_tarjeta
        '
        Me.txt_nro_tarjeta.Location = New System.Drawing.Point(94, 100)
        Me.txt_nro_tarjeta.Name = "txt_nro_tarjeta"
        Me.txt_nro_tarjeta.Size = New System.Drawing.Size(292, 20)
        Me.txt_nro_tarjeta.TabIndex = 5
        '
        'lbl_codseguridad
        '
        Me.lbl_codseguridad.AutoSize = True
        Me.lbl_codseguridad.Location = New System.Drawing.Point(200, 133)
        Me.lbl_codseguridad.Name = "lbl_codseguridad"
        Me.lbl_codseguridad.Size = New System.Drawing.Size(77, 13)
        Me.lbl_codseguridad.TabIndex = 1
        Me.lbl_codseguridad.Text = "Cod.Seguridad"
        '
        'lbl_fechvenc
        '
        Me.lbl_fechvenc.AutoSize = True
        Me.lbl_fechvenc.Location = New System.Drawing.Point(20, 159)
        Me.lbl_fechvenc.Name = "lbl_fechvenc"
        Me.lbl_fechvenc.Size = New System.Drawing.Size(68, 13)
        Me.lbl_fechvenc.TabIndex = 2
        Me.lbl_fechvenc.Text = "Fecha Venc."
        '
        'frm_tarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 324)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.box_central)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_tarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar datos de la tarjeta"
        Me.box_central.ResumeLayout(False)
        Me.box_central.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents box_central As System.Windows.Forms.GroupBox
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents txt_cod_segu As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_nrotarjeta As System.Windows.Forms.Label
    Friend WithEvents txt_banco As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_codseguridad As System.Windows.Forms.Label
    Friend WithEvents lbl_fechvenc As System.Windows.Forms.Label
    Friend WithEvents txt_fech_venc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_banco As System.Windows.Forms.Label
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
End Class
