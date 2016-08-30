Namespace SIS.Entidades
    Public Class PaquetePromocionable
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPaquetePromocionable As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idProveedor As Integer
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
        Private cantidadPasajero As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private monto As Double
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaCreacionPaquete As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private paqueteActivo As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private descripcion As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IdPaqPromocionable() As Integer
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
        Public Property IdProv() As Integer
            Get
                Return idProveedor
            End Get
            Set(ByVal value As Integer)
                idProveedor = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Destinos() As String
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
        Public Property CantPasajero() As Integer
            Get
                Return cantidadPasajero
            End Get
            Set(ByVal value As Integer)
                cantidadPasajero = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PaqMonto() As Double
            Get
                Return monto
            End Get
            Set(ByVal value As Double)
                monto = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FechCreacionPaquete() As Date
            Get
                Return fechaCreacionPaquete
            End Get
            Set(ByVal value As Date)
                fechaCreacionPaquete = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PaqActivo() As Integer
            Get
                Return paqueteActivo
            End Get
            Set(ByVal value As Integer)
                paqueteActivo = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PaqDescripcion() As String
            Get
                Return descripcion
            End Get
            Set(ByVal value As String)
                descripcion = value
            End Set
        End Property
    End Class
End Namespace

