Public Class frm_ReporteRazaPerro

    Private Sub frm_ReporteRazaPerro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RVRazaPerro.RefreshReport()
    End Sub

    Private Sub btn_generarReporte_Click(sender As Object, e As EventArgs) Handles btn_generarReporte.Click
        Dim oUsuariosService As New UsuariosService
        If IsDate(mtxt_fechaDesde.Text) And IsDate((mtxt_FechaHasta.Text)) Then
            Dim fechaDesde As DateTime = DateTime.ParseExact(mtxt_fechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformatedDesde As String = fechaDesde.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            Dim fechaHasta As DateTime = DateTime.ParseExact(mtxt_FechaHasta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformattedHasta As String = fechaHasta.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            RVRazaPerro.LocalReport.SetParameters({New ReportParameter("pFechaDesde", mtxt_fechaDesde.Text), New ReportParameter("pFechaHasta", mtxt_FechaHasta.Text)})
            RVRazaPerro.LocalReport.DataSources.Clear()
            RVRazaPerro.LocalReport.DataSources.Add(New ReportDataSource("TablaRazaPerro", oUsuariosService.generarReporteAltaUsuario(reformatedDesde, reformattedHasta)))
            RVRazaPerro.RefreshReport()
        Else
            MsgBox("Periodo incorrecto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class