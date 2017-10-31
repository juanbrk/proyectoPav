<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarPublicaciones
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
        Me.dgv_publicaciones = New System.Windows.Forms.DataGridView()
        Me.col_idPublicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edadAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_peloAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sexoAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtn_NoSabe = New System.Windows.Forms.RadioButton()
        Me.cmb_color2 = New System.Windows.Forms.ComboBox()
        Me.cmb_color1 = New System.Windows.Forms.ComboBox()
        Me.rbtn_no = New System.Windows.Forms.RadioButton()
        Me.rb_si = New System.Windows.Forms.RadioButton()
        Me.lbl_castrado = New System.Windows.Forms.Label()
        Me.lbl_color_2 = New System.Windows.Forms.Label()
        Me.lbl_color_1 = New System.Windows.Forms.Label()
        Me.cmb_pelo = New System.Windows.Forms.ComboBox()
        Me.lbl_pelo = New System.Windows.Forms.Label()
        Me.cmb_edad = New System.Windows.Forms.ComboBox()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.cmb_tamano = New System.Windows.Forms.ComboBox()
        Me.lbl_tamano = New System.Windows.Forms.Label()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.lbl_sexo_animal = New System.Windows.Forms.Label()
        Me.cmb_raza = New System.Windows.Forms.ComboBox()
        Me.lbl_raza = New System.Windows.Forms.Label()
        Me.txt_nombre_animal = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_animal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        CType(Me.dgv_publicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_publicaciones
        '
        Me.dgv_publicaciones.AllowUserToAddRows = False
        Me.dgv_publicaciones.AllowUserToDeleteRows = False
        Me.dgv_publicaciones.AllowUserToOrderColumns = True
        Me.dgv_publicaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_publicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_publicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_publicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idPublicacion, Me.col_nombreAnimal, Me.col_raza, Me.col_tipoAnimal, Me.col_edadAnimal, Me.col_peloAnimal, Me.col_sexoAnimal, Me.col_barrio, Me.col_ciudad, Me.col_nombreResponsable})
        Me.dgv_publicaciones.Location = New System.Drawing.Point(16, 182)
        Me.dgv_publicaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_publicaciones.Name = "dgv_publicaciones"
        Me.dgv_publicaciones.ReadOnly = True
        Me.dgv_publicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_publicaciones.Size = New System.Drawing.Size(1232, 166)
        Me.dgv_publicaciones.TabIndex = 0
        '
        'col_idPublicacion
        '
        Me.col_idPublicacion.HeaderText = "# Publicacion"
        Me.col_idPublicacion.Name = "col_idPublicacion"
        Me.col_idPublicacion.ReadOnly = True
        '
        'col_nombreAnimal
        '
        Me.col_nombreAnimal.HeaderText = "Nombre"
        Me.col_nombreAnimal.Name = "col_nombreAnimal"
        Me.col_nombreAnimal.ReadOnly = True
        '
        'col_raza
        '
        Me.col_raza.HeaderText = "Raza"
        Me.col_raza.Name = "col_raza"
        Me.col_raza.ReadOnly = True
        '
        'col_tipoAnimal
        '
        Me.col_tipoAnimal.HeaderText = "Perro/Gato"
        Me.col_tipoAnimal.Name = "col_tipoAnimal"
        Me.col_tipoAnimal.ReadOnly = True
        '
        'col_edadAnimal
        '
        Me.col_edadAnimal.HeaderText = "Edad"
        Me.col_edadAnimal.Name = "col_edadAnimal"
        Me.col_edadAnimal.ReadOnly = True
        '
        'col_peloAnimal
        '
        Me.col_peloAnimal.HeaderText = "Pelo"
        Me.col_peloAnimal.Name = "col_peloAnimal"
        Me.col_peloAnimal.ReadOnly = True
        '
        'col_sexoAnimal
        '
        Me.col_sexoAnimal.HeaderText = "Sexo"
        Me.col_sexoAnimal.Name = "col_sexoAnimal"
        Me.col_sexoAnimal.ReadOnly = True
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.ReadOnly = True
        '
        'col_ciudad
        '
        Me.col_ciudad.HeaderText = "Ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.ReadOnly = True
        '
        'col_nombreResponsable
        '
        Me.col_nombreResponsable.HeaderText = "Responsable"
        Me.col_nombreResponsable.Name = "col_nombreResponsable"
        Me.col_nombreResponsable.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_NoSabe)
        Me.GroupBox1.Controls.Add(Me.cmb_color2)
        Me.GroupBox1.Controls.Add(Me.cmb_color1)
        Me.GroupBox1.Controls.Add(Me.rbtn_no)
        Me.GroupBox1.Controls.Add(Me.rb_si)
        Me.GroupBox1.Controls.Add(Me.lbl_castrado)
        Me.GroupBox1.Controls.Add(Me.lbl_color_2)
        Me.GroupBox1.Controls.Add(Me.lbl_color_1)
        Me.GroupBox1.Controls.Add(Me.cmb_pelo)
        Me.GroupBox1.Controls.Add(Me.lbl_pelo)
        Me.GroupBox1.Controls.Add(Me.cmb_edad)
        Me.GroupBox1.Controls.Add(Me.lbl_edad)
        Me.GroupBox1.Controls.Add(Me.cmb_tamano)
        Me.GroupBox1.Controls.Add(Me.lbl_tamano)
        Me.GroupBox1.Controls.Add(Me.cmb_sexo)
        Me.GroupBox1.Controls.Add(Me.lbl_sexo_animal)
        Me.GroupBox1.Controls.Add(Me.cmb_raza)
        Me.GroupBox1.Controls.Add(Me.lbl_raza)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_animal)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_animal)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(789, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros animal (Selecciona al menos 1)"
        '
        'rbtn_NoSabe
        '
        Me.rbtn_NoSabe.AutoSize = True
        Me.rbtn_NoSabe.Location = New System.Drawing.Point(667, 102)
        Me.rbtn_NoSabe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtn_NoSabe.Name = "rbtn_NoSabe"
        Me.rbtn_NoSabe.Size = New System.Drawing.Size(107, 21)
        Me.rbtn_NoSabe.TabIndex = 11
        Me.rbtn_NoSabe.TabStop = True
        Me.rbtn_NoSabe.Text = "Desconozco"
        Me.rbtn_NoSabe.UseVisualStyleBackColor = True
        '
        'cmb_color2
        '
        Me.cmb_color2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_color2.FormattingEnabled = True
        Me.cmb_color2.Location = New System.Drawing.Point(432, 53)
        Me.cmb_color2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_color2.Name = "cmb_color2"
        Me.cmb_color2.Size = New System.Drawing.Size(220, 24)
        Me.cmb_color2.TabIndex = 4
        '
        'cmb_color1
        '
        Me.cmb_color1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_color1.FormattingEnabled = True
        Me.cmb_color1.Location = New System.Drawing.Point(432, 21)
        Me.cmb_color1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_color1.Name = "cmb_color1"
        Me.cmb_color1.Size = New System.Drawing.Size(220, 24)
        Me.cmb_color1.TabIndex = 3
        '
        'rbtn_no
        '
        Me.rbtn_no.AutoSize = True
        Me.rbtn_no.Location = New System.Drawing.Point(607, 102)
        Me.rbtn_no.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtn_no.Name = "rbtn_no"
        Me.rbtn_no.Size = New System.Drawing.Size(47, 21)
        Me.rbtn_no.TabIndex = 10
        Me.rbtn_no.TabStop = True
        Me.rbtn_no.Text = "No"
        Me.rbtn_no.UseVisualStyleBackColor = True
        '
        'rb_si
        '
        Me.rb_si.AutoSize = True
        Me.rb_si.Location = New System.Drawing.Point(553, 102)
        Me.rb_si.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rb_si.Name = "rb_si"
        Me.rb_si.Size = New System.Drawing.Size(41, 21)
        Me.rb_si.TabIndex = 9
        Me.rb_si.TabStop = True
        Me.rb_si.Text = "Si"
        Me.rb_si.UseVisualStyleBackColor = True
        '
        'lbl_castrado
        '
        Me.lbl_castrado.AutoSize = True
        Me.lbl_castrado.Location = New System.Drawing.Point(529, 82)
        Me.lbl_castrado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_castrado.Name = "lbl_castrado"
        Me.lbl_castrado.Size = New System.Drawing.Size(69, 17)
        Me.lbl_castrado.TabIndex = 16
        Me.lbl_castrado.Text = "Castrado:"
        '
        'lbl_color_2
        '
        Me.lbl_color_2.AutoSize = True
        Me.lbl_color_2.Location = New System.Drawing.Point(365, 57)
        Me.lbl_color_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_color_2.Name = "lbl_color_2"
        Me.lbl_color_2.Size = New System.Drawing.Size(57, 17)
        Me.lbl_color_2.TabIndex = 14
        Me.lbl_color_2.Text = "Color 2:"
        '
        'lbl_color_1
        '
        Me.lbl_color_1.AutoSize = True
        Me.lbl_color_1.Location = New System.Drawing.Point(365, 25)
        Me.lbl_color_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_color_1.Name = "lbl_color_1"
        Me.lbl_color_1.Size = New System.Drawing.Size(57, 17)
        Me.lbl_color_1.TabIndex = 12
        Me.lbl_color_1.Text = "Color 1:"
        '
        'cmb_pelo
        '
        Me.cmb_pelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pelo.FormattingEnabled = True
        Me.cmb_pelo.Location = New System.Drawing.Point(169, 101)
        Me.cmb_pelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_pelo.Name = "cmb_pelo"
        Me.cmb_pelo.Size = New System.Drawing.Size(111, 24)
        Me.cmb_pelo.TabIndex = 6
        '
        'lbl_pelo
        '
        Me.lbl_pelo.AutoSize = True
        Me.lbl_pelo.Location = New System.Drawing.Point(165, 81)
        Me.lbl_pelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_pelo.Name = "lbl_pelo"
        Me.lbl_pelo.Size = New System.Drawing.Size(36, 17)
        Me.lbl_pelo.TabIndex = 10
        Me.lbl_pelo.Text = "Pelo"
        '
        'cmb_edad
        '
        Me.cmb_edad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_edad.FormattingEnabled = True
        Me.cmb_edad.Location = New System.Drawing.Point(49, 101)
        Me.cmb_edad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_edad.Name = "cmb_edad"
        Me.cmb_edad.Size = New System.Drawing.Size(111, 24)
        Me.cmb_edad.TabIndex = 5
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Location = New System.Drawing.Point(45, 81)
        Me.lbl_edad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(41, 17)
        Me.lbl_edad.TabIndex = 8
        Me.lbl_edad.Text = "Edad"
        '
        'cmb_tamano
        '
        Me.cmb_tamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tamano.FormattingEnabled = True
        Me.cmb_tamano.Location = New System.Drawing.Point(409, 101)
        Me.cmb_tamano.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_tamano.Name = "cmb_tamano"
        Me.cmb_tamano.Size = New System.Drawing.Size(111, 24)
        Me.cmb_tamano.TabIndex = 8
        '
        'lbl_tamano
        '
        Me.lbl_tamano.AutoSize = True
        Me.lbl_tamano.Location = New System.Drawing.Point(405, 81)
        Me.lbl_tamano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tamano.Name = "lbl_tamano"
        Me.lbl_tamano.Size = New System.Drawing.Size(60, 17)
        Me.lbl_tamano.TabIndex = 6
        Me.lbl_tamano.Text = "Tamaño"
        '
        'cmb_sexo
        '
        Me.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Location = New System.Drawing.Point(289, 101)
        Me.cmb_sexo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(111, 24)
        Me.cmb_sexo.TabIndex = 7
        '
        'lbl_sexo_animal
        '
        Me.lbl_sexo_animal.AutoSize = True
        Me.lbl_sexo_animal.Location = New System.Drawing.Point(285, 81)
        Me.lbl_sexo_animal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sexo_animal.Name = "lbl_sexo_animal"
        Me.lbl_sexo_animal.Size = New System.Drawing.Size(39, 17)
        Me.lbl_sexo_animal.TabIndex = 4
        Me.lbl_sexo_animal.Text = "Sexo"
        '
        'cmb_raza
        '
        Me.cmb_raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_raza.FormattingEnabled = True
        Me.cmb_raza.Location = New System.Drawing.Point(100, 53)
        Me.cmb_raza.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_raza.Name = "cmb_raza"
        Me.cmb_raza.Size = New System.Drawing.Size(220, 24)
        Me.cmb_raza.TabIndex = 2
        '
        'lbl_raza
        '
        Me.lbl_raza.AutoSize = True
        Me.lbl_raza.Location = New System.Drawing.Point(45, 57)
        Me.lbl_raza.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_raza.Name = "lbl_raza"
        Me.lbl_raza.Size = New System.Drawing.Size(45, 17)
        Me.lbl_raza.TabIndex = 2
        Me.lbl_raza.Text = "Raza:"
        '
        'txt_nombre_animal
        '
        Me.txt_nombre_animal.Location = New System.Drawing.Point(100, 21)
        Me.txt_nombre_animal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nombre_animal.MaxLength = 50
        Me.txt_nombre_animal.Name = "txt_nombre_animal"
        Me.txt_nombre_animal.Size = New System.Drawing.Size(220, 22)
        Me.txt_nombre_animal.TabIndex = 1
        '
        'lbl_nombre_animal
        '
        Me.lbl_nombre_animal.AutoSize = True
        Me.lbl_nombre_animal.Location = New System.Drawing.Point(33, 25)
        Me.lbl_nombre_animal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_animal.Name = "lbl_nombre_animal"
        Me.lbl_nombre_animal.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre_animal.TabIndex = 0
        Me.lbl_nombre_animal.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_ciudad)
        Me.GroupBox2.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox2.Controls.Add(Me.cmb_barrio)
        Me.GroupBox2.Controls.Add(Me.lbl_barrio)
        Me.GroupBox2.Location = New System.Drawing.Point(828, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(420, 97)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion adicional"
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(72, 58)
        Me.txt_ciudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.ReadOnly = True
        Me.txt_ciudad.Size = New System.Drawing.Size(339, 22)
        Me.txt_ciudad.TabIndex = 23
        Me.txt_ciudad.Text = "Cordoba"
        Me.txt_ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(11, 62)
        Me.lbl_ciudad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(52, 17)
        Me.lbl_ciudad.TabIndex = 25
        Me.lbl_ciudad.Text = "Ciudad"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(72, 23)
        Me.cmb_barrio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(339, 24)
        Me.cmb_barrio.TabIndex = 12
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(11, 27)
        Me.lbl_barrio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(46, 17)
        Me.lbl_barrio.TabIndex = 22
        Me.lbl_barrio.Text = "Barrio"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(1040, 146)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 28)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(1148, 146)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(100, 28)
        Me.btn_buscar.TabIndex = 13
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(876, 146)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(156, 28)
        Me.btn_clear.TabIndex = 15
        Me.btn_clear.Text = "Limpiar campos"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_listarPublicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 363)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_publicaciones)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_listarPublicaciones"
        Me.Text = "Buscar publicaciones"
        CType(Me.dgv_publicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_publicaciones As DataGridView
    Friend WithEvents col_idPublicacion As DataGridViewTextBoxColumn
    Friend WithEvents col_nombreAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_raza As DataGridViewTextBoxColumn
    Friend WithEvents col_tipoAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_edadAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_peloAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_sexoAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As DataGridViewTextBoxColumn
    Friend WithEvents col_ciudad As DataGridViewTextBoxColumn
    Friend WithEvents col_nombreResponsable As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn_NoSabe As RadioButton
    Friend WithEvents cmb_color2 As ComboBox
    Friend WithEvents cmb_color1 As ComboBox
    Friend WithEvents rbtn_no As RadioButton
    Friend WithEvents rb_si As RadioButton
    Friend WithEvents lbl_castrado As Label
    Friend WithEvents lbl_color_2 As Label
    Friend WithEvents lbl_color_1 As Label
    Friend WithEvents cmb_pelo As ComboBox
    Friend WithEvents lbl_pelo As Label
    Friend WithEvents cmb_edad As ComboBox
    Friend WithEvents lbl_edad As Label
    Friend WithEvents cmb_tamano As ComboBox
    Friend WithEvents lbl_tamano As Label
    Friend WithEvents cmb_sexo As ComboBox
    Friend WithEvents lbl_sexo_animal As Label
    Friend WithEvents cmb_raza As ComboBox
    Friend WithEvents lbl_raza As Label
    Friend WithEvents txt_nombre_animal As TextBox
    Friend WithEvents lbl_nombre_animal As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_ciudad As TextBox
    Friend WithEvents lbl_ciudad As Label
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents lbl_barrio As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_clear As Button
End Class
