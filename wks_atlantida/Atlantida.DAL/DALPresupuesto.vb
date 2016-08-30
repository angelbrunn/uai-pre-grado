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
    End Class
End Namespace
