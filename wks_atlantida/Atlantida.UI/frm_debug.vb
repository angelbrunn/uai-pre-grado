Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_debug
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
    ''' <remarks></remarks>
    Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bitacoraCSV.Click
        frm_backup.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnProbarDigitoVerificador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_digitoVerificador.Click
        'Dim oUsuario As New Usuario
        'oUsuario.idUsuario = 6
        'oUsuario.usuario = "Test"
        'oUsuario.password = "123"
        'oUsuario.legajo = 2
        'oUsuario.idioma = True

        'Dim oVendedor As New Vendedor
        'oVendedor.legajo = 5
        'oVendedor.apellido = "Prado"
        'oVendedor.nombre = "Angel"
        'oVendedor.telefono = "4545-45453"
        'oVendedor.domicilio = "Superi 1245"
        'oVendedor.fechaNacimiento = "01/01/1987"
        'oVendedor.activo = True

        'interfazNegMultiUsuario.insertarUsuario(oUsuario)
        'interfazNegMultiUsuario.insertarVendedor(oVendedor)
        Dim resultadoConsistencia As Boolean = False

        Try
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnProbarConsistenciaBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consistenciaBD.Click

        Dim resultadoConsistencia As Boolean = False

        resultadoConsistencia = interfazNegMultiUsuario.verificarConsistenciaBD()

        If resultadoConsistencia = False Then
            MsgBox("Error Critico de Consistencia en la Base de Datos")
        Else
            MsgBox("Verificacion realizada correctamente")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInsertarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InsertarUsuario.Click
        frm_usuario.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInsertarBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InsertarBitacora.Click
        '##### OBJETOS A PERSISTIR #####
        Dim oBitacora_BKP As New Bitacora
        Dim oBitacora_BLL As New Bitacora
        Dim oBitacora_DAL As New Bitacora
        Dim oBitacora_IO As New Bitacora
        Dim oBitacora_SEG As New Bitacora
        '##### EDITO UN MENSAJE PARA UNA EXCEPCION DE TEST #####
        oBitacora_BKP.descripcion = "Probando desde depuracion,insercion de Trazas."
        oBitacora_BLL.descripcion = "Probando desde depuracion,insercion de Trazas."
        oBitacora_DAL.descripcion = "Probando desde depuracion,insercion de Trazas."
        oBitacora_IO.descripcion = "Probando desde depuracion,insercion de Trazas."
        oBitacora_SEG.descripcion = "Probando desde depuracion,insercion de Trazas."
        '##### CONSTRUYO LA EXCEPCION DE TEST SEGUN TIPO DE EXCEPCION #####
        Dim exc_BKP As New BKPException(oBitacora_BKP.descripcion)
        Dim exc_BLL As New BLLExcepcion(oBitacora_BLL.descripcion)
        Dim exc_DAL As New DALExcepcion(oBitacora_DAL.descripcion)
        Dim exc_IO As New IOException(oBitacora_IO.descripcion)
        Dim exc_SEG As New SEGExcepcion(oBitacora_SEG.descripcion)
        '##### EJECUTO TRAZA VIA BLL SEGUN TIPO DE EXCP QUE CORRESPONDA #####
        interfazNegocioBitacora.registrarEnBitacora_BKP(idUsuario, exc_BKP)
        interfazNegocioBitacora.registrarEnBitacora_BLL(idUsuario, exc_BLL)
        interfazNegocioBitacora.registrarEnBitacora_DAL(idUsuario, exc_DAL)
        interfazNegocioBitacora.registrarEnBitacora_IO(idUsuario, exc_IO)
        interfazNegocioBitacora.registrarEnBitacora_SEG(idUsuario, exc_SEG)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If enu.Current.componente = "btn_bitacoraCSV" Then
                Me.btn_bitacoraCSV.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_digitoVerificador" Then
                Me.btn_digitoVerificador.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_InsertarBitacora" Then
                Me.btn_InsertarBitacora.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_consistenciaBD" Then
                Me.btn_consistenciaBD.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_InsertarUsuario" Then
                Me.btn_InsertarUsuario.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_debug" Then
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