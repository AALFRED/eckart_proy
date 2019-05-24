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

Imports System.Data.Odbc
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class frm_carga_base

    Dim var As Integer

    Private Sub frm_carga_base_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - CARGA DE DATOS"


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

        lbl_traspaso.Text = ""
        lbl_nroreg.Text = ""
        lbl_traspaso.Visible = False
        lbl_cartel.Visible = False
        cmd_truncate_bd.Enabled = False

        cmd_cargar_datos.Enabled = False
        cmd_cargar_mysql.Enabled = False
        cmd_cargar_access.Enabled = False

        cmd_truncate_bd.Enabled = False

        'carga de tipo de bd
        cbo_tpo.Items.Add("BD MYSQL")
        cbo_tpo.Items.Add("BD ACCESS")
    End Sub

    Private Sub frm_carga_base_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_menu.Show()
    End Sub

    Private Sub cmd_cargar_datos_Click(sender As Object, e As EventArgs) Handles cmd_cargar_datos.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = “Seleccionar Archivo”
            .Filter = “Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*”
            .Multiselect = False
            .InitialDirectory = "C:\eckart\" 'My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                ' ImportExcellToDataGridView(.FileName, grilla)

                Dim dt As DataTable = GetDataExcel(.FileName, "Datos")
                grilla.DataSource = dt
                System.Windows.Forms.Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor

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


                Cursor.Current = Cursors.Default

            End If
        End With
    End Sub

    Private Sub cmd_cargar_Click(sender As Object, e As EventArgs) Handles cmd_cargar_mysql.Click
        Dim cmd As MySqlCommand = New MySqlCommand



        Dim ret_cobro As String
        Dim ret_vend As String
        Dim ret_nomven As String
        Dim ret_datefield As String
        Dim ret_ldiario As String
        Dim ret_descrip As String
        Dim ret_tipoClie As String
        Dim ret_descrip2 As String
        Dim ret_nomclie As String
        Dim ret_seg_nom As String
        Dim ret_abto As String
        Dim ret_gravable As String
        Dim ret_tipo_fact As String
        Dim ret_voucher As String
        Dim ret_nro_docto As String
        Dim ret_nfact_corto As String
        Dim ret_doc_relac As String
        Dim ret_fe_reg As String
        Dim ret_fe_fact As String
        Dim ret_fe_vcto As String
        Dim ret_mto_docto As String
        Dim ret_abonos As String
        Dim ret_con_seguro As String
        Dim ret_zonal_cobro As String
        Dim ret_mto_seguro As String
        Dim ret_bc_balanc As String
        Dim ret_ultPago As String
        Dim ret_cuenta As String
        Dim ret_descrip_cta As String

        'Try
        System.Windows.Forms.Application.DoEvents()

        lbl_traspaso.Visible = True

        'MsgBox("...Cargando Datos a la Base", MsgBoxStyle.Information)

        ' MsgBox("conexion establecida--")
        Call conn1()
        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        Cursor.Current = Cursors.WaitCursor
        Me.grilla.Invalidate()
        Me.grilla.Visible = False

        With grilla

            For i = 0 To .Rows.Count - 1

                lbl_traspaso.Text = "Traspasando " & i & "  de " & lbl_nroreg.Text
                lbl_cartel.Visible = True

                ret_cobro = .Rows(i).Cells(0).Value.ToString() 'cobro
                ret_vend = .Rows(i).Cells(1).Value.ToString() 'vend
                ret_nomven = .Rows(i).Cells(2).Value.ToString() 'nomvend
                ret_datefield = .Rows(i).Cells(3).Value.ToString() 'date field
                ret_ldiario = .Rows(i).Cells(4).Value.ToString() 'ldiario
                ret_descrip = .Rows(i).Cells(5).Value.ToString() 'descripcion
                ret_tipoClie = .Rows(i).Cells(6).Value.ToString() 'tipo clie
                ret_descrip2 = .Rows(i).Cells(7).Value.ToString() 'tipo clie
                ret_nomclie = .Rows(i).Cells(8).Value.ToString() 'nombre cliente
                ret_seg_nom = .Rows(i).Cells(9).Value.ToString() 'tipo seg nom
                ret_abto = .Rows(i).Cells(10).Value.ToString() 'tipo abto
                ret_gravable = .Rows(i).Cells(11).Value.ToString() 'tipo gravable
                ret_tipo_fact = .Rows(i).Cells(12).Value.ToString() 'tipo fact
                ret_voucher = .Rows(i).Cells(13).Value.ToString() 'vocuher
                ret_nro_docto = .Rows(i).Cells(14).Value.ToString() 'nro doctp
                ret_nfact_corto = .Rows(i).Cells(15).Value.ToString() 'nro fact corto
                ret_doc_relac = .Rows(i).Cells(16).Value.ToString() 'docto relacionado


                Dim v_fereg As DateTime  'la fecha reg
                v_fereg = Convert.ToDateTime(.Rows(i).Cells(17).Value.ToString()) 'la fecha reg
                Dim lafechareg As String = v_fereg.ToString("yyyy-MM-dd HH:mm:ss")
                ret_fe_reg = lafechareg 'fe reg

                Dim v_fefact As DateTime  'la fecha fact
                v_fefact = Convert.ToDateTime(.Rows(i).Cells(18).Value.ToString()) 'la fecha fact
                Dim lafechafact As String = v_fefact.ToString("yyyy-MM-dd HH:mm:ss")
                ret_fe_fact = lafechafact 'fe fact

                Dim v_fevcto As DateTime  'la fecha vcto
                v_fevcto = Convert.ToDateTime(.Rows(i).Cells(19).Value.ToString()) 'la fecha vcto
                Dim lafechavcto As String = v_fevcto.ToString("yyyy-MM-dd HH:mm:ss")
                ret_fe_vcto = lafechavcto 'fe fact


                ret_mto_docto = .Rows(i).Cells(20).Value.ToString() 'mto docto
                ret_abonos = .Rows(i).Cells(21).Value.ToString() 'abonos

                ret_con_seguro = .Rows(i).Cells(22).Value.ToString() 'con seguro
                ret_zonal_cobro = .Rows(i).Cells(23).Value.ToString() 'zonal cobro
                ret_mto_seguro = .Rows(i).Cells(24).Value.ToString() 'mto seguro
                ret_bc_balanc = .Rows(i).Cells(25).Value.ToString() 'bc balance

                ' Dim v_feultpago As DateTime  'la fecha ultimo pago
                'v_feultpago = Convert.ToDateTime(.Rows(i).Cells(26).Value.ToString()) 'la fecha vcto
                ' Dim lafechaultpago As String = v_feultpago.ToString("yyyy-MM-dd HH:mm:ss")
                'ret_ultPago = lafechaultpago
                'If .Rows(i).Cells(26).Value.ToString() = "" Then
                '   ret_ultPago = "1900-01-01"
                'Else
                ret_ultPago = .Rows(i).Cells(26).Value.ToString()
                'End If


                ret_cuenta = .Rows(i).Cells(27).Value.ToString() 'cuenta
                ret_descrip_cta = .Rows(i).Cells(28).Value.ToString() 'descrip cuenta


                'ret_totalCargos = .Rows(i).Cells(8).Value.ToString() 'total cargos

                cmd = New MySqlCommand("Insert Into Datos_fuente (Cobr_A, Salesperson, OrdenarNombre, Custom, Ldiario, descripcion, TipoClte, Descrip2, Nombre, SegundoName, abto, gravable, TipoFact, Voucher, nrodocto, nroFactura, doctoRelacion, FeRegistro, FeFact, FeVcto, MontoDocto, abonos, Seguro, ZonalCobro, MontoSeguro, BCBalance, UltimoPago, cuenta, descripCta )" &
       " Values ('" & ret_cobro & "', '" & ret_vend & "', '" & ret_nomven & "', '" & ret_datefield & "', '" & ret_ldiario & "', '" & ret_descrip & "', '" & ret_tipoClie & "', '" & ret_descrip2 & "', '" & ret_nomclie & "', '" & ret_seg_nom & "', '" & ret_abto & "', '" & ret_gravable & "', " &
       " '" & ret_tipo_fact & "', '" & ret_voucher & "', '" & ret_nro_docto & "', '" & ret_nfact_corto & "', '" & ret_doc_relac & "', '" & ret_fe_reg & "', '" & ret_fe_fact & "', '" & ret_fe_vcto & "', '" & ret_mto_docto & "', '" & ret_abonos & "', '" & ret_con_seguro & "', '" & ret_zonal_cobro & "', '" & ret_mto_seguro & "', '" & ret_bc_balanc & "', '" & ret_ultPago & "', '" & ret_cuenta & "', '" & ret_descrip_cta & "')", conexion)
                cmd.ExecuteNonQuery()
                Me.Refresh()

            Next



        End With

        conexion.Close()
        MsgBox("Datos Almacenados correctamente", MsgBoxStyle.Information)
        Cursor.Current = Cursors.Default
        lbl_cartel.Visible = False

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try




    End Sub

    Private Sub cargar_access_Click(sender As Object, e As EventArgs) Handles cmd_cargar_access.Click

        ':::Declaramos nuestra variable Sql que almacenara nuestra consuta
        Dim Sql As String = ""
        Dim ret_datefield As String
        Dim ret_ldiario As String
        Dim ret_descrip As String
        Dim ret_tipoClie As String
        Dim ret_descrip2 As String
        Dim ret_nomclie As String
        Dim ret_seg_nom As String
        Dim ret_abto As String
        Dim ret_gravable As String
        Dim ret_tipo_fact As String
        Dim ret_voucher As String
        Dim ret_descrip_cta As String
        Dim ret_ultPago As String
        Dim ret_doc_relac As String
        Dim ret_nfact_corto As String
        Dim ret_nomven As String


        Con3.Open()
        System.Windows.Forms.Application.DoEvents()

        lbl_traspaso.Visible = True
        Cursor.Current = Cursors.WaitCursor
        Me.grilla.Invalidate()
        Me.grilla.Visible = False

        ':::Usamos un ciclo For Each para recorrer nuestro DataGridView llamado grilla
        For Each Row As DataGridViewRow In grilla.Rows
            ':::Obtenemos los valores que vamos a pasar a nuestra consulta para ser guardados




            Dim ret_cobro As String = Row.Cells("F1").Value
                Dim ret_vend As String = Row.Cells("F2").Value


                If IsDBNull(Row.Cells("F3").Value) = True Then
                    ret_nomven = "No definido"
                Else
                    ret_nomven = LTrim(RTrim(Row.Cells("F3").Value))
                End If

                If IsDBNull(Row.Cells("F4").Value) = True Then
                    ret_datefield = ""
                Else
                    ret_datefield = Row.Cells("F4").Value
                End If

                If IsDBNull(Row.Cells("F5").Value) = True Then
                    ret_ldiario = ""
                Else
                    ret_ldiario = Row.Cells("F5").Value
                End If

                If IsDBNull(Row.Cells("F6").Value) = True Then
                    ret_descrip = ""
                Else
                    ret_descrip = Row.Cells("F6").Value
                End If

                If IsDBNull(Row.Cells("F7").Value) = True Then
                    ret_tipoClie = ""
                Else
                    ret_tipoClie = Row.Cells("F7").Value
                End If

                If IsDBNull(Row.Cells("F8").Value) = True Then
                    ret_descrip2 = ""
                Else
                    ret_descrip2 = Row.Cells("F8").Value
                End If

                If IsDBNull(Row.Cells("F9").Value) = True Then
                    ret_nomclie = ""
                Else
                    ret_nomclie = Row.Cells("F9").Value
                End If

                If IsDBNull(Row.Cells("F10").Value) = True Then
                    ret_seg_nom = ""
                Else
                    ret_seg_nom = Row.Cells("F10").Value
                End If

                If IsDBNull(Row.Cells("F11").Value) = True Then
                    ret_abto = ""
                Else
                    ret_abto = Row.Cells("F11").Value
                End If

                If IsDBNull(Row.Cells("F12").Value) = True Then
                    ret_gravable = ""
                Else
                    ret_gravable = Row.Cells("F12").Value
                End If


                If IsDBNull(Row.Cells("F13").Value) = True Then
                    ret_tipo_fact = ""
                Else
                    ret_tipo_fact = Row.Cells("F13").Value
                End If


                If IsDBNull(Row.Cells("F14").Value) = True Then
                    ret_voucher = ""
                Else
                    ret_voucher = Row.Cells("F14").Value
                End If




                Dim ret_nro_docto As String = Row.Cells("F15").Value

                If IsDBNull(Row.Cells("F16").Value) = True Then
                    ret_nfact_corto = ""
                Else
                    ret_nfact_corto = Row.Cells("F16").Value
                End If



                If IsDBNull(Row.Cells("F17").Value) = True Then
                    ret_doc_relac = ""
                Else
                    ret_doc_relac = Row.Cells("F17").Value
                End If

                Dim ret_fe_reg As String = Row.Cells("F18").Value
                Dim ret_fe_fact As String = Row.Cells("F19").Value
                Dim ret_fe_vcto As String = Row.Cells("F20").Value
                Dim ret_mto_docto As String = Row.Cells("F21").Value
                Dim ret_abonos As String = Row.Cells("F22").Value
                Dim ret_con_seguro As String = Row.Cells("F23").Value
                Dim ret_zonal_cobro As String = Row.Cells("F24").Value
                Dim ret_mto_seguro As String = Row.Cells("F25").Value
                Dim ret_bc_balanc As String = Row.Cells("F26").Value

                If IsDBNull(Row.Cells("F27").Value) = True Then
                    ret_ultPago = ""
                Else
                    ret_ultPago = Row.Cells("F27").Value
                End If



                Dim ret_cuenta As String = Row.Cells("F28").Value

                If IsDBNull(Row.Cells("F29").Value) = True Then
                    ret_descrip_cta = ""
                Else
                    ret_descrip_cta = Row.Cells("F29").Value
                End If




                ':::Creamos nuestra consulta de tipo Insert y le pasamos nuestros valores
                Sql = "Insert into Datos_fuente (Cobr_A, vendedor, nombre_vend, custom_date_field, Ldiario, descripcion, tipoCliente, descripcion2, nombre_cliente, segundo_nombre, abto, gravable, tipo_factura, voucher, nro_docto, nro_factura_corto, doc_relacionado, fecha_registro, fecha_factura, fecha_vcto, monto_docto, abonos, con_seguro, zonal_cobro, monto_seguro, bc_balance, ultimo_pago, cuenta, descripcion_cta) " &
            " values ('" & ret_cobro & "', '" & ret_vend & "', '" & ret_nomven & "', '" & ret_datefield & "', '" & ret_ldiario & "', '" & ret_descrip & "', '" & ret_tipoClie & "', '" & ret_descrip2 & "', '" & ret_nomclie & "', '" & ret_seg_nom & "', '" & ret_abto & "', '" & ret_gravable & "', '" & ret_tipo_fact & "', '" & ret_voucher & "', '" & ret_nro_docto & "','" & ret_nfact_corto & "', '" & ret_doc_relac & "', '" & ret_fe_reg & "', '" & ret_fe_fact & "'" &
                       ", '" & ret_fe_vcto & "', '" & ret_mto_docto & "', '" & ret_abonos & "', '" & ret_con_seguro & "', '" & ret_zonal_cobro & "', '" & ret_mto_seguro & "', '" & ret_bc_balanc & "', '" & ret_ultPago & "', '" & ret_cuenta & "', '" & ret_descrip_cta & "')"
                ':::Llamamos el procedimiento que hemos creado en el modulo y le pasamos el parametro que es la consulta SQL
                Exportar_Access(Sql)



            Next

        lbl_cartel.Visible = False
        Con3.Close()

        MsgBox("Registros exportados exitosamente", MsgBoxStyle.Information, ":: Aprendamos de Programación:::")
        lbl_nroreg.Text = "Total registros exportados: " & grilla.RowCount
        Cursor.Current = Cursors.Default


    End Sub

    Private Sub cmd_truncate_bd_Click(sender As Object, e As EventArgs) Handles cmd_truncate_bd.Click

        If var = 1 Then
            Call limpiar_tabla_mysql("datos_fuente")
        Else
            Call limpiar_tabla_Access("datos_fuente")
        End If
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
        frm_menu.Show()
    End Sub

    Private Sub cbo_tpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tpo.SelectedIndexChanged
        Select Case cbo_tpo.Text
            Case "BD MYSQL"



                cmd_cargar_datos.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 1



            Case "BD ACCESS"


                cmd_cargar_datos.Enabled = True
                cmd_truncate_bd.Enabled = True
                var = 2




        End Select
    End Sub

    Private Sub cmd_instrucciones_Click(sender As Object, e As EventArgs) Handles cmd_instrucciones.Click
        frm_intrucciones.Show()
    End Sub
End Class