<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PaqueteNoPromocionable
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
        Me.dgw_PaqNotProm = New System.Windows.Forms.DataGridView()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.dgw_PaqNotProm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgw_PaqNotProm
        '
        Me.dgw_PaqNotProm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_PaqNotProm.Location = New System.Drawing.Point(12, 12)
        Me.dgw_PaqNotProm.Name = "dgw_PaqNotProm"
        Me.dgw_PaqNotProm.Size = New System.Drawing.Size(641, 183)
        Me.dgw_PaqNotProm.TabIndex = 0
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Location = New System.Drawing.Point(12, 201)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(91, 50)
        Me.btn_seleccionar.TabIndex = 1
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(562, 201)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(91, 50)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_PaqueteNoPromocionable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 263)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.dgw_PaqNotProm)
        Me.Name = "frm_PaqueteNoPromocionable"
        Me.Text = "frm_PaqueteNoPromocionable"
        CType(Me.dgw_PaqNotProm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgw_PaqNotProm As System.Windows.Forms.DataGridView
    Friend WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
