<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_encuesta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_encuesta))
        Me.box_encuesta = New System.Windows.Forms.GroupBox()
        Me.box_pregunta_6 = New System.Windows.Forms.GroupBox()
        Me.ck3_box6 = New System.Windows.Forms.RadioButton()
        Me.ck2_box6 = New System.Windows.Forms.RadioButton()
        Me.ck1_box6 = New System.Windows.Forms.RadioButton()
        Me.box_pregunta_4 = New System.Windows.Forms.GroupBox()
        Me.ck3_box4 = New System.Windows.Forms.RadioButton()
        Me.ck2_box4 = New System.Windows.Forms.RadioButton()
        Me.ck1_box4 = New System.Windows.Forms.RadioButton()
        Me.box_pregunta_5 = New System.Windows.Forms.GroupBox()
        Me.ck3_box5 = New System.Windows.Forms.RadioButton()
        Me.ck1_box5 = New System.Windows.Forms.RadioButton()
        Me.ck2_box5 = New System.Windows.Forms.RadioButton()
        Me.box_pregunta_3 = New System.Windows.Forms.GroupBox()
        Me.ck3_box3 = New System.Windows.Forms.RadioButton()
        Me.ck2_box3 = New System.Windows.Forms.RadioButton()
        Me.ck1_box3 = New System.Windows.Forms.RadioButton()
        Me.box_pregunta_2 = New System.Windows.Forms.GroupBox()
        Me.ck3_box2 = New System.Windows.Forms.RadioButton()
        Me.ck2_box2 = New System.Windows.Forms.RadioButton()
        Me.ck1_box2 = New System.Windows.Forms.RadioButton()
        Me.box_pregunta_1 = New System.Windows.Forms.GroupBox()
        Me.ck3_box1 = New System.Windows.Forms.RadioButton()
        Me.ck2_box1 = New System.Windows.Forms.RadioButton()
        Me.ck1_box1 = New System.Windows.Forms.RadioButton()
        Me.box_cliente = New System.Windows.Forms.GroupBox()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.box_guardar_enc = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.box_encuesta.SuspendLayout()
        Me.box_pregunta_6.SuspendLayout()
        Me.box_pregunta_4.SuspendLayout()
        Me.box_pregunta_5.SuspendLayout()
        Me.box_pregunta_3.SuspendLayout()
        Me.box_pregunta_2.SuspendLayout()
        Me.box_pregunta_1.SuspendLayout()
        Me.box_cliente.SuspendLayout()
        Me.box_guardar_enc.SuspendLayout()
        Me.SuspendLayout()
        '
        'box_encuesta
        '
        Me.box_encuesta.Controls.Add(Me.box_pregunta_6)
        Me.box_encuesta.Controls.Add(Me.box_pregunta_4)
        Me.box_encuesta.Controls.Add(Me.box_pregunta_5)
        Me.box_encuesta.Controls.Add(Me.box_pregunta_3)
        Me.box_encuesta.Controls.Add(Me.box_pregunta_2)
        Me.box_encuesta.Controls.Add(Me.box_pregunta_1)
        Me.box_encuesta.Location = New System.Drawing.Point(14, 12)
        Me.box_encuesta.Name = "box_encuesta"
        Me.box_encuesta.Size = New System.Drawing.Size(884, 364)
        Me.box_encuesta.TabIndex = 2
        Me.box_encuesta.TabStop = False
        Me.box_encuesta.Text = "Encuesta pasajes"
        '
        'box_pregunta_6
        '
        Me.box_pregunta_6.Controls.Add(Me.ck3_box6)
        Me.box_pregunta_6.Controls.Add(Me.ck2_box6)
        Me.box_pregunta_6.Controls.Add(Me.ck1_box6)
        Me.box_pregunta_6.Location = New System.Drawing.Point(592, 197)
        Me.box_pregunta_6.Name = "box_pregunta_6"
        Me.box_pregunta_6.Size = New System.Drawing.Size(276, 155)
        Me.box_pregunta_6.TabIndex = 7
        Me.box_pregunta_6.TabStop = False
        Me.box_pregunta_6.Text = "Tuvo inconvenientes a la hora de la acreditacion?"
        '
        'ck3_box6
        '
        Me.ck3_box6.AutoSize = True
        Me.ck3_box6.Location = New System.Drawing.Point(88, 105)
        Me.ck3_box6.Name = "ck3_box6"
        Me.ck3_box6.Size = New System.Drawing.Size(124, 17)
        Me.ck3_box6.TabIndex = 2
        Me.ck3_box6.TabStop = True
        Me.ck3_box6.Text = "No pude acreditarme"
        Me.ck3_box6.UseVisualStyleBackColor = True
        '
        'ck2_box6
        '
        Me.ck2_box6.AutoSize = True
        Me.ck2_box6.Location = New System.Drawing.Point(88, 68)
        Me.ck2_box6.Name = "ck2_box6"
        Me.ck2_box6.Size = New System.Drawing.Size(166, 17)
        Me.ck2_box6.TabIndex = 1
        Me.ck2_box6.TabStop = True
        Me.ck2_box6.Text = "Tardaron, pero todo salio bien"
        Me.ck2_box6.UseVisualStyleBackColor = True
        '
        'ck1_box6
        '
        Me.ck1_box6.AutoSize = True
        Me.ck1_box6.Location = New System.Drawing.Point(88, 36)
        Me.ck1_box6.Name = "ck1_box6"
        Me.ck1_box6.Size = New System.Drawing.Size(115, 17)
        Me.ck1_box6.TabIndex = 0
        Me.ck1_box6.TabStop = True
        Me.ck1_box6.Text = "No hubo problema!"
        Me.ck1_box6.UseVisualStyleBackColor = True
        '
        'box_pregunta_4
        '
        Me.box_pregunta_4.Controls.Add(Me.ck3_box4)
        Me.box_pregunta_4.Controls.Add(Me.ck2_box4)
        Me.box_pregunta_4.Controls.Add(Me.ck1_box4)
        Me.box_pregunta_4.Location = New System.Drawing.Point(16, 197)
        Me.box_pregunta_4.Name = "box_pregunta_4"
        Me.box_pregunta_4.Size = New System.Drawing.Size(276, 155)
        Me.box_pregunta_4.TabIndex = 5
        Me.box_pregunta_4.TabStop = False
        Me.box_pregunta_4.Text = "volveria a comprar el servicio de pasaje?"
        '
        'ck3_box4
        '
        Me.ck3_box4.AutoSize = True
        Me.ck3_box4.Location = New System.Drawing.Point(88, 105)
        Me.ck3_box4.Name = "ck3_box4"
        Me.ck3_box4.Size = New System.Drawing.Size(39, 17)
        Me.ck3_box4.TabIndex = 2
        Me.ck3_box4.TabStop = True
        Me.ck3_box4.Text = "No"
        Me.ck3_box4.UseVisualStyleBackColor = True
        '
        'ck2_box4
        '
        Me.ck2_box4.AutoSize = True
        Me.ck2_box4.Location = New System.Drawing.Point(88, 68)
        Me.ck2_box4.Name = "ck2_box4"
        Me.ck2_box4.Size = New System.Drawing.Size(64, 17)
        Me.ck2_box4.TabIndex = 1
        Me.ck2_box4.TabStop = True
        Me.ck2_box4.Text = "No lo se"
        Me.ck2_box4.UseVisualStyleBackColor = True
        '
        'ck1_box4
        '
        Me.ck1_box4.AutoSize = True
        Me.ck1_box4.Location = New System.Drawing.Point(88, 36)
        Me.ck1_box4.Name = "ck1_box4"
        Me.ck1_box4.Size = New System.Drawing.Size(72, 17)
        Me.ck1_box4.TabIndex = 0
        Me.ck1_box4.TabStop = True
        Me.ck1_box4.Text = "Si,seguro!"
        Me.ck1_box4.UseVisualStyleBackColor = True
        '
        'box_pregunta_5
        '
        Me.box_pregunta_5.Controls.Add(Me.ck3_box5)
        Me.box_pregunta_5.Controls.Add(Me.ck1_box5)
        Me.box_pregunta_5.Controls.Add(Me.ck2_box5)
        Me.box_pregunta_5.Location = New System.Drawing.Point(310, 197)
        Me.box_pregunta_5.Name = "box_pregunta_5"
        Me.box_pregunta_5.Size = New System.Drawing.Size(276, 155)
        Me.box_pregunta_5.TabIndex = 6
        Me.box_pregunta_5.TabStop = False
        Me.box_pregunta_5.Text = "cual es su grado de satisfaccion con el vendedor?"
        '
        'ck3_box5
        '
        Me.ck3_box5.AutoSize = True
        Me.ck3_box5.Location = New System.Drawing.Point(88, 105)
        Me.ck3_box5.Name = "ck3_box5"
        Me.ck3_box5.Size = New System.Drawing.Size(109, 17)
        Me.ck3_box5.TabIndex = 5
        Me.ck3_box5.TabStop = True
        Me.ck3_box5.Text = "Poca satisfactoria"
        Me.ck3_box5.UseVisualStyleBackColor = True
        '
        'ck1_box5
        '
        Me.ck1_box5.AutoSize = True
        Me.ck1_box5.Location = New System.Drawing.Point(88, 36)
        Me.ck1_box5.Name = "ck1_box5"
        Me.ck1_box5.Size = New System.Drawing.Size(72, 17)
        Me.ck1_box5.TabIndex = 3
        Me.ck1_box5.TabStop = True
        Me.ck1_box5.Text = "Excelente"
        Me.ck1_box5.UseVisualStyleBackColor = True
        '
        'ck2_box5
        '
        Me.ck2_box5.AutoSize = True
        Me.ck2_box5.Location = New System.Drawing.Point(88, 68)
        Me.ck2_box5.Name = "ck2_box5"
        Me.ck2_box5.Size = New System.Drawing.Size(56, 17)
        Me.ck2_box5.TabIndex = 4
        Me.ck2_box5.TabStop = True
        Me.ck2_box5.Text = "Buena"
        Me.ck2_box5.UseVisualStyleBackColor = True
        '
        'box_pregunta_3
        '
        Me.box_pregunta_3.Controls.Add(Me.ck3_box3)
        Me.box_pregunta_3.Controls.Add(Me.ck2_box3)
        Me.box_pregunta_3.Controls.Add(Me.ck1_box3)
        Me.box_pregunta_3.Location = New System.Drawing.Point(592, 36)
        Me.box_pregunta_3.Name = "box_pregunta_3"
        Me.box_pregunta_3.Size = New System.Drawing.Size(276, 155)
        Me.box_pregunta_3.TabIndex = 4
        Me.box_pregunta_3.TabStop = False
        Me.box_pregunta_3.Text = "Cual es su grado de satisfaccion con el servicios?"
        '
        'ck3_box3
        '
        Me.ck3_box3.AutoSize = True
        Me.ck3_box3.Location = New System.Drawing.Point(88, 105)
        Me.ck3_box3.Name = "ck3_box3"
        Me.ck3_box3.Size = New System.Drawing.Size(109, 17)
        Me.ck3_box3.TabIndex = 2
        Me.ck3_box3.TabStop = True
        Me.ck3_box3.Text = "Poca satisfactoria"
        Me.ck3_box3.UseVisualStyleBackColor = True
        '
        'ck2_box3
        '
        Me.ck2_box3.AutoSize = True
        Me.ck2_box3.Location = New System.Drawing.Point(88, 68)
        Me.ck2_box3.Name = "ck2_box3"
        Me.ck2_box3.Size = New System.Drawing.Size(56, 17)
        Me.ck2_box3.TabIndex = 1
        Me.ck2_box3.TabStop = True
        Me.ck2_box3.Text = "Buena"
        Me.ck2_box3.UseVisualStyleBackColor = True
        '
        'ck1_box3
        '
        Me.ck1_box3.AutoSize = True
        Me.ck1_box3.Location = New System.Drawing.Point(88, 36)
        Me.ck1_box3.Name = "ck1_box3"
        Me.ck1_box3.Size = New System.Drawing.Size(72, 17)
        Me.ck1_box3.TabIndex = 0
        Me.ck1_box3.TabStop = True
        Me.ck1_box3.Text = "Excelente"
        Me.ck1_box3.UseVisualStyleBackColor = True
        '
        'box_pregunta_2
        '
        Me.box_pregunta_2.Controls.Add(Me.ck3_box2)
        Me.box_pregunta_2.Controls.Add(Me.ck2_box2)
        Me.box_pregunta_2.Controls.Add(Me.ck1_box2)
        Me.box_pregunta_2.Location = New System.Drawing.Point(310, 36)
        Me.box_pregunta_2.Name = "box_pregunta_2"
        Me.box_pregunta_2.Size = New System.Drawing.Size(276, 155)
        Me.box_pregunta_2.TabIndex = 3
        Me.box_pregunta_2.TabStop = False
        Me.box_pregunta_2.Text = "Cuantas compras hizo con nosotros?"
        '
        'ck3_box2
        '
        Me.ck3_box2.AutoSize = True
        Me.ck3_box2.Location = New System.Drawing.Point(88, 105)
        Me.ck3_box2.Name = "ck3_box2"
        Me.ck3_box2.Size = New System.Drawing.Size(68, 17)
        Me.ck3_box2.TabIndex = 2
        Me.ck3_box2.TabStop = True
        Me.ck3_box2.Text = "mas de 5"
        Me.ck3_box2.UseVisualStyleBackColor = True
        '
        'ck2_box2
        '
        Me.ck2_box2.AutoSize = True
        Me.ck2_box2.Location = New System.Drawing.Point(88, 68)
        Me.ck2_box2.Name = "ck2_box2"
        Me.ck2_box2.Size = New System.Drawing.Size(80, 17)
        Me.ck2_box2.TabIndex = 1
        Me.ck2_box2.TabStop = True
        Me.ck2_box2.Text = "menos de 5"
        Me.ck2_box2.UseVisualStyleBackColor = True
        '
        'ck1_box2
        '
        Me.ck1_box2.AutoSize = True
        Me.ck1_box2.Location = New System.Drawing.Point(88, 36)
        Me.ck1_box2.Name = "ck1_box2"
        Me.ck1_box2.Size = New System.Drawing.Size(65, 17)
        Me.ck1_box2.TabIndex = 0
        Me.ck1_box2.TabStop = True
        Me.ck1_box2.Text = "solo una"
        Me.ck1_box2.UseVisualStyleBackColor = True
        '
        'box_pregunta_1
        '
        Me.box_pregunta_1.Controls.Add(Me.ck3_box1)
        Me.box_pregunta_1.Controls.Add(Me.ck2_box1)
        Me.box_pregunta_1.Controls.Add(Me.ck1_box1)
        Me.box_pregunta_1.Location = New System.Drawing.Point(16, 36)
        Me.box_pregunta_1.Name = "box_pregunta_1"
        Me.box_pregunta_1.Size = New System.Drawing.Size(276, 155)
        Me.box_pregunta_1.TabIndex = 0
        Me.box_pregunta_1.TabStop = False
        Me.box_pregunta_1.Text = "Obtuvo  la disponibilidad que deseaba?"
        '
        'ck3_box1
        '
        Me.ck3_box1.AutoSize = True
        Me.ck3_box1.Location = New System.Drawing.Point(88, 105)
        Me.ck3_box1.Name = "ck3_box1"
        Me.ck3_box1.Size = New System.Drawing.Size(39, 17)
        Me.ck3_box1.TabIndex = 2
        Me.ck3_box1.TabStop = True
        Me.ck3_box1.Text = "No"
        Me.ck3_box1.UseVisualStyleBackColor = True
        '
        'ck2_box1
        '
        Me.ck2_box1.AutoSize = True
        Me.ck2_box1.Location = New System.Drawing.Point(88, 68)
        Me.ck2_box1.Name = "ck2_box1"
        Me.ck2_box1.Size = New System.Drawing.Size(177, 17)
        Me.ck2_box1.TabIndex = 1
        Me.ck2_box1.TabStop = True
        Me.ck2_box1.Text = "Tuve que mover fecha u horario"
        Me.ck2_box1.UseVisualStyleBackColor = True
        '
        'ck1_box1
        '
        Me.ck1_box1.AutoSize = True
        Me.ck1_box1.Location = New System.Drawing.Point(88, 36)
        Me.ck1_box1.Name = "ck1_box1"
        Me.ck1_box1.Size = New System.Drawing.Size(34, 17)
        Me.ck1_box1.TabIndex = 0
        Me.ck1_box1.TabStop = True
        Me.ck1_box1.Text = "Si"
        Me.ck1_box1.UseVisualStyleBackColor = True
        '
        'box_cliente
        '
        Me.box_cliente.Controls.Add(Me.btn_validar)
        Me.box_cliente.Controls.Add(Me.txt_cliente)
        Me.box_cliente.Location = New System.Drawing.Point(14, 382)
        Me.box_cliente.Name = "box_cliente"
        Me.box_cliente.Size = New System.Drawing.Size(586, 68)
        Me.box_cliente.TabIndex = 8
        Me.box_cliente.TabStop = False
        Me.box_cliente.Text = "Cliente"
        '
        'btn_validar
        '
        Me.btn_validar.Location = New System.Drawing.Point(486, 19)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(94, 36)
        Me.btn_validar.TabIndex = 3
        Me.btn_validar.Text = "Validar"
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(16, 29)
        Me.txt_cliente.Multiline = True
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(376, 26)
        Me.txt_cliente.TabIndex = 21
        '
        'box_guardar_enc
        '
        Me.box_guardar_enc.Controls.Add(Me.btn_guardar)
        Me.box_guardar_enc.Location = New System.Drawing.Point(606, 382)
        Me.box_guardar_enc.Name = "box_guardar_enc"
        Me.box_guardar_enc.Size = New System.Drawing.Size(292, 68)
        Me.box_guardar_enc.TabIndex = 9
        Me.box_guardar_enc.TabStop = False
        Me.box_guardar_enc.Text = "Guardar Encuesta"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(182, 20)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(94, 36)
        Me.btn_guardar.TabIndex = 2
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'frm_encuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 473)
        Me.Controls.Add(Me.box_guardar_enc)
        Me.Controls.Add(Me.box_cliente)
        Me.Controls.Add(Me.box_encuesta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_encuesta"
        Me.Text = "Encuesta"
        Me.box_encuesta.ResumeLayout(False)
        Me.box_pregunta_6.ResumeLayout(False)
        Me.box_pregunta_6.PerformLayout()
        Me.box_pregunta_4.ResumeLayout(False)
        Me.box_pregunta_4.PerformLayout()
        Me.box_pregunta_5.ResumeLayout(False)
        Me.box_pregunta_5.PerformLayout()
        Me.box_pregunta_3.ResumeLayout(False)
        Me.box_pregunta_3.PerformLayout()
        Me.box_pregunta_2.ResumeLayout(False)
        Me.box_pregunta_2.PerformLayout()
        Me.box_pregunta_1.ResumeLayout(False)
        Me.box_pregunta_1.PerformLayout()
        Me.box_cliente.ResumeLayout(False)
        Me.box_cliente.PerformLayout()
        Me.box_guardar_enc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents box_encuesta As System.Windows.Forms.GroupBox
    Friend WithEvents box_pregunta_6 As System.Windows.Forms.GroupBox
    Friend WithEvents ck3_box6 As System.Windows.Forms.RadioButton
    Friend WithEvents ck2_box6 As System.Windows.Forms.RadioButton
    Friend WithEvents ck1_box6 As System.Windows.Forms.RadioButton
    Friend WithEvents box_pregunta_4 As System.Windows.Forms.GroupBox
    Friend WithEvents ck3_box4 As System.Windows.Forms.RadioButton
    Friend WithEvents ck2_box4 As System.Windows.Forms.RadioButton
    Friend WithEvents ck1_box4 As System.Windows.Forms.RadioButton
    Friend WithEvents box_pregunta_5 As System.Windows.Forms.GroupBox
    Friend WithEvents ck3_box5 As System.Windows.Forms.RadioButton
    Friend WithEvents ck1_box5 As System.Windows.Forms.RadioButton
    Friend WithEvents ck2_box5 As System.Windows.Forms.RadioButton
    Friend WithEvents box_pregunta_3 As System.Windows.Forms.GroupBox
    Friend WithEvents ck3_box3 As System.Windows.Forms.RadioButton
    Friend WithEvents ck2_box3 As System.Windows.Forms.RadioButton
    Friend WithEvents ck1_box3 As System.Windows.Forms.RadioButton
    Friend WithEvents box_pregunta_2 As System.Windows.Forms.GroupBox
    Friend WithEvents ck3_box2 As System.Windows.Forms.RadioButton
    Friend WithEvents ck2_box2 As System.Windows.Forms.RadioButton
    Friend WithEvents ck1_box2 As System.Windows.Forms.RadioButton
    Friend WithEvents box_pregunta_1 As System.Windows.Forms.GroupBox
    Friend WithEvents ck3_box1 As System.Windows.Forms.RadioButton
    Friend WithEvents ck2_box1 As System.Windows.Forms.RadioButton
    Friend WithEvents ck1_box1 As System.Windows.Forms.RadioButton
    Friend WithEvents box_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents box_guardar_enc As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
End Class
