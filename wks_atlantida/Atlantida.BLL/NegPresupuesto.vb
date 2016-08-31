Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    Public Class NegPresupuesto
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private unUsuarioField As Usuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_cliente"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function insertarCliente(ByVal _cliente As Cliente)
            Dim oDalCliente As New DALCLiente
            Try
                oDalCliente.insertarCliente(_cliente)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_cliente"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function modificarCliente(ByVal _cliente As Cliente)
            Dim oDalCliente As New DALCLiente
            Try
                oDalCliente.modificarCliente(_cliente)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_cliente"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function inhabilitarCliente(ByVal _dni As String)
            Dim oDalCliente As New DALCLiente
            Try
                oDalCliente.marcarClienteInactivo(_dni)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_dni"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function validarCliente(ByVal _dni As String) As Cliente
            Dim _Cliente As New Cliente
            Dim oDalCliente As New DALCLiente
            Try
                _Cliente = oDalCliente.validarCliente(_dni)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
            Return _Cliente
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerDestinosDisponibles() As List(Of Destinos)
            Dim listadoDestinos As New List(Of Destinos)(New Destinos() {})
            Dim oDalDestinos As New DALPresupuesto
            Try
                listadoDestinos = oDalDestinos.destinosDisponibles()
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoDestinos
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPaquetesPromo() As DataTable
            Dim listadoPaquetesProm As DataTable
            listadoPaquetesProm = Nothing
            Dim oDalPaquetesPromocionables As New DALPresupuesto
            Try
                listadoPaquetesProm = oDalPaquetesPromocionables.paquetesPromoDisp()
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoPaquetesProm
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub exportarAArchivoPresupuesto(ByVal ruta As String, ByVal delim As String)
            Dim oIOPresupuesto As New IOPresupuesto
            Dim listaPresupuesto As New List(Of Presupuesto)
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                listaPresupuesto = oDalPresupuesto.obtenerTablaPresupuesto()
                oIOPresupuesto.escribirArchivoPresupuesto(ruta, delim, listaPresupuesto)
            Catch ex As Exception
            End Try
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <remarks></remarks>
        Sub importarDesdeArchivoPresupuesto(ByVal ruta As String, ByVal delim As String)
            Dim oIOPresupuesto As New IOPresupuesto
            Dim oDalPresupuesto As New DALPresupuesto
            Dim listaPresupuesto As New List(Of Presupuesto)

            listaPresupuesto = oIOPresupuesto.leerArchivoPresupuesto(ruta, delim)

            Dim enu As IEnumerator(Of Presupuesto) = listaPresupuesto.GetEnumerator
            While enu.MoveNext
                oDalPresupuesto.insertarPresupuesto(enu.Current)
            End While
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property unUsuario() As Usuario
            Get
                Return unUsuarioField
            End Get
            Set(ByVal value As Usuario)
                unUsuarioField = value
            End Set
        End Property
    End Class
End Namespace
