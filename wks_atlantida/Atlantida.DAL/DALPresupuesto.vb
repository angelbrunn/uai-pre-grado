﻿Imports System.Data.SqlClient
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
        ''' <param name="oPresupuesto"></param>
        ''' <remarks></remarks>
        Public Sub insertarPresupuesto(ByVal oPresupuesto As Presupuesto)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Presupuesto([idPresupuesto],[codigoCliente],[legajo],[destino],[fechaPartida],[fechaRegreso],[idPaquetePromocionable],[fechaCreacion]) VALUES (@idPresupuesto,@codigoCliente,@legajo,@destino,@fechaPartida,@fechaRegreso,@idPaquetePromocionable,@fechaCreacion)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.idPresu
            comando.Parameters.Add(iPar)

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
            iPar.ParameterName = "idPaquetePromocionable"
            iPar.DbType = DbType.Int32
            iPar.Value = oPresupuesto.idPaqPromocionable
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaCreacion"
            iPar.DbType = DbType.Date
            iPar.Value = oPresupuesto.FechCreacion
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

