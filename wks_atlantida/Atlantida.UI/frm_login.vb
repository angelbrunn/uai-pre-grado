Imports Atlantida.Excepcion
Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_login
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim interfazNegMultiUsuario As INegMultiUsuario = New NegMultiUsuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ini.Click
        Dim resultadoLogin As Integer = 0
        Dim oUsuario As New Usuario

        resultadoLogin = interfazNegMultiUsuario.login(Me.txt_usuario.Text, Me.txt_contraseña.Text)

        If Not resultadoLogin = 0 Then
            MsgBox("Logueado OK")
            Me.txt_usuario.Clear()
            Me.txt_contraseña.Clear()

            'Obtengo el usuario completo para pasarlo al formulario de Inicio como parametro
            'y que este decida que se debe habilitar.
            'resultadoLogin = id del usuario
            oUsuario = interfazNegMultiUsuario.obtenerUsuario(resultadoLogin)

            Dim formulario As New frm_TableroPrincipal()

            formulario.unUsuario = oUsuario
            formulario.Show()
            Me.Hide()
        Else
            Me.txt_usuario.Clear()
            Me.txt_contraseña.Clear()
            MsgBox("usuario o password incorrecto")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_usuario.ReadOnly = False
        Me.txt_contraseña.ReadOnly = False

        Dim resultadoConsistencia As Boolean = False

        Try
            'VERIFICO QUE LA DB ESTE INSTALADA
            resultadoConsistencia = interfazNegMultiUsuario.verificarConsistenciaBD()

        Catch ex As Exception
            MsgBox("Error de Conexión contra la Base de Datos")
        End Try

        If resultadoConsistencia = False Then
            MsgBox("Error Critico de Consistencia en la Base de Datos")
        Else
            MsgBox("Validacion de BD OK")
        End If
    End Sub
End Class