Public Class frm_seleccion_tipo_aviso

    'Cuando se hace click sobre el boton para publicar un aviso sobre la adopcion de un perro se
    'muestra el form de avisos
    Public Enum mostrarSiguienteFormPara As Integer
        publicarAviso
        buscarAnimal
    End Enum

    'Esta variable determinará cual sera a la siguiente form, si para publicar aviso o para
    'buscar animales. Es una bandera
    Dim elUsuarioVaA = mostrarSiguienteFormPara.publicarAviso


    Public Sub setEleccionUsuario(valor As mostrarSiguienteFormPara)
        elUsuarioVaA = valor
    End Sub

    'Cuando se hace click sobre el boton adopcion de perro pueden pasar dos cosas, que se este
    'tratando de hacer una nueva publicacion de un perro en adopcion o que se este buscando algun
    'perro que este en adopcion con las caracteristicas deseadas. 
    Private Sub btn_adopcion_perro_Click(sender As Object, e As EventArgs) Handles btn_adopcion_perro.Click
        ' Abrimos la ventana frm_publicarAviso con los datos cargados para publicar una adopcion de perro
        nuevaPublicacion(frm_publicar_aviso.TipoAnimal.perro, frm_publicar_aviso.AccionUsuario.adopcion)
        Me.Close()

    End Sub

    Private Sub btn_adopcion_gato_Click(sender As Object, e As EventArgs) Handles btn_adopcion_gato.Click
        'Abrimos la ventana frm_publicarAviso con los datos cargados para publicar una adopcion de gato
        nuevaPublicacion(frm_publicar_aviso.TipoAnimal.gato, frm_publicar_aviso.AccionUsuario.adopcion)
        Me.Close()
    End Sub

    Private Sub btn_perdido_perro_Click(sender As Object, e As EventArgs) Handles btn_perdido_perro.Click
        'Abrimos la ventana frm_publicarAviso con los datos cargados para publicar una perdida de perro
        nuevaPublicacion(frm_publicar_aviso.TipoAnimal.perro, frm_publicar_aviso.AccionUsuario.perdido)
    End Sub

    Private Sub btn_perdido_gato_Click(sender As Object, e As EventArgs) Handles btn_perdido_gato.Click
        'Abrimos la ventana frm_publicarAviso con los datos cargados para publicar una perdida de gato
        nuevaPublicacion(frm_publicar_aviso.TipoAnimal.gato, frm_publicar_aviso.AccionUsuario.perdido)
    End Sub

    Private Sub nuevaPublicacion(tipoAnimal As frm_publicar_aviso.TipoAnimal, tipoPublicacion As frm_publicar_aviso.AccionUsuario)
        Dim datosPublicacion_form As New frm_publicar_aviso
        ' Le seteamos el tipo de animal con el que trabajaremos
        datosPublicacion_form.setTipoAnimal(tipoAnimal)

        ' Chequeamos para ver como se mostrara la ventana de publicarAviso, puede mostrarse
        'para publicar un nuevo aviso o para hacer busqueda de animales que cumplan con ciertos
        'criterios
        'este atributo se setea cuando se hace click desde frm_main en publicar aviso

        If elUsuarioVaA = mostrarSiguienteFormPara.publicarAviso Then
            ' Le cambiamos el titulo a la form por el que sea apropiado para cada caso
            Dim strTituloTipoPublicacion = ""
            ' Segun el tipo de publicacion que hayamos entrado como parametro le cambiamos el titulo a la form siguiente
            If tipoPublicacion = frm_publicar_aviso.AccionUsuario.adopcion Then
                strTituloTipoPublicacion = "en adopcion"
            End If
            If tipoPublicacion = frm_publicar_aviso.AccionUsuario.encontrado Then
                strTituloTipoPublicacion = "encontrado"
            End If
            If tipoPublicacion = frm_publicar_aviso.AccionUsuario.perdido Then
                strTituloTipoPublicacion = "perdido"
            End If
            datosPublicacion_form.setTitulo("Publicar animal " & strTituloTipoPublicacion)

            ' Le pasamos a la form el tipo de publicacion de que se trata, 1 = adopcion, 2= perdido, 3=encontrado
            datosPublicacion_form.setTipoPublicacion(tipoPublicacion)
            datosPublicacion_form.ShowDialog()

            'Si el usuario busca un animal, se hacen otras cosas.
        Else
            Dim buscarAnimalForm As New frm_listarPublicaciones
            buscarAnimalForm.ShowDialog()
        End If
    End Sub


End Class