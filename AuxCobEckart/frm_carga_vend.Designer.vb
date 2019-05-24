<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_carga_vend
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_ver_reg = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_cargar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_seleccion_file = New System.Windows.Forms.Button()
        Me.lbl_nroreg = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.cbo_tpo = New System.Windows.Forms.ComboBox()
        Me.cmd_quitar = New System.Windows.Forms.Button()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.txt_relacCom = New System.Windows.Forms.TextBox()
        Me.txt_movil = New System.Windows.Forms.TextBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_com = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_cod_vend = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_ver_reg)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_cargar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmd_seleccion_file)
        Me.GroupBox1.Controls.Add(Me.lbl_nroreg)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.grilla)
        Me.GroupBox1.Controls.Add(Me.cbo_tpo)
        Me.GroupBox1.Controls.Add(Me.cmd_quitar)
        Me.GroupBox1.Controls.Add(Me.cmd_agregar)
        Me.GroupBox1.Controls.Add(Me.txt_relacCom)
        Me.GroupBox1.Controls.Add(Me.txt_movil)
        Me.GroupBox1.Controls.Add(Me.txt_pais)
        Me.GroupBox1.Controls.Add(Me.txt_ciudad)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_com)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_cod_vend)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(23, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(996, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Vendedor"
        '
        'cmd_ver_reg
        '
        Me.cmd_ver_reg.Location = New System.Drawing.Point(835, 351)
        Me.cmd_ver_reg.Name = "cmd_ver_reg"
        Me.cmd_ver_reg.Size = New System.Drawing.Size(111, 23)
        Me.cmd_ver_reg.TabIndex = 26
        Me.cmd_ver_reg.Text = "Ver Registros"
        Me.cmd_ver_reg.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(521, 115)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(64, 27)
        Me.cmd_limpiar.TabIndex = 25
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_cargar
        '
        Me.cmd_cargar.Location = New System.Drawing.Point(831, 84)
        Me.cmd_cargar.Name = "cmd_cargar"
        Me.cmd_cargar.Size = New System.Drawing.Size(115, 37)
        Me.cmd_cargar.TabIndex = 24
        Me.cmd_cargar.Text = "Cargar Datos"
        Me.cmd_cargar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(612, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 15)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Seleccione tipo de Base de Datos"
        '
        'cmd_seleccion_file
        '
        Me.cmd_seleccion_file.Location = New System.Drawing.Point(640, 82)
        Me.cmd_seleccion_file.Name = "cmd_seleccion_file"
        Me.cmd_seleccion_file.Size = New System.Drawing.Size(145, 37)
        Me.cmd_seleccion_file.TabIndex = 22
        Me.cmd_seleccion_file.Text = "Seleccione Archivo...."
        Me.cmd_seleccion_file.UseVisualStyleBackColor = True
        '
        'lbl_nroreg
        '
        Me.lbl_nroreg.AutoSize = True
        Me.lbl_nroreg.Location = New System.Drawing.Point(79, 360)
        Me.lbl_nroreg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nroreg.Name = "lbl_nroreg"
        Me.lbl_nroreg.Size = New System.Drawing.Size(63, 15)
        Me.lbl_nroreg.TabIndex = 21
        Me.lbl_nroreg.Text = "lbl_nroreg"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 360)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nro Reg:"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(12, 152)
        Me.grilla.Margin = New System.Windows.Forms.Padding(2)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(947, 184)
        Me.grilla.TabIndex = 19
        '
        'cbo_tpo
        '
        Me.cbo_tpo.FormattingEnabled = True
        Me.cbo_tpo.Location = New System.Drawing.Point(640, 42)
        Me.cbo_tpo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_tpo.Name = "cbo_tpo"
        Me.cbo_tpo.Size = New System.Drawing.Size(118, 23)
        Me.cbo_tpo.TabIndex = 18
        '
        'cmd_quitar
        '
        Me.cmd_quitar.Location = New System.Drawing.Point(439, 115)
        Me.cmd_quitar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_quitar.Name = "cmd_quitar"
        Me.cmd_quitar.Size = New System.Drawing.Size(64, 27)
        Me.cmd_quitar.TabIndex = 17
        Me.cmd_quitar.Text = "Quitar"
        Me.cmd_quitar.UseVisualStyleBackColor = True
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(357, 115)
        Me.cmd_agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(64, 27)
        Me.cmd_agregar.TabIndex = 16
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'txt_relacCom
        '
        Me.txt_relacCom.Location = New System.Drawing.Point(218, 121)
        Me.txt_relacCom.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_relacCom.Name = "txt_relacCom"
        Me.txt_relacCom.Size = New System.Drawing.Size(90, 21)
        Me.txt_relacCom.TabIndex = 15
        '
        'txt_movil
        '
        Me.txt_movil.Location = New System.Drawing.Point(121, 121)
        Me.txt_movil.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_movil.Name = "txt_movil"
        Me.txt_movil.Size = New System.Drawing.Size(66, 21)
        Me.txt_movil.TabIndex = 14
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(30, 121)
        Me.txt_pais.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(62, 21)
        Me.txt_pais.TabIndex = 13
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(474, 66)
        Me.txt_ciudad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(100, 21)
        Me.txt_ciudad.TabIndex = 12
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(357, 66)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(82, 21)
        Me.txt_telefono.TabIndex = 11
        '
        'txt_com
        '
        Me.txt_com.Location = New System.Drawing.Point(283, 66)
        Me.txt_com.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_com.Name = "txt_com"
        Me.txt_com.Size = New System.Drawing.Size(46, 21)
        Me.txt_com.TabIndex = 10
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(96, 66)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(168, 21)
        Me.txt_nombre.TabIndex = 9
        '
        'txt_cod_vend
        '
        Me.txt_cod_vend.Location = New System.Drawing.Point(30, 66)
        Me.txt_cod_vend.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cod_vend.Name = "txt_cod_vend"
        Me.txt_cod_vend.Size = New System.Drawing.Size(46, 21)
        Me.txt_cod_vend.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Relac-Comerc"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nro  movil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 104)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(518, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comision"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod_vend"
        '
        'frm_carga_vend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frm_carga_vend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_carga_vend"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grilla As DataGridView
    Friend WithEvents cbo_tpo As ComboBox
    Friend WithEvents cmd_quitar As Button
    Friend WithEvents cmd_agregar As Button
    Friend WithEvents txt_relacCom As TextBox
    Friend WithEvents txt_movil As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_ciudad As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_com As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_cod_vend As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_nroreg As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmd_seleccion_file As Button
    Friend WithEvents cmd_cargar As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_ver_reg As Button
End Class
