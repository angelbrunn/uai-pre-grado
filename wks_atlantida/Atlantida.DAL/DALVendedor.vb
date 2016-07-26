Imports System.Data.SqlClient
Imports System.Data
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DALVendedor
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oVendedor"></param>
        ''' <remarks></remarks>
        Public Sub insertarVendedor(ByVal oVendedor As Vendedor)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO tbl_Vendedor([legajo],[apellido],[nombre],[telefono],[domicilio],[fechaNacimiento],[activo]) VALUES (@legajo,@apellido,@nombre,@telefono,@domicilio,@fechaNacimiento,@activo)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "legajo"
            iPar.DbType = DbType.Int32
            iPar.Value = oVendedor.legajo
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "apellido"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.apellido
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "nombre"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.nombre
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "telefono"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.telefono
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "domicilio"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.domicilio
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaNacimiento"
            iPar.DbType = DbType.Date
            iPar.Value = oVendedor.fechaNacimiento
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "activo"
            iPar.DbType = DbType.Boolean
            iPar.Value = oVendedor.activo
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
        Public Function obtenerUltimoId() As Integer
            Dim ultimoId As Integer
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT MAX(legajo) FROM tbl_Vendedor"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Try
                conex.Open()
                ultimoId = comando.ExecuteScalar
                conex.Close()
            Catch ex As Exception
            End Try
            Return ultimoId
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerVendedorPorLegajo(ByVal legajo As Integer) As Vendedor
            Dim oVendedor As New Vendedor
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM tbl_Vendedor WHERE legajo=@legajo"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            iPar.ParameterName = "legajo"
            iPar.DbType = DbType.Int32
            iPar.Value = legajo
            comando.Parameters.Add(iPar)

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Vendedor")
                Dim dr As DataRow = ds.Tables("Vendedor").Rows.Item(0)
                oVendedor.legajo = CType(dr("legajo"), Integer)
                oVendedor.apellido = dr("apellido")
                oVendedor.nombre = dr("nombre")
                oVendedor.telefono = dr("telefono")
                oVendedor.domicilio = dr("domicilio")
                oVendedor.fechaNacimiento = CType(dr("fechaNacimiento"), Date)
                oVendedor.activo = CType(dr("activo"), Boolean)

            Catch
            End Try
            Return oVendedor
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerTablaVendedor() As List(Of Vendedor)
            Dim listaVendedor As New List(Of Vendedor)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM tbl_Vendedor"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Vendedor")

                Dim enu As IEnumerator(Of DataRow) = ds.Tables("Vendedor").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oVendedor As New Vendedor
                    oVendedor.legajo = CType(enu.Current("legajo"), Integer)
                    oVendedor.apellido = enu.Current("apellido")
                    oVendedor.nombre = enu.Current("nombre")
                    oVendedor.telefono = enu.Current("telefono")
                    oVendedor.domicilio = enu.Current("domicilio")
                    oVendedor.fechaNacimiento = CType(enu.Current("fechaNacimiento"), Date)
                    oVendedor.activo = CType(enu.Current("activo"), Boolean)
                    listaVendedor.Add(oVendedor)
                End While
            Catch
            End Try
            Return listaVendedor
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oVendedor"></param>
        ''' <remarks></remarks>
        Public Sub actualizarVendedor(ByVal oVendedor As Vendedor)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE tbl_Vendedor SET [legajo]=@legajo,[apellido]=@apellido,[nombre]=@nombre,[telefono]=@telefono,[domicilio]=@domicilio,[fechaNacimiento]=@fechaNacimiento,[activo]=@activo WHERE legajo=@legajo"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "legajo"
            iPar.DbType = DbType.Int32
            iPar.Value = oVendedor.legajo
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "apellido"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.apellido
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "nombre"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.nombre
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "telefono"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.telefono
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "domicilio"
            iPar.DbType = DbType.String
            iPar.Value = oVendedor.domicilio
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaNacimiento"
            iPar.DbType = DbType.Date
            iPar.Value = oVendedor.fechaNacimiento
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "activo"
            iPar.DbType = DbType.Boolean
            iPar.Value = oVendedor.activo
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
        ''' <param name="legajo"></param>
        ''' <remarks></remarks>
        Public Sub marcarVendedorInactivo(ByVal legajo As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE tbl_Vendedor SET [activo]=@activo WHERE legajo=@legajo"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "legajo"
            iPar.DbType = DbType.Int32
            iPar.Value = legajo
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "activo"
            iPar.DbType = DbType.Boolean
            iPar.Value = False
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
