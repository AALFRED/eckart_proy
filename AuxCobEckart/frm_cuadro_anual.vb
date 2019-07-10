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



Public Class frm_cuadro_anual

    Dim tot_grilla As Long


    Sub formato_grilla()


        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Ene"
        grilla.Columns(3).HeaderCell.Value = "Feb"
        grilla.Columns(4).HeaderCell.Value = "Mar"
        grilla.Columns(5).HeaderCell.Value = "Abr"
        grilla.Columns(6).HeaderCell.Value = "May"
        grilla.Columns(7).HeaderCell.Value = "Jun"
        grilla.Columns(8).HeaderCell.Value = "Jul"
        grilla.Columns(9).HeaderCell.Value = "Ago"
        grilla.Columns(10).HeaderCell.Value = "Sep"
        grilla.Columns(11).HeaderCell.Value = "Oct"
        grilla.Columns(12).HeaderCell.Value = "Nov"
        grilla.Columns(13).HeaderCell.Value = "Dic"
        grilla.Columns(14).HeaderCell.Value = "Total"


        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 250
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
        grilla.Columns(14).Width = 100


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grilla.Columns(2).DefaultCellStyle.Format = "C0"
        grilla.Columns(3).DefaultCellStyle.Format = "C0"
        grilla.Columns(4).DefaultCellStyle.Format = "C0"
        grilla.Columns(5).DefaultCellStyle.Format = "C0"
        grilla.Columns(6).DefaultCellStyle.Format = "C0"
        grilla.Columns(7).DefaultCellStyle.Format = "C0"
        grilla.Columns(8).DefaultCellStyle.Format = "C0"
        grilla.Columns(9).DefaultCellStyle.Format = "C0"
        grilla.Columns(10).DefaultCellStyle.Format = "C0"
        grilla.Columns(11).DefaultCellStyle.Format = "C0"
        grilla.Columns(12).DefaultCellStyle.Format = "C0"
        grilla.Columns(13).DefaultCellStyle.Format = "C0"
        grilla.Columns(14).DefaultCellStyle.Format = "C0"


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



    Sub Exp_Excel2(grilla As DataGridView)

        System.Windows.Forms.Application.DoEvents()


        lbl_cartel.Visible = True

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
            Cursor.Current = Cursors.WaitCursor
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

                Next

                lbl_cartel.Text = "Procesando la Fila....." & rowIndex
            Next

            'Configurar la orientacion de la  hoja y el tamaño
            ' wSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape
            ' wSheet.PageSetup.PaperSize = XlPaperSize.xlPaperLegal
            'Configurar con negrilla la cabecera y tenga autofit
            wSheet.Rows.Item(1).Font.Bold = 1
            wSheet.Columns.AutoFit()

            'Dim strFileName As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory) & "Temp\exp_Cuadro_Anual.xlsx"
            'Dim strFilename As String = System.IO.Path.GetDirectoryName(path:="Temp\exp_Cuadro_Anual.xlsx")
            Dim strfilename As String = "C:\eckart\proyecto Cobranzas\Temp\exp_Cuadro_Anual.xlsx"
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
            Cursor.Current = Cursors.Default

        End If


    End Sub




    Sub SUMA_TOT(migrilla3 As DataGridView)

        Try

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

                lbl_monto.Text = tot_grilla.ToString()
                lbl_monto.Text = String.Format("{0:C0}", tot_grilla)


            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Proceso Suma CM")
        End Try


    End Sub

    Private Sub frm_cuadro_anual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - Cuadro anual de Saldos en Deuda "


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
        lbl_monto.Text = ""
        cmd_buscar.Enabled = False
        cmd_exp_excel.Enabled = False


        cbo_anio.Items.Add("2018")
        cbo_anio.Items.Add("2019")
        cbo_anio.Items.Add("2020")
        cbo_anio.Items.Add("2021")
        cbo_anio.Items.Add("2022")
        cbo_anio.Items.Add("2023")
        cbo_anio.Items.Add("2024")
        cbo_anio.Items.Add("2025")
        cbo_anio.Items.Add("2026")
        cbo_anio.Items.Add("2027")
        cbo_anio.Items.Add("2028")
        cbo_anio.Items.Add("2029")
        cbo_anio.Items.Add("2030")
        cbo_anio.Items.Add("TODOS")

        lbl_cartel.Visible = False
        lbl_cartel.Text = ""

        lbl_reg.Text = ""



    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim cmd6 As SqlCommand = New SqlCommand


        If Connex = 0 Then
            'MODO LOCAL
            Call Conectar2()

        Else
            'MODO RED
            Call Conectar2()
        End If

        If conexion2.State = 1 Then conexion2.Close()
        conexion2.Open()

        cmd6.Connection = conexion2

        'cmd.CommandText = "SELECT nombre, Sum(BCBalance) tot  FROM datos_fuente  where FeVcto <= '2019-02-28' group by Cobr_A order by nombre ASC"
        cmd6.CommandText = "SELECT * FROM (SELECT DISTINCT Cobr_A, ltrim(rtrim(Nombre)), sum(case when MONTH(FeVcto) = 1 then BCBalance end) as ENE, sum(case when MONTH(FeVcto) = 2  then BCBalance end) as FEB, sum(case when MONTH(FeVcto) = 3 then BCBalance end) as MAR, sum(case when MONTH(FeVcto) = 4 then BCBalance end) as ABR, sum(case when MONTH(FeVcto) = 5 then BCBalance end) as MAY, sum(case when MONTH(FeVcto) = 6 then BCBalance end) as JUN, sum(case when MONTH(FeVcto) = 7 then BCBalance end) as JUL, sum(case when MONTH(FeVcto) = 8 then BCBalance end) as AGO, sum(case when MONTH(FeVcto) = 9 then BCBalance end) as SEP, sum(case when MONTH(FeVcto) = 10 then BCBalance end) as OCT, sum(case when MONTH(FeVcto) = 11 then BCBalance end) as NOV, sum(case when MONTH(FeVcto) = 12 then BCBalance end) as DIC, sum(CASE WHEN Left(TipoFact,4) = 'CRED' THEN  BCBalance * -1  else BCBalance end) as total
                                        FROM datos_fuente WHERE TipoFact Like 'INV%' and cuenta = '1114001' and year(feVcto) = '" & cbo_anio.Text & "' GROUP BY nombre 
                                            ORDER BY nombre ASC) as pivotable WHERE ENE > 0 or FEB > 0 or MAR > 0 or ABR > 0 or MAY > 0 or JUN > 0 or JUL > 0 or AGO > 0 or SEP > 0 or OCT > 0 or NOV > 0 or DIC > 0;"

        Dim dt6 As System.Data.DataTable = New System.Data.DataTable
        Dim da6 As SqlDataAdapter = New SqlDataAdapter(cmd6)
        da6.Fill(dt6)
        ' If dt.Rows.Count <> 0 Then
        grilla.DataSource = dt6

        conexion2.Close()
        da6.Dispose()
        cmd6.Dispose()

        For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

            i = +i
            lbl_reg.Text = i

        Next

        Call formato_grilla()
        Call SUMA_TOT(grilla)
        cmd_exp_excel.Enabled = True
    End Sub

    Private Sub cbo_anio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_anio.SelectedIndexChanged

        cmd_buscar.Enabled = True
        cmd_buscar.Select()

    End Sub

    Private Sub cbo_anio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_anio.SelectedValueChanged
        cmd_buscar.Enabled = True
        cmd_buscar.Select()
    End Sub

    Private Sub cbo_anio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_anio.SelectionChangeCommitted
        cmd_buscar.Enabled = True
        cmd_buscar.Select()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Dispose()
        Principal.Show()

    End Sub

    Private Sub frm_cuadro_anual_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Principal.Show()

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_cuadro_anual_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        Call Exp_Excel2(grilla)
    End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub

    Private Sub grilla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseDoubleClick
        'carga con mysql

        Dim cmd12 As SqlCommand = New SqlCommand
        Dim valMes As Integer  'la variable que controla el mes de busqueda


        If Connex = 0 Then
            'MODO LOCAL
            Call Conectar2()

        Else
            'MODO RED
            Call Conectar()
        End If
        If conexion2.State = 1 Then conexion2.Close()
        conexion2.Open()
        cmd12.Connection = conexion2

        Dim lacol As Integer

        lacol = String.Format(e.ColumnIndex)
        Select Case lacol
            Case "2"
                valMes = 1
            Case "3"
                valMes = 2
            Case "4"
                valMes = 3
            Case "5"
                valMes = 4
            Case "6"
                valMes = 5
            Case "7"
                valMes = 6
            Case "8"
                valMes = 7
            Case "9"
                valMes = 8
            Case "10"
                valMes = 9
            Case "11"
                valMes = 10
            Case "12"
                valMes = 11
            Case "13"
                valMes = 12

        End Select


        cmd12.CommandText = "SELECT FeRegistro, TipoFact, nrodocto, nroFactura, FeFact, FeVcto, MontoDocto, BCBalance, cuenta, voucher, Ldiario FROM datos_fuente where Cobr_A = '" & grilla.Item(0, e.RowIndex).Value & "' and year(FeVcto) = '" & cbo_anio.Text & "' and month(FeVcto) = '" & valMes & "'"
        Dim dt12 As System.Data.DataTable = New System.Data.DataTable
        Dim da12 As SqlDataAdapter = New SqlDataAdapter(cmd12)
        da12.Fill(dt12)


        frm_detalle_fact.lbl_rut.Text = grilla.Item(0, e.RowIndex).Value
        frm_detalle_fact.lbl_cliente.Text = grilla.Item(1, e.RowIndex).Value

        frm_detalle_fact.grilla_det.DataSource = dt12
        frm_detalle_fact.formato_grilla()


        conexion2.Close()
        da12.Dispose()
        cmd12.Dispose()

        frm_detalle_fact.Show()

        'Call formato_grilla7()

    End Sub
End Class