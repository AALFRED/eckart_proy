<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parametros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_id_user = New System.Windows.Forms.Label()
        Me.cmd_actualiza = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.ch_bloqueo = New System.Windows.Forms.CheckBox()
        Me.cmd_grabar_usr = New System.Windows.Forms.Button()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.cbo_perfil = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_asig_perfil = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_usuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmd_grabar_perfil = New System.Windows.Forms.Button()
        Me.txt_perfil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_id_user)
        Me.GroupBox1.Controls.Add(Me.cmd_actualiza)
        Me.GroupBox1.Controls.Add(Me.cmd_eliminar)
        Me.GroupBox1.Controls.Add(Me.ch_bloqueo)
        Me.GroupBox1.Controls.Add(Me.cmd_grabar_usr)
        Me.GroupBox1.Controls.Add(Me.txt_pass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_user)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'lbl_id_user
        '
        Me.lbl_id_user.AutoSize = True
        Me.lbl_id_user.Location = New System.Drawing.Point(26, 22)
        Me.lbl_id_user.Name = "lbl_id_user"
        Me.lbl_id_user.Size = New System.Drawing.Size(69, 15)
        Me.lbl_id_user.TabIndex = 9
        Me.lbl_id_user.Text = "lbl_id_user"
        '
        'cmd_actualiza
        '
        Me.cmd_actualiza.Location = New System.Drawing.Point(244, 40)
        Me.cmd_actualiza.Name = "cmd_actualiza"
        Me.cmd_actualiza.Size = New System.Drawing.Size(75, 22)
        Me.cmd_actualiza.TabIndex = 8
        Me.cmd_actualiza.Text = "Actualiza"
        Me.cmd_actualiza.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Location = New System.Drawing.Point(244, 68)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmd_eliminar.TabIndex = 7
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'ch_bloqueo
        '
        Me.ch_bloqueo.AutoSize = True
        Me.ch_bloqueo.Location = New System.Drawing.Point(228, 96)
        Me.ch_bloqueo.Name = "ch_bloqueo"
        Me.ch_bloqueo.Size = New System.Drawing.Size(76, 19)
        Me.ch_bloqueo.TabIndex = 6
        Me.ch_bloqueo.Text = "Bloquear"
        Me.ch_bloqueo.UseVisualStyleBackColor = True
        '
        'cmd_grabar_usr
        '
        Me.cmd_grabar_usr.Location = New System.Drawing.Point(244, 40)
        Me.cmd_grabar_usr.Name = "cmd_grabar_usr"
        Me.cmd_grabar_usr.Size = New System.Drawing.Size(75, 22)
        Me.cmd_grabar_usr.TabIndex = 5
        Me.cmd_grabar_usr.Text = "Grabar"
        Me.cmd_grabar_usr.UseVisualStyleBackColor = True
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(100, 73)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(112, 23)
        Me.txt_pass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USUARIO"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(100, 44)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(112, 23)
        Me.txt_user.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREAR USUARIO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_id)
        Me.GroupBox2.Controls.Add(Me.cbo_perfil)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmd_asig_perfil)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbo_usuario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 106)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asignar Perfil"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(250, 81)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(39, 15)
        Me.lbl_id.TabIndex = 7
        Me.lbl_id.Text = "lbl_id"
        Me.lbl_id.Visible = False
        '
        'cbo_perfil
        '
        Me.cbo_perfil.FormattingEnabled = True
        Me.cbo_perfil.Location = New System.Drawing.Point(92, 66)
        Me.cbo_perfil.Name = "cbo_perfil"
        Me.cbo_perfil.Size = New System.Drawing.Size(138, 23)
        Me.cbo_perfil.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Perfil:"
        '
        'cmd_asig_perfil
        '
        Me.cmd_asig_perfil.Location = New System.Drawing.Point(247, 45)
        Me.cmd_asig_perfil.Name = "cmd_asig_perfil"
        Me.cmd_asig_perfil.Size = New System.Drawing.Size(72, 25)
        Me.cmd_asig_perfil.TabIndex = 4
        Me.cmd_asig_perfil.Text = "Asignar"
        Me.cmd_asig_perfil.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuarios:"
        '
        'cbo_usuario
        '
        Me.cbo_usuario.FormattingEnabled = True
        Me.cbo_usuario.Location = New System.Drawing.Point(92, 31)
        Me.cbo_usuario.Name = "cbo_usuario"
        Me.cbo_usuario.Size = New System.Drawing.Size(138, 23)
        Me.cbo_usuario.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grilla)
        Me.GroupBox3.Location = New System.Drawing.Point(374, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 179)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado Usuarios"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(6, 20)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(382, 153)
        Me.grilla.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmd_grabar_perfil)
        Me.GroupBox4.Controls.Add(Me.txt_perfil)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(377, 197)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(396, 87)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Crear Perfil"
        '
        'cmd_grabar_perfil
        '
        Me.cmd_grabar_perfil.Location = New System.Drawing.Point(264, 34)
        Me.cmd_grabar_perfil.Name = "cmd_grabar_perfil"
        Me.cmd_grabar_perfil.Size = New System.Drawing.Size(77, 23)
        Me.cmd_grabar_perfil.TabIndex = 2
        Me.cmd_grabar_perfil.Text = "Grabar"
        Me.cmd_grabar_perfil.UseVisualStyleBackColor = True
        '
        'txt_perfil
        '
        Me.txt_perfil.Location = New System.Drawing.Point(119, 33)
        Me.txt_perfil.Name = "txt_perfil"
        Me.txt_perfil.Size = New System.Drawing.Size(111, 23)
        Me.txt_perfil.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nuevo Perfil :"
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(789, 315)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Parametros"
        Me.Text = "Parametros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_grabar_usr As Button
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbo_usuario As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents cbo_perfil As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmd_asig_perfil As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmd_grabar_perfil As Button
    Friend WithEvents txt_perfil As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents cmd_eliminar As Button
    Friend WithEvents ch_bloqueo As CheckBox
    Friend WithEvents cmd_actualiza As Button
    Friend WithEvents lbl_id_user As Label
End Class
