<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_saldo_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_saldo_cliente))
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_bus_grilla1 = New System.Windows.Forms.TextBox()
        Me.msk_fe_ini = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.msk_fe_fin = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_totales = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_bus_saldo_clte = New System.Windows.Forms.Button()
        Me.cbo_tipo_bd = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bus_grilla2 = New System.Windows.Forms.TextBox()
        Me.cmd_exp_excel2 = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_totales2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_reg2 = New System.Windows.Forms.Label()
        Me.grilla2 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(54, 585)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(65, 15)
        Me.lbl_version.TabIndex = 6
        Me.lbl_version.Text = "lbl_version"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla1)
        Me.GroupBox1.Controls.Add(Me.msk_fe_ini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.msk_fe_fin)
        Me.GroupBox1.Controls.Add(Me.lbl_totales)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lbl_reg)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.grilla)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_bus_saldo_clte)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_bd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 540)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldos Clientes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(170, 485)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Buscar:"
        '
        'txt_bus_grilla1
        '
        Me.txt_bus_grilla1.Location = New System.Drawing.Point(139, 502)
        Me.txt_bus_grilla1.Name = "txt_bus_grilla1"
        Me.txt_bus_grilla1.Size = New System.Drawing.Size(123, 23)
        Me.txt_bus_grilla1.TabIndex = 89
        '
        'msk_fe_ini
        '
        Me.msk_fe_ini.Location = New System.Drawing.Point(173, 61)
        Me.msk_fe_ini.Mask = "0000-00-00"
        Me.msk_fe_ini.Name = "msk_fe_ini"
        Me.msk_fe_ini.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_ini.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Fecha Inicial:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Fecha Final:"
        '
        'msk_fe_fin
        '
        Me.msk_fe_fin.Location = New System.Drawing.Point(272, 62)
        Me.msk_fe_fin.Mask = "0000-00-00"
        Me.msk_fe_fin.Name = "msk_fe_fin"
        Me.msk_fe_fin.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_fin.TabIndex = 85
        '
        'lbl_totales
        '
        Me.lbl_totales.AutoSize = True
        Me.lbl_totales.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbl_totales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_totales.Location = New System.Drawing.Point(370, 500)
        Me.lbl_totales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_totales.Name = "lbl_totales"
        Me.lbl_totales.Size = New System.Drawing.Size(66, 17)
        Me.lbl_totales.TabIndex = 76
        Me.lbl_totales.Text = "lbl_totales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(367, 485)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Totales:"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.Location = New System.Drawing.Point(31, 502)
        Me.lbl_reg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(44, 15)
        Me.lbl_reg.TabIndex = 74
        Me.lbl_reg.Text = "lbl_reg"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 487)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 15)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Nro de Registros : "
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(18, 112)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(620, 356)
        Me.grilla.TabIndex = 72
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_excel.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exp_excel.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel.Location = New System.Drawing.Point(495, 480)
        Me.cmd_exp_excel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(128, 37)
        Me.cmd_exp_excel.TabIndex = 71
        Me.cmd_exp_excel.Text = "Exp.Exc. Grilla1"
        Me.cmd_exp_excel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel.UseVisualStyleBackColor = False
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(513, 41)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(94, 44)
        Me.cmd_limpiar.TabIndex = 69
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_bus_saldo_clte
        '
        Me.cmd_bus_saldo_clte.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_saldo_clte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_saldo_clte.Location = New System.Drawing.Point(383, 41)
        Me.cmd_bus_saldo_clte.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_bus_saldo_clte.Name = "cmd_bus_saldo_clte"
        Me.cmd_bus_saldo_clte.Size = New System.Drawing.Size(92, 44)
        Me.cmd_bus_saldo_clte.TabIndex = 68
        Me.cmd_bus_saldo_clte.Text = "Buscar"
        Me.cmd_bus_saldo_clte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_saldo_clte.UseVisualStyleBackColor = True
        '
        'cbo_tipo_bd
        '
        Me.cbo_tipo_bd.FormattingEnabled = True
        Me.cbo_tipo_bd.Location = New System.Drawing.Point(34, 59)
        Me.cbo_tipo_bd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbo_tipo_bd.Name = "cbo_tipo_bd"
        Me.cbo_tipo_bd.Size = New System.Drawing.Size(111, 23)
        Me.cbo_tipo_bd.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Seleccione BD"
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir.Location = New System.Drawing.Point(549, 40)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(97, 44)
        Me.cmd_salir.TabIndex = 70
        Me.cmd_salir.Text = "Cancelar"
        Me.cmd_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_bus_grilla2)
        Me.GroupBox2.Controls.Add(Me.cmd_exp_excel2)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre)
        Me.GroupBox2.Controls.Add(Me.lbl_rut)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_totales2)
        Me.GroupBox2.Controls.Add(Me.cmd_salir)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_reg2)
        Me.GroupBox2.Controls.Add(Me.grilla2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(680, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 536)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Saldos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 477)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Buscar:"
        '
        'txt_bus_grilla2
        '
        Me.txt_bus_grilla2.Location = New System.Drawing.Point(209, 493)
        Me.txt_bus_grilla2.Name = "txt_bus_grilla2"
        Me.txt_bus_grilla2.Size = New System.Drawing.Size(111, 23)
        Me.txt_bus_grilla2.TabIndex = 91
        '
        'cmd_exp_excel2
        '
        Me.cmd_exp_excel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_excel2.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exp_excel2.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel2.Location = New System.Drawing.Point(519, 486)
        Me.cmd_exp_excel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_exp_excel2.Name = "cmd_exp_excel2"
        Me.cmd_exp_excel2.Size = New System.Drawing.Size(128, 37)
        Me.cmd_exp_excel2.TabIndex = 88
        Me.cmd_exp_excel2.Text = "Exp.Exc. Grilla1"
        Me.cmd_exp_excel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel2.UseVisualStyleBackColor = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nombre.Location = New System.Drawing.Point(141, 67)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(70, 17)
        Me.lbl_nombre.TabIndex = 87
        Me.lbl_nombre.Text = "lbl_nombre"
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_rut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rut.Location = New System.Drawing.Point(138, 37)
        Me.lbl_rut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(45, 17)
        Me.lbl_rut.TabIndex = 86
        Me.lbl_rut.Text = "lbl_rut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Nombre del Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Rut del Cliente:"
        '
        'lbl_totales2
        '
        Me.lbl_totales2.AutoSize = True
        Me.lbl_totales2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbl_totales2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_totales2.Location = New System.Drawing.Point(347, 498)
        Me.lbl_totales2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_totales2.Name = "lbl_totales2"
        Me.lbl_totales2.Size = New System.Drawing.Size(73, 17)
        Me.lbl_totales2.TabIndex = 81
        Me.lbl_totales2.Text = "lbl_totales2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 481)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Totales:"
        '
        'lbl_reg2
        '
        Me.lbl_reg2.AutoSize = True
        Me.lbl_reg2.Location = New System.Drawing.Point(50, 498)
        Me.lbl_reg2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_reg2.Name = "lbl_reg2"
        Me.lbl_reg2.Size = New System.Drawing.Size(51, 15)
        Me.lbl_reg2.TabIndex = 83
        Me.lbl_reg2.Text = "lbl_reg2"
        '
        'grilla2
        '
        Me.grilla2.AllowUserToAddRows = False
        Me.grilla2.AllowUserToDeleteRows = False
        Me.grilla2.AllowUserToOrderColumns = True
        Me.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla2.Location = New System.Drawing.Point(6, 109)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.Size = New System.Drawing.Size(640, 356)
        Me.grilla2.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 481)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 15)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Nro de Doctos. Encontrados: "
        '
        'frm_saldo_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1353, 629)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_version)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_saldo_cliente"
        Me.Text = "frm_saldo_cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_version As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_salir As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_bus_saldo_clte As Button
    Friend WithEvents cbo_tipo_bd As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grilla As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grilla2 As DataGridView
    Friend WithEvents lbl_totales As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_totales2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_reg2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_rut As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_exp_excel2 As Button
    Friend WithEvents msk_fe_ini As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents msk_fe_fin As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_bus_grilla1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_bus_grilla2 As TextBox
End Class
