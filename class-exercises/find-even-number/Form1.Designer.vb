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
        number_text = New TextBox()
        Button1 = New Button()
        result_label = New Label()
        SuspendLayout()
        ' 
        ' number_text
        ' 
        number_text.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        number_text.Location = New Point(12, 12)
        number_text.Name = "number_text"
        number_text.PlaceholderText = "Ακέραιος αριθμός"
        number_text.Size = New Size(173, 33)
        number_text.TabIndex = 0
        number_text.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(191, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 33)
        Button1.TabIndex = 1
        Button1.Text = "Υπολογισμός"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' result_label
        ' 
        result_label.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        result_label.Location = New Point(12, 61)
        result_label.Name = "result_label"
        result_label.Size = New Size(323, 115)
        result_label.TabIndex = 2
        result_label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(348, 193)
        Controls.Add(result_label)
        Controls.Add(Button1)
        Controls.Add(number_text)
        Name = "Form1"
        Text = "Εύρεση τύπου αριθμού"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents number_text As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents result_label As Label

End Class
