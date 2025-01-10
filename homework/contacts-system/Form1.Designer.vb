<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        first_name = New TextBox()
        last_name = New TextBox()
        Label2 = New Label()
        phone_number = New TextBox()
        Label3 = New Label()
        save_contact_btn = New Button()
        contacts_list = New ListBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        update_contact_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Όνομα"
        ' 
        ' first_name
        ' 
        first_name.Location = New Point(130, 12)
        first_name.Name = "first_name"
        first_name.PlaceholderText = "Όνομα"
        first_name.Size = New Size(177, 23)
        first_name.TabIndex = 1
        ' 
        ' last_name
        ' 
        last_name.Location = New Point(130, 41)
        last_name.Name = "last_name"
        last_name.PlaceholderText = "Επίθετο"
        last_name.Size = New Size(177, 23)
        last_name.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 2
        Label2.Text = "Επίθετο"
        ' 
        ' phone_number
        ' 
        phone_number.Location = New Point(130, 70)
        phone_number.Name = "phone_number"
        phone_number.PlaceholderText = "Αριθμός τηλεφώνου"
        phone_number.Size = New Size(177, 23)
        phone_number.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 4
        Label3.Text = "Τηλέφωνο"
        ' 
        ' save_contact_btn
        ' 
        save_contact_btn.Location = New Point(11, 99)
        save_contact_btn.Name = "save_contact_btn"
        save_contact_btn.Size = New Size(296, 32)
        save_contact_btn.TabIndex = 6
        save_contact_btn.Text = "Αποθήκευση επαφής"
        save_contact_btn.UseVisualStyleBackColor = True
        ' 
        ' contacts_list
        ' 
        contacts_list.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        contacts_list.FormattingEnabled = True
        contacts_list.ItemHeight = 20
        contacts_list.Location = New Point(313, 12)
        contacts_list.Name = "contacts_list"
        contacts_list.Size = New Size(475, 424)
        contacts_list.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(130, 366)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 32)
        Button2.TabIndex = 8
        Button2.Text = "Διαγραφή επαφής"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(130, 404)
        Button3.Name = "Button3"
        Button3.Size = New Size(177, 32)
        Button3.TabIndex = 9
        Button3.Text = "Δημιουργία διπλότυπου"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(130, 328)
        Button4.Name = "Button4"
        Button4.Size = New Size(177, 32)
        Button4.TabIndex = 10
        Button4.Text = "Επιλογή για επεξεργασία"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' update_contact_btn
        ' 
        update_contact_btn.Location = New Point(11, 99)
        update_contact_btn.Name = "update_contact_btn"
        update_contact_btn.Size = New Size(296, 32)
        update_contact_btn.TabIndex = 11
        update_contact_btn.Text = "Ενημέρωση επαφής"
        update_contact_btn.UseVisualStyleBackColor = True
        update_contact_btn.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(update_contact_btn)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(contacts_list)
        Controls.Add(save_contact_btn)
        Controls.Add(phone_number)
        Controls.Add(Label3)
        Controls.Add(last_name)
        Controls.Add(Label2)
        Controls.Add(first_name)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Επαφές"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents first_name As TextBox
    Friend WithEvents last_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents phone_number As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents save_contact_btn As Button
    Friend WithEvents contacts_list As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents update_contact_btn As Button

End Class
