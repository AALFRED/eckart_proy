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


Public Class frm_detalle_fact


    Sub formato_grilla()

        'FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario
        'FORMATO DE grilla
        grilla_det.Columns(0).HeaderCell.Value = "Fe.Registro"
        grilla_det.Columns(1).HeaderCell.Value = "Tipo Docto"
        grilla_det.Columns(2).HeaderCell.Value = "Nro Docto"
        grilla_det.Columns(3).HeaderCell.Value = "Nro Factura"
        grilla_det.Columns(4).HeaderCell.Value = "Fe. Docto."
        grilla_det.Columns(5).HeaderCell.Value = "Fe. Vcto"
        grilla_det.Columns(6).HeaderCell.Value = "Monto docto."
        grilla_det.Columns(7).HeaderCell.Value = "BC Balance"
        grilla_det.Columns(8).HeaderCell.Value = "Cuenta"
        grilla_det.Columns(9).HeaderCell.Value = "Voucher"
        grilla_det.Columns(10).HeaderCell.Value = "Ldiario"


        grilla_det.Columns(8).Visible = False 'cuenta
        grilla_det.Columns(10).Visible = False 'ldiario


        grilla_det.Columns(0).Width = 70
        grilla_det.Columns(1).Width = 80
        grilla_det.Columns(2).Width = 120
        grilla_det.Columns(3).Width = 90
        grilla_det.Columns(4).Width = 90
        grilla_det.Columns(5).Width = 80
        grilla_det.Columns(6).Width = 80
        grilla_det.Columns(7).Width = 90
        grilla_det.Columns(8).Width = 70
        grilla_det.Columns(9).Width = 80
        grilla_det.Columns(10).Width = 50


        grilla_det.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla_det.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla_det.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla_det.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla_det.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        grilla_det.Columns(6).DefaultCellStyle.Format = "C0"
        grilla_det.Columns(7).DefaultCellStyle.Format = "C0"
        grilla_det.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla_det.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla_det.RowsDefaultCellStyle.BackColor = Color.White
        grilla_det.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla_det.GridColor = Color.Black
        grilla_det.BorderStyle = BorderStyle.Fixed3D

        grilla_det.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla_det.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla_det.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla_det.Sort(grilla_det.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla_det.RowHeadersVisible = False 'oculta la primera columna

        grilla_det.Refresh()

    End Sub

    Sub Exp_Excel(migrilla2 As DataGridView)  'MYSQL
        Try



            If ((migrilla2.Columns.Count = 0) Or (migrilla2.Rows.Count = 0)) Then
                MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
                'Exit Sub
            Else

                Dim dt As New System.Data.DataTable
                dt = TryCast(migrilla2.DataSource, System.Data.DataTable)

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_det_fact_cuadro_anual.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_det_fact_cuadro_anual.xlsx")
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


    Sub Exp_Excel2(grilla As DataGridView)

        If ((grilla.Columns.Count = 0) Or (grilla.Rows.Count = 0)) Then
            MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
            'Exit Sub
        Else
            'Creando Dataset para Exportar
            Dim dset As New DataSet
            'Agregar tabla al Dataset
            dset.Tables.Add()
            'AGregar Columna a la tabla
            For i As Integer = 0 To grilla.ColumnCount - 1
                dset.Tables(0).Columns.Add(grilla.Columns(i).HeaderText)
            Next

            'Agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To grilla.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To grilla.Columns.Count - 1
                    dr1(j) = grilla.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim aplicacion As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = aplicacion.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                aplicacion.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

                Next
            Next

            'Configurar la orientacion de la  hoja y el tamaño
            ' wSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape
            '  wSheet.PageSetup.PaperSize = XlPaperSize.xlPaperLegal
            'Configurar con negrilla la cabecera y tenga autofit
            wSheet.Rows.Item(1).Font.Bold = 1
            wSheet.Columns.AutoFit()

            ' Dim strFileName As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory) & "Temp\Rep_OC_NoFacturada"
            Dim strFileName As String = "C:\eckart\proyecto Cobranzas\temp\exp_det_fact_cuadro_anual.xlsx"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If
            MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            wBook.SaveAs(strFileName)
            aplicacion.Workbooks.Open(strFileName)
            aplicacion.Visible = True


        End If

    End Sub








    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()

    End Sub

    Private Sub frm_detalle_fact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - MONTOS TOTALES"


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
        BarraStatusTime.Text = FormatDateTime(Now(), DateFormat.LongTime)
        BarraStatusTime.AutoSize = StatusBarPanelAutoSize.Contents
        BarraStatus.Panels.Add(BarraStatusTime)

        Dim BarraStatusTexto = New StatusBarPanel
        BarraStatusTexto.Name = "StatusBartexto"
        BarraStatusTexto.Width = 200
        BarraStatusTexto.Text = "CONECTADO A BD : Aux Cobranzas BD"
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)
    End Sub

    Private Sub frm_detalle_fact_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_cuadro_anual.Show()
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        'Call Exp_Excel(grilla_det)

        Dim valret3 As Integer = MsgBox("¿Desea Exportar las cuentas a Excel de la grilla?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Procesar Solicitudes de Venta")

        If valret3 = 6 Then

            Call Exp_Excel2(grilla_det)
        Else
            Exit Sub
        End If
    End Sub
End Class