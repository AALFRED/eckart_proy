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



Public Class frm_menu

    Dim var As Integer
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim com As New MySqlCommand
    Dim rs As MySqlDataReader

    Private mifecha As Date
    Private mifecha2 As Date

    Dim varmarca As Integer
    Dim tot_grilla As Long


    Sub Exp_excel_access(migrilla As DataGridView)
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

    End Sub

    Sub Exp_Excel(migrilla2 As DataGridView)  'MYSQL


        If ((migrilla2.Columns.Count = 0) Or (migrilla2.Rows.Count = 0)) Then
            MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
            'Exit Sub
        Else

            Dim dt As New System.Data.DataTable
            dt = TryCast(migrilla2.DataSource, System.Data.DataTable)

            My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_mysql_cob.xlsx")

            Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_mysql_cob.xlsx")
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


    End Sub


    Sub formato_grilla1()


        'FORMATO DE grillaCM
        grilla1.Columns(0).HeaderCell.Value = "Rut"
        grilla1.Columns(1).HeaderCell.Value = "Nombre"
        grilla1.Columns(2).HeaderCell.Value = "Vendedor"
        grilla1.Columns(3).HeaderCell.Value = "Cod Vend"
        grilla1.Columns(4).HeaderCell.Value = "Total"



        grilla1.Columns(0).Width = 90
        grilla1.Columns(1).Width = 300
        grilla1.Columns(2).Width = 200
        grilla1.Columns(3).Width = 80
        grilla1.Columns(4).Width = 120


        grilla1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla1.Columns(4).DefaultCellStyle.Format = "C2"

        grilla1.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla1.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla1.RowsDefaultCellStyle.BackColor = Color.White
        grilla1.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla1.GridColor = Color.Black
        grilla1.BorderStyle = BorderStyle.Fixed3D

        grilla1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla1.Sort(grilla1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla1.RowHeadersVisible = False 'oculta la primera columna

        grilla1.Refresh()

    End Sub

    Sub formato_grilla2()


        'FORMATO DE grillaCM
        grilla2.Columns(0).HeaderCell.Value = "Rut"
        grilla2.Columns(1).HeaderCell.Value = "Nombre"
        grilla2.Columns(2).HeaderCell.Value = "Vendedor"
        grilla2.Columns(3).HeaderCell.Value = "Cod. Vend"
        grilla2.Columns(4).HeaderCell.Value = "Total"



        grilla2.Columns(0).Width = 90
        grilla2.Columns(1).Width = 300
        grilla2.Columns(2).Width = 200
        grilla2.Columns(3).Width = 80
        grilla2.Columns(4).Width = 120

        grilla2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla2.Columns(4).DefaultCellStyle.Format = "C2"

        grilla2.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla2.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla2.RowsDefaultCellStyle.BackColor = Color.White
        grilla2.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla2.GridColor = Color.Black
        grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla2.Sort(grilla2.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla2.RowHeadersVisible = False 'oculta la primera columna

        grilla2.Refresh()

    End Sub

    Sub formato_grilla3()


        'FORMATO DE grillaCM
        grilla3.Columns(0).HeaderCell.Value = "Rut"
        grilla3.Columns(1).HeaderCell.Value = "Nombre"
        grilla3.Columns(2).HeaderCell.Value = "Vendedor"
        grilla3.Columns(3).HeaderCell.Value = "Cod. Vend"
        grilla3.Columns(4).HeaderCell.Value = "Total"


        grilla3.Columns(0).Width = 90
        grilla3.Columns(1).Width = 300
        grilla3.Columns(2).Width = 300
        grilla3.Columns(3).Width = 80
        grilla3.Columns(4).Width = 120


        grilla3.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla3.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla3.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla3.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla3.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla3.Columns(4).DefaultCellStyle.Format = "C2"

        grilla3.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla3.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla3.RowsDefaultCellStyle.BackColor = Color.White
        grilla3.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla3.GridColor = Color.Black
        grilla3.BorderStyle = BorderStyle.Fixed3D

        grilla3.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla3.Sort(grilla3.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla3.RowHeadersVisible = False 'oculta la primera columna

        grilla3.Refresh()

    End Sub

    Sub formato_grilla4()


        'FORMATO DE grillaCM
        grilla4.Columns(0).HeaderCell.Value = "Rut"
        grilla4.Columns(1).HeaderCell.Value = "Nombre"
        grilla4.Columns(2).HeaderCell.Value = "Vendedor"
        grilla4.Columns(3).HeaderCell.Value = "Cod. Vend"
        grilla4.Columns(4).HeaderCell.Value = "Total"


        grilla4.Columns(0).Width = 90
        grilla4.Columns(1).Width = 300
        grilla4.Columns(2).Width = 300
        grilla4.Columns(3).Width = 80
        grilla4.Columns(4).Width = 120


        grilla4.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla4.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla4.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla4.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla4.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla4.Columns(4).DefaultCellStyle.Format = "C2"

        grilla4.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla4.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla4.RowsDefaultCellStyle.BackColor = Color.White
        grilla4.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla4.GridColor = Color.Black
        grilla4.BorderStyle = BorderStyle.Fixed3D

        grilla4.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla4.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla4.Sort(grilla4.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla4.RowHeadersVisible = False 'oculta la primera columna

        grilla4.Refresh()

    End Sub


    Sub formato_grilla5()


        'FORMATO DE grillaCM
        grilla5.Columns(0).HeaderCell.Value = "Rut"
        grilla5.Columns(1).HeaderCell.Value = "Nombre"
        grilla5.Columns(2).HeaderCell.Value = "Vendedor"
        grilla4.Columns(3).HeaderCell.Value = "Cod. Vend"
        grilla5.Columns(4).HeaderCell.Value = "Total"


        grilla5.Columns(0).Width = 90
        grilla5.Columns(1).Width = 300
        grilla5.Columns(2).Width = 150
        grilla5.Columns(3).Width = 80
        grilla5.Columns(4).Width = 120


        grilla5.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla5.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla5.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla5.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla5.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla5.Columns(4).DefaultCellStyle.Format = "C2"

        grilla5.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla5.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla5.RowsDefaultCellStyle.BackColor = Color.White
        grilla5.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla5.GridColor = Color.Black
        grilla5.BorderStyle = BorderStyle.Fixed3D

        grilla5.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla5.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla5.Sort(grilla5.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla5.RowHeadersVisible = False 'oculta la primera columna

        grilla5.Refresh()

    End Sub


    Sub formato_grilla6()


        'FORMATO DE grillaCM
        grilla6.Columns(0).HeaderCell.Value = "Rut"
        grilla6.Columns(1).HeaderCell.Value = "Nombre"
        grilla6.Columns(2).HeaderCell.Value = "ENE"
        grilla6.Columns(3).HeaderCell.Value = "FEB"
        grilla6.Columns(4).HeaderCell.Value = "MAR"
        grilla6.Columns(5).HeaderCell.Value = "ABR"
        grilla6.Columns(6).HeaderCell.Value = "MAY"
        grilla6.Columns(7).HeaderCell.Value = "JUN"
        grilla6.Columns(8).HeaderCell.Value = "JUL"
        grilla6.Columns(9).HeaderCell.Value = "AGO"
        grilla6.Columns(10).HeaderCell.Value = "SEP"
        grilla6.Columns(11).HeaderCell.Value = "OCT"
        grilla6.Columns(12).HeaderCell.Value = "NOV"
        grilla6.Columns(13).HeaderCell.Value = "DIC"
        grilla6.Columns(14).HeaderCell.Value = "TOTAL"


        grilla6.Columns(0).Width = 60
        grilla6.Columns(1).Width = 320
        grilla6.Columns(2).Width = 80
        grilla6.Columns(3).Width = 80
        grilla6.Columns(4).Width = 80
        grilla6.Columns(5).Width = 80
        grilla6.Columns(6).Width = 80
        grilla6.Columns(7).Width = 80
        grilla6.Columns(8).Width = 80
        grilla6.Columns(9).Width = 80
        grilla6.Columns(10).Width = 80
        grilla6.Columns(11).Width = 80
        grilla6.Columns(12).Width = 80
        grilla6.Columns(13).Width = 80
        grilla6.Columns(14).Width = 80


        grilla6.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla6.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla6.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla6.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        grilla6.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla6.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla6.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        grilla6.RowsDefaultCellStyle.ForeColor = Color.White
        grilla6.GridColor = Color.Black
        grilla6.BorderStyle = BorderStyle.Fixed3D

        grilla6.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla6.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla6.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla6.Sort(grilla6.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        grilla6.RowHeadersVisible = False 'oculta la primera columna

        grilla6.Refresh()

    End Sub

    Sub formato_grilla7()

        ' FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario
        'FORMATO DE grillaCM
        frm_detalle_fact.grilla_det.Columns(0).HeaderCell.Value = "Fecha Registro"
        frm_detalle_fact.grilla_det.Columns(1).HeaderCell.Value = "Tipo Fact"
        frm_detalle_fact.grilla_det.Columns(2).HeaderCell.Value = "Nro Docto."
        frm_detalle_fact.grilla_det.Columns(3).HeaderCell.Value = "Nro Fact."
        frm_detalle_fact.grilla_det.Columns(4).HeaderCell.Value = "Fecha Fact."
        frm_detalle_fact.grilla_det.Columns(5).HeaderCell.Value = "Fecha Vcto."
        frm_detalle_fact.grilla_det.Columns(6).HeaderCell.Value = "Monto docto"
        frm_detalle_fact.grilla_det.Columns(7).HeaderCell.Value = "Balance"
        frm_detalle_fact.grilla_det.Columns(8).HeaderCell.Value = "Nro Cuenta"
        frm_detalle_fact.grilla_det.Columns(9).HeaderCell.Value = "Vocher"
        frm_detalle_fact.grilla_det.Columns(10).HeaderCell.Value = "Libro diario"


        frm_detalle_fact.grilla_det.Columns(0).Width = 100
        frm_detalle_fact.grilla_det.Columns(1).Width = 150
        frm_detalle_fact.grilla_det.Columns(2).Width = 100
        frm_detalle_fact.grilla_det.Columns(3).Width = 80
        frm_detalle_fact.grilla_det.Columns(4).Width = 80
        frm_detalle_fact.grilla_det.Columns(5).Width = 80
        frm_detalle_fact.grilla_det.Columns(6).Width = 80
        frm_detalle_fact.grilla_det.Columns(7).Width = 80
        frm_detalle_fact.grilla_det.Columns(8).Width = 80
        frm_detalle_fact.grilla_det.Columns(9).Width = 80
        frm_detalle_fact.grilla_det.Columns(10).Width = 80



        frm_detalle_fact.grilla_det.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        frm_detalle_fact.grilla_det.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        frm_detalle_fact.grilla_det.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        frm_detalle_fact.grilla_det.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        frm_detalle_fact.grilla_det.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        frm_detalle_fact.grilla_det.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        frm_detalle_fact.grilla_det.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        frm_detalle_fact.grilla_det.RowsDefaultCellStyle.ForeColor = Color.White
        frm_detalle_fact.grilla_det.GridColor = Color.Black
        frm_detalle_fact.grilla_det.BorderStyle = BorderStyle.Fixed3D

        frm_detalle_fact.grilla_det.CellBorderStyle = DataGridViewCellBorderStyle.Single
        frm_detalle_fact.grilla_det.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        frm_detalle_fact.grilla_det.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        frm_detalle_fact.grilla_det.Sort(frm_detalle_fact.grilla_det.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        frm_detalle_fact.grilla_det.RowHeadersVisible = False 'oculta la primera columna

        frm_detalle_fact.grilla_det.Refresh()

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


    Public Function cargacombo(ByVal TABLENAME As String, ByVal fldName As String, ByVal cmbname As ComboBox)


        If var = 1 Then 'buscar por mysql
            Dim cmd1 As New MySqlCommand
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



    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - MENÚ PRINCIPAL"


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


        'TP1
        'carga de tipo de bd
        cbo_tipo_bd_tp1.Items.Add("BD MYSQL")
        cbo_tipo_bd_tp1.Items.Add("BD ACCESS")

        cbo_tipo_bd_tp2.Items.Add("BD MYSQL")
        cbo_tipo_bd_tp2.Items.Add("BD ACCESS")

        cbo_tipo_bd_tp3.Items.Add("BD MYSQL")
        cbo_tipo_bd_tp3.Items.Add("BD ACCESS")

        cbo_tipo_bd_tp4.Items.Add("BD MYSQL")
        cbo_tipo_bd_tp4.Items.Add("BD ACCESS")

        cbo_tipo_bd_tp5.Items.Add("BD MYSQL")
        cbo_tipo_bd_tp5.Items.Add("BD ACCESS")

        cbo_tipo_bd_tp6.Items.Add("BD MYSQL")




        txt_bus_grilla1.Visible = True
        txt_bus_grilla2.Visible = False
        txt_bus_grilla3.Visible = False
        txt_bus_grilla4.Visible = False
        txt_bus_grilla5.Visible = False
        txt_bus_grilla6.Visible = False


        'control de carga grilla1
        cmd_exp_excel.Enabled = False
        lbl_reg.Text = ""
        lbl_totales.Text = ""



    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Hide()
        frm_cliente.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub frm_menu_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub CargarBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarBaseToolStripMenuItem.Click
        Me.Hide()
        frm_carga_base.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        Me.Hide()
        frm_carga_vend.Show()
    End Sub

    Private Sub VerIncobrablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerIncobrablesToolStripMenuItem.Click
        Me.Hide()
        frm_incobrables.Show()
    End Sub

    Private Sub msk_fe_ini_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini.MaskInputRejected

    End Sub

    Private Sub msk_fe_ini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then



            If msk_fe_ini.Text <> "    -  -" Then
                msk_fe_fin.Enabled = True
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


            If msk_fe_fin.Text <> "    -  -" Then
                cmd_buscar.Enabled = True
                cmd_buscar.Select()
            Else
                msk_fe_fin.Select()
            End If


        End If
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click

        If var = 1 Then 'buscar por mysql

            Dim cmd1 As MySqlCommand = New MySqlCommand

            ' conexion.Close()
            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            cmd1.Connection = conexion
            cmd1.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total  FROM eck_cobranza.datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and BCBalance > 0 and cuenta = '1114001' group by Cobr_A order by nombre ASC;"

            Dim dt1 As System.Data.DataTable = New System.Data.DataTable
            Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
            da1.Fill(dt1)

            grilla1.DataSource = dt1

            conexion.Close()
            da1.Dispose()
            cmd1.Dispose()



            For i As Integer = 0 To grilla1.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla1()
            Call SUMA_TOT(grilla1)
            cmd_exp_excel.Enabled = True

        Else

            'BUSCA EN ACCESS
            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            'estableces la connstring a la connection
            Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
            'Creas el comando SELECT

            Dim comando As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando.Connection = Conn
            If Conn.State = 1 Then Conn.Close()


            comando.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.fecha_vcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "'  and cuenta = '1114001' GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

            Conn.Open()


            Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando)
            da.Fill(dt)


            grilla1.DataSource = dt


            Conn.Close()
            da.Dispose()
            comando.Dispose()

            For i As Integer = 0 To grilla1.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla1()
            Call SUMA_TOT(grilla1)
            cmd_exp_excel.Enabled = True

        End If
    End Sub

    Private Sub cbo_tipo_bd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd_tp1.SelectedIndexChanged
        If cbo_tipo_bd_tp1.Text = "BD MYSQL" Then

            var = 1
        Else
            var = 2


        End If
    End Sub

    Private Sub cmd_bus_may_fecha_Click(sender As Object, e As EventArgs) Handles cmd_bus_may_fecha.Click

        If var = 1 Then 'buscar por mysql


            Dim cmd2 As MySqlCommand = New MySqlCommand

            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            mifecha = msk_fe_ini2.Text

            cmd2.Connection = conexion
            cmd2.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total  FROM eck_cobranza.datos_fuente where FeVcto > '" & mifecha.ToString("yyyy-MM-dd") & "' and BCBalance > 0 group by Cobr_A order by nombre ASC ;"
            Dim dt2 As System.Data.DataTable = New System.Data.DataTable
            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd2)
            da2.Fill(dt2)

            grilla2.DataSource = dt2

            conexion.Close()
            da2.Dispose()
            cmd2.Dispose()
            lbl_reg.Text = ""


            For i As Integer = 0 To grilla2.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla2()
            Call SUMA_TOT(grilla2)
            cmd_exp_exc_grilla2.Enabled = True

        Else
            'busca en access
            mifecha = msk_fe_ini2.Text


            'estableces la connstring a la connection
            Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
            'Creas el comando SELECT

            Dim comando2 As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando2.Connection = Conn
            If Conn.State = 1 Then Conn.Close()


            comando2.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.fecha_vcto > '" & mifecha.ToString("yyyy-MM-dd") & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

            Conn.Open()


            Dim dt2 As System.Data.DataTable = New System.Data.DataTable
            Dim da2 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando2)
            da2.Fill(dt2)


            grilla2.DataSource = dt2


            Conn.Close()
            da2.Dispose()
            comando2.Dispose()

            For i As Integer = 0 To grilla2.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla2()
            Call SUMA_TOT(grilla2)
            cmd_exp_exc_grilla2.Enabled = True

        End If


    End Sub

    Private Sub cmd_bus_men_fecha_Click(sender As Object, e As EventArgs) Handles cmd_bus_men_fecha.Click

        If var = 1 Then  'busca en mysql

            Dim cmd3 As MySqlCommand = New MySqlCommand

            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()



            mifecha = msk_fe_ini3.Text


            cmd3.Connection = conexion
            cmd3.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total  FROM eck_cobranza.datos_fuente where FeVcto < '" & mifecha.ToString("yyyy-MM-dd") & "' and BCBalance > 0 group by Cobr_A order by nombre ASC ;"
            Dim dt3 As System.Data.DataTable = New System.Data.DataTable
            Dim da3 As MySqlDataAdapter = New MySqlDataAdapter(cmd3)
            da3.Fill(dt3)

            grilla3.DataSource = dt3

            conexion.Close()
            da3.Dispose()
            cmd3.Dispose()

            For i As Integer = 0 To grilla3.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next

            Call formato_grilla3()
            Call SUMA_TOT(grilla3)
            cmd_exp_exc_grilla3.Enabled = True
        Else

            'busca en access
            mifecha = msk_fe_ini.Text


            'estableces la connstring a la connection
            Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
            'Creas el comando SELECT

            Dim comando3 As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando3.Connection = Conn
            If Conn.State = 1 Then Conn.Close()


            comando3.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.fecha_vcto > '" & mifecha.ToString("yyyy-MM-dd") & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

            Conn.Open()


            Dim dt3 As System.Data.DataTable = New System.Data.DataTable
            Dim da3 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando3)
            da3.Fill(dt3)


            grilla3.DataSource = dt3


            Conn.Close()
            da3.Dispose()
            comando3.Dispose()

            For i As Integer = 0 To grilla3.Rows.Count() - 1

                i = +i
                lbl_reg.Text = i

            Next

            Call formato_grilla3()
            Call SUMA_TOT(grilla3)
            cmd_exp_exc_grilla3.Enabled = True

        End If

    End Sub

    Private Sub cmd_bus_rut4_Click(sender As Object, e As EventArgs) Handles cmd_bus_rut4.Click
        If var = 1 Then 'busca en mysql

            Dim cmd4 As MySqlCommand = New MySqlCommand

            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd4.Connection = conexion
            cmd4.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total FROM eck_cobranza.datos_fuente where Cobr_A = '" & txt_rut.Text & "' and cuenta = '1114001' group by Nombre Order by Nombre ASC"
            Dim dt4 As System.Data.DataTable = New System.Data.DataTable
            Dim da4 As MySqlDataAdapter = New MySqlDataAdapter(cmd4)
            da4.Fill(dt4)

            grilla4.DataSource = dt4

            conexion.Close()
            da4.Dispose()
            cmd4.Dispose()

            For i As Integer = 0 To grilla4.Rows.Count() Step +1

                i = +i
                lbl_reg.Text = i

            Next
            '  Call formato_grilla4()
            Call SUMA_TOT(grilla4)
            cmd_exp_exc_grilla4.Enabled = True

        Else
            'busca en mysql
            'estableces la connstring a la connection
            Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
            'Creas el comando SELECT

            Dim comando4 As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando4.Connection = Conn
            If Conn.State = 1 Then Conn.Close()


            comando4.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.Cobr_A = '" & txt_rut.Text & "' and cuenta = '1114001'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

            Conn.Open()


            Dim dt4 As System.Data.DataTable = New System.Data.DataTable
            Dim da4 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando4)
            da4.Fill(dt4)


            grilla4.DataSource = dt4

            Conn.Close()
            da4.Dispose()
            comando4.Dispose()

            For i As Integer = 0 To grilla4.Rows.Count() - 1

                i = +i
                lbl_reg.Text = i

            Next
            Call formato_grilla4()
            Call SUMA_TOT(grilla4)
            cmd_exp_exc_grilla4.Enabled = True

        End If

    End Sub


    Private Sub cmd_bus_vend5_Click(sender As Object, e As EventArgs) Handles cmd_bus_vend5.Click

        var = 1

        If var = 1 Then 'busca en mysql

            Dim cmd5 As MySqlCommand = New MySqlCommand

            conexion.Close()
            Call conn1()
            'If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd5.Connection = conexion
            'where cuenta = '1114001'
            cmd5.CommandText = "SELECT OrdenarNombre as Vendedor, Salesperson as codven, Sum(BCBalance) as Total FROM datos_fuente group by OrdenarNombre  Order by OrdenarNombre  ASC"
            Dim dt5 As System.Data.DataTable = New System.Data.DataTable
            Dim da5 As MySqlDataAdapter = New MySqlDataAdapter(cmd5)
            da5.Fill(dt5)

            grilla5.DataSource = dt5

            conexion.Close()
            da5.Dispose()
            cmd5.Dispose()

            For i As Integer = 0 To grilla5.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next
            ' Call formato_grilla5()
            Call SUMA_TOT(grilla5)
            cmd_exp_exc_grilla5.Enabled = True
        Else
            'busca en access
            'estableces la connstring a la connection
            Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
            'Creas el comando SELECT

            Dim comando5 As OleDbCommand = New OleDbCommand
            'Estableces la conexion activa
            comando5.Connection = Conn
            If Conn.State = 1 Then Conn.Close()


            comando5.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where vendedor = '" & lbl_cod_vend.Text & "' and cuenta = '1114001'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, vendedor Order by Datos_fuente.nombre_cliente ASC "

            Conn.Open()


            Dim dt5 As System.Data.DataTable = New System.Data.DataTable
            Dim da5 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando5)
            da5.Fill(dt5)


            grilla5.DataSource = dt5

            Conn.Close()
            da5.Dispose()
            comando5.Dispose()


            For i As Integer = 0 To grilla5.Rows.Count() - 1

                i = +i
                lbl_reg.Text = i

            Next

            ' Call formato_grilla5()
            Call SUMA_TOT(grilla5)
            cmd_exp_exc_grilla5.Enabled = True

        End If

    End Sub

    Private Sub cmd_bus_cuadro_anual6_Click(sender As Object, e As EventArgs) Handles cmd_bus_cuadro_anual6.Click
        Dim cmd6 As MySqlCommand = New MySqlCommand

        Call conn1()
        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        cmd6.Connection = conexion

        'cmd.CommandText = "SELECT nombre, Sum(BCBalance) tot  FROM datos_fuente  where FeVcto <= '2019-02-28' group by Cobr_A order by nombre ASC"
        cmd6.CommandText = "SELECT * FROM (SELECT DISTINCT Cobr_A, ltrim(rtrim(Nombre)), sum(case when MONTH(FeVcto) = 1 then BCBalance end) as ENE, sum(case when MONTH(FeVcto) = 2  then BCBalance end) as FEB, sum(case when MONTH(FeVcto) = 3 then BCBalance end) as MAR, sum(case when MONTH(FeVcto) = 4 then BCBalance end) as ABR, sum(case when MONTH(FeVcto) = 5 then BCBalance end) as MAY, sum(case when MONTH(FeVcto) = 6 then BCBalance end) as JUN, sum(case when MONTH(FeVcto) = 7 then BCBalance end) as JUL, sum(case when MONTH(FeVcto) = 8 then BCBalance end) as AGO, sum(case when MONTH(FeVcto) = 9 then BCBalance end) as SEP, sum(case when MONTH(FeVcto) = 10 then BCBalance end) as OCT, sum(case when MONTH(FeVcto) = 11 then BCBalance end) as NOV, sum(case when MONTH(FeVcto) = 12 then BCBalance end) as DIC, sum(CASE WHEN Left(TipoFact,4) = 'CRED' THEN  BCBalance * -1  else BCBalance end) as total
                                        FROM datos_fuente WHERE TipoFact Like 'INV%' and cuenta = '1114001' GROUP BY nombre 
                                            ORDER BY nombre ASC) as pivotable WHERE ENE > 0 or FEB > 0 or MAR > 0 or ABR > 0 or MAY > 0 or JUN > 0 or JUL > 0 or AGO > 0 or SEP > 0 or OCT > 0 or NOV > 0 or DIC > 0;"

        Dim dt6 As System.Data.DataTable = New System.Data.DataTable
        Dim da6 As MySqlDataAdapter = New MySqlDataAdapter(cmd6)
        da6.Fill(dt6)
        ' If dt.Rows.Count <> 0 Then
        grilla6.DataSource = dt6

        conexion.Close()
        da6.Dispose()
        cmd6.Dispose()

        For i As Integer = 0 To grilla6.Rows.Count() - 1 Step +1

            i = +i
            lbl_reg.Text = i

        Next

        Call formato_grilla6()
        cmd_exp_exc_grilla6.Enabled = True


    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_menu_Load(e, e) 'Load everything in your form load event again
        TC1.SelectedTab = TP1

    End Sub

    Private Sub cmd_limpiar2_Click(sender As Object, e As EventArgs) Handles cmd_limpiar2.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_menu_Load(e, e) 'Load everything in your form load event again
        TC1.SelectedTab = TP2
    End Sub

    Private Sub cmd_limpiar3_Click(sender As Object, e As EventArgs) Handles cmd_limpiar3.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_menu_Load(e, e) 'Load everything in your form load event again
        TC1.SelectedTab = TP3
    End Sub

    Private Sub cmd_limpiar4_Click(sender As Object, e As EventArgs) Handles cmd_limpiar4.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_menu_Load(e, e) 'Load everything in your form load event again
        TC1.SelectedTab = TP4
    End Sub

    Private Sub cmd_limpiar5_Click(sender As Object, e As EventArgs) Handles cmd_limpiar5.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_menu_Load(e, e) 'Load everything in your form load event again
        TC1.SelectedTab = TP5
    End Sub

    Private Sub cmd_limpiar6_Click(sender As Object, e As EventArgs) Handles cmd_limpiar6.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_menu_Load(e, e) 'Load everything in your form load event again
        TC1.SelectedTab = TP6
    End Sub

    Private Sub cmd_salir6_Click(sender As Object, e As EventArgs) Handles cmd_salir6.Click
        Dim valret6 As String
        valret6 = MsgBox("¿Desea salir del aplicativo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Abandonar el aplicativo")

        If valret6 = 6 Then
            End
        Else
            Exit Sub

        End If

    End Sub

    Private Sub cmd_salir5_Click(sender As Object, e As EventArgs) Handles cmd_salir5.Click
        Dim valret5 As String
        valret5 = MsgBox("¿Desea salir del aplicativo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Abandonar el aplicativo")

        If valret5 = 6 Then
            End
        Else
            Exit Sub

        End If
    End Sub

    Private Sub cmd_salir4_Click(sender As Object, e As EventArgs) Handles cmd_salir4.Click
        Dim valret4 As String
        valret4 = MsgBox("¿Desea salir del aplicativo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Abandonar el aplicativo")

        If valret4 = 6 Then
            End
        Else
            Exit Sub

        End If
    End Sub

    Private Sub cmd_salir3_Click(sender As Object, e As EventArgs) Handles cmd_salir3.Click
        Dim valret3 As String
        valret3 = MsgBox("¿Desea salir del aplicativo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Abandonar el aplicativo")

        If valret3 = 6 Then
            End
        Else
            Exit Sub

        End If
    End Sub

    Private Sub cmd_salir2_Click(sender As Object, e As EventArgs) Handles cmd_salir2.Click
        Dim valret2 As String
        valret2 = MsgBox("¿Desea salir del aplicativo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Abandonar el aplicativo")

        If valret2 = 6 Then
            End
        Else
            Exit Sub

        End If
    End Sub

    Private Sub cmd_salir1_Click(sender As Object, e As EventArgs) Handles cmd_salir1.Click
        Dim valret1 As String
        valret1 = MsgBox("¿Desea salir del aplicativo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Abandonar el aplicativo")

        If valret1 = 6 Then
            End
        Else
            Exit Sub

        End If
    End Sub



    Private Sub msk_fe_ini2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini2.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_ini2.Text <> "    -  -" Then


                cmd_bus_may_fecha.Enabled = True
                cmd_bus_may_fecha.Select()
            Else
                msk_fe_ini2.Select()

            End If

        End If
    End Sub



    Private Sub msk_fe_ini3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini3.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_ini3.Text <> "    -  -" Then


                cmd_bus_men_fecha.Enabled = True
                cmd_bus_men_fecha.Select()
            Else
                msk_fe_ini3.Select()

            End If

        End If
    End Sub

    Private Sub msk_fe_ini2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini2.MaskInputRejected

    End Sub

    Private Sub msk_fe_ini3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini3.MaskInputRejected

    End Sub



    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged

    End Sub

    Private Sub txt_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rut.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then
            If txt_rut.Text <> "" Then
                cmd_bus_rut4.Enabled = True
                cmd_bus_rut4.Select()
            Else
                txt_rut.Select()

            End If

        End If


    End Sub

    Private Sub cbo_tipo_bd_tp4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd_tp4.SelectedIndexChanged
        If cbo_tipo_bd_tp4.Text = "BD MYSQL" Then

            var = 1
            txt_rut.Select()

        Else
            var = 2
            txt_rut.Select()


        End If
    End Sub

    Private Sub cbo_tipo_bd_tp5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd_tp5.SelectedIndexChanged
        Select Case cbo_tipo_bd_tp1.Text
            Case "BD MYSQL"
                var = 1

                'Cargar Vendedores
                Call cargacombo("vendedor", "nombre", cbo_vend)
                cbo_vend.Select()

                ' cmd_exp_excel.Visible = True
                'cmd_exp_excel.Enabled = False
                'cmd_exp_excel_acc.Visible = False

            Case "BD ACCESS"

                'Call Carga_cta_access()

                var = 2
                'Cargar Vendedores
                Call cargacombo("vendedor", "nombre", cbo_vend)
                cbo_vend.Select()

                ' cmd_exp_excel.Visible = False
                ' cmd_exp_excel_acc.Visible = True
                ' cmd_exp_excel_acc.Enabled = False
        End Select
    End Sub





    Private Sub msk_fe_fin6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_fin6.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_fin6.Text <> "    -  -" Then


                cmd_bus_cuadro_anual6.Enabled = True
                cmd_bus_cuadro_anual6.Select()
            Else
                msk_fe_fin6.Select()

            End If

        End If

    End Sub

    Private Sub msk_fe_ini6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini6.MaskInputRejected

    End Sub

    Private Sub msk_fe_ini6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini6.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_ini6.Text <> "    -  -" Then

                msk_fe_fin6.Select()


            Else
                msk_fe_ini6.Select()

            End If

        End If
    End Sub



    Private Sub cbo_tipo_bd_tp2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd_tp2.SelectedIndexChanged
        If cbo_tipo_bd_tp2.Text = "BD MYSQL" Then

            var = 1
        Else
            var = 2


        End If
    End Sub

    Private Sub cbo_tipo_bd_tp3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd_tp3.SelectedIndexChanged
        If cbo_tipo_bd_tp3.Text = "BD MYSQL" Then

            var = 1
        Else
            var = 2


        End If
    End Sub

    Private Sub cbo_tipo_bd_tp6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd_tp6.SelectedIndexChanged
        If cbo_tipo_bd_tp6.Text = "BD MYSQL" Then

            var = 1
        Else
            var = 2


        End If
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        If var = 1 Then

            Call Exp_Excel(grilla1)

        Else
            Call Exp_excel_access(grilla1)

        End If
    End Sub

    Private Sub txt_bus_grilla1_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla1.TextChanged

    End Sub

    Private Sub txt_bus_grilla1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla1.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCAR

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla1.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_bus_grilla1.CharacterCasing = CharacterCasing.Upper

                For r As Integer = 1 To Me.grilla1.Rows.Count - 2

                    For x As Integer = 0 To grilla1.ColumnCount - 1

                        If grilla1.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla1.CurrentCell = grilla1.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla1.CurrentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke
                            grilla1.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmd_exp_exc_grilla2_Click(sender As Object, e As EventArgs) Handles cmd_exp_exc_grilla2.Click
        If var = 1 Then

            Call Exp_Excel(grilla2)

        Else
            Call Exp_excel_access(grilla2)

        End If
    End Sub



    Private Sub TC1_MouseClick(sender As Object, e As MouseEventArgs) Handles TC1.MouseClick

        Select Case TC1.SelectedIndex
            Case 0


                txt_bus_grilla1.Visible = True
                txt_bus_grilla2.Visible = False
                txt_bus_grilla3.Visible = False
                txt_bus_grilla4.Visible = False
                txt_bus_grilla5.Visible = False
                txt_bus_grilla6.Visible = False

            Case 1

                txt_bus_grilla1.Visible = False
                txt_bus_grilla2.Visible = True
                txt_bus_grilla3.Visible = False
                txt_bus_grilla4.Visible = False
                txt_bus_grilla5.Visible = False
                txt_bus_grilla6.Visible = False
            Case 2


                txt_bus_grilla1.Visible = False
                txt_bus_grilla2.Visible = False
                txt_bus_grilla3.Visible = True
                txt_bus_grilla4.Visible = False
                txt_bus_grilla5.Visible = False
                txt_bus_grilla6.Visible = False
            Case 3


                txt_bus_grilla1.Visible = False
                txt_bus_grilla2.Visible = False
                txt_bus_grilla3.Visible = False
                txt_bus_grilla4.Visible = True
                txt_bus_grilla5.Visible = False
                txt_bus_grilla6.Visible = False
            Case 4


                txt_bus_grilla1.Visible = False
                txt_bus_grilla2.Visible = False
                txt_bus_grilla3.Visible = False
                txt_bus_grilla4.Visible = False
                txt_bus_grilla5.Visible = True
                txt_bus_grilla6.Visible = False
            Case 5


                txt_bus_grilla1.Visible = False
                txt_bus_grilla2.Visible = False
                txt_bus_grilla3.Visible = False
                txt_bus_grilla4.Visible = False
                txt_bus_grilla5.Visible = False
                txt_bus_grilla6.Visible = True

        End Select


    End Sub

    Private Sub txt_bus_grilla2_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla2.TextChanged

    End Sub

    Private Sub txt_bus_grilla2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla2.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCAR

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla2.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_bus_grilla2.CharacterCasing = CharacterCasing.Upper

                For r As Integer = 1 To Me.grilla2.Rows.Count - 2

                    For x As Integer = 0 To grilla2.ColumnCount - 1

                        If grilla2.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla2.CurrentCell = grilla2.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla2.CurrentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke
                            grilla2.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_bus_grilla6_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla6.TextChanged

    End Sub

    Private Sub txt_bus_grilla6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla6.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCAR

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla6.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_bus_grilla6.CharacterCasing = CharacterCasing.Upper

                For r As Integer = 1 To Me.grilla6.Rows.Count - 2

                    For x As Integer = 0 To grilla6.ColumnCount - 1

                        If grilla6.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla6.CurrentCell = grilla6.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla6.CurrentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke
                            grilla6.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_bus_grilla5_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_grilla5.TextChanged

    End Sub

    Private Sub txt_bus_grilla5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_grilla5.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCAR

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_grilla5.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_bus_grilla5.CharacterCasing = CharacterCasing.Upper

                For r As Integer = 1 To Me.grilla5.Rows.Count - 2

                    For x As Integer = 0 To grilla5.ColumnCount - 1

                        If grilla5.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla5.CurrentCell = grilla5.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla5.CurrentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke
                            grilla5.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TP1_Click(sender As Object, e As EventArgs) Handles TP1.Click

    End Sub

    Private Sub grilla4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla4.CellContentClick

    End Sub

    Private Sub TP2_Click(sender As Object, e As EventArgs) Handles TP2.Click

    End Sub

    Private Sub cmd_exp_exc_grilla3_Click(sender As Object, e As EventArgs) Handles cmd_exp_exc_grilla3.Click
        If var = 1 Then

            Call Exp_Excel(grilla3)

        Else
            Call Exp_excel_access(grilla3)

        End If
    End Sub

    Private Sub cmd_exp_exc_grilla4_Click(sender As Object, e As EventArgs) Handles cmd_exp_exc_grilla4.Click
        If var = 1 Then

            Call Exp_Excel(grilla4)

        Else
            Call Exp_excel_access(grilla4)

        End If
    End Sub

    Private Sub cmd_exp_exc_grilla5_Click(sender As Object, e As EventArgs) Handles cmd_exp_exc_grilla5.Click
        If var = 1 Then

            Call Exp_Excel(grilla5)

        Else
            Call Exp_excel_access(grilla5)

        End If
    End Sub

    Private Sub cmd_exp_exc_grilla6_Click(sender As Object, e As EventArgs) Handles cmd_exp_exc_grilla6.Click


        Call Exp_Excel(grilla6)


    End Sub

    Private Sub grilla1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla1.CellContentClick

    End Sub

    Private Sub grilla1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla1.CellMouseDoubleClick
        If var = 1 Then
            'carga con mysql

            Dim cmd12 As MySqlCommand = New MySqlCommand

            conexion.Close()
            Call conn1()
            'If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd12.Connection = conexion


            cmd12.CommandText = "SELECT FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario FROM eck_cobranza.datos_fuente where Cobr_A = '" & grilla1.Item(0, e.RowIndex).Value & "' And Salesperson = '" & grilla1.Item(3, e.RowIndex).Value & "'"
            Dim dt12 As System.Data.DataTable = New System.Data.DataTable
            Dim da12 As MySqlDataAdapter = New MySqlDataAdapter(cmd12)
            da12.Fill(dt12)


            frm_detalle_fact.lbl_rut.Text = grilla1.Item(0, e.RowIndex).Value
            frm_detalle_fact.lbl_cliente.Text = grilla1.Item(1, e.RowIndex).Value

            frm_detalle_fact.grilla_det.DataSource = dt12

            conexion.Close()
            da12.Dispose()
            cmd12.Dispose()

            frm_detalle_fact.Show()

            Call formato_grilla7()


        Else

            'carga con access

        End If
    End Sub

    Private Sub grilla5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla5.CellContentClick

    End Sub

    Private Sub grilla5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grilla5.MouseDoubleClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
