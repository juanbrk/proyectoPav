Imports Microsoft.Reporting.WinForms
Imports System.Globalization

Public Class frm_ReporteUsuarioNrPublicacion

    Private Sub frm_ReporteUsuarioNrPublicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RVUsuarioNrPublicacion.RefreshReport()
    End Sub

    Private Sub btn_generarReporte_Click(sender As Object, e As EventArgs) Handles btn_generarReporte.Click
        Dim oPublicacionService As New PublicacionService
        If IsDate(mtxt_fechaDesde.Text) And IsDate((mtxt_FechaHasta.Text)) Then
            Dim fechaDesde As DateTime = DateTime.ParseExact(mtxt_fechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformatedDesde As String = fechaDesde.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            Dim fechaHasta As DateTime = DateTime.ParseExact(mtxt_FechaHasta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformattedHasta As String = fechaHasta.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            RVUsuarioNrPublicacion.LocalReport.DataSources.Clear()
            RVUsuarioNrPublicacion.LocalReport.SetParameters({New ReportParameter("pFechaDesde", mtxt_fechaDesde.Text), New ReportParameter("pFechaHasta", mtxt_FechaHasta.Text)})
            RVUsuarioNrPublicacion.LocalReport.DataSources.Add(New ReportDataSource("DSUsuarioNrPublicacion", oPublicacionService.generarReporteUsuariosPublicaciones(reformatedDesde, reformattedHasta)))
            RVUsuarioNrPublicacion.RefreshReport()
        Else
            MsgBox("Periodo incorrecto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class