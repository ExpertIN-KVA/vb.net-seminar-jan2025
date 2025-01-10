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
        Button1 = New Button()
        TextBox = New TextBox()
        ListBox = New ListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(277, 36)
        Button1.TabIndex = 0
        Button1.Text = "Προσθήκη αριθμών"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox
        ' 
        TextBox.Location = New Point(12, 12)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(277, 23)
        TextBox.TabIndex = 1
        ' 
        ' ListBox
        ' 
        ListBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox.FormattingEnabled = True
        ListBox.ItemHeight = 21
        ListBox.Location = New Point(12, 83)
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(277, 340)
        ListBox.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(301, 450)
        Controls.Add(ListBox)
        Controls.Add(TextBox)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Windows form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox As TextBox
    Friend WithEvents ListBox As ListBox

End Class
