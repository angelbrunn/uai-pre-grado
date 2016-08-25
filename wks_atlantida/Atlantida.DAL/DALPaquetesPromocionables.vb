Imports System.Data.SqlClient
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    Public Class DALPaquetesPromocionables
        Public Function obtenerUltimoId() As Integer
            Dim ultimoId As Integer

            'SELECT MAX(idEvento) FROM tbl_Bitacora
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT MAX(idPaquetePromocionable) FROM PaquetesPromocionable"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Try
                conex.Open()
                ultimoId = comando.ExecuteScalar
                conex.Close()

            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
            Return ultimoId
        End Function
    End Class
End Namespace
