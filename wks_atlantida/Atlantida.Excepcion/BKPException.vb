﻿Namespace SIS.Excepcion
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class BKPException
        Inherits System.Exception
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="mensaje"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal mensaje As String)
            MyBase.New(mensaje)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="mensaje"></param>
        ''' <param name="inner"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal mensaje As String, ByVal inner As Exception)
            MyBase.New(mensaje, inner)
        End Sub
    End Class
End Namespace