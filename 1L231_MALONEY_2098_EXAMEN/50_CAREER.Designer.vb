﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _50_CAREER
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
        Label9 = New Label()
        ddl_faculty = New ComboBox()
        list_user = New DataGridView()
        lblt_title_01 = New Label()
        txt_name = New TextBox()
        Label4 = New Label()
        txt_cod = New TextBox()
        Label2 = New Label()
        btn_new = New Button()
        CType(list_user, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(148, 55)
        Label9.Name = "Label9"
        Label9.Size = New Size(155, 15)
        Label9.TabIndex = 30
        Label9.Text = "SELECCIONE LA FACULTAD: "
        ' 
        ' ddl_faculty
        ' 
        ddl_faculty.FormattingEnabled = True
        ddl_faculty.Location = New Point(309, 47)
        ddl_faculty.Name = "ddl_faculty"
        ddl_faculty.Size = New Size(150, 23)
        ddl_faculty.TabIndex = 29
        ' 
        ' list_user
        ' 
        list_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        list_user.Location = New Point(60, 90)
        list_user.Name = "list_user"
        list_user.RowTemplate.Height = 25
        list_user.Size = New Size(685, 260)
        list_user.TabIndex = 32
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(215, 12)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(347, 24)
        lblt_title_01.TabIndex = 31
        lblt_title_01.Text = "MANTENIMIENTO DE CARRERAS"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(429, 373)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(150, 23)
        txt_name.TabIndex = 36
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(364, 381)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 35
        Label4.Text = "NOMBRE:"
        ' 
        ' txt_cod
        ' 
        txt_cod.Location = New Point(192, 378)
        txt_cod.Name = "txt_cod"
        txt_cod.Size = New Size(150, 23)
        txt_cod.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(141, 381)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 33
        Label2.Text = "COD:"
        ' 
        ' btn_new
        ' 
        btn_new.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_new.Location = New Point(331, 415)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(92, 23)
        btn_new.TabIndex = 37
        btn_new.Text = "REGISTRAR"
        btn_new.UseVisualStyleBackColor = True
        ' 
        ' _50_CAREER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_new)
        Controls.Add(txt_name)
        Controls.Add(Label4)
        Controls.Add(txt_cod)
        Controls.Add(Label2)
        Controls.Add(list_user)
        Controls.Add(lblt_title_01)
        Controls.Add(Label9)
        Controls.Add(ddl_faculty)
        Name = "_50_CAREER"
        Text = "_50_CAREER"
        CType(list_user, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents ddl_faculty As ComboBox
    Friend WithEvents list_user As DataGridView
    Friend WithEvents lblt_title_01 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_new As Button
End Class
