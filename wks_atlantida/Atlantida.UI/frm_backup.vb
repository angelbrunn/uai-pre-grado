Imports Atlantida.Entidades
Imports Atlantida.BLL.SIS.BLL
Imports Atlantida.Entidades.SIS.Entidades

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_backup
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
    Dim interfazBackup As INegBackup = New NegBackup
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Dim interfazNegocioBitacora As INegBitacora = New NegBitacora
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        Dim ruta As String

        Try
            If chkbxVendedor.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_vendedor.csv"
                interfazBackup.exportarAArchivoVendedor(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxBitacora.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_bitacora.csv"
                interfazBackup.exportarAArchivoBitacora(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxUsuario.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_usuario.csv"
                interfazBackup.exportarAArchivoUsuario(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxGrupo.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_grupo.csv"
                interfazBackup.exportarAArchivoGrupo(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxGrupoPermiso.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_grupoPermiso.csv"
                interfazBackup.exportarAArchivoGrupoPermisos(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxPermiso.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_permisos.csv"
                interfazBackup.exportarAArchivoPermisos(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxMultiIdioma.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_multiIdioma.csv"
                interfazBackup.exportarAArchivoMultiIdioma(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxUsuarioGrupo.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_usuarioGrupo.csv"
                interfazBackup.exportarAArchivoUsuarioGrupo(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxPresupuesto.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_presupuesto.csv"
                interfazBackup.exportarAArchivoPresupuesto(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxPago.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_pago.csv"
                interfazBackup.exportarAArchivoPago(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxCobro.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_cobro.csv"
                interfazBackup.exportarAArchivoCobro(ruta, Me.txtbxDelimitador.Text)
            End If

            MsgBox("Exportación realizada correctamente")
        Catch ex As Exception
            interfazNegocioBitacora.registrarEnBitacora_BKP(UsuarioId, ex)
            MsgBox("Se produjo un error al realizar la exportación")
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If enu.Current.componente = "lbl_del" Then
                Me.lbl_del.Text = enu.Current.value
            End If
            If enu.Current.componente = "lbl_ruta" Then
                Me.lbl_ruta.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxBitacora" Then
                Me.chkbxBitacora.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxUsuario" Then
                Me.chkbxUsuario.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxUsuarioGrupo" Then
                Me.chkbxUsuarioGrupo.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxGrupo" Then
                Me.chkbxGrupo.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxGrupoPermiso" Then
                Me.chkbxGrupoPermiso.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxPermiso" Then
                Me.chkbxPermiso.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxVendedor" Then
                Me.chkbxVendedor.Text = enu.Current.value
            End If
            If enu.Current.componente = "chkbxMultiIdioma" Then
                Me.chkbxMultiIdioma.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_Exportar" Then
                Me.btn_Exportar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_Importar" Then
                Me.btn_Importar.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_SeleccionarTodo" Then
                Me.btn_SeleccionarTodo.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_DesSeleccionarTodo" Then
                Me.btn_DesSeleccionarTodo.Text = enu.Current.value
            End If
            If enu.Current.componente = "btn_salir" Then
                Me.btn_salir.Text = enu.Current.value
            End If
            If enu.Current.componente = "frm_backup" Then
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
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importar.Click
        Dim ruta As String
        Try

            If chkbxVendedor.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_vendedor.csv"
                interfazBackup.importarDesdeArchivoVendedor(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxBitacora.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_bitacora.csv"
                interfazBackup.importarDesdeArchivoBitacora(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxUsuario.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_usuario.csv"
                interfazBackup.importarDesdeArchivoUsuario(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxGrupo.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_grupo.csv"
                interfazBackup.importarDesdeArchivoGrupo(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxGrupoPermiso.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_grupoPermiso.csv"
                interfazBackup.importarDesdeArchivoGrupoPermiso(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxPermiso.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_permisos.csv"
                interfazBackup.importarDesdeArchivoPermiso(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxMultiIdioma.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_multiIdioma.csv"
                interfazBackup.importarDesdeArchivoMultiIdioma(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxUsuarioGrupo.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_usuariogrupo.csv"
                interfazBackup.importarDesdeArchivoUsuarioGrupo(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxPresupuesto.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_presupuesto.csv"
                interfazBackup.importarDesdeArchivoPresupuesto(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxPago.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_pago.csv"
                interfazBackup.importarDesdeArchivoPago(ruta, Me.txtbxDelimitador.Text)
            End If

            If chkbxCobro.Checked Then
                ruta = Me.txtbxRuta.Text + "bkp_cobro.csv"
                interfazBackup.importarDesdeArchivoCobro(ruta, Me.txtbxDelimitador.Text)
            End If

            MsgBox("Importación realizada de forma satisfactoria")
        Catch ex As Exception
            interfazNegocioBitacora.registrarEnBitacora_BKP(UsuarioId, ex)
            MsgBox("Error al realizar la importación")
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtbxSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkbxVendedorExportar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxVendedor.CheckedChanged
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkbxUsuarioExportar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxUsuario.CheckedChanged
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkbxVendedoresImportar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkbxUsuarioImportar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSeleccionarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SeleccionarTodo.Click
        Me.chkbxVendedor.Checked = True
        Me.chkbxBitacora.Checked = True
        Me.chkbxUsuario.Checked = True
        Me.chkbxUsuarioGrupo.Checked = True
        Me.chkbxGrupo.Checked = True
        Me.chkbxGrupoPermiso.Checked = True
        Me.chkbxPermiso.Checked = True
        Me.chkbxMultiIdioma.Checked = True
        Me.chkbxPresupuesto.Checked = True
        Me.chkbxPago.Checked = True
        Me.chkbxCobro.Checked = True
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDesSeleccionarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DesSeleccionarTodo.Click
        Me.chkbxVendedor.Checked = False
        Me.chkbxBitacora.Checked = False
        Me.chkbxUsuario.Checked = False
        Me.chkbxUsuarioGrupo.Checked = False
        Me.chkbxGrupo.Checked = False
        Me.chkbxGrupoPermiso.Checked = False
        Me.chkbxPermiso.Checked = False
        Me.chkbxMultiIdioma.Checked = False
        Me.chkbxPresupuesto.Checked = False
        Me.chkbxCobro.Checked = False
        Me.chkbxPago.Checked = False
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub a_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.Enter
        Me.txtbxDelimitador.Text = ";"
        Me.txtbxRuta.Text = "C:\Logs Atlantida\"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkbxBitacora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxBitacora.CheckedChanged
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