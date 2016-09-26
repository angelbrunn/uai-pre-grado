Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

Public Class frm_cobro
    ''' <summary>
    ''' Creo obj tipo cuenta
    ''' </summary>
    ''' <remarks></remarks>
    Public cue As cuenta
    ''' <summary>
    '''  Creo obj tipo tarjeta
    ''' </summary>
    ''' <remarks></remarks>
    Public tar As tarjeta
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
    Dim interfazCobro As NegCobro = New NegCobro
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_validar.Click
        'Por medio del nro dni voy a buscar todos las operaciones abiertas en estado pendiente de pago
        Dim _dni As Integer = Integer.Parse(txt_cliente.Text)
        dgw_resultDeuda.DataSource = interfazCobro.obtenerDeudaCliente(_dni)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'Validar tipo de pago si es credito->tarjeta or transferencia->cuenta'
        'Creo popUps tarjeta y cuenta'
        Dim popUptarj As frm_tarjeta = New frm_tarjeta()
        Dim popUpcuen As frm_cuenta = New frm_cuenta()
        'Cargo tarjeta para el pago de la operacion'
        If popUptarj.ShowDialog() = DialogResult.OK Then
            Me.tar = popUptarj.tar
            If String.IsNullOrEmpty(txt_tarjeta.Text) Then
                Me.txt_tarjeta.Text = popUptarj.tar.banco + " " + popUptarj.tar.tipo + " " + popUptarj.tar.nrotarjeta + " " + popUptarj.tar.codsegu + " " + popUptarj.tar.fechvenc
            End If
        End If
        'Cargo cuenta para el pago de la operacion'
        If popUpcuen.ShowDialog() = DialogResult.OK Then
            Me.cue = popUpcuen.cue
            If String.IsNullOrEmpty(txt_cuenta.Text) Then
                Me.txt_cuenta.Text = popUpcuen.cue.des_tipocuenta + " " + popUpcuen.cue.des_banco + " " + popUpcuen.cue.des_numerocuenta + " " + popUpcuen.cue.des_nombre + " " + popUpcuen.cue.des_email
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub box_central_Enter(sender As Object, e As EventArgs) Handles box_central.Enter
        modificarIdiomaSegunPreferencias(UsuarioIdioma)

        Dim listadoFormasPago As New List(Of String)
        listadoFormasPago.Add("Efectivo")
        listadoFormasPago.Add("Debito")
        listadoFormasPago.Add("Credito")

        Dim listadoCantidad As New List(Of String)
        listadoCantidad.Add("1")
        listadoCantidad.Add("3")
        listadoCantidad.Add("6")
        listadoCantidad.Add("12")

        Dim enumerator_A As IEnumerator(Of String) = listadoFormasPago.GetEnumerator
        While enumerator_A.MoveNext
            cbx_formasPago.Items.Add(enumerator_A.Current)
        End While
        Dim enumerator_B As IEnumerator(Of String) = listadoCantidad.GetEnumerator
        While enumerator_B.MoveNext
            cbx_cantidad.Items.Add(enumerator_B.Current)
        End While

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
            If enu.Current.componente = "box_cliente_deuda" Then
                Me.box_cliente_deuda.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_formulario_pago" Then
                Me.box_formulario_pago.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_resultado_deuda" Then
                Me.box_resultado_deuda.Text = enu.Current.value
            End If
            ''If enu.Current.componente = "btn_carga" Then
            ''Me.btn_carga.Text = enu.Current.value
            ''End If
            If enu.Current.componente = "btn_imprimir_voucher" Then
                Me.btn_imprimir_voucher.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_pagar" Then
                Me.btn_pagar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_validar" Then
                Me.btn_validar.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_cantidad" Then
                Me.lbl_cantidad.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_dato_cuenta" Then
                Me.lbl_dato_cuenta.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_datos_tarjeta" Then
                Me.lbl_datos_tarjeta.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_dni" Then
                Me.lbl_dni.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_forma_pago" Then
                Me.lbl_forma_pago.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_importe" Then
                Me.lbl_importe.Text = enu.Current.value
            End If
            If enu.Current.componente = "rdio_cuota" Then
                Me.rdio_cuota.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_sena" Then
                Me.btn_sena.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_sena" Then
                Me.box_sena.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_ConfirmarComprobantes" Then
                Me.btn_ConfirmarComprobantes.Text = enu.Current.value
            End If
            If enu.Current.componente = "ChkReserva" Then
                Me.ChkReserva.Text = enu.Current.value
            End If
            If enu.Current.componente = "ChkPagoToT" Then
                Me.ChkPagoToT.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_cobro" Then
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