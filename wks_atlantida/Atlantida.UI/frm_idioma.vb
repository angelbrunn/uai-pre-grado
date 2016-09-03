Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

Public Class frm_idioma
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private chUsuarioField As Usuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim interfazMultiIdioma As INegMultiIdioma = New NegMultiIdioma
        Dim listadoIdiomas As New List(Of MultiIdioma)
        listadoIdiomas = interfazMultiIdioma.obtenerIdiomasDisponibles()

        'Listar Los idiomas habilitados
        Dim enumerator As IEnumerator(Of MultiIdioma) = listadoIdiomas.GetEnumerator
        While enumerator.MoveNext
            lstbx_chIdioma.Items.Add(enumerator.Current.iKey)
        End While

        Me.modificarIdiomaSegunPreferencias(chUsuario.idioma)
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
            If enu.Current.componente = "btn_cancelar" Then
                Me.btn_cancelar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_seleccionar" Then
                Me.btn_seleccionar.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_chIdioma" Then
                Me.lbl_chIdioma.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_idioma" Then
                Me.Text = enu.Current.value
            End If
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Dim bandera As String = True

        If lstbx_chIdioma.SelectedItems.Count = 0 Then
            MsgBox("Debe Seleccionar un Idioma")
            bandera = False
        Else
            For indice = 0 To lstbx_chIdioma.SelectedItems.Count - 1
                chUsuario.idioma = lstbx_chIdioma.SelectedItems(indice)
            Next
        End If

        Dim formulario As New frm_TableroPrincipal()
        formulario.unUsuario = chUsuario
        formulario.Show()
        Me.Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property chUsuario() As Usuario
        Get
            Return chUsuarioField
        End Get
        Set(ByVal value As Usuario)
            chUsuarioField = value
        End Set
    End Property
End Class