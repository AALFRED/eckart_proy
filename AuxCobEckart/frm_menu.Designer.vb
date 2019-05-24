<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_totales = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TC1 = New System.Windows.Forms.TabControl()
        Me.TP1 = New System.Windows.Forms.TabPage()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_salir1 = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.msk_fe_fin = New System.Windows.Forms.MaskedTextBox()
        Me.msk_fe_ini = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_tipo_bd_tp1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grilla1 = New System.Windows.Forms.DataGridView()
        Me.TP2 = New System.Windows.Forms.TabPage()
        Me.cmd_exp_exc_grilla2 = New System.Windows.Forms.Button()
        Me.cmd_salir2 = New System.Windows.Forms.Button()
        Me.cmd_limpiar2 = New System.Windows.Forms.Button()
        Me.cmd_bus_may_fecha = New System.Windows.Forms.Button()
        Me.msk_fe_ini2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_tipo_bd_tp2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grilla2 = New System.Windows.Forms.DataGridView()
        Me.TP3 = New System.Windows.Forms.TabPage()
        Me.cmd_exp_exc_grilla3 = New System.Windows.Forms.Button()
        Me.cmd_salir3 = New System.Windows.Forms.Button()
        Me.cmd_limpiar3 = New System.Windows.Forms.Button()
        Me.cmd_bus_men_fecha = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.msk_fe_ini3 = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_tipo_bd_tp3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grilla3 = New System.Windows.Forms.DataGridView()
        Me.TP4 = New System.Windows.Forms.TabPage()
        Me.cmd_exp_exc_grilla4 = New System.Windows.Forms.Button()
        Me.cmd_salir4 = New System.Windows.Forms.Button()
        Me.cmd_limpiar4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.cbo_tipo_bd_tp4 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_bus_rut4 = New System.Windows.Forms.Button()
        Me.grilla4 = New System.Windows.Forms.DataGridView()
        Me.TP5 = New System.Windows.Forms.TabPage()
        Me.cmd_exp_exc_grilla5 = New System.Windows.Forms.Button()
        Me.cmd_salir5 = New System.Windows.Forms.Button()
        Me.cmd_limpiar5 = New System.Windows.Forms.Button()
        Me.lbl_cod_vend = New System.Windows.Forms.Label()
        Me.cbo_vend = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_tipo_bd_tp5 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmd_bus_vend5 = New System.Windows.Forms.Button()
        Me.grilla5 = New System.Windows.Forms.DataGridView()
        Me.TP6 = New System.Windows.Forms.TabPage()
        Me.cmd_exp_exc_grilla6 = New System.Windows.Forms.Button()
        Me.cmd_salir6 = New System.Windows.Forms.Button()
        Me.cmd_limpiar6 = New System.Windows.Forms.Button()
        Me.cmd_bus_cuadro_anual6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.msk_fe_fin6 = New System.Windows.Forms.MaskedTextBox()
        Me.msk_fe_ini6 = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbo_tipo_bd_tp6 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grilla6 = New System.Windows.Forms.DataGridView()
        Me.txt_bus_grilla5 = New System.Windows.Forms.TextBox()
        Me.txt_bus_grilla4 = New System.Windows.Forms.TextBox()
        Me.txt_bus_grilla3 = New System.Windows.Forms.TextBox()
        Me.txt_bus_grilla2 = New System.Windows.Forms.TextBox()
        Me.txt_bus_grilla1 = New System.Windows.Forms.TextBox()
        Me.txt_bus_grilla6 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CargarBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerIncobrablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TC1.SuspendLayout()
        Me.TP1.SuspendLayout()
        CType(Me.grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP2.SuspendLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP3.SuspendLayout()
        CType(Me.grilla3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP4.SuspendLayout()
        CType(Me.grilla4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP5.SuspendLayout()
        CType(Me.grilla5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP6.SuspendLayout()
        CType(Me.grilla6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_totales)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_reg)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TC1)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla5)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla4)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla3)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla2)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla1)
        Me.GroupBox1.Controls.Add(Me.txt_bus_grilla6)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1290, 589)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de trabajo"
        '
        'lbl_totales
        '
        Me.lbl_totales.AutoSize = True
        Me.lbl_totales.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbl_totales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_totales.Location = New System.Drawing.Point(443, 542)
        Me.lbl_totales.Name = "lbl_totales"
        Me.lbl_totales.Size = New System.Drawing.Size(69, 16)
        Me.lbl_totales.TabIndex = 8
        Me.lbl_totales.Text = "lbl_totales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(443, 523)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 14)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Totales:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(248, 527)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 14)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Buscar :"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.Location = New System.Drawing.Point(52, 552)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(45, 14)
        Me.lbl_reg.TabIndex = 4
        Me.lbl_reg.Text = "lbl_reg"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 528)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(173, 14)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Nro de Registros Encontrados: "
        '
        'TC1
        '
        Me.TC1.Controls.Add(Me.TP1)
        Me.TC1.Controls.Add(Me.TP2)
        Me.TC1.Controls.Add(Me.TP3)
        Me.TC1.Controls.Add(Me.TP4)
        Me.TC1.Controls.Add(Me.TP5)
        Me.TC1.Controls.Add(Me.TP6)
        Me.TC1.Location = New System.Drawing.Point(15, 21)
        Me.TC1.Name = "TC1"
        Me.TC1.SelectedIndex = 0
        Me.TC1.Size = New System.Drawing.Size(1251, 482)
        Me.TC1.TabIndex = 0
        '
        'TP1
        '
        Me.TP1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP1.Controls.Add(Me.cmd_exp_excel)
        Me.TP1.Controls.Add(Me.cmd_salir1)
        Me.TP1.Controls.Add(Me.cmd_limpiar)
        Me.TP1.Controls.Add(Me.cmd_buscar)
        Me.TP1.Controls.Add(Me.Label6)
        Me.TP1.Controls.Add(Me.msk_fe_fin)
        Me.TP1.Controls.Add(Me.msk_fe_ini)
        Me.TP1.Controls.Add(Me.Label5)
        Me.TP1.Controls.Add(Me.cbo_tipo_bd_tp1)
        Me.TP1.Controls.Add(Me.Label3)
        Me.TP1.Controls.Add(Me.grilla1)
        Me.TP1.Location = New System.Drawing.Point(4, 23)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1.Size = New System.Drawing.Size(1243, 455)
        Me.TP1.TabIndex = 0
        Me.TP1.Text = "Entre Fechas"
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_excel.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel.Location = New System.Drawing.Point(988, 19)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_excel.TabIndex = 54
        Me.cmd_exp_excel.Text = "Exportar Excel"
        Me.cmd_exp_excel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel.UseVisualStyleBackColor = False
        '
        'cmd_salir1
        '
        Me.cmd_salir1.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir1.Location = New System.Drawing.Point(818, 19)
        Me.cmd_salir1.Name = "cmd_salir1"
        Me.cmd_salir1.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir1.TabIndex = 53
        Me.cmd_salir1.Text = "Cancelar"
        Me.cmd_salir1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir1.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(679, 19)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar.TabIndex = 52
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar.Location = New System.Drawing.Point(543, 19)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(91, 47)
        Me.cmd_buscar.TabIndex = 51
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Fecha Final:"
        '
        'msk_fe_fin
        '
        Me.msk_fe_fin.Location = New System.Drawing.Point(411, 43)
        Me.msk_fe_fin.Mask = "0000-00-00"
        Me.msk_fe_fin.Name = "msk_fe_fin"
        Me.msk_fe_fin.Size = New System.Drawing.Size(89, 22)
        Me.msk_fe_fin.TabIndex = 49
        '
        'msk_fe_ini
        '
        Me.msk_fe_ini.Location = New System.Drawing.Point(263, 44)
        Me.msk_fe_ini.Mask = "0000-00-00"
        Me.msk_fe_ini.Name = "msk_fe_ini"
        Me.msk_fe_ini.Size = New System.Drawing.Size(89, 22)
        Me.msk_fe_ini.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Fecha Inicial:"
        '
        'cbo_tipo_bd_tp1
        '
        Me.cbo_tipo_bd_tp1.FormattingEnabled = True
        Me.cbo_tipo_bd_tp1.Location = New System.Drawing.Point(35, 43)
        Me.cbo_tipo_bd_tp1.Name = "cbo_tipo_bd_tp1"
        Me.cbo_tipo_bd_tp1.Size = New System.Drawing.Size(142, 22)
        Me.cbo_tipo_bd_tp1.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Seleccione BD"
        '
        'grilla1
        '
        Me.grilla1.AllowUserToAddRows = False
        Me.grilla1.AllowUserToDeleteRows = False
        Me.grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla1.Location = New System.Drawing.Point(6, 85)
        Me.grilla1.Name = "grilla1"
        Me.grilla1.ReadOnly = True
        Me.grilla1.Size = New System.Drawing.Size(1221, 364)
        Me.grilla1.TabIndex = 0
        '
        'TP2
        '
        Me.TP2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP2.Controls.Add(Me.cmd_exp_exc_grilla2)
        Me.TP2.Controls.Add(Me.cmd_salir2)
        Me.TP2.Controls.Add(Me.cmd_limpiar2)
        Me.TP2.Controls.Add(Me.cmd_bus_may_fecha)
        Me.TP2.Controls.Add(Me.msk_fe_ini2)
        Me.TP2.Controls.Add(Me.Label1)
        Me.TP2.Controls.Add(Me.cbo_tipo_bd_tp2)
        Me.TP2.Controls.Add(Me.Label2)
        Me.TP2.Controls.Add(Me.grilla2)
        Me.TP2.Location = New System.Drawing.Point(4, 23)
        Me.TP2.Name = "TP2"
        Me.TP2.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2.Size = New System.Drawing.Size(1243, 455)
        Me.TP2.TabIndex = 1
        Me.TP2.Text = "Mayor a una Fecha"
        '
        'cmd_exp_exc_grilla2
        '
        Me.cmd_exp_exc_grilla2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_exc_grilla2.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_exc_grilla2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_exc_grilla2.Location = New System.Drawing.Point(831, 14)
        Me.cmd_exp_exc_grilla2.Name = "cmd_exp_exc_grilla2"
        Me.cmd_exp_exc_grilla2.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_exc_grilla2.TabIndex = 57
        Me.cmd_exp_exc_grilla2.Text = "Exportar Excel"
        Me.cmd_exp_exc_grilla2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_exc_grilla2.UseVisualStyleBackColor = False
        '
        'cmd_salir2
        '
        Me.cmd_salir2.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir2.Location = New System.Drawing.Point(661, 14)
        Me.cmd_salir2.Name = "cmd_salir2"
        Me.cmd_salir2.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir2.TabIndex = 56
        Me.cmd_salir2.Text = "Cancelar"
        Me.cmd_salir2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir2.UseVisualStyleBackColor = True
        '
        'cmd_limpiar2
        '
        Me.cmd_limpiar2.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar2.Location = New System.Drawing.Point(522, 14)
        Me.cmd_limpiar2.Name = "cmd_limpiar2"
        Me.cmd_limpiar2.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar2.TabIndex = 55
        Me.cmd_limpiar2.Text = "Limpiar"
        Me.cmd_limpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar2.UseVisualStyleBackColor = True
        '
        'cmd_bus_may_fecha
        '
        Me.cmd_bus_may_fecha.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_may_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_may_fecha.Location = New System.Drawing.Point(385, 14)
        Me.cmd_bus_may_fecha.Name = "cmd_bus_may_fecha"
        Me.cmd_bus_may_fecha.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_may_fecha.TabIndex = 47
        Me.cmd_bus_may_fecha.Text = "Buscar"
        Me.cmd_bus_may_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_may_fecha.UseVisualStyleBackColor = True
        '
        'msk_fe_ini2
        '
        Me.msk_fe_ini2.Location = New System.Drawing.Point(251, 39)
        Me.msk_fe_ini2.Mask = "0000-00-00"
        Me.msk_fe_ini2.Name = "msk_fe_ini2"
        Me.msk_fe_ini2.Size = New System.Drawing.Size(89, 22)
        Me.msk_fe_ini2.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 14)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Mayor a la Fecha:"
        '
        'cbo_tipo_bd_tp2
        '
        Me.cbo_tipo_bd_tp2.FormattingEnabled = True
        Me.cbo_tipo_bd_tp2.Location = New System.Drawing.Point(32, 39)
        Me.cbo_tipo_bd_tp2.Name = "cbo_tipo_bd_tp2"
        Me.cbo_tipo_bd_tp2.Size = New System.Drawing.Size(142, 22)
        Me.cbo_tipo_bd_tp2.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Seleccione BD"
        '
        'grilla2
        '
        Me.grilla2.AllowUserToAddRows = False
        Me.grilla2.AllowUserToDeleteRows = False
        Me.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla2.Location = New System.Drawing.Point(6, 85)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.ReadOnly = True
        Me.grilla2.Size = New System.Drawing.Size(1231, 364)
        Me.grilla2.TabIndex = 1
        '
        'TP3
        '
        Me.TP3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP3.Controls.Add(Me.cmd_exp_exc_grilla3)
        Me.TP3.Controls.Add(Me.cmd_salir3)
        Me.TP3.Controls.Add(Me.cmd_limpiar3)
        Me.TP3.Controls.Add(Me.cmd_bus_men_fecha)
        Me.TP3.Controls.Add(Me.Label4)
        Me.TP3.Controls.Add(Me.msk_fe_ini3)
        Me.TP3.Controls.Add(Me.cbo_tipo_bd_tp3)
        Me.TP3.Controls.Add(Me.Label7)
        Me.TP3.Controls.Add(Me.grilla3)
        Me.TP3.Location = New System.Drawing.Point(4, 23)
        Me.TP3.Name = "TP3"
        Me.TP3.Size = New System.Drawing.Size(1243, 455)
        Me.TP3.TabIndex = 2
        Me.TP3.Text = "Menor a una Fecha"
        '
        'cmd_exp_exc_grilla3
        '
        Me.cmd_exp_exc_grilla3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_exc_grilla3.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_exc_grilla3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_exc_grilla3.Location = New System.Drawing.Point(811, 21)
        Me.cmd_exp_exc_grilla3.Name = "cmd_exp_exc_grilla3"
        Me.cmd_exp_exc_grilla3.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_exc_grilla3.TabIndex = 57
        Me.cmd_exp_exc_grilla3.Text = "Exportar Excel"
        Me.cmd_exp_exc_grilla3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_exc_grilla3.UseVisualStyleBackColor = False
        '
        'cmd_salir3
        '
        Me.cmd_salir3.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir3.Location = New System.Drawing.Point(641, 21)
        Me.cmd_salir3.Name = "cmd_salir3"
        Me.cmd_salir3.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir3.TabIndex = 56
        Me.cmd_salir3.Text = "Cancelar"
        Me.cmd_salir3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir3.UseVisualStyleBackColor = True
        '
        'cmd_limpiar3
        '
        Me.cmd_limpiar3.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar3.Location = New System.Drawing.Point(502, 21)
        Me.cmd_limpiar3.Name = "cmd_limpiar3"
        Me.cmd_limpiar3.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar3.TabIndex = 55
        Me.cmd_limpiar3.Text = "Limpiar"
        Me.cmd_limpiar3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar3.UseVisualStyleBackColor = True
        '
        'cmd_bus_men_fecha
        '
        Me.cmd_bus_men_fecha.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_men_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_men_fecha.Location = New System.Drawing.Point(358, 22)
        Me.cmd_bus_men_fecha.Name = "cmd_bus_men_fecha"
        Me.cmd_bus_men_fecha.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_men_fecha.TabIndex = 49
        Me.cmd_bus_men_fecha.Text = "Buscar"
        Me.cmd_bus_men_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_men_fecha.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 14)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Fecha Final:"
        '
        'msk_fe_ini3
        '
        Me.msk_fe_ini3.Location = New System.Drawing.Point(230, 46)
        Me.msk_fe_ini3.Mask = "0000-00-00"
        Me.msk_fe_ini3.Name = "msk_fe_ini3"
        Me.msk_fe_ini3.Size = New System.Drawing.Size(89, 22)
        Me.msk_fe_ini3.TabIndex = 47
        '
        'cbo_tipo_bd_tp3
        '
        Me.cbo_tipo_bd_tp3.FormattingEnabled = True
        Me.cbo_tipo_bd_tp3.Location = New System.Drawing.Point(29, 47)
        Me.cbo_tipo_bd_tp3.Name = "cbo_tipo_bd_tp3"
        Me.cbo_tipo_bd_tp3.Size = New System.Drawing.Size(142, 22)
        Me.cbo_tipo_bd_tp3.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Seleccione BD"
        '
        'grilla3
        '
        Me.grilla3.AllowUserToAddRows = False
        Me.grilla3.AllowUserToDeleteRows = False
        Me.grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla3.Location = New System.Drawing.Point(3, 88)
        Me.grilla3.Name = "grilla3"
        Me.grilla3.ReadOnly = True
        Me.grilla3.Size = New System.Drawing.Size(1237, 364)
        Me.grilla3.TabIndex = 1
        '
        'TP4
        '
        Me.TP4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP4.Controls.Add(Me.cmd_exp_exc_grilla4)
        Me.TP4.Controls.Add(Me.cmd_salir4)
        Me.TP4.Controls.Add(Me.cmd_limpiar4)
        Me.TP4.Controls.Add(Me.Label8)
        Me.TP4.Controls.Add(Me.txt_rut)
        Me.TP4.Controls.Add(Me.cbo_tipo_bd_tp4)
        Me.TP4.Controls.Add(Me.Label9)
        Me.TP4.Controls.Add(Me.cmd_bus_rut4)
        Me.TP4.Controls.Add(Me.grilla4)
        Me.TP4.Location = New System.Drawing.Point(4, 23)
        Me.TP4.Name = "TP4"
        Me.TP4.Size = New System.Drawing.Size(1243, 455)
        Me.TP4.TabIndex = 3
        Me.TP4.Text = "Por Rut de Cliente"
        '
        'cmd_exp_exc_grilla4
        '
        Me.cmd_exp_exc_grilla4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_exc_grilla4.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_exc_grilla4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_exc_grilla4.Location = New System.Drawing.Point(759, 19)
        Me.cmd_exp_exc_grilla4.Name = "cmd_exp_exc_grilla4"
        Me.cmd_exp_exc_grilla4.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_exc_grilla4.TabIndex = 57
        Me.cmd_exp_exc_grilla4.Text = "Exportar Excel"
        Me.cmd_exp_exc_grilla4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_exc_grilla4.UseVisualStyleBackColor = False
        '
        'cmd_salir4
        '
        Me.cmd_salir4.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir4.Location = New System.Drawing.Point(589, 19)
        Me.cmd_salir4.Name = "cmd_salir4"
        Me.cmd_salir4.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir4.TabIndex = 56
        Me.cmd_salir4.Text = "Cancelar"
        Me.cmd_salir4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir4.UseVisualStyleBackColor = True
        '
        'cmd_limpiar4
        '
        Me.cmd_limpiar4.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar4.Location = New System.Drawing.Point(450, 19)
        Me.cmd_limpiar4.Name = "cmd_limpiar4"
        Me.cmd_limpiar4.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar4.TabIndex = 55
        Me.cmd_limpiar4.Text = "Limpiar"
        Me.cmd_limpiar4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 14)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Rut:"
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(189, 36)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(89, 22)
        Me.txt_rut.TabIndex = 15
        '
        'cbo_tipo_bd_tp4
        '
        Me.cbo_tipo_bd_tp4.FormattingEnabled = True
        Me.cbo_tipo_bd_tp4.Location = New System.Drawing.Point(23, 36)
        Me.cbo_tipo_bd_tp4.Name = "cbo_tipo_bd_tp4"
        Me.cbo_tipo_bd_tp4.Size = New System.Drawing.Size(142, 22)
        Me.cbo_tipo_bd_tp4.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Seleccione BD"
        '
        'cmd_bus_rut4
        '
        Me.cmd_bus_rut4.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_rut4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_rut4.Location = New System.Drawing.Point(321, 19)
        Me.cmd_bus_rut4.Name = "cmd_bus_rut4"
        Me.cmd_bus_rut4.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_rut4.TabIndex = 13
        Me.cmd_bus_rut4.Text = "Buscar"
        Me.cmd_bus_rut4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_rut4.UseVisualStyleBackColor = True
        '
        'grilla4
        '
        Me.grilla4.AllowUserToAddRows = False
        Me.grilla4.AllowUserToDeleteRows = False
        Me.grilla4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla4.Location = New System.Drawing.Point(3, 88)
        Me.grilla4.Name = "grilla4"
        Me.grilla4.ReadOnly = True
        Me.grilla4.Size = New System.Drawing.Size(1237, 364)
        Me.grilla4.TabIndex = 1
        '
        'TP5
        '
        Me.TP5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP5.Controls.Add(Me.cmd_exp_exc_grilla5)
        Me.TP5.Controls.Add(Me.cmd_salir5)
        Me.TP5.Controls.Add(Me.cmd_limpiar5)
        Me.TP5.Controls.Add(Me.lbl_cod_vend)
        Me.TP5.Controls.Add(Me.cbo_vend)
        Me.TP5.Controls.Add(Me.Label10)
        Me.TP5.Controls.Add(Me.cbo_tipo_bd_tp5)
        Me.TP5.Controls.Add(Me.Label11)
        Me.TP5.Controls.Add(Me.cmd_bus_vend5)
        Me.TP5.Controls.Add(Me.grilla5)
        Me.TP5.Location = New System.Drawing.Point(4, 23)
        Me.TP5.Name = "TP5"
        Me.TP5.Size = New System.Drawing.Size(1243, 455)
        Me.TP5.TabIndex = 4
        Me.TP5.Text = "Por Vendedor"
        '
        'cmd_exp_exc_grilla5
        '
        Me.cmd_exp_exc_grilla5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_exc_grilla5.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_exc_grilla5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_exc_grilla5.Location = New System.Drawing.Point(926, 15)
        Me.cmd_exp_exc_grilla5.Name = "cmd_exp_exc_grilla5"
        Me.cmd_exp_exc_grilla5.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_exc_grilla5.TabIndex = 57
        Me.cmd_exp_exc_grilla5.Text = "Exportar Excel"
        Me.cmd_exp_exc_grilla5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_exc_grilla5.UseVisualStyleBackColor = False
        '
        'cmd_salir5
        '
        Me.cmd_salir5.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir5.Location = New System.Drawing.Point(756, 15)
        Me.cmd_salir5.Name = "cmd_salir5"
        Me.cmd_salir5.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir5.TabIndex = 56
        Me.cmd_salir5.Text = "Cancelar"
        Me.cmd_salir5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir5.UseVisualStyleBackColor = True
        '
        'cmd_limpiar5
        '
        Me.cmd_limpiar5.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar5.Location = New System.Drawing.Point(617, 15)
        Me.cmd_limpiar5.Name = "cmd_limpiar5"
        Me.cmd_limpiar5.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar5.TabIndex = 55
        Me.cmd_limpiar5.Text = "Limpiar"
        Me.cmd_limpiar5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar5.UseVisualStyleBackColor = True
        '
        'lbl_cod_vend
        '
        Me.lbl_cod_vend.AutoSize = True
        Me.lbl_cod_vend.Location = New System.Drawing.Point(384, 22)
        Me.lbl_cod_vend.Name = "lbl_cod_vend"
        Me.lbl_cod_vend.Size = New System.Drawing.Size(58, 14)
        Me.lbl_cod_vend.TabIndex = 53
        Me.lbl_cod_vend.Text = "cod_vend"
        '
        'cbo_vend
        '
        Me.cbo_vend.FormattingEnabled = True
        Me.cbo_vend.Location = New System.Drawing.Point(236, 40)
        Me.cbo_vend.Name = "cbo_vend"
        Me.cbo_vend.Size = New System.Drawing.Size(142, 22)
        Me.cbo_vend.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(254, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 14)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Seleccione Vendedor:"
        '
        'cbo_tipo_bd_tp5
        '
        Me.cbo_tipo_bd_tp5.FormattingEnabled = True
        Me.cbo_tipo_bd_tp5.Location = New System.Drawing.Point(43, 40)
        Me.cbo_tipo_bd_tp5.Name = "cbo_tipo_bd_tp5"
        Me.cbo_tipo_bd_tp5.Size = New System.Drawing.Size(142, 22)
        Me.cbo_tipo_bd_tp5.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Seleccione BD"
        '
        'cmd_bus_vend5
        '
        Me.cmd_bus_vend5.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_vend5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_vend5.Location = New System.Drawing.Point(467, 15)
        Me.cmd_bus_vend5.Name = "cmd_bus_vend5"
        Me.cmd_bus_vend5.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_vend5.TabIndex = 49
        Me.cmd_bus_vend5.Text = "Buscar"
        Me.cmd_bus_vend5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_vend5.UseVisualStyleBackColor = True
        '
        'grilla5
        '
        Me.grilla5.AllowUserToAddRows = False
        Me.grilla5.AllowUserToDeleteRows = False
        Me.grilla5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla5.Location = New System.Drawing.Point(3, 88)
        Me.grilla5.Name = "grilla5"
        Me.grilla5.ReadOnly = True
        Me.grilla5.Size = New System.Drawing.Size(1237, 364)
        Me.grilla5.TabIndex = 1
        '
        'TP6
        '
        Me.TP6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP6.Controls.Add(Me.cmd_exp_exc_grilla6)
        Me.TP6.Controls.Add(Me.cmd_salir6)
        Me.TP6.Controls.Add(Me.cmd_limpiar6)
        Me.TP6.Controls.Add(Me.cmd_bus_cuadro_anual6)
        Me.TP6.Controls.Add(Me.Label12)
        Me.TP6.Controls.Add(Me.msk_fe_fin6)
        Me.TP6.Controls.Add(Me.msk_fe_ini6)
        Me.TP6.Controls.Add(Me.Label13)
        Me.TP6.Controls.Add(Me.cbo_tipo_bd_tp6)
        Me.TP6.Controls.Add(Me.Label14)
        Me.TP6.Controls.Add(Me.grilla6)
        Me.TP6.Location = New System.Drawing.Point(4, 23)
        Me.TP6.Name = "TP6"
        Me.TP6.Size = New System.Drawing.Size(1243, 455)
        Me.TP6.TabIndex = 5
        Me.TP6.Text = "Cuadro Anual"
        '
        'cmd_exp_exc_grilla6
        '
        Me.cmd_exp_exc_grilla6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exp_exc_grilla6.Image = Global.AuxCobEckart.My.Resources.Resources.excel_imports
        Me.cmd_exp_exc_grilla6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_exc_grilla6.Location = New System.Drawing.Point(925, 18)
        Me.cmd_exp_exc_grilla6.Name = "cmd_exp_exc_grilla6"
        Me.cmd_exp_exc_grilla6.Size = New System.Drawing.Size(134, 47)
        Me.cmd_exp_exc_grilla6.TabIndex = 61
        Me.cmd_exp_exc_grilla6.Text = "Exportar Excel"
        Me.cmd_exp_exc_grilla6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_exc_grilla6.UseVisualStyleBackColor = False
        '
        'cmd_salir6
        '
        Me.cmd_salir6.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_salir6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir6.Location = New System.Drawing.Point(755, 18)
        Me.cmd_salir6.Name = "cmd_salir6"
        Me.cmd_salir6.Size = New System.Drawing.Size(95, 47)
        Me.cmd_salir6.TabIndex = 60
        Me.cmd_salir6.Text = "Cancelar"
        Me.cmd_salir6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir6.UseVisualStyleBackColor = True
        '
        'cmd_limpiar6
        '
        Me.cmd_limpiar6.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar6.Location = New System.Drawing.Point(603, 18)
        Me.cmd_limpiar6.Name = "cmd_limpiar6"
        Me.cmd_limpiar6.Size = New System.Drawing.Size(91, 47)
        Me.cmd_limpiar6.TabIndex = 59
        Me.cmd_limpiar6.Text = "Limpiar"
        Me.cmd_limpiar6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar6.UseVisualStyleBackColor = True
        '
        'cmd_bus_cuadro_anual6
        '
        Me.cmd_bus_cuadro_anual6.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_bus_cuadro_anual6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_bus_cuadro_anual6.Location = New System.Drawing.Point(466, 18)
        Me.cmd_bus_cuadro_anual6.Name = "cmd_bus_cuadro_anual6"
        Me.cmd_bus_cuadro_anual6.Size = New System.Drawing.Size(91, 47)
        Me.cmd_bus_cuadro_anual6.TabIndex = 58
        Me.cmd_bus_cuadro_anual6.Text = "Buscar"
        Me.cmd_bus_cuadro_anual6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_bus_cuadro_anual6.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(343, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 14)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Fecha Final:"
        '
        'msk_fe_fin6
        '
        Me.msk_fe_fin6.Location = New System.Drawing.Point(337, 43)
        Me.msk_fe_fin6.Mask = "0000-00-00"
        Me.msk_fe_fin6.Name = "msk_fe_fin6"
        Me.msk_fe_fin6.Size = New System.Drawing.Size(89, 22)
        Me.msk_fe_fin6.TabIndex = 49
        '
        'msk_fe_ini6
        '
        Me.msk_fe_ini6.Location = New System.Drawing.Point(218, 43)
        Me.msk_fe_ini6.Mask = "0000-00-00"
        Me.msk_fe_ini6.Name = "msk_fe_ini6"
        Me.msk_fe_ini6.Size = New System.Drawing.Size(89, 22)
        Me.msk_fe_ini6.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(226, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 14)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Fecha Inicial:"
        '
        'cbo_tipo_bd_tp6
        '
        Me.cbo_tipo_bd_tp6.FormattingEnabled = True
        Me.cbo_tipo_bd_tp6.Location = New System.Drawing.Point(42, 43)
        Me.cbo_tipo_bd_tp6.Name = "cbo_tipo_bd_tp6"
        Me.cbo_tipo_bd_tp6.Size = New System.Drawing.Size(142, 22)
        Me.cbo_tipo_bd_tp6.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(51, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 14)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Seleccione BD"
        '
        'grilla6
        '
        Me.grilla6.AllowUserToAddRows = False
        Me.grilla6.AllowUserToDeleteRows = False
        Me.grilla6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla6.Location = New System.Drawing.Point(3, 88)
        Me.grilla6.Name = "grilla6"
        Me.grilla6.ReadOnly = True
        Me.grilla6.Size = New System.Drawing.Size(1237, 364)
        Me.grilla6.TabIndex = 1
        '
        'txt_bus_grilla5
        '
        Me.txt_bus_grilla5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bus_grilla5.Location = New System.Drawing.Point(229, 544)
        Me.txt_bus_grilla5.Name = "txt_bus_grilla5"
        Me.txt_bus_grilla5.Size = New System.Drawing.Size(142, 22)
        Me.txt_bus_grilla5.TabIndex = 12
        '
        'txt_bus_grilla4
        '
        Me.txt_bus_grilla4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bus_grilla4.Location = New System.Drawing.Point(229, 544)
        Me.txt_bus_grilla4.Name = "txt_bus_grilla4"
        Me.txt_bus_grilla4.Size = New System.Drawing.Size(142, 22)
        Me.txt_bus_grilla4.TabIndex = 11
        '
        'txt_bus_grilla3
        '
        Me.txt_bus_grilla3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bus_grilla3.Location = New System.Drawing.Point(229, 544)
        Me.txt_bus_grilla3.Name = "txt_bus_grilla3"
        Me.txt_bus_grilla3.Size = New System.Drawing.Size(142, 22)
        Me.txt_bus_grilla3.TabIndex = 10
        '
        'txt_bus_grilla2
        '
        Me.txt_bus_grilla2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bus_grilla2.Location = New System.Drawing.Point(229, 544)
        Me.txt_bus_grilla2.Name = "txt_bus_grilla2"
        Me.txt_bus_grilla2.Size = New System.Drawing.Size(142, 22)
        Me.txt_bus_grilla2.TabIndex = 9
        '
        'txt_bus_grilla1
        '
        Me.txt_bus_grilla1.Location = New System.Drawing.Point(229, 544)
        Me.txt_bus_grilla1.Name = "txt_bus_grilla1"
        Me.txt_bus_grilla1.Size = New System.Drawing.Size(142, 22)
        Me.txt_bus_grilla1.TabIndex = 6
        '
        'txt_bus_grilla6
        '
        Me.txt_bus_grilla6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_bus_grilla6.Location = New System.Drawing.Point(229, 544)
        Me.txt_bus_grilla6.Name = "txt_bus_grilla6"
        Me.txt_bus_grilla6.Size = New System.Drawing.Size(142, 22)
        Me.txt_bus_grilla6.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1336, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ToolStripMenuItem1, Me.VendedoresToolStripMenuItem, Me.ToolStripMenuItem2, Me.CargarBaseToolStripMenuItem, Me.ToolStripMenuItem3, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        'CargarBaseToolStripMenuItem
        '
        Me.CargarBaseToolStripMenuItem.Name = "CargarBaseToolStripMenuItem"
        Me.CargarBaseToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CargarBaseToolStripMenuItem.Text = "Cargar Base"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerIncobrablesToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'VerIncobrablesToolStripMenuItem
        '
        Me.VerIncobrablesToolStripMenuItem.Name = "VerIncobrablesToolStripMenuItem"
        Me.VerIncobrablesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.VerIncobrablesToolStripMenuItem.Text = "Ver Incobrables"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(12, 661)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(68, 14)
        Me.lbl_version.TabIndex = 2
        Me.lbl_version.Text = "lbl_version"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_menu"
        Me.Text = "frm_menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TC1.ResumeLayout(False)
        Me.TP1.ResumeLayout(False)
        Me.TP1.PerformLayout()
        CType(Me.grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP2.ResumeLayout(False)
        Me.TP2.PerformLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP3.ResumeLayout(False)
        Me.TP3.PerformLayout()
        CType(Me.grilla3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP4.ResumeLayout(False)
        Me.TP4.PerformLayout()
        CType(Me.grilla4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP5.ResumeLayout(False)
        Me.TP5.PerformLayout()
        CType(Me.grilla5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP6.ResumeLayout(False)
        Me.TP6.PerformLayout()
        CType(Me.grilla6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents CargarBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerIncobrablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TC1 As TabControl
    Friend WithEvents TP1 As TabPage
    Friend WithEvents TP2 As TabPage
    Friend WithEvents TP3 As TabPage
    Friend WithEvents TP4 As TabPage
    Friend WithEvents TP5 As TabPage
    Friend WithEvents TP6 As TabPage
    Friend WithEvents lbl_version As Label
    Friend WithEvents grilla1 As DataGridView
    Friend WithEvents grilla2 As DataGridView
    Friend WithEvents grilla3 As DataGridView
    Friend WithEvents grilla4 As DataGridView
    Friend WithEvents grilla5 As DataGridView
    Friend WithEvents grilla6 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents msk_fe_fin As MaskedTextBox
    Friend WithEvents msk_fe_ini As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbo_tipo_bd_tp1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents msk_fe_ini2 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_tipo_bd_tp2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_bus_may_fecha As Button
    Friend WithEvents cmd_bus_men_fecha As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents msk_fe_ini3 As MaskedTextBox
    Friend WithEvents cbo_tipo_bd_tp3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_rut As TextBox
    Friend WithEvents cbo_tipo_bd_tp4 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmd_bus_rut4 As Button
    Friend WithEvents lbl_cod_vend As Label
    Friend WithEvents cbo_vend As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_tipo_bd_tp5 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmd_bus_vend5 As Button
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_salir1 As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_exp_exc_grilla2 As Button
    Friend WithEvents cmd_salir2 As Button
    Friend WithEvents cmd_limpiar2 As Button
    Friend WithEvents cmd_exp_exc_grilla3 As Button
    Friend WithEvents cmd_salir3 As Button
    Friend WithEvents cmd_limpiar3 As Button
    Friend WithEvents cmd_exp_exc_grilla4 As Button
    Friend WithEvents cmd_salir4 As Button
    Friend WithEvents cmd_limpiar4 As Button
    Friend WithEvents cmd_exp_exc_grilla5 As Button
    Friend WithEvents cmd_salir5 As Button
    Friend WithEvents cmd_limpiar5 As Button
    Friend WithEvents cmd_exp_exc_grilla6 As Button
    Friend WithEvents cmd_salir6 As Button
    Friend WithEvents cmd_limpiar6 As Button
    Friend WithEvents cmd_bus_cuadro_anual6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents msk_fe_fin6 As MaskedTextBox
    Friend WithEvents msk_fe_ini6 As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbo_tipo_bd_tp6 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_bus_grilla1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_bus_grilla2 As TextBox
    Friend WithEvents txt_bus_grilla6 As TextBox
    Friend WithEvents txt_bus_grilla5 As TextBox
    Friend WithEvents txt_bus_grilla4 As TextBox
    Friend WithEvents txt_bus_grilla3 As TextBox
    Friend WithEvents lbl_totales As Label
    Friend WithEvents Label17 As Label
End Class
