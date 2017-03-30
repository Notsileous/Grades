<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboScore = New System.Windows.Forms.ComboBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboScore
        '
        Me.cboScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboScore.FormattingEnabled = True
        Me.cboScore.Location = New System.Drawing.Point(185, 41)
        Me.cboScore.Name = "cboScore"
        Me.cboScore.Size = New System.Drawing.Size(121, 23)
        Me.cboScore.TabIndex = 2
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(76, 49)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(84, 15)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Select a score"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(12, 9)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(122, 25)
        Me.lblFinal.TabIndex = 0
        Me.lblFinal.Text = "Final Project"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(133, 83)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Worth 25% of final grade"
        '
        'frmFinals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 118)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.cboScore)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Project Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboScore As ComboBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
End Class
