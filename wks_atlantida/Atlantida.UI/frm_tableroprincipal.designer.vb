<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TableroPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TableroPrincipal))
        Me.Menu_General = New System.Windows.Forms.MenuStrip()
        Me.Menu_Administracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Resguardo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Depuracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Generar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Presupuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_CyP = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Cobro = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Pago = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Idioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Cambiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Terminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Ayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Leer = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_General.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_General
        '
        resources.ApplyResources(Me.Menu_General, "Menu_General")
        Me.Menu_General.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Administracion, Me.Menu_Generar, Me.Menu_CyP, Me.Menu_Idioma, Me.Menu_Ayuda, Me.Menu_Terminar})
        Me.Menu_General.Name = "Menu_General"
        '
        'Menu_Administracion
        '
        resources.ApplyResources(Me.Menu_Administracion, "Menu_Administracion")
        Me.Menu_Administracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_Usuario, Me.SubMenu_Resguardo, Me.SubMenu_Depuracion})
        Me.Menu_Administracion.Name = "Menu_Administracion"
        '
        'SubMenu_Usuario
        '
        resources.ApplyResources(Me.SubMenu_Usuario, "SubMenu_Usuario")
        Me.SubMenu_Usuario.Name = "SubMenu_Usuario"
        '
        'SubMenu_Resguardo
        '
        resources.ApplyResources(Me.SubMenu_Resguardo, "SubMenu_Resguardo")
        Me.SubMenu_Resguardo.Name = "SubMenu_Resguardo"
        '
        'SubMenu_Depuracion
        '
        resources.ApplyResources(Me.SubMenu_Depuracion, "SubMenu_Depuracion")
        Me.SubMenu_Depuracion.Name = "SubMenu_Depuracion"
        '
        'Menu_Generar
        '
        resources.ApplyResources(Me.Menu_Generar, "Menu_Generar")
        Me.Menu_Generar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_Presupuesto})
        Me.Menu_Generar.Name = "Menu_Generar"
        '
        'SubMenu_Presupuesto
        '
        resources.ApplyResources(Me.SubMenu_Presupuesto, "SubMenu_Presupuesto")
        Me.SubMenu_Presupuesto.Name = "SubMenu_Presupuesto"
        '
        'Menu_CyP
        '
        resources.ApplyResources(Me.Menu_CyP, "Menu_CyP")
        Me.Menu_CyP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_Cobro, Me.SubMenu_Pago})
        Me.Menu_CyP.Name = "Menu_CyP"
        '
        'SubMenu_Cobro
        '
        resources.ApplyResources(Me.SubMenu_Cobro, "SubMenu_Cobro")
        Me.SubMenu_Cobro.Name = "SubMenu_Cobro"
        '
        'SubMenu_Pago
        '
        resources.ApplyResources(Me.SubMenu_Pago, "SubMenu_Pago")
        Me.SubMenu_Pago.Name = "SubMenu_Pago"
        '
        'Menu_Idioma
        '
        resources.ApplyResources(Me.Menu_Idioma, "Menu_Idioma")
        Me.Menu_Idioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_Cambiar})
        Me.Menu_Idioma.Name = "Menu_Idioma"
        '
        'SubMenu_Cambiar
        '
        resources.ApplyResources(Me.SubMenu_Cambiar, "SubMenu_Cambiar")
        Me.SubMenu_Cambiar.Name = "SubMenu_Cambiar"
        '
        'Menu_Terminar
        '
        resources.ApplyResources(Me.Menu_Terminar, "Menu_Terminar")
        Me.Menu_Terminar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_Salir})
        Me.Menu_Terminar.Name = "Menu_Terminar"
        '
        'SubMenu_Salir
        '
        resources.ApplyResources(Me.SubMenu_Salir, "SubMenu_Salir")
        Me.SubMenu_Salir.Name = "SubMenu_Salir"
        '
        'Menu_Ayuda
        '
        resources.ApplyResources(Me.Menu_Ayuda, "Menu_Ayuda")
        Me.Menu_Ayuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Leer})
        Me.Menu_Ayuda.Name = "Menu_Ayuda"
        '
        'Menu_Leer
        '
        resources.ApplyResources(Me.Menu_Leer, "Menu_Leer")
        Me.Menu_Leer.Name = "Menu_Leer"
        '
        'frm_TableroPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Menu_General)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu_General
        Me.Name = "frm_TableroPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu_General.ResumeLayout(False)
        Me.Menu_General.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu_General As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_Generar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Presupuesto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_CyP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Administracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Usuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Cobro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Pago As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Resguardo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Terminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Depuracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Idioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubMenu_Cambiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Ayuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Leer As System.Windows.Forms.ToolStripMenuItem

End Class
