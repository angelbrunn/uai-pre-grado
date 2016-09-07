Imports Atlantida.BLL
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

Public Class frm_presupuesto
    ''' <summary>
    ''' Creo obj tipo cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public cli As Cliente
    ''' <summary>
    ''' Creo obj tipo negocio
    ''' </summary>
    ''' <remarks></remarks>
    Public n As New negocio
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
    Dim interfazPresupuesto As NegPresupuesto = New NegPresupuesto
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim interfazUsuario As NegMultiUsuario = New NegMultiUsuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Dim popUp As frm_cliente = New frm_cliente()
        popUp.UsuarioId = idUsuario
        popUp.UsuarioIdioma = idioma

        'Cargo clientes para la operacion'
        If popUp.ShowDialog() = DialogResult.OK Then
            Me.cli = popUp.cli
            If String.IsNullOrEmpty(txt_cliente1.Text) Then
                Me.txt_cliente1.Text = popUp.cli.dni + " " + popUp.cli.nombre + " " + popUp.cli.apellido + " " + popUp.cli.email
            ElseIf String.IsNullOrEmpty(txt_cliente2.Text) Then
                Me.txt_cliente2.Text = popUp.cli.dni + " " + popUp.cli.nombre + " " + popUp.cli.apellido + " " + popUp.cli.email
            ElseIf String.IsNullOrEmpty(txt_cliente3.Text) Then
                Me.txt_cliente3.Text = popUp.cli.dni + " " + popUp.cli.nombre + " " + popUp.cli.apellido + " " + popUp.cli.email
            ElseIf String.IsNullOrEmpty(txt_cliente4.Text) Then
                Me.txt_cliente4.Text = popUp.cli.dni + " " + popUp.cli.nombre + " " + popUp.cli.apellido + " " + popUp.cli.email
            End If
        End If
    End Sub
    'Busco disponibilidad a partir de la fecha de salida desde un origen hacia un destino por medio del transporte indicado.
    'la fecha vuelta no tiene tanta importancia en la toma de decision del pasaje ya que el vendedor lo puedo conversar con el cliente
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_disponibilidad_Click(sender As Object, e As EventArgs) Handles btn_obtPaqNoProm.Click
        'Defino un flag para el tipo de transporte - FIXME:solo funciona para una seleccion
        Dim _Origen As String = ""
        Dim _Destino As String = ""
        Dim _FIda As String = ""
        Dim _FVta As String = ""
        Dim _medioTransporte As String = ""
        Dim bandera As String = True

        'Guardo el Origen
        If lst_origen.SelectedItems.Count = 0 Then
            MsgBox("Debe Seleccionar un Origen")
            bandera = False
        Else
            For indice = 0 To lst_origen.SelectedItems.Count - 1
                _Origen = lst_origen.SelectedItems(indice)
            Next
        End If

        'Guardo el destino
        If lst_destino.SelectedItems.Count = 0 Then
            MsgBox("Debe Seleccionar un Destino")
            bandera = False
        Else
            For indice = 0 To lst_destino.SelectedItems.Count - 1
                _Destino = lst_destino.SelectedItems(indice)
            Next
        End If

        'Guardo Fechas
        _FIda = txt_fechaida.Text
        _FVta = txt_fechavuelta.Text

        'Guardo Medio de Transporte
        If chk_bus.Checked = True Then
            _medioTransporte += "Bus"
        End If
        If chk_tren.Checked = True Then
            _medioTransporte += "Tren"
        End If
        If chk_avion.Checked = True Then
            _medioTransporte += "Avion"
        End If
        If chk_crucero.Checked = True Then
            _medioTransporte += "Crucero"
        End If

        If _medioTransporte Is Nothing Then
            MsgBox("Debe Seleccionar un Medio de Transporte")
            bandera = False
        End If

        If bandera = True Then
            Dim listadoPaquetesNoProm As DataTable
            listadoPaquetesNoProm = interfazPresupuesto.obtenerPaqueteNoPromo(_Origen, _Destino, _FIda, _FVta, _medioTransporte)
            frm_PaqueteNoPromocionable.dgw_PaqNotProm.DataSource = listadoPaquetesNoProm
            frm_PaqueteNoPromocionable.Show()
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
            If enu.Current.componente = "box_cliente" Then
                Me.box_cliente.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_result" Then
                Me.box_result.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_estadoOP" Then
                Me.box_result.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_presupuesto" Then
                Me.box_presupuesto.Text = enu.Current.value
            End If
            If enu.Current.componente = "box_resultadodisp" Then
                Me.box_resultadodisp.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_asignar" Then
                Me.btn_asignar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_cargar" Then
                Me.btn_cargar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_disponibilidad" Then
                Me.btn_obtPaqNoProm.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_generapresu" Then
                Me.btn_generapresu.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_hospedaje" Then
                Me.btn_hospedaje.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_obtPaqProm" Then
                Me.btn_obtPaqProm.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_terminaop" Then
                Me.btn_terminaop.Text = enu.Current.value
            End If
            If enu.Current.componente = "chk_avion" Then
                Me.chk_avion.Text = enu.Current.value
            End If
            If enu.Current.componente = "chk_bus" Then
                Me.chk_bus.Text = enu.Current.value
            End If
            If enu.Current.componente = "chk_crucero" Then
                Me.chk_crucero.Text = enu.Current.value
            End If
            If enu.Current.componente = "chk_tren" Then
                Me.chk_tren.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_cliente1" Then
                Me.lbl_cliente1.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_cliente2" Then
                Me.lbl_cliente2.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_cliente3" Then
                Me.lbl_cliente3.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_cliente4" Then
                Me.lbl_cliente4.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_cliente5" Then
                Me.lbl_cliente5.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_destino" Then
                Me.lbl_destino.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_fechIda" Then
                Me.lbl_fechIda.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_fechVue" Then
                Me.lbl_fechVue.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_origen" Then
                Me.lbl_origen.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_idPres" Then
                Me.lbl_idPres.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_cancelar" Then
                Me.btn_cancelar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_obtPaqNoProm" Then
                Me.btn_obtPaqNoProm.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_presupuesto" Then
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
    Private Sub frm_presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)
        Dim listadoDestinos As New List(Of Destinos)
        listadoDestinos = interfazPresupuesto.obtenerDestinosDisponibles()

        Dim enumerator As IEnumerator(Of Destinos) = listadoDestinos.GetEnumerator
        While enumerator.MoveNext
            lst_destino.Items.Add(enumerator.Current.destino)
            lst_origen.Items.Add(enumerator.Current.destino)
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_obtPaqProm_Click(sender As Object, e As EventArgs) Handles btn_obtPaqProm.Click
        Dim listadoPaquetesProm As DataTable
        listadoPaquetesProm = interfazPresupuesto.obtenerPaquetesPromo()
        dgw_PaqProm.DataSource = listadoPaquetesProm
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_hospedaje_Click(sender As Object, e As EventArgs) Handles btn_hospedaje.Click
        'Dim listadoHospedaje As DataTable
        'listadoHospedaje = interfazPresupuesto.obtenerHospedajesDisponibles()
        'dgw_hospedaje.DataSource = listadoHospedaje
        frm_hospedaje.Show()
    End Sub

    Private Sub btn_generapresu_Click(sender As Object, e As EventArgs) Handles btn_generapresu.Click
        Dim f As DataGridViewCellEventArgs
        dataGridViewVisualizar(sender, f)

    End Sub


    Private Sub dataGridViewVisualizar(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_PaqProm.CellContentClick, dgw_PaqProm.CellDoubleClick
        'Tomar del datagridview los valores necesarios para armar el presupuesto
        Dim oPresupuesto As Presupuesto
        oPresupuesto = New Presupuesto()


        'Obtener la cantidad de pasajeros | Ingresamos Pasajeros
        Dim cantPasajeros As Integer
        cantPasajeros = 0
        'Apellido - Nombre - fechaNacimiento - edad= sysdate - fechaNacimiento


        'obtener Primer Cliente | presupuesto generado con el dni del primer pasajero
        Dim oCliente As Cliente
        Dim _dni As String
        _dni = cli.dni
        oCliente = interfazPresupuesto.obtenerCliente(_dni)


        'Obtener Legajo del Vendedor
        Dim oUsuario As Usuario
        oUsuario = interfazUsuario.obtenerUsuario(UsuarioId)

        'Fecha de creacion | sysdate
        Dim _FCre As DateTime
        _FCre = DateTime.Now

        Dim idx As Integer
        idx = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgw_PaqProm.Rows(idx)

        'Creo el objeto Presupuesto
        Dim idPaquete As Integer
        Dim idOper As Integer
        Dim tipoPaq As String
        tipoPaq = selectedRow.Cells(8).Value.ToString()

        If tipoPaq = "PROMO" Then
            'FIXME:Obtener idPaquetePromo
            idPaquete = 1
        ElseIf tipoPaq = "NO PROMO" Then
            idPaquete = 0
            'FIXME: obtener id de la oper
            idOper = 1
        End If

        Dim estadoInicialPresu As String
        estadoInicialPresu = "SRES"

        oPresupuesto.codCliente = oCliente.codCliente.ToString()
        oPresupuesto.legPresu = oUsuario.legajo.ToString()
        oPresupuesto.destPres = selectedRow.Cells(1).Value.ToString()
        oPresupuesto.FechPartida = selectedRow.Cells(2).Value.ToString()
        oPresupuesto.FechRegreso = selectedRow.Cells(3).Value.ToString()
        oPresupuesto.idPaqPromocionable = idPaquete.ToString()
        oPresupuesto.FechCreacion = _FCre
        oPresupuesto.EstadoPresu = estadoInicialPresu.ToString()
        'Gravar presupuesto en estado sin reserva ni pago
        'ESTADOS: SRES - RES - PAG - CAN
        interfazPresupuesto.insertarPresupuesto(oPresupuesto)
        'Descontar disponibilidad para ese paquete
        If idPaquete = 1 Then
            interfazPresupuesto.descontarPaquete(idPaquete, cantPasajeros)
        ElseIf idPaquete = 0 Then
            interfazPresupuesto.descontarOperacion(idOper, cantPasajeros)
        End If
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'Cambiar el estado del presupuesto a cancelado
    End Sub
End Class