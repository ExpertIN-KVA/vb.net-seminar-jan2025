<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comparisonIf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        number1_text = New TextBox()
        Label2 = New Label()
        number2_text = New TextBox()
        Label3 = New Label()
        operatorCombo = New ComboBox()
        resultLabel = New Label()
        calculateButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 55)
        Label1.TabIndex = 1
        Label1.Text = "Σύνθετες συγκρίσεις"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' number1_text
        ' 
        number1_text.Location = New Point(123, 89)
        number1_text.Name = "number1_text"
        number1_text.Size = New Size(100, 23)
        number1_text.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 3
        Label2.Text = "Αριθμός 1"
        ' 
        ' number2_text
        ' 
        number2_text.Location = New Point(123, 201)
        number2_text.Name = "number2_text"
        number2_text.Size = New Size(100, 23)
        number2_text.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 5
        Label3.Text = "Αριθμός 2"
        ' 
        ' operatorCombo
        ' 
        operatorCombo.FormattingEnabled = True
        operatorCombo.Items.AddRange(New Object() {"=", "<>", ">", "<", ">=", "<="})
        operatorCombo.Location = New Point(56, 148)
        operatorCombo.Name = "operatorCombo"
        operatorCombo.Size = New Size(167, 23)
        operatorCombo.TabIndex = 7
        ' 
        ' resultLabel
        ' 
        resultLabel.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        resultLabel.Location = New Point(12, 302)
        resultLabel.Name = "resultLabel"
        resultLabel.Size = New Size(279, 139)
        resultLabel.TabIndex = 8
        resultLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' calculateButton
        ' 
        calculateButton.Location = New Point(94, 276)
        calculateButton.Name = "calculateButton"
        calculateButton.Size = New Size(100, 23)
        calculateButton.TabIndex = 9
        calculateButton.Text = "Υπολογισμός"
        calculateButton.UseVisualStyleBackColor = True
        ' 
        ' comparisonIf
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(303, 450)
        Controls.Add(calculateButton)
        Controls.Add(resultLabel)
        Controls.Add(operatorCombo)
        Controls.Add(number2_text)
        Controls.Add(Label3)
        Controls.Add(number1_text)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "comparisonIf"
        Text = "Πολλαπλές συγκρίσεις"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents number1_text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents number2_text As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents operatorCombo As ComboBox
    Friend WithEvents resultLabel As Label
    Friend WithEvents calculateButton As Button
End Class
