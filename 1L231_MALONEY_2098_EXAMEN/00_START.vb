Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1800
        Me.Height = 900

        Dim wins As New _01_HOME
        wins.MdiParent = Me
        wins.WindowState = FormWindowState.Maximized
        wins.ControlBox = False
        wins.Show()

    End Sub
    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
        Dim wins As New _02_PRESENT
        wins.MdiParent = Me
        wins.WindowState = FormWindowState.Maximized
        wins.ControlBox = False
        wins.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click
        Dim wins As New _20_STUDENT
        wins.MdiParent = Me
        wins.WindowState = FormWindowState.Maximized
        wins.ControlBox = False
        wins.Show()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Dim wins As New _21_STUDENT_LST
        wins.MdiParent = Me
        wins.WindowState = FormWindowState.Maximized
        wins.ControlBox = False
        wins.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem1.Click
        Dim wins As New _30_TEACHER
        wins.MdiParent = Me
        wins.WindowState = FormWindowState.Maximized
        wins.ControlBox = False
        wins.Show()
    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click
        Dim wins As New _31_TEACHER_LST
        wins.MdiParent = Me
        wins.WindowState = FormWindowState.Maximized
        wins.ControlBox = False
        wins.Show()
    End Sub
End Class
