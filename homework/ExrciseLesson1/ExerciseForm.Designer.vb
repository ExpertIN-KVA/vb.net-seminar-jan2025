<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExerciseForm
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
        number1_text = New TextBox()
        number2_text = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        calculation_result = New Label()
        trigger_calculation = New Button()
        SuspendLayout()
        ' 
        ' number1_text
        ' 
        number1_text.Location = New Point(12, 12)
        number1_text.Name = "number1_text"
        number1_text.PlaceholderText = "Number 1"
        number1_text.Size = New Size(125, 23)
        number1_text.TabIndex = 0
        number1_text.TextAlign = HorizontalAlignment.Center
        ' 
        ' number2_text
        ' 
        number2_text.Location = New Point(174, 12)
        number2_text.Name = "number2_text"
        number2_text.PlaceholderText = "Number 2"
        number2_text.Size = New Size(125, 23)
        number2_text.TabIndex = 1
        number2_text.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(143, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 25)
        Label1.TabIndex = 2
        Label1.Text = "+"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(305, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 25)
        Label2.TabIndex = 3
        Label2.Text = "="
        ' 
        ' calculation_result
        ' 
        calculation_result.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        calculation_result.Location = New Point(336, 12)
        calculation_result.Name = "calculation_result"
        calculation_result.Size = New Size(109, 25)
        calculation_result.TabIndex = 4
        ' 
        ' trigger_calculation
        ' 
        trigger_calculation.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        trigger_calculation.Location = New Point(336, 40)
        trigger_calculation.Name = "trigger_calculation"
        trigger_calculation.Size = New Size(109, 37)
        trigger_calculation.TabIndex = 5
        trigger_calculation.Text = "Calculate"
        trigger_calculation.UseVisualStyleBackColor = True
        ' 
        ' ExerciseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 82)
        Controls.Add(trigger_calculation)
        Controls.Add(calculation_result)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(number2_text)
        Controls.Add(number1_text)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ExerciseForm"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents number1_text As TextBox
    Friend WithEvents number2_text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents calculation_result As Label
    Friend WithEvents trigger_calculation As Button

End Class
