Imports System.Data.SqlClient
Imports System.Data
Imports System.Exception
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DALCLiente
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_cliente"></param>
        ''' <remarks></remarks>
        Public Sub insertarCliente(ByVal _cliente As Cliente)

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Cliente"

            Dim adaptador As New SqlDataAdapter(sqlQuery, conexString)
            Dim ds As New DataSet
            Dim cb As New SqlCommandBuilder(adaptador)
            adaptador.UpdateCommand = cb.GetUpdateCommand
            adaptador.InsertCommand = cb.GetInsertCommand
            adaptador.DeleteCommand = cb.GetDeleteCommand
            _cliente.inhabilitar = 1
            Try
                adaptador.Fill(ds, "Cliente")
                Dim dr As DataRow = ds.Tables("Cliente").NewRow
                dr("dni") = CType(_cliente.dni, String)
                dr("nombre") = CType(_cliente.nombreCliente, String)
                dr("apellido") = CType(_cliente.apellidoCliente, String)
                dr("email") = CType(_cliente.emailCliente, String)
                dr("telefono") = CType(_cliente.telefono, String)
                dr("fechaNac") = CType(_cliente.fecNacimiento, String)
                dr("inhibicion") = CType(_cliente.inhabilitar, Integer)
                ds.Tables("Cliente").Rows.Add(dr)

                adaptador.Update(ds, "Cliente")
            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_cliente"></param>
        ''' <remarks></remarks>
        Public Sub modificarCliente(ByVal _cliente As Cliente)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Cliente SET [dni]=@dni,[nombre]=@nombre,[apellido]=@apellido,[email]=@email,[telefono]=@telefono,[fechaNac]=@fechaNac WHERE dni=@dni"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "dni"
            iPar.DbType = DbType.Int32
            iPar.Value = _cliente.dni
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "nombre"
            iPar.DbType = DbType.String
            iPar.Value = _cliente.nombre
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "apellido"
            iPar.DbType = DbType.String
            iPar.Value = _cliente.apellido
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "email"
            iPar.DbType = DbType.String
            iPar.Value = _cliente.email
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "telefono"
            iPar.DbType = DbType.String
            iPar.Value = _cliente.telefono
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaNac"
            iPar.DbType = DbType.Date
            iPar.Value = _cliente.fecNacimiento
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
        ''' <param name="dni"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function validarCliente(ByVal dni As String) As Cliente
            Dim oCliente As New Cliente

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Cliente WHERE [dni]=@dni"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            iPar.ParameterName = "dni"
            iPar.DbType = DbType.String
            iPar.Value = dni
            comando.Parameters.Add(iPar)

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Cliente")
                Dim dr As DataRow = ds.Tables("Cliente").Rows.Item(0)

                oCliente.dni = dr("dni")
                oCliente.nombre = dr("nombre")
                oCliente.apellido = dr("apellido")
                oCliente.email = dr("email")
                oCliente.telefono = dr("telefono")
                oCliente.fecNacimiento = dr("fechaNac")
                oCliente.inhabilitar = dr("inhibicion")

            Catch ex As Exception
                Throw New DALExcepcion("Error en BD", ex)
            End Try
            Return oCliente
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_dni"></param>
        ''' <remarks></remarks>
        Public Sub marcarClienteInactivo(ByVal _dni As String)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Cliente SET [inhibicion]=@inhibicion WHERE dni=@dni"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "dni"
            iPar.DbType = DbType.String
            iPar.Value = _dni
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "inhibicion"
            iPar.DbType = DbType.Int16
            iPar.Value = 0
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
        ''' <param name="listaClientes"></param>
        ''' <remarks></remarks>
        Public Sub insertarPasajero(ByVal listaClientes As List(Of Cliente))

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Pasajero"

            Dim adaptador As New SqlDataAdapter(sqlQuery, conexString)
            Dim ds As New DataSet
            Dim cb As New SqlCommandBuilder(adaptador)
            adaptador.UpdateCommand = cb.GetUpdateCommand
            adaptador.InsertCommand = cb.GetInsertCommand
            adaptador.DeleteCommand = cb.GetDeleteCommand

            Try
                adaptador.Fill(ds, "Pasajero")
                Dim enu As IEnumerator(Of Cliente) = listaClientes.GetEnumerator

                While enu.MoveNext
                    Dim dr As DataRow = ds.Tables("Pasajero").NewRow
                    dr("dni") = CType(enu.Current.dni, String)
                    dr("apellido") = CType(enu.Current.apellidoCliente, String)
                    dr("nombre") = CType(enu.Current.nombreCliente, String)
                    'FIXME:FechaNac y Edad
                    ds.Tables("Bitacora").Rows.Add(dr)
                End While
                adaptador.Update(ds, "Pasajero")
            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
