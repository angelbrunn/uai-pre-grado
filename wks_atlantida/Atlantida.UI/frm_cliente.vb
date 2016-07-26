Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_cliente
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public cli As Cliente
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Dim res As Cliente = New Cliente()
        res.dniCliente = Me.txt_dni.Text
        res.apellidoCliente = Me.txt_ape.Text
        res.nombreCliente = Me.txt_nom.Text
        res.emailCliente = Me.txt_email.Text
        Me.cli = res
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If enu.Current.componente = "box_cliente" Then
                Me.box_cliente.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_alta" Then
                Me.btn_alta.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_baja" Then
                Me.btn_baja.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_modificacion" Then
                Me.btn_modificacion.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_ok" Then
                Me.btn_ok.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_validar" Then
                Me.btn_validar.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_apellido" Then
                Me.lbl_apellido.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_email" Then
                Me.lbl_email.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_nombre" Then
                Me.lbl_nombre.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_nrodni" Then
                Me.lbl_nrodni.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_cliente" Then
                Me.Text = enu.Current.value
            End If
        End While
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