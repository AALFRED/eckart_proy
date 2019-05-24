<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_saldos_atrasados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_saldos_atrasados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.msk_fe_ini = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_totales = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_bus_grilla = New System.Windows.Forms.TextBox()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_bus_saldo_atrasado = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.msk_fe_fin = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_tipo_bd = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.msk_fe_ini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_totales)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_reg)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_salir)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_bus_saldo_atrasado)
        Me.GroupBox1.Controls.Add(Me.grilla)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.msk_fe_fin)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_bd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1267, 567)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldos Atrasados"
        '
        'msk_fe_ini
        '
        Me.msk_fe_ini.Location = New System.Drawing.Point(220, 50)
        Me.msk_fe_ini.Mask = "0000-00-00"
        Me.msk_fe_ini.Name = "msk_fe_ini"
        Me.msk_fe_ini.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_ini.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Fecha Inicial:"
        '
        'lbl_totales
        '
        Me.lbl_totales.AutoSize = True
        Me.lbl_totales.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbl_totales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_totales.Location = New System.Drawing.Point(457, 522)
        Me.lbl_totales.Name = "lbl_totales"
        Me.lbl_totales.Size = New System.Drawing.Size(66, 17)
        Me.lbl_totales.TabIndex = 66
        Me.lbl_totales.Text = "lbl_totales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(457, 503)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Totales:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(262, 507)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 15)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Buscar :"
        '
        'txt_bus_grilla
        '
        Me.txt_bus_grilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bus_grilla.Location = New System.Drawing.Point(243, 524)
        Me.txt_bus_grilla.Name = "txt_bus_grilla"
        Me.txt_bus_grilla.Size = New System.Drawing.Size(142, 23)
        Me.txt_bus_grilla.TabIndex = 67
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_excel.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel.Location = New System.Drawing.Point(1078, 26)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_excel.TabIndex = 61
        Me.cmd_exp_excel.Text = "Exportar Excel"
        Me.cmd_exp_excel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir.Location = New System.Drawing.Point(836, 26)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir.TabIndex = 60
        Me.cmd_salir.Text = "Cancelar"
        Me.cmd_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(689, 26)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar.TabIndex = 59
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_bus_saldo_atrasado
        '
        Me.cmd_bus_saldo_atrasado.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_saldo_atrasado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_saldo_atrasado.Location = New System.Drawing.Point(542, 26)
        Me.cmd_bus_saldo_atrasado.Name = "cmd_bus_saldo_atrasado"
        Me.cmd_bus_saldo_atrasado.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_saldo_atrasado.TabIndex = 58
        Me.cmd_bus_saldo_atrasado.Text = "Buscar"
        Me.cmd_bus_saldo_atrasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_saldo_atrasado.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(9, 93)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(1237, 392)
        Me.grilla.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha Final:"
        '
        'msk_fe_fin
        '
        Me.msk_fe_fin.Location = New System.Drawing.Point(375, 50)
        Me.msk_fe_fin.Mask = "0000-00-00"
        Me.msk_fe_fin.Name = "msk_fe_fin"
        Me.msk_fe_fin.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_fin.TabIndex = 51
        '
        'cbo_tipo_bd
        '
        Me.cbo_tipo_bd.FormattingEnabled = True
        Me.cbo_tipo_bd.Location = New System.Drawing.Point(20, 50)
        Me.cbo_tipo_bd.Name = "cbo_tipo_bd"
        Me.cbo_tipo_bd.Size = New System.Drawing.Size(142, 23)
        Me.cbo_tipo_bd.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Seleccione BD"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(38, 609)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(65, 15)
        Me.lbl_version.TabIndex = 4
        Me.lbl_version.Text = "lbl_version"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 508)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 15)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Nro de Registros : "
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.Location = New System.Drawing.Point(66, 532)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(44, 15)
        Me.lbl_reg.TabIndex = 63
        Me.lbl_reg.Text = "lbl_reg"
        '
        'frm_saldos_atrasados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1324, 676)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_saldos_atrasados"
        Me.Text = "frm_saldos_atrasados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents msk_fe_fin As MaskedTextBox
    Friend WithEvents cbo_tipo_bd As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_version As Label
    Friend WithEvents grilla As DataGridView
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_salir As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_bus_saldo_atrasado As Button
    Friend WithEvents lbl_totales As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_bus_grilla As TextBox
    Friend WithEvents msk_fe_ini As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label15 As Label
End Class
