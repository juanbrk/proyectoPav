<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteRazaGato
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RVRazaGato = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSRazaGato = New Hund_Tier.DSRazaGato()
        Me.DTRazaGatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DSRazaGato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTRazaGatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RVRazaGato
        '
        ReportDataSource1.Name = "TablaRazaGato"
        ReportDataSource1.Value = Me.DTRazaGatoBindingSource
        Me.RVRazaGato.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVRazaGato.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_RazaGato.rdlc"
        Me.RVRazaGato.Location = New System.Drawing.Point(12, 12)
        Me.RVRazaGato.Name = "RVRazaGato"
        Me.RVRazaGato.Size = New System.Drawing.Size(569, 349)
        Me.RVRazaGato.TabIndex = 0
        '
        'DSRazaGato
        '
        Me.DSRazaGato.DataSetName = "DSRazaGato"
        Me.DSRazaGato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTRazaGatoBindingSource
        '
        Me.DTRazaGatoBindingSource.DataMember = "DTRazaGato"
        Me.DTRazaGatoBindingSource.DataSource = Me.DSRazaGato
        '
        'frm_ReporteRazaGato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 373)
        Me.Controls.Add(Me.RVRazaGato)
        Me.Name = "frm_ReporteRazaGato"
        Me.Text = "Reporte de la raza de los gatos"
        CType(Me.DSRazaGato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTRazaGatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RVRazaGato As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTRazaGatoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSRazaGato As Hund_Tier.DSRazaGato
End Class
