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
        Public Sub insertarPago(ByVal oPago As Pago)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Pago(confirmacionPagoRealizado,idPresupuesto,fechaPago) VALUES (@confirmacionPagoRealizado,@idPresupuesto,@fechaPago)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

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
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerCotizacionMoneda(ByVal idDivisa As Integer) As Integer
            Dim ultimaCotizacion As Integer

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT TOP 1 valorActual FROM Divisa WHERE idDivisa=@idDivisa"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar = comando.CreateParameter
            iPar.ParameterName = "idDivisa"
            iPar.DbType = DbType.Int32
            iPar.Value = idDivisa
            comando.Parameters.Add(iPar)

            Try
                conex.Open()
                ultimaCotizacion = comando.ExecuteScalar
                conex.Close()

            Catch ex As SqlException
                Throw New DALExcepcion(ex.Message)
            End Try
            Return ultimaCotizacion
        End Function
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
            '0:Pago Pendiente pero Activo |1:Pago realizado correctamente |2:Pago cancelado
            iPar.ParameterName = "confirmacionPagoRealizado"
            iPar.DbType = DbType.Int32
            iPar.Value = 2
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







        Public Sub actualizarPago(ByVal idPresupuesto As Integer, ByVal monto As Integer)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "UPDATE Pago SET [confirmacionPagoRealizado]=@confirmacionPagoRealizado WHERE idPresupuesto=@idPresupuesto"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter
            '0:Pago Pendiente pero Activo |1:Pago realizado correctamente |2:Pago cancelado
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = idPresupuesto
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




    End Class
End Namespace
