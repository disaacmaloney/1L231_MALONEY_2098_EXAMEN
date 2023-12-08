Imports Microsoft.Data.SqlClient
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

End Class
