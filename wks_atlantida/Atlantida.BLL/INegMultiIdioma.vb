Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.BLL
    Public Interface INegMultiIdioma
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerTablaMultiIdioma(ByVal idioma As String) As List(Of MultiIdioma)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerIdiomasDisponibles() As List(Of MultiIdioma)
    End Interface
End Namespace