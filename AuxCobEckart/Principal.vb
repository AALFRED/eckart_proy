Public Class Principal



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



        Me.CenterToScreen()

        Me.Text = "ECKART / AUXILIAR DE COBRANZA - MENÚ PRINCIPAL"


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

        cbo_conn.Items.Add("Local")
        cbo_conn.Items.Add("Red")




        lbl_version.Text = "VERSIÓN " & System.Windows.Forms.Application.ProductVersion.ToString & " - " & System.Windows.Forms.Application.CompanyName.ToString

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        End
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
        Me.Hide()
        Parametros.Show()

    End Sub

    Private Sub cbo_conn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_conn.SelectedIndexChanged
        If cbo_conn.Text = "Local" Then
            Connex = 1
        Else
            Connex = 2

        End If
    End Sub

    Private Sub cbo_conn_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_conn.SelectedValueChanged
        If cbo_conn.Text = "Local" Then
            Connex = 1
        Else
            Connex = 2

        End If
    End Sub
End Class