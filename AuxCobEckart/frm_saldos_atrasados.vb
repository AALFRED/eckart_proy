Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text
Imports System.Data.OleDb
Imports System
Imports System.Diagnostics
Imports System.Object
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports AuxCobEckart
Imports System.Data.Odbc
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.Globalization


Public Class frm_saldos_atrasados

    Dim var As Integer
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim com As New MySqlCommand
    Dim rs As MySqlDataReader

    Private mifecha As Date
    Private mifecha2 As Date

    Dim varmarca As Integer
    Dim tot_grilla As Long
    Dim fecha_actual As String


    Sub formato_grilla()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Vendedor"
        grilla.Columns(3).HeaderCell.Value = "Cod. Vend"
        grilla.Columns(4).HeaderCell.Value = "Total"


        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 300
        grilla.Columns(2).Width = 300
        grilla.Columns(3).Width = 80
        grilla.Columns(4).Width = 120


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(4).DefaultCellStyle.Format = "C0"
        grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.White
        grilla.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        grilla.Refresh()

    End Sub


    Sub Exp_excel_access(migrilla As DataGridView)
        Try
            If ((migrilla.Columns.Count = 0) Or (migrilla.Rows.Count = 0)) Then
                MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
                'Exit Sub
            Else
                Dim dt As New System.Data.DataTable
                dt = TryCast(migrilla.DataSource, System.Data.DataTable)

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_access_cob.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_access_cob.xlsx")
                Using package As New OfficeOpenXml.ExcelPackage(fileg)
                    Dim ws As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add("Hoja1")
                    ws.Cells("A1").LoadFromDataTable(dt, True)
                    package.Save()
                End Using


                MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exp_excel mysql")
        End Try
    End Sub

    Sub Exp_Excel(migrilla2 As DataGridView)  'MYSQL
        Try



            If ((migrilla2.Columns.Count = 0) Or (migrilla2.Rows.Count = 0)) Then
                MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
                'Exit Sub
            Else

                Dim dt As New System.Data.DataTable
                dt = TryCast(migrilla2.DataSource, System.Data.DataTable)

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_saldo_atrasado.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_saldo_atrasado.xlsx")
                Using package As New OfficeOpenXml.ExcelPackage(fileg)
                    Dim ws As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add("Hoja1")
                    ws.Cells("A1").LoadFromDataTable(dt, True)
                    package.Save()
                End Using


                MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)



                'wBook.SaveAs(strFileName)
                'aplicacion.Workbooks.Open(strFileName)
                'aplicacion.Visible = True


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exp_excel mysql")
        End Try

    End Sub

    Public Function cargacombo(ByVal TABLENAME As String, ByVal fldName As String, ByVal cmbname As ComboBox)


        If var = 1 Then 'buscar por mysql
            Dim cmd1 As New MySqlCommand

            If Connex = 0 Then
                'MODO LOCAL
                Call conn3()

            Else
                'MODO RED
                Call Conectar()
            End If



            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)


            dr = cmd1.ExecuteReader
            cmbname.Items.Clear()
            Do While dr.Read()
                cmbname.Items.Add(dr(fldName))
            Loop
            dr.Close()
            conexion.Close()
            cmd1.Dispose()
        Else
            If var = 2 Then 'busca Access

                'estableces la connstring a la connection
                Dim comando As OleDbCommand
                Dim dr2 As OleDbDataReader
                Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                If Conn.State = 1 Then Conn.Close()
                Conn.Open()

                comando = New OleDbCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, Conn)

                dr2 = comando.ExecuteReader
                cmbname.Items.Clear()
                Do While dr2.Read()
                    cmbname.Items.Add(dr2(fldName))

                Loop
                dr2.Close()
                Conn.Close()
                comando.Dispose()

            End If
        End If


        Return 0
    End Function


    Sub SUMA_TOT(migrilla3 As DataGridView)

        ' Try

        tot_grilla = 0


        'suma los montos 
        With migrilla3
            For fila = 0 To .Rows.Count - 1
                If IsDBNull(.Item("Total", fila).Value) Then
                    .Item("Total", fila).Value = 0
                Else
                    tot_grilla = tot_grilla + CDbl(.Item("Total", fila).Value)
                End If


            Next

            lbl_totales.Text = tot_grilla.ToString()
            lbl_totales.Text = String.Format("{0:C0}", tot_grilla)


        End With

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Proceso Suma CM")
        'End Try


    End Sub


    Private Sub frm_saldos_atrasados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '///////////////////////////////////////
        '///// CONFIGURACION REGIONAL
        '////////////////////////////////////

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        '//////////////////////////////////////////////////////////////////////////////////////////////////////



        Me.CenterToScreen()

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - SALDOS ATRASADOS POR RANGO DE FECHAS"


        'Create a StatusBar
        Dim BarraStatus As New StatusBar
        BarraStatus.Name = "StatusBar"
        BarraStatus.ShowPanels = True

        'Create the panels
        Dim BarraStatusDate = New StatusBarPanel
        BarraStatusDate.Name = "StatusBarDate"
        BarraStatusDate.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        BarraStatusDate.AutoSize = StatusBarPanelAutoSize.Contents
        BarraStatus.Panels.Add(BarraStatusDate)

        Dim BarraStatusTime = New StatusBarPanel
        BarraStatusTime.Name = "StatusBarTime"
        BarraStatusTime.Text = Now.ToShortTimeString  'FormatDateTime(Now(), DateFormat.LongTime)
        BarraStatusTime.AutoSize = StatusBarPanelAutoSize.Contents
        BarraStatus.Panels.Add(BarraStatusTime)

        Dim BarraStatusTexto = New StatusBarPanel
        BarraStatusTexto.Name = "StatusBartexto"
        BarraStatusTexto.Width = 400
        BarraStatusTexto.Text = "CONECTADO A Base de Datos "
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)


        lbl_version.Text = "VERSIÓN " & System.Windows.Forms.Application.ProductVersion.ToString & " - " & System.Windows.Forms.Application.CompanyName.ToString

        'carga de tipo de bd
        cbo_tipo_bd.Items.Add("BD MYSQL")
        cbo_tipo_bd.Items.Add("BD ACCESS")
        cbo_tipo_bd.Text = "BD MYSQL"
        var = 1


        'carga la fecha actual
        fecha_actual = System.DateTime.Now.ToString(("yyyy-MM-dd"))
        msk_fe_fin.Text = fecha_actual.ToString


        'control de carga grilla1
        cmd_exp_excel.Enabled = False
        lbl_reg.Text = ""
        lbl_totales.Text = ""

        cmd_bus_saldo_atrasado.Enabled = False

    End Sub

    Private Sub cmd_limpiar3_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_saldos_atrasados_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub cmd_salir3_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
        Principal.Show()

    End Sub

    Private Sub cmd_bus_men_fecha_Click(sender As Object, e As EventArgs) Handles cmd_bus_saldo_atrasado.Click
        Try



            If var = 1 Then  'busca en mysql

                Dim cmd3 As MySqlCommand = New MySqlCommand
                If Connex = 0 Then
                    'MODO LOCAL
                    Call conn3()

                Else
                    'MODO RED
                    Call Conectar()
                End If

                If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    mifecha = msk_fe_ini.Text
                    mifecha2 = msk_fe_fin.Text
                    ' mifecha = mifecha.AddDays(-1) 'resta 1 dia

                    cmd3.Connection = conexion
                    cmd3.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total  FROM eck_cobranza.datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and BCBalance > 0 group by Cobr_A order by nombre ASC ;"
                    Dim dt3 As System.Data.DataTable = New System.Data.DataTable
                    Dim da3 As MySqlDataAdapter = New MySqlDataAdapter(cmd3)
                    da3.Fill(dt3)

                    grilla.DataSource = dt3

                    conexion.Close()
                    da3.Dispose()
                    cmd3.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla()
                    Call SUMA_TOT(grilla)
                    cmd_exp_excel.Enabled = True

                Else

                    'busca en access
                    mifecha = msk_fe_ini.Text
                mifecha2 = msk_fe_fin.Text
                ' mifecha = mifecha.AddDays(-1) 'resta 1 dia

                'estableces la connstring a la connection
                Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                'Creas el comando SELECT

                Dim comando3 As OleDbCommand = New OleDbCommand
                'Estableces la conexion activa
                comando3.Connection = Conn
                If Conn.State = 1 Then Conn.Close()


                comando3.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Wherewhere FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and FeVcto '" & mifecha.ToString("yyyy-MM-dd") & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

                Conn.Open()


                Dim dt3 As System.Data.DataTable = New System.Data.DataTable
                Dim da3 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando3)
                da3.Fill(dt3)


                grilla.DataSource = dt3


                Conn.Close()
                da3.Dispose()
                comando3.Dispose()

                For i As Integer = 0 To grilla.Rows.Count() - 1

                    i = +i
                    lbl_reg.Text = i

                Next

                Call formato_grilla()
                Call SUMA_TOT(grilla)
                cmd_exp_excel.Enabled = True

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        If var = 1 Then

            Call Exp_Excel(grilla)

        Else
            Call Exp_excel_access(grilla)

        End If
    End Sub

    Private Sub msk_fe_ini_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini.MaskInputRejected

    End Sub

    Private Sub msk_fe_ini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_ini.Text <> "    -  -" Then
                msk_fe_fin.Select()

            Else
                msk_fe_ini.Select()
            End If


        End If
    End Sub

    Private Sub msk_fe_fin_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_fin.MaskInputRejected

    End Sub

    Private Sub msk_fe_fin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_fin.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_ini.Text <> "    -  -" Then
                cmd_bus_saldo_atrasado.Enabled = True
                cmd_bus_saldo_atrasado.Select()
            Else
                msk_fe_fin.Select()
            End If

        End If
    End Sub

    Private Sub cbo_tipo_bd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd.SelectedIndexChanged

    End Sub

    Private Sub cbo_tipo_bd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_tipo_bd.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            msk_fe_ini.Select()



        End If
    End Sub
    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub

    Private Sub txt_bus_grilla_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla.TextChanged

    End Sub

    Private Sub txt_bus_grilla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCA 

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla.Text))
                If Len(target_name) = 0 Then Exit Sub

                For r As Integer = 1 To Me.grilla.Rows.Count - 2

                    For x As Integer = 0 To grilla.ColumnCount - 1

                        If grilla.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla.CurrentCell = grilla.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue
                            grilla.CurrentRow.DefaultCellStyle.ForeColor = Color.Yellow

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_saldos_atrasados_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Principal.Show()

    End Sub
End Class