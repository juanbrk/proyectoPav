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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_reporteMayorRazasGato = New System.Windows.Forms.Button()
        Me.btn_reporteMayorRazasPerro = New System.Windows.Forms.Button()
        Me.btn_reporteAnimalXTipoPublicacion = New System.Windows.Forms.Button()
        Me.btn_reporteMayorUsuarioPublicaciones = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_reporteAnimalXTipoPublicacion)
        Me.GroupBox1.Controls.Add(Me.btn_reporteTipoPublicacion)
        Me.GroupBox1.Controls.Add(Me.tbn_reporteTipoAnimal)
        Me.GroupBox1.Controls.Add(Me.btn_altaUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes entre fechas"
        '
        'btn_reporteTipoPublicacion
        '
        Me.btn_reporteTipoPublicacion.Location = New System.Drawing.Point(6, 76)
        Me.btn_reporteTipoPublicacion.Name = "btn_reporteTipoPublicacion"
        Me.btn_reporteTipoPublicacion.Size = New System.Drawing.Size(248, 23)
        Me.btn_reporteTipoPublicacion.TabIndex = 2
        Me.btn_reporteTipoPublicacion.Text = "Busquedas por tipo de publicacion"
        Me.btn_reporteTipoPublicacion.UseVisualStyleBackColor = True
        '
        'tbn_reporteTipoAnimal
        '
        Me.tbn_reporteTipoAnimal.Location = New System.Drawing.Point(6, 47)
        Me.tbn_reporteTipoAnimal.Name = "tbn_reporteTipoAnimal"
        Me.tbn_reporteTipoAnimal.Size = New System.Drawing.Size(248, 23)
        Me.tbn_reporteTipoAnimal.TabIndex = 1
        Me.tbn_reporteTipoAnimal.Text = "Busquedas por tipo de animal"
        Me.tbn_reporteTipoAnimal.UseVisualStyleBackColor = True
        '
        'btn_altaUsuarios
        '
        Me.btn_altaUsuarios.Location = New System.Drawing.Point(6, 19)
        Me.btn_altaUsuarios.Name = "btn_altaUsuarios"
        Me.btn_altaUsuarios.Size = New System.Drawing.Size(248, 23)
        Me.btn_altaUsuarios.TabIndex = 0
        Me.btn_altaUsuarios.Text = "Nuevos usuarios de la aplicacion"
        Me.btn_altaUsuarios.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_reporteMayorUsuarioPublicaciones)
        Me.GroupBox2.Controls.Add(Me.btn_reporteMayorRazasGato)
        Me.GroupBox2.Controls.Add(Me.btn_reporteMayorRazasPerro)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 102)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes por frecuencia"
        '
        'btn_reporteMayorRazasGato
        '
        Me.btn_reporteMayorRazasGato.Location = New System.Drawing.Point(35, 47)
        Me.btn_reporteMayorRazasGato.Name = "btn_reporteMayorRazasGato"
        Me.btn_reporteMayorRazasGato.Size = New System.Drawing.Size(191, 23)
        Me.btn_reporteMayorRazasGato.TabIndex = 1
        Me.btn_reporteMayorRazasGato.Text = "Razas de gato mas buscadas"
        Me.btn_reporteMayorRazasGato.UseVisualStyleBackColor = True
        '
        'btn_reporteMayorRazasPerro
        '
        Me.btn_reporteMayorRazasPerro.Location = New System.Drawing.Point(34, 19)
        Me.btn_reporteMayorRazasPerro.Name = "btn_reporteMayorRazasPerro"
        Me.btn_reporteMayorRazasPerro.Size = New System.Drawing.Size(191, 23)
        Me.btn_reporteMayorRazasPerro.TabIndex = 0
        Me.btn_reporteMayorRazasPerro.Text = "Razas de perros mas buscadas"
        Me.btn_reporteMayorRazasPerro.UseVisualStyleBackColor = True
        '
        'btn_reporteAnimalXTipoPublicacion
        '
        Me.btn_reporteAnimalXTipoPublicacion.Location = New System.Drawing.Point(6, 105)
        Me.btn_reporteAnimalXTipoPublicacion.Name = "btn_reporteAnimalXTipoPublicacion"
        Me.btn_reporteAnimalXTipoPublicacion.Size = New System.Drawing.Size(248, 23)
        Me.btn_reporteAnimalXTipoPublicacion.TabIndex = 3
        Me.btn_reporteAnimalXTipoPublicacion.Text = "Tipos de animal por tipo de publicacion"
        Me.btn_reporteAnimalXTipoPublicacion.UseVisualStyleBackColor = True
        '
        'btn_reporteMayorUsuarioPublicaciones
        '
        Me.btn_reporteMayorUsuarioPublicaciones.Location = New System.Drawing.Point(34, 73)
        Me.btn_reporteMayorUsuarioPublicaciones.Name = "btn_reporteMayorUsuarioPublicaciones"
        Me.btn_reporteMayorUsuarioPublicaciones.Size = New System.Drawing.Size(191, 23)
        Me.btn_reporteMayorUsuarioPublicaciones.TabIndex = 2
        Me.btn_reporteMayorUsuarioPublicaciones.Text = "Usuarios con mas publicaciones"
        Me.btn_reporteMayorUsuarioPublicaciones.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(197, 275)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_seleccionTipoReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 307)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_seleccionTipoReporte"
        Me.Text = "Seleccionar tipon de reporte a generar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_reporteTipoPublicacion As Button
    Friend WithEvents tbn_reporteTipoAnimal As Button
    Friend WithEvents btn_altaUsuarios As Button
    Friend WithEvents btn_reporteAnimalXTipoPublicacion As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_reporteMayorUsuarioPublicaciones As Button
    Friend WithEvents btn_reporteMayorRazasGato As Button
    Friend WithEvents btn_reporteMayorRazasPerro As Button
    Friend WithEvents btn_cancelar As Button
End Class
