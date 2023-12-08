<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _02_PRESENT
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
        lblt_title_02 = New Label()
        lblt_title_03 = New Label()
        lblt_title_04 = New Label()
        SuspendLayout()
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(304, 31)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(445, 24)
        lblt_title_01.TabIndex = 0
        lblt_title_01.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
        ' 
        ' lblt_title_02
        ' 
        lblt_title_02.AutoSize = True
        lblt_title_02.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_02.Location = New Point(304, 69)
        lblt_title_02.Name = "lblt_title_02"
        lblt_title_02.Size = New Size(598, 22)
        lblt_title_02.TabIndex = 1
        lblt_title_02.Text = "FACULTAD DE INGENIERÍA DE SISTEMAS COMPUTACIONALES"
        ' 
        ' lblt_title_03
        ' 
        lblt_title_03.AutoSize = True
        lblt_title_03.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_03.Location = New Point(304, 116)
        lblt_title_03.Name = "lblt_title_03"
        lblt_title_03.Size = New Size(269, 22)
        lblt_title_03.TabIndex = 3
        lblt_title_03.Text = "NOMBRE: DAVID MALONEY"
        ' 
        ' lblt_title_04
        ' 
        lblt_title_04.AutoSize = True
        lblt_title_04.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_04.Location = New Point(304, 152)
        lblt_title_04.Name = "lblt_title_04"
        lblt_title_04.Size = New Size(158, 22)
        lblt_title_04.TabIndex = 2
        lblt_title_04.Text = "CED.: 8-935-2098"
        ' 
        ' _02_PRESENT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblt_title_03)
        Controls.Add(lblt_title_04)
        Controls.Add(lblt_title_02)
        Controls.Add(lblt_title_01)
        Name = "_02_PRESENT"
        Text = "_02_PRESENT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblt_title_01 As Label
    Friend WithEvents lblt_title_02 As Label
    Friend WithEvents lblt_title_03 As Label
    Friend WithEvents lblt_title_04 As Label
End Class
