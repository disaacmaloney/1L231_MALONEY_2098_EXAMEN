﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        lblt_title_01 = New Label()
        list_user = New DataGridView()
        CType(list_user, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(191, 33)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(275, 24)
        lblt_title_01.TabIndex = 8
        lblt_title_01.Text = "CONSULTA DE PROFESOR"
        ' 
        ' list_user
        ' 
        list_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        list_user.Location = New Point(34, 72)
        list_user.Name = "list_user"
        list_user.RowTemplate.Height = 25
        list_user.Size = New Size(685, 387)
        list_user.TabIndex = 10
        ' 
        ' _31_TEACHER_LST
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 662)
        Controls.Add(list_user)
        Controls.Add(lblt_title_01)
        Name = "_31_TEACHER_LST"
        Text = "_31_TEACHER_LST"
        CType(list_user, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblt_title_01 As Label
    Friend WithEvents lst_profesor As ListBox
    Friend WithEvents list_user As DataGridView
End Class
