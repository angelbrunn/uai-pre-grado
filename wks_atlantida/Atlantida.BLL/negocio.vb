Imports Atlantida.DAL.Atlantida.DAL

Public Class negocio
    'Creamos un objeto de tipo dato
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim d As New dato
    'Definimos un constructor por defecto
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub
    'Servicio validacion de frm:login
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="usr"></param>
    ''' <param name="pass"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function login(usr As String, pass As String) As Boolean
        If d.validalogin(usr, pass) = True Then
            'informo que el usuario existe, true - ingreso
            Return True
        Else
            d.validalogin(usr, pass)
            'informo que el usuario no existe, flase - no ingresa
            Return False
        End If
    End Function
    'Servicio Agregar frm:usuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nom"></param>
    ''' <param name="ape"></param>
    ''' <param name="usr"></param>
    ''' <param name="leg"></param>
    ''' <param name="sec"></param>
    ''' <param name="per"></param>
    ''' <param name="pwd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function agregar(nom As String, ape As String, usr As String, leg As String, sec As String, per As String, pwd As String) As Boolean
        If d.validauser(usr) = True Then
            'Informar que ya existe - true - informar que el usuario  ya ha sido dado de alta posteriormente
            Return True
        Else
            d.agregar(nom, ape, usr, leg, sec, per, pwd)
            'Informar que el user ha sido dado de alta
            Return False
        End If
    End Function
    'Servicio Borrar frm:usuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="usr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function borrar(usr As String) As Boolean
        If d.validauser(usr) = False Then
            'Informar que no existe - false - informar que el usuario no existe
            Return False
        Else
            d.borrar(usr)
            'Informar que el user ha sido borrado
            Return True
        End If
    End Function
    'Servicio modificar frm:usuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nom"></param>
    ''' <param name="ape"></param>
    ''' <param name="usr"></param>
    ''' <param name="leg"></param>
    ''' <param name="sec"></param>
    ''' <param name="per"></param>
    ''' <param name="pwd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function modificar(nom As String, ape As String, usr As String, leg As String, sec As String, per As String, pwd As String) As Boolean
        If d.validauser(usr) = False Then
            'Informar que no existe - false - informar que el usuario no ha sido modificado
            Return False
        Else
            d.modificar(nom, ape, usr, leg, sec, per, pwd)
            'Informar que el user ha sido modificado
            Return True
        End If
    End Function
    'Servicio autocompletar frm:usuario
    'PENDIENTE DE DESARROLLAR - FIXME:

    'Servicio disponibilidadpasajes frm:pasajes
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="origen"></param>
    ''' <param name="destino"></param>
    ''' <param name="tipotrans"></param>
    ''' <param name="fechasalida"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function disponibiliadPasajes(origen As String, destino As String, tipotrans As String, fechasalida As String) As DataTable
        Return d.disponibiliadPasajes(origen, destino, tipotrans, fechasalida)
    End Function
End Class
