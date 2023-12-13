Public Class _50_CAREER
    Dim var_faculy As New Faculty()
    Dim var_carrer As New Carrer()
    Private Sub _50_CAREER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddl_faculty.DataSource = var_faculy.getFaculty()
        ddl_faculty.DisplayMember = "FAC_NAME"
        ddl_faculty.ValueMember = "ID_FACULTY"
        ddl_faculty.SelectedIndex = 0
    End Sub

    Private Sub ddl_faculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_faculty.SelectedIndexChanged
        Dim facu As String = 1
        If (ddl_faculty.SelectedValue.ToString().Length < 3 And ddl_faculty.SelectedValue.ToString().Length > 0) Then
            facu = ddl_faculty.SelectedValue.ToString()
        End If
        list_user.DataSource = var_carrer.getCarrer(facu)

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        var_carrer.postCarrerNew(txt_name.Text, txt_cod.Text, ddl_faculty.SelectedValue.ToString())
        clear()
    End Sub

    Private Sub clear()
        txt_cod.Text = ""
        txt_name.Text = ""
    End Sub
End Class