Public Class _41_FACULTY_LIST
    Dim var_faculty As New Faculty()
    Private Sub _41_FACULTY_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list_user.DataSource = var_faculty.getFaculty()
    End Sub
End Class