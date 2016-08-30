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
        Private confirmacionPagoRealizado As Boolean
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
        Public Property confPago() As Boolean
            Get
                Return confirmacionPagoRealizado
            End Get
            Set(ByVal value As Boolean)
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
    End Class
End Namespace

