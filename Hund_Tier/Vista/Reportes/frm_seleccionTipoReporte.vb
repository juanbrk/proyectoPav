Public Class frm_seleccionTipoReporte
    Private Sub tbn_reporteTipoAnimal_Click(sender As Object, e As EventArgs) Handles tbn_reporteTipoAnimal.Click
        Dim frm_reporteTipoAnimal As New frm_ReporteTipoAnimal
        frm_reporteTipoAnimal.ShowDialog()

    End Sub

    Private Sub btn_altaUsuarios_Click(sender As Object, e As EventArgs) Handles btn_altaUsuarios.Click
        Dim formReporteUsuarios As New frm_ReporteAltaUsuario
        formReporteUsuarios.ShowDialog()
    End Sub

    Private Sub btn_reporteTipoPublicacion_Click(sender As Object, e As EventArgs) Handles btn_reporteTipoPublicacion.Click

    End Sub

    Private Sub btn_reporteMayorRazasPerro_Click(sender As Object, e As EventArgs) Handles btn_reporteMayorRazasPerro.Click
        Dim formReporteRazasPerro As New frm_ReporteRazaPerro
        formReporteRazasPerro.ShowDialog()

    End Sub

    Private Sub btn_reporteMayorRazasGato_Click(sender As Object, e As EventArgs) Handles btn_reporteMayorRazasGato.Click
        Dim formReporteRazasGatos As New frm_ReporteRazaGato
        formReporteRazasGatos.ShowDialog()

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Dim d As DialogResult
        d = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If d = DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class