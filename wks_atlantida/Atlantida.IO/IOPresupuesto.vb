Imports System.IO
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.IO
    Public Class IOPresupuesto
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoPresupuesto(ByVal ruta As String, ByVal delim As String) As List(Of Presupuesto)
            Dim lista As New List(Of Presupuesto)
            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oPresupuesto As New Presupuesto
                            oPresupuesto.idPaqPromocionable = CType(vec(0), Integer)
                            oPresupuesto.codCliente = CType(vec(1), String)
                            oPresupuesto.legPresu = CType(vec(2), Integer)
                            oPresupuesto.destPres = CType(vec(3), String)
                            oPresupuesto.FechPartida = CType(vec(4), Date)
                            oPresupuesto.FechRegreso = CType(vec(5), Date)
                            oPresupuesto.idPaqPromocionable = CType(vec(6), Integer)
                            oPresupuesto.FechCreacion = CType(vec(7), Date)
                            lista.Add(oPresupuesto)
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
        ''' <param name="listaPresupuesto"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoPresupuesto(ByVal ruta As String, ByVal delim As String, ByVal listaPresupuesto As List(Of Presupuesto))

            'legajo;apellido;nombre;telefono;domicilio;fechaNacimiento;activo
            Dim cabecera As String = "idPresupuesto;codigoCliente;legajo;destino;fechaPartida;fechaRegreso;idPaquetePromocionable;fechaCreacion"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Presupuesto) = listaPresupuesto.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idPresu.ToString() + ";" + enumC.Current.codCliente _
                + ";" + enumC.Current.legPresu.ToString() + ";" + enumC.Current.destPres + ";" + _
                enumC.Current.FechPartida.ToString() + ";" + enumC.Current.FechRegreso.ToString() + ";" + _
                enumC.Current.idPaqPromocionable.ToString + ";" + enumC.Current.FechCreacion.ToString()

                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
    End Class
End Namespace

