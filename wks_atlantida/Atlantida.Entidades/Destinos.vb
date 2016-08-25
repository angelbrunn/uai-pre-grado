Namespace SIS.Entidades
    Public Class Destinos
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private codigoDestino As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public destino As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property codDestino() As String
            Get
                Return codigoDestino
            End Get
            Set(ByVal value As String)
                codigoDestino = value
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
    End Class
End Namespace

