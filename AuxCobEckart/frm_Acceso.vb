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
Imports System.Data.SqlClient
Imports AuxCobEckart


Public Class frm_Acceso

    Public level As Integer
    Dim fecha1 As String
    Dim ano As String
    Dim bandera As Boolean


    Dim bloqueo As Integer
    Dim Id_reg As Integer

    Dim sSql As String
    Dim sql As String
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    'Para SqlServer
    Dim da1 As New SqlDataAdapter
    Dim dr1 As SqlDataReader

    Dim ds As New DataSet
    Dim sw As Boolean = False
    Dim dt As New DataTable

    Dim com As New MySqlCommand
    Dim rs As MySqlDataReader
    Dim rs1 As MySqlDataReader

    'Para SqlServer
    Dim com1 As New SqlCommand
    Dim rs11 As SqlDataReader
    Dim rs2 As SqlDataReader

    Dim cmd As MySqlCommand = New MySqlCommand
    Dim cmd2 As MySqlCommand = New MySqlCommand

    'Para SqlServer
    Dim cmd1 As SqlCommand = New SqlCommand
    Dim cmd22 As SqlCommand = New SqlCommand


    Public Sub registra_entrada(bandera)
        Dim mifecha As String
        mifecha = System.DateTime.Now.ToString((" yyyy-MM-dd HH:mm:ss"))

        'Try
        If Connex = 0 Then
            'MODO LOCAL
            Call conn3()

        Else
            'MODO RED
            Call Conectar()
        End If

        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        If bandera = False Then

            cmd = New MySqlCommand("INSERT INTO ctrl_acceso (id, usuario, acceso) Values (0, '" & txt_user.Text & "', '" & (mifecha) & "')", conexion)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conexion.Close()
            cmd_ingreso.Enabled = True
        Else
            cmd_ingreso.Enabled = True
        End If
        cmd.Dispose()
        conexion.Close()

        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'End Try
    End Sub

    Public Sub registra_entrada2(bandera)
        'PARA SQL SERVER
        Dim mifecha As String
        mifecha = System.DateTime.Now.ToString((" yyyy-MM-dd HH:mm:ss"))

        'Try
        If Connex = 0 Then
            'MODO LOCAL
            Call Conectar2()

        Else
            'MODO RED
            Call Conectar2()
        End If

        If conexion2.State = 1 Then conexion2.Close()
        conexion2.Open()

        If bandera = False Then

            cmd1 = New SqlCommand("INSERT INTO ctrl_acceso (usuario, acceso) Values ('" & txt_user.Text & "', '" & (mifecha) & "')", conexion2)
            cmd1.ExecuteNonQuery()
            cmd1.Dispose()
            conexion2.Close()
            cmd_ingreso.Enabled = True
        Else
            cmd_ingreso.Enabled = True
        End If
        cmd1.Dispose()
        conexion2.Close()

        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'End Try
    End Sub


    Function ExisteUsuario(ByVal usuario As String, ByVal password As String) As Boolean

        'Try

        If Connex = 0 Then
            'MODO LOCAL
            Call conn3()

        Else
            'MODO RED
            Call Conectar()
        End If

        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        sSql = "Select * From usuarios where usuario= '" & txt_user.Text & "' and pass= '" & txt_pass.Text & "'"
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

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try
        Return (sw)
        txt_pass.Select()
    End Function

    Function ExisteUsuario2(ByVal usuario As String, ByVal password As String) As Boolean

        'PARA SQL SERVER

        'Try

        If Connex = 0 Then
            'MODO LOCAL
            Call Conectar2()

        Else
            'MODO RED
            Call Conectar2()
        End If

        If conexion2.State = 1 Then conexion2.Close()
        conexion2.Open()

        sSql = "Select * From usuarios where usuario= '" & txt_user.Text & "' and pass= '" & txt_pass.Text & "'"
        da1 = New SqlDataAdapter(sSql, conexion2)
        ds.Clear()
        da1.Fill(ds, "usuarios")

        If (ds.Tables("usuarios").Rows.Count() <> 0) Then

            ' MessageBox.Show("Usuario Encontrado", "Validacion Usuario")
            sw = True
        Else
            MessageBox.Show("Usuario o Password no Válido", "Validacion de Usuario")
            sw = False

        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try
        Return (sw)
        txt_pass.Select()
    End Function

    Private Sub frm_Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call elano() 'trae el año


        ano = miano.ToString

        cbo_tipo_conn.Items.Add("LOCAL")
        cbo_tipo_conn.Items.Add("RED")
        cbo_tipo_conn.Text = "RED"

        If Connex = 0 Then
            'MODO LOCAL
            Call Conectar2()

        Else
            'MODO RED
            Call Conectar2()
        End If


        txt_user.Text = ""
        txt_pass.Text = ""
        txt_pass.UseSystemPasswordChar = True
        txt_pass.Enabled = True
        Label5.Text = ""


        Me.Text = "ECKART //Sistema Aux. de Cobranza - versión Rev.1.0 - Año *** " & ano & " ****"

        ''Create a StatusBar
        'Dim BarraStatus As New StatusBar
        'BarraStatus.Name = "StatusBar"
        'BarraStatus.ShowPanels = True

        ''Create the panels
        'Dim BarraStatusDate = New StatusBarPanel
        'BarraStatusDate.Name = "StatusBarDate"
        'BarraStatusDate.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        'BarraStatusDate.AutoSize = StatusBarPanelAutoSize.Contents
        'BarraStatus.Panels.Add(BarraStatusDate)

        'Dim BarraStatusTime = New StatusBarPanel
        'BarraStatusTime.Name = "StatusBarTime"
        'BarraStatusTime.Text = FormatDateTime(Now(), DateFormat.LongTime)
        'BarraStatusTime.AutoSize = StatusBarPanelAutoSize.Contents
        'BarraStatus.Panels.Add(BarraStatusTime)

        'Dim BarraStatusTexto = New StatusBarPanel
        'BarraStatusTexto.Name = "StatusBartexto"
        'BarraStatusTexto.Width = 300
        'BarraStatusTexto.Text = "CONECTADO A BD: " & mibd.ToString

        'BarraStatus.Panels.Add(BarraStatusTexto)

        'Dim BarraStatusTexto2 = New StatusBarPanel
        'BarraStatusTexto2.Name = "StatusBartexto"
        'BarraStatusTexto2.Width = 300
        'BarraStatusTexto2.Text = "SERVIDOR : " & miserver.ToString
        'BarraStatus.Panels.Add(BarraStatusTexto2)

        ''Add all teh controls to the form
        'Me.Controls.Add(BarraStatus)
        'Timer1.Enabled = True
        'Timer1.Interval = 1000
        'Timer1.Start()



        cmd_ingreso.Enabled = False


    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub
    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            txt_user.CharacterCasing = CharacterCasing.Upper

            If Connex = 0 Then
                'MODO LOCAL
                Call Conectar2()

            Else
                'MODO RED
                Call Conectar2()
            End If

            If conexion2.State = 1 Then conexion2.Close()
            conexion2.Open()

            If txt_user.Text <> "" Then
                txt_user.Text.ToUpper() 'cambia a mayusculas

                sql = "SELECT usuario, perfil, bloqueo, id FROM usuarios where usuario= '" & txt_user.Text & "'"
                com1 = New SqlCommand(sql, conexion2)
                rs11 = com1.ExecuteReader()
                If rs11.HasRows() Then
                    rs11.Read()

                    txt_user.Text = rs11.GetString(0)
                    perfil = rs11.GetInt32(1)
                    bloqueo = rs11.GetInt32(2)
                    Id_reg = rs11.GetInt32(3)
                    sw = True
                Else
                    txt_user.Text = ""
                    'MessageBox.Show("No Existen accesos Registrados", "Validacion de Acceso")
                    sw = False

                End If
                If sw = True Then
                    Select Case perfil
                        Case 1
                            Label5.Text = "Administrador"
                        Case 2
                            Label5.Text = "Usuario"

                    End Select

                    If bloqueo = 1 Then
                        MsgBox("Este Usuario se encuentra bloqueado, verifique!")
                        txt_user.Select()
                    Else
                        conexion2.Close()
                        'Call Lastaccess()

                        level = perfil  'le pasa el valor del perfil que tiene el usuario
                        txt_pass.Enabled = True
                        txt_pass.Select()

                    End If
                Else
                    conexion2.Close()
                    txt_user.Select()


                End If
                rs11.Dispose()
                conexion2.Close()
            End If




        End If
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub cbo_tipo_conn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_conn.SelectedIndexChanged


        If cbo_tipo_conn.Text = "LOCAL" Then
            Connex = 0
        Else
            Connex = 1   'red

        End If
        txt_user.Select()

    End Sub

    Private Sub cbo_tipo_conn_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_tipo_conn.SelectedValueChanged
        If cbo_tipo_conn.Text = "LOCAL" Then
            Connex = 0
        Else
            Connex = 1   'red

        End If
        txt_user.Select()
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress


        'Dim dr3 As MySqlDataReader

        'para sql server
        Dim dr3 As SqlDataReader
        Dim bandera As Boolean


        Try
            If e.KeyChar = Convert.ToChar(13) Then


                If sw = False Then
                    Exit Sub
                Else

                    If txt_pass.Text <> "" Then

                        If Connex = 0 Then
                            'MODO LOCAL
                            Call Conectar2()

                        Else
                            'MODO RED
                            Call Conectar2()
                        End If

                        If conexion2.State = 1 Then conexion2.Close()
                        conexion2.Open()

                        cmd22.CommandText = ("SELECT * FROM usuarios where usuario= '" & txt_user.Text & "' and pass = '" & txt_pass.Text & "'")
                        cmd22.Connection = conexion2
                        cmd22.CommandType = CommandType.Text
                        dr3 = cmd22.ExecuteReader

                        If dr3.Read = False Then
                            'cmd2.ExecuteNonQuery()
                            MessageBox.Show("La Clave o el Usuario no son válidos", "Validación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            conexion2.Close()

                            bandera = True
                            txt_pass.Select()
                        Else
                            bandera = False

                            cmd_ingreso.Enabled = True
                            cmd_ingreso.Select()
                        End If


                        dr3.Dispose()
                        conexion2.Close()
                        cmd_ingreso.Enabled = True
                        cmd_ingreso.Select()

                    End If
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub cmd_ingreso_Click(sender As Object, e As EventArgs) Handles cmd_ingreso.Click

        If ExisteUsuario2(txt_user.Text, txt_pass.Text) Then
            Me.Hide()

            registra_entrada2(bandera)




            Select Case perfil
                Case 1 'administrador 
                    Principal.cmd_carga_base.Enabled = True
                    Principal.cmd_parametros.Enabled = True
                    Principal.cmd_clientes.Enabled = True

                Case 2
                    Principal.cmd_carga_base.Enabled = False
                    Principal.cmd_parametros.Enabled = False
                    Principal.cmd_clientes.Enabled = False
                Case 3
                    Principal.cmd_carga_base.Enabled = False
                    Principal.cmd_parametros.Enabled = False
                    Principal.cmd_clientes.Enabled = False
                Case 4
                    Principal.cmd_carga_base.Enabled = False
                    Principal.cmd_parametros.Enabled = False
                    Principal.cmd_clientes.Enabled = False
                Case 5
                    Principal.cmd_carga_base.Enabled = False
                    Principal.cmd_parametros.Enabled = False
                    Principal.cmd_clientes.Enabled = False
                Case 6
                    Principal.cmd_carga_base.Enabled = False
                    Principal.cmd_parametros.Enabled = False
                    Principal.cmd_clientes.Enabled = False

            End Select


            Principal.Show()
        Else
            Exit Sub
            End If



    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        End
    End Sub
End Class