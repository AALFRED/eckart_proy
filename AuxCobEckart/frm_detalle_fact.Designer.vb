<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detalle_fact
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
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.grilla_det = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_salir)
        Me.GroupBox1.Controls.Add(Me.lbl_cliente)
        Me.GroupBox1.Controls.Add(Me.lbl_rut)
        Me.GroupBox1.Controls.Add(Me.grilla_det)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1311, 687)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Facturas"
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.Location = New System.Drawing.Point(857, 22)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(89, 28)
        Me.cmd_exp_excel.TabIndex = 6
        Me.cmd_exp_excel.Text = "exp Excel"
        Me.cmd_exp_excel.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(975, 22)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(92, 27)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cliente.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cliente.Location = New System.Drawing.Point(343, 35)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(45, 17)
        Me.lbl_cliente.TabIndex = 4
        Me.lbl_cliente.Text = "Label4"
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_rut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rut.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rut.Location = New System.Drawing.Point(109, 35)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(45, 17)
        Me.lbl_rut.TabIndex = 3
        Me.lbl_rut.Text = "Label3"
        '
        'grilla_det
        '
        Me.grilla_det.AllowUserToAddRows = False
        Me.grilla_det.AllowUserToDeleteRows = False
        Me.grilla_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_det.Location = New System.Drawing.Point(18, 78)
        Me.grilla_det.Name = "grilla_det"
        Me.grilla_det.ReadOnly = True
        Me.grilla_det.Size = New System.Drawing.Size(1272, 535)
        Me.grilla_det.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(220, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Cliente :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut Cliente:"
        '
        'frm_detalle_fact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1372, 767)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frm_detalle_fact"
        Me.Text = "frm_detalle_fact"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grilla_det As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_salir As Button
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_rut As Label
End Class
