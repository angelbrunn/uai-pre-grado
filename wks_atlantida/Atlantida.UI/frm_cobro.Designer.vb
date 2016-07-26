<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cobro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cobro))
        Me.box_central = New System.Windows.Forms.GroupBox()
        Me.box_sena = New System.Windows.Forms.GroupBox()
        Me.btn_sena = New System.Windows.Forms.Button()
        Me.txt_sena = New System.Windows.Forms.TextBox()
        Me.btn_imprimir_voucher = New System.Windows.Forms.Button()
        Me.btn_ConfirmarComprobantes = New System.Windows.Forms.Button()
        Me.box_cliente_deuda = New System.Windows.Forms.GroupBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.lbl_dni = New System.Windows.Forms.Label()
        Me.box_formulario_pago = New System.Windows.Forms.GroupBox()
        Me.ChkPagoToT = New System.Windows.Forms.CheckBox()
        Me.ChkReserva = New System.Windows.Forms.CheckBox()
        Me.btn_pagar = New System.Windows.Forms.Button()
        Me.lbl_dato_cuenta = New System.Windows.Forms.Label()
        Me.txt_cuenta = New System.Windows.Forms.TextBox()
        Me.lbl_datos_tarjeta = New System.Windows.Forms.Label()
        Me.txt_tarjeta = New System.Windows.Forms.TextBox()
        Me.rdio_cuota = New System.Windows.Forms.RadioButton()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_forma_pago = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.box_resultado_deuda = New System.Windows.Forms.GroupBox()
        Me.list_result_deuda = New System.Windows.Forms.ListView()
        Me.box_central.SuspendLayout()
        Me.box_sena.SuspendLayout()
        Me.box_cliente_deuda.SuspendLayout()
        Me.box_formulario_pago.SuspendLayout()
        Me.box_resultado_deuda.SuspendLayout()
        Me.SuspendLayout()
        '
        'box_central
        '
        Me.box_central.Controls.Add(Me.box_sena)
        Me.box_central.Controls.Add(Me.btn_imprimir_voucher)
        Me.box_central.Controls.Add(Me.btn_ConfirmarComprobantes)
        Me.box_central.Controls.Add(Me.box_cliente_deuda)
        Me.box_central.Controls.Add(Me.box_formulario_pago)
        Me.box_central.Controls.Add(Me.box_resultado_deuda)
        Me.box_central.Location = New System.Drawing.Point(11, 12)
        Me.box_central.Name = "box_central"
        Me.box_central.Size = New System.Drawing.Size(816, 462)
        Me.box_central.TabIndex = 1
        Me.box_central.TabStop = False
        '
        'box_sena
        '
        Me.box_sena.Controls.Add(Me.btn_sena)
        Me.box_sena.Controls.Add(Me.txt_sena)
        Me.box_sena.Location = New System.Drawing.Point(7, 138)
        Me.box_sena.Name = "box_sena"
        Me.box_sena.Size = New System.Drawing.Size(392, 75)
        Me.box_sena.TabIndex = 28
        Me.box_sena.TabStop = False
        Me.box_sena.Text = "Seña"
        '
        'btn_sena
        '
        Me.btn_sena.Location = New System.Drawing.Point(9, 19)
        Me.btn_sena.Name = "btn_sena"
        Me.btn_sena.Size = New System.Drawing.Size(75, 32)
        Me.btn_sena.TabIndex = 1
        Me.btn_sena.Text = "Calcular"
        Me.btn_sena.UseVisualStyleBackColor = True
        '
        'txt_sena
        '
        Me.txt_sena.Location = New System.Drawing.Point(188, 19)
        Me.txt_sena.Name = "txt_sena"
        Me.txt_sena.Size = New System.Drawing.Size(198, 20)
        Me.txt_sena.TabIndex = 0
        '
        'btn_imprimir_voucher
        '
        Me.btn_imprimir_voucher.Location = New System.Drawing.Point(109, 219)
        Me.btn_imprimir_voucher.Name = "btn_imprimir_voucher"
        Me.btn_imprimir_voucher.Size = New System.Drawing.Size(90, 45)
        Me.btn_imprimir_voucher.TabIndex = 25
        Me.btn_imprimir_voucher.Text = "Imprimir voucher"
        Me.btn_imprimir_voucher.UseVisualStyleBackColor = True
        '
        'btn_ConfirmarComprobantes
        '
        Me.btn_ConfirmarComprobantes.Location = New System.Drawing.Point(13, 219)
        Me.btn_ConfirmarComprobantes.Name = "btn_ConfirmarComprobantes"
        Me.btn_ConfirmarComprobantes.Size = New System.Drawing.Size(90, 45)
        Me.btn_ConfirmarComprobantes.TabIndex = 26
        Me.btn_ConfirmarComprobantes.Text = "Conf.Comprobante"
        Me.btn_ConfirmarComprobantes.UseVisualStyleBackColor = True
        '
        'box_cliente_deuda
        '
        Me.box_cliente_deuda.Controls.Add(Me.txt_cliente)
        Me.box_cliente_deuda.Controls.Add(Me.btn_validar)
        Me.box_cliente_deuda.Controls.Add(Me.lbl_dni)
        Me.box_cliente_deuda.Location = New System.Drawing.Point(7, 18)
        Me.box_cliente_deuda.Name = "box_cliente_deuda"
        Me.box_cliente_deuda.Size = New System.Drawing.Size(392, 114)
        Me.box_cliente_deuda.TabIndex = 18
        Me.box_cliente_deuda.TabStop = False
        Me.box_cliente_deuda.Text = "Validar deuda cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(90, 38)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(296, 20)
        Me.txt_cliente.TabIndex = 19
        '
        'btn_validar
        '
        Me.btn_validar.Location = New System.Drawing.Point(90, 67)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(75, 30)
        Me.btn_validar.TabIndex = 14
        Me.btn_validar.Text = "Validar"
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'lbl_dni
        '
        Me.lbl_dni.AutoSize = True
        Me.lbl_dni.Location = New System.Drawing.Point(6, 41)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(44, 13)
        Me.lbl_dni.TabIndex = 0
        Me.lbl_dni.Text = "Nro dni "
        '
        'box_formulario_pago
        '
        Me.box_formulario_pago.Controls.Add(Me.ChkPagoToT)
        Me.box_formulario_pago.Controls.Add(Me.ChkReserva)
        Me.box_formulario_pago.Controls.Add(Me.btn_pagar)
        Me.box_formulario_pago.Controls.Add(Me.lbl_dato_cuenta)
        Me.box_formulario_pago.Controls.Add(Me.txt_cuenta)
        Me.box_formulario_pago.Controls.Add(Me.lbl_datos_tarjeta)
        Me.box_formulario_pago.Controls.Add(Me.txt_tarjeta)
        Me.box_formulario_pago.Controls.Add(Me.rdio_cuota)
        Me.box_formulario_pago.Controls.Add(Me.lbl_cantidad)
        Me.box_formulario_pago.Controls.Add(Me.ComboBox1)
        Me.box_formulario_pago.Controls.Add(Me.lbl_forma_pago)
        Me.box_formulario_pago.Controls.Add(Me.ComboBox2)
        Me.box_formulario_pago.Controls.Add(Me.lbl_importe)
        Me.box_formulario_pago.Controls.Add(Me.txt_importe)
        Me.box_formulario_pago.Location = New System.Drawing.Point(405, 19)
        Me.box_formulario_pago.Name = "box_formulario_pago"
        Me.box_formulario_pago.Size = New System.Drawing.Size(405, 245)
        Me.box_formulario_pago.TabIndex = 17
        Me.box_formulario_pago.TabStop = False
        Me.box_formulario_pago.Text = "Formulario de pago"
        '
        'ChkPagoToT
        '
        Me.ChkPagoToT.AutoSize = True
        Me.ChkPagoToT.Location = New System.Drawing.Point(188, 199)
        Me.ChkPagoToT.Name = "ChkPagoToT"
        Me.ChkPagoToT.Size = New System.Drawing.Size(50, 17)
        Me.ChkPagoToT.TabIndex = 26
        Me.ChkPagoToT.Text = "Total"
        Me.ChkPagoToT.UseVisualStyleBackColor = True
        '
        'ChkReserva
        '
        Me.ChkReserva.AutoSize = True
        Me.ChkReserva.Location = New System.Drawing.Point(188, 222)
        Me.ChkReserva.Name = "ChkReserva"
        Me.ChkReserva.Size = New System.Drawing.Size(66, 17)
        Me.ChkReserva.TabIndex = 25
        Me.ChkReserva.Text = "Reserva"
        Me.ChkReserva.UseVisualStyleBackColor = True
        '
        'btn_pagar
        '
        Me.btn_pagar.Location = New System.Drawing.Point(107, 200)
        Me.btn_pagar.Name = "btn_pagar"
        Me.btn_pagar.Size = New System.Drawing.Size(75, 30)
        Me.btn_pagar.TabIndex = 24
        Me.btn_pagar.Text = "Pagar"
        Me.btn_pagar.UseVisualStyleBackColor = True
        '
        'lbl_dato_cuenta
        '
        Me.lbl_dato_cuenta.AutoSize = True
        Me.lbl_dato_cuenta.Location = New System.Drawing.Point(3, 155)
        Me.lbl_dato_cuenta.Name = "lbl_dato_cuenta"
        Me.lbl_dato_cuenta.Size = New System.Drawing.Size(97, 13)
        Me.lbl_dato_cuenta.TabIndex = 23
        Me.lbl_dato_cuenta.Text = "Datos de la cuenta"
        '
        'txt_cuenta
        '
        Me.txt_cuenta.Location = New System.Drawing.Point(107, 148)
        Me.txt_cuenta.Name = "txt_cuenta"
        Me.txt_cuenta.Size = New System.Drawing.Size(292, 20)
        Me.txt_cuenta.TabIndex = 22
        '
        'lbl_datos_tarjeta
        '
        Me.lbl_datos_tarjeta.AutoSize = True
        Me.lbl_datos_tarjeta.Location = New System.Drawing.Point(7, 129)
        Me.lbl_datos_tarjeta.Name = "lbl_datos_tarjeta"
        Me.lbl_datos_tarjeta.Size = New System.Drawing.Size(93, 13)
        Me.lbl_datos_tarjeta.TabIndex = 21
        Me.lbl_datos_tarjeta.Text = "Datos de la tarjeta"
        '
        'txt_tarjeta
        '
        Me.txt_tarjeta.Location = New System.Drawing.Point(107, 122)
        Me.txt_tarjeta.Name = "txt_tarjeta"
        Me.txt_tarjeta.Size = New System.Drawing.Size(292, 20)
        Me.txt_tarjeta.TabIndex = 20
        '
        'rdio_cuota
        '
        Me.rdio_cuota.AutoSize = True
        Me.rdio_cuota.Location = New System.Drawing.Point(110, 69)
        Me.rdio_cuota.Name = "rdio_cuota"
        Me.rdio_cuota.Size = New System.Drawing.Size(64, 17)
        Me.rdio_cuota.TabIndex = 19
        Me.rdio_cuota.TabStop = True
        Me.rdio_cuota.Text = "Coutas?"
        Me.rdio_cuota.UseVisualStyleBackColor = True
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(268, 73)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 18
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(323, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(76, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'lbl_forma_pago
        '
        Me.lbl_forma_pago.AutoSize = True
        Me.lbl_forma_pago.Location = New System.Drawing.Point(22, 44)
        Me.lbl_forma_pago.Name = "lbl_forma_pago"
        Me.lbl_forma_pago.Size = New System.Drawing.Size(78, 13)
        Me.lbl_forma_pago.TabIndex = 16
        Me.lbl_forma_pago.Text = "Forma de pago"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(110, 36)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(289, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Location = New System.Drawing.Point(58, 181)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(42, 13)
        Me.lbl_importe.TabIndex = 0
        Me.lbl_importe.Text = "Importe"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(107, 174)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(292, 20)
        Me.txt_importe.TabIndex = 3
        '
        'box_resultado_deuda
        '
        Me.box_resultado_deuda.Controls.Add(Me.list_result_deuda)
        Me.box_resultado_deuda.Location = New System.Drawing.Point(7, 270)
        Me.box_resultado_deuda.Name = "box_resultado_deuda"
        Me.box_resultado_deuda.Size = New System.Drawing.Size(804, 184)
        Me.box_resultado_deuda.TabIndex = 9
        Me.box_resultado_deuda.TabStop = False
        Me.box_resultado_deuda.Text = "Resultado deuda"
        '
        'list_result_deuda
        '
        Me.list_result_deuda.Location = New System.Drawing.Point(6, 19)
        Me.list_result_deuda.Name = "list_result_deuda"
        Me.list_result_deuda.Size = New System.Drawing.Size(792, 157)
        Me.list_result_deuda.TabIndex = 1
        Me.list_result_deuda.UseCompatibleStateImageBehavior = False
        '
        'frm_cobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 487)
        Me.Controls.Add(Me.box_central)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cobro"
        Me.Text = "Cobro"
        Me.box_central.ResumeLayout(False)
        Me.box_sena.ResumeLayout(False)
        Me.box_sena.PerformLayout()
        Me.box_cliente_deuda.ResumeLayout(False)
        Me.box_cliente_deuda.PerformLayout()
        Me.box_formulario_pago.ResumeLayout(False)
        Me.box_formulario_pago.PerformLayout()
        Me.box_resultado_deuda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents box_central As System.Windows.Forms.GroupBox
    Friend WithEvents box_formulario_pago As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_forma_pago As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_importe As System.Windows.Forms.Label
    Friend WithEvents txt_importe As System.Windows.Forms.TextBox
    Friend WithEvents box_resultado_deuda As System.Windows.Forms.GroupBox
    Friend WithEvents list_result_deuda As System.Windows.Forms.ListView
    Friend WithEvents box_cliente_deuda As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents lbl_dni As System.Windows.Forms.Label
    Friend WithEvents rdio_cuota As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_imprimir_voucher As System.Windows.Forms.Button
    Friend WithEvents btn_pagar As System.Windows.Forms.Button
    Friend WithEvents lbl_dato_cuenta As System.Windows.Forms.Label
    Friend WithEvents txt_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_datos_tarjeta As System.Windows.Forms.Label
    Friend WithEvents txt_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents btn_ConfirmarComprobantes As System.Windows.Forms.Button
    Friend WithEvents box_sena As System.Windows.Forms.GroupBox
    Friend WithEvents btn_sena As System.Windows.Forms.Button
    Friend WithEvents txt_sena As System.Windows.Forms.TextBox
    Friend WithEvents ChkPagoToT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkReserva As System.Windows.Forms.CheckBox
End Class
