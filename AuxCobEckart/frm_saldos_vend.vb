
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


Public Class frm_saldos_vend

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
        grilla.Columns(0).HeaderCell.Value = "Vendedor"
        grilla.Columns(1).HeaderCell.Value = "Cod. Vend"
        grilla.Columns(2).HeaderCell.Value = "Total"


        grilla.Columns(0).Width = 150
        grilla.Columns(1).Width = 80
        grilla.Columns(2).Width = 120


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(2).DefaultCellStyle.Format = "C0"
        grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.White
        grilla.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        grilla.Refresh()

    End Sub


    Sub formato_grilla2()

        ' Cobr_A as Rut, Nombre as cliente, TipoFact, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, FeRegistro
        'FORMATO DE grillaCM
        grilla2.Columns(0).HeaderCell.Value = "rut"
        grilla2.Columns(1).HeaderCell.Value = "Cliente"
        grilla2.Columns(2).HeaderCell.Value = "Tipo Docto."
        grilla2.Columns(3).HeaderCell.Value = "Nro Fact."
        grilla2.Columns(4).HeaderCell.Value = "Fecha Fact."
        grilla2.Columns(5).HeaderCell.Value = "Fecha Vcto."
        grilla2.Columns(6).HeaderCell.Value = "Monto docto"
        grilla2.Columns(7).HeaderCell.Value = "Balance"
        grilla2.Columns(8).HeaderCell.Value = "Fe. Reg."


        grilla2.Columns(0).Width = 80
        grilla2.Columns(1).Width = 190
        grilla2.Columns(2).Width = 90
        grilla2.Columns(3).Width = 90
        grilla2.Columns(4).Width = 70
        grilla2.Columns(5).Width = 70
        grilla2.Columns(6).Width = 70
        grilla2.Columns(7).Width = 90
        grilla2.Columns(8).Width = 90



        grilla2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla2.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla2.Columns(6).DefaultCellStyle.Format = "C0"
        grilla2.Columns(7).DefaultCellStyle.Format = "C0"
        grilla2.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla2.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla2.RowsDefaultCellStyle.BackColor = Color.White
        grilla2.RowsDefaultCellStyle.ForeColor = Color.Blue
        ' grilla2.GridColor = Color.Black
        ' grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla2.Sort(grilla2.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        grilla2.RowHeadersVisible = False 'oculta la primera columna

        grilla2.Refresh()

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exp_excel access")
        End Try
    End Sub

    Sub Exp_excel_access2(migrilla As DataGridView)
        Try
            If ((migrilla.Columns.Count = 0) Or (migrilla.Rows.Count = 0)) Then
                MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
                'Exit Sub
            Else
                Dim dt As New System.Data.DataTable
                dt = TryCast(migrilla.DataSource, System.Data.DataTable)

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_vend.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_vend.xlsx")
                Using package As New OfficeOpenXml.ExcelPackage(fileg)
                    Dim ws As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add("Hoja1")
                    ws.Cells("A1").LoadFromDataTable(dt, True)
                    package.Save()
                End Using


                MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Exp_excel access2")
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



                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_saldo_Cliente.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_saldo_Cliente.xlsx")
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


    Sub Exp_Excel2(migrilla2 As DataGridView)  'MYSQL

        Try
            If ((migrilla2.Columns.Count = 0) Or (migrilla2.Rows.Count = 0)) Then
                MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
                'Exit Sub
            Else

                Dim dt As New System.Data.DataTable
                dt = TryCast(migrilla2.DataSource, System.Data.DataTable)



                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_vend.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_vend.xlsx")
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


    Sub SUMA_TOT(migrilla3 As DataGridView)

        ' Try

        tot_grilla = 0


        'suma los montos 
        With migrilla3
            For fila = 0 To .Rows.Count - 1
                If IsDBNull(.Item("Total", fila).Value) Then
                    .Item("Total", fila).Value = 0
                Else
                    tot_grilla = tot_grilla + CDbl(.Item("total", fila).Value)
                End If


            Next

            lbl_totales.Text = tot_grilla.ToString()
            lbl_totales.Text = String.Format("{0:C0}", tot_grilla)


        End With

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Proceso Suma CM")
        'End Try


    End Sub

    Sub SUMA_TOT2(migrilla4 As DataGridView)

        ' Try

        tot_grilla = 0


        'suma los montos 
        With migrilla4
            For fila = 0 To .Rows.Count - 1
                If IsDBNull(.Item("BCBalance", fila).Value) Then
                    .Item("BCBalance", fila).Value = 0
                Else
                    tot_grilla = tot_grilla + CDbl(.Item("BCBalance", fila).Value)
                End If


            Next

            lbl_totales2.Text = tot_grilla.ToString()
            lbl_totales2.Text = String.Format("{0:C0}", tot_grilla)


        End With

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Proceso Suma CM")
        'End Try


    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_saldos_vend_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub frm_saldos_vend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - Saldos por Vendedor - Detalle de Saldos "


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

        lbl_reg.Text = ""
        lbl_reg2.Text = ""
        lbl_totales.Text = ""
        lbl_totales2.Text = ""

        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grilla2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub cmd_bus_saldo_vend_Click(sender As Object, e As EventArgs) Handles cmd_bus_saldo_vend.Click
        If var = 1 Then 'busca en mysql

            Dim cmd5 As MySqlCommand = New MySqlCommand

            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text


            If conexion.State = 1 Then conexion.Close()
            If Connex = 0 Then
                'MODO LOCAL
                Call conn3()

            Else
                'MODO RED
                Call Conectar()
            End If
            '
            conexion.Open()
            cmd5.Connection = conexion
            'where cuenta = '1114001'
            cmd5.CommandText = "SELECT OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total FROM datos_fuente  where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001' group by OrdenarNombre  Order by OrdenarNombre  ASC"
            Dim dt5 As System.Data.DataTable = New System.Data.DataTable
            Dim da5 As MySqlDataAdapter = New MySqlDataAdapter(cmd5)
            da5.Fill(dt5)

            grilla.DataSource = dt5

            conexion.Close()
            da5.Dispose()
            cmd5.Dispose()

            For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla()
            Call SUMA_TOT(grilla)
            cmd_exp_excel.Enabled = True
        Else
            'busca en access
            'estableces la connstring a la connection
            Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
            'Creas el comando SELECT

            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            Dim comando5 As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando5.Connection = Conn
            If Conn.State = 1 Then Conn.Close()

            comando5.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001'  group by OrdenarNombre  Order by OrdenarNombre  ASC"

            Conn.Open()

            Dim dt5 As System.Data.DataTable = New System.Data.DataTable
            Dim da5 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando5)
            da5.Fill(dt5)


            grilla.DataSource = dt5

            Conn.Close()
            da5.Dispose()
            comando5.Dispose()


            For i As Integer = 0 To grilla.Rows.Count() - 1

                i = +i
                lbl_reg.Text = i

            Next

            Call formato_grilla()
            Call SUMA_TOT(grilla)
            cmd_exp_excel.Enabled = True

        End If
    End Sub


    Private Sub grilla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseDoubleClick
        If var = 1 Then
            'carga con mysql

            grilla2.Columns.Clear()


            Dim cmd12 As MySqlCommand = New MySqlCommand

            If conexion.State = 1 Then conexion.Close()
            If Connex = 0 Then
                'MODO LOCAL
                Call conn3()

            Else
                'MODO RED
                Call Conectar()
            End If

            conexion.Open()
            cmd12.Connection = conexion


            ' cmd12.CommandText = "SELECT FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario FROM eck_cobranza.datos_fuente where Cobr_A = '" & grilla.Item(0, e.RowIndex).Value & "' And Salesperson = '" & grilla1.Item(3, e.RowIndex).Value & "'"
            cmd12.CommandText = "SELECT Cobr_A as Rut, Nombre as cliente, TipoFact, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, FeRegistro FROM datos_fuente where Salesperson = '" & grilla.Item(1, e.RowIndex).Value & "' and FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001'"
            Dim dt12 As System.Data.DataTable = New System.Data.DataTable
            Dim da12 As MySqlDataAdapter = New MySqlDataAdapter(cmd12)
            da12.Fill(dt12)

            grilla2.DataSource = dt12

            conexion.Close()
            da12.Dispose()
            cmd12.Dispose()

            For i As Integer = 0 To grilla2.Rows.Count()

                i = +i
                lbl_reg2.Text = i

            Next


            Call SUMA_TOT2(grilla2)
            Call formato_grilla2()


        Else

            'carga con access

        End If
    End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

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
                cmd_bus_saldo_vend.Enabled = True
                cmd_bus_saldo_vend.Select()
            Else
                msk_fe_fin.Select()
            End If

        End If
    End Sub



    Private Sub cbo_tipo_bd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_tipo_bd.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            msk_fe_ini.Select()

        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
        Principal.Show()

    End Sub



    Private Sub frm_saldos_vend_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Principal.Show()
    End Sub

    Private Sub txt_bus_grilla1_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla1.TextChanged

    End Sub

    Private Sub txt_bus_grilla1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla1.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCA 

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla1.Text))
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

    Private Sub txt_bus_grilla2_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla2.TextChanged

    End Sub

    Private Sub txt_bus_grilla2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla2.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCA 

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla2.Text))
                If Len(target_name) = 0 Then Exit Sub

                For r As Integer = 1 To Me.grilla2.Rows.Count - 2

                    For x As Integer = 0 To grilla2.ColumnCount - 1

                        If grilla2.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla2.CurrentCell = grilla2.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla2.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue
                            grilla2.CurrentRow.DefaultCellStyle.ForeColor = Color.Yellow

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        If var = 1 Then

            Call Exp_Excel(grilla)

        Else
            Call Exp_excel_access(grilla)

        End If
    End Sub

    Private Sub cmd_exp_excel2_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel2.Click
        If var = 1 Then

            Call Exp_Excel2(grilla2)

        Else
            Call Exp_excel_access2(grilla2)

        End If
    End Sub
End Class