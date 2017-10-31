<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteTipoAnimal
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
        Me.DTTipoAnimalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSTipoAnimal = New Hund_Tier.DSTipoAnimal()
        Me.RVTipoAnimal = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        CType(Me.DTTipoAnimalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTipoAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTTipoAnimalBindingSource
        '
        Me.DTTipoAnimalBindingSource.DataMember = "DTTipoAnimal"
        Me.DTTipoAnimalBindingSource.DataSource = Me.DSTipoAnimal
        '
        'DSTipoAnimal
        '
        Me.DSTipoAnimal.DataSetName = "DSTipoAnimal"
        Me.DSTipoAnimal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RVTipoAnimal
        '
        ReportDataSource1.Name = "TablaTipoAnimal"
        ReportDataSource1.Value = Me.DTTipoAnimalBindingSource
        Me.RVTipoAnimal.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVTipoAnimal.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_TipoAnimal.rdlc"
        Me.RVTipoAnimal.Location = New System.Drawing.Point(12, 58)
        Me.RVTipoAnimal.Name = "RVTipoAnimal"
        Me.RVTipoAnimal.Size = New System.Drawing.Size(629, 289)
        Me.RVTipoAnimal.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(252, 19)
        Me.mtxt_FechaHasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxt_FechaHasta.Mask = "00/00/0000"
        Me.mtxt_FechaHasta.Name = "mtxt_FechaHasta"
        Me.mtxt_FechaHasta.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_FechaHasta.TabIndex = 15
        Me.mtxt_FechaHasta.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(91, 19)
        Me.mtxt_fechaDesde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fechaDesde.TabIndex = 13
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(431, 20)
        Me.btn_generarReporte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(80, 19)
        Me.btn_generarReporte.TabIndex = 12
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'frm_ReporteTipoAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 359)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtxt_FechaHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxt_fechaDesde)
        Me.Controls.Add(Me.btn_generarReporte)
        Me.Controls.Add(Me.RVTipoAnimal)
        Me.Name = "frm_ReporteTipoAnimal"
        Me.Text = "Reporte del tipo de los animales"
        CType(Me.DTTipoAnimalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTipoAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTTipoAnimalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSTipoAnimal As Hund_Tier.DSTipoAnimal
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxt_FechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_fechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generarReporte As System.Windows.Forms.Button
    Private WithEvents RVTipoAnimal As Microsoft.Reporting.WinForms.ReportViewer
End Class
