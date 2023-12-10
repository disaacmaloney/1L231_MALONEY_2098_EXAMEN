Public Class _31_TEACHER_LST
    Dim var_user As New User()
    Private Sub _31_TEACHER_LST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleCenter()

        list_user.DataSource = var_user.getUser("Profesor")
        list_user.Columns("ID_USER").Visible = False

        list_user.Columns("COD_USER").DisplayIndex = 0
        list_user.Columns("COD_USER").HeaderText = "Código"

        list_user.Columns("USE_NAME").DisplayIndex = 1
        list_user.Columns("USE_NAME").HeaderText = "Nombre"

        list_user.Columns("USE_LASTNAME").DisplayIndex = 2
        list_user.Columns("USE_LASTNAME").HeaderText = "Apellido"

        list_user.Columns("USE_IDENT").DisplayIndex = 3
        list_user.Columns("USE_IDENT").HeaderText = "Identificación"

        list_user.Columns("USE_ADDRESS").DisplayIndex = 4
        list_user.Columns("USE_ADDRESS").HeaderText = "Dirección"

        list_user.Columns("USE_PHONE").DisplayIndex = 5
        list_user.Columns("USE_PHONE").HeaderText = "Teléfono"

        list_user.Columns("USE_EMAIL").DisplayIndex = 6
        list_user.Columns("USE_EMAIL").HeaderText = "Correo"

        list_user.Columns("USE_SALARIE").DisplayIndex = 7
        list_user.Columns("USE_SALARIE").HeaderText = "Salario"

        list_user.Columns("PRO_NAME").DisplayIndex = 8
        list_user.Columns("PRO_NAME").HeaderText = "Provincia"

        list_user.Columns("DIS_NAME").DisplayIndex = 9
        list_user.Columns("DIS_NAME").HeaderText = "Distrito"

        list_user.Columns("STA_NAME").DisplayIndex = 10
        list_user.Columns("STA_NAME").HeaderText = "Estado"

        list_user.Columns("ID_DITRICT").Visible = False
        list_user.Columns("ID_PROVINCE").Visible = False

        list_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



    End Sub

    Private Sub _31_TEACHER_LST_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TitleCenter()
    End Sub

    Private Sub TitleCenter()
        Dim sizeValueTitle As Integer = Me.Width - 150
        list_user.Width = sizeValueTitle
        list_user.Left = 75
        list_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        lblt_title_01.Left = (Me.Width) / 2 - (lblt_title_01.Width / 2)
    End Sub


End Class