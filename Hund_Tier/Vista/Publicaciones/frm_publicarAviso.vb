﻿Public Class frm_publicar_aviso
    Dim usuario As Usuario
    'Booleano que permite saber si las fechas ingresadas son validas.
    Dim flagFechas = False
    Friend Enum TipoAnimal As Integer
        perro = 1
        gato = 2
    End Enum
    'Bandera que me permite setear el tipo de animal para el quie se hara la publicacion, desde otras ventanas)
    'Por defecto es 1 = perro
    Dim tipo_animal = TipoAnimal.perro

    Enum AccionUsuario As Integer
        adopcion = 1
        perdido = 2
        encontrado = 3
    End Enum

    Friend Enum idCastrado As Integer
        si = 1
        no = 2
        desconoce = 3
    End Enum
    'Bandera para saber que tipo de publicacion es, adopcion = 1, perdido = 2, encontrado = 3
    Dim accion_usuario = 1
    'Cuando carga la form hay que cargar los combos Barrio y los campos nombre y email con los datos del 
    'usuario

    'Instancia de PublicacionService para usar en los distintos metodos
    Dim publiServicio As New PublicacionService


    Private Sub frm_publicar_aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCampos()
        usuario = Frm_main.getusuario()

    End Sub

    Public Sub setTitulo(titulo As String)
        Me.Text = titulo
    End Sub
    Public Sub setTipoAnimal(valor As Integer)
        tipo_animal = valor
    End Sub
    Public Sub setTipoPublicacion(valor As Integer)
        accion_usuario = valor
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
        If tipo_animal = TipoAnimal.perro Then
            TablaDatos = cmbServicio.getRazasPerros
            cmbServicio.llenarCombo(cmb_raza, TablaDatos, "nombre_raza", "cod_raza")

        Else
            'Si el animal es un gato llenamos los combos con lo relativo a gatos. 
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

        'Si el tipo de publicacion es adopcion cargamos los nombres del usuario
        If accion_usuario = AccionUsuario.adopcion Then

            ' El nombre y email del usuario lo conseguimos desde el usuario de la frm_main
            ' ????? Si es singleton, no deberia tomar todo directamente desde frm_main y no tener una 
            ' instancia de usuario. ?????
            usuario = Frm_main.getusuario()
            txt_nombre_responsable.Text = usuario.getNombre
            txt_mail_responsable.Text = usuario.getEmail
            txt_telefono_1.Text = usuario.getNumTelefono
        End If
    End Sub

    'Funcion que sirve para validar que se hayan rellenado todos los campos obligatorios, caso contrario
    'se informa con una ventana para que cada campo se complete
    Private Function validar_campos() As Boolean

        'validamos los campos obligatorios  segun el tipo de publicacion 

        If accion_usuario = AccionUsuario.adopcion Or accion_usuario = AccionUsuario.perdido Then
            'campos obligatorios
            If txt_nombre_animal.Text = String.Empty Then
                txt_nombre_animal.BackColor = Color.Red
                txt_nombre_animal.Focus()
                frm_UsuarioABM.informar_campo_faltante(lbl_nombre_animal.Text)
                Return False
            Else
                txt_nombre_animal.BackColor = Color.White
            End If

            If cmb_raza.SelectedItem Is Nothing Then
                frm_UsuarioABM.informar_campo_faltante(lbl_raza.Text)
                Return False
            End If
            If cmb_color1.SelectedItem Is Nothing Then
                frm_UsuarioABM.informar_campo_faltante(lbl_color_1.Text)
                Return False
            End If
            If cmb_sexo.SelectedItem Is Nothing Then
                frm_UsuarioABM.informar_campo_faltante(lbl_sexo_animal.Text)
                Return False
            End If
            If cmb_edad.SelectedItem Is Nothing Then
                frm_UsuarioABM.informar_campo_faltante(lbl_edad.Text)
                Return False
            End If
            If cmb_tamano.SelectedItem Is Nothing Then
                frm_UsuarioABM.informar_campo_faltante(lbl_tamano.Text)
                Return False
            End If
            If cmb_pelo.SelectedItem Is Nothing Then
                frm_UsuarioABM.informar_campo_faltante(lbl_pelo.Text)
                Return False
            End If

            'Si el usuario no agrego un telefono cuando se dio de alta, vamos a necesitar que agregue al menos uno.
            If txt_telefono_1.Text = "" Then
                If txt_telefono_2.Text = "" Then
                    MsgBox("Debe agregar al menos un telefono", MsgBoxStyle.OkOnly, "Error con telefono")
                    txt_telefono_2.BackColor = Color.Red
                    txt_telefono_2.Focus()
                    Return False
                End If
            End If
        End If ' If de accion_usuario


        Return True
    End Function

    Private Sub btn_publicar_Click(sender As Object, e As EventArgs) Handles btn_publicar.Click
        If validar_campos() Then
            ' Animal  y publicacion que agregaremos a la BD o con los que buscaremos un animal
            Dim unAni As New Animal
            Dim publi As New Publicacion

            'Si el usuario esta haciendo una publicacion se crea una publiacion y se la carga con
            'los datos del animal, usuario y la publicacion.
            If accion_usuario = AccionUsuario.adopcion Or accion_usuario = AccionUsuario.perdido Or accion_usuario = AccionUsuario.encontrado Then

                'Chequeamos todo lo pertinente al animal de la publicacion.

                ' Creamos una variable del tipo booleana para saber que tipo de animal es, si es perro da verdadero
                ' Si es gato da falso
                Dim esPerro = (tipo_animal = TipoAnimal.perro)

                ' Si lo que se va a agregar es un perro. 
                If esPerro Then
                    unAni.tipoAnimal = TipoAnimal.perro
                    unAni.idAnimal = BDHelper.getDBHelper.generarIdAnimal(tipo_animal)

                    ' Si lo que agregamos es un gato
                Else
                    unAni.tipoAnimal = TipoAnimal.gato
                    unAni.idAnimal = BDHelper.getDBHelper.generarIdAnimal(tipo_animal)
                End If

                'Datos comunes tanto a perros como gatos
                unAni.nombre = txt_nombre_animal.Text
                unAni.tamano = cmb_tamano.SelectedValue
                unAni.idTipoPelo = cmb_pelo.SelectedValue
                unAni.idRaza = cmb_raza.SelectedValue
                unAni.idEdad = cmb_edad.SelectedValue
                unAni.idSexo = cmb_sexo.SelectedValue
                unAni.idColor1 = cmb_color1.SelectedValue
                If cmb_color2.SelectedValue IsNot Nothing Then
                    unAni.idColor2 = cmb_color2.SelectedValue
                End If

                If rb_si.Checked Then
                    unAni.idCondicionCastrado = 1
                End If

                If rbtn_no.Checked Then
                    unAni.idCondicionCastrado = 2
                End If

                If rbtn_NoSabe.Checked Then
                    unAni.idCondicionCastrado = 3
                End If

                ' Pasamos a la seccion de la informacion adicional y empezamos a completar los datos de
                ' la publicacion que se cargara a la BD
                publi.usuario = usuario
                publi.idBarrio = cmb_barrio.SelectedValue
                publi.nombreCiudad = txt_ciudad.Text
                publi.descripcionPublicacion = txt_descripcion.Text
                publi.animal = unAni
                publi.tipoPublicacion = accion_usuario

                If publi.usuario.getNumTelefono Is Nothing Then
                    usuario.setNumeroTelefono("")
                End If

                If txt_telefono_2.Text IsNot Nothing Then
                    publi.telefono2 = txt_telefono_2.Text
                End If

                ' Por ahora no mostramos confirmacion con los datos de la publicacion
                '  Solo un cartelito que diga estas seguro que deseas publicar. 

                Dim d As DialogResult
                d = MessageBox.Show("¿Desea continuar y realizar la publicacion?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If (d = DialogResult.OK) Then

                    ' PRUEBA DE CARGA, si es perro se carga mediante carga normal
                    If esPerro Then
                        ' Con todos los datos de la publicacion, la cargamos en la BD mediante la clase PublicacionService
                        ' Pasandole la publicacion como parametro.
                        ' Si la publicacion se cargo correctamente en la BD mostramos una ventana de confirmacion. 
                        If publiServicio.agregarPublicacionAdopcion(publi) = 1 Then
                            MessageBox.Show("La publicacion fue realizada con éxito", "Exito", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            Me.Close()
                        End If
                    Else
                        ' Si es gato vamos a probar cargandolo con transaccion
                        If publiServicio.publicarAdopcionTransaccion(publi) = 1 Then
                            MessageBox.Show("La publicacion fue realizada con éxito", "Exito", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            Me.Close()
                        End If
                    End If
                Else
                    Me.Close()
                End If

                'Si el usuario esta realizando una busqueda accion_usuario = TipoUsuario.busqueda
                'Se busca entre todas las publicaciones con los datos del animal proporcionado

            End If 'If de TipoAccionUsuario = TipoAccionUsuario.adopcion
        End If 'If de validarCampos()
    End Sub


End Class