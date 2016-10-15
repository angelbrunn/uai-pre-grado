Imports System.Data.SqlClient
Imports System.Data
Imports System.Exception
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    Public Class DALPago
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerTablaPago() As List(Of Pago)
            Dim listaPago As New List(Of Pago)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM Pago"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Pago")

                Dim enu As IEnumerator(Of DataRow) = ds.Tables("Pago").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oPago As New Pago
                    oPago.idPagos = CType(enu.Current("idPago"), Integer)
                    oPago.confPago = CType(enu.Current("confirmacionPagoRealizado"), Boolean)
                    oPago.FechPago = CType(enu.Current("fechaPago"), Date)
                    oPago.idPresu = CType(enu.Current("idPresupuesto"), Integer)
                    listaPago.Add(oPago)
                End While
            Catch
            End Try
            Return listaPago
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerPagosActivos() As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_get_pagosActivos")

            Dim connection As New SqlConnection(conexString)
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            '0:Pago Pendiente pero Activo |1:Pago realizado correctamente |2:Pago cancelado
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
        ''' <param name="oPago"></param>
        ''' <remarks></remarks>
        Public Sub registrarPago(ByVal oPago As Pago)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Pago(confirmacionPagoRealizado,idPresupuesto,montoTransporte,montoHospedaje,fechaPago) VALUES (@confirmacionPagoRealizado,@idPresupuesto,@montoTransporte,@montoHospedaje,@fechaPago)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado
            iPar = comando.CreateParameter
            iPar.ParameterName = "confirmacionPagoRealizado"
            iPar.DbType = DbType.Int32
            iPar.Value = oPago.confPago
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = oPago.idPresu
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "montoTransporte"
            iPar.DbType = DbType.Int32
            iPar.Value = oPago.montoAPagarTransporte
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "montoHospedaje"
            iPar.DbType = DbType.Int32
            iPar.Value = oPago.montoAPagarHospedaje
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaPago"
            iPar.DbType = DbType.Date
            iPar.Value = oPago.FechPago
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
        ''' <param name="idPresupuesto"></param>
        ''' <param name="idCuentaCorriente"></param>
        ''' <param name="monto"></param>
        ''' <remarks></remarks>
        Public Sub incrementarCuentaCorriente(ByVal idPresupuesto As Integer, ByVal idCuentaCorriente As Integer, ByVal monto As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Transferencias(idPresupuesto,idCuentaCorriente,monto) VALUES (@idPresupuesto,@idCuentaCorriente,@monto)"

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
            iPar.ParameterName = "idCuentaCorriente"
            iPar.DbType = DbType.Int32
            iPar.Value = idCuentaCorriente
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "monto"
            iPar.DbType = DbType.Int32
            iPar.Value = monto
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
        ''' <param name="idPresupuesto"></param>
        ''' <remarks></remarks>
        Public Sub insertarPresupuestoPago(ByVal idPresupuesto As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO PresupuestoPago(idPresupuesto) VALUES (@idPresupuesto)"

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
        Public Sub cancelarPago(ByVal idx As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Pago SET [confirmacionPagoRealizado]=@confirmacionPagoRealizado WHERE idPresupuesto=@idPresupuesto"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado
            iPar.ParameterName = "confirmacionPagoRealizado"
            iPar.DbType = DbType.Int32
            iPar.Value = 3
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
        ''' <param name="monto"></param>
        ''' <remarks></remarks>
        Public Sub decrementarCaja(ByVal monto As String)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Caja SET [monto]=@monto WHERE id=1"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "monto"
            iPar.DbType = DbType.Int32
            iPar.Value = monto
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
        ''' <param name="idPresupuesto"></param>
        ''' <param name="montoTransporte"></param>
        ''' <remarks></remarks>
        Public Sub decrementarPagoTransporte(ByVal idPresupuesto As String, ByVal montoTransporte As String)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Pago SET [montoTransporte]=@montoTransporte WHERE idPresupuesto=@idPresupuesto"

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

            iPar.ParameterName = "montoTransporte"
            iPar.DbType = DbType.Int32
            iPar.Value = montoTransporte
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
        ''' <param name="idPresupuesto"></param>
        ''' <param name="montoHospedaje"></param>
        ''' <remarks></remarks>
        Public Sub decrementarPagoHospedaje(ByVal idPresupuesto As String, ByVal montoHospedaje As String)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Pago SET [montoHospedaje]=@montoHospedaje WHERE idPresupuesto=@idPresupuesto"

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

            iPar.ParameterName = "montoHospedaje"
            iPar.DbType = DbType.Int32
            iPar.Value = montoHospedaje
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
        ''' <param name="idPresupuesto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerMontoTransporte(ByVal idPresupuesto As Integer)
            Dim ultimoMonto As Integer

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT TOP montoTransporte FROM Pago WHERE idPresupuesto=@idPresupuesto"

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

            Try
                conex.Open()
                ultimoMonto = comando.ExecuteScalar
                conex.Close()

            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
            Return ultimoMonto
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerMontoHospedaje(ByVal idPresupuesto As Integer)
            Dim ultimoMonto As Integer

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT TOP montoHospedaje FROM Pago WHERE idPresupuesto=@idPresupuesto"

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

            Try
                conex.Open()
                ultimoMonto = comando.ExecuteScalar
                conex.Close()

            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
            Return ultimoMonto
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <param name="estado"></param>
        ''' <remarks></remarks>
        Public Sub actualizarEstadoPago(ByVal idPresupuesto As Integer, ByVal estado As String)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Pago SET [confirmacionPagoRealizado]=@confirmacionPagoRealizado WHERE idPresupuesto=@idPresupuesto"

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
            '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado
            iPar = comando.CreateParameter
            iPar.ParameterName = "confirmacionPagoRealizado"
            iPar.DbType = DbType.String
            iPar.Value = estado
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
        ''' <param name="idPresupuesto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function consultarTipoTransferencia(ByVal idPresupuesto As Integer) As Integer
            Dim tipoTransferencia As Integer

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT confirmacionPagoRealizado FROM Pago WHERE idPresupuesto=@idPresupuesto"

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

            Try
                conex.Open()
                tipoTransferencia = comando.ExecuteScalar
                conex.Close()

            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
            Return tipoTransferencia
        End Function
    End Class
End Namespace
