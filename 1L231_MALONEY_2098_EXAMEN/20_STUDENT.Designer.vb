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
        Label11 = New Label()
        txt_address = New TextBox()
        Label8 = New Label()
        ddl_state = New ComboBox()
        txt_phone = New TextBox()
        Label6 = New Label()
        txt_email = New TextBox()
        Label3 = New Label()
        txt_lastname = New TextBox()
        Label4 = New Label()
        txt_name = New TextBox()
        Label2 = New Label()
        ddl_faculty = New ComboBox()
        btn_clean = New Button()
        btn_new = New Button()
        btn_delete = New Button()
        btn_edit = New Button()
        txt_search = New TextBox()
        Label1 = New Label()
        btn_search = New Button()
        lblt_title_01 = New Label()
        ddl_carrer = New ComboBox()
        txt_indice = New TextBox()
        Label5 = New Label()
        Label9 = New Label()
        Label12 = New Label()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(568, 281)
        Label11.Name = "Label11"
        Label11.Size = New Size(71, 15)
        Label11.TabIndex = 58
        Label11.Text = "DIRECCIÓN:"
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(642, 273)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(150, 23)
        txt_address.TabIndex = 54
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(584, 191)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 15)
        Label8.TabIndex = 53
        Label8.Text = "ESTADO:"
        ' 
        ' ddl_state
        ' 
        ddl_state.FormattingEnabled = True
        ddl_state.Location = New Point(639, 185)
        ddl_state.Name = "ddl_state"
        ddl_state.Size = New Size(150, 23)
        ddl_state.TabIndex = 52
        ' 
        ' txt_phone
        ' 
        txt_phone.Location = New Point(138, 227)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(150, 23)
        txt_phone.TabIndex = 49
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Location = New Point(73, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 15)
        Label6.TabIndex = 48
        Label6.Text = "TELÉFONO: "
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(385, 227)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(150, 23)
        txt_email.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(320, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 44
        Label3.Text = "CORREO: "
        ' 
        ' txt_lastname
        ' 
        txt_lastname.Location = New Point(385, 185)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(150, 23)
        txt_lastname.TabIndex = 43
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(320, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 42
        Label4.Text = "APELLIDO:"
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(138, 185)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(150, 23)
        txt_name.TabIndex = 41
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 40
        Label2.Text = "NOMBRE:"
        ' 
        ' ddl_faculty
        ' 
        ddl_faculty.FormattingEnabled = True
        ddl_faculty.Location = New Point(138, 273)
        ddl_faculty.Name = "ddl_faculty"
        ddl_faculty.Size = New Size(150, 23)
        ddl_faculty.TabIndex = 39
        ' 
        ' btn_clean
        ' 
        btn_clean.Enabled = False
        btn_clean.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_clean.Location = New Point(372, 131)
        btn_clean.Name = "btn_clean"
        btn_clean.Size = New Size(92, 23)
        btn_clean.TabIndex = 38
        btn_clean.Text = "LIMPIAR"
        btn_clean.UseVisualStyleBackColor = True
        ' 
        ' btn_new
        ' 
        btn_new.Enabled = False
        btn_new.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_new.Location = New Point(274, 131)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(92, 23)
        btn_new.TabIndex = 37
        btn_new.Text = "REGISTRAR"
        btn_new.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Enabled = False
        btn_delete.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_delete.Location = New Point(156, 131)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(92, 23)
        btn_delete.TabIndex = 36
        btn_delete.Text = "ELININAR"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Enabled = False
        btn_edit.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_edit.Location = New Point(40, 131)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(92, 23)
        btn_edit.TabIndex = 35
        btn_edit.Text = "MODIFICAR"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' txt_search
        ' 
        txt_search.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(342, 87)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(100, 22)
        txt_search.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(124, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 15)
        Label1.TabIndex = 33
        Label1.Text = "Ingrese la identificación del estudiante"
        ' 
        ' btn_search
        ' 
        btn_search.Enabled = False
        btn_search.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_search.Location = New Point(448, 87)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(75, 23)
        btn_search.TabIndex = 32
        btn_search.Text = "BUSCAR"
        btn_search.UseVisualStyleBackColor = True
        ' 
        ' lblt_title_01
        ' 
        lblt_title_01.AutoSize = True
        lblt_title_01.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblt_title_01.Location = New Point(147, 36)
        lblt_title_01.Name = "lblt_title_01"
        lblt_title_01.Size = New Size(364, 24)
        lblt_title_01.TabIndex = 31
        lblt_title_01.Text = "MANTENIMIENTO DE ESTUDIANTE"
        ' 
        ' ddl_carrer
        ' 
        ddl_carrer.FormattingEnabled = True
        ddl_carrer.Location = New Point(385, 276)
        ddl_carrer.Name = "ddl_carrer"
        ddl_carrer.Size = New Size(150, 23)
        ddl_carrer.TabIndex = 59
        ' 
        ' txt_indice
        ' 
        txt_indice.Location = New Point(642, 227)
        txt_indice.Name = "txt_indice"
        txt_indice.Size = New Size(150, 23)
        txt_indice.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(586, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 61
        Label5.Text = "INDICE: "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(64, 279)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 15)
        Label9.TabIndex = 62
        Label9.Text = "FACULTAD: "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(315, 284)
        Label12.Name = "Label12"
        Label12.Size = New Size(64, 15)
        Label12.TabIndex = 63
        Label12.Text = "CARRERA: "
        ' 
        ' _20_STUDENT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(859, 450)
        Controls.Add(Label12)
        Controls.Add(Label9)
        Controls.Add(Label5)
        Controls.Add(txt_indice)
        Controls.Add(ddl_carrer)
        Controls.Add(Label11)
        Controls.Add(txt_address)
        Controls.Add(Label8)
        Controls.Add(ddl_state)
        Controls.Add(txt_phone)
        Controls.Add(Label6)
        Controls.Add(txt_email)
        Controls.Add(Label3)
        Controls.Add(txt_lastname)
        Controls.Add(Label4)
        Controls.Add(txt_name)
        Controls.Add(Label2)
        Controls.Add(ddl_faculty)
        Controls.Add(btn_clean)
        Controls.Add(btn_new)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(txt_search)
        Controls.Add(Label1)
        Controls.Add(btn_search)
        Controls.Add(lblt_title_01)
        Name = "_20_STUDENT"
        Text = "_20_STUDENT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ddl_state As ComboBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ddl_faculty As ComboBox
    Friend WithEvents btn_clean As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents lblt_title_01 As Label
    Friend WithEvents ddl_carrer As ComboBox
    Friend WithEvents txt_indice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
End Class
