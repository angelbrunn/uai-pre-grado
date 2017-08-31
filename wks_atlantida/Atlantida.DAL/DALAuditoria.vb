Imports System.Data.SqlClient
Imports System.Data
Imports System.Exception
Imports Atlantida.Excepcion.SIS.Excepcion

Namespace SIS.DAL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DALAuditoria
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function primeraConexion() As Integer
            Dim id As Integer

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT id FROM Config WHERE entidad='DB_SYS' AND estado='OK'"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Try
                conex.Open()
                id = comando.ExecuteScalar
                conex.Close()

            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
            Return id
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub saveConexion()
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Config(id,entidad,estado) VALUES (1,'DB_SYS','OK')"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Try
                conex.Open()
                comando.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace
