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
            Dim sqlQuery As String = "INSERT INTO Presupuesto([idCobro],[dPresupuesto],[monto],[nroFactura],[ventaCancelada],[fechaCobro] VALUES (@idCobro,@dPresupuesto,@monto,@nroFactura,@ventaCancelada,@fechaCobro)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "idCobro"
            iPar.DbType = DbType.Int32
            iPar.Value = oCobro.idCobros
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "dPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = oCobro.idPresu
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "monto"
            iPar.DbType = DbType.Double
            iPar.Value = oCobro.montos
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "nroFactura"
            iPar.DbType = DbType.Int32
            iPar.Value = oCobro.numeroFactura
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "ventaCancelada"
            iPar.DbType = DbType.Boolean
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
    End Class
End Namespace

