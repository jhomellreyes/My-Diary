<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNewStory = New System.Windows.Forms.Button()
        Me.btnEditStory = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelStory = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(616, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNewStory
        '
        Me.btnNewStory.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNewStory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewStory.Font = New System.Drawing.Font("COCOMAT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewStory.ForeColor = System.Drawing.Color.White
        Me.btnNewStory.Location = New System.Drawing.Point(-2, 232)
        Me.btnNewStory.Name = "btnNewStory"
        Me.btnNewStory.Size = New System.Drawing.Size(217, 45)
        Me.btnNewStory.TabIndex = 1
        Me.btnNewStory.Text = "New Story"
        Me.btnNewStory.UseVisualStyleBackColor = False
        '
        'btnEditStory
        '
        Me.btnEditStory.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEditStory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditStory.Font = New System.Drawing.Font("COCOMAT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStory.ForeColor = System.Drawing.Color.White
        Me.btnEditStory.Location = New System.Drawing.Point(-2, 283)
        Me.btnEditStory.Name = "btnEditStory"
        Me.btnEditStory.Size = New System.Drawing.Size(217, 45)
        Me.btnEditStory.TabIndex = 2
        Me.btnEditStory.Text = "Edit Story"
        Me.btnEditStory.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("COCOMAT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(-2, 390)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(217, 45)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(234, 81)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(360, 373)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "             Date"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "                       Story"
        Me.ColumnHeader2.Width = 205
        '
        'btnDelStory
        '
        Me.btnDelStory.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDelStory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelStory.Font = New System.Drawing.Font("COCOMAT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelStory.ForeColor = System.Drawing.Color.White
        Me.btnDelStory.Location = New System.Drawing.Point(-2, 337)
        Me.btnDelStory.Name = "btnDelStory"
        Me.btnDelStory.Size = New System.Drawing.Size(217, 45)
        Me.btnDelStory.TabIndex = 3
        Me.btnDelStory.Text = "Delete Story"
        Me.btnDelStory.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 467)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnDelStory)
        Me.Controls.Add(Me.btnEditStory)
        Me.Controls.Add(Me.btnNewStory)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNewStory As Button
    Friend WithEvents btnEditStory As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnDelStory As Button
End Class
