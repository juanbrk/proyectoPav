Public Class frm_seleccionTipoReporte
    Private Sub tbn_reporteTipoAnimal_Click(sender As Object, e As EventArgs) Handles tbn_reporteTipoAnimal.Click
        Dim frm_reporteTipoAnimal As New frm_ReporteTipoAnimal
        frm_reporteTipoAnimal.ShowDialog()

    End Sub
End Class