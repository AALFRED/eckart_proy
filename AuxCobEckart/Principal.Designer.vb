﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_cuadro_anual = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_det_deuda_clie = New System.Windows.Forms.Button()
        Me.cmd_det_vend_clte = New System.Windows.Forms.Button()
        Me.cmd_tramos_vcto = New System.Windows.Forms.Button()
        Me.cmd_saldos_vend = New System.Windows.Forms.Button()
        Me.cmd_saldo_atrasado = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_cuadro_anual)
        Me.GroupBox1.Controls.Add(Me.cmd_salir)
        Me.GroupBox1.Controls.Add(Me.cmd_det_deuda_clie)
        Me.GroupBox1.Controls.Add(Me.cmd_det_vend_clte)
        Me.GroupBox1.Controls.Add(Me.cmd_tramos_vcto)
        Me.GroupBox1.Controls.Add(Me.cmd_saldos_vend)
        Me.GroupBox1.Controls.Add(Me.cmd_saldo_atrasado)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 409)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pantalla Principal"
        '
        'cmd_cuadro_anual
        '
        Me.cmd_cuadro_anual.Location = New System.Drawing.Point(456, 213)
        Me.cmd_cuadro_anual.Name = "cmd_cuadro_anual"
        Me.cmd_cuadro_anual.Size = New System.Drawing.Size(169, 52)
        Me.cmd_cuadro_anual.TabIndex = 6
        Me.cmd_cuadro_anual.Text = "Cuadro Anual"
        Me.ToolTip1.SetToolTip(Me.cmd_cuadro_anual, "Fecha de Vencimiento menos fecha actual")
        Me.cmd_cuadro_anual.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(687, 105)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(169, 52)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.Text = "Salir de la Aplicación"
        Me.ToolTip1.SetToolTip(Me.cmd_salir, "Fecha de Vencimiento menos fecha actual")
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_det_deuda_clie
        '
        Me.cmd_det_deuda_clie.Location = New System.Drawing.Point(250, 323)
        Me.cmd_det_deuda_clie.Name = "cmd_det_deuda_clie"
        Me.cmd_det_deuda_clie.Size = New System.Drawing.Size(169, 52)
        Me.cmd_det_deuda_clie.TabIndex = 4
        Me.cmd_det_deuda_clie.Text = "Detalle Deuda Cliente (monto total deuda)"
        Me.ToolTip1.SetToolTip(Me.cmd_det_deuda_clie, "Fecha de Vencimiento menos fecha actual")
        Me.cmd_det_deuda_clie.UseVisualStyleBackColor = True
        '
        'cmd_det_vend_clte
        '
        Me.cmd_det_vend_clte.Location = New System.Drawing.Point(250, 213)
        Me.cmd_det_vend_clte.Name = "cmd_det_vend_clte"
        Me.cmd_det_vend_clte.Size = New System.Drawing.Size(169, 52)
        Me.cmd_det_vend_clte.TabIndex = 3
        Me.cmd_det_vend_clte.Text = "Detalle de Vendedor / Cliente (monto total deuda)"
        Me.ToolTip1.SetToolTip(Me.cmd_det_vend_clte, "Fecha de Vencimiento menos fecha actual")
        Me.cmd_det_vend_clte.UseVisualStyleBackColor = True
        '
        'cmd_tramos_vcto
        '
        Me.cmd_tramos_vcto.Location = New System.Drawing.Point(456, 105)
        Me.cmd_tramos_vcto.Name = "cmd_tramos_vcto"
        Me.cmd_tramos_vcto.Size = New System.Drawing.Size(169, 52)
        Me.cmd_tramos_vcto.TabIndex = 2
        Me.cmd_tramos_vcto.Text = "Tramos de Vencimiento (30-60-90- más de 90)"
        Me.ToolTip1.SetToolTip(Me.cmd_tramos_vcto, "Fecha de Vencimiento menos fecha actual")
        Me.cmd_tramos_vcto.UseVisualStyleBackColor = True
        '
        'cmd_saldos_vend
        '
        Me.cmd_saldos_vend.Location = New System.Drawing.Point(250, 105)
        Me.cmd_saldos_vend.Name = "cmd_saldos_vend"
        Me.cmd_saldos_vend.Size = New System.Drawing.Size(169, 52)
        Me.cmd_saldos_vend.TabIndex = 1
        Me.cmd_saldos_vend.Text = "Saldos por Vendedor (monto total deuda)"
        Me.ToolTip1.SetToolTip(Me.cmd_saldos_vend, "Fecha de Vencimiento menos fecha actual")
        Me.cmd_saldos_vend.UseVisualStyleBackColor = True
        '
        'cmd_saldo_atrasado
        '
        Me.cmd_saldo_atrasado.Location = New System.Drawing.Point(40, 105)
        Me.cmd_saldo_atrasado.Name = "cmd_saldo_atrasado"
        Me.cmd_saldo_atrasado.Size = New System.Drawing.Size(169, 52)
        Me.cmd_saldo_atrasado.TabIndex = 0
        Me.cmd_saldo_atrasado.Text = "Saldos Atrasados        (Fecha Vcto. incluye Fecha Actual)"
        Me.ToolTip1.SetToolTip(Me.cmd_saldo_atrasado, "Vcto. menos fecha actual (Fecha Vcto. menos Fecha Actual)")
        Me.cmd_saldo_atrasado.UseVisualStyleBackColor = True
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(54, 448)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(65, 15)
        Me.lbl_version.TabIndex = 3
        Me.lbl_version.Text = "lbl_version"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1041, 510)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_saldo_atrasado As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmd_salir As Button
    Friend WithEvents cmd_det_deuda_clie As Button
    Friend WithEvents cmd_det_vend_clte As Button
    Friend WithEvents cmd_tramos_vcto As Button
    Friend WithEvents cmd_saldos_vend As Button
    Friend WithEvents lbl_version As Label
    Friend WithEvents cmd_cuadro_anual As Button
End Class