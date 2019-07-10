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
Imports Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.Odbc
Imports AuxCobEckart
Imports System.Globalization
Imports DataTable = System.Data.DataTable
'::: Librerias SQL SERVER
Imports System.Data.SqlClient



Module Module1
    Public conexion As New MySqlConnection
    Public mibd As String
    Public miano As Integer
    Public perfil As Integer = 0

    'PARA SQL SERVER
    Public conexion2 As New SqlConnection



    'para access
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection
    Public dr As OleDbDataReader
    Public Connex As Integer 'guarda la variable de conexion local o red

    ':::Procedimiento para conexion a Access
    'Dim Con3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\eckart\proyecto Cobranzas\base\Cobranza.accdb")
    Public Con3 As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\eckart\proyecto Cobranzas\base\Cobranza_aux.mdb;Persist Security Info=False")

    Public miserver As String
    Public myid As String
    Public mipass As String
    Public mipuerto As Integer

    Public UserAdmin As String
    Public laemp As String
    Public tipobase As String


    'conectar
    Dim v_userad As String 'useradmin
    Public v_server As String 'ip servidor
    Dim v_port As String 'puerto
    Public v_database As String 'basede datos
    Dim v_userbd As String 'usuario de bd
    Dim v_pass As String 'pass
    Public v_emp As String  'empresa
    Public v_sqlserv As String 'tipo de base datos

    Public Sub elano()
        'saca el año a la fecha
        miano = Year(Date.Now).ToString

    End Sub

    Sub conn1()
        'CONECTAR EN FORMA LOCAL
        'conecta con Mysql
        Dim miserver2 As String = "127.0.0.1"
        Dim myid2 As String
        Dim mipass2 As String
        Dim mipuerto2 As Integer


        myid2 = "root"
        mipass2 = "Xtreme749"
        mibd = "eck_cobranza"
        mipuerto2 = "3306"
        ' Try
        If conexion.State = 1 Then conexion.Close()
        conexion.ConnectionString = "server=" & miserver2 & ";Port=" & mipuerto2 & ";user id=" & myid2 & ";database=" & mibd & ";password=" & mipass2 & "; convert zero datetime=True"

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


    End Sub

    Sub Conectar()
        ' Try

        '//////////////////////
        'CARGA DE PARAMETROS
        Const fichero As String = "C:\eckart\proyecto Cobranzas\parametros.dat"
            Dim texto As String = ""

        Dim sr As New System.IO.StreamReader(fichero)
            texto = sr.ReadToEnd()
            sr.Close()
            ' We need to read into this List.
            Dim list As New List(Of String)

        ' Open file.txt with the Using statement.
        Using r As StreamReader = New StreamReader(fichero)
            ' Store contents in this String.
            Dim line As String

            ' Read first line.
            line = r.ReadLine

            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.
                list.Add(line)

                'MsgBox(line.ToString)
                'MsgBox(Mid(line.ToString, 1, 10))




                If Mid(line.ToString, 1, 10) = "USERADMIN=" Then
                    v_userad = Mid(Trim(line), 11, 18) 'el usuario admin
                    'MsgBox(v_userad.ToString)
                    UserAdmin = v_userad.ToString

                Else
                    If Mid(line.ToString, 1, 7) = "Server=" Then
                        v_server = Mid(Trim(line), 8, 20)  'la ip del server
                        'MsgBox(v_server.ToString)
                        miserver = v_server.ToString 'asigna el valor a la v de conexion
                    Else
                        If Mid(line.ToString, 1, 5) = "Port=" Then
                            v_port = Mid(Trim(line), 6, 9)  'el port
                            'MsgBox(v_port.ToString)
                            mipuerto = v_port.ToString
                        Else

                            If Mid(line.ToString, 1, 9) = "Database=" Then
                                v_database = Mid(Trim(line), 10, 22) 'base de datos
                                'MsgBox(v_database.ToString)
                                mibd = v_database.ToString

                            Else
                                If Mid(line.ToString, 1, 5) = "User=" Then
                                    v_userbd = Mid(Trim(line), 6, 14) 'usuario
                                    'MsgBox(v_userbd.ToString)
                                    myid = v_userbd.ToString 'asigna el valor a la v de conexion
                                Else

                                    If Mid(line.ToString, 1, 9) = "password=" Then
                                        v_pass = Mid(Trim(line), 10, 18) 'password
                                        'MsgBox(v_pass.ToString)
                                        mipass = v_pass.ToString
                                    Else
                                        If Mid(line.ToString, 1, 8) = "EMPRESA=" Then
                                            v_emp = Mid(Trim(line), 9, 17) 'password
                                            'MsgBox(v_emp.ToString)
                                            laemp = v_emp.ToString
                                        Else

                                            If Mid(line.ToString, 1, 10) = "SQLServer=" Then
                                                v_sqlserv = Mid(Trim(line), 11, 27) 'password
                                                'MsgBox(v_sqlserv.ToString)
                                                tipobase = v_sqlserv.ToString
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                ' Read in the next line.
                line = r.ReadLine
            Loop
        End Using
        If conexion.State = 1 Then conexion.Close()

        'con mysql
        conexion.ConnectionString = "server=" & miserver & "; Port=" & mipuerto & "; user id=" & myid & "; database=" & mibd & "; password=" & mipass & "; convert zero datetime=True"

        ' Catch ex As Exception
        '     MsgBox(ex.Message)
        ' End Try



    End Sub


    Sub Conectar2()
        'CONECTA A SQL SERVER
        ' Try

        '//////////////////////
        'CARGA DE PARAMETROS
        Const fichero As String = "C:\eckart\proyecto Cobranzas\parametros.dat"
        Dim texto As String = ""

        Dim sr As New System.IO.StreamReader(fichero)
        texto = sr.ReadToEnd()
        sr.Close()
        ' We need to read into this List.
        Dim list As New List(Of String)

        ' Open file.txt with the Using statement.
        Using r As StreamReader = New StreamReader(fichero)
            ' Store contents in this String.
            Dim line As String

            ' Read first line.
            line = r.ReadLine

            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.
                list.Add(line)

                'MsgBox(line.ToString)
                'MsgBox(Mid(line.ToString, 1, 10))

                If Mid(line.ToString, 1, 10) = "USERADMIN=" Then
                    v_userad = Mid(Trim(line), 11, 18) 'el usuario admin
                    'MsgBox(v_userad.ToString)
                    UserAdmin = v_userad.ToString

                Else
                    If Mid(line.ToString, 1, 7) = "Server=" Then
                        v_server = Mid(Trim(line), 8, 20)  'la ip del server
                        'MsgBox(v_server.ToString)
                        miserver = v_server.ToString 'asigna el valor a la v de conexion
                    Else
                        If Mid(line.ToString, 1, 5) = "Port=" Then
                            v_port = Mid(Trim(line), 6, 9)  'el port
                            'MsgBox(v_port.ToString)
                            mipuerto = v_port.ToString
                        Else

                            If Mid(line.ToString, 1, 9) = "Database=" Then
                                v_database = Mid(Trim(line), 10, 22) 'base de datos
                                'MsgBox(v_database.ToString)
                                mibd = v_database.ToString

                            Else
                                If Mid(line.ToString, 1, 5) = "User=" Then
                                    v_userbd = Mid(Trim(line), 6, 14) 'usuario
                                    'MsgBox(v_userbd.ToString)
                                    myid = v_userbd.ToString 'asigna el valor a la v de conexion
                                Else

                                    If Mid(line.ToString, 1, 9) = "password=" Then
                                        v_pass = Mid(Trim(line), 10, 18) 'password
                                        'MsgBox(v_pass.ToString)
                                        mipass = v_pass.ToString
                                    Else
                                        If Mid(line.ToString, 1, 8) = "EMPRESA=" Then
                                            v_emp = Mid(Trim(line), 9, 17) 'password
                                            'MsgBox(v_emp.ToString)
                                            laemp = v_emp.ToString
                                        Else

                                            If Mid(line.ToString, 1, 10) = "SQLServer=" Then
                                                v_sqlserv = Mid(Trim(line), 11, 27) 'password
                                                'MsgBox(v_sqlserv.ToString)
                                                tipobase = v_sqlserv.ToString
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                ' Read in the next line.
                line = r.ReadLine
            Loop
        End Using
        If conexion2.State = 1 Then conexion2.Close()


        'con SqlServer
        conexion2.ConnectionString = "Server=" & miserver & "; Database=" & mibd & "; User Id=" & myid & ";Password=" & mipass & ""


        ' Catch ex As Exception
        '     MsgBox(ex.Message)
        ' End Try



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
        ' Dim miserver As String = "192.168.1.126"
        Dim miserver As String = "127.0.0.1"
        Dim myid2 As String
        Dim mipass2 As String
        Dim mipuerto2 As Integer


        myid2 = "root"
        mipass2 = "Xtreme749"
        mibd = "eck_cobranza"
        mipuerto2 = "3306"
        ' Try
        If conexion.State = 1 Then conexion.Close()

        conexion.ConnectionString = "server=" & miserver & ";Port=" & mipuerto2 & ";user id=" & myid2 & ";database=" & mibd & ";password=" & mipass2 & "; convert zero datetime=True"

        'Catch ex As Exception
        ' MsgBox(ex.Message)
        ' End Try




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


    Sub limpiar_tabla_sqlserver(ByVal tabla As String)
        Dim strSQL As String

        strSQL = "TRUNCATE TABLE " & tabla

        Call Conectar2()
        If conexion2.State = 1 Then conexion2.Close()
        conexion2.Open()


        Dim cmd As New SqlCommand(strSQL, conexion2)
        cmd.ExecuteNonQuery()
        conexion2.Close()
        MsgBox("Datos Borrados de la tabla", MsgBoxStyle.Information)


    End Sub


    Public Function GetDataExcel(ByVal fileName As String, ByVal sheetName As String) As DataTable

        ' Comprobamos los parámetros.
        '
        If ((String.IsNullOrEmpty(fileName)) OrElse
      (String.IsNullOrEmpty(sheetName))) Then _
      Throw New ArgumentNullException()

        Try
            Dim extension As String = IO.Path.GetExtension(fileName)

            Dim connString As String = "Data Source=" & fileName

            If extension = ".xls" Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0;" &
               "Extended Properties='Excel 8.0;HDR=NO;IMEX=1'"

            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0;" &
               "Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1'"
            Else
                Throw New ArgumentException(
          "La extensión " & extension & " del archivo no está permitida.")
            End If

            Using conexion As New System.Data.OleDb.OleDbConnection(connString)

                Dim sql As String = "SELECT * FROM [" & sheetName & "$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)

                Dim dt As New System.Data.DataTable("Excel")

                adaptador.Fill(dt)

                Return dt

            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código




End Module
