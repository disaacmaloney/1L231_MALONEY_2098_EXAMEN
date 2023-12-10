<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _40_FACULTY
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
        txt_name = New TextBox()
        Label4 = New Label()
        txt_cod = New TextBox()
        Label2 = New Label()
        lblt_title_01 = New Label()
        btn_new = New Button()
        SuspendLayout()
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(360, 105)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(150, 23)
        txt_name.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(295, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 19
        Label4.Text = "NOMBRE:"
        ' 
        ' txt_cod
        ' 
        txt_cod.Location = New Point(123, 110)
        txt_cod.Name = "txt_cod"
        txt_cod.Size = New Size(150, 23)
        txt_cod.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 17
        Label2.Text = "COD:"
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(148, 43)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(341, 24)
        lblt_title_01.TabIndex = 16
        lblt_title_01.Text = "MANTENIMIENTO DE FACULTAD"
        ' 
        ' btn_new
        ' 
        btn_new.Enabled = False
        btn_new.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_new.Location = New Point(262, 76)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(92, 23)
        btn_new.TabIndex = 21
        btn_new.Text = "REGISTRAR"
        btn_new.UseVisualStyleBackColor = True
        ' 
        ' _40_FACULTY
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_new)
        Controls.Add(txt_name)
        Controls.Add(Label4)
        Controls.Add(txt_cod)
        Controls.Add(Label2)
        Controls.Add(lblt_title_01)
        Name = "_40_FACULTY"
        Text = "_40_FACULTY"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblt_title_01 As Label
    Friend WithEvents btn_new As Button
End Class
