Namespace SIS.Entidades
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Cliente
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private codigoCliente As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public dni As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public nombre As String
        ''' <summary>  
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public apellido As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public email As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public telefono As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public fecNacimiento As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public medioContacto As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public inhabilitar As Integer
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
        Public Property dniCliente() As String
            Get
                Return dni
            End Get
            Set(ByVal value As String)
                dni = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property nombreCliente() As String
            Get
                Return nombre
            End Get
            Set(ByVal value As String)
                nombre = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property apellidoCliente() As String
            Get
                Return apellido
            End Get
            Set(ByVal value As String)
                apellido = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property emailCliente() As String
            Get
                Return email
            End Get
            Set(ByVal value As String)
                email = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property telefonoCliente() As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property medioContactoCliente() As Boolean
            Get
                Return medioContacto
            End Get
            Set(ByVal value As Boolean)
                medioContacto = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property fechaNacimientoCliente() As String
            Get
                Return fecNacimiento
            End Get
            Set(ByVal value As String)
                fecNacimiento = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property inhabilitarCliente() As Integer
            Get
                Return inhabilitar
            End Get
            Set(ByVal value As Integer)
                inhabilitar = value
            End Set
        End Property
    End Class
End Namespace
