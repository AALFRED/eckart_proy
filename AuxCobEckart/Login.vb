Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System
Imports System.Diagnostics
Imports System.Object
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Net
Imports MySql.Data.MySqlClient
Imports AuxCobEckart



Public Class Login

    Public level As Integer
    Dim fecha1 As String
    Dim ano As String

    Dim perfil As Integer = 0
    Dim bloqueo As Integer
    Dim Id_reg As Integer

    Dim sSql As String
    Dim sql As String
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Dim ds As New DataSet
    Dim sw As Boolean = False
    Dim dt As New DataTable

    Dim com As New MySqlCommand
    Dim rs As MySqlDataReader
    Dim rs1 As MySqlDataReader

    Dim cmd As MySqlCommand = New MySqlCommand
    Dim cmd2 As MySqlCommand = New MySqlCommand

    'Public Sub registra_entrada(bandera)
    '    Dim mifecha As String
    '    mifecha = System.DateTime.Now.ToString((" yyyy-MM-dd HH:mm:ss"))

    '    Try


    '        If conexion.State = 1 Then conexion.Close()
    '        conexion.Open()

    '        If bandera = False Then

    '            cmd = New MySqlCommand("INSERT INTO ctrl_acceso_cm (id, usuario, ingreso) Values (0, '" & txt_usuario.Text & "', '" & (mifecha) & "')", conexion)
    '            cmd.ExecuteNonQuery()
    '            cmd.Dispose()
    '            conexion.Close()
    '            cmd_ingreso.Enabled = True
    '        Else
    '            cmd_ingreso.Enabled = True
    '        End If
    '        cmd.Dispose()
    '        conexion.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try

    'End Sub

    'Sub Lastaccess()

    '    Try
    '        If txt_usuario.Text <> "" Then


    '            conexion.Open()

    '            sql = "Select MAX(ingreso) FROM ctrl_acceso where usuario ='" & txt_usuario.Text & "'"
    '            com = New MySqlCommand(sql, conexion)
    '            rs1 = com.ExecuteReader()

    '            If rs1.HasRows() Then
    '                rs1.Read()


    '                Label6.Text = rs1.GetString(0)


    '            Else
    '                MessageBox.Show("No hay Accesos Registrados", "Validacion Usuario")
    '                Label6.Text = ""
    '                txt_usuario.Select()
    '                Exit Sub
    '            End If

    '            rs1.Dispose()
    '            conexion.Close()
    '        Else
    '            txt_usuario.Select()
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    'End Sub

    Function ExisteUsuario(ByVal usuario As String, ByVal password As String) As Boolean

        Try
            Call conn1()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            sSql = "Select * From usuarios where usuario= '" & txtUser.Text & "' and pass= '" & txt_pass.Text & "'"
            da = New MySqlDataAdapter(sSql, conexion)
            ds.Clear()
            da.Fill(ds, "usuarios")

            If (ds.Tables("usuarios").Rows.Count() <> 0) Then

                ' MessageBox.Show("Usuario Encontrado", "Validacion Usuario")
                sw = True
            Else
                MessageBox.Show("Usuario o Password no Válido", "Validacion de Usuario")
                sw = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return (sw)
        txt_pass.Select()
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ingreso.Click


        'If ExisteUsuario(txtUser.Text, txt_pass.Text) Then
        '    Me.Hide()
        '    Principal.Show()
        'Else
        '    Exit Sub
        'End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call elano() 'trae el año

        Call Conectar()

        ano = miano.ToString



        cbo_tipo_conn.Items.Add("LOCAL")
        cbo_tipo_conn.Items.Add("RED")



        Me.Text = "ECKART //Sistema Aux. de Cobranza - versión Rev.1.0 - Año *** " & ano & " ****"

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
        BarraStatusTexto.Width = 300
        BarraStatusTexto.Text = "CONECTADO A BD: " & mibd.ToString
        BarraStatus.Panels.Add(BarraStatusTexto)

        Dim BarraStatusTexto2 = New StatusBarPanel
        BarraStatusTexto2.Name = "StatusBartexto"
        BarraStatusTexto2.Width = 300
        BarraStatusTexto2.Text = "SERVIDOR : " & miserver.ToString
        BarraStatus.Panels.Add(BarraStatusTexto2)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)


        txtUser.Text = ""
        txt_pass.Text = ""
        txt_pass.UseSystemPasswordChar = True
        txt_pass.Enabled = True
        Label5.Text = ""
        Label6.Text = ""
        cmd_ingreso.Enabled = False




    End Sub


    Private Sub cbo_tipo_conn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_conn.SelectedIndexChanged
        If cbo_tipo_conn.Text = "LOCAL" Then
            Connex = 0
        Else
            Connex = 1

        End If
    End Sub

    Private Sub cbo_tipo_conn_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_tipo_conn.SelectedValueChanged
        If cbo_tipo_conn.Text = "LOCAL" Then
            Connex = 0
        Else
            Connex = 1

        End If
    End Sub


    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        Dim dr3 As MySqlDataReader
        Dim bandera As Boolean


        Try
            If e.KeyChar = Convert.ToChar(13) Then

                If sw = False Then
                    Exit Sub
                Else

                    If txt_pass.Text <> "" Then
                    End If


                    Call Conectar()
                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()



                    cmd2.CommandText = ("SELECT * FROM usuarios where usuario= '" & txtUser.Text & "' and pass = '" & txt_pass.Text & "'")
                    cmd2.Connection = conexion
                    cmd2.CommandType = CommandType.Text
                    dr3 = cmd2.ExecuteReader

                    If dr3.Read = False Then
                        'cmd2.ExecuteNonQuery()
                        MessageBox.Show("La Clave o el Usuario no son válidos", "Validación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        conexion.Close()

                        bandera = True
                        txt_pass.Select()
                    Else
                        bandera = False
                    End If


                    ' Call registra_entrada(bandera)
                    dr3.Dispose()
                    conexion.Close()
                    cmd_ingreso.Select()


                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        'Try
        'SoloLetras(e)
        If e.KeyChar = Convert.ToChar(13) Then

            MsgBox("paso")
            'txtUser.CharacterCasing = CharacterCasing.Upper

            'If Connex = 0 Then
            '    'MODO LOCAL
            '    Call Conectar()
            'Else
            '    'MODO RED

            'End If


            'If conexion.State = 1 Then conexion.Close()
            'conexion.Open()

            'If txtUser.Text <> "" Then
            '    txtUser.Text.ToUpper() 'cambia a mayusculas

            '    sql = "SELECT usuario, perfil, bloqueo, id FROM usuarios where usuario= '" & txtUser.Text & "'"
            '    com = New MySqlCommand(sql, conexion)
            '    rs = com.ExecuteReader()
            '    If rs.HasRows() Then
            '        rs.Read()

            '        txtUser.Text = rs.GetString(0)
            '        perfil = rs.GetString(1)
            '        bloqueo = rs.GetString(2)
            '        Id_reg = rs.GetString(3)
            '        sw = True
            '    Else
            '        txtUser.Text = ""
            '        'MessageBox.Show("No Existen accesos Registrados", "Validacion de Acceso")
            '        sw = False

            '    End If
            '    If sw = True Then
            '        Select Case perfil
            '            Case 1
            '                Label5.Text = "Administrador"
            '            Case 2
            '                Label5.Text = "Usuario"

            '        End Select

            '        If bloqueo = 1 Then
            '            MsgBox("Este Usuario se encuentra bloqueado, verifique!")
            '            txtUser.Select()
            '        Else
            '            conexion.Close()
            '            'Call Lastaccess()

            '            level = perfil  'le pasa el valor del perfil que tiene el usuario
            '            txt_pass.Enabled = True
            '            txt_pass.Select()

            '        End If
            '    Else
            '        conexion.Close()
            '        txtUser.Select()


            '    End If
            '    rs.Dispose()
            '    conexion.Close()
            'End If
        End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    da = Nothing
        '    conexion.Close()
        'End Try
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Acceso.Show()
    End Sub
End Class
