Public Class _20_STUDENT
    Dim var_user As New User()
    Dim var_faculy As New Faculty()
    Dim var_carrer As New Carrer()
    Private Sub _20_STUDENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleCenter()

        txt_address.Enabled = False
        txt_email.Enabled = False
        txt_lastname.Enabled = False
        txt_name.Enabled = False
        txt_phone.Enabled = False
        ddl_faculty.Enabled = False
        ddl_state.Enabled = False
        ddl_carrer.Enabled = False
        txt_indice.Enabled = False

        ddl_state.Items.Add("Activo")
        ddl_state.Items.Add("Suspendido")
        ddl_state.SelectedIndex = 0


    End Sub
    Private Sub _20_STUDENT_LST_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TitleCenter()
    End Sub

    Private Sub TitleCenter()
        Dim sizeValueTitle As Integer = Me.Width - 150
        lblt_title_01.Left = (Me.Width) / 2 - (lblt_title_01.Width / 2)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If (txt_search.Text.Trim().Length > 0) Then
            btn_search.Enabled = True
            btn_clean.Enabled = True
        Else
            btn_search.Enabled = False
            btn_clean.Enabled = False
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        clear()
    End Sub

    Private Sub clear()
        txt_search.Text = ""
        txt_search.Enabled = True
        btn_search.Enabled = True
        btn_new.Enabled = False
        btn_delete.Enabled = False
        btn_edit.Enabled = False

        txt_address.Text = ""
        txt_name.Text = ""
        txt_lastname.Text = ""
        txt_email.Text = ""
        txt_phone.Text = ""
        txt_indice.Text = ""


        txt_address.Enabled = False
        txt_email.Enabled = False
        txt_lastname.Enabled = False
        txt_name.Enabled = False
        txt_phone.Enabled = False
        txt_indice.Enabled = False

        ddl_faculty.Enabled = False
        ddl_carrer.Enabled = False
        ddl_state.Enabled = False
    End Sub

    Private Sub ddl_faculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_faculty.SelectedIndexChanged
        Dim provi As String = 1
        If ddl_faculty.SelectedValue IsNot Nothing Then
            If (ddl_faculty.SelectedValue.ToString().Length < 3 And ddl_faculty.SelectedValue.ToString().Length > 0) Then
                provi = ddl_faculty.SelectedValue.ToString()
            End If
            ddl_carrer.DataSource = var_carrer.getCarrer(provi)
            ddl_carrer.DisplayMember = "CAR_NAME"
            ddl_carrer.ValueMember = "ID_CAREER"
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        var_user.deleteUser(txt_search.Text)
        clear()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim lstUser As DataTable
        lstUser = New DataTable()
        lstUser = var_user.getUserByCod(txt_search.Text, "Estudiante")

        If (lstUser.Rows.Count > 0) Then
            txt_address.Text = lstUser.Rows(0).Item("USE_ADDRESS").ToString()
            txt_email.Text = lstUser.Rows(0).Item("USE_EMAIL").ToString()
            txt_lastname.Text = lstUser.Rows(0).Item("USE_LASTNAME").ToString()
            txt_name.Text = lstUser.Rows(0).Item("USE_NAME").ToString()
            txt_phone.Text = lstUser.Rows(0).Item("USE_PHONE").ToString()
            txt_indice.Text = lstUser.Rows(0).Item("USE_INDICE").ToString()

            ddl_state.SelectedValue = lstUser.Rows(0).Item("ID_STATE").ToString()

            ddl_faculty.DataSource = var_faculy.getFaculty()
            ddl_faculty.DisplayMember = "FAC_NAME"
            ddl_faculty.ValueMember = "ID_FACULTY"
            ddl_faculty.SelectedValue = lstUser.Rows(0).Item("ID_FACULTAD").ToString()

            ddl_carrer.SelectedValue = lstUser.Rows(0).Item("ID_CARRERA").ToString()
            txt_search.Enabled = False

            btn_delete.Enabled = True
            btn_edit.Enabled = True

            txt_address.Enabled = True
            txt_email.Enabled = True
            txt_lastname.Enabled = True
            txt_name.Enabled = True
            txt_phone.Enabled = True
            ddl_faculty.Enabled = True
            ddl_state.Enabled = True
            ddl_carrer.Enabled = True
            txt_indice.Enabled = True
        Else
            btn_new.Enabled = True
            txt_search.Enabled = False

            ddl_faculty.DataSource = var_faculy.getFaculty()
            ddl_faculty.DisplayMember = "FAC_NAME"
            ddl_faculty.ValueMember = "ID_FACULTY"
            ddl_faculty.SelectedIndex = 0

            txt_address.Enabled = True
            txt_email.Enabled = True
            txt_lastname.Enabled = True
            txt_name.Enabled = True
            txt_phone.Enabled = True
            ddl_faculty.Enabled = True
            ddl_state.Enabled = True
            ddl_carrer.Enabled = True
            txt_indice.Enabled = True
        End If

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        var_user.postUserNew("", txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_address.Text, 0, 0, ddl_state.SelectedIndex.ToString(), "Estudiante", 0, txt_search.Text, ddl_faculty.SelectedValue.ToString(), ddl_carrer.SelectedValue.ToString(), txt_indice.Text)
        clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        var_user.upddateUser("", txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_address.Text, 0, 0, ddl_state.SelectedIndex.ToString(), 0, txt_search.Text, "Estudiante", ddl_faculty.SelectedValue.ToString(), ddl_carrer.SelectedValue.ToString(), txt_indice.Text)
        clear()
    End Sub
End Class