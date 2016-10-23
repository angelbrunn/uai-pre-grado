Imports System.Data.SqlClient
Imports System.Data
Imports System.Exception
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    Public Class DALVenta
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <param name="fechaVenta"></param>
        ''' <remarks></remarks>
        Public Sub insertarVenta(ByVal idPresupuesto As Integer, ByVal fechaVenta As DateTime)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Ventas(idPresupuesto,fechaVenta) VALUES (@idPresupuesto,@fechaVenta)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = idPresupuesto
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaVenta"
            iPar.DbType = DbType.DateTime
            iPar.Value = fechaVenta
            comando.Parameters.Add(iPar)

            Try
                conex.Open()
                comando.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace

