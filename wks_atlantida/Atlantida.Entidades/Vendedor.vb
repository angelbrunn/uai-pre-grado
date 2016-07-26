Namespace SIS.Entidades
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Vendedor
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private legajoField As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property legajo() As Integer
            Get
                Return legajoField
            End Get
            Set(ByVal value As Integer)
                legajoField = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private apellidoField As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property apellido() As String
            Get
                Return apellidoField
            End Get
            Set(ByVal value As String)
                apellidoField = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private nombreField As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property nombre() As String
            Get
                Return nombreField
            End Get
            Set(ByVal value As String)
                nombreField = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private telefonoField As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property telefono() As String
            Get
                Return telefonoField
            End Get
            Set(ByVal value As String)
                telefonoField = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private domicilioField As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property domicilio() As String
            Get
                Return domicilioField
            End Get
            Set(ByVal value As String)
                domicilioField = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaNacimientoField As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property fechaNacimiento() As Date
            Get
                Return fechaNacimientoField
            End Get
            Set(ByVal value As Date)
                fechaNacimientoField = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private activoFeld As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property activo() As Boolean
            Get
                Return activoFeld
            End Get
            Set(ByVal value As Boolean)
                activoFeld = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private clienteField As List(Of Cliente)
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property cliente() As List(Of Cliente)
            Get
                Return clienteField
            End Get
            Set(ByVal value As List(Of Cliente))
                clienteField = value
            End Set
        End Property
    End Class
End Namespace
