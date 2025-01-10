<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class antigoni
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
        anastasia_btn = New Button()
        result_lbl = New Label()
        Label1 = New Label()
        dimitra_txtbox = New TextBox()
        SuspendLayout()
        ' 
        ' anastasia_btn
        ' 
        anastasia_btn.BackColor = Color.Red
        anastasia_btn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        anastasia_btn.Location = New Point(12, 133)
        anastasia_btn.Name = "anastasia_btn"
        anastasia_btn.Size = New Size(297, 122)
        anastasia_btn.TabIndex = 0
        anastasia_btn.Text = "Despoina"
        anastasia_btn.UseVisualStyleBackColor = False
        ' 
        ' result_lbl
        ' 
        result_lbl.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        result_lbl.Location = New Point(315, 133)
        result_lbl.Name = "result_lbl"
        result_lbl.Size = New Size(375, 122)
        result_lbl.TabIndex = 1
        result_lbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(356, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' dimitra_txtbox
        ' 
        dimitra_txtbox.Location = New Point(12, 12)
        dimitra_txtbox.Name = "dimitra_txtbox"
        dimitra_txtbox.ReadOnly = True
        dimitra_txtbox.Size = New Size(678, 23)
        dimitra_txtbox.TabIndex = 3
        ' 
        ' antigoni
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(702, 267)
        Controls.Add(dimitra_txtbox)
        Controls.Add(Label1)
        Controls.Add(result_lbl)
        Controls.Add(anastasia_btn)
        Name = "antigoni"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Valia"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents anastasia_btn As Button
    Friend WithEvents result_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dimitra_txtbox As TextBox

End Class
