<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _30_TEACHER
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
        btn_search = New Button()
        Label1 = New Label()
        txt_search = New TextBox()
        btn_edit = New Button()
        btn_delete = New Button()
        btn_new = New Button()
        btn_clean = New Button()
        ddl_province = New ComboBox()
        Label2 = New Label()
        txt_name = New TextBox()
        txt_lastname = New TextBox()
        Label4 = New Label()
        txt_email = New TextBox()
        Label3 = New Label()
        txt_ident = New TextBox()
        Label5 = New Label()
        txt_phone = New TextBox()
        Label6 = New Label()
        txt_salary = New TextBox()
        Label7 = New Label()
        ddl_state = New ComboBox()
        Label8 = New Label()
        txt_address = New TextBox()
        ddl_district = New ComboBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(156, 23)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(347, 24)
        lblt_title_01.TabIndex = 1
        lblt_title_01.Text = "MANTENIMIENTO DE PROFESOR"
        ' 
        ' btn_search
        ' 
        btn_search.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search.Location = New Point(457, 74)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(75, 23)
        btn_search.TabIndex = 2
        btn_search.Text = "BUSCAR"
        btn_search.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(177, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 15)
        Label1.TabIndex = 3
        Label1.Text = "Ingrese el código del profesor:"
        ' 
        ' txt_search
        ' 
        txt_search.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(351, 74)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(100, 22)
        txt_search.TabIndex = 4
        ' 
        ' btn_edit
        ' 
        btn_edit.Enabled = False
        btn_edit.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_edit.Location = New Point(49, 118)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(92, 23)
        btn_edit.TabIndex = 5
        btn_edit.Text = "MODIFICAR"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Enabled = False
        btn_delete.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_delete.Location = New Point(165, 118)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(92, 23)
        btn_delete.TabIndex = 6
        btn_delete.Text = "ELININAR"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_new
        ' 
        btn_new.Enabled = False
        btn_new.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_new.Location = New Point(283, 118)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(92, 23)
        btn_new.TabIndex = 7
        btn_new.Text = "REGISTRAR"
        btn_new.UseVisualStyleBackColor = True
        ' 
        ' btn_clean
        ' 
        btn_clean.Enabled = False
        btn_clean.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_clean.Location = New Point(381, 118)
        btn_clean.Name = "btn_clean"
        btn_clean.Size = New Size(92, 23)
        btn_clean.TabIndex = 8
        btn_clean.Text = "LIMPIAR"
        btn_clean.UseVisualStyleBackColor = True
        ' 
        ' ddl_province
        ' 
        ddl_province.FormattingEnabled = True
        ddl_province.Location = New Point(394, 268)
        ddl_province.Name = "ddl_province"
        ddl_province.Size = New Size(150, 23)
        ddl_province.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(82, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 10
        Label2.Text = "NOMBRE:"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(147, 172)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(150, 23)
        txt_name.TabIndex = 11
        ' 
        ' txt_lastname
        ' 
        txt_lastname.Location = New Point(394, 172)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(150, 23)
        txt_lastname.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(329, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 14
        Label4.Text = "APELLIDO:"
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(394, 214)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(150, 23)
        txt_email.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(329, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 16
        Label3.Text = "CORREO: "
        ' 
        ' txt_ident
        ' 
        txt_ident.Location = New Point(667, 172)
        txt_ident.Name = "txt_ident"
        txt_ident.Size = New Size(150, 23)
        txt_ident.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(565, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 15)
        Label5.TabIndex = 18
        Label5.Text = "IDENTIFICACIÓN"
        ' 
        ' txt_phone
        ' 
        txt_phone.Location = New Point(147, 214)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(150, 23)
        txt_phone.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Location = New Point(82, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 15)
        Label6.TabIndex = 20
        Label6.Text = "TELÉFONO: "
        ' 
        ' txt_salary
        ' 
        txt_salary.Location = New Point(148, 263)
        txt_salary.Name = "txt_salary"
        txt_salary.Size = New Size(150, 23)
        txt_salary.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(82, 271)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 22
        Label7.Text = "SALARIO: "
        ' 
        ' ddl_state
        ' 
        ddl_state.FormattingEnabled = True
        ddl_state.Location = New Point(667, 214)
        ddl_state.Name = "ddl_state"
        ddl_state.Size = New Size(150, 23)
        ddl_state.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(612, 220)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 15)
        Label8.TabIndex = 25
        Label8.Text = "ESTADO:"
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(147, 312)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(150, 23)
        txt_address.TabIndex = 26
        ' 
        ' ddl_district
        ' 
        ddl_district.FormattingEnabled = True
        ddl_district.Location = New Point(667, 268)
        ddl_district.Name = "ddl_district"
        ddl_district.Size = New Size(150, 23)
        ddl_district.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(317, 276)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 15)
        Label9.TabIndex = 28
        Label9.Text = "PROVINCIA:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(604, 276)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 15)
        Label10.TabIndex = 29
        Label10.Text = "DISTRITO:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(73, 320)
        Label11.Name = "Label11"
        Label11.Size = New Size(71, 15)
        Label11.TabIndex = 30
        Label11.Text = "DIRECCIÓN:"
        ' 
        ' _30_TEACHER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 450)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(ddl_district)
        Controls.Add(txt_address)
        Controls.Add(Label8)
        Controls.Add(ddl_state)
        Controls.Add(txt_salary)
        Controls.Add(Label7)
        Controls.Add(txt_phone)
        Controls.Add(Label6)
        Controls.Add(txt_ident)
        Controls.Add(Label5)
        Controls.Add(txt_email)
        Controls.Add(Label3)
        Controls.Add(txt_lastname)
        Controls.Add(Label4)
        Controls.Add(txt_name)
        Controls.Add(Label2)
        Controls.Add(ddl_province)
        Controls.Add(btn_clean)
        Controls.Add(btn_new)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(txt_search)
        Controls.Add(Label1)
        Controls.Add(btn_search)
        Controls.Add(lblt_title_01)
        Name = "_30_TEACHER"
        Text = "_30_TEACHER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblt_title_01 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_clean As Button
    Friend WithEvents ddl_province As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ident As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_salary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ddl_state As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents ddl_district As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
