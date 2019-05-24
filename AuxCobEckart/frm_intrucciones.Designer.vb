<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_intrucciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_intrucciones))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(34, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(916, 393)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(908, 366)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Carga de Datos"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(26, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(846, 82)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(26, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(846, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PASO 4:  GUARDAR EL ARCHIVO CON NOMBRE A SU GUSTO Y CON LA EXTENSION XLSX EN LA C" &
    "ARPETA ----> C:\eckart\proyecto Cobranzas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(26, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(800, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASO 3:  CAMBIAR EL NOMBRE DE LA HOJA (HOJA1) POR  ""Datos"". A LOS CAMPOS FECHA DE" &
    "JARLOS CON FORMATO (yyyy-mm-dd)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(26, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(811, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASO 2: ABRIR EL ARCHIVO CON EXCEL, DEBERÁ BORRAR LA CABEZERA CON LOS NOMBRES DE " &
    "LOS CAMPOS, DEBEN QUEDAR                                    SOLO LOS DATOS CON U" &
    "N TOTAL DE 29 CAMPOS."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(29, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(808, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A CONTINUACION, SE DETALLAN LOS PASOS A SEGUIR PARA LA CARGA DE INFORMACION DESDE" &
    " LOS DATOS DEL SISTEMA QAD AL SISTEMA AUXILIAR DE COBRANZA ."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(26, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(622, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PASO 1: OBTENER EL ARCHIVO DE SALIDA DE COBRANZA DESDE EL SISTEMA QAD EN FORMATO " &
    "EXCEL."
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(908, 366)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Carga de Clientes"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(32, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(846, 82)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = resources.GetString("Label12.Text")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(32, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(846, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "PASO 4:  GUARDAR EL ARCHIVO CON NOMBRE A SU GUSTO Y CON LA EXTENSION XLSX EN LA C" &
    "ARPETA ----> C:\eckart\proyecto Cobranzas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(32, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(417, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "PASO 3:  CAMBIAR EL NOMBRE DE LA HOJA (HOJA1) POR  ""cliente""."
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(32, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(811, 40)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "PASO 2:  ABRIR EL ARCHIVO CON EXCEL, DEBERÁ BORRAR LA CABEZERA CON LOS NOMBRES DE" &
    " LOS CAMPOS, DEBEN QUEDAR                                    SOLO LOS DATOS CON " &
    "UN TOTAL DE 30 CAMPOS."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(32, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(754, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "PASO 1: OBTENER EL ARCHIVO DE SALIDA CON LA INFORMACION DE CLIENTES DESDE EL SIST" &
    "EMA QAD EN FORMATO EXCEL."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(32, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(808, 38)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "A CONTINUACION, SE DETALLAN LOS PASOS A SEGUIR PARA  CARGAR  INFORMACION DE CLIEN" &
    "TES DESDE LOS DATOS EXTRAIDOS  DEL SISTEMA QAD AL SISTEMA AUXILIAR DE COBRANZA ." &
    ""
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(908, 366)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Carga de Vendedores"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(31, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(846, 82)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(31, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(846, 18)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "PASO 4:  GUARDAR EL ARCHIVO CON NOMBRE A SU GUSTO Y CON LA EXTENSION XLSX EN LA C" &
    "ARPETA ----> C:\eckart\proyecto Cobranzas"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(31, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(434, 18)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "PASO 3:  CAMBIAR EL NOMBRE DE LA HOJA (HOJA1) POR  ""vendedor""."
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(31, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(811, 40)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "PASO 2:  ABRIR EL ARCHIVO CON EXCEL, DEBERÁ BORRAR LA CABEZERA CON LOS NOMBRES DE" &
    " LOS CAMPOS, DEBEN QUEDAR                                    SOLO LOS DATOS CON " &
    "UN TOTAL DE 8 CAMPOS."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(31, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(781, 18)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "PASO 1: OBTENER EL ARCHIVO DE SALIDA CON LA INFORMACION DE VENDEDORES DESDE EL SI" &
    "STEMA QAD EN FORMATO EXCEL."
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(31, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(808, 38)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "A CONTINUACION, SE DETALLAN LOS PASOS A SEGUIR PARA  CARGAR  INFORMACION DE VENDE" &
    "DORES DESDE LOS DATOS EXTRAIDOS  DEL SISTEMA QAD AL SISTEMA AUXILIAR DE COBRANZA" &
    " ."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_intrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 506)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_intrucciones"
        Me.Text = "frm_intrucciones"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
End Class
