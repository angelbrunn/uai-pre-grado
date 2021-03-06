﻿Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.DAL
Imports Atlantida.DAL.SIS.DAL

Namespace SIS.BLL
    Public Class NegNegocio
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Private unUsuarioField As Usuario
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="idPresupuesto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function registrarVenta(ByVal idPresupuesto As Integer)
            Dim oDalVenta As New DALVenta
            Dim fechaVenta As DateTime = DateTime.Now
            Try
                oDalVenta.insertarVenta(idPresupuesto, fechaVenta)
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex)
            End Try
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function validarPrimeraConexion() As Boolean
            Dim isFirts As Boolean = False
            Dim oDalAuditoria As New DALAuditoria
            Try
                Dim id = oDalAuditoria.primeraConexion()

                If id <> 0 Then
                    'DB ESTA CONFIGURADA
                    isFirts = True
                Else
                    'NO DB ESTA CONFIGURADA
                    isFirts = False
                End If
                Return isFirts
            Catch ex As Exception
                interfazNegocioBitacora.registrarEnBitacora_BLL("SYS_DB_CONN", ex)
            End Try
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

