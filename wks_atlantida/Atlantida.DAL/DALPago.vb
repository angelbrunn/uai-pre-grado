﻿Imports System.Data.SqlClient
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
        ''' <param name="oPago"></param>
        ''' <remarks></remarks>
        Public Sub insertarPago(ByVal oPago As Pago)
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "INSERT INTO Pago([idPago],[confirmacionPagoRealizado],[fechaPago],[idPresupuesto]) VALUES (@idPago,@confirmacionPagoRealizado,@fechaPago,@idPresupuesto)"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim iPar As IDataParameter = comando.CreateParameter

            iPar.ParameterName = "idPago"
            iPar.DbType = DbType.Int32
            iPar.Value = oPago.idPagos
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "confirmacionPagoRealizado"
            iPar.DbType = DbType.Boolean
            iPar.Value = oPago.confPago
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "fechaPago"
            iPar.DbType = DbType.Date
            iPar.Value = oPago.FechPago
            comando.Parameters.Add(iPar)

            iPar = comando.CreateParameter
            iPar.ParameterName = "idPresupuesto"
            iPar.DbType = DbType.Int32
            iPar.Value = oPago.idPresu
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
