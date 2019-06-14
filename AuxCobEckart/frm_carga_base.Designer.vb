<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_carga_base
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_carga_base))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_instrucciones = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_tpo = New System.Windows.Forms.ComboBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_truncate_bd = New System.Windows.Forms.Button()
        Me.cmd_cargar_access = New System.Windows.Forms.Button()
        Me.cmd_cargar_mysql = New System.Windows.Forms.Button()
        Me.cmd_cargar_datos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_cartel = New System.Windows.Forms.Label()
        Me.lbl_traspaso = New System.Windows.Forms.Label()
        Me.lbl_nroreg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_instrucciones)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbo_tpo)
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_truncate_bd)
        Me.GroupBox1.Controls.Add(Me.cmd_cargar_access)
        Me.GroupBox1.Controls.Add(Me.cmd_cargar_mysql)
        Me.GroupBox1.Controls.Add(Me.cmd_cargar_datos)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cargar Datos Base"
        '
        'cmd_instrucciones
        '
        Me.cmd_instrucciones.Location = New System.Drawing.Point(699, 30)
        Me.cmd_instrucciones.Name = "cmd_instrucciones"
        Me.cmd_instrucciones.Size = New System.Drawing.Size(91, 39)
        Me.cmd_instrucciones.TabIndex = 26
        Me.cmd_instrucciones.Text = "Instrucciones"
        Me.cmd_instrucciones.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Seleccione tipo de Base de Datos"
        '
        'cbo_tpo
        '
        Me.cbo_tpo.FormattingEnabled = True
        Me.cbo_tpo.Location = New System.Drawing.Point(45, 45)
        Me.cbo_tpo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_tpo.Name = "cbo_tpo"
        Me.cbo_tpo.Size = New System.Drawing.Size(112, 21)
        Me.cbo_tpo.TabIndex = 24
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(840, 30)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(91, 39)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_truncate_bd
        '
        Me.cmd_truncate_bd.Location = New System.Drawing.Point(583, 28)
        Me.cmd_truncate_bd.Name = "cmd_truncate_bd"
        Me.cmd_truncate_bd.Size = New System.Drawing.Size(91, 43)
        Me.cmd_truncate_bd.TabIndex = 3
        Me.cmd_truncate_bd.Text = "Limpiar Tabla de Datos"
        Me.cmd_truncate_bd.UseVisualStyleBackColor = True
        '
        'cmd_cargar_access
        '
        Me.cmd_cargar_access.Location = New System.Drawing.Point(230, 57)
        Me.cmd_cargar_access.Name = "cmd_cargar_access"
        Me.cmd_cargar_access.Size = New System.Drawing.Size(104, 23)
        Me.cmd_cargar_access.TabIndex = 2
        Me.cmd_cargar_access.Text = "Cargar Access"
        Me.cmd_cargar_access.UseVisualStyleBackColor = True
        Me.cmd_cargar_access.Visible = False
        '
        'cmd_cargar_mysql
        '
        Me.cmd_cargar_mysql.Location = New System.Drawing.Point(395, 33)
        Me.cmd_cargar_mysql.Name = "cmd_cargar_mysql"
        Me.cmd_cargar_mysql.Size = New System.Drawing.Size(104, 23)
        Me.cmd_cargar_mysql.TabIndex = 1
        Me.cmd_cargar_mysql.Text = "Cargar Mysql"
        Me.cmd_cargar_mysql.UseVisualStyleBackColor = True
        '
        'cmd_cargar_datos
        '
        Me.cmd_cargar_datos.Location = New System.Drawing.Point(230, 32)
        Me.cmd_cargar_datos.Name = "cmd_cargar_datos"
        Me.cmd_cargar_datos.Size = New System.Drawing.Size(132, 24)
        Me.cmd_cargar_datos.TabIndex = 0
        Me.cmd_cargar_datos.Text = "Seleccionar Archivo"
        Me.cmd_cargar_datos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_cartel)
        Me.GroupBox2.Controls.Add(Me.lbl_traspaso)
        Me.GroupBox2.Controls.Add(Me.lbl_nroreg)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1014, 331)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos a Cargar"
        '
        'lbl_cartel
        '
        Me.lbl_cartel.AutoSize = True
        Me.lbl_cartel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_cartel.Location = New System.Drawing.Point(766, 299)
        Me.lbl_cartel.Name = "lbl_cartel"
        Me.lbl_cartel.Size = New System.Drawing.Size(228, 13)
        Me.lbl_cartel.TabIndex = 3
        Me.lbl_cartel.Text = "FAVOR ESPERE....TRASPASANDO DATOS.."
        '
        'lbl_traspaso
        '
        Me.lbl_traspaso.AutoSize = True
        Me.lbl_traspaso.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_traspaso.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_traspaso.Location = New System.Drawing.Point(551, 297)
        Me.lbl_traspaso.Name = "lbl_traspaso"
        Me.lbl_traspaso.Size = New System.Drawing.Size(43, 15)
        Me.lbl_traspaso.TabIndex = 3
        Me.lbl_traspaso.Text = "Label4"
        '
        'lbl_nroreg
        '
        Me.lbl_nroreg.AutoSize = True
        Me.lbl_nroreg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nroreg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nroreg.Location = New System.Drawing.Point(96, 298)
        Me.lbl_nroreg.Name = "lbl_nroreg"
        Me.lbl_nroreg.Size = New System.Drawing.Size(2, 15)
        Me.lbl_nroreg.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro Registros:"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(13, 26)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(995, 242)
        Me.grilla.TabIndex = 0
        '
        'frm_carga_base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1057, 490)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_carga_base"
        Me.Text = "frm_carga_base"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_cargar_datos As Button
    Friend WithEvents cmd_cargar_mysql As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents cmd_cargar_access As Button
    Friend WithEvents lbl_cartel As Label
    Friend WithEvents lbl_traspaso As Label
    Friend WithEvents lbl_nroreg As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_truncate_bd As Button
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_tpo As ComboBox
    Friend WithEvents cmd_instrucciones As Button
End Class
