﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _21_STUDENT_LST
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
        list_user = New DataGridView()
        lblt_title_01 = New Label()
        CType(list_user, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' list_user
        ' 
        list_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        list_user.Location = New Point(55, 82)
        list_user.Name = "list_user"
        list_user.RowTemplate.Height = 25
        list_user.Size = New Size(685, 387)
        list_user.TabIndex = 13
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(259, 30)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(275, 24)
        lblt_title_01.TabIndex = 12
        lblt_title_01.Text = "CONSULTA DE PROFESOR"
        ' 
        ' _21_STUDENT_LST
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(list_user)
        Controls.Add(lblt_title_01)
        Name = "_21_STUDENT_LST"
        Text = "_21_STUDENT_LST"
        CType(list_user, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents list_user As DataGridView
    Friend WithEvents lblt_title_01 As Label
End Class
