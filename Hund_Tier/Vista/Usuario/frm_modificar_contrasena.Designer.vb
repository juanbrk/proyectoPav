<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modificar_contrasena
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
        Me.lbl_pass_actual = New System.Windows.Forms.Label()
        Me.txt_pass_actual = New System.Windows.Forms.TextBox()
        Me.txt_nueva_pass = New System.Windows.Forms.TextBox()
        Me.lbl_nueva_pass = New System.Windows.Forms.Label()
        Me.txt_confirmar_pass = New System.Windows.Forms.TextBox()
        Me.lbl_confirmar_nueva_pass = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_pass_actual
        '
        Me.lbl_pass_actual.AutoSize = True
        Me.lbl_pass_actual.Location = New System.Drawing.Point(17, 16)
        Me.lbl_pass_actual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pass_actual.Name = "lbl_pass_actual"
        Me.lbl_pass_actual.Size = New System.Drawing.Size(123, 17)
        Me.lbl_pass_actual.TabIndex = 0
        Me.lbl_pass_actual.Text = "Contraseña actual"
        '
        'txt_pass_actual
        '
        Me.txt_pass_actual.Location = New System.Drawing.Point(149, 12)
        Me.txt_pass_actual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pass_actual.Name = "txt_pass_actual"
        Me.txt_pass_actual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass_actual.Size = New System.Drawing.Size(212, 22)
        Me.txt_pass_actual.TabIndex = 1
        '
        'txt_nueva_pass
        '
        Me.txt_nueva_pass.Location = New System.Drawing.Point(149, 44)
        Me.txt_nueva_pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nueva_pass.Name = "txt_nueva_pass"
        Me.txt_nueva_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nueva_pass.Size = New System.Drawing.Size(212, 22)
        Me.txt_nueva_pass.TabIndex = 3
        '
        'lbl_nueva_pass
        '
        Me.lbl_nueva_pass.AutoSize = True
        Me.lbl_nueva_pass.Location = New System.Drawing.Point(17, 48)
        Me.lbl_nueva_pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nueva_pass.Name = "lbl_nueva_pass"
        Me.lbl_nueva_pass.Size = New System.Drawing.Size(124, 17)
        Me.lbl_nueva_pass.TabIndex = 2
        Me.lbl_nueva_pass.Text = "Nueva contraseña"
        '
        'txt_confirmar_pass
        '
        Me.txt_confirmar_pass.Location = New System.Drawing.Point(149, 76)
        Me.txt_confirmar_pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_confirmar_pass.Name = "txt_confirmar_pass"
        Me.txt_confirmar_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_pass.Size = New System.Drawing.Size(212, 22)
        Me.txt_confirmar_pass.TabIndex = 5
        '
        'lbl_confirmar_nueva_pass
        '
        Me.lbl_confirmar_nueva_pass.AutoSize = True
        Me.lbl_confirmar_nueva_pass.Location = New System.Drawing.Point(1, 80)
        Me.lbl_confirmar_nueva_pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_confirmar_nueva_pass.Name = "lbl_confirmar_nueva_pass"
        Me.lbl_confirmar_nueva_pass.Size = New System.Drawing.Size(144, 17)
        Me.lbl_confirmar_nueva_pass.TabIndex = 4
        Me.lbl_confirmar_nueva_pass.Text = "Confirmar contraseña"
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(263, 110)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(100, 28)
        Me.btn_modificar.TabIndex = 6
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(155, 110)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 28)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_modificar_contrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 151)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.txt_confirmar_pass)
        Me.Controls.Add(Me.lbl_confirmar_nueva_pass)
        Me.Controls.Add(Me.txt_nueva_pass)
        Me.Controls.Add(Me.lbl_nueva_pass)
        Me.Controls.Add(Me.txt_pass_actual)
        Me.Controls.Add(Me.lbl_pass_actual)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(397, 198)
        Me.Name = "frm_modificar_contrasena"
        Me.Text = "Modificar contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_pass_actual As Label
    Friend WithEvents txt_pass_actual As TextBox
    Friend WithEvents txt_nueva_pass As TextBox
    Friend WithEvents lbl_nueva_pass As Label
    Friend WithEvents txt_confirmar_pass As TextBox
    Friend WithEvents lbl_confirmar_nueva_pass As Label
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_cancelar As Button
End Class
