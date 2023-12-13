Imports Microsoft.VisualBasic.ApplicationServices

Public Class _30_TEACHER
    Dim var_province As New Province()
    Dim var_user As New User()
    Dim var_distric As New District()
    Private Sub _30_TEACHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_search.Enabled = False

        txt_address.Height = 60

        ddl_state.Items.Add("Activo")
        ddl_state.Items.Add("Suspendido")
        ddl_state.SelectedIndex = 0

        txt_address.Enabled = False
        txt_email.Enabled = False
        txt_ident.Enabled = False
        txt_lastname.Enabled = False
        txt_name.Enabled = False
        txt_phone.Enabled = False
        txt_salary.Enabled = False
        ddl_district.Enabled = False
        ddl_province.Enabled = False
        ddl_state.Enabled = False

        btn_new.Enabled = False
        btn_delete.Enabled = False
        btn_edit.Enabled = False

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim lstUser As DataTable
        lstUser = New DataTable()
        lstUser = var_user.getUserByCod(txt_search.Text, "Profesor")

        If (lstUser.Rows.Count > 0) Then
            txt_search.Enabled = False
            btn_search.Enabled = False
            txt_name.Text = lstUser.Rows(0)("USE_NAME").ToString()
            txt_lastname.Text = lstUser.Rows(0)("USE_LASTNAME").ToString()
            txt_ident.Text = lstUser.Rows(0)("USE_IDENT").ToString()
            txt_address.Text = lstUser.Rows(0)("USE_ADDRESS").ToString()
            txt_phone.Text = lstUser.Rows(0)("USE_PHONE").ToString()
            txt_email.Text = lstUser.Rows(0)("USE_EMAIL").ToString()
            ddl_state.SelectedIndex = CInt(lstUser.Rows(0)("ID_STATE").ToString()) - 1
            ddl_province.SelectedValue = lstUser.Rows(0)("ID_DITRICT").ToString()
            txt_salary.Text = lstUser.Rows(0)("USE_SALARIE").ToString()

            ddl_province.DataSource = var_province.getProvince()
            ddl_province.DisplayMember = "PRO_NAME"
            ddl_province.ValueMember = "ID_PROVINCE"
            ddl_province.SelectedValue = lstUser.Rows(0)("ID_PROVINCE").ToString()

            ddl_district.DataSource = var_distric.getDistrict(lstUser.Rows(0)("ID_PROVINCE").ToString())
            ddl_district.DisplayMember = "DIS_NAME"
            ddl_district.ValueMember = "ID_DISTRICT"
            ddl_district.SelectedValue = lstUser.Rows(0)("ID_DITRICT").ToString()

            ddl_state.SelectedIndex = CInt(lstUser.Rows(0)("ID_STATE").ToString())

            btn_delete.Enabled = True
            btn_edit.Enabled = True

            txt_address.Enabled = True
            txt_email.Enabled = True
            txt_ident.Enabled = True
            txt_lastname.Enabled = True
            txt_name.Enabled = True
            txt_phone.Enabled = True
            txt_salary.Enabled = True
            ddl_district.Enabled = True
            ddl_province.Enabled = True
            ddl_state.Enabled = True

        Else
            btn_new.Enabled = True
            txt_search.Enabled = False

            ddl_province.DataSource = var_province.getProvince()
            ddl_province.DisplayMember = "PRO_NAME"
            ddl_province.ValueMember = "ID_PROVINCE"
            ddl_province.SelectedIndex = 0

            txt_address.Enabled = True
            txt_email.Enabled = True
            txt_ident.Enabled = True
            txt_lastname.Enabled = True
            txt_name.Enabled = True
            txt_phone.Enabled = True
            txt_salary.Enabled = True
            ddl_district.Enabled = True
            ddl_province.Enabled = True
            ddl_state.Enabled = True

        End If
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
        txt_ident.Text = ""
        txt_email.Text = ""
        txt_salary.Text = ""
        txt_phone.Text = ""

        txt_address.Enabled = False
        txt_email.Enabled = False
        txt_ident.Enabled = False
        txt_lastname.Enabled = False
        txt_name.Enabled = False
        txt_phone.Enabled = False
        txt_salary.Enabled = False
        ddl_district.Enabled = False
        ddl_province.Enabled = False
        ddl_state.Enabled = False
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        var_user.postUserNew(txt_search.Text, txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_address.Text, txt_salary.Text, ddl_district.SelectedValue.ToString(), ddl_state.SelectedIndex.ToString(), "Profesor", ddl_province.SelectedValue.ToString(), txt_ident.Text, 0, 0, 0)
        clear()
    End Sub

    Private Sub ddl_province_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_province.SelectedIndexChanged
        Dim provi As String = 1
        If (ddl_province.SelectedValue.ToString().Length < 3 And ddl_province.SelectedValue.ToString().Length > 0) Then
            provi = ddl_province.SelectedValue.ToString()
        End If
        ddl_district.DataSource = var_distric.getDistrict(provi)
        ddl_district.DisplayMember = "DIS_NAME"
        ddl_district.ValueMember = "ID_DISTRICT"
        ddl_district.SelectedIndex = 0

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        var_user.deleteUser(txt_search.Text)
        clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        var_user.upddateUser(txt_search.Text, txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_address.Text, txt_salary.Text, ddl_district.SelectedValue.ToString(), ddl_state.SelectedIndex.ToString(), ddl_province.SelectedValue.ToString(), txt_ident.Text, "Profesor", 0, 0, 0)
        clear()
    End Sub
End Class