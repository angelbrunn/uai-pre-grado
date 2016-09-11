Imports System.Data.SqlClient
Imports Atlantida.Excepcion.SIS.Excepcion
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.DAL
    Public Class DALHospedaje
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function hospedajesDisponibles_2() As List(Of Hospedaje)
            Dim listaHospedaje As New List(Of Hospedaje)

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT DISTINCT idProvHos,razonSocial,montoAPagar,categoria,descripcion FROM Hospedaje "

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "Hospedaje")
                Dim enu As IEnumerator(Of DataRow) = ds.Tables("Hospedaje").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oHospedaje As New Hospedaje
                    oHospedaje.idHospedaje = enu.Current("idProvHos").ToString
                    oHospedaje.razSocial = enu.Current("razonSocial").ToString
                    oHospedaje.monPagar = enu.Current("montoAPagar").ToString
                    oHospedaje.cat = enu.Current("categoria").ToString
                    oHospedaje.desc = enu.Current("descripcion").ToString
                    listaHospedaje.Add(oHospedaje)
                End While
            Catch
            End Try
            Return listaHospedaje
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function hospedajesDisponibles() As DataTable
            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim command As New SqlCommand("sp_hospedajes_disponibles")

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

