﻿Namespace SIS.Entidades
    Public Class Cobro
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idCobro As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private idPresupuesto As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private monto As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private nroFactura As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private ventaCancelada As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private pasajeros As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private fechaCobro As Date
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property idCobros() As Integer
            Get
                Return idCobro
            End Get
            Set(ByVal value As Integer)
                idCobro = value
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
        Public Property montos() As Integer
            Get
                Return monto
            End Get
            Set(ByVal value As Integer)
                monto = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property numeroFactura() As Integer
            Get
                Return nroFactura
            End Get
            Set(ByVal value As Integer)
                nroFactura = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ventaCancel() As String
            Get
                Return ventaCancelada
            End Get
            Set(ByVal value As String)
                ventaCancelada = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property pasajerosCobros() As String
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
        Public Property FechCobro() As Date
            Get
                Return fechaCobro
            End Get
            Set(ByVal value As Date)
                fechaCobro = value
            End Set
        End Property
    End Class
End Namespace

