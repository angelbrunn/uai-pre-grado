Imports Atlantida.Bitacora.SIS_BIT.Bitacora
Imports Atlantida.Excepcion.SIS
Imports Atlantida.Entidades.SIS

Namespace SIS.BLL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class NegBitacora
        Implements INegBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oBKP"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_BKP(ByVal usuarioId As String, ByVal oBKP As Excepcion.SIS.Excepcion.BKPException) Implements INegBitacora.registrarEnBitacora_BKP
            Dim oBITBitacora As New BITBitacora
            oBITBitacora.registrarEnBitacora_BKP(usuarioId, oBKP)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oBLL"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_BLL(ByVal usuarioId As String, ByVal oBLL As Excepcion.SIS.Excepcion.BLLExcepcion) Implements INegBitacora.registrarEnBitacora_BLL
            Dim oBITBitacora As New BITBitacora
            oBITBitacora.registrarEnBitacora_BLL(usuarioId, oBLL)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oDAL"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_DAL(ByVal usuarioId As String, ByVal oDAL As Excepcion.SIS.Excepcion.DALExcepcion) Implements INegBitacora.registrarEnBitacora_DAL
            Dim oBITBitacora As New BITBitacora
            oBITBitacora.registrarEnBitacora_DAL(usuarioId, oDAL)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oIO"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_IO(ByVal usuarioId As String, ByVal oIO As Excepcion.SIS.Excepcion.IOException) Implements INegBitacora.registrarEnBitacora_IO
            Dim oBITBitacora As New BITBitacora
            oBITBitacora.registrarEnBitacora_IO(usuarioId, oIO)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuarioId"></param>
        ''' <param name="oSEG"></param>
        ''' <remarks></remarks>
        Sub registrarEnBitacora_SEG(ByVal usuarioId As String, ByVal oSEG As Excepcion.SIS.Excepcion.SEGExcepcion) Implements INegBitacora.registrarEnBitacora_SEG
            Dim oBITBitacora As New BITBitacora
            oBITBitacora.registrarEnBitacora_SEG(usuarioId, oSEG)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerEventosBitacora() As List(Of Entidades.SIS.Entidades.Bitacora) Implements INegBitacora.obtenerEventosBitacora
            Dim listadoEventos As New List(Of Entidades.SIS.Entidades.Bitacora)

            Dim oBitBitacora As New BITBitacora
            listadoEventos = oBitBitacora.obtenerEventos

            Return listadoEventos
        End Function
    End Class
End Namespace
