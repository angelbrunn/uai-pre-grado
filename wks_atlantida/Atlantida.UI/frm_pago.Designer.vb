<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pago))
        Me.box_pagos_pend = New System.Windows.Forms.GroupBox()
        Me.dgw_pagos_pend = New System.Windows.Forms.DataGridView()
        Me.box_acciones = New System.Windows.Forms.GroupBox()
        Me.btn_solicitarPax = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_terminar_op = New System.Windows.Forms.Button()
        Me.btn_cotizar = New System.Windows.Forms.Button()
        Me.btn_transferencia = New System.Windows.Forms.Button()
        Me.txt_idProveedor = New System.Windows.Forms.TextBox()
        Me.lbl_idPres = New System.Windows.Forms.Label()
        Me.box_pagos_pend.SuspendLayout()
        CType(Me.dgw_pagos_pend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_acciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'box_pagos_pend
        '
        Me.box_pagos_pend.Controls.Add(Me.dgw_pagos_pend)
        Me.box_pagos_pend.Location = New System.Drawing.Point(12, 12)
        Me.box_pagos_pend.Name = "box_pagos_pend"
        Me.box_pagos_pend.Size = New System.Drawing.Size(867, 324)
        Me.box_pagos_pend.TabIndex = 8
        Me.box_pagos_pend.TabStop = False
        Me.box_pagos_pend.Text = "Pagos Pendientes"
        '
        'dgw_pagos_pend
        '
        Me.dgw_pagos_pend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_pagos_pend.Location = New System.Drawing.Point(9, 19)
        Me.dgw_pagos_pend.Name = "dgw_pagos_pend"
        Me.dgw_pagos_pend.Size = New System.Drawing.Size(852, 298)
        Me.dgw_pagos_pend.TabIndex = 1
        '
        'box_acciones
        '
        Me.box_acciones.Controls.Add(Me.btn_solicitarPax)
        Me.box_acciones.Controls.Add(Me.btn_confirmar)
        Me.box_acciones.Controls.Add(Me.btn_terminar_op)
        Me.box_acciones.Controls.Add(Me.btn_cotizar)
        Me.box_acciones.Controls.Add(Me.btn_transferencia)
        Me.box_acciones.Location = New System.Drawing.Point(12, 342)
        Me.box_acciones.Name = "box_acciones"
        Me.box_acciones.Size = New System.Drawing.Size(448, 74)
        Me.box_acciones.TabIndex = 9
        Me.box_acciones.TabStop = False
        Me.box_acciones.Text = "Acciones"
        '
        'btn_solicitarPax
        '
        Me.btn_solicitarPax.Location = New System.Drawing.Point(274, 19)
        Me.btn_solicitarPax.Name = "btn_solicitarPax"
        Me.btn_solicitarPax.Size = New System.Drawing.Size(81, 37)
        Me.btn_solicitarPax.TabIndex = 4
        Me.btn_solicitarPax.Text = "Solicitar Conf.Pago"
        Me.btn_solicitarPax.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(361, 19)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(81, 37)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = "Confirmar Pago"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'btn_terminar_op
        '
        Me.btn_terminar_op.Location = New System.Drawing.Point(186, 19)
        Me.btn_terminar_op.Name = "btn_terminar_op"
        Me.btn_terminar_op.Size = New System.Drawing.Size(81, 37)
        Me.btn_terminar_op.TabIndex = 2
        Me.btn_terminar_op.Text = "Terminar Operacion"
        Me.btn_terminar_op.UseVisualStyleBackColor = True
        '
        'btn_cotizar
        '
        Me.btn_cotizar.Location = New System.Drawing.Point(96, 19)
        Me.btn_cotizar.Name = "btn_cotizar"
        Me.btn_cotizar.Size = New System.Drawing.Size(81, 37)
        Me.btn_cotizar.TabIndex = 1
        Me.btn_cotizar.Text = "Cotizar"
        Me.btn_cotizar.UseVisualStyleBackColor = True
        '
        'btn_transferencia
        '
        Me.btn_transferencia.Location = New System.Drawing.Point(9, 19)
        Me.btn_transferencia.Name = "btn_transferencia"
        Me.btn_transferencia.Size = New System.Drawing.Size(81, 37)
        Me.btn_transferencia.TabIndex = 0
        Me.btn_transferencia.Text = "Transferencia"
        Me.btn_transferencia.UseVisualStyleBackColor = True
        '
        'txt_idProveedor
        '
        Me.txt_idProveedor.Location = New System.Drawing.Point(676, 361)
        Me.txt_idProveedor.Name = "txt_idProveedor"
        Me.txt_idProveedor.Size = New System.Drawing.Size(176, 20)
        Me.txt_idProveedor.TabIndex = 10
        '
        'lbl_idPres
        '
        Me.lbl_idPres.AutoSize = True
        Me.lbl_idPres.Location = New System.Drawing.Point(592, 368)
        Me.lbl_idPres.Name = "lbl_idPres"
        Me.lbl_idPres.Size = New System.Drawing.Size(78, 13)
        Me.lbl_idPres.TabIndex = 11
        Me.lbl_idPres.Text = "Id.Presupuesto"
        '
        'frm_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 430)
        Me.Controls.Add(Me.lbl_idPres)
        Me.Controls.Add(Me.txt_idProveedor)
        Me.Controls.Add(Me.box_acciones)
        Me.Controls.Add(Me.box_pagos_pend)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_pago"
        Me.Text = "Pago"
        Me.box_pagos_pend.ResumeLayout(False)
        CType(Me.dgw_pagos_pend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_acciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents box_pagos_pend As System.Windows.Forms.GroupBox
    Friend WithEvents dgw_pagos_pend As System.Windows.Forms.DataGridView
    Friend WithEvents box_acciones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cotizar As System.Windows.Forms.Button
    Friend WithEvents btn_transferencia As System.Windows.Forms.Button
    Friend WithEvents btn_terminar_op As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents txt_idProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idPres As System.Windows.Forms.Label
    Friend WithEvents btn_solicitarPax As System.Windows.Forms.Button
End Class
