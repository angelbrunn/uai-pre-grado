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
        Private codigoClienteField As String
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
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property codigoCliente() As String
            Get
                Return codigoClienteField
            End Get
            Set(ByVal value As String)
                codigoClienteField = value
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
                Return dni
            End Get
            Set(ByVal value As String)
                email = value
            End Set
        End Property
    End Class
End Namespace
