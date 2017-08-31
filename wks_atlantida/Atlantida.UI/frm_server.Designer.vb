<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_server
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_server))
        Me.txt_servidor = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_servidor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_servidor
        '
        Me.txt_servidor.Location = New System.Drawing.Point(100, 15)
        Me.txt_servidor.Name = "txt_servidor"
        Me.txt_servidor.Size = New System.Drawing.Size(131, 20)
        Me.txt_servidor.TabIndex = 0
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(12, 73)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(96, 23)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar/save"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(135, 73)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(96, 23)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir/Exit"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl_servidor
        '
        Me.lbl_servidor.AutoSize = True
        Me.lbl_servidor.Location = New System.Drawing.Point(9, 22)
        Me.lbl_servidor.Name = "lbl_servidor"
        Me.lbl_servidor.Size = New System.Drawing.Size(82, 13)
        Me.lbl_servidor.TabIndex = 3
        Me.lbl_servidor.Text = "Servidor/Server"
        '
        'frm_server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 108)
        Me.Controls.Add(Me.lbl_servidor)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_servidor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_server"
        Me.Text = "Servidor/Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_servidor As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_servidor As System.Windows.Forms.Label
End Class
