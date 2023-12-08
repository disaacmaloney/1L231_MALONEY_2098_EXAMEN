Imports Microsoft.VisualBasic.ApplicationServices

Public Class _30_TEACHER
    Dim var_province As New Province()
    Dim var_user As New User()
    Private Sub _30_TEACHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_search.Enabled = False

        txt_address.Height = 60

        ddl_state.Items.Add("Activo")
        ddl_state.Items.Add("Suspendido")

        ddl_province.DataSource = var_province.getProvince()
        ddl_province.DisplayMember = "PRO_NAME"
        ddl_province.ValueMember = "ID_PROVINCE"

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim lstUser As DataTable
        lstUser = New DataTable()
        lstUser = var_user.getUserByCod(txt_search.Text, "Profesor")

        If (lstUser.Rows.Count > 0) Then
            txt_search.Enabled = False
            btn_search.Enabled = False
            'txt_cod.Text = lstUser.Rows(0)("COD_TEACHER").ToString()
            txt_name.Text = lstUser.Rows(0)("USE_NAME").ToString()
            txt_lastname.Text = lstUser.Rows(0)("USE_LASTNAME").ToString()
            txt_ident.Text = lstUser.Rows(0)("USE_IDENT").ToString()
            txt_address.Text = lstUser.Rows(0)("USE_ADDRESS").ToString()
            txt_email.Text = lstUser.Rows(0)("USE_PHONE").ToString()
            txt_email.Text = lstUser.Rows(0)("USE_EMAIL").ToString()
            ddl_state.SelectedIndex = CInt(lstUser.Rows(0)("ID_STATE").ToString()) - 1
            ddl_province.SelectedValue = lstUser.Rows(0)("ID_DITRICT").ToString()
            txt_salary.Text = lstUser.Rows(0)("USE_SALARIE").ToString()

        Else
            MsgBox("No se encontraron resultados")
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
        txt_search.Text = ""
        txt_search.Enabled = True
        btn_search.Enabled = True

        txt_address.Text = ""
        txt_name.Text = ""
        txt_lastname.Text = ""
        txt_ident.Text = ""
        txt_email.Text = ""
        txt_salary.Text = ""
    End Sub
End Class