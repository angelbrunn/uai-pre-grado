Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    Public Class NegCobro
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoCobro(ByVal ruta As String, ByVal delim As String)
            Dim oIOCobro As New IOCobro
            Dim listaCobro As New List(Of Cobro)
            Dim oDalCobro As New DALCobro
            Try
                listaCobro = oDalCobro.obtenerTablaCobro()
                oIOCobro.escribirArchivoCobro(ruta, delim, listaCobro)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoCobro(ByVal ruta As String, ByVal delim As String)
            Dim oIOCobro As New IOCobro
            Dim oDalCobro As New DALCobro
            Dim listaCobro As New List(Of Cobro)

            listaCobro = oIOCobro.leerArchivoCobro(ruta, delim)

            Dim enu As IEnumerator(Of Cobro) = listaCobro.GetEnumerator
            While enu.MoveNext
                oDalCobro.insertarCobro(enu.Current)
            End While
        End Sub
    End Class
End Namespace
