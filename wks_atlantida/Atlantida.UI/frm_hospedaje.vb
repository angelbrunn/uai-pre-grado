Imports Atlantida.BLL
Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL
Public Class frm_hospedaje
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
    Dim hospedajeTemporal As Hospedaje
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim interfazPresupuesto As NegPresupuesto = New NegPresupuesto
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_hospedaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificarIdiomaSegunPreferencias(UsuarioIdioma)
        Dim listadoHospedaje As DataTable
        listadoHospedaje = interfazPresupuesto.obtenerHospedajesDisponibles()
        dgw_hospedaje.DataSource = listadoHospedaje
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
            If enu.Current.componente = "frm_hospedaje" Then
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
        Me.Hide()
        frm_presupuesto.doAssemblerMachHotel(hospedajeTemporal)
        frm_presupuesto.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dataGridViewVisualizar(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_hospedaje.CellContentClick, dgw_hospedaje.CellDoubleClick
        'Guardo un presupuesto temporal en tiempo de ejecucion
        hospedajeTemporal = New Hospedaje()
        Dim idx As Integer
        idx = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgw_hospedaje.Rows(idx)

        hospedajeTemporal.idHospedaje = selectedRow.Cells(0).Value.ToString()
        hospedajeTemporal.razSocial = selectedRow.Cells(1).Value.ToString()
        hospedajeTemporal.monPagar = selectedRow.Cells(2).Value.ToString()
        hospedajeTemporal.cat = selectedRow.Cells(3).Value.ToString()
        hospedajeTemporal.desc = selectedRow.Cells(4).Value.ToString()
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