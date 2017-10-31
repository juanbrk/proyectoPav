<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteCantidadPorPublicacion
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
        Me.DTCantidadPorPublicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCantidadPorPublicacion = New Hund_Tier.DSCantidadPorPublicacion()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        Me.RVCantidadPorPublicacion = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DTCantidadPorPublicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCantidadPorPublicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTCantidadPorPublicacionBindingSource
        '
        Me.DTCantidadPorPublicacionBindingSource.DataMember = "DTCantidadPorPublicacion"
        Me.DTCantidadPorPublicacionBindingSource.DataSource = Me.DSCantidadPorPublicacion
        '
        'DSCantidadPorPublicacion
        '
        Me.DSCantidadPorPublicacion.DataSetName = "DSCantidadPorPublicacion"
        Me.DSCantidadPorPublicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(252, 6)
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
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(91, 6)
        Me.mtxt_fechaDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fechaDesde.TabIndex = 13
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(431, 7)
        Me.btn_generarReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(80, 19)
        Me.btn_generarReporte.TabIndex = 12
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'RVCantidadPorPublicacion
        '
        ReportDataSource1.Name = "DSCantidadPorPublicacion"
        ReportDataSource1.Value = Me.DTCantidadPorPublicacionBindingSource
        Me.RVCantidadPorPublicacion.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVCantidadPorPublicacion.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_CantidadPorPulicacion.rdlc"
        Me.RVCantidadPorPublicacion.Location = New System.Drawing.Point(12, 41)
        Me.RVCantidadPorPublicacion.Name = "RVCantidadPorPublicacion"
        Me.RVCantidadPorPublicacion.Size = New System.Drawing.Size(638, 298)
        Me.RVCantidadPorPublicacion.TabIndex = 17
        '
        'frm_ReporteCantidadPorPublicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 351)
        Me.Controls.Add(Me.RVCantidadPorPublicacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtxt_FechaHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxt_fechaDesde)
        Me.Controls.Add(Me.btn_generarReporte)
        Me.Name = "frm_ReporteCantidadPorPublicacion"
        Me.Text = "Reporte de la cantidad de los tipos de publicaciones"
        CType(Me.DTCantidadPorPublicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCantidadPorPublicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxt_FechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_fechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generarReporte As System.Windows.Forms.Button
    Friend WithEvents RVCantidadPorPublicacion As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTCantidadPorPublicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSCantidadPorPublicacion As Hund_Tier.DSCantidadPorPublicacion
End Class
