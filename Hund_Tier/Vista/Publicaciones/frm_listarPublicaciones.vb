Public Class frm_listarPublicaciones

    'VAriable tipo animal por defecto
    Dim tipo_animal As Integer = frm_publicar_aviso.TipoAnimal.perro

    'Variable para el tipo de publicacion por defecto
    Dim tipo_publicacion As Integer = frm_publicar_aviso.AccionUsuario.adopcion

    'Instancia de PublicacionService para usar en los distintos metodos
    Dim publiServicio As New PublicacionService


    Private Sub frm_listarPublicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCampos()

    End Sub


    'Sub que llena el grid con las publicaciones de la lista pasada por parametro
    Public Sub llenarGrid(ByRef source As List(Of Publicacion))
        dgv_publicaciones.Rows.Clear()
        For Each oPublicacion As Publicacion In source
            dgv_publicaciones.Rows.Add(New String() {oPublicacion.codigoPublicacion.ToString, oPublicacion.animal.nombre, oPublicacion.animal.razaString, oPublicacion.animal.tipoAnimalString, oPublicacion.animal.edadString, oPublicacion.animal.peloString, oPublicacion.animal.sexoString, oPublicacion.barrioString, oPublicacion.nombreCiudad, oPublicacion.nombreUsuario})
        Next
    End Sub

    Private Function validarCampos() As Boolean
        If txt_nombre_animal.Text = String.Empty Then
            If cmb_raza.SelectedItem Is Nothing Then
                If cmb_color1.SelectedItem Is Nothing Then
                    If cmb_color2.SelectedItem Is Nothing Then
                        If cmb_sexo.SelectedItem Is Nothing Then
                            If cmb_edad.SelectedItem Is Nothing Then
                                If cmb_pelo.SelectedItem Is Nothing Then
                                    If cmb_barrio.SelectedItem Is Nothing Then
                                        If cmb_tamano.SelectedItem Is Nothing Then
                                            MsgBox("Debe completar al menos un campo para continuar", MsgBoxStyle.OkOnly, "Error ")
                                            Return False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return True
    End Function

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If validarCampos() Then
            ' Animal  y publicacion que agregaremos a la BD o con los que buscaremos un animal
            Dim unAni As New Animal
            Dim publi As New Publicacion

            'Definimos una lista de publicaciones que es la que le vamos a pasar a la siguiente
            ' Ventana

            Dim lstPubli As List(Of Publicacion)

            'Completamos los datos del animal que se quiere encontrar

            'Vamos a hacer la consulta en la BD con parametros. Es decir con una lista de filtros
            Dim filters As New List(Of Object)

            If txt_nombre_animal.Text <> "" Then
                'Si el txt tiene un texto no vacìo entonces enviamos como filtro el nombre del animal a consultar
                filters.Add(txt_nombre_animal.Text) ' param1
            Else
                filters.Add(Nothing)
            End If 'Fin if de nombreANimal.text

            'Agregamos el tipo del animal que se busca
            filters.Add(tipo_animal) '  param2

            filters.Add(tipo_publicacion) 'param3

            If Not cmb_raza.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro la raza  a consultar
                filters.Add(cmb_raza.SelectedValue) 'param3
            Else
                filters.Add(Nothing)
            End If ' If de cmbRaza.selectedVAlue

            If Not cmb_color1.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del color a consultar
                filters.Add(cmb_color1.SelectedValue) 'param4
            Else
                filters.Add(Nothing)
            End If

            If Not cmb_color2.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del color a consultar
                filters.Add(cmb_color2.SelectedValue) 'param5
            Else
                filters.Add(Nothing)
            End If

            If Not cmb_edad.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id de la edad a consultar
                filters.Add(cmb_edad.SelectedValue) 'param6
            Else
                filters.Add(Nothing)
            End If

            If Not cmb_sexo.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del sexo a consultar
                filters.Add(cmb_sexo.SelectedValue) 'param7
            Else
                filters.Add(Nothing)
            End If

            If Not cmb_tamano.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del tamaño a consultar
                filters.Add(cmb_tamano.SelectedValue) 'param8
            Else
                filters.Add(Nothing)
            End If

            If Not cmb_pelo.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del pelo a consultar
                filters.Add(cmb_pelo.SelectedValue) 'param9
            Else
                filters.Add(Nothing)
            End If

            If Not cmb_barrio.SelectedItem Is Nothing Then
                'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del barrio a consultar
                filters.Add(cmb_barrio.SelectedValue) 'param10
            Else
                filters.Add(Nothing)
            End If


            ' Agregamos el nombre de la ciudad
            filters.Add(txt_ciudad.Text) 'param11


            ' TODO arreglar el tema de las fechas. Tengo formato dd/mm/yy y no me lo permite

            'Mostramos las fechas para las cuales se va a realizar la busqueda y esperamos el resultado
            'Dim frm_seleccionFechas As New Frm_fechasBusqueda
            'frm_seleccionFechas.ShowDialog()

            'Si las fechas son validas (El usuario apreto OK y se validaron las fechas) las agregamos a los filtros

            'If frm_seleccionFechas.flagFechas Then
            '    filters.Add(frm_seleccionFechas.getFechaDesde)
            '    filters.Add(frm_seleccionFechas.getFechaHasta)
            'Else
            '    filters.Add(Nothing)
            '    filters.Add(Nothing)
            'End If

            'Chequeamos los radiobuttons a ver cual esta chequeado
            If rb_si.Checked Then
                filters.Add(frm_publicar_aviso.idCastrado.si)
            Else
                If rbtn_no.Checked Then
                    filters.Add(frm_publicar_aviso.idCastrado.no)
                Else
                    If rbtn_NoSabe.Checked Then
                        filters.Add(frm_publicar_aviso.idCastrado.desconoce)
                    Else
                        filters.Add(Nothing)
                    End If
                End If
            End If

            'Con todos los filtros agregados vamos a buscar en la BD para mostrar en la grilla 
            ' De la siguiente ventana. 
            lstPubli = publiServicio.consultarPublicacionesConFiltro(filters.ToArray)

            ' Chequeamos la cantidad de objetos que contiene la lista devuelta para saber si se 
            ' encontraron coincidencias o no
            If lstPubli.Count <> 0 Then
                'Si la lista no esta vacia se muestra el form donde se listan las publicaciones obtenidas
                llenarGrid(lstPubli)

            Else
                'Si la lista esta vacia se le avisa al usuario
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados",
               "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ''TODO agregar nueva busqueda a la BD 
            Dim unaBusqueda As New Busqueda
            unaBusqueda.idBusqueda = publiServicio.generarIdBusqueda()
            unaBusqueda.tipoAnimal = tipo_animal
            unaBusqueda.tipoPublicacion = tipo_publicacion
            If cmb_raza.SelectedValue IsNot Nothing Then
                unaBusqueda.razaAnimal = cmb_raza.SelectedValue
            End If
            If publiServicio.agregarBusqueda(unaBusqueda) <> 1 Then
                MessageBox.Show("Error", "Insertar Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub


    Private Sub llenarCampos()
        'Cargamos los combos a partir de ComboService 
        Dim cmbServicio As New CombosService
        'Obtenemos la tabla con todos los barrios
        Dim TablaDatos = cmbServicio.getBarrios
        'Cargamos el combo mediante el metodo llenarCombo de CombosService
        'Es todo lo mismo, lo unico que cambia es el combo a rellenar y 
        ' los ultimos dos parametros
        cmbServicio.llenarCombo(cmb_barrio, TablaDatos, "nombre", "ID_BARRIO")
        'Reutilizamos la tabla, pero ahora le cargamos las razas

        'Si el tipo de animal es un perro, cargamos los combos con lo que le corresponde a perros. 
        If tipo_animal = frm_publicar_aviso.TipoAnimal.perro Then
            TablaDatos = cmbServicio.getRazasPerros
            cmbServicio.llenarCombo(cmb_raza, TablaDatos, "nombre_raza", "cod_raza")
            'Si el animal es un gato llenamos los combos con lo relativo a gatos. 
        Else
            TablaDatos = cmbServicio.getRazasGatos
            cmbServicio.llenarCombo(cmb_raza, TablaDatos, "nombre_raza", "cod_raza")
        End If

        'Carga de combos que son iguales tanto para perros como para gatos, de aca para abajo. 
        'Reutilizamos la tabla para cargar los combos color1 y color2
        TablaDatos = cmbServicio.getColores
        cmbServicio.llenarCombo(cmb_color1, TablaDatos, "nombre", "id_color")
        'Volvemos a cargar con los colores
        TablaDatos = cmbServicio.getColores
        cmbServicio.llenarCombo(cmb_color2, TablaDatos, "nombre", "id_color")

        'Cargamos combo sexos
        TablaDatos = cmbServicio.getSexos
        cmbServicio.llenarCombo(cmb_sexo, TablaDatos, "nombre_sexo", "codigo_sexo")
        'Cargamos combo edades
        TablaDatos = cmbServicio.getEdadesAnimal
        cmbServicio.llenarCombo(cmb_edad, TablaDatos, "nombre_edad", "codigo_edad")
        'Cargamos el combo tamaño
        TablaDatos = cmbServicio.getTamanosAnimal
        cmbServicio.llenarCombo(cmb_tamano, TablaDatos, "nombre_tamano", "codigo_tamano")
        'Cargamos el combo pelo
        TablaDatos = cmbServicio.getPelosAnimal
        cmbServicio.llenarCombo(cmb_pelo, TablaDatos, "nombre_pelo", "codigo_pelo")
    End Sub

    'Funcion para setear el tipo de animal que manejara esta ventana puede ser gato o perro
    Public Sub setTipoAnimal(valor As Integer)
        tipo_animal = valor
    End Sub

    Public Sub setTipoPublicacion(valor As Integer)
        tipo_publicacion = valor
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        resetearCampos()

    End Sub

    Private Sub resetearCampos()
        txt_nombre_animal.Text = ""
        cmb_raza.SelectedValue = -1
        cmb_edad.SelectedValue = -1
        cmb_pelo.SelectedValue = -1
        cmb_sexo.SelectedValue = -1
        cmb_tamano.SelectedValue = -1
        cmb_color1.SelectedValue = -1
        cmb_color2.SelectedValue = -1
        cmb_barrio.SelectedValue = -1
        rb_si.Checked = False
        rbtn_no.Checked = False
        rbtn_NoSabe.Checked = False
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub
End Class