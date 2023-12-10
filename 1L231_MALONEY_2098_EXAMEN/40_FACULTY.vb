Public Class _40_FACULTY
    Dim var_faculty As New Faculty()

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        var_faculty.postFacultyNew(txt_name.Text, txt_cod.Text)
        clear()
    End Sub

    Private Sub clear()
        txt_cod.Text = ""
        txt_name.Text = ""
    End Sub

    Private Sub _40_FACULTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_new.Enabled = True
    End Sub
End Class