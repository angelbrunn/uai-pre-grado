Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    Public Class NegPago
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoPago(ByVal ruta As String, ByVal delim As String)
            Dim oIOPago As New IOPago
            Dim listaPago As New List(Of Pago)
            Dim oDalPago As New DALPago
            Try
                listaPago = oDalPago.obtenerTablaPago()
                oIOPago.escribirArchivoCobro(ruta, delim, listaPago)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoPago(ByVal ruta As String, ByVal delim As String)
            Dim oIOPago As New IOPago
            Dim oDalPago As New DALPago
            Dim listaPago As New List(Of Pago)

            listaPago = oIOPago.leerArchivoCobro(ruta, delim)

            Dim enu As IEnumerator(Of Pago) = listaPago.GetEnumerator
            While enu.MoveNext
                oDalPago.insertarPago(enu.Current)
            End While
        End Sub
    End Class
End Namespace

