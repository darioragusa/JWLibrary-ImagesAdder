<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonRestoreAll = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ListBoxImg = New System.Windows.Forms.ListBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonRestoreAll
        '
        Me.ButtonRestoreAll.Location = New System.Drawing.Point(8, 251)
        Me.ButtonRestoreAll.Name = "ButtonRestoreAll"
        Me.ButtonRestoreAll.Size = New System.Drawing.Size(285, 23)
        Me.ButtonRestoreAll.TabIndex = 11
        Me.ButtonRestoreAll.Text = "Restore original publications"
        Me.ButtonRestoreAll.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Location = New System.Drawing.Point(242, 8)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(51, 23)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ListBoxImg
        '
        Me.ListBoxImg.FormattingEnabled = True
        Me.ListBoxImg.Location = New System.Drawing.Point(8, 38)
        Me.ListBoxImg.Name = "ListBoxImg"
        Me.ListBoxImg.Size = New System.Drawing.Size(285, 173)
        Me.ListBoxImg.TabIndex = 9
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Enabled = False
        Me.ButtonAdd.Location = New System.Drawing.Point(8, 221)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(285, 23)
        Me.ButtonAdd.TabIndex = 7
        Me.ButtonAdd.Text = "Add images"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(8, 8)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(228, 23)
        Me.ButtonSelect.TabIndex = 6
        Me.ButtonSelect.Text = "Select the images to add"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 283)
        Me.Controls.Add(Me.ButtonRestoreAll)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ListBoxImg)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JWLibrary-ImagesAdder"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonRestoreAll As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ListBoxImg As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSelect As System.Windows.Forms.Button

End Class
