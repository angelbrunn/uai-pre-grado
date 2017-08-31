Imports Atlantida.BLL.SIS.BLL

Public Class frm_server
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private interfazNegocio As NegNegocio = New NegNegocio
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public firstIntall As Boolean = interfazNegocio.validarPrimeraConexion
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'TODO: implementar
        'primero edita el script
        'segundo edita el app.config
        Dim isSave = interfazNegocio.saveConexion()
        Dim frmlogin As New frm_login
        frmlogin.Show()
        Me.Hide()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_server_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTO SI ES LA PRIMERA VEZ QUE SE INICIA = TRUE SINO YA FUE INSTALADO=FALSE
        If firstIntall = False Then
            Dim frmlogin As New frm_login
            frmlogin.Show()
            Me.Hide()
        End If
    End Sub
End Class