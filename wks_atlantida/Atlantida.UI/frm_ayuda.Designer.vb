<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ayuda
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Principal (Index)")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administracion (Administration)")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar (Generate)")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cobro/Pago (Collection/Payment)")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Idioma (Lenguaje)")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Terminar (Finish)")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ayuda))
        Me.TabControl_00 = New System.Windows.Forms.TabControl()
        Me.tab_00 = New System.Windows.Forms.TabPage()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rich_00 = New System.Windows.Forms.RichTextBox()
        Me.Tree_menu = New System.Windows.Forms.TreeView()
        Me.TabControl_00.SuspendLayout()
        Me.tab_00.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_00
        '
        Me.TabControl_00.Controls.Add(Me.tab_00)
        Me.TabControl_00.Location = New System.Drawing.Point(12, 42)
        Me.TabControl_00.Name = "TabControl_00"
        Me.TabControl_00.SelectedIndex = 0
        Me.TabControl_00.Size = New System.Drawing.Size(606, 359)
        Me.TabControl_00.TabIndex = 0
        '
        'tab_00
        '
        Me.tab_00.Controls.Add(Me.SplitContainer1)
        Me.tab_00.Location = New System.Drawing.Point(4, 22)
        Me.tab_00.Name = "tab_00"
        Me.tab_00.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_00.Size = New System.Drawing.Size(598, 333)
        Me.tab_00.TabIndex = 0
        Me.tab_00.Text = "Indice"
        Me.tab_00.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(175, 14)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(225, 25)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Informacion Sistema"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Tree_menu)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rich_00)
        Me.SplitContainer1.Size = New System.Drawing.Size(592, 327)
        Me.SplitContainer1.SplitterDistance = 197
        Me.SplitContainer1.TabIndex = 0
        '
        'rich_00
        '
        Me.rich_00.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rich_00.Location = New System.Drawing.Point(3, 0)
        Me.rich_00.Name = "rich_00"
        Me.rich_00.Size = New System.Drawing.Size(385, 321)
        Me.rich_00.TabIndex = 0
        Me.rich_00.Text = ""
        '
        'Tree_menu
        '
        Me.Tree_menu.Location = New System.Drawing.Point(3, 0)
        Me.Tree_menu.Name = "Tree_menu"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Principal (Index)"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Administracion (Administration)"
        TreeNode3.Name = "Node2"
        TreeNode3.Text = "Generar (Generate)"
        TreeNode4.Name = "Node3"
        TreeNode4.Text = "Cobro/Pago (Collection/Payment)"
        TreeNode5.Name = "Node4"
        TreeNode5.Text = "Idioma (Lenguaje)"
        TreeNode6.Name = "Node5"
        TreeNode6.Text = "Terminar (Finish)"
        Me.Tree_menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.Tree_menu.Size = New System.Drawing.Size(195, 327)
        Me.Tree_menu.TabIndex = 0
        '
        'frm_ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 413)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.TabControl_00)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_ayuda"
        Me.Text = "Ayuda"
        Me.TabControl_00.ResumeLayout(False)
        Me.tab_00.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl_00 As System.Windows.Forms.TabControl
    Friend WithEvents tab_00 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Tree_menu As System.Windows.Forms.TreeView
    Friend WithEvents rich_00 As System.Windows.Forms.RichTextBox
End Class
