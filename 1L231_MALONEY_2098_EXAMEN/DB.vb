Imports Azure.Core.HttpHeader
Imports System.Net
Imports System.Windows.Forms.AxHost
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Internal.Requests

Public Class DB
    Dim connectionString As String
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim SqlReader As SqlDataReader
    Dim sqlAdapter As SqlDataAdapter

    Public Sub New()
        connectionString = "Data Source=DESKTOP-G8SFV7E;Initial Catalog=SEMESTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0"
    End Sub

    Public Sub abrir()
        Try
            connection = New SqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            MsgBox("abrir " + ex.ToString())
        End Try
    End Sub
    Public Sub cerrar()
        If Not IsNothing(SqlReader) Then
            SqlReader.Close()
        End If

        connection.Close()
    End Sub

    Public Function getList(table As String) As DataTable
        Dim dt As New DataTable()

        Try
            abrir()
            command = New SqlCommand(table, connection)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            cerrar()
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
        End Try
        Return dt

    End Function

    Public Function getDistrict(ID_PROVINCE As String) As DataTable
        Dim dt As New DataTable()

        Try
            abrir()
            command = New SqlCommand("SP_DISTRICT_GET", connection)
            command.Parameters.AddWithValue("@ID_PROVINCE", ID_PROVINCE)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            cerrar()
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
        End Try
        Return dt

    End Function

    Public Function getUserByCod(table As String, cod As String, typeUser As String) As DataTable
        Dim dt As New DataTable()

        Try
            abrir()
            command = New SqlCommand(table, connection)

            command.Parameters.AddWithValue("@COD_USER", cod)
            command.Parameters.AddWithValue("@TYPE_USER", typeUser)
            command.CommandType = CommandType.StoredProcedure

            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            cerrar()
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
        End Try
        Return dt

    End Function

    Public Function getUser(typeUser As String) As DataTable
        Dim dt As New DataTable()

        Try
            abrir()
            command = New SqlCommand("SP_USERS_GET", connection)

            command.Parameters.AddWithValue("@TYPE_USER", typeUser)
            command.CommandType = CommandType.StoredProcedure

            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            cerrar()
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
        End Try
        Return dt

    End Function

    Public Function postUserNew(cod As String, name As String, lastname As String, email As String, phone As String, address As String, salary As String, district As String, state As String, typeUser As String, province As String, ident As String) As Boolean

        Try
            abrir()
            command = New SqlCommand("SP_USERS_NEW", connection)

            command.Parameters.AddWithValue("@COD_USER", cod)
            command.Parameters.AddWithValue("@USE_NAME", name)
            command.Parameters.AddWithValue("@USE_LASTNAME", lastname)
            command.Parameters.AddWithValue("@USE_EMAIL", email)
            command.Parameters.AddWithValue("@USE_PHONE", phone)
            command.Parameters.AddWithValue("@USE_ADDRESS", address)
            command.Parameters.AddWithValue("@USE_SALARIE", salary)
            command.Parameters.AddWithValue("@ID_DITRICT", district)
            command.Parameters.AddWithValue("@ID_STATE", state)
            command.Parameters.AddWithValue("@TYPE_USER", typeUser)
            command.Parameters.AddWithValue("@ID_PROVINCE", province)
            command.Parameters.AddWithValue("@USE_IDENT", ident)

            command.CommandType = CommandType.StoredProcedure

            command.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
            Return False
        End Try

    End Function

    Public Function deleteUser(COD_USER As String)
        Try
            abrir()
            command = New SqlCommand("SP_USERS_DELETE", connection)

            command.Parameters.AddWithValue("@COD_USER", COD_USER)
            command.CommandType = CommandType.StoredProcedure
            command.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
            Return False
        End Try
    End Function

    Public Function upddateUser(COD_USER As String, USE_NAME As String, USE_LASTNAME As String, USE_EMAIL As String, USE_PHONE As String, USE_ADDRESS As String, USE_SALARIE As String, ID_DITRICT As String, ID_STATE As String, ID_PROVINCE As String, USE_IDENT As String)
        Try
            abrir()
            command = New SqlCommand("SP_USERS_UPDATE", connection)

            command.Parameters.AddWithValue("@COD_USER", COD_USER)
            command.Parameters.AddWithValue("@USE_NAME", USE_NAME)
            command.Parameters.AddWithValue("@USE_LASTNAME", USE_LASTNAME)
            command.Parameters.AddWithValue("@USE_EMAIL", USE_EMAIL)
            command.Parameters.AddWithValue("@USE_PHONE", USE_PHONE)
            command.Parameters.AddWithValue("@USE_ADDRESS", USE_ADDRESS)
            command.Parameters.AddWithValue("@USE_SALARIE", USE_SALARIE)
            command.Parameters.AddWithValue("@ID_DITRICT", ID_DITRICT)
            command.Parameters.AddWithValue("@ID_STATE", ID_STATE)
            command.Parameters.AddWithValue("@ID_PROVINCE", ID_PROVINCE)
            command.Parameters.AddWithValue("@USE_IDENT", USE_IDENT)

            command.CommandType = CommandType.StoredProcedure

            command.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
            Return False
        End Try
    End Function

    Public Function getFaculty() As DataTable
        Dim dt As New DataTable()

        Try
            abrir()
            command = New SqlCommand("SP_FACULTY_GET", connection)

            command.CommandType = CommandType.StoredProcedure

            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            cerrar()
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
        End Try
        Return dt

    End Function

    Public Function getFacultyById(ID_FACULTY As String) As DataTable
        Dim dt As New DataTable()

        Try
            abrir()
            command = New SqlCommand("SP_FACULTY_GET_BY_ID", connection)

            command.Parameters.AddWithValue("@ID_FACULTY", ID_FACULTY)
            command.CommandType = CommandType.StoredProcedure

            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            cerrar()
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
        End Try
        Return dt

    End Function

    Public Function postFacultyNew(FAC_NAME As String, FAC_CODIGO As String) As Boolean

        Try
            abrir()
            command = New SqlCommand("SP_FACULTY_NEW", connection)

            command.Parameters.AddWithValue("@FAC_NAME", FAC_NAME)
            command.Parameters.AddWithValue("@FAC_CODIGO", FAC_CODIGO)

            command.CommandType = CommandType.StoredProcedure

            command.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MsgBox("excuteReader " + ex.ToString())
            Return False
        End Try

    End Function

End Class
