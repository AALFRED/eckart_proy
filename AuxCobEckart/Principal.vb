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
Imports System.Data.SqlClient
Imports AuxCobEckart



Public Class Principal
    Dim cmd3 As SqlCommand = New SqlCommand
    Dim sql As String
    Dim com As New SqlCommand
    Dim rs As SqlDataReader
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer


    Sub Ultima_Carga_datos()

        Try

            If Connex = 0 Then
                'MODO LOCAL
                'Call conn3()
                Call Conectar2()


            Else
                'MODO RED
                Call Conectar2()
            End If
            If conexion2.State = 1 Then conexion2.Close()
            conexion2.Open()

            sql = "SELECT MAX(fecha) FROM ultima_carga"
            com = New SqlCommand(sql, conexion2)
            rs = com.ExecuteReader()
            If rs.HasRows() Then
                rs.Read()

                lbl_carga_datos.Text = rs.GetDateTime(0)

            Else
                lbl_carga_datos.Text = "No definido"
                'MessageBox.Show("No Existen accesos Registrados", "Validacion de Acceso")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

            Me.CenterToScreen()

            Me.Text = "ECKART / AUXILIAR DE COBRANZA - MENÚ PRINCIPAL"
            Call Ultima_Carga_datos()



            ' lbl_version.Text = "VERSIÓN " & System.Windows.Forms.Application.ProductVersion.ToString & " - " & System.Windows.Forms.Application.CompanyName.ToString

            lbl_version.Text = "VERSIÓN " & Application.ProductVersion.ToString & " - " & Application.CompanyName.ToString

            Tool1.Text = " // Cobranza Aux.- " & DateTime.Now.ToString((" dd-MM-yyyy")) '& DateTime.Now
            Tool2.Text = "// Ip del Servidor " & miserver.ToString
            Tool3.Text = "// Base de Datos: " & mibd.ToString
            Tool4.Text = "// TIPO SERVIDOR: " & tipobase.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            If conexion.State = 1 Then conexion.Close()

            End
        End If
    End Sub

    Private Sub cmd_saldo_atrasado_Click(sender As Object, e As EventArgs) Handles cmd_saldo_atrasado.Click
        Me.Hide()
        frm_saldos_atrasados.Show()
        'frm_saldos_atrasados.cmd_bus_men_fecha.PerformClick()

    End Sub

    Private Sub cmd_saldos_vend_Click(sender As Object, e As EventArgs) Handles cmd_saldos_vend.Click
        Me.Hide()
        frm_saldos_vend.Show()
        ' frm_saldos_vend.cmd_bus_saldo_vend.PerformClick()

    End Sub

    Private Sub cmd_det_vend_clte_Click(sender As Object, e As EventArgs) Handles cmd_det_vend_clte.Click
        Me.Hide()
        frm_saldos_vend.Show()
        'frm_saldos_vend.cmd_bus_saldo_vend.PerformClick()
    End Sub

    Private Sub cmd_det_deuda_clie_Click(sender As Object, e As EventArgs) Handles cmd_det_deuda_clie.Click
        Me.Hide()
        frm_saldo_cliente.Show()
        'frm_saldo_cliente.cmd_bus_saldo_clte.PerformClick()
    End Sub

    Private Sub cmd_tramos_vcto_Click(sender As Object, e As EventArgs) Handles cmd_tramos_vcto.Click
        Me.Hide()
        frm_tramos_vcto.Show()

    End Sub

    Private Sub cmd_cuadro_anual_Click(sender As Object, e As EventArgs) Handles cmd_cuadro_anual.Click
        Me.Hide()
        frm_cuadro_anual.Show()

    End Sub

    Private Sub cmd_clientes_Click(sender As Object, e As EventArgs) Handles cmd_clientes.Click


        Me.Hide()
        frm_cliente.Show()


    End Sub

    Private Sub cmd_carga_base_Click(sender As Object, e As EventArgs) Handles cmd_carga_base.Click

        Me.Hide()
        frm_carga_base.Show()


    End Sub

    Private Sub cmd_parametros_Click(sender As Object, e As EventArgs) Handles cmd_parametros.Click
        If Connex = 1 Then
            MsgBox("Este Módulo sólo funciona en entorno local de administración", MsgBoxStyle.Critical)
            Me.Show()

        Else
            Me.Hide()
            Parametros.Show()
        End If

    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
End Class