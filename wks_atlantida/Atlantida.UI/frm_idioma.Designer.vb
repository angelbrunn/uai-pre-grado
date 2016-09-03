<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_idioma
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
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lstbx_chIdioma = New System.Windows.Forms.ListBox()
        Me.lbl_chIdioma = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Location = New System.Drawing.Point(12, 58)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(84, 34)
        Me.btn_seleccionar.TabIndex = 1
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(135, 58)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(84, 34)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lstbx_chIdioma
        '
        Me.lstbx_chIdioma.FormattingEnabled = True
        Me.lstbx_chIdioma.Location = New System.Drawing.Point(102, 12)
        Me.lstbx_chIdioma.Name = "lstbx_chIdioma"
        Me.lstbx_chIdioma.Size = New System.Drawing.Size(120, 30)
        Me.lstbx_chIdioma.TabIndex = 3
        '
        'lbl_chIdioma
        '
        Me.lbl_chIdioma.AutoSize = True
        Me.lbl_chIdioma.Location = New System.Drawing.Point(12, 12)
        Me.lbl_chIdioma.Name = "lbl_chIdioma"
        Me.lbl_chIdioma.Size = New System.Drawing.Size(67, 13)
        Me.lbl_chIdioma.TabIndex = 4
        Me.lbl_chIdioma.Text = "Elegir Idioma"
        '
        'frm_idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 104)
        Me.Controls.Add(Me.lbl_chIdioma)
        Me.Controls.Add(Me.lstbx_chIdioma)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Name = "frm_idioma"
        Me.Text = "frm_idioma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lstbx_chIdioma As System.Windows.Forms.ListBox
    Friend WithEvents lbl_chIdioma As System.Windows.Forms.Label
End Class
