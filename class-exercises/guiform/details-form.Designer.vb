<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class personal_data_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        name_text = New TextBox()
        lastname_text = New TextBox()
        dateOfBirth = New TextBox()
        Button1 = New Button()
        result_label = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Όνομα"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 1
        Label2.Text = "Επίθετο"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 2
        Label3.Text = "Ημερομηνία γέννησης"
        ' 
        ' name_text
        ' 
        name_text.Location = New Point(151, 16)
        name_text.Name = "name_text"
        name_text.Size = New Size(179, 23)
        name_text.TabIndex = 3
        ' 
        ' lastname_text
        ' 
        lastname_text.Location = New Point(151, 46)
        lastname_text.Name = "lastname_text"
        lastname_text.Size = New Size(179, 23)
        lastname_text.TabIndex = 4
        ' 
        ' dateOfBirth
        ' 
        dateOfBirth.Location = New Point(151, 75)
        dateOfBirth.Name = "dateOfBirth"
        dateOfBirth.Size = New Size(179, 23)
        dateOfBirth.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(255, 119)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Εμφάνιση"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' result_label
        ' 
        result_label.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        result_label.Location = New Point(12, 170)
        result_label.Name = "result_label"
        result_label.Size = New Size(317, 155)
        result_label.TabIndex = 7
        ' 
        ' personal_data_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 339)
        Controls.Add(result_label)
        Controls.Add(Button1)
        Controls.Add(dateOfBirth)
        Controls.Add(lastname_text)
        Controls.Add(name_text)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "personal_data_form"
        Text = "Personal Data Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents name_text As TextBox
    Friend WithEvents lastname_text As TextBox
    Friend WithEvents dateOfBirth As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents result_label As Label

End Class
