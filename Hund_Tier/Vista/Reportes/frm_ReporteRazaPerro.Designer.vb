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
        Me.DTRazaGatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRazaGato = New Hund_Tier.DSRazaGato()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSRazaPerro = New Hund_Tier.DSRazaPerro()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.mtxt_fechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        CType(Me.DTRazaGatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRazaGato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRazaPerro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTRazaGatoBindingSource
        '
        Me.DTRazaGatoBindingSource.DataMember = "DTRazaGato"
        Me.DTRazaGatoBindingSource.DataSource = Me.DSRazaGato
        '
        'DSRazaGato
        '
        Me.DSRazaGato.DataSetName = "DSRazaGato"
        Me.DSRazaGato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "TablaRazaPerro"
        ReportDataSource1.Value = Me.DTRazaGatoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_RazaPerro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 15)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(789, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSRazaPerro
        '
        Me.DSRazaPerro.DataSetName = "DSRazaPerro"
        Me.DSRazaPerro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccionar fechas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(203, 471)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(117, 22)
        Me.mtxt_fechaDesde.TabIndex = 3
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'mtxt_fechaHasta
        '
        Me.mtxt_fechaHasta.Location = New System.Drawing.Point(403, 471)
        Me.mtxt_fechaHasta.Mask = "00/00/0000"
        Me.mtxt_fechaHasta.Name = "mtxt_fechaHasta"
        Me.mtxt_fechaHasta.Size = New System.Drawing.Size(117, 22)
        Me.mtxt_fechaHasta.TabIndex = 5
        Me.mtxt_fechaHasta.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 471)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasta:"
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(565, 468)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(75, 23)
        Me.btn_generarReporte.TabIndex = 6
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'frm_ReporteRazaPerro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 505)
        Me.Controls.Add(Me.btn_generarReporte)
        Me.Controls.Add(Me.mtxt_fechaHasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mtxt_fechaDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_ReporteRazaPerro"
        Me.Text = "Reporte de las razas de los perros"
        CType(Me.DTRazaGatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRazaGato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRazaPerro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTRazaGatoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSRazaGato As Hund_Tier.DSRazaGato
    Friend WithEvents DSRazaPerro As Hund_Tier.DSRazaPerro
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxt_fechaDesde As MaskedTextBox
    Friend WithEvents mtxt_fechaHasta As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_generarReporte As Button
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
