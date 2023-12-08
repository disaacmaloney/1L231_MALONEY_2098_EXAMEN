<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        PresentaciónToolStripMenuItem = New ToolStripMenuItem()
        EstudianteToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        ListarToolStripMenuItem = New ToolStripMenuItem()
        ProfesorToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem1 = New ToolStripMenuItem()
        ListarToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, EstudianteToolStripMenuItem, ProfesorToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PresentaciónToolStripMenuItem})
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(48, 20)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' PresentaciónToolStripMenuItem
        ' 
        PresentaciónToolStripMenuItem.Name = "PresentaciónToolStripMenuItem"
        PresentaciónToolStripMenuItem.Size = New Size(142, 22)
        PresentaciónToolStripMenuItem.Text = "Presentación"
        ' 
        ' EstudianteToolStripMenuItem
        ' 
        EstudianteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MantenimientoToolStripMenuItem, ListarToolStripMenuItem})
        EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        EstudianteToolStripMenuItem.Size = New Size(74, 20)
        EstudianteToolStripMenuItem.Text = "Estudiante"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(156, 22)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' ListarToolStripMenuItem
        ' 
        ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        ListarToolStripMenuItem.Size = New Size(156, 22)
        ListarToolStripMenuItem.Text = "Listar"
        ' 
        ' ProfesorToolStripMenuItem
        ' 
        ProfesorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MantenimientoToolStripMenuItem1, ListarToolStripMenuItem1})
        ProfesorToolStripMenuItem.Name = "ProfesorToolStripMenuItem"
        ProfesorToolStripMenuItem.Size = New Size(63, 20)
        ProfesorToolStripMenuItem.Text = "Profesor"
        ' 
        ' MantenimientoToolStripMenuItem1
        ' 
        MantenimientoToolStripMenuItem1.Name = "MantenimientoToolStripMenuItem1"
        MantenimientoToolStripMenuItem1.Size = New Size(180, 22)
        MantenimientoToolStripMenuItem1.Text = "Mantenimiento"
        ' 
        ' ListarToolStripMenuItem1
        ' 
        ListarToolStripMenuItem1.Name = "ListarToolStripMenuItem1"
        ListarToolStripMenuItem1.Size = New Size(180, 22)
        ListarToolStripMenuItem1.Text = "Listar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem1 As ToolStripMenuItem
End Class
