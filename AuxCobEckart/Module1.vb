Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text
Imports System
Imports System.Diagnostics
Imports System.Object
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
':::Libreria OleDb - Access
Imports System.Data.OleDb





Module Module1
    Public conexion As New MySqlConnection
    Public mibd As String

    'para access
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Public Connex As Integer

    ':::Procedimiento para conexion a Access
    'Dim Con3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\eckart\proyecto Cobranzas\base\Cobranza.accdb")
    Public Con3 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")
    Sub conn1()
        'conecta con Mysql
        Dim miserver2 As String = "127.0.0.1"
        Dim myid2 As String
        Dim mipass2 As String
        Dim mipuerto2 As Integer


        myid2 = "root"
        mipass2 = "Xtreme749"
        mibd = "eck_cobranza"
        mipuerto2 = "3306"
        Try


            conexion.ConnectionString = "server=" & miserver2 & ";Port=" & mipuerto2 & ";user id=" & myid2 & ";database=" & mibd & ";password=" & mipass2 & "; convert zero datetime=True"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Sub Conn2()
        'Conecta con Access

        'Dim cadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza.accdb;Persist Security Info=False"
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\eckart\proyecto Cobranzas\base\Cobranza.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString



    End Sub

    Sub conn3()
        'conecta con Mysql
        Dim miserver2 As String = "192.168.1.126"
        Dim myid2 As String
        Dim mipass2 As String
        Dim mipuerto2 As Integer


        myid2 = "root"
        mipass2 = "Xtreme749"
        mibd = "eck_cobranza"
        mipuerto2 = "3306"
        Try


            conexion.ConnectionString = "server=" & miserver2 & ";Port=" & mipuerto2 & ";user id=" & myid2 & ";database=" & mibd & ";password=" & mipass2 & "; convert zero datetime=True"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    ':::Procedimiento para exportar en Access
    Sub Exportar_Access(ByVal Sql As String)

        ':::Declaramos nuestro objeto de tipo OleDbCommand para ejecutar la consulta
        Dim cmd As New OleDbCommand(Sql, Con3)
        Try

            cmd.ExecuteNonQuery()
            ' Con3.Close()
        Catch ex As Exception
            MsgBox("No se pueden guardar los registro por: " & ex.Message, MsgBoxStyle.Critical, "carga clientes")
        End Try
    End Sub

    Sub limpiar_tabla_Access(ByRef tabla As String)


        If Con3.State = 1 Then Con3.Close()
        Con3.Open()

        Dim SQL As String
        SQL = "DELETE FROM " & tabla
        If Con3.State = 1 Then Con3.Close()
        Con3.Open()
        Dim cmd2 As New OleDbCommand(SQL, Con3)
        cmd2.ExecuteNonQuery()
        Con3.Close()
        MsgBox("Datos Eliminados", MsgBoxStyle.Critical, "Eliminacion de Datos")


    End Sub

    Sub limpiar_tabla_mysql(ByVal tabla As String)
        Dim strSQL As String

        strSQL = "TRUNCATE TABLE " & tabla

        Call conn1()
        If conexion.State = 1 Then conexion.Close()
        conexion.Open()


        Dim cmd As New MySqlCommand(strSQL, conexion)



        cmd.ExecuteNonQuery()
        MsgBox("Datos Borrados de la tabla", MsgBoxStyle.Information)
    End Sub

    'End Function
    Public Function GetDataExcel(ByVal fileName As String, ByVal sheetName As String) As DataTable

        ' Comprobamos los parámetros.
        '
        If ((String.IsNullOrEmpty(fileName)) OrElse
      (String.IsNullOrEmpty(sheetName))) Then _
      Throw New ArgumentNullException()

        Try
            Dim extension As String = IO.Path.GetExtension(fileName)

            Dim connString As String = "Data Source=" & fileName

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0;" &
               "Extended Properties='Excel 8.0;HDR=NO;IMEX=1'"

            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0;" &
               "Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1'"
            Else
                Throw New ArgumentException(
          "La extensión " & extension & " del archivo no está permitida.")
            End If

            Using conexion As New OleDbConnection(connString)

                Dim sql As String = "SELECT * FROM [" & sheetName & "$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)

                Dim dt As New DataTable("Excel")

                adaptador.Fill(dt)

                Return dt

            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Function




End Module
