<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnESave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Eddate = New System.Windows.Forms.Label()
        Me.txtStory = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(616, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnESave
        '
        Me.btnESave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnESave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnESave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnESave.Font = New System.Drawing.Font("COCOMAT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnESave.ForeColor = System.Drawing.Color.White
        Me.btnESave.Location = New System.Drawing.Point(-2, 275)
        Me.btnESave.Name = "btnESave"
        Me.btnESave.Size = New System.Drawing.Size(217, 45)
        Me.btnESave.TabIndex = 6
        Me.btnESave.Text = "Save"
        Me.btnESave.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("COCOMAT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(-2, 223)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(217, 45)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Eddate
        '
        Me.Eddate.AutoSize = True
        Me.Eddate.BackColor = System.Drawing.Color.Transparent
        Me.Eddate.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eddate.Location = New System.Drawing.Point(306, 72)
        Me.Eddate.Name = "Eddate"
        Me.Eddate.Size = New System.Drawing.Size(84, 33)
        Me.Eddate.TabIndex = 11
        Me.Eddate.Text = "Label1"
        '
        'txtStory
        '
        Me.txtStory.Location = New System.Drawing.Point(232, 108)
        Me.txtStory.Name = "txtStory"
        Me.txtStory.Size = New System.Drawing.Size(365, 339)
        Me.txtStory.TabIndex = 12
        Me.txtStory.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Day:"
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 467)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStory)
        Me.Controls.Add(Me.Eddate)
        Me.Controls.Add(Me.btnESave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnESave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Eddate As Label
    Friend WithEvents txtStory As RichTextBox
    Friend WithEvents Label1 As Label
End Class
