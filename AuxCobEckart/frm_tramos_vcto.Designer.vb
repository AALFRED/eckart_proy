<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tramos_vcto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tramos_vcto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_tramos = New System.Windows.Forms.ComboBox()
        Me.txt_nro_dias = New System.Windows.Forms.TextBox()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_bus_saldo_atrasado = New System.Windows.Forms.Button()
        Me.msk_fe_ini = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.msk_fe_fin = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_tipo_bd = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_tramos)
        Me.GroupBox1.Controls.Add(Me.txt_nro_dias)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_salir)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_bus_saldo_atrasado)
        Me.GroupBox1.Controls.Add(Me.msk_fe_ini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.msk_fe_fin)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_bd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1192, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda por Tramos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(487, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Personalizado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(392, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Tramos Dias"
        '
        'cbo_tramos
        '
        Me.cbo_tramos.FormattingEnabled = True
        Me.cbo_tramos.Location = New System.Drawing.Point(386, 51)
        Me.cbo_tramos.Name = "cbo_tramos"
        Me.cbo_tramos.Size = New System.Drawing.Size(93, 23)
        Me.cbo_tramos.TabIndex = 80
        '
        'txt_nro_dias
        '
        Me.txt_nro_dias.Location = New System.Drawing.Point(494, 50)
        Me.txt_nro_dias.Name = "txt_nro_dias"
        Me.txt_nro_dias.Size = New System.Drawing.Size(62, 23)
        Me.txt_nro_dias.TabIndex = 79
        Me.txt_nro_dias.Text = "txt_nro_dias"
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_excel.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel.Location = New System.Drawing.Point(1023, 32)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_excel.TabIndex = 78
        Me.cmd_exp_excel.Text = "Exportar Excel"
        Me.cmd_exp_excel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir.Location = New System.Drawing.Point(823, 32)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir.TabIndex = 77
        Me.cmd_salir.Text = "Cancelar"
        Me.cmd_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(702, 32)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar.TabIndex = 76
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_bus_saldo_atrasado
        '
        Me.cmd_bus_saldo_atrasado.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_saldo_atrasado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_saldo_atrasado.Location = New System.Drawing.Point(587, 32)
        Me.cmd_bus_saldo_atrasado.Name = "cmd_bus_saldo_atrasado"
        Me.cmd_bus_saldo_atrasado.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_saldo_atrasado.TabIndex = 75
        Me.cmd_bus_saldo_atrasado.Text = "Buscar"
        Me.cmd_bus_saldo_atrasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_saldo_atrasado.UseVisualStyleBackColor = True
        '
        'msk_fe_ini
        '
        Me.msk_fe_ini.Location = New System.Drawing.Point(178, 50)
        Me.msk_fe_ini.Mask = "0000-00-00"
        Me.msk_fe_ini.Name = "msk_fe_ini"
        Me.msk_fe_ini.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_ini.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(191, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Fecha Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(294, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Fecha Final:"
        '
        'msk_fe_fin
        '
        Me.msk_fe_fin.Location = New System.Drawing.Point(286, 51)
        Me.msk_fe_fin.Mask = "0000-00-00"
        Me.msk_fe_fin.Name = "msk_fe_fin"
        Me.msk_fe_fin.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_fin.TabIndex = 70
        '
        'cbo_tipo_bd
        '
        Me.cbo_tipo_bd.FormattingEnabled = True
        Me.cbo_tipo_bd.Location = New System.Drawing.Point(33, 51)
        Me.cbo_tipo_bd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbo_tipo_bd.Name = "cbo_tipo_bd"
        Me.cbo_tipo_bd.Size = New System.Drawing.Size(111, 23)
        Me.cbo_tipo_bd.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(30, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Seleccione BD"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_reg)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1192, 456)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_reg.Location = New System.Drawing.Point(129, 405)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(46, 17)
        Me.lbl_reg.TabIndex = 65
        Me.lbl_reg.Text = "lbl_reg"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 405)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 15)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Nro de Registros : "
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(6, 22)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(1024, 366)
        Me.grilla.TabIndex = 0
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(26, 742)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(65, 15)
        Me.lbl_version.TabIndex = 5
        Me.lbl_version.Text = "lbl_version"
        '
        'frm_tramos_vcto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1271, 657)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tramos_vcto"
        Me.Text = "frm_tramos_vcto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_tipo_bd As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents msk_fe_ini As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents msk_fe_fin As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents lbl_version As Label
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_salir As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_bus_saldo_atrasado As Button
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_nro_dias As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_tramos As ComboBox
    Friend WithEvents Label2 As Label
End Class
