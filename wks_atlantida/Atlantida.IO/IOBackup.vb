Imports System.IO
Imports Atlantida.IO
Imports Atlantida.Entidades.SIS.Entidades

Namespace SIS.IO
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class IOBackup
        ''' <summary>
        ''' LEER
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoVendedor(ByVal ruta As String, ByVal delim As String) As List(Of Vendedor)
            Dim lista As New List(Of Vendedor)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oVendedor As New Vendedor

                            'legajo;apellido;nombre;telefono;domicilio;fechaNacimiento;activo
                            'Agregar todos los campos de vendedor

                            oVendedor.legajo = CType(vec(0), Integer)
                            oVendedor.apellido = CType(vec(1), String)
                            oVendedor.nombre = CType(vec(2), String)
                            oVendedor.telefono = CType(vec(3), String)
                            oVendedor.domicilio = CType(vec(4), String)
                            oVendedor.fechaNacimiento = CType(vec(5), Date)
                            oVendedor.activo = CType(vec(6), Boolean)
                            lista.Add(oVendedor)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try

            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoUsuario(ByVal ruta As String, ByVal delim As String) As List(Of Usuario)
            Dim lista As New List(Of Usuario)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oUsuario As New Usuario

                            'idUsuario;usuario;password;legajo;digitoVerificador
                            'Agregar todos los campos de usuario

                            oUsuario.idUsuario = CType(vec(0), Integer)
                            oUsuario.usuario = CType(vec(1), String)
                            oUsuario.password = CType(vec(2), String)
                            oUsuario.legajo = CType(vec(3), String)
                            oUsuario.idioma = CType(vec(4), String)
                            oUsuario.digitoVerificador = CType(vec(5), String)
                            lista.Add(oUsuario)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try

            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoBitacora(ByVal ruta As String, ByVal delim As String) As List(Of Bitacora)
            Dim lista As New List(Of Bitacora)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oBitacora As New Bitacora
                            oBitacora.idEvento = CType(vec(0), Integer)
                            oBitacora.idUsuario = CType(vec(1), Integer)
                            oBitacora.descripcion = CType(vec(2), String)
                            oBitacora.fecha = CType(vec(3), Date)
                            lista.Add(oBitacora)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try
            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoGrupo(ByVal ruta As String, ByVal delim As String) As List(Of Grupo)
            Dim lista As New List(Of Grupo)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oGrupo As New Grupo
                            oGrupo.idGrupo = CType(vec(0), Integer)
                            oGrupo.grupo = CType(vec(1), String)
                            oGrupo.descripcion = CType(vec(2), String)
                            lista.Add(oGrupo)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try
            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoGrupoPermiso(ByVal ruta As String, ByVal delim As String) As List(Of GrupoPermiso)
            Dim lista As New List(Of GrupoPermiso)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oGrupoPermiso As New GrupoPermiso
                            oGrupoPermiso.idGrupo = CType(vec(0), Integer)
                            oGrupoPermiso.idPermiso = CType(vec(1), Integer)
                            lista.Add(oGrupoPermiso)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try

            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoPermiso(ByVal ruta As String, ByVal delim As String) As List(Of Permiso)
            Dim lista As New List(Of Permiso)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oPermiso As New Permiso
                            oPermiso.idPermiso = CType(vec(0), Integer)
                            oPermiso.descripcion = CType(vec(1), String)
                            lista.Add(oPermiso)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try

            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoMultiIdioma(ByVal ruta As String, ByVal delim As String) As List(Of MultiIdioma)
            Dim lista As New List(Of MultiIdioma)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oMultiIdioma As New MultiIdioma
                            oMultiIdioma.componente = CType(vec(0), String)
                            oMultiIdioma.iKey = CType(vec(1), String)
                            oMultiIdioma.value = CType(vec(2), String)
                            lista.Add(oMultiIdioma)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try

            Return lista
        End Function
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function leerArchivoUsuarioGrupo(ByVal ruta As String, ByVal delim As String) As List(Of UsuarioGrupo)
            Dim lista As New List(Of UsuarioGrupo)

            Try
                Dim linea As String = ""
                Dim sr As New StreamReader(ruta)
                Dim contador As Integer = 0
                Do
                    linea = sr.ReadLine()
                    If Not linea = Nothing Then
                        If contador > 0 Then
                            Dim vec() As String = linea.Split(delim)
                            Dim oUsuarioGrupo As New UsuarioGrupo
                            oUsuarioGrupo.idUsuario = CType(vec(0), Integer)
                            oUsuarioGrupo.idGrupo = CType(vec(1), Integer)
                            lista.Add(oUsuarioGrupo)
                        End If
                    End If
                    contador = contador + 1

                Loop Until linea Is Nothing
                sr.Close()
            Catch ex As Exception
                'Throw New BKPException("Error leyendo el Archivo")
            End Try

            Return lista
        End Function
        ''' <summary>
        ''' Escribir
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaVendedor"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoVendedor(ByVal ruta As String, ByVal delim As String, ByVal listaVendedor As List(Of Vendedor))

            'legajo;apellido;nombre;telefono;domicilio;fechaNacimiento;activo
            Dim cabecera As String = "legajo;apellido;nombre;telefono;domicilio;fechaNacimiento;activo"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Vendedor) = listaVendedor.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.legajo.ToString() + ";" + enumC.Current.apellido _
                + ";" + enumC.Current.nombre + ";" + enumC.Current.telefono + ";" + _
                enumC.Current.domicilio + ";" + enumC.Current.fechaNacimiento.ToString + ";" + _
                enumC.Current.activo.ToString

                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaUsuario"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoUsuario(ByVal ruta As String, ByVal delim As String, ByVal listaUsuario As List(Of Usuario))

            'idUsuario;usuario;password;legajo;idioma;digitoVerificador
            Dim cabecera As String = "idUsuario;usuario;password;legajo;idioma;digitoVerificador"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Usuario) = listaUsuario.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idUsuario.ToString() + delim + enumC.Current.usuario _
                + delim + enumC.Current.password + delim + enumC.Current.legajo + delim + _
                enumC.Current.idioma + delim + enumC.Current.digitoVerificador

                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaEventos"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoBitacora(ByVal ruta As String, ByVal delim As String, ByVal listaEventos As List(Of Bitacora))

            'idEvento;idUsuario;descripcion;fecha
            Dim cabecera As String = "idEvento;idUsuario;descripcion;fecha"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Bitacora) = listaEventos.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idEvento.ToString() + delim + enumC.Current.idUsuario.ToString _
                + delim + enumC.Current.descripcion.ToString + delim + enumC.Current.fecha.ToString

                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaUsuarioGrupo"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoUsuarioGrupo(ByVal ruta As String, ByVal delim As String, ByVal listaUsuarioGrupo As List(Of UsuarioGrupo))

            'idUsuario;idGrupo
            Dim cabecera As String = "idUsuario;idGrupo"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of UsuarioGrupo) = listaUsuarioGrupo.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idUsuario.ToString() + delim + enumC.Current.idGrupo.ToString
                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaGrupo"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoGrupo(ByVal ruta As String, ByVal delim As String, ByVal listaGrupo As List(Of Grupo))

            'idUsuario;idGrupo
            Dim cabecera As String = "idGrupo;grupo;descripcion"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Grupo) = listaGrupo.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idGrupo.ToString() + delim + enumC.Current.grupo.ToString + delim + enumC.Current.descripcion.ToString
                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaGrupoPermiso"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoGrupoPermiso(ByVal ruta As String, ByVal delim As String, ByVal listaGrupoPermiso As List(Of GrupoPermiso))

            Dim cabecera As String = "idGrupo;idPermiso"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of GrupoPermiso) = listaGrupoPermiso.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idGrupo.ToString() + delim + enumC.Current.idPermiso.ToString()
                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaPermiso"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoPermiso(ByVal ruta As String, ByVal delim As String, ByVal listaPermiso As List(Of Permiso))

            Dim cabecera As String = "idPermiso;descripcion"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of Permiso) = listaPermiso.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.idPermiso.ToString() + delim + enumC.Current.descripcion.ToString()
                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="delim"></param>
        ''' <param name="listaPermiso"></param>
        ''' <remarks></remarks>
        Public Sub escribirArchivoMultiIdioma(ByVal ruta As String, ByVal delim As String, ByVal listaPermiso As List(Of MultiIdioma))

            Dim cabecera As String = "componente;idiomaEspanol;idiomaIngles"

            Dim sw As New StreamWriter(ruta)
            sw.WriteLine(cabecera)
            Dim linea As String

            Dim enumC As IEnumerator(Of MultiIdioma) = listaPermiso.GetEnumerator()
            While (enumC.MoveNext())
                linea = enumC.Current.componente.ToString() + delim + enumC.Current.iKey.ToString() + delim + enumC.Current.value.ToString()
                sw.WriteLine(linea)
            End While
            sw.Close()
        End Sub
    End Class
End Namespace