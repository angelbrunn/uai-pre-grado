Imports System.IO
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.IO
    Public Class IOCobro
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoCobro(ByVal ruta As String, ByVal delim As String) As List(Of Cobro)
            Dim lista As New List(Of Cobro)
            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oCobro As New Cobro
                            oCobro.idCobros = CType(vec(0), Integer)
                            oCobro.idPresu = CType(vec(1), Integer)
                            oCobro.montos = CType(vec(2), Double)
                            oCobro.numeroFactura = CType(vec(3), Integer)
                            oCobro.ventaCancel = CType(vec(4), Boolean)
                            oCobro.FechCobro = CType(vec(5), Date)
                            lista.Add(oCobro)
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
        ''' <param name="listaCobro"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoCobro(ByVal ruta As String, ByVal delim As String, ByVal listaCobro As List(Of Cobro))

            Dim cabecera As String = "idCobro;idPresupuesto;monto;nroFactura;ventaCancelada;fechaCobro"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Cobro) = listaCobro.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idCobros.ToString() + ";" + enumC.Current.idPresu _
                + ";" + enumC.Current.montos.ToString() + ";" + enumC.Current.numeroFactura + ";" + _
                enumC.Current.ventaCancel.ToString() + ";" + enumC.Current.FechCobro.ToString() 
                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
    End Class
End Namespace


