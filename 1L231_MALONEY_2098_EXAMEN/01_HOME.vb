Public Class _01_HOME
    Private Sub _01_HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = Date.Now.ToString("dddd") & " " & Date.Now.ToString("dd") & " de " & Date.Now.ToString("MMMM") & " del " & Date.Now.ToString("yyyy")
        TitleCenter()
    End Sub

    Private Sub _01_HOME_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TitleCenter()
    End Sub

    Private Sub TitleCenter()
        Dim lblLarge = Me.Width - 15
        lbl_date.Left = Me.Width - (lbl_date.Width + 25)
        lbl_date_title.Left = Me.Width - (lbl_date.Width + lbl_date_title.Width + 30)
    End Sub
End Class