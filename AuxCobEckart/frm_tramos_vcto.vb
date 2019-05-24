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

Public Class frm_tramos_vcto
    Dim var As Integer
    Private mifecha As Date
    Private mifecha2 As Date
    Dim marca_tramo As Integer

    Dim fecha_actual As String


    Sub formato_grilla()

        'Cobr_A, nombre, BCBalance, nrofactura, nrodocto, FeVcto, CURDATE(), DATEDIFF(FeVcto, CURDATE()) AS 'Tramo', salesperson as cod_ven, OrdenarNombre as Vend 
        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "Rut"
        grilla.Columns(1).HeaderCell.Value = "Nombre"
        grilla.Columns(2).HeaderCell.Value = "Monto Deuda"
        grilla.Columns(3).HeaderCell.Value = "Nro Factura"
        grilla.Columns(4).HeaderCell.Value = "Nro Docto."
        grilla.Columns(5).HeaderCell.Value = "Fe. Vcto"
        grilla.Columns(6).HeaderCell.Value = "Fe Actual"
        grilla.Columns(7).HeaderCell.Value = "Dias Atraso"
        grilla.Columns(8).HeaderCell.Value = "Cod. Vend."
        grilla.Columns(9).HeaderCell.Value = "Vendedor"


        grilla.Columns(6).Visible = False 'fe actual


        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 240
        grilla.Columns(2).Width = 90
        grilla.Columns(3).Width = 90
        grilla.Columns(4).Width = 90
        grilla.Columns(5).Width = 80
        grilla.Columns(6).Width = 80
        grilla.Columns(7).Width = 90
        grilla.Columns(8).Width = 70
        grilla.Columns(9).Width = 120


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

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

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_access_tramos_deuda.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_access_tramos_deuda.xlsx")
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

                My.Computer.FileSystem.DeleteFile("C:\eckart\proyecto Cobranzas\temp\exp_tramos_deuda.xlsx")

                Dim fileg As New FileInfo("C:\eckart\proyecto Cobranzas\temp\exp_tramos_deuda.xlsx")
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




    Private Sub frm_tramos_vcto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - SALDOS ATRASADOS POR TRAMOS de Dias"


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
        msk_fe_ini.Text = "1980-01-01"
        txt_nro_dias.Text = ""

        cbo_tramos.Items.Add("Menor a 30")
        cbo_tramos.Items.Add("Mayor a 30")
        cbo_tramos.Items.Add("Menor a 90")
        cbo_tramos.Items.Add("Mayor a 90")

        lbl_reg.Text = ""


    End Sub

    Private Sub cmd_bus_saldo_atrasado_Click(sender As Object, e As EventArgs) Handles cmd_bus_saldo_atrasado.Click
        'SELECT Cobr_A, nombre, BCBalance, nrofactura, nrodocto, FeVcto, CURDATE(), DATEDIFF(FeVcto, CURDATE()) AS 'Tramo', salesperson as cod_ven, OrdenarNombre as Vend FROM datos_fuente
        ' where FeVcto between '1980-01-01' and '2019-03-31' and cuenta = '1114001' and TipoFact = 'INVOICE' and DATEDIFF(FeVcto, CURDATE()) > -90  order by tramo;
        Dim valdias As Integer

        Try
            If var = 1 Then  'busca en mysql

                Dim cmd3 As MySqlCommand = New MySqlCommand

                Call conn1()
                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                mifecha = msk_fe_ini.Text
                mifecha2 = msk_fe_fin.Text
                ' mifecha = mifecha.AddDays(-1) 'resta 1 dia

                valdias = txt_nro_dias.Text
                valdias = valdias * -1

                cmd3.Connection = conexion

                If marca_tramo = 1 Then
                    'MENOR QUE
                    cmd3.CommandText = "SELECT Cobr_A, nombre, BCBalance, nrofactura, nrodocto, FeVcto, CURDATE(), DATEDIFF(FeVcto, CURDATE()) AS 'Tramo', salesperson as cod_ven, OrdenarNombre as Vend FROM datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001' and TipoFact = 'INVOICE' and DATEDIFF(FeVcto, CURDATE()) <= '" & valdias & "'  order by tramo ;"

                Else
                    'MAYOR QUE
                    cmd3.CommandText = "SELECT Cobr_A, nombre, BCBalance, nrofactura, nrodocto, FeVcto, CURDATE(), DATEDIFF(FeVcto, CURDATE()) AS 'Tramo', salesperson as cod_ven, OrdenarNombre as Vend FROM datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001' and TipoFact = 'INVOICE' and DATEDIFF(FeVcto, CURDATE()) >= '" & valdias & "'  order by tramo ;"
                End If


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
                ' Call SUMA_TOT(grilla)
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

                If marca_tramo = 1 Then
                    'MENOR QUE
                    comando3.CommandText = "SELECT Cobr_A, nombre, BCBalance, nrofactura, nrodocto, FeVcto, CURDATE(), DATEDIFF(FeVcto, CURDATE()) AS 'Tramo', salesperson as cod_ven, OrdenarNombre as Vend FROM datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001' and TipoFact = 'INVOICE' and DATEDIFF(FeVcto, CURDATE()) <= '" & valdias & "'  order by tramo "
                Else
                    'MAYOR QUE
                    comando3.CommandText = "SELECT Cobr_A, nombre, BCBalance, nrofactura, nrodocto, FeVcto, CURDATE(), DATEDIFF(FeVcto, CURDATE()) AS 'Tramo', salesperson as cod_ven, OrdenarNombre as Vend FROM datos_fuente where FeVcto between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and cuenta = '1114001' and TipoFact = 'INVOICE' and DATEDIFF(FeVcto, CURDATE()) >= '" & valdias & "'  order by tramo "
                End If



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
                ' Call SUMA_TOT(grilla)
                cmd_exp_excel.Enabled = True

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbo_tipo_bd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_bd.SelectedIndexChanged

    End Sub

    Private Sub cbo_tipo_bd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_tipo_bd.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            msk_fe_ini.Select()



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

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_tramos_vcto_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub cbo_tramos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tramos.SelectedIndexChanged



        Select Case cbo_tramos.Text
            Case "Menor a 30"
                txt_nro_dias.Text = 30
                marca_tramo = 1  'indica si es mayor 2 o menor 1

            Case "Mayor a 30"
                txt_nro_dias.Text = 30
                marca_tramo = 2
            Case "Menor a 90"
                txt_nro_dias.Text = 90
                marca_tramo = 1
            Case "Mayor a 90"
                txt_nro_dias.Text = 90
                marca_tramo = 2
        End Select
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        If var = 1 Then

            Call Exp_Excel(grilla)

        Else
            Call Exp_excel_access(grilla)

        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
        Principal.Show()

    End Sub
End Class