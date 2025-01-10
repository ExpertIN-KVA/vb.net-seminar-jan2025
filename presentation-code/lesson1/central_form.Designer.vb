<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class central_form
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
        central_button = New Button()
        fullname_text = New TextBox()
        fullname_label = New Label()
        SuspendLayout()
        ' 
        ' central_button
        ' 
        central_button.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        central_button.Location = New Point(255, 103)
        central_button.Name = "central_button"
        central_button.Size = New Size(252, 113)
        central_button.TabIndex = 0
        central_button.Text = "Δώσε αποτέλεσμα"
        central_button.UseVisualStyleBackColor = True
        ' 
        ' fullname_text
        ' 
        fullname_text.Location = New Point(12, 154)
        fullname_text.Name = "fullname_text"
        fullname_text.PlaceholderText = "Όνομα"
        fullname_text.Size = New Size(212, 23)
        fullname_text.TabIndex = 1
        ' 
        ' fullname_label
        ' 
        fullname_label.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fullname_label.Location = New Point(513, 103)
        fullname_label.Name = "fullname_label"
        fullname_label.Size = New Size(238, 113)
        fullname_label.TabIndex = 2
        fullname_label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' central_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 308)
        Controls.Add(fullname_label)
        Controls.Add(fullname_text)
        Controls.Add(central_button)
        Name = "central_form"
        Text = "Lesson 1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents central_button As Button
    Friend WithEvents fullname_text As TextBox
    Friend WithEvents fullname_label As Label

End Class
