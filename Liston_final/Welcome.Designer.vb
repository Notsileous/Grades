<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblBegin = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStudent
        '
        Me.txtStudent.Location = New System.Drawing.Point(79, 76)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(155, 20)
        Me.txtStudent.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(3, 25)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(313, 13)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to the Coal Hill Secondary School grading system"
        '
        'lblBegin
        '
        Me.lblBegin.AutoSize = True
        Me.lblBegin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBegin.ForeColor = System.Drawing.Color.White
        Me.lblBegin.Location = New System.Drawing.Point(43, 47)
        Me.lblBegin.Name = "lblBegin"
        Me.lblBegin.Size = New System.Drawing.Size(232, 15)
        Me.lblBegin.TabIndex = 2
        Me.lblBegin.Text = "Please enter the students name to begin"
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(119, 111)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(75, 23)
        Me.btnBegin.TabIndex = 3
        Me.btnBegin.Text = "&Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmWelcome
        '
        Me.AcceptButton = Me.btnBegin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 239)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblBegin)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.txtStudent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coal Hill Secondary School"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStudent As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblBegin As Label
    Friend WithEvents btnBegin As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
