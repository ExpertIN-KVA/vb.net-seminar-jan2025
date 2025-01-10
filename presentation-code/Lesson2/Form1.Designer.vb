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
        Label2 = New Label()
        number_text = New TextBox()
        calculateButton = New Button()
        result_label = New Label()
        openSecondForm = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 113)
        Label1.TabIndex = 0
        Label1.Text = "Πρόγραμμα που ελέγχει αν ένας αριθμός είναι μικρότερος ή μεγαλύτερος του 10"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 1
        Label2.Text = "Αριθμός"
        ' 
        ' number_text
        ' 
        number_text.Location = New Point(159, 125)
        number_text.Name = "number_text"
        number_text.Size = New Size(100, 23)
        number_text.TabIndex = 2
        ' 
        ' calculateButton
        ' 
        calculateButton.Location = New Point(265, 125)
        calculateButton.Name = "calculateButton"
        calculateButton.Size = New Size(100, 23)
        calculateButton.TabIndex = 3
        calculateButton.Text = "Υπολογισμός"
        calculateButton.UseVisualStyleBackColor = True
        ' 
        ' result_label
        ' 
        result_label.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        result_label.Location = New Point(12, 169)
        result_label.Name = "result_label"
        result_label.Size = New Size(476, 49)
        result_label.TabIndex = 4
        result_label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' openSecondForm
        ' 
        openSecondForm.Location = New Point(12, 9)
        openSecondForm.Name = "openSecondForm"
        openSecondForm.Size = New Size(169, 24)
        openSecondForm.TabIndex = 5
        openSecondForm.Text = "Άνοιγμα συνθετης φόρμας"
        openSecondForm.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 223)
        Controls.Add(openSecondForm)
        Controls.Add(result_label)
        Controls.Add(calculateButton)
        Controls.Add(number_text)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Simple if"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents number_text As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents result_label As Label
    Friend WithEvents openSecondForm As Button

End Class
