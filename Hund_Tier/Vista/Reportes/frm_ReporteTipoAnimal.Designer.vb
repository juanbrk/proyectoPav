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
        Me.RVTipoAnimal = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSTipoAnimal = New Hund_Tier.DSTipoAnimal()
        Me.DTTipoAnimalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DSTipoAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTTipoAnimalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RVTipoAnimal
        '
        ReportDataSource1.Name = "TablaTipoAnimal"
        ReportDataSource1.Value = Me.DTTipoAnimalBindingSource
        Me.RVTipoAnimal.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RVTipoAnimal.LocalReport.ReportEmbeddedResource = "Hund_Tier.Reporte_TipoAnimal.rdlc"
        Me.RVTipoAnimal.Location = New System.Drawing.Point(12, 12)
        Me.RVTipoAnimal.Name = "RVTipoAnimal"
        Me.RVTipoAnimal.Size = New System.Drawing.Size(541, 335)
        Me.RVTipoAnimal.TabIndex = 0
        '
        'DSTipoAnimal
        '
        Me.DSTipoAnimal.DataSetName = "DSTipoAnimal"
        Me.DSTipoAnimal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTTipoAnimalBindingSource
        '
        Me.DTTipoAnimalBindingSource.DataMember = "DTTipoAnimal"
        Me.DTTipoAnimalBindingSource.DataSource = Me.DSTipoAnimal
        '
        'frm_ReporteTipoAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 359)
        Me.Controls.Add(Me.RVTipoAnimal)
        Me.Name = "frm_ReporteTipoAnimal"
        Me.Text = "Reporte del tipo de los animales"
        CType(Me.DSTipoAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTTipoAnimalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RVTipoAnimal As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTTipoAnimalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSTipoAnimal As Hund_Tier.DSTipoAnimal
End Class
