Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.Seguridad
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface IHash
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sCadena"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function generarSHA(ByVal sCadena As String) As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="cadena"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerHash(ByVal cadena As String) As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oUsuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerHashUsuario(ByVal oUsuario As Usuario) As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function verificarConsistenciaBD() As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="listaUsuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function calcularHashTablaUsuario(ByVal listaUsuario As List(Of Usuario)) As List(Of Usuario)
    End Interface
End Namespace
