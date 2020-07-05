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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonAdd_Menu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonRestoreAll
        '
        Me.ButtonRestoreAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRestoreAll.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonRestoreAll.FlatAppearance.BorderSize = 0
        Me.ButtonRestoreAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonRestoreAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonRestoreAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRestoreAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRestoreAll.ForeColor = System.Drawing.Color.Red
        Me.ButtonRestoreAll.Location = New System.Drawing.Point(40, 109)
        Me.ButtonRestoreAll.Name = "ButtonRestoreAll"
        Me.ButtonRestoreAll.Size = New System.Drawing.Size(240, 31)
        Me.ButtonRestoreAll.TabIndex = 11
        Me.ButtonRestoreAll.Text = "Restore original publications"
        Me.ButtonRestoreAll.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.Red
        Me.ButtonDelete.Location = New System.Drawing.Point(249, 3)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(68, 23)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ListBoxImg
        '
        Me.ListBoxImg.FormattingEnabled = True
        Me.ListBoxImg.Location = New System.Drawing.Point(3, 32)
        Me.ListBoxImg.Name = "ListBoxImg"
        Me.ListBoxImg.Size = New System.Drawing.Size(314, 95)
        Me.ListBoxImg.TabIndex = 9
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Enabled = False
        Me.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.Blue
        Me.ButtonAdd.Location = New System.Drawing.Point(294, 116)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(26, 47)
        Me.ButtonAdd.TabIndex = 7
        Me.ButtonAdd.Text = "→"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSelect
        '
        Me.ButtonSelect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonSelect.FlatAppearance.BorderSize = 0
        Me.ButtonSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.ButtonSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelect.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelect.ForeColor = System.Drawing.Color.Blue
        Me.ButtonSelect.Location = New System.Drawing.Point(3, 3)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(169, 23)
        Me.ButtonSelect.TabIndex = 6
        Me.ButtonSelect.Text = "Select the images to add"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonAdd_Menu)
        Me.Panel1.Controls.Add(Me.ButtonRestoreAll)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 156)
        Me.Panel1.TabIndex = 12
        '
        'ButtonAdd_Menu
        '
        Me.ButtonAdd_Menu.BackColor = System.Drawing.Color.White
        Me.ButtonAdd_Menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdd_Menu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonAdd_Menu.FlatAppearance.BorderSize = 0
        Me.ButtonAdd_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonAdd_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonAdd_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd_Menu.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd_Menu.ForeColor = System.Drawing.Color.Blue
        Me.ButtonAdd_Menu.Location = New System.Drawing.Point(40, 30)
        Me.ButtonAdd_Menu.Name = "ButtonAdd_Menu"
        Me.ButtonAdd_Menu.Size = New System.Drawing.Size(240, 61)
        Me.ButtonAdd_Menu.TabIndex = 12
        Me.ButtonAdd_Menu.Text = "Add images"
        Me.ButtonAdd_Menu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonSelect)
        Me.Panel2.Controls.Add(Me.ButtonDelete)
        Me.Panel2.Controls.Add(Me.ListBoxImg)
        Me.Panel2.Controls.Add(Me.ButtonAdd)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 159)
        Me.Panel2.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(344, 167)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JWLibrary-ImagesAdder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonRestoreAll As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ListBoxImg As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSelect As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonAdd_Menu As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
