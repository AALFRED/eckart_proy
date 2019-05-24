<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_incobrables
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_exp_excel_acc = New System.Windows.Forms.Button()
        Me.lbl_cod_vend = New System.Windows.Forms.Label()
        Me.cbo_vend = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.msk_fe_fin = New System.Windows.Forms.MaskedTextBox()
        Me.msk_fe_ini = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.cbo_tipo_bd = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cbo_filtro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_cta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_vend = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel_acc)
        Me.GroupBox1.Controls.Add(Me.lbl_cod_vend)
        Me.GroupBox1.Controls.Add(Me.cbo_vend)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.msk_fe_fin)
        Me.GroupBox1.Controls.Add(Me.msk_fe_ini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_rut)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_bd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Controls.Add(Me.cbo_filtro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_cta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1197, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Búsqueda"
        '
        'cmd_exp_excel_acc
        '
        Me.cmd_exp_excel_acc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_excel_acc.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel_acc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel_acc.Location = New System.Drawing.Point(930, 69)
        Me.cmd_exp_excel_acc.Name = "cmd_exp_excel_acc"
        Me.cmd_exp_excel_acc.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_excel_acc.TabIndex = 49
        Me.cmd_exp_excel_acc.Text = "Exportar Excel"
        Me.cmd_exp_excel_acc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel_acc.UseVisualStyleBackColor = False
        '
        'lbl_cod_vend
        '
        Me.lbl_cod_vend.AutoSize = True
        Me.lbl_cod_vend.Location = New System.Drawing.Point(844, 31)
        Me.lbl_cod_vend.Name = "lbl_cod_vend"
        Me.lbl_cod_vend.Size = New System.Drawing.Size(59, 15)
        Me.lbl_cod_vend.TabIndex = 47
        Me.lbl_cod_vend.Text = "cod_vend"
        '
        'cbo_vend
        '
        Me.cbo_vend.FormattingEnabled = True
        Me.cbo_vend.Location = New System.Drawing.Point(719, 49)
        Me.cbo_vend.Name = "cbo_vend"
        Me.cbo_vend.Size = New System.Drawing.Size(142, 23)
        Me.cbo_vend.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(716, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Seleccione Vendedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Fecha Final:"
        '
        'msk_fe_fin
        '
        Me.msk_fe_fin.Location = New System.Drawing.Point(488, 51)
        Me.msk_fe_fin.Mask = "0000-00-00"
        Me.msk_fe_fin.Name = "msk_fe_fin"
        Me.msk_fe_fin.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_fin.TabIndex = 43
        '
        'msk_fe_ini
        '
        Me.msk_fe_ini.Location = New System.Drawing.Point(369, 51)
        Me.msk_fe_ini.Mask = "0000-00-00"
        Me.msk_fe_ini.Name = "msk_fe_ini"
        Me.msk_fe_ini.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_ini.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Rut:"
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(191, 103)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(70, 23)
        Me.txt_rut.TabIndex = 10
        '
        'cbo_tipo_bd
        '
        Me.cbo_tipo_bd.FormattingEnabled = True
        Me.cbo_tipo_bd.Location = New System.Drawing.Point(27, 49)
        Me.cbo_tipo_bd.Name = "cbo_tipo_bd"
        Me.cbo_tipo_bd.Size = New System.Drawing.Size(142, 23)
        Me.cbo_tipo_bd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Seleccione BD"
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel.Location = New System.Drawing.Point(930, 69)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_excel.TabIndex = 7
        Me.cmd_exp_excel.Text = "Exportar Excel"
        Me.cmd_exp_excel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancelar.Location = New System.Drawing.Point(755, 85)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(95, 47)
        Me.cmd_cancelar.TabIndex = 6
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(587, 85)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar.TabIndex = 5
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar.Location = New System.Drawing.Point(432, 85)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(91, 47)
        Me.cmd_buscar.TabIndex = 4
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cbo_filtro
        '
        Me.cbo_filtro.FormattingEnabled = True
        Me.cbo_filtro.Location = New System.Drawing.Point(191, 48)
        Me.cbo_filtro.Name = "cbo_filtro"
        Me.cbo_filtro.Size = New System.Drawing.Size(153, 23)
        Me.cbo_filtro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filtrar por:"
        '
        'cbo_cta
        '
        Me.cbo_cta.FormattingEnabled = True
        Me.cbo_cta.Location = New System.Drawing.Point(27, 103)
        Me.cbo_cta.Name = "cbo_cta"
        Me.cbo_cta.Size = New System.Drawing.Size(142, 23)
        Me.cbo_cta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione Cuenta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_total_vend)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_buscar)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_reg)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1197, 566)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'lbl_total_vend
        '
        Me.lbl_total_vend.AutoSize = True
        Me.lbl_total_vend.Location = New System.Drawing.Point(389, 529)
        Me.lbl_total_vend.Name = "lbl_total_vend"
        Me.lbl_total_vend.Size = New System.Drawing.Size(86, 15)
        Me.lbl_total_vend.TabIndex = 6
        Me.lbl_total_vend.Text = "lbl_total_vend"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 512)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Total Monto Vendedor:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(223, 528)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(121, 23)
        Me.txt_buscar.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 512)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "BUSCAR CONTENIDO:"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.Location = New System.Drawing.Point(36, 536)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(45, 15)
        Me.lbl_reg.TabIndex = 2
        Me.lbl_reg.Text = "lbl_reg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 512)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nro de Registros Encontrados: "
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla.Location = New System.Drawing.Point(17, 30)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(1153, 461)
        Me.grilla.TabIndex = 0
        '
        'frm_incobrables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 811)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frm_incobrables"
        Me.Text = "frm_incobrables"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents cbo_filtro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_cta As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cbo_tipo_bd As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_rut As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents msk_fe_fin As MaskedTextBox
    Friend WithEvents msk_fe_ini As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_cod_vend As Label
    Friend WithEvents cbo_vend As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmd_exp_excel_acc As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_total_vend As Label
End Class
