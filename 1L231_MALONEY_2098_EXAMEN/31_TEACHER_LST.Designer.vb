<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _31_TEACHER_LST
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
        txt_search = New TextBox()
        Label1 = New Label()
        btn_search = New Button()
        lblt_title_01 = New Label()
        SuspendLayout()
        ' 
        ' txt_search
        ' 
        txt_search.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(357, 83)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(100, 22)
        txt_search.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(183, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 15)
        Label1.TabIndex = 6
        Label1.Text = "Ingrese el código del profesor:"
        ' 
        ' btn_search
        ' 
        btn_search.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search.Location = New Point(463, 83)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(75, 23)
        btn_search.TabIndex = 5
        btn_search.Text = "BUSCAR"
        btn_search.UseVisualStyleBackColor = True
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(191, 33)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(347, 24)
        lblt_title_01.TabIndex = 8
        lblt_title_01.Text = "MANTENIMIENTO DE PROFESOR"
        ' 
        ' _31_TEACHER_LST
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblt_title_01)
        Controls.Add(txt_search)
        Controls.Add(Label1)
        Controls.Add(btn_search)
        Name = "_31_TEACHER_LST"
        Text = "_31_TEACHER_LST"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents lblt_title_01 As Label
End Class
