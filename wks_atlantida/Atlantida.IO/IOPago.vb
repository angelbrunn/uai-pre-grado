Imports System.IO
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.IO
    Public Class IOPago
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoCobro(ByVal ruta As String, ByVal delim As String) As List(Of Pago)
            Dim lista As New List(Of Pago)
            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oPago As New Pago
                            oPago.idPagos = CType(vec(0), Integer)
                            oPago.confPago = CType(vec(1), Boolean)
                            oPago.FechPago = CType(vec(2), Date)
                            oPago.idPresu = CType(vec(3), Integer)
                            lista.Add(oPago)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try
            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaPago"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoCobro(ByVal ruta As String, ByVal delim As String, ByVal listaPago As List(Of Pago))

            Dim cabecera As String = "idPago;confirmacionPagoRealizado;fechaPago;idPresupuesto"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Pago) = listaPago.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idPagos.ToString() + ";" + enumC.Current.confPago _
                + ";" + enumC.Current.FechPago.ToString() + ";" + enumC.Current.idPresu.ToString()
            End While
            sw.Close()
        End Sub
    End Class
End Namespace

