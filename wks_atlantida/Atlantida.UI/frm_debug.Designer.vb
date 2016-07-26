<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_debug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_debug))
        Me.btn_bitacoraCSV = New System.Windows.Forms.Button()
        Me.btn_digitoVerificador = New System.Windows.Forms.Button()
        Me.btn_consistenciaBD = New System.Windows.Forms.Button()
        Me.btn_InsertarUsuario = New System.Windows.Forms.Button()
        Me.btn_InsertarBitacora = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_bitacoraCSV
        '
        Me.btn_bitacoraCSV.Location = New System.Drawing.Point(12, 12)
        Me.btn_bitacoraCSV.Name = "btn_bitacoraCSV"
        Me.btn_bitacoraCSV.Size = New System.Drawing.Size(75, 59)
        Me.btn_bitacoraCSV.TabIndex = 0
        Me.btn_bitacoraCSV.Text = "Probar Bitacora CSV"
        Me.btn_bitacoraCSV.UseVisualStyleBackColor = True
        '
        'btn_digitoVerificador
        '
        Me.btn_digitoVerificador.Location = New System.Drawing.Point(93, 12)
        Me.btn_digitoVerificador.Name = "btn_digitoVerificador"
        Me.btn_digitoVerificador.Size = New System.Drawing.Size(75, 59)
        Me.btn_digitoVerificador.TabIndex = 1
        Me.btn_digitoVerificador.Text = "Probar Digito Verificador"
        Me.btn_digitoVerificador.UseVisualStyleBackColor = True
        '
        'btn_consistenciaBD
        '
        Me.btn_consistenciaBD.Location = New System.Drawing.Point(12, 77)
        Me.btn_consistenciaBD.Name = "btn_consistenciaBD"
        Me.btn_consistenciaBD.Size = New System.Drawing.Size(75, 59)
        Me.btn_consistenciaBD.TabIndex = 2
        Me.btn_consistenciaBD.Text = "Probar Consistencia BD"
        Me.btn_consistenciaBD.UseVisualStyleBackColor = True
        '
        'btn_InsertarUsuario
        '
        Me.btn_InsertarUsuario.Location = New System.Drawing.Point(93, 77)
        Me.btn_InsertarUsuario.Name = "btn_InsertarUsuario"
        Me.btn_InsertarUsuario.Size = New System.Drawing.Size(75, 59)
        Me.btn_InsertarUsuario.TabIndex = 3
        Me.btn_InsertarUsuario.Text = "Insertar Usuario"
        Me.btn_InsertarUsuario.UseVisualStyleBackColor = True
        '
        'btn_InsertarBitacora
        '
        Me.btn_InsertarBitacora.Location = New System.Drawing.Point(174, 12)
        Me.btn_InsertarBitacora.Name = "btn_InsertarBitacora"
        Me.btn_InsertarBitacora.Size = New System.Drawing.Size(75, 59)
        Me.btn_InsertarBitacora.TabIndex = 4
        Me.btn_InsertarBitacora.Text = "Insertar en Bitacora"
        Me.btn_InsertarBitacora.UseVisualStyleBackColor = True
        '
        'frm_debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 264)
        Me.Controls.Add(Me.btn_InsertarBitacora)
        Me.Controls.Add(Me.btn_InsertarUsuario)
        Me.Controls.Add(Me.btn_consistenciaBD)
        Me.Controls.Add(Me.btn_digitoVerificador)
        Me.Controls.Add(Me.btn_bitacoraCSV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_debug"
        Me.Text = "Depuracion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_bitacoraCSV As System.Windows.Forms.Button
    Friend WithEvents btn_digitoVerificador As System.Windows.Forms.Button
    Friend WithEvents btn_consistenciaBD As System.Windows.Forms.Button
    Friend WithEvents btn_InsertarUsuario As System.Windows.Forms.Button
    Friend WithEvents btn_InsertarBitacora As System.Windows.Forms.Button
End Class
