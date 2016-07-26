Imports System.IO
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.IO
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class IOBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oBitacora"></param>
        ''' <remarks></remarks>
        Public Sub registrarEnBitacoraIO(ByVal oBitacora As Bitacora)
            Dim delimitador As String = ";"
            Dim ruta As String = "C:\Logs Atlantida\log.csv"
            Dim cabecera As String = "idEvento" + delimitador + "idUsuario" + delimitador + "descripcion" + delimitador + "fecha"
            Try
                Dim archivo As New StreamWriter(ruta, True)
                archivo.WriteLine(cabecera)
                Dim linea As String
                Dim idEvento As String = oBitacora.idEvento.ToString
                Dim idUsuario As String = oBitacora.idUsuario.ToString
                Dim descripcion As String = oBitacora.descripcion.ToString
                Dim fecha As String = oBitacora.fecha.ToString
                linea = idEvento + delimitador + idUsuario + delimitador _
                + descripcion + delimitador + fecha
                archivo.WriteLine(linea)
                archivo.Close()
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace
