Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text
Imports System.Windows.Forms
Imports System
Imports System.Diagnostics
Imports System.Object
Imports System.Drawing
Imports System.Runtime.InteropServices

':::Libreria OleDb - Access
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frm_cliente

    Dim var As Integer
    Dim dr3 As MySqlDataReader


    Sub formato_grilla()


        'FORMATO DE grillaCM
        grilla2.Columns(0).HeaderCell.Value = "Rut"
        grilla2.Columns(1).HeaderCell.Value = "Cod Vend"
        grilla2.Columns(2).HeaderCell.Value = "Vendedor"
        grilla2.Columns(3).HeaderCell.Value = "Cliente"


        grilla2.Columns(0).Width = 100
        grilla2.Columns(1).Width = 100
        grilla2.Columns(2).Width = 190
        grilla2.Columns(3).Width = 250


        grilla2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        grilla2.Columns(2).DefaultCellStyle.Format = "C2"

        grilla2.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla2.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla2.RowsDefaultCellStyle.BackColor = Color.White
        grilla2.RowsDefaultCellStyle.ForeColor = Color.Blue
        grilla2.GridColor = Color.Black
        grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla2.Sort(grilla2.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        grilla2.RowHeadersVisible = False 'oculta la primera columna

        grilla2.Refresh()

    End Sub


    Public Function cargacombo(ByVal TABLENAME As String, ByVal fldName As String, ByVal cmbname As ComboBox)

        If var = 1 Then 'buscar por mysql
            Dim cmd1 As New MySqlCommand
            Call conn1()

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)


            dr3 = cmd1.ExecuteReader
            cmbname.Items.Clear()
            Do While dr3.Read()
                cmbname.Items.Add(dr3(fldName))
            Loop
            dr3.Close()
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

    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - MANEJO DE VENDEDORES"


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
        BarraStatusTexto.Width = 200
        BarraStatusTexto.Text = "CONECTADO A Base de Datos "
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)



        cmd_cargar_mysql.Enabled = False
            cmd_cargar_access.Enabled = False
            cmd_seleccionar.Enabled = False
            cmd_truncate_bd.Enabled = False

            lbl_nroreg.Text = ""
            'carga de tipo de bd
            cbo_tpo.Items.Add("BD MYSQL")
            cbo_tpo.Items.Add("BD ACCESS")


            lbl_nomclie.Text = ""
            lbl_cod_vend.Text = ""
            lbl_vend_actual.Text = ""
            cbo_vend.Enabled = False
            txt_rutclie.Enabled = False
            cmd_asigna_vend.Enabled = False
            cmd_quitar_vend.Enabled = False
            lbl_nroreg2.Text = ""



    End Sub

    Private Sub cmd_seleccionar_Click(sender As Object, e As EventArgs) Handles cmd_seleccionar.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = “Seleccionar Archivo”
            .Filter = “Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*”
            .Multiselect = False
            .InitialDirectory = "C:\eckart\" 'My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                ' ImportExcellToDataGridView(.FileName, grilla)

                Dim dt As DataTable = GetDataExcel(.FileName, "Hoja1")
                grilla.DataSource = dt

                For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1
                    i = +i
                    lbl_nroreg.Text = i
                Next

                If var = 1 Then
                    cmd_cargar_mysql.Enabled = True
                    cmd_truncate_bd.Enabled = True
                Else
                    cmd_cargar_access.Enabled = True
                    cmd_truncate_bd.Enabled = True
                End If

            End If
        End With
    End Sub

    Private Sub frm_cliente_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        'frm_menu.Show()
        Principal.Show()

    End Sub

    Private Sub cmd_cargar_Click(sender As Object, e As EventArgs) Handles cmd_cargar_access.Click
        ':::Declaramos nuestra variable Sql que almacenara nuestra consuta
        Dim Sql As String = ""
        ':::Usamos un ciclo For Each para recorrer nuestro DataGridView llamado grilla
        For Each Row As DataGridViewRow In grilla.Rows
            ':::Obtenemos los valores que vamos a pasar a nuestra consulta para ser guardados
            ':::rut cliente
            Dim rut As String = Row.Cells("F1").Value
            ':::nombre
            Dim nombreClie As String = Row.Cells("F2").Value
            ':::cobrar_a
            Dim cobrar As String = Row.Cells("F3").Value
            ':::pais
            Dim pais As String = Row.Cells("F4").Value
            'moneda
            Dim moneda As String = Row.Cells("F5").Value
            'idioma
            Dim idioma As String = Row.Cells("F6").Value
            'region
            Dim region As String = Row.Cells("F7").Value
            'tipo
            Dim tipo As String = Row.Cells("F8").Value
            'planta
            Dim planta As String = Row.Cells("F9").Value
            'vendedor
            Dim vendedor As String = Row.Cells("F10").Value
            'observa
            Dim observa As String = Row.Cells("F11").Value
            'zona horaria
            Dim zona_horaria1 As String = Row.Cells("F12").Value
            'datos completos
            Dim datos_completos As String = Row.Cells("F13").Value
            'activo
            Dim activo As String = Row.Cells("F14").Value
            'tabla_dscto
            Dim dscto As String = Row.Cells("F15").Value
            'precio_fijo
            Dim precio_fijo As String = Row.Cells("F16").Value
            'clase
            Dim clase As String = Row.Cells("F17").Value
            'Sic
            Dim sic As String = Row.Cells("F18").Value
            'porc dscto
            Dim porc_dscto As String = Row.Cells("F19").Value
            'terminos
            Dim terminos As String = Row.Cells("F20").Value
            'lista flete
            Dim lista_flete As String = Row.Cells("F21").Value
            'min_ps_fit
            Dim min_ps_fit As Integer = Row.Cells("F22").Value
            'termino flete
            Dim termino_flete As String = Row.Cells("F23").Value
            'tipo_transf
            Dim tipo_transf As String = Row.Cells("F24").Value
            'via_embarque
            Dim via_embarque As String = Row.Cells("F25").Value
            'ciudad
            Dim ciudad As String = Row.Cells("F26").Value
            'estado
            Dim estado As String = Row.Cells("F27").Value
            'cod postal
            Dim cod_postal As String = Row.Cells("F28").Value
            'cod relacion empresa
            Dim cod_relac_emp As String = Row.Cells("F29").Value
            'nom relacion
            Dim nom_relaciom As String = Row.Cells("F30").Value



            ':::Creamos nuestra consulta de tipo Insert y le pasamos nuestros valores
            Sql = "Insert into Cliente (clie, Ordenar_nombre, Cobrar_A, pais, moneda, idioma, region, tipo, planta, vendedor, observa, zona_horaria, datos_completos, activo, tabla_dscto, precio_fijo, clase, sic, porc_dscto, terminos, lista_flete, min_ps_fit, terms_flete, tipo_transf, via_embarque, ciudad, estado, cod_postal, cod_relacion, nom_relacion) " &
            " values ('" & rut & "', '" & nombreClie & "', '" & cobrar & "', '" & pais & "', '" & moneda & "', '" & idioma & "', '" & region & "', '" & tipo & "', '" & planta & "', '" & vendedor & "', '" & observa & "', '" & zona_horaria1 & "', '" & datos_completos & "', '" & activo & "', '" & dscto & "','" & precio_fijo & "', '" & clase & "', '" & sic & "', '" & porc_dscto & "'" &
                       ", '" & terminos & "', '" & lista_flete & "', '" & min_ps_fit & "', '" & termino_flete & "', '" & tipo_transf & "', '" & via_embarque & "', '" & ciudad & "', '" & estado & "', '" & cod_postal & "', '" & cod_relac_emp & "', '" & nom_relaciom & "')"
            ':::Llamamos el procedimiento que hemos creado en el modulo y le pasamos el parametro que es la consulta SQL
            Exportar_Access(Sql)
        Next

        MsgBox("Registros importados exitosamente", MsgBoxStyle.Information, ":: Aprendamos de Programación:::")
        lbl_nroreg.Text = "Total registros exportados: " & grilla.RowCount
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Dispose()
        ' frm_menu.Show()
        Principal.Show()

    End Sub

    Private Sub cmd_truncate_bd_Click(sender As Object, e As EventArgs) Handles cmd_truncate_bd.Click


        If var = 1 Then
            Call limpiar_tabla_mysql("datos_fuente")
        Else
            Call limpiar_tabla_Access("datos_fuente")
        End If


    End Sub

    Private Sub cmd_cargar2_Click(sender As Object, e As EventArgs) Handles cmd_cargar_mysql.Click
        Dim cmd As MySqlCommand = New MySqlCommand

        Dim rut As String
        ':::nombre
        Dim nombreClie As String
        ':::cobrar_a
        Dim cobrar As String
        ':::pais
        Dim pais As String
        'moneda
        Dim moneda As String
        'idioma
        Dim idioma As String
        'region
        Dim region As String
        'tipo
        Dim tipo As String
        'planta
        Dim planta As String
        'vendedor
        Dim vendedor As String
        'observa
        Dim observa As String
        'zona horaria
        Dim zona_horaria1 As String
        'datos completos
        Dim datos_completos As String
        'activo
        Dim activo As String
        'tabla_dscto
        Dim dscto As String
        'precio_fijo
        Dim precio_fijo As String
        'clase
        Dim clase As String
        'Sic
        Dim sic As String
        'porc dscto
        Dim porc_dscto As String
        'terminos
        Dim terminos As String
        'lista flete
        Dim lista_flete As String
        'min_ps_fit
        Dim min_ps_fit As Integer
        'termino flete
        Dim termino_flete As String
        'tipo_transf
        Dim tipo_transf As String
        'via_embarque
        Dim via_embarque As String
        'ciudad
        Dim ciudad As String
        'estado
        Dim estado As String
        'cod postal
        Dim cod_postal As String
        'cod relacion empresa
        Dim cod_relac_emp As String
        'nom relacion
        Dim nom_relaciom As String


        Try
            System.Windows.Forms.Application.DoEvents()
            Call conn1()

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            Cursor.Current = Cursors.WaitCursor
            Me.grilla.Invalidate()
            Me.grilla.Visible = False

            With grilla

                For i = 0 To .Rows.Count - 1


                    rut = .Rows(i).Cells(0).Value.ToString() 'rut
                    nombreClie = .Rows(i).Cells(1).Value.ToString() 'nom-clie
                    cobrar = .Rows(i).Cells(2).Value.ToString() 'cobrar
                    pais = .Rows(i).Cells(3).Value.ToString() 'date field
                    moneda = .Rows(i).Cells(4).Value.ToString() 'ldiario
                    idioma = .Rows(i).Cells(5).Value.ToString() 'descripcion
                    region = .Rows(i).Cells(6).Value.ToString() 'tipo clie
                    tipo = .Rows(i).Cells(7).Value.ToString() 'tipo clie
                    planta = .Rows(i).Cells(8).Value.ToString() 'nombre cliente
                    vendedor = .Rows(i).Cells(9).Value.ToString() 'tipo seg nom
                    observa = .Rows(i).Cells(10).Value.ToString() 'tipo abto
                    zona_horaria1 = .Rows(i).Cells(11).Value.ToString() 'tipo gravable
                    datos_completos = .Rows(i).Cells(12).Value.ToString() 'tipo fact
                    activo = .Rows(i).Cells(13).Value.ToString() 'vocuher
                    dscto = .Rows(i).Cells(14).Value.ToString() 'nro doctp
                    precio_fijo = .Rows(i).Cells(15).Value.ToString() 'nro fact corto
                    clase = .Rows(i).Cells(16).Value.ToString() 'docto relacionado
                    sic = .Rows(i).Cells(17).Value.ToString() 'mto docto
                    porc_dscto = .Rows(i).Cells(18).Value.ToString() 'abonos
                    terminos = .Rows(i).Cells(19).Value.ToString() 'con seguro
                    lista_flete = .Rows(i).Cells(20).Value.ToString() 'zonal cobro
                    min_ps_fit = .Rows(i).Cells(21).Value.ToString() 'mto seguro
                    termino_flete = .Rows(i).Cells(22).Value.ToString() 'bc balance
                    tipo_transf = .Rows(i).Cells(23).Value.ToString()
                    via_embarque = .Rows(i).Cells(24).Value.ToString() 'cuenta
                    ciudad = .Rows(i).Cells(25).Value.ToString() 'descrip cuenta
                    estado = .Rows(i).Cells(26).Value.ToString() 'descrip cuenta
                    cod_postal = .Rows(i).Cells(27).Value.ToString() 'descrip cuenta
                    cod_relac_emp = .Rows(i).Cells(28).Value.ToString() 'descrip cuenta
                    nom_relaciom = .Rows(i).Cells(29).Value.ToString() 'descrip cuenta


                    cmd = New MySqlCommand("Insert Into cliente (id, Clie, Ordenar_nombre, Cobrar_A, Pais, moneda, idioma, region, tipo, planta, vendedor, observa, zona_horaria, datos_completos, activo, tabla_dscto, precio_fijo, clase, sic, porc_dscto, terminos, lista_flete, min_ps_fit, terms_flete, tipo_transf, via_embarque, ciudad, estado, cod_postal, cod_relacion, nom_relacion)" &
       " Values (0, '" & rut & "', '" & nombreClie & "', '" & cobrar & "', '" & pais & "', '" & moneda & "', '" & idioma & "', '" & region & "', '" & tipo & "', '" & planta & "', '" & vendedor & "', '" & observa & "', " &
       " '" & zona_horaria1 & "', '" & datos_completos & "', '" & activo & "', '" & dscto & "', '" & precio_fijo & "', '" & clase & "', '" & sic & "', '" & porc_dscto & "', '" & terminos & "', '" & lista_flete & "', '" & min_ps_fit & "', '" & termino_flete & "', '" & tipo_transf & "', '" & via_embarque & "', '" & ciudad & "', '" & estado & "', '" & cod_postal & "', '" & cod_relac_emp & "', '" & nom_relaciom & "')", conexion)
                    cmd.ExecuteNonQuery()
                    Me.Refresh()

                Next



            End With

            conexion.Close()
            MsgBox("Datos Almacenados correctamente", MsgBoxStyle.Information)
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub cbo_tpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tpo.SelectedIndexChanged

        Select Case cbo_tpo.Text
            Case "BD MYSQL"



                cmd_seleccionar.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 1
                Call cargacombo("vendedor", "nombre", cbo_vend)
                txt_rutclie.Enabled = True
                cbo_vend.Enabled = True

            Case "BD ACCESS"


                cmd_seleccionar.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 2
                Call cargacombo("vendedor", "nombre", cbo_vend)

                txt_rutclie.Enabled = True
                cbo_vend.Enabled = True

        End Select
    End Sub

    Private Sub txt_rutclie_TextChanged(sender As Object, e As EventArgs) Handles txt_rutclie.TextChanged

    End Sub

    Private Sub txt_rutclie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rutclie.KeyPress
        Dim cmd1 As MySqlCommand = New MySqlCommand

        Try

            If e.KeyChar = Convert.ToChar(13) Then

                If txt_rutclie.Text <> "" Then

                    If var = 1 Then


                        Call conn1()
                        cmd1.Connection = conexion
                        'cmd1.CommandText = "SELECT Cobr_A as Rut, Salesperson as codven, OrdenarNombre as Vendedor, Nombre as cliente FROM eck_cobranza.datos_fuente  where salesperson = '" & txt_rut.Text & "' group by Cobr_A order by nombre ASC "
                        cmd1.CommandText = "SELECT Cobr_A as Rut, Salesperson as codven, OrdenarNombre as Vendedor, Nombre as cliente FROM datos_fuente  where Cobr_A = '" & txt_rutclie.Text & "' group by Salesperson order by Ordenarnombre ASC"
                        Dim dt1 As System.Data.DataTable = New System.Data.DataTable
                        Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
                        da2.Fill(dt1)

                        grilla2.DataSource = dt1

                        conexion.Close()
                        da2.Dispose()
                        cmd1.Dispose()

                        For i As Integer = 0 To grilla2.Rows.Count() Step +1

                            i = +i
                            lbl_nroreg2.Text = i

                        Next
                        Call formato_grilla()

                    Else




                    End If
                Else

                    txt_rutclie.Select()

                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cbo_tpo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_tpo.SelectedValueChanged
        Select Case cbo_tpo.Text
            Case "BD MYSQL"



                cmd_seleccionar.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 1
                Call cargacombo("vendedor", "nombre", cbo_vend)
                txt_rutclie.Enabled = True
                cbo_vend.Enabled = True

            Case "BD ACCESS"


                cmd_seleccionar.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 2
                Call cargacombo("vendedor", "nombre", cbo_vend)

                txt_rutclie.Enabled = True
                cbo_vend.Enabled = True

        End Select
    End Sub

    Private Sub cbo_tpo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_tpo.SelectionChangeCommitted
        Select Case cbo_tpo.Text
            Case "BD MYSQL"



                cmd_seleccionar.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 1
                Call cargacombo("vendedor", "nombre", cbo_vend)
                txt_rutclie.Enabled = True
                cbo_vend.Enabled = True

            Case "BD ACCESS"


                cmd_seleccionar.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 2
                Call cargacombo("vendedor", "nombre", cbo_vend)

                txt_rutclie.Enabled = True
                cbo_vend.Enabled = True

        End Select
    End Sub

    Private Sub grilla2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla2.CellContentClick

    End Sub

    Private Sub grilla2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla2.CellMouseDoubleClick
        lbl_nomclie.Text = grilla2.Rows(e.RowIndex).Cells(3).Value 'cliente
        txt_rutclie.Text = grilla2.Rows(e.RowIndex).Cells(0).Value 'rut
        lbl_cod_vend.Text = grilla2.Rows(e.RowIndex).Cells(1).Value 'cod vend
        lbl_vend_actual.Text = grilla2.Rows(e.RowIndex).Cells(2).Value 'vend actual
        lbl_nomclie.Text = grilla2.Rows(e.RowIndex).Cells(3).Value
        cmd_asigna_vend.Enabled = True
        cmd_quitar_vend.Enabled = True
    End Sub

    Private Sub cmd_quitar_vend_Click(sender As Object, e As EventArgs) Handles cmd_quitar_vend.Click
        Dim cmd3 As MySqlCommand

        If var = 1 Then
            'con mysql
            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd3 = New MySqlCommand("Update datos_fuente set Salesperson = '0000' where Salesperson = '" & lbl_cod_vend.Text & "' and Cobr_A = '" & txt_rutclie.Text & "'", conexion)

            cmd3.ExecuteNonQuery()
            conexion.Close()
            cmd3.Dispose()

            MsgBox("Modificación realizada.", MsgBoxStyle.Information)



        Else

            'falta access
        End If
    End Sub

    Private Sub cmd_asigna_vend_Click(sender As Object, e As EventArgs) Handles cmd_asigna_vend.Click
        Dim cmd3 As MySqlCommand

        If var = 1 Then
            'con mysql
            Call conn1()
            conexion.Open()
            cmd3 = New MySqlCommand("Update datos_fuente set Salesperson = '" & lbl_cod_vend.Text & "', OrdenarNombre = '" & cbo_vend.Text & "' where OrdenarNombre = '" & lbl_vend_actual.Text & "' and Cobr_A = '" & txt_rutclie.Text & "'", conexion)

            cmd3.ExecuteNonQuery()
            conexion.Close()
            cmd3.Dispose()

            MsgBox("Modificación realizada.", MsgBoxStyle.Information)



        Else

            'falta access
        End If
    End Sub

    Private Sub cbo_vend_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_vend.SelectedIndexChanged
        If var = 1 Then

            Dim sql As String
            Dim cmd7 As MySqlCommand = New MySqlCommand
            Dim rs9 As MySqlDataReader

            conexion.Close()

            Call conn1()
            ' If conexion.State = 1 Then conexion.Close()
            conexion.Open()


            cmd7.Connection = conexion
            sql = "SELECT * FROM vendedor where nombre = '" & cbo_vend.Text & "'"

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

    Private Sub cbo_vend_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_vend.SelectedValueChanged
        If var = 1 Then

            Dim sql As String
            Dim cmd7 As MySqlCommand = New MySqlCommand
            Dim rs9 As MySqlDataReader

            conexion.Close()

            Call conn1()
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
End Class