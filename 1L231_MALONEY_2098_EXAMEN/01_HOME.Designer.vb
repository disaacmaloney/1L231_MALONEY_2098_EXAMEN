<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _01_HOME
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lbl_date_title = New Label()
        lbl_date = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(30, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 24)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido (a)"
        ' 
        ' lbl_date_title
        ' 
        lbl_date_title.AutoSize = True
        lbl_date_title.Location = New Point(534, 88)
        lbl_date_title.Name = "lbl_date_title"
        lbl_date_title.Size = New Size(106, 15)
        lbl_date_title.TabIndex = 1
        lbl_date_title.Text = "Fecha del sistema: "
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Location = New Point(646, 88)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(116, 15)
        lbl_date.TabIndex = 2
        lbl_date.Text = "FECHA DEL SISTEMA"
        ' 
        ' _01_HOME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_date)
        Controls.Add(lbl_date_title)
        Controls.Add(Label1)
        Name = "_01_HOME"
        Text = "_01_HOME"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_date_title As Label
    Friend WithEvents lbl_date As Label
End Class
