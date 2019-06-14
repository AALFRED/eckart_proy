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

Public Class frm_incobrables

    Dim var As Integer
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim com As New MySqlCommand
    Dim rs As MySqlDataReader

    Private mifecha As Date
    Private mifecha2 As Date

    Dim varmarca As Integer
    Dim tot_vend As Long

    Sub Exp_excel_access()
        If ((grilla.Columns.Count = 0) Or (grilla.Rows.Count = 0)) Then
            MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
            'Exit Sub
        Else
            Dim dt As New System.Data.DataTable
            dt = TryCast(grilla.DataSource, System.Data.DataTable)

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
    Sub Exp_Excel(grilla As DataGridView)


        If ((grilla.Columns.Count = 0) Or (grilla.Rows.Count = 0)) Then
            MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
            'Exit Sub
        Else
            ''Creando Dataset para Exportar
            'Dim dset As New DataSet
            ''Agregar tabla al Dataset
            'dset.Tables.Add()
            ''AGregar Columna a la tabla
            'For i As Integer = 0 To grilla.ColumnCount - 1
            '    dset.Tables(0).Columns.Add(grilla.Columns(i).HeaderText)
            'Next

            ''Agregar filas a la tabla
            'Dim dr1 As DataRow
            'For i As Integer = 0 To grilla.RowCount - 1
            '    dr1 = dset.Tables(0).NewRow
            '    For j As Integer = 0 To grilla.Columns.Count - 1
            '        dr1(j) = grilla.Rows(i).Cells(j).Value
            '    Next
            '    dset.Tables(0).Rows.Add(dr1)
            'Next



            'Dim aplicacion As New Microsoft.Office.Interop.Excel.Application

            'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            'Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            'wBook = aplicacion.Workbooks.Add()

            'wSheet = wBook.ActiveSheet()

            'Dim dt As System.Data.DataTable = dset.Tables(0)
            'Dim dc As System.Data.DataColumn
            'Dim dr As System.Data.DataRow
            'Dim colIndex As Integer = 0
            'Dim rowIndex As Integer = 0

            'For Each dc In dt.Columns
            '    colIndex = colIndex + 1
            '    aplicacion.Cells(1, colIndex) = dc.ColumnName
            'Next

            'For Each dr In dt.Rows
            '    rowIndex = rowIndex + 1
            '    colIndex = 0
            '    For Each dc In dt.Columns
            '        colIndex = colIndex + 1
            '        aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            '    Next
            'Next

            ''Configurar la orientacion de la  hoja y el tamaño
            '' wSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape
            '' wSheet.PageSetup.PaperSize = XlPaperSize.xlPaperLegal
            ''Configurar con negrilla la cabecera y tenga autofit
            'wSheet.Rows.Item(1).Font.Bold = 1
            'wSheet.Columns.AutoFit()

            'Dim strFileName As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory) & "Temp\Reporte_cob_eck.xlsx"
            'Dim blnFileOpen As Boolean = False
            'Try
            '    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            '    fileTemp.Close()
            'Catch ex As Exception
            '    blnFileOpen = False
            'End Try

            'If System.IO.File.Exists(strFileName) Then
            '    System.IO.File.Delete(strFileName)
            'End If


            Dim dt As New System.Data.DataTable
            dt = TryCast(grilla.DataSource, System.Data.DataTable)

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
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Vendedor"
        grilla.Columns(3).HeaderCell.Value = "Total"



        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 300
        grilla.Columns(2).Width = 300
        grilla.Columns(3).Width = 120




        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(3).DefaultCellStyle.Format = "C2"

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


    Sub formato_grilla2()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Vendedor"
        grilla.Columns(3).HeaderCell.Value = "Total"



        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 300
        grilla.Columns(2).Width = 300
        grilla.Columns(3).Width = 120




        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(3).DefaultCellStyle.Format = "C2"

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

    Sub formato_grilla3()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Vendedor"
        grilla.Columns(3).HeaderCell.Value = "Total"



        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 300
        grilla.Columns(2).Width = 300
        grilla.Columns(3).Width = 120




        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(3).DefaultCellStyle.Format = "C2"

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


    Sub formato_grilla4()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Vendedor"
        grilla.Columns(3).HeaderCell.Value = "Total"



        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 300
        grilla.Columns(2).Width = 300
        grilla.Columns(3).Width = 120


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(3).DefaultCellStyle.Format = "C2"

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

    Sub formato_grilla5()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Total"
        grilla.Columns(3).HeaderCell.Value = "Vendedor"


        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 300
        grilla.Columns(2).Width = 150
        grilla.Columns(3).Width = 220


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        grilla.Columns(2).DefaultCellStyle.Format = "C2"

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


    Sub formato_grilla6()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "ENE"
        grilla.Columns(3).HeaderCell.Value = "FEB"
        grilla.Columns(4).HeaderCell.Value = "MAR"
        grilla.Columns(5).HeaderCell.Value = "ABR"
        grilla.Columns(6).HeaderCell.Value = "MAY"
        grilla.Columns(7).HeaderCell.Value = "JUN"
        grilla.Columns(8).HeaderCell.Value = "JUL"
        grilla.Columns(9).HeaderCell.Value = "AGO"
        grilla.Columns(10).HeaderCell.Value = "SEP"
        grilla.Columns(11).HeaderCell.Value = "OCT"
        grilla.Columns(12).HeaderCell.Value = "NOV"
        grilla.Columns(13).HeaderCell.Value = "DIC"
        grilla.Columns(14).HeaderCell.Value = "TOTAL"


        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 320
        grilla.Columns(2).Width = 80
        grilla.Columns(3).Width = 80
        grilla.Columns(4).Width = 80
        grilla.Columns(5).Width = 80
        grilla.Columns(6).Width = 80
        grilla.Columns(7).Width = 80
        grilla.Columns(8).Width = 80
        grilla.Columns(9).Width = 80
        grilla.Columns(10).Width = 80
        grilla.Columns(11).Width = 80
        grilla.Columns(12).Width = 80
        grilla.Columns(13).Width = 80
        grilla.Columns(14).Width = 80


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        grilla.RowsDefaultCellStyle.ForeColor = Color.White
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        grilla.Refresh()

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

    Sub SUMATOTVEND()

        ' Try

        tot_vend = 0


        'suma los montos 
        With grilla
            For fila = 0 To .Rows.Count - 1
                If IsDBNull(.Item("Total", fila).Value) Then
                    .Item("Total", fila).Value = 0
                Else
                    tot_vend = tot_vend + CDbl(.Item("Total", fila).Value)
                End If





            Next

            lbl_total_vend.Text = tot_vend.ToString()


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

    Sub Carga_cta_mysql()


        If Connex = 1 Then
            Call conn1() 'local
        Else
            Call Conectar() 'red
        End If
        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        cmd = New MySqlCommand("select distinct cuenta from datos_fuente ", conexion)


        dr = cmd.ExecuteReader
        cbo_cta.Items.Clear()
        Do While dr.Read()
            cbo_cta.Items.Add(dr("cuenta"))
        Loop
        dr.Close()
        conexion.Close()
    End Sub

    Sub Carga_cta_access()
        'conecta a access

        If Con3.State = 1 Then Con3.Close()
        Con3.Open()


        Dim sql As String = "select distinct cuenta from datos_fuente"
        Dim cmd As New OleDbCommand(sql, Con3)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New System.Data.DataTable()
        da.Fill(dt)
        cbo_cta.DataSource = dt
        cbo_cta.DisplayMember = "cuenta"
        cbo_cta.ValueMember = "cuenta"
    End Sub





    Private Sub frm_incobrables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        'carga de tipo de bd
        cbo_tipo_bd.Items.Add("BD MYSQL")
        cbo_tipo_bd.Items.Add("BD ACCESS")

        'carga filtro
        cbo_filtro.Items.Add("Rango de Fechas")
        cbo_filtro.Items.Add("Mayor a Fecha Vcto")
        cbo_filtro.Items.Add("Menor a Fecha Vcto")
        cbo_filtro.Items.Add("Por Rut")
        cbo_filtro.Items.Add("Por Vendedor")
        cbo_filtro.Items.Add("Cuadro Anual")


        'control de carga
        cmd_buscar.Enabled = False
        cmd_exp_excel.Enabled = False


        Label4.Visible = False
        txt_rut.Visible = False
        lbl_reg.Text = ""

        'opcion entre fechas
        Label5.Visible = False
        Label6.Visible = False
        msk_fe_ini.Visible = False
        msk_fe_fin.Visible = False


        'exportacion
        cmd_exp_excel.Visible = False
        cmd_exp_excel_acc.Visible = False


        'opcion buscar vendedor
        Label8.Visible = False
        lbl_cod_vend.Visible = False
        cbo_vend.Visible = False

        lbl_total_vend.Text = ""



    End Sub

    Private Sub frm_incobrables_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_menu.Show()

    End Sub

    Private Sub cbo_tipo_bd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd.SelectedIndexChanged

        Select Case cbo_tipo_bd.Text
            Case "BD MYSQL"
                var = 1
                Call Carga_cta_mysql()
                'Cargar Vendedores

                Call cargacombo("vendedor", "nombre", cbo_vend)
                cmd_exp_excel.Visible = True
                cmd_exp_excel.Enabled = False
                cmd_exp_excel_acc.Visible = False

            Case "BD ACCESS"

                Call Carga_cta_access()

                var = 2
                'Cargar Vendedores
                Call cargacombo("vendedor", "nombre", cbo_vend)
                cmd_exp_excel.Visible = False
                cmd_exp_excel_acc.Visible = True
                cmd_exp_excel_acc.Enabled = False
        End Select
    End Sub

    Private Sub cbo_cta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_cta.SelectedIndexChanged


    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click


        If var = 1 Then 'buscar por mysql

            Select Case varmarca
                Case 1 'Rango de Fechas
                    Dim cmd1 As MySqlCommand = New MySqlCommand

                    ' conexion.Close()
                    If Connex = 1 Then
                        Call conn1() 'local
                    Else
                        Call Conectar() 'red
                    End If
                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    mifecha = msk_fe_ini.Text
                    mifecha2 = msk_fe_fin.Text

                    cmd1.Connection = conexion
                    cmd1.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Sum(BCBalance) as Total  FROM eck_cobranza.datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and BCBalance > 0 and cuenta = '" & cbo_cta.Text & "' group by Cobr_A order by nombre ASC;"

                    Dim dt1 As System.Data.DataTable = New System.Data.DataTable
                    Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
                    da1.Fill(dt1)

                    grilla.DataSource = dt1

                    conexion.Close()
                    da1.Dispose()
                    cmd1.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla1()

                    cmd_exp_excel.Enabled = True

                Case 2 'Mayor a Fecha Vcto

                    Dim cmd2 As MySqlCommand = New MySqlCommand

                    If Connex = 1 Then
                        Call conn1() 'local
                    Else
                        Call Conectar() 'red
                    End If
                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    mifecha = msk_fe_ini.Text

                    cmd2.Connection = conexion
                    cmd2.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre As Vendedor, Sum(BCBalance) As Total  FROM eck_cobranza.datos_fuente where FeVcto > '" & mifecha.ToString("yyyy-MM-dd") & "' and BCBalance > 0 group by Cobr_A order by nombre ASC ;"
                    Dim dt2 As System.Data.DataTable = New System.Data.DataTable
                    Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd2)
                    da2.Fill(dt2)

                    grilla.DataSource = dt2

                    conexion.Close()
                    da2.Dispose()
                    cmd2.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla2()

                    cmd_exp_excel.Enabled = True


                Case 3 'Menor a Fecha Vcto

                    Dim cmd3 As MySqlCommand = New MySqlCommand

                    If Connex = 1 Then
                        Call conn1()
                    Else
                        Call Conectar() 'red
                    End If
                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    mifecha = msk_fe_ini.Text

                    cmd3.Connection = conexion
                    cmd3.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Sum(BCBalance) As Total  FROM eck_cobranza.datos_fuente where FeVcto < '" & mifecha.ToString("yyyy-MM-dd") & "' and BCBalance > 0 group by Cobr_A order by nombre ASC ;"
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

                    Call formato_grilla3()

                    cmd_exp_excel.Enabled = True



                Case 4 'Por Rut
                    Dim cmd4 As MySqlCommand = New MySqlCommand

                    If Connex = 1 Then
                        Call conn1()
                    Else
                        Call Conectar() 'red
                    End If
                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()
                    cmd4.Connection = conexion
                    cmd4.CommandText = "SELECT Cobr_A, nombre, OrdenarNombre as Vendedor, Sum(BCBalance) As Total FROM eck_cobranza.datos_fuente where Cobr_A = '" & txt_rut.Text & "' and cuenta = '" & cbo_cta.Text & "' group by Nombre Order by Nombre ASC"
                    Dim dt4 As System.Data.DataTable = New System.Data.DataTable
                    Dim da4 As MySqlDataAdapter = New MySqlDataAdapter(cmd4)
                    da4.Fill(dt4)

                    grilla.DataSource = dt4

                    conexion.Close()
                    da4.Dispose()
                    cmd4.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla4()

                    cmd_exp_excel.Enabled = True

                Case 5 'Por Vendedor
                    Dim cmd5 As MySqlCommand = New MySqlCommand

                    conexion.Close()
                    If Connex = 1 Then
                        Call conn1()
                    Else
                        Call Conectar() 'red
                    End If
                    'If conexion.State = 1 Then conexion.Close()
                    conexion.Open()
                    cmd5.Connection = conexion

                    cmd5.CommandText = "SELECT Cobr_A, Nombre, Sum(BCBalance) as total, OrdenarNombre as Vend FROM eck_cobranza.datos_fuente where cast(Salesperson as unsigned) = '" & lbl_cod_vend.Text & "' and cuenta = '" & cbo_cta.Text & "' group by Nombre Order by Nombre ASC"
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

                    Call formato_grilla5()
                    Call SUMATOTVEND()
                    cmd_exp_excel.Enabled = True

                Case 6 'cuadro anual

                    'conecta mysql
                    Dim cmd6 As MySqlCommand = New MySqlCommand

                    If Connex = 1 Then
                        Call conn1()
                    Else
                        Call Conectar() 'red
                    End If
                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    cmd6.Connection = conexion

                    'cmd.CommandText = "SELECT nombre, Sum(BCBalance) tot  FROM datos_fuente  where FeVcto <= '2019-02-28' group by Cobr_A order by nombre ASC"
                    cmd6.CommandText = "SELECT * FROM (SELECT DISTINCT Cobr_A, ltrim(rtrim(Nombre)), sum(case when MONTH(FeVcto) = 1 then BCBalance end) as ENE, sum(case when MONTH(FeVcto) = 2  then BCBalance end) as FEB, sum(case when MONTH(FeVcto) = 3 then BCBalance end) as MAR, sum(case when MONTH(FeVcto) = 4 then BCBalance end) as ABR, sum(case when MONTH(FeVcto) = 5 then BCBalance end) as MAY, sum(case when MONTH(FeVcto) = 6 then BCBalance end) as JUN, sum(case when MONTH(FeVcto) = 7 then BCBalance end) as JUL, sum(case when MONTH(FeVcto) = 8 then BCBalance end) as AGO, sum(case when MONTH(FeVcto) = 9 then BCBalance end) as SEP, sum(case when MONTH(FeVcto) = 10 then BCBalance end) as OCT, sum(case when MONTH(FeVcto) = 11 then BCBalance end) as NOV, sum(case when MONTH(FeVcto) = 12 then BCBalance end) as DIC, sum(CASE WHEN Left(TipoFact,4) = 'CRED' THEN  BCBalance * -1  else BCBalance end) as total
                                        FROM datos_fuente WHERE TipoFact Like 'INV%' and cuenta = '" & cbo_cta.Text & "' GROUP BY nombre 
                                            ORDER BY nombre ASC) as pivotable WHERE ENE > 0 or FEB > 0 or MAR > 0 or ABR > 0 or MAY > 0 or JUN > 0 or JUL > 0 or AGO > 0 or SEP > 0 or OCT > 0 or NOV > 0 or DIC > 0;"

                    Dim dt6 As System.Data.DataTable = New System.Data.DataTable
                    Dim da6 As MySqlDataAdapter = New MySqlDataAdapter(cmd6)
                    da6.Fill(dt6)
                    ' If dt.Rows.Count <> 0 Then
                    grilla.DataSource = dt6

                    conexion.Close()
                    da6.Dispose()
                    cmd6.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla6()
                    cmd_exp_excel.Enabled = True

            End Select






        Else
            '////////////////////////////////////
            'BUSQUEDAS POR ACCESS
            '////////////////////////////////////

            Select Case varmarca
                Case 1 'Rango de Fechas
                    mifecha = msk_fe_ini.Text
                    mifecha2 = msk_fe_fin.Text

                    'estableces la connstring a la connection
                    Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                    'Creas el comando SELECT

                    Dim comando As OleDbCommand = New OleDbCommand
                    'Estableces la conexion activa
                    comando.Connection = Conn
                    If Conn.State = 1 Then Conn.Close()


                    comando.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.fecha_vcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend Order by Datos_fuente.nombre_cliente ASC "

                    Conn.Open()


                    Dim dt As System.Data.DataTable = New System.Data.DataTable
                    Dim da As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando)
                    da.Fill(dt)


                    grilla.DataSource = dt


                    Conn.Close()
                    da.Dispose()
                    comando.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next
                    Call formato_grilla1()
                    cmd_exp_excel_acc.Enabled = True


                Case 2 'Mayor a Fecha Vcto

                    mifecha = msk_fe_ini.Text


                    'estableces la connstring a la connection
                    Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                    'Creas el comando SELECT

                    Dim comando2 As OleDbCommand = New OleDbCommand
                    'Estableces la conexion activa
                    comando2.Connection = Conn
                    If Conn.State = 1 Then Conn.Close()


                    comando2.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.fecha_vcto > '" & mifecha.ToString("yyyy-MM-dd") & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend Order by Datos_fuente.nombre_cliente ASC "

                    Conn.Open()


                    Dim dt2 As System.Data.DataTable = New System.Data.DataTable
                    Dim da2 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando2)
                    da2.Fill(dt2)


                    grilla.DataSource = dt2


                    Conn.Close()
                    da2.Dispose()
                    comando2.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next
                    Call formato_grilla2()
                    cmd_exp_excel_acc.Enabled = True

                Case 3 'Menor a Fecha Vcto

                    mifecha = msk_fe_ini.Text


                    'estableces la connstring a la connection
                    Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                    'Creas el comando SELECT

                    Dim comando3 As OleDbCommand = New OleDbCommand
                    'Estableces la conexion activa
                    comando3.Connection = Conn
                    If Conn.State = 1 Then Conn.Close()


                    comando3.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.fecha_vcto > '" & mifecha.ToString("yyyy-MM-dd") & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend Order by Datos_fuente.nombre_cliente ASC "

                    Conn.Open()


                    Dim dt3 As System.Data.DataTable = New System.Data.DataTable
                    Dim da3 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando3)
                    da3.Fill(dt3)


                    grilla.DataSource = dt3


                    Conn.Close()
                    da3.Dispose()
                    comando3.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla3()
                    cmd_exp_excel_acc.Enabled = True


                Case 4 'Por Rut

                    'estableces la connstring a la connection
                    Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                    'Creas el comando SELECT

                    Dim comando4 As OleDbCommand = New OleDbCommand
                    'Estableces la conexion activa
                    comando4.Connection = Conn
                    If Conn.State = 1 Then Conn.Close()


                    comando4.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend, Sum(Datos_fuente.bc_balance) AS Total FROM Datos_fuente Where Datos_fuente.Cobr_A = '" & txt_rut.Text & "' and cuenta = '" & cbo_cta.Text & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend Order by Datos_fuente.nombre_cliente ASC "

                    Conn.Open()


                    Dim dt4 As System.Data.DataTable = New System.Data.DataTable
                    Dim da4 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando4)
                    da4.Fill(dt4)


                    grilla.DataSource = dt4

                    Conn.Close()
                    da4.Dispose()
                    comando4.Dispose()

                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next

                    Call formato_grilla4()
                    cmd_exp_excel_acc.Enabled = True


                Case 5 'Por Vendedor

                    'estableces la connstring a la connection
                    Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                    'Creas el comando SELECT

                    Dim comando5 As OleDbCommand = New OleDbCommand
                    'Estableces la conexion activa
                    comando5.Connection = Conn
                    If Conn.State = 1 Then Conn.Close()


                    comando5.CommandText = "SELECT Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Sum(Datos_fuente.bc_balance) AS Total, Datos_fuente.Nombre_Vend FROM Datos_fuente Where vendedor = '" & lbl_cod_vend.Text & "' and cuenta = '" & cbo_cta.Text & "'  GROUP BY Datos_fuente.Cobr_A, Datos_fuente.nombre_cliente, Datos_fuente.Nombre_Vend Order by Datos_fuente.nombre_cliente ASC "

                    Conn.Open()


                    Dim dt5 As System.Data.DataTable = New System.Data.DataTable
                    Dim da5 As System.Data.OleDb.OleDbDataAdapter = New OleDbDataAdapter(comando5)
                    da5.Fill(dt5)


                    grilla.DataSource = dt5

                    Conn.Close()
                    da5.Dispose()
                    comando5.Dispose()


                    For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                        i = +i
                        lbl_reg.Text = i

                    Next
                    Call formato_grilla5()
                    cmd_exp_excel_acc.Enabled = True

                Case 6 'cuadro anual

                    MsgBox("No disponible")

                    'If Con3.State = 1 Then Con3.Close()
                    'Con3.Open()

                    'Dim da6 As New OleDbDataAdapter("SELECT * FROM (SELECT DISTINCT Cobr_A, Nombre, sum(case when MONTH(FeVcto) = 1 then BCBalance end) as ENE, sum(case when MONTH(FeVcto) = 2  then BCBalance end) as FEB, sum(case when MONTH(FeVcto) = 3 then BCBalance end) as MAR, sum(case when MONTH(FeVcto) = 4 then BCBalance end) as ABR, sum(case when MONTH(FeVcto) = 5 then BCBalance end) as MAY, sum(case when MONTH(FeVcto) = 6 then BCBalance end) as JUN, sum(case when MONTH(FeVcto) = 7 then BCBalance end) as JUL, sum(case when MONTH(FeVcto) = 8 then BCBalance end) as AGO, sum(case when MONTH(FeVcto) = 9 then BCBalance end) as SEP, sum(case when MONTH(FeVcto) = 10 then BCBalance end) as OCT, sum(case when MONTH(FeVcto) = 11 then BCBalance end) as NOV, sum(case when MONTH(FeVcto) = 12 then BCBalance end) as DIC, sum(CASE WHEN Left(TipoFact,4) = 'CRED' THEN  BCBalance * -1  else BCBalance end) as total
                    '                    FROM datos_fuente WHERE TipoFact Like 'INV%' GROUP BY nombre
                    '                        ORDER BY nombre ASC) as pivotable WHERE ENE > 0 or FEB > 0 or MAR > 0 or ABR > 0 or MAY > 0 or JUN > 0 or JUL > 0 or AGO > 0 or SEP > 0 or OCT > 0 or NOV > 0 or DIC > 0;", Con3)
                    'Dim ds6 As New DataSet

                    'da6.Fill(ds6)
                    'grilla.DataSource = ds6.Tables(0)
                    'Con3.Close()

            End Select
        End If

    End Sub

    Private Sub cbo_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_filtro.SelectedIndexChanged



        Select Case cbo_filtro.Text

            Case "Rango de Fechas"
                varmarca = 1
                Label5.Visible = True
                Label6.Visible = True
                msk_fe_ini.Visible = True
                msk_fe_fin.Visible = True
                Label4.Visible = False
                txt_rut.Visible = False
                txt_rut.Select()

            Case "Mayor a Fecha Vcto"
                varmarca = 2

                Label5.Visible = True
                Label5.Text = "Fecha Mayor a:"
                msk_fe_ini.Visible = True



                Label4.Visible = False
                txt_rut.Visible = False
                Label6.Visible = False
                msk_fe_fin.Visible = False
                msk_fe_ini.Select()

            Case "Menor a Fecha Vcto"
                varmarca = 3

                Label5.Visible = True
                Label5.Text = "Fecha Menor a:"
                msk_fe_ini.Visible = True



                Label4.Visible = False
                txt_rut.Visible = False
                Label6.Visible = False
                msk_fe_fin.Visible = False

                msk_fe_ini.Select()

            Case "Por Rut"
                varmarca = 4
                Label5.Visible = False
                Label6.Visible = False
                msk_fe_ini.Visible = False
                msk_fe_fin.Visible = False

                Label4.Visible = True
                txt_rut.Visible = True
                txt_rut.Enabled = True
                txt_rut.Select()




            Case "Por Vendedor"
                varmarca = 5
                Label5.Visible = False
                Label6.Visible = False
                msk_fe_ini.Visible = False
                msk_fe_fin.Visible = False

                'opcion buscar vendedor
                Label8.Visible = True
                lbl_cod_vend.Visible = True
                cbo_vend.Visible = True

                Label4.Visible = False
                txt_rut.Visible = False

                cmd_buscar.Enabled = True
                cmd_buscar.Select()

            Case "Cuadro Anual"
                varmarca = 6
                Label5.Visible = False
                Label6.Visible = False
                msk_fe_ini.Visible = False
                msk_fe_fin.Visible = False
                cmd_buscar.Enabled = True
                cmd_buscar.Select()


        End Select


    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Dispose()
        frm_menu.Show()

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_incobrables_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub msk_fe_ini_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini.MaskInputRejected

    End Sub

    Private Sub msk_fe_ini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If cbo_filtro.Text = "Mayor a Fecha Vcto" Or cbo_filtro.Text = "Menor a Fecha Vcto" Then

                If msk_fe_ini.Text <> "    -  -" Then
                    cmd_buscar.Enabled = True
                    cmd_buscar.Select()
                Else
                    msk_fe_ini.Select()
                End If
            Else
                msk_fe_fin.Select()


            End If
        End If


    End Sub

    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged

    End Sub

    Private Sub txt_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rut.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If txt_rut.Text.Trim.Length < 8 Then
                MsgBox("Error, el rut debe tener 8 caracteres numéricos", MsgBoxStyle.Critical)
                txt_rut.Select()
            Else
                cmd_buscar.Enabled = True
                cmd_buscar.Select()

            End If
        End If

    End Sub

    Private Sub msk_fe_fin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_fin.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then


            If msk_fe_ini.Text <> "    -  -" Then
                    cmd_buscar.Enabled = True
                    cmd_buscar.Select()
                Else
                    msk_fe_ini.Select()
                End If
            Else
                msk_fe_fin.Select()


        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged

    End Sub

    Private Sub txt_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscar.KeyPress
        Dim target_name As String = ""
        Try

            'BUSCAR

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_buscar.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_buscar.CharacterCasing = CharacterCasing.Upper

                For r As Integer = 1 To Me.grilla.Rows.Count - 2

                    For x As Integer = 0 To grilla.ColumnCount - 1

                        If grilla.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla.CurrentCell = grilla.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla.CurrentRow.DefaultCellStyle.BackColor = Color.WhiteSmoke
                            grilla.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub cbo_vend_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_vend.SelectedValueChanged

        If var = 1 Then

            Dim sql As String
            Dim cmd7 As MySqlCommand = New MySqlCommand
            Dim rs9 As MySqlDataReader

            conexion.Close()
            If Connex = 1 Then
                Call conn1()
            Else
                Call Conectar() 'red
            End If
            'If conexion.State = 1 Then conexion.Close()
            conexion.Open()


            cmd7.Connection = conexion
            sql = "SELECT * FROM eck_cobranza.vendedor where nombre = '" & cbo_vend.Text & "'"

            cmd7 = New MySqlCommand(sql, conexion)

            rs9 = cmd7.ExecuteReader()
            rs9.Read()


            lbl_cod_vend.Text = CStr(rs9("cod_vend"))

            rs9.Close()
            conexion.Close()
            sql = ""

        Else

            If var = 2 Then


                Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                Dim comando As OleDbCommand
                Dim dr2 As OleDbDataReader

                If Conn.State = 1 Then Conn.Close()
                Conn.Open()

                comando = New OleDbCommand("SELECT cod_vend FROM vendedor where nombre = '" & cbo_vend.Text & "'", Conn)

                dr2 = comando.ExecuteReader

                Do While dr2.Read()
                    lbl_cod_vend.Text = dr2("cod_vend").ToString()
                Loop

                dr2.Close()
                Conn.Close()
                comando.Dispose()





            End If

        End If


    End Sub

    Private Sub cbo_vend_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_vend.SelectedIndexChanged
        If var = 1 Then

            Dim sql As String
            Dim cmd7 As MySqlCommand = New MySqlCommand
            Dim rs9 As MySqlDataReader

            conexion.Close()

            If Connex = 1 Then
                Call conn1()
            Else
                Call Conectar() 'red
            End If
            ' If conexion.State = 1 Then conexion.Close()
            conexion.Open()


            cmd7.Connection = conexion
            sql = "SELECT * FROM eck_cobranza.vendedor where nombre = '" & cbo_vend.Text & "'"

            cmd7 = New MySqlCommand(sql, conexion)

            rs9 = cmd7.ExecuteReader()
            rs9.Read()


            lbl_cod_vend.Text = CStr(rs9("cod_vend"))

            'rs9.Close()
            'conexion.Close()
            sql = ""

        Else

            If var = 2 Then


                Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                Dim comando As OleDbCommand
                Dim dr2 As OleDbDataReader

                If Conn.State = 1 Then Conn.Close()
                Conn.Open()

                comando = New OleDbCommand("SELECT cod_vend FROM vendedor where nombre = '" & cbo_vend.Text & "'", Conn)

                dr2 = comando.ExecuteReader

                Do While dr2.Read()
                    lbl_cod_vend.Text = dr2("cod_vend").ToString()
                Loop

                dr2.Close()
                Conn.Close()
                comando.Dispose()





            End If

        End If

    End Sub

    Private Sub cbo_vend_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_vend.SelectionChangeCommitted
        If var = 1 Then

            Dim sql As String
            Dim cmd7 As MySqlCommand = New MySqlCommand
            Dim rs9 As MySqlDataReader

            conexion.Close()
            If Connex = 1 Then
                Call conn1()
            Else
                Call Conectar() 'red
            End If
            'If conexion.State = 1 Then conexion.Close()
            conexion.Open()


            cmd7.Connection = conexion
            sql = "SELECT * FROM eck_cobranza.vendedor where nombre = '" & cbo_vend.Text & "'"

            cmd7 = New MySqlCommand(sql, conexion)

            rs9 = cmd7.ExecuteReader()
            rs9.Read()


            lbl_cod_vend.Text = CStr(rs9("cod_vend"))

            rs9.Close()
            conexion.Close()
            sql = ""

        Else

            If var = 2 Then


                Dim Conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
                Dim comando As OleDbCommand
                Dim dr2 As OleDbDataReader

                If Conn.State = 1 Then Conn.Close()
                Conn.Open()

                comando = New OleDbCommand("SELECT cod_vend FROM vendedor where nombre = '" & cbo_vend.Text & "'", Conn)

                dr2 = comando.ExecuteReader

                Do While dr2.Read()
                    lbl_cod_vend.Text = dr2("cod_vend").ToString()
                Loop

                dr2.Close()
                Conn.Close()
                comando.Dispose()





            End If

        End If
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        Call Exp_Excel(grilla)

    End Sub



    Private Sub cmd_exp_excel_acc_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel_acc.Click
        Call Exp_excel_access()
    End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub

    Private Sub grilla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseDoubleClick


        If var = 1 Then
            'carga con mysql

            Dim cmd12 As MySqlCommand = New MySqlCommand

            conexion.Close()
            If Connex = 1 Then
                Call conn1()
            Else
                Call Conectar() 'red
            End If
            'If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd12.Connection = conexion


            cmd12.CommandText = "SELECT FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario FROM eck_cobranza.datos_fuente where Cobr_A = '" & grilla.Item(0, e.RowIndex).Value & "' And Salesperson = '" & lbl_cod_vend.Text & "'"
            Dim dt12 As System.Data.DataTable = New System.Data.DataTable
            Dim da12 As MySqlDataAdapter = New MySqlDataAdapter(cmd12)
            da12.Fill(dt12)


            frm_detalle_fact.lbl_rut.Text = grilla.Item(0, e.RowIndex).Value
            frm_detalle_fact.lbl_cliente.Text = grilla.Item(1, e.RowIndex).Value

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

    Private Sub msk_fe_fin_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_fin.MaskInputRejected

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class