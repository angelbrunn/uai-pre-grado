Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades

Public Class frm_metrica
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
    Private Sub frm_metrica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)
    End Sub
    Private Sub modificarIdiomaSegunPreferencias(ByVal idioma As String)
        'Obtengo el listado de nombre de los componentes en ambos idiomas.
        Dim interfazMultiIdioma As INegMultiIdioma = New NegMultiIdioma
        Dim listadoMultiIdioma As New List(Of MultiIdioma)
        listadoMultiIdioma = interfazMultiIdioma.obtenerTablaMultiIdioma(idioma)

        Dim enu As IEnumerator(Of MultiIdioma) = listadoMultiIdioma.GetEnumerator
        While enu.MoveNext
            If enu.Current.componente = "box_consultas" Then
                Me.box_consultas.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_metrica" Then
                Me.box_metrica.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_clientes_frec" Then
                Me.btn_clientes_frec.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_mas_vendidos" Then
                Me.btn_mas_vendidos.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_menos_vendidos" Then
                Me.btn_menos_vendidos.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_metrica" Then
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