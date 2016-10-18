Imports Atlantida.BLL
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL
Public Class frm_PaqueteNoPromocionable
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
    Dim presupuestoTemporal As Presupuesto
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_PaqueteNoPromocionable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)
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
            If enu.Current.componente = "btn_seleccionar" Then
                Me.btn_seleccionar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_cancelar" Then
                Me.btn_cancelar.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_PaqNoProm" Then
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
    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        If presupuestoTemporal IsNot Nothing Then
            Me.Hide()
            frm_presupuesto.doAssembler(presupuestoTemporal)
            frm_presupuesto.Show()
        Else
            MsgBox("Seleccione un registro de la grilla,haciendo doble click sobre ella!")
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dataGridViewVisualizar(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_PaqNotProm.CellContentClick, dgw_PaqNotProm.CellDoubleClick
        'Guardo un presupuesto temporal en tiempo de ejecucion
        presupuestoTemporal = New Presupuesto()
        Dim idx As Integer
        idx = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgw_PaqNotProm.Rows(idx)

        'Creo el objeto Presupuesto
        Dim idPaquete As Integer
        Dim idOper As Integer
        Dim tipoPaq As String
        'Guardo tipo de paquete PROMO|NO PROMO
        tipoPaq = selectedRow.Cells(9).Value.ToString()

        If tipoPaq = "PROMO" Then
            idPaquete = selectedRow.Cells(0).Value.ToString()
        ElseIf tipoPaq = "NO PROMO" Then
            idPaquete = 0
            idOper = selectedRow.Cells(0).Value.ToString()
            presupuestoTemporal.idPaqueteNoPromocionable = idOper
        End If
        'Guardo el tipo de paquete 
        presupuestoTemporal.TipoPaquete = tipoPaq

        presupuestoTemporal.destPres = selectedRow.Cells(2).Value.ToString()
        presupuestoTemporal.FechPartida = selectedRow.Cells(3).Value.ToString()
        presupuestoTemporal.FechRegreso = selectedRow.Cells(4).Value.ToString()
        presupuestoTemporal.IdTransp = selectedRow.Cells(5).Value.ToString()
        presupuestoTemporal.idPaqPromocionable = idPaquete.ToString()
        presupuestoTemporal.dispPresu = selectedRow.Cells(7).Value
        presupuestoTemporal.MontoAPagar = selectedRow.Cells(8).Value
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
        Me.Close()
    End Sub
End Class