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
        ListBox = New ListBox()
        addItem = New Button()
        deleteItem = New Button()
        duplicateItem = New Button()
        SuspendLayout()
        ' 
        ' ListBox
        ' 
        ListBox.FormattingEnabled = True
        ListBox.ItemHeight = 15
        ListBox.Location = New Point(12, 12)
        ListBox.Name = "ListBox"
        ListBox.Size = New Size(217, 424)
        ListBox.TabIndex = 0
        ' 
        ' addItem
        ' 
        addItem.Location = New Point(235, 12)
        addItem.Name = "addItem"
        addItem.Size = New Size(186, 33)
        addItem.TabIndex = 1
        addItem.Text = "Προσθήκη αντικειμένου"
        addItem.UseVisualStyleBackColor = True
        ' 
        ' deleteItem
        ' 
        deleteItem.Location = New Point(235, 51)
        deleteItem.Name = "deleteItem"
        deleteItem.Size = New Size(186, 33)
        deleteItem.TabIndex = 2
        deleteItem.Text = "Διαγραφή αντικειμένου"
        deleteItem.UseVisualStyleBackColor = True
        ' 
        ' duplicateItem
        ' 
        duplicateItem.Location = New Point(235, 90)
        duplicateItem.Name = "duplicateItem"
        duplicateItem.Size = New Size(186, 33)
        duplicateItem.TabIndex = 3
        duplicateItem.Text = "Δημιουργία διπλότυπου"
        duplicateItem.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(433, 450)
        Controls.Add(duplicateItem)
        Controls.Add(deleteItem)
        Controls.Add(addItem)
        Controls.Add(ListBox)
        Name = "Form1"
        Text = "Διαχείριση ListBox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox As ListBox
    Friend WithEvents addItem As Button
    Friend WithEvents deleteItem As Button
    Friend WithEvents duplicateItem As Button

End Class
