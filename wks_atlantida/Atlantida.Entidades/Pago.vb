Namespace SIS.Entidades
    Public Class Pago
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPago As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private confirmacionPagoRealizado As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaPago As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPresupuesto As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idProveedorTransporte As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idProveedorHospedaje As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idCuentaCorr As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private tipoDiviza As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private estadoPago As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private razonSocial As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private montPagoTransporte As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private montPagoHospedaje As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idPagos() As Integer
            Get
                Return idPago
            End Get
            Set(ByVal value As Integer)
                idPago = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property confPago() As Integer
            Get
                Return confirmacionPagoRealizado
            End Get
            Set(ByVal value As Integer)
                confirmacionPagoRealizado = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FechPago() As Date
            Get
                Return fechaPago
            End Get
            Set(ByVal value As Date)
                fechaPago = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idPresu() As Integer
            Get
                Return idPresupuesto
            End Get
            Set(ByVal value As Integer)
                idPresupuesto = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idCuentaCorriente() As Integer
            Get
                Return idCuentaCorr
            End Get
            Set(ByVal value As Integer)
                idCuentaCorr = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idProv() As Integer
            Get
                Return idProveedorTransporte
            End Get
            Set(ByVal value As Integer)
                idProveedorTransporte = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idProvHosp() As Integer
            Get
                Return idProveedorHospedaje
            End Get
            Set(ByVal value As Integer)
                idProveedorHospedaje = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property tipoDeDiviza() As String
            Get
                Return tipoDiviza
            End Get
            Set(ByVal value As String)
                tipoDiviza = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property estadoDelPago() As String
            Get
                Return estadoPago
            End Get
            Set(ByVal value As String)
                estadoPago = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property razonSocialCuenta() As String
            Get
                Return razonSocial
            End Get
            Set(ByVal value As String)
                razonSocial = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property montoAPagarTransporte() As Integer
            Get
                Return montPagoTransporte
            End Get
            Set(ByVal value As Integer)
                montPagoTransporte = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property montoAPagarHospedaje() As Integer
            Get
                Return montPagoHospedaje
            End Get
            Set(ByVal value As Integer)
                montPagoHospedaje = value
            End Set
        End Property
    End Class
End Namespace

