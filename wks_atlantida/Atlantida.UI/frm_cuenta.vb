Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_cuenta
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public cue As cuenta
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
        Dim res As cuenta = New cuenta()
        'Origen cuenta'
        res.ori_tipocuenta = Me.txt_ori_tcuenta.Text
        res.ori_banco = Me.txt_ori_banco.Text
        res.ori_numerocuenta = Me.txt_ori_nro_cuenta.Text
        'Destino cuenta'
        res.des_tipocuenta = Me.txt_des_tcuenta.Text
        res.des_banco = Me.txt_des_banco.Text
        res.des_numerocuenta = Me.txt_des_nro_cuenta.Text
        res.des_nombre = Me.txt_des_nombre.Text
        res.des_email = Me.txt_des_email.Text
        Me.cue = res
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If enu.Current.componente = "lbl_tipo_cuenta" Then
                Me.lbl_tipo_cuenta.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_banco" Then
                Me.lbl_banco.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_num_cuenta" Then
                Me.lbl_num_cuenta.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_tipo_cuenta_b" Then
                Me.lbl_tipo_cuenta_b.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_banco_b" Then
                Me.lbl_banco_b.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_num_cuenta_b" Then
                Me.lbl_num_cuenta_b.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_nombre" Then
                Me.lbl_nombre.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_mail" Then
                Me.lbl_mail.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_cuenta" Then
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