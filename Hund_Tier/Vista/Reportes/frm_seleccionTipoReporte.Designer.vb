<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_seleccionTipoReporte
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_reporteTipoPublicacion = New System.Windows.Forms.Button()
        Me.tbn_reporteTipoAnimal = New System.Windows.Forms.Button()
        Me.btn_altaUsuarios = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_reporteTipoPublicacion)
        Me.GroupBox1.Controls.Add(Me.tbn_reporteTipoAnimal)
        Me.GroupBox1.Controls.Add(Me.btn_altaUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes entre fechas"
        '
        'btn_reporteTipoPublicacion
        '
        Me.btn_reporteTipoPublicacion.Location = New System.Drawing.Point(35, 76)
        Me.btn_reporteTipoPublicacion.Name = "btn_reporteTipoPublicacion"
        Me.btn_reporteTipoPublicacion.Size = New System.Drawing.Size(191, 23)
        Me.btn_reporteTipoPublicacion.TabIndex = 2
        Me.btn_reporteTipoPublicacion.Text = "Busquedas por tipo de publicacion"
        Me.btn_reporteTipoPublicacion.UseVisualStyleBackColor = True
        '
        'tbn_reporteTipoAnimal
        '
        Me.tbn_reporteTipoAnimal.Location = New System.Drawing.Point(35, 47)
        Me.tbn_reporteTipoAnimal.Name = "tbn_reporteTipoAnimal"
        Me.tbn_reporteTipoAnimal.Size = New System.Drawing.Size(191, 23)
        Me.tbn_reporteTipoAnimal.TabIndex = 1
        Me.tbn_reporteTipoAnimal.Text = "Busquedas por tipo de animal"
        Me.tbn_reporteTipoAnimal.UseVisualStyleBackColor = True
        '
        'btn_altaUsuarios
        '
        Me.btn_altaUsuarios.Location = New System.Drawing.Point(34, 19)
        Me.btn_altaUsuarios.Name = "btn_altaUsuarios"
        Me.btn_altaUsuarios.Size = New System.Drawing.Size(191, 23)
        Me.btn_altaUsuarios.TabIndex = 0
        Me.btn_altaUsuarios.Text = "Nuevos usuarios de la aplicacion"
        Me.btn_altaUsuarios.UseVisualStyleBackColor = True
        '
        'frm_seleccionTipoReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_seleccionTipoReporte"
        Me.Text = "Seleccionar tipon de reporte a generar"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_reporteTipoPublicacion As Button
    Friend WithEvents tbn_reporteTipoAnimal As Button
    Friend WithEvents btn_altaUsuarios As Button
End Class
