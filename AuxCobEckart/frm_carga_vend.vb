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
Imports MySql.Data
Imports MySql.Data.MySqlClient

':::Libreria OleDb - Access
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports ADODB





Public Class frm_carga_vend


    Dim var As Integer


    Private Sub frm_carga_vend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        BarraStatusTexto.Width = 400
        BarraStatusTexto.Text = "CONECTADO A Base de Datos "
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)

        'control de carga
        txt_cod_vend.Text = 0
        txt_com.Text = 0
        txt_ciudad.Text = ""
        txt_movil.Text = 0
        txt_nombre.Text = ""
        txt_pais.Text = "CHILE"
        txt_relacCom.Text = 0
        txt_telefono.Text = 0
        lbl_nroreg.Text = ""


        cmd_seleccion_file.Enabled = False
        cmd_cargar.Enabled = False
        cmd_quitar.Enabled = False
        cmd_ver_reg.Enabled = False



        'carga de tipo de bd
        cbo_tpo.Items.Add("BD MYSQL")
        cbo_tpo.Items.Add("BD ACCESS")




    End Sub

    Private Sub frm_carga_vend_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_menu.Show()
    End Sub

    Private Sub cbo_tpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tpo.SelectedIndexChanged




        Select Case cbo_tpo.Text
            Case "BD MYSQL"

                cmd_seleccion_file.Enabled = True
                cmd_cargar.Enabled = True
                cmd_ver_reg.Enabled = True
                var = 1



            Case "BD ACCESS"

                cmd_seleccion_file.Enabled = True
                cmd_cargar.Enabled = True
                cmd_ver_reg.Enabled = True
                var = 2




        End Select

    End Sub

    Private Sub cmd_seleccion_file_Click(sender As Object, e As EventArgs) Handles cmd_seleccion_file.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = “Seleccionar Archivo”
            .Filter = “Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*”
            .Multiselect = False
            .InitialDirectory = "C:\eckart\" 'My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                ' ImportExcellToDataGridView(.FileName, grilla)

                Dim dt As DataTable = GetDataExcel(.FileName, "vendedor")
                grilla.DataSource = dt

                For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1
                    i = +i
                    lbl_nroreg.Text = i
                Next
            End If
        End With
    End Sub

    Private Sub cmd_cargar_Click(sender As Object, e As EventArgs) Handles cmd_cargar.Click

        'Try

        If var = 1 Then

            '///////////////////////////
            'CARGAR A MYSQL ///////////
            '///////////////////////
            Dim ret_var1 As String
            Dim ret_var2 As String
            Dim ret_var3 As String
            Dim ret_var4 As String
            Dim ret_var5 As String
            Dim ret_var6 As String
            Dim ret_var7 As String
            Dim ret_var8 As String
            Dim cmd7 As New MySqlCommand

            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            With grilla

                For i = 0 To .Rows.Count - 1


                    ret_var1 = .Rows(i).Cells(0).Value.ToString() 'cod vend
                    ret_var2 = .Rows(i).Cells(1).Value.ToString() 'nombre
                    ret_var3 = .Rows(i).Cells(2).Value.ToString() 'comision
                    ret_var4 = .Rows(i).Cells(3).Value.ToString() 'telefono
                    ret_var5 = .Rows(i).Cells(4).Value.ToString() 'ciudad
                    ret_var6 = .Rows(i).Cells(5).Value.ToString() 'pais
                    ret_var7 = .Rows(i).Cells(6).Value.ToString() 'nro movil
                    ret_var8 = .Rows(i).Cells(7).Value.ToString() 'relac comercial

                    cmd7 = New MySqlCommand("Insert Into vendedor (id, cod_vend, Nombre, comision, telefono, ciudad, pais, nro_fax, relac_com) Values (0,'" & ret_var1.ToString() & "', '" & ret_var2.ToString() & "', '" & ret_var3.ToString() & "', '" & ret_var4.ToString() & "', '" & ret_var5.ToString() & "', '" & ret_var6.ToString() & "', '" & ret_var7.ToString() & "', '" & ret_var8.ToString() & "' )", conexion)
                    cmd7.ExecuteNonQuery()

                Next
            End With

            conexion.Close()
            cmd7.Dispose()

            MsgBox("Datos Almacenados", MsgBoxStyle.Information)



        Else

            '///////////////////////////
            'CARGAR A ACCESS ///////////
            '///////////////////////


            ':::Declaramos nuestra variable Sql que almacenara nuestra consuta
            Dim Sql As String = ""
            ':::Usamos un ciclo For Each para recorrer nuestro DataGridView llamado grilla
            For Each Row As DataGridViewRow In grilla.Rows
                ':::Obtenemos los valores que vamos a pasar a nuestra consulta para ser guardados
                ':::cod vend
                Dim codvend As String = Row.Cells("F1").Value
                ':::nombre
                Dim nombre As String = Row.Cells("F2").Value
                ':::comision
                Dim comision As String = Row.Cells("F3").Value
                ':::telefono
                Dim telefono As String = Row.Cells("F4").Value
                'ciudad
                Dim ciudad As String = Row.Cells("F5").Value
                'pais
                Dim pais As String = Row.Cells("F6").Value
                'celular
                Dim celular As String = Row.Cells("F7").Value
                'relac com
                Dim relac_com As String = Row.Cells("F8").Value
                'planta



                ':::Creamos nuestra consulta de tipo Insert y le pasamos nuestros valores
                Sql = "Insert into vendedor (cod_vend, nombre, comision, telefono, ciudad, pais, nro_fax, relac_com) " &
                " values ('" & codvend & "', '" & nombre & "', '" & comision & "', '" & telefono & "', '" & ciudad & "', '" & pais & "', '" & celular & "', '" & relac_com & "')"
                ':::Llamamos el procedimiento que hemos creado en el modulo y le pasamos el parametro que es la consulta SQL

                Dim cmd As New OleDbCommand(Sql, Con3)
                If Con3.State = 1 Then Con3.Close()
                Con3.Open()

                cmd.ExecuteNonQuery()
                Con3.Close()


            Next

            MsgBox("Registros Importados exitosamente", MsgBoxStyle.Information, ":: Importación de datos:::")
            lbl_nroreg.Text = "Total registros exportados: " & grilla.RowCount

        End If



        'Catch ex As Exception
        '    MsgBox("No se pueden guardar los registro por: " & ex.Message, MsgBoxStyle.Critical, "carga clientes")
        'End Try
    End Sub

    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click

        Dim cmd4 As New MySqlCommand

        'Try

        If var = 1 Then
            ' CARGO EN MYSQL
            Call conn1()

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            cmd4 = New MySqlCommand("Insert Into vendedor (id, cod_vend, Nombre, comision, telefono, ciudad, pais, nro_fax, relac_com) " &
                                    " Values (0,'" & txt_cod_vend.Text & "', '" & txt_nombre.Text & "', '" & txt_com.Text & "', '" & txt_telefono.Text & "', '" & txt_ciudad.Text & "', '" & txt_pais.Text & "', '" & txt_movil.Text & "', '" & txt_relacCom.Text & "' )", conexion)
            cmd4.ExecuteNonQuery()
            conexion.Close()

            MsgBox("Datos Almacenados", MsgBoxStyle.Information)

        Else
            Dim sql As String

            Dim codvend As String = txt_cod_vend.Text
            ':::nombre
            Dim nombre As String = txt_nombre.Text
            ':::comision
            Dim comision As String = txt_com.Text
            ':::telefono
            Dim telefono As String = txt_telefono.Text
            'ciudad
            Dim ciudad As String = txt_ciudad.Text
            'pais
            Dim pais As String = txt_pais.Text
            'celular
            Dim celular As String = txt_movil.Text
            'relac com
            Dim relac_com As String = txt_relacCom.Text
            'planta



            ':::Creamos nuestra consulta de tipo Insert y le pasamos nuestros valores
            sql = "Insert into vendedor (cod_vend, nombre, comision, telefono, ciudad, pais, nro_fax, relac_com) " &
            " values ('" & codvend & "', '" & nombre & "', '" & comision & "', '" & telefono & "', '" & ciudad & "', '" & pais & "', '" & celular & "', '" & relac_com & "')"
            ':::Llamamos el procedimiento que hemos creado en el modulo y le pasamos el parametro que es la consulta SQL

            Dim cmd As New OleDbCommand(sql, Con3)
            If Con3.State = 1 Then Con3.Close()
            Con3.Open()

            cmd.ExecuteNonQuery()
            Con3.Close()



            MsgBox("Registro Agregado exitosamente", MsgBoxStyle.Information, ":: Ingreso de Datos:::")
            lbl_nroreg.Text = "1"
        End If

        'Catch ex As Exception
        ' MsgBox("No se pueden guardar los registro por: " & ex.Message, MsgBoxStyle.Critical, "carga clientes")
        'End Try
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_carga_vend_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub cmd_ver_reg_Click(sender As Object, e As EventArgs) Handles cmd_ver_reg.Click

        ' Try
        Dim cmd1 As New MySqlCommand


        If var = 1 Then
                'conecta a mysql
                Call conn1()
                If conexion.State = 1 Then conexion.Close()
                conexion.Open()
                cmd1.Connection = conexion


            cmd1.CommandText = "SELECT * FROM vendedor ORDER BY Nombre ASC"


            Dim dt As System.Data.DataTable = New System.Data.DataTable
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
                da.Fill(dt)
            grilla.DataSource = dt

            conexion.Close()
                da.Dispose()
                cmd1.Dispose()



            Else
            'conecta a access

            If Con3.State = 1 Then Con3.Close()
            Con3.Open()

            Dim da As New OleDbDataAdapter("SELECT * FROM vendedor ORDER BY Nombre ASC", Con3)
            Dim ds As New DataSet

            da.Fill(ds)
            grilla.DataSource = ds.Tables(0)
            Con3.Close()


        End If

        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub txt_cod_vend_TextChanged(sender As Object, e As EventArgs) Handles txt_cod_vend.TextChanged

    End Sub

    Private Sub txt_cod_vend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cod_vend.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                If txt_cod_vend.Text <> "" Then

                    txt_nombre.Select()

                Else
                    txt_cod_vend.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                txt_nombre.CharacterCasing = CharacterCasing.Upper
                If txt_nombre.Text <> "" Then
                    txt_nombre.Text.ToUpper() 'cambia a mayusculas
                    txt_com.Select()

                Else
                    txt_nombre.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_com_TextChanged(sender As Object, e As EventArgs) Handles txt_com.TextChanged

    End Sub

    Private Sub txt_com_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_com.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                If txt_com.Text <> "" Then

                    txt_telefono.Select()

                Else
                    txt_com.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_telefono_TextChanged(sender As Object, e As EventArgs) Handles txt_telefono.TextChanged

    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                If txt_telefono.Text <> "" Then

                    txt_ciudad.Select()

                Else
                    txt_telefono.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_ciudad_TextChanged(sender As Object, e As EventArgs) Handles txt_ciudad.TextChanged

    End Sub

    Private Sub txt_ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ciudad.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                txt_ciudad.CharacterCasing = CharacterCasing.Upper
                If txt_ciudad.Text <> "" Then
                    txt_ciudad.Text.ToUpper() 'cambia a mayusculas
                    txt_pais.Select()

                Else
                    txt_ciudad.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_pais_TextChanged(sender As Object, e As EventArgs) Handles txt_pais.TextChanged

    End Sub

    Private Sub txt_pais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pais.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                txt_pais.CharacterCasing = CharacterCasing.Upper
                If txt_pais.Text <> "" Then
                    txt_pais.Text.ToUpper() 'cambia a mayusculas
                    txt_movil.Select()

                Else
                    txt_pais.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_movil_TextChanged(sender As Object, e As EventArgs) Handles txt_movil.TextChanged

    End Sub

    Private Sub txt_movil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_movil.KeyPress
        Try


            If e.KeyChar = Convert.ToChar(13) Then
                If IsNumeric(txt_movil.Text) = False Then
                    MsgBox("Sólo se permiten números", MsgBoxStyle.Critical)
                    txt_movil.Select()
                Else

                    txt_relacCom.Select()

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_relacCom_TextChanged(sender As Object, e As EventArgs) Handles txt_relacCom.TextChanged

    End Sub

    Private Sub txt_relacCom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_relacCom.KeyPress
        Try


            If e.KeyChar = Convert.ToChar(13) Then
                If IsNumeric(txt_relacCom.Text) = False Then
                    MsgBox("Sólo se permiten números", MsgBoxStyle.Critical)
                    txt_relacCom.Select()
                Else
                    cmd_agregar.Enabled = True
                    cmd_agregar.Select()

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class