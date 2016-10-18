Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL
Imports System.Net.Mail
Imports System.Net

Namespace SIS.BLL
    Public Class NegPago
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
        ''' <param name="_pago"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarPago(ByVal _pago As Pago)
            Dim oDalPago As New DALPago
            Try
                oDalPago.registrarPago(_pago)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPres"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function actualizarEstadoPago(ByVal idPres As Integer, ByVal estado As String)
            Dim oDalPago As New DALPago
            Try
                oDalPago.actualizarEstadoPago(idPres, estado)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPres"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarPresupuestoPago(ByVal idPres As Integer)
            Dim oDalPago As New DALPago
            Try
                oDalPago.insertarPresupuestoPago(idPres)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerPagos() As DataTable
            Dim listadoPago As DataTable
            listadoPago = Nothing
            Dim oDalPago As New DALPago
            Try
                listadoPago = oDalPago.obtenerPagosActivos()
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoPago
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresu"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function consultarTipoTransferencia(ByVal idPresu As Integer) As Integer
            Dim oDalPago As New DALPago
            Dim tipoTransferencia As Integer
            Try
                tipoTransferencia = oDalPago.consultarTipoTransferencia(idPresu)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
            Return tipoTransferencia
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <param name="idCuentaCorriente"></param>
        ''' <param name="_monto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function incrementarCuentaCorriente(ByVal idPresupuesto As Integer, ByVal idCuentaCorriente As Integer, ByVal _monto As Integer)
            Dim oDalPago As New DALPago
            Try
                oDalPago.incrementarCuentaCorriente(idPresupuesto, idCuentaCorriente, _monto)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_monto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function decrementoCaja(ByVal _monto As Integer)
            Dim oDalPago As New DALPago
            Dim oDalCobro As New DALCobro
            Dim montoTemporal As Integer
            Try
                montoTemporal = oDalCobro.obtenerMonto()
                montoTemporal = montoTemporal - _monto
                oDalPago.decrementarCaja(montoTemporal)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <param name="_monto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function decrementoPagoPendiente(ByVal idPresupuesto As Integer, ByVal _monto As Integer, ByVal action As String)
            Dim oDalPago As New DALPago
            Dim montoTemporalTransporte As Integer
            Dim montoTemporalHospedaje As Integer
            Try
                If action = "Transporte" Then
                    montoTemporalTransporte = oDalPago.obtenerMontoTransporte(idPresupuesto)
                    montoTemporalTransporte = montoTemporalTransporte - _monto
                    oDalPago.decrementarPagoTransporte(idPresupuesto, montoTemporalTransporte)
                Else
                    montoTemporalHospedaje = oDalPago.obtenerMontoHospedaje(idPresupuesto)
                    montoTemporalHospedaje = montoTemporalHospedaje - _monto
                    oDalPago.decrementarPagoHospedaje(idPresupuesto, montoTemporalHospedaje)
                End If
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <param name="_estado"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function actualizarEstado(ByVal idPresupuesto As Integer, ByVal _estado As String)
            Dim oDalPago As New DALPago
            Try
                oDalPago.actualizarEstadoPago(idPresupuesto, _estado)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_idx"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function cancelarPago(ByVal _idx As Integer)
            Dim oDalPago As New DALPago
            Try
                oDalPago.cancelarPago(_idx)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
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

