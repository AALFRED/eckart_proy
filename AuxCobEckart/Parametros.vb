﻿Imports System.Data
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


Public Class Parametros
    Dim bloqueoUser As Integer

    Public Function cargacombo(ByVal TABLENAME As String, ByVal fldName As String, ByVal cmbname As ComboBox)
        Dim cmd1 As New MySqlCommand
        Dim dr1 As MySqlDataReader

        Call conn1()

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)


            dr1 = cmd1.ExecuteReader
            cmbname.Items.Clear()
            Do While dr1.Read()
                cmbname.Items.Add(dr1(fldName))
            Loop
            dr1.Close()
            conexion.Close()
            cmd1.Dispose()


        Return 0
    End Function

    Sub formato_grilla()

        'FORMATO DE grillaCM
        grilla.Columns(0).HeaderCell.Value = "idbd"
        grilla.Columns(1).HeaderCell.Value = "Usuario"
        grilla.Columns(2).HeaderCell.Value = "Password"
        grilla.Columns(3).HeaderCell.Value = "Perfil"
        grilla.Columns(4).HeaderCell.Value = "Bloqueo"



        grilla.Columns(0).Width = 0
        grilla.Columns(1).Width = 100
        grilla.Columns(2).Width = 90
        grilla.Columns(3).Width = 50
        grilla.Columns(4).Width = 50


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


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


    Sub Carga_datos()

        Try
            Dim cmd1 As New MySqlCommand


            'conecta a mysql

            If Connex = 1 Then
                Call Conectar()
            Else
                Call conn1()
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd1.Connection = conexion


            cmd1.CommandText = "SELECT * FROM usuarios ORDER BY usuario ASC"


            Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
            da.Fill(dt)
            grilla.DataSource = dt

            conexion.Close()
            da.Dispose()
            cmd1.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub



    Private Sub cmd_grabar_usr_Click(sender As Object, e As EventArgs) Handles cmd_grabar_usr.Click
        Dim cmd3 As New MySqlCommand

        Try

            If Connex = 1 Then
                Call Conectar()
            Else
                Call conn1()
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            If bloqueoUser = 0 Then
                cmd3 = New MySqlCommand("Insert Into usuarios (id, usuario, pass, perfil, bloqueo) Values (0,'" & txt_user.Text & "', '" & txt_pass.Text & "', '2', '0' )", conexion)
            Else
                cmd3 = New MySqlCommand("Insert Into usuarios (id, usuario, pass, perfil, bloqueo) Values (0,'" & txt_user.Text & "', '" & txt_pass.Text & "', '2', '" & bloqueoUser & "' )", conexion)
            End If
            cmd3.ExecuteNonQuery()

            conexion.Close()
            cmd3.Dispose()

            MsgBox("Datos Almacenados para perfil", MsgBoxStyle.Information)

            Call cargacombo("perfil", "perfil", cbo_perfil)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        Try

            Call Carga_datos()

            Call formato_grilla()
            cmd_actualiza.Visible = False


            Call cargacombo("usuarios", "usuario", cbo_usuario)

            Call cargacombo("perfil", "perfil", cbo_perfil)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cmd_grabar_perfil_Click(sender As Object, e As EventArgs) Handles cmd_grabar_perfil.Click
        Dim cmd As New MySqlCommand

        Try


            If Connex = 1 Then
            Call Conectar()
        Else
            Call conn1()
        End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd = New MySqlCommand("Insert Into perfil (id, perfil) Values (0,'" & txt_perfil.Text() & "')", conexion)
            cmd.ExecuteNonQuery()

            conexion.Close()
            cmd.Dispose()

            MsgBox("Datos Almacenados para perfil", MsgBoxStyle.Information)

            Call cargacombo("perfil", "perfil", cbo_perfil)


        Catch ex As Exception
        MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Parametros_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        Principal.Show()

    End Sub

    Private Sub cmd_asig_perfil_Click(sender As Object, e As EventArgs) Handles cmd_asig_perfil.Click
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim conf As Integer = 0

        Try


            If Connex = 1 Then
                Call Conectar()
            Else
                Call conn1()
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()


            cmd = New MySqlCommand("Update usuarios Set perfil = '" & lbl_id.Text & "' where usuario = '" & cbo_usuario.Text & "'", conexion)

            cmd.ExecuteNonQuery()
            conexion.Close()
            cmd.Dispose()
            Call Carga_datos()

            MsgBox("Modificación realizada.", MsgBoxStyle.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub cbo_perfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_perfil.SelectedIndexChanged

        Dim Sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader

        Try

            If Connex = 1 Then
                Call Conectar()
            Else
                Call conn1()
            End If
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            Sql = "SELECT id FROM perfil where perfil= '" & cbo_perfil.Text & "'"
            com = New MySqlCommand(Sql, conexion)
            rs = com.ExecuteReader()
            If rs.HasRows() Then
                rs.Read()

                lbl_id.Text = rs.GetString(0)

            Else
                lbl_id.Text = 0
                'MessageBox.Show("No Existen accesos Registrados", "Validacion de Acceso")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cbo_perfil_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_perfil.SelectedValueChanged
        Dim Sql As String
        Dim com As New MySqlCommand
        Dim rs As MySqlDataReader

        Try
            If Connex = 1 Then
                Call Conectar()
            Else
                Call conn1()
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            Sql = "SELECT id, perfil FROM perfil where perfil= '" & cbo_perfil.Text & "'"
            com = New MySqlCommand(Sql, conexion)
            rs = com.ExecuteReader()
            If rs.HasRows() Then
                rs.Read()

                lbl_id.Text = rs.GetString(0)

            Else
                lbl_id.Text = 0
                'MessageBox.Show("No Existen accesos Registrados", "Validacion de Acceso")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub

    Private Sub grilla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseDoubleClick
        lbl_id_user.Text = grilla.Rows(e.RowIndex).Cells(0).Value
        txt_user.Text = grilla.Rows(e.RowIndex).Cells(1).Value
        txt_pass.Text = grilla.Rows(e.RowIndex).Cells(2).Value
        cmd_actualiza.Visible = True
        cmd_grabar_usr.Visible = False

    End Sub

    Private Sub ch_bloqueo_CheckedChanged(sender As Object, e As EventArgs) Handles ch_bloqueo.CheckedChanged

    End Sub

    Private Sub ch_bloqueo_Click(sender As Object, e As EventArgs) Handles ch_bloqueo.Click

        If ch_bloqueo.Checked = True Then


            bloqueoUser = 1
        Else
            bloqueoUser = 0

        End If
    End Sub

    Private Sub cmd_actualiza_Click(sender As Object, e As EventArgs) Handles cmd_actualiza.Click
        Dim cmd4 As New MySqlCommand


        Try


            If Connex = 1 Then
                Call Conectar()
            Else
                Call conn1()
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            cmd4 = New MySqlCommand("Update usuarios set usuario = '" & txt_user.Text & "', pass = '" & txt_pass.Text & "', bloqueo = '" & bloqueoUser & "' where id = '" & lbl_id_user.Text & "'", conexion)

            cmd4.ExecuteNonQuery()

            conexion.Close()
            cmd4.Dispose()
            Call Carga_datos()

            MsgBox("Datos Actualizados para usuarios", MsgBoxStyle.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim Query As String

        Try
            Call Conectar()
            Call elano()
            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            Query = "Delete FROM usuarios WHERE id = '" & lbl_id_user.Text & "'"

            Dim cmd As MySqlCommand = New MySqlCommand(Query, conexion)
            conexion.Close()

            MsgBox("El Usuario fue Eliminado", MsgBoxStyle.Information)
            txt_user.Text = ""
            txt_pass.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
End Class