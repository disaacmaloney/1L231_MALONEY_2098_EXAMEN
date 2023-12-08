<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _20_STUDENT
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
        lblt_title_01 = New Label()
        SuspendLayout()
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(337, 213)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(143, 24)
        lblt_title_01.TabIndex = 2
        lblt_title_01.Text = "ESTUDIANTE"
        ' 
        ' _20_STUDENT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblt_title_01)
        Name = "_20_STUDENT"
        Text = "_20_STUDENT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblt_title_01 As Label
End Class
