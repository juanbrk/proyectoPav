<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteRazaPerro
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSRazaGato = New Hund_Tier.DSRazaGato()
        Me.DTRazaGatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRazaPerro = New Hund_Tier.DSRazaPerro()
        CType(Me.DSRazaGato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTRazaGatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRazaPerro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "TablaRazaPerro"
        ReportDataSource1.Value = Me.DTRazaGatoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_RazaPerro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(592, 347)
        Me.ReportViewer1.TabIndex = 0
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
        'DSRazaPerro
        '
        Me.DSRazaPerro.DataSetName = "DSRazaPerro"
        Me.DSRazaPerro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frm_ReporteRazaPerro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 371)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_ReporteRazaPerro"
        Me.Text = "Reporte de las razas de los perros"
        CType(Me.DSRazaGato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTRazaGatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRazaPerro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTRazaGatoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSRazaGato As Hund_Tier.DSRazaGato
    Friend WithEvents DSRazaPerro As Hund_Tier.DSRazaPerro
End Class
