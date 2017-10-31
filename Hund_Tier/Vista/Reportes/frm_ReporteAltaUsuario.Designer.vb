<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteAltaUsuario
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
        Me.ReporteUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS1 = New Hund_Tier.DS1()
        Me.rpt_animales = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        CType(Me.ReporteUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReporteUsuariosBindingSource
        '
        Me.ReporteUsuariosBindingSource.DataMember = "ReporteUsuarios"
        Me.ReporteUsuariosBindingSource.DataSource = Me.DS1
        '
        'DS1
        '
        Me.DS1.DataSetName = "DS1"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpt_animales
        '
        ReportDataSource1.Name = "TablaUsuariosAlta"
        ReportDataSource1.Value = Me.ReporteUsuariosBindingSource
        Me.rpt_animales.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt_animales.LocalReport.ReportEmbeddedResource = "Hund_Tier.ReporteUsuariosAlta.rdlc"
        Me.rpt_animales.Location = New System.Drawing.Point(16, 60)
        Me.rpt_animales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rpt_animales.Name = "rpt_animales"
        Me.rpt_animales.Size = New System.Drawing.Size(681, 361)
        Me.rpt_animales.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(337, 14)
        Me.mtxt_FechaHasta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxt_FechaHasta.Mask = "00/00/0000"
        Me.mtxt_FechaHasta.Name = "mtxt_FechaHasta"
        Me.mtxt_FechaHasta.Size = New System.Drawing.Size(100, 22)
        Me.mtxt_FechaHasta.TabIndex = 10
        Me.mtxt_FechaHasta.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(123, 14)
        Me.mtxt_fechaDesde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(100, 22)
        Me.mtxt_fechaDesde.TabIndex = 8
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(547, 14)
        Me.btn_generarReporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(107, 23)
        Me.btn_generarReporte.TabIndex = 7
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'frm_ReporteAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 437)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtxt_FechaHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxt_fechaDesde)
        Me.Controls.Add(Me.btn_generarReporte)
        Me.Controls.Add(Me.rpt_animales)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_ReporteAltaUsuario"
        Me.Text = "```"
        CType(Me.ReporteUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReporteUsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS1 As Hund_Tier.DS1
    Private WithEvents rpt_animales As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxt_FechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxt_fechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_generarReporte As System.Windows.Forms.Button
End Class
