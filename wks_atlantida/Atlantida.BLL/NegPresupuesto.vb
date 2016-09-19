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
        ''' <param name="idCliente"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerCliente(ByVal _dni As Integer) As Cliente
            Dim oDalCliente As New DALCLiente
            Dim _cliente As Cliente
            _cliente = Nothing
            Try
                _cliente = oDalCliente.obtenerClientePorId(_dni)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
            Return _cliente
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
        ''' <param name="_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPresPorId(ByVal _id As Integer) As Presupuesto
            Dim _presupuesto As Presupuesto
            _presupuesto = Nothing
            Dim oPresupuesto As New DALPresupuesto
            Try
                _presupuesto = oPresupuesto.obtenerPresupuestoPorId(_id)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return _presupuesto
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="origen"></param>
        ''' <param name="destino"></param>
        ''' <param name="fechIda"></param>
        ''' <param name="fechVuelta"></param>
        ''' <param name="medioTransp"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPaqueteNoPromo(ByVal origen As String, ByVal destino As String, ByVal fechIda As String, ByVal fechVuelta As String, ByVal medioTransp As String) As DataTable
            Dim listadoPaquetesNoProm As DataTable
            listadoPaquetesNoProm = Nothing
            Dim oDalPaquetesNoPromocionables As New DALPresupuesto
            Try
                listadoPaquetesNoProm = oDalPaquetesNoPromocionables.paquetesNoPromo(origen, destino, fechIda, fechVuelta, medioTransp)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoPaquetesNoProm
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_presupuesto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function insertarPresupuesto(ByVal _presupuesto As Presupuesto)
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                oDalPresupuesto.insertarPresupuesto(_presupuesto, 0)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_presupuesto"></param>
        ''' <param name="_idHospedaje"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function insertarPresupuesto(ByVal _presupuesto As Presupuesto, ByVal _idHospedaje As Integer)
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                oDalPresupuesto.insertarPresupuesto(_presupuesto, _idHospedaje)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idProvHos"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function insertarPresupuestoHospedaje(ByVal idProvHos As Integer)
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                oDalPresupuesto.insertarPresupuestoHospedaje(idProvHos)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idProvTrans"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function insertarPresupuestoTransporte(ByVal idProvTrans As Integer)
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                oDalPresupuesto.insertarPresupuestoTransporte(idProvTrans)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_presupuesto"></param>
        ''' <param name="cantidadPasajeros"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function descontarPaquete(ByVal _presupuesto As Presupuesto, ByVal cantidadPasajeros As Integer)
            Dim oDalPresupuesto As New DALPresupuesto
            Dim _cantidadPasajerosTmp As Integer
            Try
                _cantidadPasajerosTmp = _presupuesto.dispPresu
                _presupuesto.dispPresu = _cantidadPasajerosTmp - cantidadPasajeros
                oDalPresupuesto.descontarPaquetePromo(_presupuesto)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_presupuesto"></param>
        ''' <param name="cantidadPasajeros"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function descontarOperacion(ByVal _presupuesto As Presupuesto, ByVal cantidadPasajeros As Integer)
            Dim oDalPresupuesto As New DALPresupuesto
            Dim _cantidadPasajerosTmp As Integer
            Try
                _cantidadPasajerosTmp = _presupuesto.dispPresu
                _presupuesto.dispPresu = _cantidadPasajerosTmp - cantidadPasajeros
                oDalPresupuesto.descontarPaqueteNoPromo(_presupuesto)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerHospedajesDisponibles() As DataTable
            Dim listadoHospedaje As DataTable
            listadoHospedaje = Nothing
            Dim oDalHospedaje As New DALHospedaje
            Try
                listadoHospedaje = oDalHospedaje.hospedajesDisponibles()
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoHospedaje
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idx"></param>
        ''' <param name="estado"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function setEstadoPresupuesto(ByVal idx As Integer, ByVal estado As String)
            Dim listadoPeresupuesto As DataTable
            listadoPeresupuesto = Nothing
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                listadoPeresupuesto = oDalPresupuesto.setEstadoPresupuesto(idx, estado)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idx"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPresupuestoById(ByVal idx As Integer) As DataTable
            Dim listadoPeresupuesto As DataTable
            listadoPeresupuesto = Nothing
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                listadoPeresupuesto = oDalPresupuesto.getPresupuetoById(idx)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoPeresupuesto
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPresupuesto() As DataTable
            Dim listadoPeresupuesto As DataTable
            listadoPeresupuesto = Nothing
            Dim oDalPresupuesto As New DALPresupuesto
            Try
                listadoPeresupuesto = oDalPresupuesto.getPresupueto()
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoPeresupuesto
        End Function
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
