Imports System.Data.SqlClient
Imports System.Data
Imports System.Exception
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    Public Class DALPresupuesto
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function destinosDisponibles() As List(Of Destinos)
            Dim listaDisponibles As New List(Of Destinos)

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT DISTINCT destino FROM Disponibles "

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Disponibles")
                Dim enu As IEnumerator(Of DataRow) = ds.Tables("Disponibles").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oDestino As New Destinos
                    oDestino.destino = enu.Current("destino").ToString
                    listaDisponibles.Add(oDestino)
                End While
            Catch
            End Try
            Return listaDisponibles
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function paquetesPromoDisp() As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_paquetes_promocionables")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            adapter.SelectCommand.CommandTimeout = 300

            Dim Ada As New SqlDataAdapter(command)
            Dim Dt As New DataTable()
            Ada.Fill(Dt)
            connection.Close()
            Return Dt
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="origen"></param>
        ''' <param name="destino"></param>
        ''' <param name="fechIda"></param>
        ''' <param name="fechVuelta"></param>
        ''' <param name="medioTransp"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function paquetesNoPromo(ByVal origen As String, ByVal destino As String, ByVal fechIda As String, ByVal fechVuelta As String, ByVal medioTransp As String) As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_paquetes_no_promocionables")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@pOrigen", origen)
            command.Parameters.AddWithValue("@pDestino", destino)
            command.Parameters.AddWithValue("@pFIda", fechIda)
            command.Parameters.AddWithValue("@pFVta", fechVuelta)
            command.Parameters.AddWithValue("@pMedioTransp", medioTransp)

            Dim adapter As New SqlDataAdapter(command)
            adapter.SelectCommand.CommandTimeout = 300

            Dim Ada As New SqlDataAdapter(command)
            Dim Dt As New DataTable()
            Ada.Fill(Dt)
            connection.Close()
            Return Dt
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerTablaPresupuesto() As List(Of Presupuesto)
            Dim listaPresupuesto As New List(Of Presupuesto)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Presupuesto"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Presupuesto")

                Dim enu As IEnumerator(Of DataRow) = ds.Tables("Presupuesto").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oPresupuesto As New Presupuesto
                    oPresupuesto.idPresu = CType(enu.Current("idPresupuesto"), Integer)
                    oPresupuesto.codCliente = enu.Current("codigoCliente")
                    oPresupuesto.legPresu = CType(enu.Current("legajo"), Integer)
                    oPresupuesto.destPres = enu.Current("destino")
                    oPresupuesto.FechPartida = CType(enu.Current("fechaPartida"), Date)
                    oPresupuesto.FechRegreso = CType(enu.Current("fechaRegreso"), Date)
                    oPresupuesto.idPaqPromocionable = CType(enu.Current("idPaquetePromocionable"), Integer)
                    oPresupuesto.FechCreacion = CType(enu.Current("fechaCreacion"), Date)
                    listaPresupuesto.Add(oPresupuesto)
                End While
            Catch
            End Try
            Return listaPresupuesto
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerPresupuestoPorId(ByVal idPresupuesto As Integer) As Presupuesto
            Dim oPresupuesto As New Presupuesto

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Presupuesto WHERE idPresupuesto=@idPresupuesto"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = idPresupuesto
            comando.Parameters.Add(iPar)

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Presupuesto")
                Dim dr As DataRow = ds.Tables("Presupuesto").Rows.Item(0)

                oPresupuesto.idPresu = dr("idPresupuesto")
                oPresupuesto.codCliente = dr("codigoCliente")
                oPresupuesto.legPresu = dr("legajo")
                oPresupuesto.destPres = dr("destino")
                oPresupuesto.FechPartida = dr("fechaPartida")
                oPresupuesto.FechRegreso = dr("fechaRegreso")
                oPresupuesto.PasajerosPresu = dr("pasajeros")
                oPresupuesto.idPaqPromocionable = dr("idPaquetePromocionable")
                oPresupuesto.FechCreacion = dr("fechaCreacion")
                oPresupuesto.EstadoPresu = dr("estado")
                oPresupuesto.IdTransp = dr("idPresupuestoTransporte")

            Catch ex As Exception
                Throw New DALExcepcion("Error en BD", ex)
            End Try
            Return oPresupuesto
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getPresupueto() As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_get_presupuesto")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure


            Dim adapter As New SqlDataAdapter(command)
            adapter.SelectCommand.CommandTimeout = 300


            Dim Ada As New SqlDataAdapter(command)
            Dim Dt As New DataTable()
            Ada.Fill(Dt)
            connection.Close()
            Return Dt
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idx"></param>
        ''' <param name="estado"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function setEstadoPresupuesto(ByVal idx As Integer, ByVal estado As String)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_set_estadoPresupuesto")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@idPresupuesto", idx)
            command.Parameters.AddWithValue("@estado", estado)

            Dim adapter As New SqlDataAdapter(command)
            adapter.SelectCommand.CommandTimeout = 300

            Try
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idx"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getPresupuetoById(ByVal idx As Integer) As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_get_presupuestoById")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@idPresupuesto", idx)

            Dim adapter As New SqlDataAdapter(command)
            adapter.SelectCommand.CommandTimeout = 300


            Dim Ada As New SqlDataAdapter(command)
            Dim Dt As New DataTable()
            Ada.Fill(Dt)
            connection.Close()
            Return Dt
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oPresupuesto"></param>
        ''' <param name="_idhospedaje"></param>
        ''' <remarks></remarks>
        Public Sub insertarPresupuesto(ByVal oPresupuesto As Presupuesto, ByVal _idhospedaje As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Presupuesto([codigoCliente],[legajo],[destino],[fechaPartida],[fechaRegreso],[pasajeros],[idPaquetePromocionable],[fechaCreacion],[estado],[idPresupuestoTransporte],[idPresupuestoHotel]) VALUES (@codigoCliente,@legajo,@destino,@fechaPartida,@fechaRegreso,@pasajeros,@idPaquetePromocionable,@fechaCreacion,@estado,@idPresupuestoTransporte,@idPresupuestoHotel)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar = comando.CreateParameter
            iPar.ParameterName = "codigoCliente"
            iPar.DbType = DbType.String
            iPar.Value = oPresupuesto.codCliente
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "legajo"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.legPresu
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "destino"
            iPar.DbType = DbType.String
            iPar.Value = oPresupuesto.destPres
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaPartida"
            iPar.DbType = DbType.Date
            iPar.Value = oPresupuesto.FechPartida
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaRegreso"
            iPar.DbType = DbType.Date
            iPar.Value = oPresupuesto.FechRegreso
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "pasajeros"
            iPar.DbType = DbType.String
            iPar.Value = oPresupuesto.PasajerosPresu
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPaquetePromocionable"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.idPaqPromocionable
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaCreacion"
            iPar.DbType = DbType.Date
            iPar.Value = oPresupuesto.FechCreacion
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "estado"
            iPar.DbType = DbType.String
            iPar.Value = oPresupuesto.EstadoPresu
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuestoTransporte"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.IdTransp
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuestoHotel"
            iPar.DbType = DbType.Int32
            iPar.Value = _idhospedaje
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
        ''' <param name="idProvHos"></param>
        ''' <remarks></remarks>
        Public Sub insertarPresupuestoHospedaje(ByVal idPresupuesto As Integer, ByVal idProvHos As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO PresupuestoHospedaje([idPresupuesto],[idProvHos]) VALUES (@idPresupuesto,@idProvHos)"

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
            iPar.ParameterName = "idProvHos"
            iPar.DbType = DbType.Int32
            iPar.Value = idProvHos
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
        ''' <param name="idProvTrans"></param>
        ''' <remarks></remarks>
        Public Sub insertarPresupuestoTransporte(ByVal idPresupuesto As Integer, ByVal idProvTrans As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO PresupuestoTransporte([idPresupuesto],[idProvTrans]) VALUES (@idPresupuesto,@idProvTrans)"

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
            iPar.ParameterName = "idProvTrans"
            iPar.DbType = DbType.Int32
            iPar.Value = idProvTrans
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
        ''' <param name="oPresupuesto"></param>
        ''' <remarks></remarks>
        Public Sub descontarPaquetePromo(ByVal oPresupuesto As Presupuesto)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE PaquetesPromocionable SET [cantidadPasajero]=@cantidadPasajero WHERE idPaquetePromocionable=@idPaquetePromocionable"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "idPaquetePromocionable"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.idPaqPromocionable
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "cantidadPasajero"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.dispPresu
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
        ''' <param name="oPresupuesto"></param>
        ''' <remarks></remarks>
        Public Sub descontarPaqueteNoPromo(ByVal oPresupuesto As Presupuesto)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Operaciones SET [capacidad]=@capacidad WHERE idOp=@idOp"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "idOp"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.idPaqueteNoPromocionable
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "capacidad"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.dispPresu
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

