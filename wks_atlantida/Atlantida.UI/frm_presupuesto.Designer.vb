<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_presupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_presupuesto))
        Me.box_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_cliente5 = New System.Windows.Forms.TextBox()
        Me.txt_cliente4 = New System.Windows.Forms.TextBox()
        Me.txt_cliente3 = New System.Windows.Forms.TextBox()
        Me.txt_cliente2 = New System.Windows.Forms.TextBox()
        Me.txt_cliente1 = New System.Windows.Forms.TextBox()
        Me.lbl_cliente5 = New System.Windows.Forms.Label()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.lbl_cliente4 = New System.Windows.Forms.Label()
        Me.lbl_cliente1 = New System.Windows.Forms.Label()
        Me.lbl_cliente2 = New System.Windows.Forms.Label()
        Me.lbl_cliente3 = New System.Windows.Forms.Label()
        Me.box_presupuesto = New System.Windows.Forms.GroupBox()
        Me.lst_destino = New System.Windows.Forms.ListBox()
        Me.lst_origen = New System.Windows.Forms.ListBox()
        Me.chk_crucero = New System.Windows.Forms.RadioButton()
        Me.chk_tren = New System.Windows.Forms.RadioButton()
        Me.chk_bus = New System.Windows.Forms.RadioButton()
        Me.chk_avion = New System.Windows.Forms.RadioButton()
        Me.btn_hospedaje = New System.Windows.Forms.Button()
        Me.btn_obtPaqProm = New System.Windows.Forms.Button()
        Me.btn_generapresu = New System.Windows.Forms.Button()
        Me.btn_terminaop = New System.Windows.Forms.Button()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.btn_obtPaqNoProm = New System.Windows.Forms.Button()
        Me.lbl_origen = New System.Windows.Forms.Label()
        Me.lbl_destino = New System.Windows.Forms.Label()
        Me.txt_fechaida = New System.Windows.Forms.TextBox()
        Me.lbl_fechIda = New System.Windows.Forms.Label()
        Me.lbl_fechVue = New System.Windows.Forms.Label()
        Me.txt_fechavuelta = New System.Windows.Forms.TextBox()
        Me.box_resultadodisp = New System.Windows.Forms.GroupBox()
        Me.dgw_PaqProm = New System.Windows.Forms.DataGridView()
        Me.box_result = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_idPres = New System.Windows.Forms.Label()
        Me.txt_idProveedor = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.box_cliente.SuspendLayout()
        Me.box_presupuesto.SuspendLayout()
        Me.box_resultadodisp.SuspendLayout()
        CType(Me.dgw_PaqProm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_result.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'box_cliente
        '
        Me.box_cliente.Controls.Add(Me.txt_cliente5)
        Me.box_cliente.Controls.Add(Me.txt_cliente4)
        Me.box_cliente.Controls.Add(Me.txt_cliente3)
        Me.box_cliente.Controls.Add(Me.txt_cliente2)
        Me.box_cliente.Controls.Add(Me.txt_cliente1)
        Me.box_cliente.Controls.Add(Me.lbl_cliente5)
        Me.box_cliente.Controls.Add(Me.btn_cargar)
        Me.box_cliente.Controls.Add(Me.lbl_cliente4)
        Me.box_cliente.Controls.Add(Me.lbl_cliente1)
        Me.box_cliente.Controls.Add(Me.lbl_cliente2)
        Me.box_cliente.Controls.Add(Me.lbl_cliente3)
        Me.box_cliente.Location = New System.Drawing.Point(12, 12)
        Me.box_cliente.Name = "box_cliente"
        Me.box_cliente.Size = New System.Drawing.Size(392, 210)
        Me.box_cliente.TabIndex = 7
        Me.box_cliente.TabStop = False
        Me.box_cliente.Text = "Datos del pasajero"
        '
        'txt_cliente5
        '
        Me.txt_cliente5.Location = New System.Drawing.Point(130, 145)
        Me.txt_cliente5.Name = "txt_cliente5"
        Me.txt_cliente5.Size = New System.Drawing.Size(256, 20)
        Me.txt_cliente5.TabIndex = 23
        '
        'txt_cliente4
        '
        Me.txt_cliente4.Location = New System.Drawing.Point(130, 118)
        Me.txt_cliente4.Name = "txt_cliente4"
        Me.txt_cliente4.Size = New System.Drawing.Size(256, 20)
        Me.txt_cliente4.TabIndex = 22
        '
        'txt_cliente3
        '
        Me.txt_cliente3.Location = New System.Drawing.Point(130, 92)
        Me.txt_cliente3.Name = "txt_cliente3"
        Me.txt_cliente3.Size = New System.Drawing.Size(256, 20)
        Me.txt_cliente3.TabIndex = 21
        '
        'txt_cliente2
        '
        Me.txt_cliente2.Location = New System.Drawing.Point(130, 66)
        Me.txt_cliente2.Name = "txt_cliente2"
        Me.txt_cliente2.Size = New System.Drawing.Size(256, 20)
        Me.txt_cliente2.TabIndex = 20
        '
        'txt_cliente1
        '
        Me.txt_cliente1.Location = New System.Drawing.Point(130, 38)
        Me.txt_cliente1.Name = "txt_cliente1"
        Me.txt_cliente1.Size = New System.Drawing.Size(256, 20)
        Me.txt_cliente1.TabIndex = 19
        '
        'lbl_cliente5
        '
        Me.lbl_cliente5.AutoSize = True
        Me.lbl_cliente5.Location = New System.Drawing.Point(6, 148)
        Me.lbl_cliente5.Name = "lbl_cliente5"
        Me.lbl_cliente5.Size = New System.Drawing.Size(65, 13)
        Me.lbl_cliente5.TabIndex = 18
        Me.lbl_cliente5.Text = "Cliente Nro5"
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(130, 171)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(75, 30)
        Me.btn_cargar.TabIndex = 14
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'lbl_cliente4
        '
        Me.lbl_cliente4.AutoSize = True
        Me.lbl_cliente4.Location = New System.Drawing.Point(6, 121)
        Me.lbl_cliente4.Name = "lbl_cliente4"
        Me.lbl_cliente4.Size = New System.Drawing.Size(65, 13)
        Me.lbl_cliente4.TabIndex = 12
        Me.lbl_cliente4.Text = "Cliente Nro4"
        '
        'lbl_cliente1
        '
        Me.lbl_cliente1.AutoSize = True
        Me.lbl_cliente1.Location = New System.Drawing.Point(6, 41)
        Me.lbl_cliente1.Name = "lbl_cliente1"
        Me.lbl_cliente1.Size = New System.Drawing.Size(65, 13)
        Me.lbl_cliente1.TabIndex = 0
        Me.lbl_cliente1.Text = "Cliente Nro1"
        '
        'lbl_cliente2
        '
        Me.lbl_cliente2.AutoSize = True
        Me.lbl_cliente2.Location = New System.Drawing.Point(6, 69)
        Me.lbl_cliente2.Name = "lbl_cliente2"
        Me.lbl_cliente2.Size = New System.Drawing.Size(65, 13)
        Me.lbl_cliente2.TabIndex = 1
        Me.lbl_cliente2.Text = "Cliente Nro2"
        '
        'lbl_cliente3
        '
        Me.lbl_cliente3.AutoSize = True
        Me.lbl_cliente3.Location = New System.Drawing.Point(6, 95)
        Me.lbl_cliente3.Name = "lbl_cliente3"
        Me.lbl_cliente3.Size = New System.Drawing.Size(65, 13)
        Me.lbl_cliente3.TabIndex = 2
        Me.lbl_cliente3.Text = "Cliente Nro3"
        '
        'box_presupuesto
        '
        Me.box_presupuesto.Controls.Add(Me.lst_destino)
        Me.box_presupuesto.Controls.Add(Me.lst_origen)
        Me.box_presupuesto.Controls.Add(Me.chk_crucero)
        Me.box_presupuesto.Controls.Add(Me.chk_tren)
        Me.box_presupuesto.Controls.Add(Me.chk_bus)
        Me.box_presupuesto.Controls.Add(Me.chk_avion)
        Me.box_presupuesto.Controls.Add(Me.btn_hospedaje)
        Me.box_presupuesto.Controls.Add(Me.btn_obtPaqProm)
        Me.box_presupuesto.Controls.Add(Me.btn_generapresu)
        Me.box_presupuesto.Controls.Add(Me.btn_terminaop)
        Me.box_presupuesto.Controls.Add(Me.btn_asignar)
        Me.box_presupuesto.Controls.Add(Me.btn_obtPaqNoProm)
        Me.box_presupuesto.Controls.Add(Me.lbl_origen)
        Me.box_presupuesto.Controls.Add(Me.lbl_destino)
        Me.box_presupuesto.Controls.Add(Me.txt_fechaida)
        Me.box_presupuesto.Controls.Add(Me.lbl_fechIda)
        Me.box_presupuesto.Controls.Add(Me.lbl_fechVue)
        Me.box_presupuesto.Controls.Add(Me.txt_fechavuelta)
        Me.box_presupuesto.Location = New System.Drawing.Point(410, 12)
        Me.box_presupuesto.Name = "box_presupuesto"
        Me.box_presupuesto.Size = New System.Drawing.Size(392, 246)
        Me.box_presupuesto.TabIndex = 8
        Me.box_presupuesto.TabStop = False
        Me.box_presupuesto.Text = "Paquete No promocionable"
        '
        'lst_destino
        '
        Me.lst_destino.FormattingEnabled = True
        Me.lst_destino.Location = New System.Drawing.Point(111, 66)
        Me.lst_destino.Name = "lst_destino"
        Me.lst_destino.Size = New System.Drawing.Size(270, 17)
        Me.lst_destino.TabIndex = 33
        '
        'lst_origen
        '
        Me.lst_origen.FormattingEnabled = True
        Me.lst_origen.Location = New System.Drawing.Point(111, 38)
        Me.lst_origen.Name = "lst_origen"
        Me.lst_origen.Size = New System.Drawing.Size(270, 17)
        Me.lst_origen.TabIndex = 32
        '
        'chk_crucero
        '
        Me.chk_crucero.AutoSize = True
        Me.chk_crucero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chk_crucero.Location = New System.Drawing.Point(270, 148)
        Me.chk_crucero.Name = "chk_crucero"
        Me.chk_crucero.Size = New System.Drawing.Size(62, 17)
        Me.chk_crucero.TabIndex = 31
        Me.chk_crucero.TabStop = True
        Me.chk_crucero.Text = "Crucero"
        Me.chk_crucero.UseVisualStyleBackColor = True
        '
        'chk_tren
        '
        Me.chk_tren.AutoSize = True
        Me.chk_tren.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chk_tren.Location = New System.Drawing.Point(218, 148)
        Me.chk_tren.Name = "chk_tren"
        Me.chk_tren.Size = New System.Drawing.Size(47, 17)
        Me.chk_tren.TabIndex = 30
        Me.chk_tren.TabStop = True
        Me.chk_tren.Text = "Tren"
        Me.chk_tren.UseVisualStyleBackColor = True
        '
        'chk_bus
        '
        Me.chk_bus.AutoSize = True
        Me.chk_bus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chk_bus.Location = New System.Drawing.Point(169, 148)
        Me.chk_bus.Name = "chk_bus"
        Me.chk_bus.Size = New System.Drawing.Size(43, 17)
        Me.chk_bus.TabIndex = 29
        Me.chk_bus.TabStop = True
        Me.chk_bus.Text = "Bus"
        Me.chk_bus.UseVisualStyleBackColor = True
        '
        'chk_avion
        '
        Me.chk_avion.AutoSize = True
        Me.chk_avion.Location = New System.Drawing.Point(111, 148)
        Me.chk_avion.Name = "chk_avion"
        Me.chk_avion.Size = New System.Drawing.Size(52, 17)
        Me.chk_avion.TabIndex = 28
        Me.chk_avion.TabStop = True
        Me.chk_avion.Text = "Avion"
        Me.chk_avion.UseVisualStyleBackColor = True
        '
        'btn_hospedaje
        '
        Me.btn_hospedaje.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_hospedaje.Location = New System.Drawing.Point(183, 171)
        Me.btn_hospedaje.Name = "btn_hospedaje"
        Me.btn_hospedaje.Size = New System.Drawing.Size(82, 38)
        Me.btn_hospedaje.TabIndex = 26
        Me.btn_hospedaje.Text = "Obtener Hospedaje"
        Me.btn_hospedaje.UseVisualStyleBackColor = True
        '
        'btn_obtPaqProm
        '
        Me.btn_obtPaqProm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_obtPaqProm.Location = New System.Drawing.Point(6, 171)
        Me.btn_obtPaqProm.Name = "btn_obtPaqProm"
        Me.btn_obtPaqProm.Size = New System.Drawing.Size(170, 30)
        Me.btn_obtPaqProm.TabIndex = 25
        Me.btn_obtPaqProm.Text = "Obtener Paquetes Prom."
        Me.btn_obtPaqProm.UseVisualStyleBackColor = True
        '
        'btn_generapresu
        '
        Me.btn_generapresu.Location = New System.Drawing.Point(270, 171)
        Me.btn_generapresu.Name = "btn_generapresu"
        Me.btn_generapresu.Size = New System.Drawing.Size(108, 38)
        Me.btn_generapresu.TabIndex = 24
        Me.btn_generapresu.Text = "Generar Presup."
        Me.btn_generapresu.UseVisualStyleBackColor = True
        '
        'btn_terminaop
        '
        Me.btn_terminaop.Location = New System.Drawing.Point(270, 217)
        Me.btn_terminaop.Name = "btn_terminaop"
        Me.btn_terminaop.Size = New System.Drawing.Size(108, 22)
        Me.btn_terminaop.TabIndex = 21
        Me.btn_terminaop.Text = "Terminar OP"
        Me.btn_terminaop.UseVisualStyleBackColor = True
        '
        'btn_asignar
        '
        Me.btn_asignar.Location = New System.Drawing.Point(182, 215)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(82, 23)
        Me.btn_asignar.TabIndex = 20
        Me.btn_asignar.Text = "Asignar"
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'btn_obtPaqNoProm
        '
        Me.btn_obtPaqNoProm.Location = New System.Drawing.Point(6, 207)
        Me.btn_obtPaqNoProm.Name = "btn_obtPaqNoProm"
        Me.btn_obtPaqNoProm.Size = New System.Drawing.Size(170, 32)
        Me.btn_obtPaqNoProm.TabIndex = 18
        Me.btn_obtPaqNoProm.Text = "Obtener Paquetes NoProm."
        Me.btn_obtPaqNoProm.UseVisualStyleBackColor = True
        '
        'lbl_origen
        '
        Me.lbl_origen.AutoSize = True
        Me.lbl_origen.Location = New System.Drawing.Point(6, 41)
        Me.lbl_origen.Name = "lbl_origen"
        Me.lbl_origen.Size = New System.Drawing.Size(38, 13)
        Me.lbl_origen.TabIndex = 11
        Me.lbl_origen.Text = "Origen"
        '
        'lbl_destino
        '
        Me.lbl_destino.AutoSize = True
        Me.lbl_destino.Location = New System.Drawing.Point(6, 69)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_destino.TabIndex = 12
        Me.lbl_destino.Text = "Destino"
        '
        'txt_fechaida
        '
        Me.txt_fechaida.Location = New System.Drawing.Point(111, 92)
        Me.txt_fechaida.Name = "txt_fechaida"
        Me.txt_fechaida.Size = New System.Drawing.Size(270, 20)
        Me.txt_fechaida.TabIndex = 6
        Me.txt_fechaida.Text = """YYYY-MM-DD"""
        '
        'lbl_fechIda
        '
        Me.lbl_fechIda.AutoSize = True
        Me.lbl_fechIda.Location = New System.Drawing.Point(6, 95)
        Me.lbl_fechIda.Name = "lbl_fechIda"
        Me.lbl_fechIda.Size = New System.Drawing.Size(55, 13)
        Me.lbl_fechIda.TabIndex = 6
        Me.lbl_fechIda.Text = "Fecha Ida"
        '
        'lbl_fechVue
        '
        Me.lbl_fechVue.AutoSize = True
        Me.lbl_fechVue.Location = New System.Drawing.Point(6, 121)
        Me.lbl_fechVue.Name = "lbl_fechVue"
        Me.lbl_fechVue.Size = New System.Drawing.Size(70, 13)
        Me.lbl_fechVue.TabIndex = 7
        Me.lbl_fechVue.Text = "Fecha Vuelta"
        '
        'txt_fechavuelta
        '
        Me.txt_fechavuelta.Location = New System.Drawing.Point(111, 118)
        Me.txt_fechavuelta.Name = "txt_fechavuelta"
        Me.txt_fechavuelta.Size = New System.Drawing.Size(270, 20)
        Me.txt_fechavuelta.TabIndex = 8
        Me.txt_fechavuelta.Text = """YYYY-MM-DD"""
        '
        'box_resultadodisp
        '
        Me.box_resultadodisp.Controls.Add(Me.dgw_PaqProm)
        Me.box_resultadodisp.Location = New System.Drawing.Point(12, 264)
        Me.box_resultadodisp.Name = "box_resultadodisp"
        Me.box_resultadodisp.Size = New System.Drawing.Size(790, 166)
        Me.box_resultadodisp.TabIndex = 9
        Me.box_resultadodisp.TabStop = False
        Me.box_resultadodisp.Text = "Visualizar Paquete"
        '
        'dgw_PaqProm
        '
        Me.dgw_PaqProm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_PaqProm.Location = New System.Drawing.Point(9, 19)
        Me.dgw_PaqProm.Name = "dgw_PaqProm"
        Me.dgw_PaqProm.Size = New System.Drawing.Size(775, 141)
        Me.dgw_PaqProm.TabIndex = 1
        '
        'box_result
        '
        Me.box_result.Controls.Add(Me.DataGridView1)
        Me.box_result.Location = New System.Drawing.Point(12, 436)
        Me.box_result.Name = "box_result"
        Me.box_result.Size = New System.Drawing.Size(790, 119)
        Me.box_result.TabIndex = 11
        Me.box_result.TabStop = False
        Me.box_result.Text = "Presupuesto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(775, 101)
        Me.DataGridView1.TabIndex = 0
        '
        'lbl_idPres
        '
        Me.lbl_idPres.AutoSize = True
        Me.lbl_idPres.Location = New System.Drawing.Point(18, 233)
        Me.lbl_idPres.Name = "lbl_idPres"
        Me.lbl_idPres.Size = New System.Drawing.Size(78, 13)
        Me.lbl_idPres.TabIndex = 12
        Me.lbl_idPres.Text = "Id.Presupuesto"
        '
        'txt_idProveedor
        '
        Me.txt_idProveedor.Location = New System.Drawing.Point(142, 227)
        Me.txt_idProveedor.Name = "txt_idProveedor"
        Me.txt_idProveedor.Size = New System.Drawing.Size(176, 20)
        Me.txt_idProveedor.TabIndex = 13
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(323, 227)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 566)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_idProveedor)
        Me.Controls.Add(Me.lbl_idPres)
        Me.Controls.Add(Me.box_result)
        Me.Controls.Add(Me.box_resultadodisp)
        Me.Controls.Add(Me.box_presupuesto)
        Me.Controls.Add(Me.box_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_presupuesto"
        Me.Text = "Presupuesto"
        Me.box_cliente.ResumeLayout(False)
        Me.box_cliente.PerformLayout()
        Me.box_presupuesto.ResumeLayout(False)
        Me.box_presupuesto.PerformLayout()
        Me.box_resultadodisp.ResumeLayout(False)
        CType(Me.dgw_PaqProm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_result.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents box_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cliente5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cliente5 As System.Windows.Forms.Label
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents lbl_cliente4 As System.Windows.Forms.Label
    Friend WithEvents lbl_cliente1 As System.Windows.Forms.Label
    Friend WithEvents lbl_cliente2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cliente3 As System.Windows.Forms.Label
    Friend WithEvents box_presupuesto As System.Windows.Forms.GroupBox
    Friend WithEvents chk_crucero As System.Windows.Forms.RadioButton
    Friend WithEvents chk_tren As System.Windows.Forms.RadioButton
    Friend WithEvents chk_bus As System.Windows.Forms.RadioButton
    Friend WithEvents chk_avion As System.Windows.Forms.RadioButton
    Friend WithEvents btn_hospedaje As System.Windows.Forms.Button
    Friend WithEvents btn_obtPaqProm As System.Windows.Forms.Button
    Friend WithEvents btn_generapresu As System.Windows.Forms.Button
    Friend WithEvents btn_terminaop As System.Windows.Forms.Button
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents btn_obtPaqNoProm As System.Windows.Forms.Button
    Friend WithEvents lbl_origen As System.Windows.Forms.Label
    Friend WithEvents lbl_destino As System.Windows.Forms.Label
    Friend WithEvents txt_fechaida As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechIda As System.Windows.Forms.Label
    Friend WithEvents lbl_fechVue As System.Windows.Forms.Label
    Friend WithEvents txt_fechavuelta As System.Windows.Forms.TextBox
    Friend WithEvents box_resultadodisp As System.Windows.Forms.GroupBox
    Friend WithEvents dgw_PaqProm As System.Windows.Forms.DataGridView
    Friend WithEvents box_result As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_idPres As System.Windows.Forms.Label
    Friend WithEvents txt_idProveedor As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lst_destino As System.Windows.Forms.ListBox
    Friend WithEvents lst_origen As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
