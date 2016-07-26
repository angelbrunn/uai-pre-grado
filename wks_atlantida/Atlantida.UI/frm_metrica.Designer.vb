<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_metrica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_metrica))
        Me.dgw_metricas = New System.Windows.Forms.DataGridView()
        Me.btn_mas_vendidos = New System.Windows.Forms.Button()
        Me.btn_menos_vendidos = New System.Windows.Forms.Button()
        Me.btn_clientes_frec = New System.Windows.Forms.Button()
        Me.box_consultas = New System.Windows.Forms.GroupBox()
        Me.box_metrica = New System.Windows.Forms.GroupBox()
        CType(Me.dgw_metricas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_consultas.SuspendLayout()
        Me.box_metrica.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgw_metricas
        '
        Me.dgw_metricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_metricas.Location = New System.Drawing.Point(6, 19)
        Me.dgw_metricas.Name = "dgw_metricas"
        Me.dgw_metricas.Size = New System.Drawing.Size(783, 317)
        Me.dgw_metricas.TabIndex = 2
        '
        'btn_mas_vendidos
        '
        Me.btn_mas_vendidos.Location = New System.Drawing.Point(6, 19)
        Me.btn_mas_vendidos.Name = "btn_mas_vendidos"
        Me.btn_mas_vendidos.Size = New System.Drawing.Size(75, 50)
        Me.btn_mas_vendidos.TabIndex = 3
        Me.btn_mas_vendidos.Text = "Destinos Mas Vendidos"
        Me.btn_mas_vendidos.UseVisualStyleBackColor = True
        '
        'btn_menos_vendidos
        '
        Me.btn_menos_vendidos.Location = New System.Drawing.Point(87, 19)
        Me.btn_menos_vendidos.Name = "btn_menos_vendidos"
        Me.btn_menos_vendidos.Size = New System.Drawing.Size(75, 50)
        Me.btn_menos_vendidos.TabIndex = 4
        Me.btn_menos_vendidos.Text = "Destinos Menos Vendidos"
        Me.btn_menos_vendidos.UseVisualStyleBackColor = True
        '
        'btn_clientes_frec
        '
        Me.btn_clientes_frec.Location = New System.Drawing.Point(168, 19)
        Me.btn_clientes_frec.Name = "btn_clientes_frec"
        Me.btn_clientes_frec.Size = New System.Drawing.Size(75, 50)
        Me.btn_clientes_frec.TabIndex = 5
        Me.btn_clientes_frec.Text = "Clientes Frecuentes"
        Me.btn_clientes_frec.UseVisualStyleBackColor = True
        '
        'box_consultas
        '
        Me.box_consultas.Controls.Add(Me.btn_mas_vendidos)
        Me.box_consultas.Controls.Add(Me.btn_menos_vendidos)
        Me.box_consultas.Controls.Add(Me.btn_clientes_frec)
        Me.box_consultas.Location = New System.Drawing.Point(6, 366)
        Me.box_consultas.Name = "box_consultas"
        Me.box_consultas.Size = New System.Drawing.Size(795, 83)
        Me.box_consultas.TabIndex = 7
        Me.box_consultas.TabStop = False
        Me.box_consultas.Text = "Consultas"
        '
        'box_metrica
        '
        Me.box_metrica.Controls.Add(Me.dgw_metricas)
        Me.box_metrica.Location = New System.Drawing.Point(6, 12)
        Me.box_metrica.Name = "box_metrica"
        Me.box_metrica.Size = New System.Drawing.Size(795, 342)
        Me.box_metrica.TabIndex = 8
        Me.box_metrica.TabStop = False
        Me.box_metrica.Text = "Metricas"
        '
        'frm_metrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 461)
        Me.Controls.Add(Me.box_metrica)
        Me.Controls.Add(Me.box_consultas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_metrica"
        Me.Text = "Metricas"
        CType(Me.dgw_metricas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_consultas.ResumeLayout(False)
        Me.box_metrica.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgw_metricas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_mas_vendidos As System.Windows.Forms.Button
    Friend WithEvents btn_menos_vendidos As System.Windows.Forms.Button
    Friend WithEvents btn_clientes_frec As System.Windows.Forms.Button
    Friend WithEvents box_consultas As System.Windows.Forms.GroupBox
    Friend WithEvents box_metrica As System.Windows.Forms.GroupBox
End Class
