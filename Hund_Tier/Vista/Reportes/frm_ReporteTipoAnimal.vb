Imports System.Globalization
Imports Microsoft.Reporting.WinForms

Public Class frm_ReporteTipoAnimal

    Private Sub frm_ReporteTipoAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RVTipoAnimal.RefreshReport()
    End Sub

    Private Sub btn_generarReporte_Click(sender As Object, e As EventArgs) Handles btn_generarReporte.Click
        Dim oUsuariosService As New UsuariosService
        If IsDate(mtxt_fechaDesde.Text) And IsDate((mtxt_FechaHasta.Text)) Then
            Dim fechaDesde As DateTime = DateTime.ParseExact(mtxt_fechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformatedDesde As String = fechaDesde.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            Dim fechaHasta As DateTime = DateTime.ParseExact(mtxt_FechaHasta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformattedHasta As String = fechaHasta.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            RVTipoAnimal.LocalReport.SetParameters({New ReportParameter("pFechaDesde", mtxt_fechaDesde.Text), New ReportParameter("pFechaHasta", mtxt_FechaHasta.Text)})
            RVTipoAnimal.LocalReport.DataSources.Clear()
            RVTipoAnimal.LocalReport.DataSources.Add(New ReportDataSource("TablaRazaPerro", oUsuariosService.generarReporteAltaUsuario(reformatedDesde, reformattedHasta)))
            RVTipoAnimal.RefreshReport()
        Else
            MsgBox("Periodo incorrecto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class