Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.BLL
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface INegMultiUsuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oUsuario"></param>
        ''' <remarks></remarks>
        Sub insertarUsuario(ByVal oUsuario As Entidades.SIS.Entidades.Usuario)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerIdParaUsuario() As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idUsuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerUsuario(ByVal idUsuario As Integer) As Usuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerUsuarioPorLegajo(ByVal legajo As Integer) As Usuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuario"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function validarExistenciaUsuario(ByVal usuario As String) As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oVendedor"></param>
        ''' <remarks></remarks>
        Sub insertarVendedor(ByVal oVendedor As Vendedor)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="oVendedor"></param>
        ''' <remarks></remarks>
        Sub actualizarVendedor(ByVal oVendedor As Vendedor)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <remarks></remarks>
        Sub marcarVendedorComoInactivo(ByVal legajo As Integer)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerIdParaVendedor() As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="legajo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerVendedorPorLegajo(ByVal legajo As Integer) As Vendedor
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idGrupo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerGrupoPorId(ByVal idGrupo As Integer) As Grupo
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerGrupos() As List(Of Grupo)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nombreGrupo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerDescripcionGrupoPorNombre(ByVal nombreGrupo As String) As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nombreGrupo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerGrupoPorNombre(ByVal nombreGrupo As String) As Grupo
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPermiso"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPermisoPorId(ByVal idPermiso As Integer) As Permiso
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="usuario"></param>
        ''' <param name="password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function login(ByVal usuario As String, ByVal password As String) As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function verificarConsistenciaBD() As Boolean
    End Interface
End Namespace
