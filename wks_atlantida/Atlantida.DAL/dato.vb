Imports System.IO
Imports System.Data.SqlClient

Namespace Atlantida.DAL
    Public Class dato
        'Creacion de la conexion
        Dim cn As New SqlConnection("Data Source=DESKTOP-L902MHA\SQLEXPRESS;Initial Catalog=AtlantidaDev;Integrated Security=True")
        'Definimos un constructor por defecto
        Public Sub New()
        End Sub
        'funcion para validar login 
        Public Function validalogin(_usr As String, _pass As String) As Boolean
            cn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM USUARIO WHERE usr_id = '" & _usr & "' and usr_password= '" & _pass & "'", cn)
            Dim c As SqlDataReader = cmd.ExecuteReader
            If c.Read Then
                'Cierro conexion
                cn.Close()
                'Informo que el usuario existe, true
                Return True
            Else
                'Cierro conexion
                cn.Close()
                'Informo que el usuario no existe, false
                Return False
            End If
        End Function
        'funcion para validar login
        Public Function validauser(_usr As String) As Boolean
            cn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM USUARIO WHERE usr_id = '" & _usr & "'", cn)
            Dim c As SqlDataReader = cmd.ExecuteReader
            If c.Read Then
                'Cierro conexion
                cn.Close()
                'Informo que el usuario existe, true
                Return True
            Else
                'Cierro conexion
                cn.Close()
                'Informo que el usuario no existe, false
                Return False
            End If
        End Function
        'funcion o sub rutina agregar
        Public Sub agregar(_nom As String, _ape As String, _usr As String, _leg As String, _sec As String, _per As String, _pwd As String)
            cn.Open()
            Dim cmd As New SqlCommand("INSERT INTO USUARIO (usr_nombre,usr_apellido,usr_id,usr_password,usr_legajo,usr_sector,usr_tipoperfil) values ('" & _nom & "','" & _ape & "','" & _usr & "','" & _pwd & "','" & _leg & "','" & _sec & "','" & _per & "')", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        End Sub
        'funcion o sub rutina borrar
        Public Sub borrar(_usr As String)
            cn.Open()
            Dim cmd As New SqlCommand("DELETE FROM USUARIO WHERE usr_id = '" & _usr & "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        End Sub
        'funcion o sub rutina modificar
        Public Sub modificar(_nom As String, _ape As String, _usr As String, _leg As String, _sec As String, _per As String, _pwd As String)
            cn.Open()
            Dim cmd As New SqlCommand("UPDATE USUARIO SET usr_nombre = '" & _nom & "',usr_apellido ='" & _ape & "' ,usr_password ='" & _pwd & "',usr_legajo ='" & _leg & "',usr_sector ='" & _sec & "',usr_tipoperfil ='" & _per & "'WHERE usr_id=" & _usr & "", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        End Sub
        'Crea el response para el autocompletado
        'PENDIENTE DE DESARROLLAR - FIXME
        'funcion o sub rutina disponibilidadPasajes
        Public Function disponibiliadPasajes(_origen As String, _destino As String, _tipotrans As String, _fechasalida As String) As DataTable
            'Dim strsql As String = "SELECT sal_id AS 'SALIDA ID',rut_origen AS 'ORIGEN',rut_destino AS 'DESTINO',sal_fecha AS 'FECHA SALIDA',dis_tipo_asc AS 'CLASE DE ASCIENTO',dic_cant_asc AS 'CANT ASCIENTO',dis_estado  AS 'DISPONIBILIDAD ASCIENTO' FROM SALIDARUTA INNER JOIN RUTA ON sal_ruta = rut_id INNER JOIN DISPONIBILIDADSALIDA ON sal_id = dis_salida WHERE (rut_origen = '" & _origen & "') AND (rut_destino = '" & _destino & "') AND (rut_tipotransporte = '" & _tipotrans & "') AND (sal_fecha >= CONVERT(DATETIME, '" & _fechasalida & "', 102))"
            Dim strsql As String = "SELECT sal_id AS 'SALIDA ID',rut_origen AS 'ORIGEN',rut_destino AS 'DESTINO',sal_fecha AS 'FECHA SALIDA',dis_tipo_asc AS 'CLASE DE ASCIENTO',dic_cant_asc AS 'CANT ASCIENTO',dis_estado  AS 'DISPONIBILIDAD ASCIENTO' FROM SALIDARUTA INNER JOIN RUTA ON sal_ruta = rut_id INNER JOIN DISPONIBILIDADSALIDA ON sal_id = dis_salida WHERE (rut_origen = '" & _origen & "') AND (rut_destino = '" & _destino & "') AND (sal_fecha >= CONVERT(DATETIME, '" & _fechasalida & "', 102) " & _tipotrans & ")"
            cn.Open()
            Dim ada As SqlDataAdapter = New SqlDataAdapter(strsql, cn)
            Dim dts As New DataSet
            ada.Fill(dts)
            cn.Close()
            Return dts.Tables(0)
        End Function
    End Class
End Namespace
