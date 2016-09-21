Imports System.IO
Imports Atlantida.IO.SIS.IO
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    Public Class NegCobro
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private unUsuarioField As Usuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_cobro"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarCobro(ByVal _cobro As Cobro)
            Dim oDalCobro As New DALCobro
            Try
                oDalCobro.insertarCobro(_cobro)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="_idx"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function cancelarCobro(ByVal _idx As Integer)
            Dim oDalCobro As New DALCobro
            Try
                oDalCobro.cancelarCobro(_idx)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function obtenerUltimaFactura() As Integer
            Dim oDalCobro As New DALCobro
            Dim listadoCobro As Cobro = New Cobro()
            listadoCobro = Nothing
            Dim numerofactura As Integer = 0
            Try
                listadoCobro = oDalCobro.obtenerUltimaFactura()
                If listadoCobro.numeroFactura = 0 Then
                    numerofactura = 1
                End If
                If listadoCobro.numeroFactura <> 0 Then
                    numerofactura = listadoCobro.numeroFactura
                End If
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
            Return numerofactura
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property unUsuario() As Usuario
            Get
                Return unUsuarioField
            End Get
            Set(ByVal value As Usuario)
                unUsuarioField = value
            End Set
        End Property
    End Class
End Namespace
