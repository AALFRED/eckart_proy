
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
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.Globalization


Public Class frm_saldo_cliente

    Dim var As Integer
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim com As New SqlCommand
    Dim rs As SqlDataReader

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

        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 200
        grilla.Columns(2).Width = 150
        grilla.Columns(3).Width = 60
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

        grilla.Sort(grilla.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        grilla.Refresh()

    End Sub


    Sub formato_grilla2()

        'TipoFact, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, FeRegistro
        'FORMATO DE grillaCM
        grilla2.Columns(0).HeaderCell.Value = "Tipo Docto."
        grilla2.Columns(1).HeaderCell.Value = "Nro Docto."
        grilla2.Columns(2).HeaderCell.Value = "Fecha Docto."
        grilla2.Columns(3).HeaderCell.Value = "Fecha Vcto."
        grilla2.Columns(4).HeaderCell.Value = "Monto Docto."
        grilla2.Columns(5).HeaderCell.Value = "Balance"
        grilla2.Columns(6).HeaderCell.Value = "Fecha Reg."

        grilla2.Columns(0).Width = 60
        grilla2.Columns(1).Width = 80
        grilla2.Columns(2).Width = 70
        grilla2.Columns(3).Width = 70
        grilla2.Columns(4).Width = 90
        grilla2.Columns(5).Width = 80
        grilla2.Columns(6).Width = 70

        grilla2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        grilla2.Columns(4).DefaultCellStyle.Format = "C0"
        grilla2.Columns(5).DefaultCellStyle.Format = "C0"

        grilla2.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla2.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla2.RowsDefaultCellStyle.BackColor = Color.White
        grilla2.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla2.GridColor = Color.Black
        grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla2.Sort(grilla2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
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

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_saldo_Clientes.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_saldo_Clientes.xlsx")
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

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_clte.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_clte.xlsx")
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



                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_saldo_Clientes.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_saldo_Clientes.xlsx")
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


    Sub Exp_Excel22(migrilla2 As DataGridView)

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("hoja1")

        xlWorkSheet.Cells(1, 9) = "Rut Cliente :" & lbl_rut.Text
        xlWorkSheet.Cells(2, 9) = "Nombre :" & lbl_nombre.Text


        'Original
        'For i = 0 To DataGridView1.RowCount - 2
        '    For j = 0 To DataGridView1.ColumnCount - 1
        '        For k As Integer = 1 To DataGridView1.Columns.Count
        '            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        '            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
        '        Next
        '    Next
        'Next



        For i = 0 To grilla2.RowCount - 2
            For j = 0 To grilla2.ColumnCount - 1
                For k As Integer = 1 To grilla2.Columns.Count
                    xlWorkSheet.Cells(1, k) = grilla2.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = grilla2(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_Cliente.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("You can find the file C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_Cliente.xlsx")

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
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



                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_Cliente.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_det_saldo_Cliente.xlsx")
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

    Private Sub frm_saldo_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - SALDOS DE CLIENTES - DETALLE DE SALDOS"


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
        cbo_tipo_bd.Items.Add("BD SQL SERVER")
        cbo_tipo_bd.Text = "BD SQL SERVER"
        var = 1
        cbo_tipo_bd.Enabled = False

        lbl_reg.Text = ""
        lbl_reg2.Text = ""
        lbl_totales.Text = ""
        lbl_totales2.Text = ""
        lbl_rut.Text = ""
        lbl_nombre.text = ""


        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grilla2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub cmd_bus_saldo_vend_Click(sender As Object, e As EventArgs) Handles cmd_bus_saldo_clte.Click
        If var = 1 Then 'busca en mysql

            Dim cmd4 As SqlCommand = New SqlCommand


            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            If Connex = 0 Then
                'MODO LOCAL
                Call Conectar2()


            Else
                'MODO RED
                Call Conectar2()
            End If
            If conexion2.State = 1 Then conexion2.Close()
            conexion2.Open()
            cmd4.Connection = conexion2
            cmd4.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total FROM datos_fuente where cuenta = '1114001' and FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' group by Nombre Order by Nombre ASC"
            Dim dt4 As System.Data.DataTable = New System.Data.DataTable
            Dim da4 As SqlDataAdapter = New SqlDataAdapter(cmd4)
            da4.Fill(dt4)

            grilla.DataSource = dt4

            conexion2.Close()
            da4.Dispose()
            cmd4.Dispose()

            For i As Integer = 0 To grilla.Rows.Count() Step +1

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

            Dim comando4 As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando4.Connection = Conn
            If Conn.State = 1 Then Conn.Close()


            comando4.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where cuenta = '1114001' and FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

            Conn.Open()


            Dim dt4 As System.Data.DataTable = New System.Data.DataTable
            Dim da4 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando4)
            da4.Fill(dt4)


            grilla.DataSource = dt4

            Conn.Close()
            da4.Dispose()
            comando4.Dispose()

            For i As Integer = 0 To grilla.Rows.Count() - 1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla()
            Call SUMA_TOT(grilla)
            cmd_exp_excel.Enabled = True

        End If
    End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub

    Private Sub grilla_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseClick
        Dim cmd12 As SqlCommand = New SqlCommand

        If var = 1 Then
            'carga con mysql

            grilla2.Columns.Clear()

            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            If Connex = 0 Then
                'MODO LOCAL
                Call Conectar2()
            Else
                'MODO RED
                Call Conectar2()
            End If

            If conexion2.State = 1 Then conexion2.Close()
            conexion2.Open()
            cmd12.Connection = conexion2


            ' cmd12.CommandText = "SELECT FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario FROM eck_cobranza.datos_fuente where Cobr_A = '" & grilla.Item(0, e.RowIndex).Value & "' And Salesperson = '" & grilla1.Item(3, e.RowIndex).Value & "'"
            cmd12.CommandText = "SELECT TipoFact, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, FeRegistro FROM datos_fuente where  Cobr_A = '" & grilla.Item(0, e.RowIndex).Value & "' and cuenta = '1114001' and FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "'"
            Dim dt12 As System.Data.DataTable = New System.Data.DataTable
            Dim da12 As SqlDataAdapter = New SqlDataAdapter(cmd12)
            da12.Fill(dt12)

            grilla2.DataSource = dt12

            conexion2.Close()
            da12.Dispose()
            cmd12.Dispose()

            For i As Integer = 0 To grilla2.Rows.Count()

                i = +i
                lbl_reg2.Text = i

            Next
            lbl_rut.Text = grilla.Item(0, e.RowIndex).Value
            lbl_nombre.Text = grilla.Item(1, e.RowIndex).Value

            Call SUMA_TOT2(grilla2)
            Call formato_grilla2()


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


            comando3.CommandText = "SELECT TipoFact, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, FeRegistro FROM datos_fuente where  Cobr_A = '" & grilla.Item(0, e.RowIndex).Value & "' and cuenta = '1114001' and FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "'"

            Conn.Open()


            Dim dt3 As System.Data.DataTable = New System.Data.DataTable
            Dim da3 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando3)
            da3.Fill(dt3)


            grilla2.DataSource = dt3


            Conn.Close()
            da3.Dispose()
            comando3.Dispose()

            For i As Integer = 0 To grilla2.Rows.Count() - 1

                i = +i
                lbl_reg2.Text = i

            Next
            lbl_rut.Text = grilla.Item(0, e.RowIndex).Value
            lbl_nombre.Text = grilla.Item(1, e.RowIndex).Value

            Call SUMA_TOT2(grilla2)
            Call formato_grilla2()



        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
        Principal.Show()

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_saldo_cliente_Load(e, e) 'Load everything in your form load event again
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
                cmd_bus_saldo_clte.Enabled = True
                cmd_bus_saldo_clte.Select()
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

    Private Sub frm_saldo_cliente_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
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

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        If var = 1 Then

            Call Exp_Excel(grilla)

        Else
            Call Exp_excel_access(grilla)

        End If
    End Sub

    Private Sub cmd_exp_excel2_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel2.Click
        If var = 1 Then

            Call Exp_Excel22(grilla2)

        Else
            Call Exp_excel_access2(grilla2)

        End If
    End Sub
End Class