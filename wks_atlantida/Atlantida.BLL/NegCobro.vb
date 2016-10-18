Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    Public Class NegCobro
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
        ''' <param name="_cobro"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarCobro(ByVal _cobro As Cobro)
            Dim oDalCobro As New DALCobro
            Try
                oDalCobro.insertarCobro(_cobro)
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
        Function registrarPresupuestoCobro(ByVal idPres As Integer)
            Dim oDalCobro As New DALCobro
            Try
                oDalCobro.insertarPresupuestoCobro(idPres)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_idFact"></param>
        ''' <param name="_upmonto"></param>
        ''' <param name="_cuenta"></param>
        ''' <param name="_tarjeta"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarReservaConTarjeta(ByVal _idFact As Integer, ByVal _upmonto As Integer, ByVal _interes As Integer, ByVal _cuotas As String, ByVal _cuenta As String, ByVal _tarjeta As String)
            Dim oDalCobro As New DALCobro
            Dim fechaCobro As DateTime = DateTime.Now
            Try
                oDalCobro.registarReservaConTarjeta(_idFact, _upmonto, fechaCobro, _interes, _cuotas, _cuenta, _tarjeta)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_idFact"></param>
        ''' <param name="_upmonto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarReserva(ByVal _idFact As Integer, ByVal _upmonto As Integer)
            Dim oDalCobro As New DALCobro
            Dim fechaCobro As DateTime = DateTime.Now
            Try
                oDalCobro.registarReserva(_idFact, _upmonto, fechaCobro)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_idFact"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarCobro(ByVal _idFact As Integer)
            Dim oDalCobro As New DALCobro
            Dim fechaCobro As DateTime = DateTime.Now
            Try
                oDalCobro.registrarCobro(_idFact, fechaCobro)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_idFact"></param>
        ''' <param name="_cuenta"></param>
        ''' <param name="_tarjeta"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarCobroConTarjeta(ByVal _idFact As Integer, ByVal _interes As Integer, ByVal _cuotas As String, ByVal _cuenta As String, ByVal _tarjeta As String)
            Dim oDalCobro As New DALCobro
            Dim fechaCobro As DateTime = DateTime.Now
            Try
                oDalCobro.registrarCobroConTarjeta(_idFact, fechaCobro, _interes, _cuotas, _cuenta, _tarjeta)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dni"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerDeudaCliente(ByVal dni As Integer) As DataTable
            Dim listadoCobro As DataTable
            listadoCobro = Nothing
            Dim oDalCobro As New DALCobro
            Try
                listadoCobro = oDalCobro.obtenerDeudaCliente(dni)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoCobro
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_monto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function incrementarCuenta(ByVal _monto As Integer)
            Dim oDalCobro As New DALCobro
            Dim montoTemporal As Integer
            Try
                montoTemporal = oDalCobro.obtenerMonto()
                montoTemporal = montoTemporal + _monto
                oDalCobro.incrementarCuenta(montoTemporal)
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
        Function cancelarCobro(ByVal _idx As Integer)
            Dim oDalCobro As New DALCobro
            Try
                oDalCobro.cancelarCobro(_idx)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerUltimaFactura() As Integer
            Dim oDalCobro As New DALCobro
            Dim listadoCobro As Cobro = New Cobro()
            listadoCobro = Nothing
            Dim numerofactura As Integer = 0
            Try
                listadoCobro = oDalCobro.obtenerUltimaFactura()
                If listadoCobro.numeroFactura = 0 Then
                    numerofactura = 1
                End If
                If listadoCobro.numeroFactura <> 0 Then
                    numerofactura = listadoCobro.numeroFactura
                End If
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
            Return numerofactura
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_nroFactura"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerEstadoCobro(ByVal _nroFactura As Integer) As Integer
            Dim oDalCobro As New DALCobro
            Dim estadoCobro As Integer = 0
            Try
                estadoCobro = oDalCobro.obtenerEstadoPago(_nroFactura)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
            Return estadoCobro
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dni"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerVoucherCliente(ByVal dni As Integer) As DataTable
            Dim listadoVoucher As DataTable
            listadoVoucher = Nothing
            Dim oDalCobro As New DALCobro
            Try
                listadoVoucher = oDalCobro.obtenerVoucherCliente(dni)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try

            Return listadoVoucher
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
