Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades
''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_ayuda
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private idUsuario As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private idioma As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idioma"></param>
    ''' <remarks></remarks>
    Private Sub modificarIdiomaSegunPreferencias(ByVal idioma As String)
        'Obtengo el listado de nombre de los componentes en ambos idiomas.
        Dim interfazMultiIdioma As INegMultiIdioma = New NegMultiIdioma
        Dim listadoMultiIdioma As New List(Of MultiIdioma)
        listadoMultiIdioma = interfazMultiIdioma.obtenerTablaMultiIdioma(idioma)

        Dim enu As IEnumerator(Of MultiIdioma) = listadoMultiIdioma.GetEnumerator
        While enu.MoveNext
            If enu.Current.componente = "frm_ayuda" Then
                Me.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_titulo" Then
                Me.lbl_titulo.Text = enu.Current.value
            End If
            If enu.Current.componente = "tab_00" Then
                Me.tab_00.Text = enu.Current.value
            End If
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Tree_menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tree_menu.AfterSelect
        If e.Node.Name = "Node0" Then
            rich_00.Text = "ES-SIS Atlantida es un Software para la venta de pasajes Turisticos,esta es la primer version del producto.Por mayores incomenientes podra comunicarse con el administrador y linea de soporte al +54011 6823 3744/mail:angelbrunn@gmail.com - BS AS,Argentina.                                                EN-SIS Atlantida is a Software for the sale of tourist passages, this is the first version of the product. For more incomenientes you can communicate with the administrator and support line at +54011 6823 3744 / mail: angelbrunn@gmail.com - BS AS, Argentina"
        End If
        If e.Node.Name = "Node1" Then
            rich_00.Text = "ES:En el menu administrador podras encontrar todas las acciones para el resguardo de datos de la aplicacion, podras hacer creaciones de usuario como generar un resguardo de datos de la base de datos.                                     EN:In the menu administrator you will be able to find all the actions for the protection of data of the application, you can make creations of user like to generate a safeguard of data of the database."
        End If
        If e.Node.Name = "Node2" Then
            rich_00.Text = "ES:En el menú Generar podrás realizar un presupuesto para la venta de un pasaje al cliente.                                                          EN:In the Generate menu you can make a quote for the sale of a ticket to the customer."
        End If
        If e.Node.Name = "Node3" Then
            rich_00.Text = "ES:En el menú Cobro/Pago puedes realizar toda la gestion de cobro al cliente y pago a tus proveedores.                                               EN:In the Collection / Payment menu you can perform all the management of payment to the customer and payment to your suppliers."
        End If
        If e.Node.Name = "Node4" Then
            rich_00.Text = "ES:En el menú Idioma podras cambiar el lenguaje de la aplicacion.                           EN:In the Language menu you can change the language of the application."
        End If
        If e.Node.Name = "Node5" Then
            rich_00.Text = "ES:En el menú Terminar podras cerrar la aplicacion de manera adecuada y segura. EN:In the Finish menu you can close the application properly and safely."
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UsuarioId() As String
        Get
            Return idUsuario
        End Get
        Set(ByVal value As String)
            idUsuario = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UsuarioIdioma() As String
        Get
            Return idioma
        End Get
        Set(ByVal value As String)
            idioma = value
        End Set
    End Property
End Class