Imports Atlantida.Excepcion.SIS
Imports Atlantida.Entidades.SIS

Namespace SIS.BLL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface INegBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oBKP"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_BKP(ByVal usuarioId As String, ByVal oBKP As Excepcion.SIS.Excepcion.BKPException)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oBLL"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_BLL(ByVal usuarioId As String, ByVal oBLL As Excepcion.SIS.Excepcion.BLLExcepcion)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oDAL"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_DAL(ByVal usuarioId As String, ByVal oDAL As Excepcion.SIS.Excepcion.DALExcepcion)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oIO"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_IO(ByVal usuarioId As String, ByVal oIO As Excepcion.SIS.Excepcion.IOException)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oSEG"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_SEG(ByVal usuarioId As String, ByVal oSEG As Excepcion.SIS.Excepcion.SEGExcepcion)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerEventosBitacora() As List(Of Entidades.SIS.Entidades.Bitacora)
    End Interface
End Namespace
