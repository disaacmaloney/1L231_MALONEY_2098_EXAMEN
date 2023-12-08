Public Class _02_PRESENT
    Private Sub _02_PRESENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleCenter()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TitleCenter()
    End Sub

    Private Sub TitleCenter()
        Dim sizeValueTitle As Integer = Me.Width / 2
        lblt_title_01.Left = sizeValueTitle - (lblt_title_01.Width / 2)
        lblt_title_01.Top = 25 + lblt_title_01.Height
        lblt_title_02.Left = sizeValueTitle - (lblt_title_02.Width / 2)
        lblt_title_02.Top = 25 + 15 + lblt_title_01.Height + lblt_title_02.Height
        lblt_title_03.Left = sizeValueTitle - (lblt_title_03.Width / 2)
        lblt_title_03.Top = 25 + 15 + 15 + lblt_title_01.Height + lblt_title_02.Height + lblt_title_03.Height
        lblt_title_04.Left = sizeValueTitle - (lblt_title_04.Width / 2)
        lblt_title_04.Top = 25 + 15 + 15 + 15 + lblt_title_01.Height + lblt_title_02.Height + lblt_title_03.Height + lblt_title_04.Height
    End Sub
End Class