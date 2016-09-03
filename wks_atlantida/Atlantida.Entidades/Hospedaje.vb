Namespace SIS.Entidades
    Public Class Hospedaje
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idProvHos As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idCuentaCorriente As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private poseeCuentaCorriente As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private razonSocial As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private direccion As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private mail As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private reservaPendiente As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idDivisa As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private pagoPendiente As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private montoAPagar As Double
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private categoria As Integer
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
        Public Property idHospedaje() As Integer
            Get
                Return idProvHos
            End Get
            Set(ByVal value As Integer)
                idProvHos = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idCuentaCorr() As Integer
            Get
                Return idCuentaCorriente
            End Get
            Set(ByVal value As Integer)
                idCuentaCorriente = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property isCuentaCorriente() As Boolean
            Get
                Return poseeCuentaCorriente
            End Get
            Set(ByVal value As Boolean)
                poseeCuentaCorriente = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property razSocial() As String
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
        Public Property Direcciones() As String
            Get
                Return direccion
            End Get
            Set(ByVal value As String)
                direccion = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property email() As String
            Get
                Return mail
            End Get
            Set(ByVal value As String)
                mail = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property resPendiente() As Boolean
            Get
                Return reservaPendiente
            End Get
            Set(ByVal value As Boolean)
                reservaPendiente = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property divisa() As Integer
            Get
                Return idDivisa
            End Get
            Set(ByVal value As Integer)
                idDivisa = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property pagoPend() As Boolean
            Get
                Return pagoPendiente
            End Get
            Set(ByVal value As Boolean)
                pagoPendiente = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property monPagar() As Integer
            Get
                Return montoAPagar
            End Get
            Set(ByVal value As Integer)
                montoAPagar = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property cat() As Integer
            Get
                Return categoria
            End Get
            Set(ByVal value As Integer)
                categoria = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property desc() As String
            Get
                Return descripcion
            End Get
            Set(ByVal value As String)
                descripcion = value
            End Set
        End Property
    End Class
End Namespace

