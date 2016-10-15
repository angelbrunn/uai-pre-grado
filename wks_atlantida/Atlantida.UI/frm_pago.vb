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
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_cotizar_Click(sender As Object, e As EventArgs) Handles btn_cotizar.Click
        Dim cotizacion As Integer
        Dim idxDiviza As Integer

        If pagoTemporal.tipoDeDiviza = "Peso" Then
            idxDiviza = 1
        End If
        If pagoTemporal.tipoDeDiviza = "Dolar" Then
            idxDiviza = 2
        End If
        If pagoTemporal.tipoDeDiviza = "Euro" Then
            idxDiviza = 3
        End If

        If idxDiviza <> 1 Then
            cotizacion = interfazPago.obtenerCotizacion(idxDiviza)
            pagoTemporal.montoPago = pagoTemporal.montoPago * cotizacion
        End If

        'TO-DO:UPDATE DEL PAGO - CAMBIANDO LA DIV DEL PAGO POR PESO Y ACTUALIZANDO EL MAP
        interfazPago.actualizarPago(pagoTemporal.idPresu, pagoTemporal.montoPago)

        'setDgw
        'setDataGridView()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function setDataGridView()
        Dim DS As DataSet = New DataSet("Pago")
        Dim Tabla As DataTable = DS.Tables.Add("Pago")

        Tabla.Columns.Add("IDPROV", Type.GetType("System.String"))
        Tabla.Columns.Add("IDPRESU", Type.GetType("System.String"))
        Tabla.Columns.Add("CCORR", Type.GetType("System.String"))
        Tabla.Columns.Add("ESTADO", Type.GetType("System.String"))
        Tabla.Columns.Add("RAZON SOCIAL", Type.GetType("System.String"))
        Tabla.Columns.Add("MAP", Type.GetType("System.String"))
        Tabla.Columns.Add("DIV", Type.GetType("System.String"))

        Dim Fila As DataRow = Tabla.NewRow

        'Fila = DS.Tables("PaqueteNoPromo").NewRow()
        Fila("IDPROV") = pagoTemporal.idProv.ToString()
        Fila("IDPRESU") = pagoTemporal.idPresu.ToString()
        Fila("CCORR") = pagoTemporal.idCuentaCorriente.ToString()
        Fila("ESTADO") = pagoTemporal.estadoDelPago.ToString()
        Fila("RAZON SOCIAL") = pagoTemporal.razonSocialCuenta.ToString()
        Fila("MAP") = pagoTemporal.montoPago.ToString()
        Fila("DIV") = pagoTemporal.tipoDeDiviza.ToString()

        Tabla.Rows.Add(Fila)
        dgw_pagos_pend.DataSource = Tabla

    End Function
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
        pagoTemporal.idPresu = selectedRow.Cells(1).Value.ToString()
        pagoTemporal.idCuentaCorriente = selectedRow.Cells(2).Value.ToString()
        pagoTemporal.estadoDelPago = selectedRow.Cells(3).Value.ToString()
        pagoTemporal.razonSocialCuenta = selectedRow.Cells(4).Value.ToString()
        pagoTemporal.montoPago = selectedRow.Cells(5).Value.ToString()
        pagoTemporal.tipoDeDiviza = Trim(selectedRow.Cells(6).Value.ToString())
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
            If enu.Current.componente = "btn_cotizar" Then
                Me.btn_cotizar.Text = enu.Current.value
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
                Me.btn_confirmar.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_idPres" Then
                Me.lbl_idPres.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_solicitarPax" Then
                Me.btn_solicitarPax.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_pago" Then
                Me.Text = enu.Current.value
            End If
        End While
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