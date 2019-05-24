<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuadro_anual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cuadro_anual))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cartel = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_anio = New System.Windows.Forms.ComboBox()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_monto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_cartel)
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_anio)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1178, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de Carga"
        '
        'lbl_cartel
        '
        Me.lbl_cartel.AutoSize = True
        Me.lbl_cartel.Location = New System.Drawing.Point(768, 45)
        Me.lbl_cartel.Name = "lbl_cartel"
        Me.lbl_cartel.Size = New System.Drawing.Size(57, 15)
        Me.lbl_cartel.TabIndex = 6
        Me.lbl_cartel.Text = "lbl_cartel"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.AuxCobEckart.My.Resources.Resources.cancel
        Me.cmd_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancelar.Location = New System.Drawing.Point(564, 38)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(126, 40)
        Me.cmd_cancelar.TabIndex = 5
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.AuxCobEckart.My.Resources.Resources.textfield_clear
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(357, 38)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(126, 40)
        Me.cmd_limpiar.TabIndex = 4
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.Image = Global.AuxCobEckart.My.Resources.Resources.export_excel
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmd_exp_excel.Location = New System.Drawing.Point(986, 38)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(125, 41)
        Me.cmd_exp_excel.TabIndex = 3
        Me.cmd_exp_excel.Text = "Exp. Excel"
        Me.cmd_exp_excel.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.AuxCobEckart.My.Resources.Resources.search_plus
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar.Location = New System.Drawing.Point(164, 37)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(125, 42)
        Me.cmd_buscar.TabIndex = 2
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione Año:"
        '
        'cbo_anio
        '
        Me.cbo_anio.FormattingEnabled = True
        Me.cbo_anio.Location = New System.Drawing.Point(29, 48)
        Me.cbo_anio.Name = "cbo_anio"
        Me.cbo_anio.Size = New System.Drawing.Size(110, 23)
        Me.cbo_anio.TabIndex = 0
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(25, 517)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(65, 15)
        Me.lbl_version.TabIndex = 5
        Me.lbl_version.Text = "lbl_version"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_monto)
        Me.GroupBox2.Controls.Add(Me.lbl_version)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_reg)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1219, 540)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Anual"
        '
        'lbl_monto
        '
        Me.lbl_monto.AutoSize = True
        Me.lbl_monto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_monto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_monto.Location = New System.Drawing.Point(1075, 545)
        Me.lbl_monto.Name = "lbl_monto"
        Me.lbl_monto.Size = New System.Drawing.Size(64, 17)
        Me.lbl_monto.TabIndex = 67
        Me.lbl_monto.Text = "lbl_monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1039, 517)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Total Monto de Cobranza"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_reg.Location = New System.Drawing.Point(138, 462)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(46, 17)
        Me.lbl_reg.TabIndex = 65
        Me.lbl_reg.Text = "lbl_reg"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 464)
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
        Me.grilla.Size = New System.Drawing.Size(1207, 428)
        Me.grilla.TabIndex = 0
        '
        'frm_cuadro_anual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1243, 697)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_cuadro_anual"
        Me.Text = "frm_cuadro_anual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_anio As ComboBox
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents lbl_version As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_monto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents lbl_cartel As Label
End Class
