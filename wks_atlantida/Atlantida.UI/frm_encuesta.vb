Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades

Public Class frm_encuesta
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
    Private Sub frm_encuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If enu.Current.componente = "box_encuesta" Then
                Me.box_encuesta.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_guardar_enc" Then
                Me.box_guardar_enc.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pregunta_1" Then
                Me.box_pregunta_1.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pregunta_2" Then
                Me.box_pregunta_2.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pregunta_3" Then
                Me.box_pregunta_3.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pregunta_4" Then
                Me.box_pregunta_4.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pregunta_5" Then
                Me.box_pregunta_5.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pregunta_6" Then
                Me.box_pregunta_6.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_guardar" Then
                Me.btn_guardar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_validar" Then
                Me.btn_validar.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck1_box1" Then
                Me.ck1_box1.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck1_box2" Then
                Me.ck1_box2.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck1_box3" Then
                Me.ck1_box3.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck1_box4" Then
                Me.ck1_box4.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck1_box5" Then
                Me.ck1_box5.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck1_box6" Then
                Me.ck1_box6.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck2_box1" Then
                Me.ck2_box1.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck2_box2" Then
                Me.ck2_box2.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck2_box3" Then
                Me.ck2_box3.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck2_box4" Then
                Me.ck2_box4.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck2_box5" Then
                Me.ck2_box5.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck2_box6" Then
                Me.ck2_box6.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck3_box1" Then
                Me.ck3_box1.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck3_box2" Then
                Me.ck3_box2.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck3_box3" Then
                Me.ck3_box3.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck3_box4" Then
                Me.ck3_box4.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck3_box5" Then
                Me.ck3_box5.Text = enu.Current.value
            End If
            If enu.Current.componente = "ck3_box6" Then
                Me.ck3_box6.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_encuesta" Then
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