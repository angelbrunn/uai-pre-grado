Imports System.Data.SqlClient
Imports System.Data
Imports System.Exception
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    Public Class DALCobro
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerTablaCobro() As List(Of Cobro)
            Dim listaCobro As New List(Of Cobro)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Cobro"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Cobro")

                Dim enu As IEnumerator(Of DataRow) = ds.Tables("Cobro").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oCobro As New Cobro
                    oCobro.idCobros = CType(enu.Current("idCobro"), Integer)
                    oCobro.idPresu = CType(enu.Current("dPresupuesto"), Integer)
                    oCobro.montos = CType(enu.Current("monto"), Double)
                    oCobro.numeroFactura = CType(enu.Current("nroFactura"), Integer)
                    oCobro.ventaCancel = CType(enu.Current("ventaCancelada"), Boolean)
                    oCobro.FechCobro = CType(enu.Current("fechaCobro"), Date)
                    listaCobro.Add(oCobro)
                End While
            Catch
            End Try
            Return listaCobro
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oCobro"></param>
        ''' <remarks></remarks>
        Public Sub insertarCobro(ByVal oCobro As Cobro)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Cobro(idPresupuesto,nroFactura,monto,ventaCancelada,fechaCobro) VALUES (@idPresupuesto,@nroFactura,@monto,@ventaCancelada,@fechaCobro)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = oCobro.idPresu
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "nroFactura"
            iPar.DbType = DbType.Int32
            iPar.Value = oCobro.numeroFactura
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "monto"
            iPar.DbType = DbType.Int32
            iPar.Value = oCobro.montos
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "ventaCancelada"
            iPar.DbType = DbType.String
            iPar.Value = oCobro.ventaCancel
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaCobro"
            iPar.DbType = DbType.Date
            iPar.Value = oCobro.FechCobro
            comando.Parameters.Add(iPar)

            Try
                conex.Open()
                comando.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idx"></param>
        ''' <remarks></remarks>
        Public Sub cancelarCobro(ByVal idx As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Cobro SET [ventaCancelada]=@ventaCancelada WHERE idPresupuesto=@idPresupuesto"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            '0:significa que el cobro estaactivo |1:significa cobro cancelado
            iPar.ParameterName = "ventaCancelada"
            iPar.DbType = DbType.Int32
            iPar.Value = 1
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = idx
            comando.Parameters.Add(iPar)

            Try
                conex.Open()
                comando.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerUltimaFactura() As Cobro
            Dim oCobro As New Cobro

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT TOP 1 nroFactura FROM Cobro ORDER BY nroFactura DESC"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "nroFactura")
                Dim dr As DataRow = ds.Tables("nroFactura").Rows.Item(0)

                oCobro.numeroFactura = dr("nroFactura")

            Catch ex As Exception
                Throw New DALExcepcion("Error en BD", ex)
            End Try
            Return oCobro
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dni"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerDeudaCliente(ByVal dni As Integer) As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_deuda_cliente")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@pdni", dni)

            Dim adapter As New SqlDataAdapter(command)
            adapter.SelectCommand.CommandTimeout = 300

            Dim Ada As New SqlDataAdapter(command)
            Dim Dt As New DataTable()
            Ada.Fill(Dt)
            connection.Close()
            Return Dt
        End Function
    End Class
End Namespace

