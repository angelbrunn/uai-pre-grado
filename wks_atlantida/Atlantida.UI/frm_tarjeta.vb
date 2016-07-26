Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_tarjeta
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public tar As tarjeta
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
        Dim res As tarjeta = New tarjeta()
        res.banco = Me.txt_banco.Text
        res.tipo = Me.txt_tipo.Text
        res.nrotarjeta = Me.txt_nro_tarjeta.Text
        res.fechvenc = Me.txt_fech_venc.Text
        Me.tar = res
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_tarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If enu.Current.componente = "btn_ok" Then
                Me.btn_ok.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_validar" Then
                Me.btn_validar.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_banco" Then
                Me.lbl_banco.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_codseguridad" Then
                Me.lbl_codseguridad.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_fechvenc" Then
                Me.lbl_fechvenc.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_nrotarjeta" Then
                Me.lbl_nrotarjeta.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_tipo" Then
                Me.lbl_tipo.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_tarjeta" Then
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