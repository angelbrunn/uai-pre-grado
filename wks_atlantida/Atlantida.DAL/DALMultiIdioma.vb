Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.Common
Imports Atlantida.Entidades.SIS.Entidades


Namespace SIS.DAL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DALMultiIdioma
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerTablaMultiIdioma(ByVal idioma As String) As List(Of MultiIdioma)
            Dim listaMultiIdioma As New List(Of MultiIdioma)

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM tbl_MultiIdioma where ikey =" + "'" + idioma + "'"

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "MultiIdioma")
                Dim enu As IEnumerator(Of DataRow) = ds.Tables("MultiIdioma").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oMultiIdioma As New MultiIdioma
                    oMultiIdioma.componente = enu.Current("componente").ToString
                    oMultiIdioma.iKey = enu.Current("iKey").ToString
                    oMultiIdioma.value = enu.Current("value").ToString
                    listaMultiIdioma.Add(oMultiIdioma)
                End While
            Catch
            End Try
            Return listaMultiIdioma
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function obtenerTablaMultiIdiomaAll() As List(Of MultiIdioma)
            Dim listaMultiIdioma As New List(Of MultiIdioma)

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT * FROM tbl_MultiIdioma "

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "MultiIdioma")
                Dim enu As IEnumerator(Of DataRow) = ds.Tables("MultiIdioma").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oMultiIdioma As New MultiIdioma
                    oMultiIdioma.componente = enu.Current("componente").ToString
                    oMultiIdioma.iKey = enu.Current("iKey").ToString
                    oMultiIdioma.value = enu.Current("value").ToString
                    listaMultiIdioma.Add(oMultiIdioma)
                End While
            Catch
            End Try
            Return listaMultiIdioma
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function idiomasDisponibles() As List(Of MultiIdioma)
            Dim listaMultiIdioma As New List(Of MultiIdioma)

            Dim conexString As String = System.Configuration.ConfigurationManager.ConnectionStrings("AtlantidaDev").ConnectionString
            Dim sqlQuery As String = "SELECT DISTINCT iKey FROM tbl_MultiIdioma "

            Dim conex As New SqlConnection
            conex.ConnectionString = conexString

            Dim comando As SqlCommand = conex.CreateCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = sqlQuery

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet

            Try
                adapter.Fill(ds, "MultiIdioma")
                Dim enu As IEnumerator(Of DataRow) = ds.Tables("MultiIdioma").Rows.GetEnumerator
                While enu.MoveNext
                    Dim oMultiIdioma As New MultiIdioma
                    oMultiIdioma.iKey = enu.Current("iKey").ToString
                    listaMultiIdioma.Add(oMultiIdioma)
                End While
            Catch
            End Try
            Return listaMultiIdioma
        End Function
    End Class
End Namespace