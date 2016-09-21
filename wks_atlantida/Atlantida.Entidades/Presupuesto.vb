Namespace SIS.Entidades
    Public Class Presupuesto
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPresupuesto As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private codigoCliente As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private legajo As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private destino As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaPartida As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaRegreso As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private pasajeros As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPaquetePromocionable As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPaqNoProm As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idTransporte As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaCreacion As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private disponibilidad As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private monto As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private estado As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private tipo As String
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
        Public Property codCliente() As String
            Get
                Return codigoCliente
            End Get
            Set(ByVal value As String)
                codigoCliente = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property legPresu() As Integer
            Get
                Return legajo
            End Get
            Set(ByVal value As Integer)
                legajo = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property destPres() As String
            Get
                Return destino
            End Get
            Set(ByVal value As String)
                destino = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FechPartida() As Date
            Get
                Return fechaPartida
            End Get
            Set(ByVal value As Date)
                fechaPartida = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FechRegreso() As Date
            Get
                Return fechaRegreso
            End Get
            Set(ByVal value As Date)
                fechaRegreso = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idPaqPromocionable() As Integer
            Get
                Return idPaquetePromocionable
            End Get
            Set(ByVal value As Integer)
                idPaquetePromocionable = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idPaqueteNoPromocionable() As Integer
            Get
                Return idPaqNoProm
            End Get
            Set(ByVal value As Integer)
                idPaqNoProm = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FechCreacion() As Date
            Get
                Return fechaCreacion
            End Get
            Set(ByVal value As Date)
                fechaCreacion = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property dispPresu() As Integer
            Get
                Return disponibilidad
            End Get
            Set(ByVal value As Integer)
                disponibilidad = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property EstadoPresu() As String
            Get
                Return estado
            End Get
            Set(ByVal value As String)
                estado = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PasajerosPresu() As String
            Get
                Return pasajeros
            End Get
            Set(ByVal value As String)
                pasajeros = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TipoPaquete() As String
            Get
                Return tipo
            End Get
            Set(ByVal value As String)
                tipo = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IdTransp() As String
            Get
                Return idTransporte
            End Get
            Set(ByVal value As String)
                idTransporte = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MontoAPagar() As Integer
            Get
                Return monto
            End Get
            Set(ByVal value As Integer)
                monto = value
            End Set
        End Property
    End Class
End Namespace

