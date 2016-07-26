Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class NegMultiIdioma
        Implements INegMultiIdioma
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private unUsuarioField As Usuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerTablaMultiIdioma(ByVal idioma As String) As List(Of MultiIdioma) Implements INegMultiIdioma.obtenerTablaMultiIdioma
            Dim listaMultiIdioma As New List(Of MultiIdioma)(New MultiIdioma() {})
            Dim oDalMultiIdioma As New DALMultiIdioma

            Try
                listaMultiIdioma = oDalMultiIdioma.obtenerTablaMultiIdioma(idioma)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listaMultiIdioma
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerIdiomasDisponibles() As List(Of MultiIdioma) Implements INegMultiIdioma.obtenerIdiomasDisponibles
            Dim listaIdiomas As New List(Of MultiIdioma)(New MultiIdioma() {})
            Dim oDalMultiIdioma As New DALMultiIdioma

            Try
                listaIdiomas = oDalMultiIdioma.idiomasDisponibles()
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listaIdiomas
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property unUsuario() As Usuario
            Get
                Return unUsuarioField
            End Get
            Set(ByVal value As Usuario)
                unUsuarioField = value
            End Set
        End Property
    End Class
End Namespace