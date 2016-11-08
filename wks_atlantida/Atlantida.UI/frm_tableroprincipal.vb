Imports Atlantida.Entidades.SIS.Entidades
Imports Atlantida.BLL.SIS.BLL

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class frm_TableroPrincipal
    ''' <summary>
    ''' Guardo nombre de la aplicacion
    ''' </summary>
    ''' <remarks></remarks>
    Dim ApplicationName As String = "SIS-Atlantida"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private unUsuarioField As Usuario
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_TableroPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim idiomaElegido As String
        'Deshabilito todos los controles
        Me.Menu_Administracion.Visible = False
        Me.Menu_Generar.Visible = False
        Me.Menu_CyP.Visible = False
        'Me.Menu_Negocio.Visible = False
        ' Me.Menu_PstVenta.Visible = False
        Me.Menu_Terminar.Visible = False
        'Eligo el idioma segun lo establecido
        Me.modificarIdiomaSegunPreferencias(unUsuario.idioma)
        'Recorro el objeto usuario, y voy habilitando segun los permisos que tenga asociados.
        Dim enu As IEnumerator(Of Grupo) = Me.unUsuario.listadoGrupos.GetEnumerator
        While enu.MoveNext
            Dim enu2 As IEnumerator(Of Permiso) = enu.Current.listadoPermisos.GetEnumerator
            While enu2.MoveNext
                If enu2.Current.descripcion = "Full Access" Then
                    Me.Menu_Administracion.Visible = True
                    Me.Menu_Generar.Visible = True
                    Me.Menu_CyP.Visible = True
                    'Me.Menu_Negocio.Visible = True
                    'Me.Menu_PstVenta.Visible = True
                    Me.Menu_Terminar.Visible = True
                End If

                If enu2.Current.descripcion = "Modulo Presupuesto" Then
                    Me.Menu_Generar.Visible = True
                    Me.Menu_CyP.Visible = True
                    Me.Menu_Terminar.Visible = True
                End If

                If enu2.Current.descripcion = "Modulo Tablero de Control" Then
                    Me.Menu_Generar.Visible = True
                    Me.Menu_CyP.Visible = True
                    'Me.Menu_Negocio.Visible = True
                    'Me.Menu_PstVenta.Visible = True
                    Me.Menu_Terminar.Visible = True
                End If

            End While
        End While
        If unUsuario.idioma = "es" Then
            idiomaElegido = "Español"
        Else
            idiomaElegido = "Ingles"
        End If
        MsgBox("El idioma elegido es: " + idiomaElegido)
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
            If enu.Current.componente = "Menu_Administracion" Then
                Me.Menu_Administracion.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_CyP" Then
                Me.Menu_CyP.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_Generar" Then
                Me.Menu_Generar.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_Negocio" Then
                'Me.Menu_Negocio.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_PstVenta" Then
                'Me.Menu_PstVenta.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_Idioma" Then
                Me.Menu_Idioma.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_Terminar" Then
                Me.Menu_Terminar.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Cobro" Then
                Me.SubMenu_Cobro.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Depuracion" Then
                Me.SubMenu_Depuracion.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Encuesta" Then
                'Me.SubMenu_Encuesta.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Metricas" Then
                'Me.SubMenu_Metricas.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Pago" Then
                Me.SubMenu_Pago.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Presupuesto" Then
                Me.SubMenu_Presupuesto.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Resguardo" Then
                Me.SubMenu_Resguardo.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Salir" Then
                Me.SubMenu_Salir.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Usuario" Then
                Me.SubMenu_Usuario.Text = enu.Current.value
            End If
            If enu.Current.componente = "SubMenu_Cambiar" Then
                Me.SubMenu_Cambiar.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_Ayuda" Then
                Me.Menu_Ayuda.Text = enu.Current.value
            End If
            If enu.Current.componente = "Menu_Leer" Then
                Me.Menu_Leer.Text = enu.Current.value
            End If
        End While
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuUsuario_Click(sender As Object, e As EventArgs) Handles SubMenu_Usuario.Click
        'Persisto el usuario dentro de mi aplicacion
        frm_usuario.UsuarioId = unUsuario.idUsuario
        frm_usuario.UsuarioIdioma = unUsuario.idioma
        frm_usuario.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuResguardo_Click(sender As Object, e As EventArgs) Handles SubMenu_Resguardo.Click
        'Persisto el usuario dentro de mi aplicacion
        frm_backup.UsuarioId = unUsuario.idUsuario
        frm_backup.UsuarioIdioma = unUsuario.idioma
        frm_backup.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuPresupuesto_Click(sender As Object, e As EventArgs) Handles SubMenu_Presupuesto.Click
        'Persisto el usuario dentro de mi aplicacion
        frm_presupuesto.UsuarioId = unUsuario.idUsuario
        frm_presupuesto.UsuarioIdioma = unUsuario.idioma
        frm_presupuesto.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuCobro_Click(sender As Object, e As EventArgs) Handles SubMenu_Cobro.Click
        'Persisto el usuario dentro de mi aplicacion
        frm_cobro.UsuarioId = unUsuario.idUsuario
        frm_cobro.UsuarioIdioma = unUsuario.idioma
        frm_cobro.Show()
    End Sub

    Private Sub CambiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubMenu_Cambiar.Click
        Dim formulario As New frm_idioma()
        formulario.chUsuario = unUsuario
        formulario.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuPago_Click(sender As Object, e As EventArgs) Handles SubMenu_Pago.Click
        'Persisto el usuario dentro de mi aplicacion
        frm_pago.UsuarioId = unUsuario.idUsuario
        frm_pago.UsuarioIdioma = unUsuario.idioma
        frm_pago.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuMetricas_Click(sender As Object, e As EventArgs)
        'Persisto el usuario dentro de mi aplicacion
        frm_metrica.UsuarioId = unUsuario.idUsuario
        frm_metrica.UsuarioIdioma = unUsuario.idioma
        frm_metrica.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuEncuesta_Click(sender As Object, e As EventArgs)
        'Persisto el usuario dentro de mi aplicacion
        frm_encuesta.UsuarioId = unUsuario.idUsuario
        frm_encuesta.UsuarioIdioma = unUsuario.idioma
        frm_encuesta.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DepuracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubMenu_Depuracion.Click
        'Persisto el usuario dentro de mi aplicacion
        frm_debug.UsuarioId = unUsuario.idUsuario
        frm_debug.UsuarioIdioma = unUsuario.idioma
        frm_debug.Show()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubMenuSalir_Click(sender As Object, e As EventArgs) Handles SubMenu_Salir.Click
        Me.Close()
        Application.ExitThread()
    End Sub
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