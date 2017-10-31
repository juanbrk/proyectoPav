<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteTipoPublicacion
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
        Me.DTTipoPublicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSTipoPublicacion = New Hund_Tier.DSTipoPublicacion()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        Me.RVTipoPublicacion = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DTTipoPublicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTipoPublicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTTipoPublicacionBindingSource
        '
        Me.DTTipoPublicacionBindingSource.DataMember = "DTTipoPublicacion"
        Me.DTTipoPublicacionBindingSource.DataSource = Me.DSTipoPublicacion
        '
        'DSTipoPublicacion
        '
        Me.DSTipoPublicacion.DataSetName = "DSTipoPublicacion"
        Me.DSTipoPublicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(253, 6)
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
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(92, 6)
        Me.mtxt_fechaDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fechaDesde.TabIndex = 13
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(432, 7)
        Me.btn_generarReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(80, 19)
        Me.btn_generarReporte.TabIndex = 12
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'RVTipoPublicacion
        '
        ReportDataSource1.Name = "DSTipoPublicacion"
        ReportDataSource1.Value = Me.DTTipoPublicacionBindingSource
        Me.RVTipoPublicacion.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVTipoPublicacion.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_TipoPublicacion.rdlc"
        Me.RVTipoPublicacion.Location = New System.Drawing.Point(12, 42)
        Me.RVTipoPublicacion.Name = "RVTipoPublicacion"
        Me.RVTipoPublicacion.Size = New System.Drawing.Size(601, 297)
        Me.RVTipoPublicacion.TabIndex = 17
        '
        'frm_ReporteTipoPublicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 351)
        Me.Controls.Add(Me.RVTipoPublicacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtxt_FechaHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxt_fechaDesde)
        Me.Controls.Add(Me.btn_generarReporte)
        Me.Name = "frm_ReporteTipoPublicacion"
        Me.Text = "Reporte del Tipo de las Publicaciones"
        CType(Me.DTTipoPublicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTipoPublicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxt_FechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_fechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generarReporte As System.Windows.Forms.Button
    Friend WithEvents RVTipoPublicacion As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTTipoPublicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSTipoPublicacion As Hund_Tier.DSTipoPublicacion
End Class
