<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteUsuarioNrPublicacion
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
        Me.DTUsuarioNrPublicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUsuarioNrPublicacion = New Hund_Tier.DSUsuarioNrPublicacion()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        Me.RVUsuarioNrPublicacion = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DTUsuarioNrPublicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUsuarioNrPublicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTUsuarioNrPublicacionBindingSource
        '
        Me.DTUsuarioNrPublicacionBindingSource.DataMember = "DTUsuarioNrPublicacion"
        Me.DTUsuarioNrPublicacionBindingSource.DataSource = Me.DSUsuarioNrPublicacion
        '
        'DSUsuarioNrPublicacion
        '
        Me.DSUsuarioNrPublicacion.DataSetName = "DSUsuarioNrPublicacion"
        Me.DSUsuarioNrPublicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(257, 20)
        Me.mtxt_FechaHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxt_FechaHasta.Mask = "00/00/0000"
        Me.mtxt_FechaHasta.Name = "mtxt_FechaHasta"
        Me.mtxt_FechaHasta.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_FechaHasta.TabIndex = 15
        Me.mtxt_FechaHasta.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(96, 20)
        Me.mtxt_fechaDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fechaDesde.TabIndex = 13
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generarReporte.Location = New System.Drawing.Point(436, 21)
        Me.btn_generarReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(80, 19)
        Me.btn_generarReporte.TabIndex = 12
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'RVUsuarioNrPublicacion
        '
        Me.RVUsuarioNrPublicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DSUsuarioNrPublicacion"
        ReportDataSource1.Value = Me.DTUsuarioNrPublicacionBindingSource
        Me.RVUsuarioNrPublicacion.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVUsuarioNrPublicacion.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_UsuarioNrPublicacion.rdlc"
        Me.RVUsuarioNrPublicacion.Location = New System.Drawing.Point(12, 45)
        Me.RVUsuarioNrPublicacion.Name = "RVUsuarioNrPublicacion"
        Me.RVUsuarioNrPublicacion.Size = New System.Drawing.Size(635, 296)
        Me.RVUsuarioNrPublicacion.TabIndex = 17
        '
        'frm_ReporteUsuarioNrPublicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 355)
        Me.Controls.Add(Me.RVUsuarioNrPublicacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtxt_FechaHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxt_fechaDesde)
        Me.Controls.Add(Me.btn_generarReporte)
        Me.MaximumSize = New System.Drawing.Size(800, 394)
        Me.MinimumSize = New System.Drawing.Size(674, 394)
        Me.Name = "frm_ReporteUsuarioNrPublicacion"
        Me.Text = "Reporte de la cantidad de reportes por usuario"
        CType(Me.DTUsuarioNrPublicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUsuarioNrPublicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxt_FechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_fechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generarReporte As System.Windows.Forms.Button
    Friend WithEvents RVUsuarioNrPublicacion As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTUsuarioNrPublicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSUsuarioNrPublicacion As Hund_Tier.DSUsuarioNrPublicacion
End Class
