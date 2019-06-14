<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_tpo = New System.Windows.Forms.ComboBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_truncate_bd = New System.Windows.Forms.Button()
        Me.cmd_cargar_mysql = New System.Windows.Forms.Button()
        Me.cmd_cargar_access = New System.Windows.Forms.Button()
        Me.cmd_seleccionar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_nroreg = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_nroreg2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmd_quitar_vend = New System.Windows.Forms.Button()
        Me.cmd_asigna_vend = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_vend_actual = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grilla2 = New System.Windows.Forms.DataGridView()
        Me.lbl_nomclie = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_rutclie = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_cod_vend = New System.Windows.Forms.Label()
        Me.cbo_vend = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbo_tpo)
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_truncate_bd)
        Me.GroupBox1.Controls.Add(Me.cmd_cargar_mysql)
        Me.GroupBox1.Controls.Add(Me.cmd_cargar_access)
        Me.GroupBox1.Controls.Add(Me.cmd_seleccionar)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga Masiva"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Seleccione tipo de Base de Datos"
        '
        'cbo_tpo
        '
        Me.cbo_tpo.FormattingEnabled = True
        Me.cbo_tpo.Location = New System.Drawing.Point(48, 52)
        Me.cbo_tpo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_tpo.Name = "cbo_tpo"
        Me.cbo_tpo.Size = New System.Drawing.Size(107, 23)
        Me.cbo_tpo.TabIndex = 26
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(698, 31)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(91, 39)
        Me.cmd_cancelar.TabIndex = 5
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_truncate_bd
        '
        Me.cmd_truncate_bd.Location = New System.Drawing.Point(587, 29)
        Me.cmd_truncate_bd.Name = "cmd_truncate_bd"
        Me.cmd_truncate_bd.Size = New System.Drawing.Size(91, 43)
        Me.cmd_truncate_bd.TabIndex = 4
        Me.cmd_truncate_bd.Text = "Limpiar Tabla de Datos"
        Me.cmd_truncate_bd.UseVisualStyleBackColor = True
        '
        'cmd_cargar_mysql
        '
        Me.cmd_cargar_mysql.Location = New System.Drawing.Point(431, 57)
        Me.cmd_cargar_mysql.Name = "cmd_cargar_mysql"
        Me.cmd_cargar_mysql.Size = New System.Drawing.Size(124, 32)
        Me.cmd_cargar_mysql.TabIndex = 3
        Me.cmd_cargar_mysql.Text = "Cargar a Mysql"
        Me.cmd_cargar_mysql.UseVisualStyleBackColor = True
        '
        'cmd_cargar_access
        '
        Me.cmd_cargar_access.Location = New System.Drawing.Point(431, 19)
        Me.cmd_cargar_access.Name = "cmd_cargar_access"
        Me.cmd_cargar_access.Size = New System.Drawing.Size(124, 32)
        Me.cmd_cargar_access.TabIndex = 1
        Me.cmd_cargar_access.Text = "Cargar a Access"
        Me.cmd_cargar_access.UseVisualStyleBackColor = True
        '
        'cmd_seleccionar
        '
        Me.cmd_seleccionar.Location = New System.Drawing.Point(219, 37)
        Me.cmd_seleccionar.Name = "cmd_seleccionar"
        Me.cmd_seleccionar.Size = New System.Drawing.Size(149, 33)
        Me.cmd_seleccionar.TabIndex = 0
        Me.cmd_seleccionar.Text = "Seleccionar Archivo"
        Me.cmd_seleccionar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(814, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Carga Manual"
        Me.GroupBox2.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(184, 117)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(148, 23)
        Me.ComboBox3.TabIndex = 18
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(93, 118)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(63, 23)
        Me.ComboBox2.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(662, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(50, 23)
        Me.ComboBox1.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(565, 113)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(61, 23)
        Me.TextBox7.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(364, 118)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(61, 23)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(12, 118)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(61, 23)
        Me.TextBox5.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(844, 56)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(61, 23)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(347, 54)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(255, 23)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(79, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 23)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 23)
        Me.TextBox1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cod.Relacion Emp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(229, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ciudad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(673, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Activo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(852, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Planta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Region"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cobrar-A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_nroreg)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.grilla)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(812, 453)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes Registrados"
        '
        'lbl_nroreg
        '
        Me.lbl_nroreg.AutoSize = True
        Me.lbl_nroreg.Location = New System.Drawing.Point(74, 407)
        Me.lbl_nroreg.Name = "lbl_nroreg"
        Me.lbl_nroreg.Size = New System.Drawing.Size(64, 15)
        Me.lbl_nroreg.TabIndex = 2
        Me.lbl_nroreg.Text = "lbl_nroreg"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 407)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nro Reg:"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(16, 29)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(781, 351)
        Me.grilla.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_nroreg2)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cmd_quitar_vend)
        Me.GroupBox4.Controls.Add(Me.cmd_asigna_vend)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lbl_vend_actual)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.grilla2)
        Me.GroupBox4.Controls.Add(Me.lbl_nomclie)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txt_rutclie)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lbl_cod_vend)
        Me.GroupBox4.Controls.Add(Me.cbo_vend)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(870, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(467, 557)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Asignacion de Cuenta"
        Me.GroupBox4.Visible = False
        '
        'lbl_nroreg2
        '
        Me.lbl_nroreg2.AutoSize = True
        Me.lbl_nroreg2.Location = New System.Drawing.Point(78, 528)
        Me.lbl_nroreg2.Name = "lbl_nroreg2"
        Me.lbl_nroreg2.Size = New System.Drawing.Size(71, 15)
        Me.lbl_nroreg2.TabIndex = 14
        Me.lbl_nroreg2.Text = "lbl_nroreg2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 528)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Nro Reg:"
        '
        'cmd_quitar_vend
        '
        Me.cmd_quitar_vend.Location = New System.Drawing.Point(352, 153)
        Me.cmd_quitar_vend.Name = "cmd_quitar_vend"
        Me.cmd_quitar_vend.Size = New System.Drawing.Size(99, 35)
        Me.cmd_quitar_vend.TabIndex = 12
        Me.cmd_quitar_vend.Text = "Retirar vend."
        Me.cmd_quitar_vend.UseVisualStyleBackColor = True
        '
        'cmd_asigna_vend
        '
        Me.cmd_asigna_vend.Location = New System.Drawing.Point(352, 104)
        Me.cmd_asigna_vend.Name = "cmd_asigna_vend"
        Me.cmd_asigna_vend.Size = New System.Drawing.Size(99, 35)
        Me.cmd_asigna_vend.TabIndex = 11
        Me.cmd_asigna_vend.Text = "Asignar vend."
        Me.cmd_asigna_vend.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(156, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Cuentas Asiganadas"
        '
        'lbl_vend_actual
        '
        Me.lbl_vend_actual.AutoSize = True
        Me.lbl_vend_actual.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_vend_actual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_vend_actual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_vend_actual.Location = New System.Drawing.Point(125, 104)
        Me.lbl_vend_actual.Name = "lbl_vend_actual"
        Me.lbl_vend_actual.Size = New System.Drawing.Size(97, 17)
        Me.lbl_vend_actual.TabIndex = 9
        Me.lbl_vend_actual.Text = "lbl_vend_actual"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(23, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Vend. Actual: "
        '
        'grilla2
        '
        Me.grilla2.AllowUserToAddRows = False
        Me.grilla2.AllowUserToDeleteRows = False
        Me.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla2.Location = New System.Drawing.Point(11, 222)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.ReadOnly = True
        Me.grilla2.Size = New System.Drawing.Size(414, 269)
        Me.grilla2.TabIndex = 7
        '
        'lbl_nomclie
        '
        Me.lbl_nomclie.AutoSize = True
        Me.lbl_nomclie.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_nomclie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nomclie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nomclie.Location = New System.Drawing.Point(148, 60)
        Me.lbl_nomclie.Name = "lbl_nomclie"
        Me.lbl_nomclie.Size = New System.Drawing.Size(74, 17)
        Me.lbl_nomclie.TabIndex = 6
        Me.lbl_nomclie.Text = "lbl_nomclie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(143, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 17)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Nombre Cliente: "
        '
        'txt_rutclie
        '
        Me.txt_rutclie.Location = New System.Drawing.Point(34, 54)
        Me.txt_rutclie.Name = "txt_rutclie"
        Me.txt_rutclie.Size = New System.Drawing.Size(77, 23)
        Me.txt_rutclie.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(34, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Rut Cliente:"
        '
        'lbl_cod_vend
        '
        Me.lbl_cod_vend.AutoSize = True
        Me.lbl_cod_vend.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_cod_vend.Location = New System.Drawing.Point(135, 142)
        Me.lbl_cod_vend.Name = "lbl_cod_vend"
        Me.lbl_cod_vend.Size = New System.Drawing.Size(80, 15)
        Me.lbl_cod_vend.TabIndex = 2
        Me.lbl_cod_vend.Text = "lbl_cod_vend"
        '
        'cbo_vend
        '
        Me.cbo_vend.FormattingEnabled = True
        Me.cbo_vend.Location = New System.Drawing.Point(23, 162)
        Me.cbo_vend.Name = "cbo_vend"
        Me.cbo_vend.Size = New System.Drawing.Size(173, 23)
        Me.cbo_vend.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(23, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Asignar Vendedor:"
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(863, 625)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_cliente"
        Me.Text = "frm_cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_cargar_access As Button
    Friend WithEvents cmd_seleccionar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents lbl_nroreg As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmd_cargar_mysql As Button
    Friend WithEvents cmd_truncate_bd As Button
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_tpo As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmd_quitar_vend As Button
    Friend WithEvents cmd_asigna_vend As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_vend_actual As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents grilla2 As DataGridView
    Friend WithEvents lbl_nomclie As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_rutclie As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_cod_vend As Label
    Friend WithEvents cbo_vend As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_nroreg2 As Label
    Friend WithEvents Label17 As Label
End Class
