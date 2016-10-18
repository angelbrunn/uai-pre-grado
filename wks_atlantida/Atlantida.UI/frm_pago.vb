Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades
''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_pago
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private idUsuario As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private idioma As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private pagoTemporal As Pago
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private interfazPago As NegPago = New NegPago
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private razonSocialTransp As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private razonSocialHospedaje As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgw_pagos_pend_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_pagos_pend.CellDoubleClick
        pagoTemporal = New Pago()
        Dim idx As Integer
        idx = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgw_pagos_pend.Rows(idx)

        pagoTemporal.idProv = selectedRow.Cells(0).Value.ToString()
        pagoTemporal.idProvHosp = selectedRow.Cells(1).Value.ToString()
        pagoTemporal.idPresu = selectedRow.Cells(2).Value.ToString()
        pagoTemporal.idCuentaCorriente = selectedRow.Cells(3).Value.ToString()
        pagoTemporal.estadoDelPago = selectedRow.Cells(4).Value.ToString()
        pagoTemporal.montoAPagarTransporte = selectedRow.Cells(5).Value.ToString()
        razonSocialTransp = selectedRow.Cells(6).Value.ToString()
        pagoTemporal.montoAPagarHospedaje = selectedRow.Cells(7).Value.ToString()
        razonSocialHospedaje = selectedRow.Cells(8).Value.ToString()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)

        dgw_pagos_pend.DataSource = interfazPago.obtenerPagos()

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_transferencia_Click(sender As Object, e As EventArgs) Handles btn_transferencia.Click
        Dim tipoTrasnf As Integer

        If pagoTemporal IsNot Nothing Then
            tipoTrasnf = interfazPago.consultarTipoTransferencia(pagoTemporal.idPresu)

            Dim montoCseñaTransporte As Integer
            Dim montoCseñaHospedaje As Integer

            Dim montoToTTransporte As Integer
            Dim montoToTHospedaje As Integer

            '1:PAGO DE TRANSFERENCIA POR SEÑA
            If tipoTrasnf = 1 Then
                If pagoTemporal.montoAPagarTransporte <> 0 Then
                    montoCseñaTransporte = (pagoTemporal.montoAPagarTransporte * 0.3)
                    'INCREMENTO CUENTA CORRIENTE DEL CLIENTE
                    interfazPago.incrementarCuentaCorriente(pagoTemporal.idPresu, pagoTemporal.idCuentaCorriente, montoCseñaTransporte)
                    'DECREMENTO CAJA
                    interfazPago.decrementoCaja(montoCseñaTransporte)
                    'DECREMENTO PAGO PENDIENTE
                    interfazPago.decrementoPagoPendiente(pagoTemporal.idPresu, montoCseñaTransporte, "Transporte")
                    '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado|4:seña Paga|5:tot Paga
                    interfazPago.actualizarEstado(pagoTemporal.idPresu, 4)
                End If
                If pagoTemporal.montoAPagarHospedaje <> 0 Then
                    montoCseñaHospedaje = (pagoTemporal.montoAPagarHospedaje * 0.3)
                    interfazPago.incrementarCuentaCorriente(pagoTemporal.idPresu, pagoTemporal.idCuentaCorriente, montoCseñaHospedaje)
                    'DECREMENTO CAJA
                    interfazPago.decrementoCaja(montoCseñaHospedaje)
                    'DECREMENTO PAGO PENDIENTE
                    interfazPago.decrementoPagoPendiente(pagoTemporal.idPresu, montoCseñaHospedaje, "Hospedaje")
                    '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado|4:seña Paga|5:tot Paga
                    interfazPago.actualizarEstado(pagoTemporal.idPresu, 4)
                End If
            End If
            '2:PAGO DE TRANSFERENCIA POR TOTAL
            If tipoTrasnf = 2 Then
                'pagoTemporal.idCuentaCorriente
                If pagoTemporal.montoAPagarTransporte <> 0 Then
                    montoToTTransporte = pagoTemporal.montoAPagarTransporte
                    'INCREMENTO CUENTA CORRIENTE DEL CLIENTE
                    interfazPago.incrementarCuentaCorriente(pagoTemporal.idPresu, pagoTemporal.idCuentaCorriente, montoToTTransporte)
                    'DECREMENTO CAJA
                    interfazPago.decrementoCaja(montoToTTransporte)
                    'DECREMENTO PAGO PENDIENTE
                    '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado|4:seña Paga|5:tot Paga
                    interfazPago.decrementoPagoPendiente(pagoTemporal.idPresu, montoToTTransporte, "Transporte")
                    interfazPago.actualizarEstado(pagoTemporal.idPresu, 5)
                End If
                If pagoTemporal.montoAPagarHospedaje <> 0 Then
                    montoToTHospedaje = pagoTemporal.montoAPagarHospedaje
                    interfazPago.incrementarCuentaCorriente(pagoTemporal.idPresu, pagoTemporal.idCuentaCorriente, montoToTHospedaje)
                    'DECREMENTO CAJA
                    interfazPago.decrementoCaja(montoCseñaHospedaje)
                    'DECREMENTO PAGO PENDIENTE
                    interfazPago.decrementoPagoPendiente(pagoTemporal.idPresu, montoToTHospedaje, "Hospedaje")
                    '0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado|4:seña Paga|5:tot Paga
                    interfazPago.actualizarEstado(pagoTemporal.idPresu, 5)
                End If
            End If
            MsgBox("Operacion Exitosa!")
        Else
            MsgBox("Seleccione un registro de la grilla,haciendo doble click sobre ella!")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idioma"></param>
    ''' <remarks></remarks>
    Private Sub modificarIdiomaSegunPreferencias(ByVal idioma As String)
        'Obtengo el listado de nombre de los componentes en ambos idiomas.
        Dim interfazMultiIdioma As INegMultiIdioma = New NegMultiIdioma
        Dim listadoMultiIdioma As New List(Of MultiIdioma)
        listadoMultiIdioma = interfazMultiIdioma.obtenerTablaMultiIdioma(idioma)

        Dim enu As IEnumerator(Of MultiIdioma) = listadoMultiIdioma.GetEnumerator
        While enu.MoveNext
            If enu.Current.componente = "box_acciones" Then
                Me.box_acciones.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_terminar_op" Then
                Me.btn_terminar_op.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_transferencia" Then
                Me.btn_transferencia.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_pagos_pend" Then
                Me.btn_transferencia.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_confirmar" Then
                Me.btn_refrescar.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_pago" Then
                Me.Text = enu.Current.value
            End If
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_refrescar_Click(sender As Object, e As EventArgs) Handles btn_refrescar.Click
        'Recargar el datagridview
        dgw_pagos_pend.DataSource = interfazPago.obtenerPagos()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UsuarioId() As String
        Get
            Return idUsuario
        End Get
        Set(ByVal value As String)
            idUsuario = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property UsuarioIdioma() As String
        Get
            Return idioma
        End Get
        Set(ByVal value As String)
            idioma = value
        End Set
    End Property
End Class