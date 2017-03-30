<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrade
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrade))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.lblSectionForum = New System.Windows.Forms.Label()
        Me.lblForumWeight = New System.Windows.Forms.Label()
        Me.lblAssignmentWeight = New System.Windows.Forms.Label()
        Me.lblSectionAssignment = New System.Windows.Forms.Label()
        Me.lblForum1 = New System.Windows.Forms.Label()
        Me.lblPointsForum = New System.Windows.Forms.Label()
        Me.txtForum1 = New System.Windows.Forms.TextBox()
        Me.txtForum2 = New System.Windows.Forms.TextBox()
        Me.txtForum3 = New System.Windows.Forms.TextBox()
        Me.txtForum4 = New System.Windows.Forms.TextBox()
        Me.txtForum5 = New System.Windows.Forms.TextBox()
        Me.txtForum6 = New System.Windows.Forms.TextBox()
        Me.txtForum7 = New System.Windows.Forms.TextBox()
        Me.txtForum8 = New System.Windows.Forms.TextBox()
        Me.lblForum2 = New System.Windows.Forms.Label()
        Me.lblForum3 = New System.Windows.Forms.Label()
        Me.lblForum4 = New System.Windows.Forms.Label()
        Me.lblForum5 = New System.Windows.Forms.Label()
        Me.lblForum6 = New System.Windows.Forms.Label()
        Me.lblForum7 = New System.Windows.Forms.Label()
        Me.lblForum8 = New System.Windows.Forms.Label()
        Me.lblPointsAssignment = New System.Windows.Forms.Label()
        Me.lblAssignment8 = New System.Windows.Forms.Label()
        Me.lblAssignment7 = New System.Windows.Forms.Label()
        Me.lblAssignment6 = New System.Windows.Forms.Label()
        Me.lblAssignment5 = New System.Windows.Forms.Label()
        Me.lblAssignment4 = New System.Windows.Forms.Label()
        Me.lblAssignment3 = New System.Windows.Forms.Label()
        Me.lblAssignment2 = New System.Windows.Forms.Label()
        Me.txtAssignment8 = New System.Windows.Forms.TextBox()
        Me.txtAssignment7 = New System.Windows.Forms.TextBox()
        Me.txtAssignment6 = New System.Windows.Forms.TextBox()
        Me.txtAssignment5 = New System.Windows.Forms.TextBox()
        Me.txtAssignment4 = New System.Windows.Forms.TextBox()
        Me.txtAssignment3 = New System.Windows.Forms.TextBox()
        Me.txtAssignment2 = New System.Windows.Forms.TextBox()
        Me.txtAssignment1 = New System.Windows.Forms.TextBox()
        Me.lblAssignment1 = New System.Windows.Forms.Label()
        Me.btnFinals = New System.Windows.Forms.Button()
        Me.lblFinals = New System.Windows.Forms.Label()
        Me.txtFinals = New System.Windows.Forms.TextBox()
        Me.grpForums = New System.Windows.Forms.GroupBox()
        Me.grpAssignment = New System.Windows.Forms.GroupBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.lblFinalGrade = New System.Windows.Forms.Label()
        Me.txtFinalLetterGrade = New System.Windows.Forms.TextBox()
        Me.btnStartOver = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picPencil = New System.Windows.Forms.PictureBox()
        Me.lblForumPercent = New System.Windows.Forms.Label()
        Me.lblFinalPercent = New System.Windows.Forms.Label()
        Me.txtFinalsPercent = New System.Windows.Forms.TextBox()
        Me.txtForumPercent = New System.Windows.Forms.TextBox()
        Me.txtAssignmentPercent = New System.Windows.Forms.TextBox()
        Me.lblAssignmentPercent = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpForums.SuspendLayout()
        Me.grpAssignment.SuspendLayout()
        CType(Me.picPencil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(137, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(123, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "No Student Selected"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(12, 50)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(128, 15)
        Me.lblSummary.TabIndex = 1
        Me.lblSummary.Text = "Grading summary for "
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(410, 6)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(131, 59)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Location = New System.Drawing.Point(12, 15)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(261, 15)
        Me.lblSchoolName.TabIndex = 0
        Me.lblSchoolName.Text = "Coal Hill Secondary School System Gradebook"
        '
        'lblSectionForum
        '
        Me.lblSectionForum.AutoSize = True
        Me.lblSectionForum.Location = New System.Drawing.Point(9, 39)
        Me.lblSectionForum.Name = "lblSectionForum"
        Me.lblSectionForum.Size = New System.Drawing.Size(43, 15)
        Me.lblSectionForum.TabIndex = 1
        Me.lblSectionForum.Text = "Forum"
        '
        'lblForumWeight
        '
        Me.lblForumWeight.AutoSize = True
        Me.lblForumWeight.Location = New System.Drawing.Point(9, 15)
        Me.lblForumWeight.Name = "lblForumWeight"
        Me.lblForumWeight.Size = New System.Drawing.Size(229, 15)
        Me.lblForumWeight.TabIndex = 0
        Me.lblForumWeight.Text = "Forums count for 30% of the final grade"
        '
        'lblAssignmentWeight
        '
        Me.lblAssignmentWeight.AutoSize = True
        Me.lblAssignmentWeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignmentWeight.Location = New System.Drawing.Point(6, 15)
        Me.lblAssignmentWeight.Name = "lblAssignmentWeight"
        Me.lblAssignmentWeight.Size = New System.Drawing.Size(243, 13)
        Me.lblAssignmentWeight.TabIndex = 0
        Me.lblAssignmentWeight.Text = "Assignments count for 45% of the final grade"
        '
        'lblSectionAssignment
        '
        Me.lblSectionAssignment.AutoSize = True
        Me.lblSectionAssignment.Location = New System.Drawing.Point(17, 38)
        Me.lblSectionAssignment.Name = "lblSectionAssignment"
        Me.lblSectionAssignment.Size = New System.Drawing.Size(77, 15)
        Me.lblSectionAssignment.TabIndex = 1
        Me.lblSectionAssignment.Text = "Assignments"
        '
        'lblForum1
        '
        Me.lblForum1.AutoSize = True
        Me.lblForum1.Location = New System.Drawing.Point(9, 75)
        Me.lblForum1.Name = "lblForum1"
        Me.lblForum1.Size = New System.Drawing.Size(50, 15)
        Me.lblForum1.TabIndex = 2
        Me.lblForum1.Text = "Week 1"
        '
        'lblPointsForum
        '
        Me.lblPointsForum.AutoSize = True
        Me.lblPointsForum.Location = New System.Drawing.Point(120, 38)
        Me.lblPointsForum.Name = "lblPointsForum"
        Me.lblPointsForum.Size = New System.Drawing.Size(102, 15)
        Me.lblPointsForum.TabIndex = 10
        Me.lblPointsForum.Text = "Points out of 100"
        '
        'txtForum1
        '
        Me.txtForum1.Location = New System.Drawing.Point(122, 67)
        Me.txtForum1.MaxLength = 3
        Me.txtForum1.Name = "txtForum1"
        Me.txtForum1.Size = New System.Drawing.Size(100, 23)
        Me.txtForum1.TabIndex = 11
        '
        'txtForum2
        '
        Me.txtForum2.Location = New System.Drawing.Point(122, 105)
        Me.txtForum2.MaxLength = 3
        Me.txtForum2.Name = "txtForum2"
        Me.txtForum2.Size = New System.Drawing.Size(100, 23)
        Me.txtForum2.TabIndex = 12
        '
        'txtForum3
        '
        Me.txtForum3.Location = New System.Drawing.Point(122, 143)
        Me.txtForum3.MaxLength = 3
        Me.txtForum3.Name = "txtForum3"
        Me.txtForum3.Size = New System.Drawing.Size(100, 23)
        Me.txtForum3.TabIndex = 13
        '
        'txtForum4
        '
        Me.txtForum4.Location = New System.Drawing.Point(122, 181)
        Me.txtForum4.MaxLength = 3
        Me.txtForum4.Name = "txtForum4"
        Me.txtForum4.Size = New System.Drawing.Size(100, 23)
        Me.txtForum4.TabIndex = 14
        '
        'txtForum5
        '
        Me.txtForum5.Location = New System.Drawing.Point(122, 219)
        Me.txtForum5.MaxLength = 3
        Me.txtForum5.Name = "txtForum5"
        Me.txtForum5.Size = New System.Drawing.Size(100, 23)
        Me.txtForum5.TabIndex = 15
        '
        'txtForum6
        '
        Me.txtForum6.Location = New System.Drawing.Point(122, 257)
        Me.txtForum6.MaxLength = 3
        Me.txtForum6.Name = "txtForum6"
        Me.txtForum6.Size = New System.Drawing.Size(100, 23)
        Me.txtForum6.TabIndex = 16
        '
        'txtForum7
        '
        Me.txtForum7.Location = New System.Drawing.Point(122, 295)
        Me.txtForum7.MaxLength = 3
        Me.txtForum7.Name = "txtForum7"
        Me.txtForum7.Size = New System.Drawing.Size(100, 23)
        Me.txtForum7.TabIndex = 17
        '
        'txtForum8
        '
        Me.txtForum8.Location = New System.Drawing.Point(122, 333)
        Me.txtForum8.MaxLength = 3
        Me.txtForum8.Name = "txtForum8"
        Me.txtForum8.Size = New System.Drawing.Size(100, 23)
        Me.txtForum8.TabIndex = 18
        '
        'lblForum2
        '
        Me.lblForum2.AutoSize = True
        Me.lblForum2.Location = New System.Drawing.Point(9, 113)
        Me.lblForum2.Name = "lblForum2"
        Me.lblForum2.Size = New System.Drawing.Size(50, 15)
        Me.lblForum2.TabIndex = 3
        Me.lblForum2.Text = "Week 2"
        '
        'lblForum3
        '
        Me.lblForum3.AutoSize = True
        Me.lblForum3.Location = New System.Drawing.Point(9, 151)
        Me.lblForum3.Name = "lblForum3"
        Me.lblForum3.Size = New System.Drawing.Size(50, 15)
        Me.lblForum3.TabIndex = 4
        Me.lblForum3.Text = "Week 3"
        '
        'lblForum4
        '
        Me.lblForum4.AutoSize = True
        Me.lblForum4.Location = New System.Drawing.Point(9, 189)
        Me.lblForum4.Name = "lblForum4"
        Me.lblForum4.Size = New System.Drawing.Size(50, 15)
        Me.lblForum4.TabIndex = 5
        Me.lblForum4.Text = "Week 4"
        '
        'lblForum5
        '
        Me.lblForum5.AutoSize = True
        Me.lblForum5.Location = New System.Drawing.Point(9, 227)
        Me.lblForum5.Name = "lblForum5"
        Me.lblForum5.Size = New System.Drawing.Size(50, 15)
        Me.lblForum5.TabIndex = 6
        Me.lblForum5.Text = "Week 5"
        '
        'lblForum6
        '
        Me.lblForum6.AutoSize = True
        Me.lblForum6.Location = New System.Drawing.Point(9, 265)
        Me.lblForum6.Name = "lblForum6"
        Me.lblForum6.Size = New System.Drawing.Size(50, 15)
        Me.lblForum6.TabIndex = 7
        Me.lblForum6.Text = "Week 6"
        '
        'lblForum7
        '
        Me.lblForum7.AutoSize = True
        Me.lblForum7.Location = New System.Drawing.Point(9, 303)
        Me.lblForum7.Name = "lblForum7"
        Me.lblForum7.Size = New System.Drawing.Size(50, 15)
        Me.lblForum7.TabIndex = 8
        Me.lblForum7.Text = "Week 7"
        '
        'lblForum8
        '
        Me.lblForum8.AutoSize = True
        Me.lblForum8.Location = New System.Drawing.Point(9, 341)
        Me.lblForum8.Name = "lblForum8"
        Me.lblForum8.Size = New System.Drawing.Size(50, 15)
        Me.lblForum8.TabIndex = 9
        Me.lblForum8.Text = "Week 8"
        '
        'lblPointsAssignment
        '
        Me.lblPointsAssignment.AutoSize = True
        Me.lblPointsAssignment.Location = New System.Drawing.Point(133, 39)
        Me.lblPointsAssignment.Name = "lblPointsAssignment"
        Me.lblPointsAssignment.Size = New System.Drawing.Size(102, 15)
        Me.lblPointsAssignment.TabIndex = 10
        Me.lblPointsAssignment.Text = "Points out of 100"
        '
        'lblAssignment8
        '
        Me.lblAssignment8.AutoSize = True
        Me.lblAssignment8.Location = New System.Drawing.Point(17, 334)
        Me.lblAssignment8.Name = "lblAssignment8"
        Me.lblAssignment8.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment8.TabIndex = 9
        Me.lblAssignment8.Text = "Week 8"
        '
        'lblAssignment7
        '
        Me.lblAssignment7.AutoSize = True
        Me.lblAssignment7.Location = New System.Drawing.Point(17, 296)
        Me.lblAssignment7.Name = "lblAssignment7"
        Me.lblAssignment7.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment7.TabIndex = 8
        Me.lblAssignment7.Text = "Week 7"
        '
        'lblAssignment6
        '
        Me.lblAssignment6.AutoSize = True
        Me.lblAssignment6.Location = New System.Drawing.Point(17, 254)
        Me.lblAssignment6.Name = "lblAssignment6"
        Me.lblAssignment6.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment6.TabIndex = 7
        Me.lblAssignment6.Text = "Week 6"
        '
        'lblAssignment5
        '
        Me.lblAssignment5.AutoSize = True
        Me.lblAssignment5.Location = New System.Drawing.Point(17, 216)
        Me.lblAssignment5.Name = "lblAssignment5"
        Me.lblAssignment5.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment5.TabIndex = 6
        Me.lblAssignment5.Text = "Week 5"
        '
        'lblAssignment4
        '
        Me.lblAssignment4.AutoSize = True
        Me.lblAssignment4.Location = New System.Drawing.Point(17, 178)
        Me.lblAssignment4.Name = "lblAssignment4"
        Me.lblAssignment4.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment4.TabIndex = 5
        Me.lblAssignment4.Text = "Week 4"
        '
        'lblAssignment3
        '
        Me.lblAssignment3.AutoSize = True
        Me.lblAssignment3.Location = New System.Drawing.Point(17, 140)
        Me.lblAssignment3.Name = "lblAssignment3"
        Me.lblAssignment3.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment3.TabIndex = 4
        Me.lblAssignment3.Text = "Week 3"
        '
        'lblAssignment2
        '
        Me.lblAssignment2.AutoSize = True
        Me.lblAssignment2.Location = New System.Drawing.Point(17, 102)
        Me.lblAssignment2.Name = "lblAssignment2"
        Me.lblAssignment2.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment2.TabIndex = 3
        Me.lblAssignment2.Text = "Week 2"
        '
        'txtAssignment8
        '
        Me.txtAssignment8.Location = New System.Drawing.Point(130, 330)
        Me.txtAssignment8.MaxLength = 3
        Me.txtAssignment8.Name = "txtAssignment8"
        Me.txtAssignment8.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment8.TabIndex = 18
        '
        'txtAssignment7
        '
        Me.txtAssignment7.Location = New System.Drawing.Point(130, 293)
        Me.txtAssignment7.MaxLength = 3
        Me.txtAssignment7.Name = "txtAssignment7"
        Me.txtAssignment7.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment7.TabIndex = 17
        '
        'txtAssignment6
        '
        Me.txtAssignment6.Location = New System.Drawing.Point(130, 251)
        Me.txtAssignment6.MaxLength = 3
        Me.txtAssignment6.Name = "txtAssignment6"
        Me.txtAssignment6.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment6.TabIndex = 16
        '
        'txtAssignment5
        '
        Me.txtAssignment5.Location = New System.Drawing.Point(130, 212)
        Me.txtAssignment5.MaxLength = 3
        Me.txtAssignment5.Name = "txtAssignment5"
        Me.txtAssignment5.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment5.TabIndex = 15
        '
        'txtAssignment4
        '
        Me.txtAssignment4.Location = New System.Drawing.Point(130, 174)
        Me.txtAssignment4.MaxLength = 3
        Me.txtAssignment4.Name = "txtAssignment4"
        Me.txtAssignment4.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment4.TabIndex = 14
        '
        'txtAssignment3
        '
        Me.txtAssignment3.Location = New System.Drawing.Point(130, 136)
        Me.txtAssignment3.MaxLength = 3
        Me.txtAssignment3.Name = "txtAssignment3"
        Me.txtAssignment3.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment3.TabIndex = 13
        '
        'txtAssignment2
        '
        Me.txtAssignment2.Location = New System.Drawing.Point(130, 100)
        Me.txtAssignment2.MaxLength = 3
        Me.txtAssignment2.Name = "txtAssignment2"
        Me.txtAssignment2.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment2.TabIndex = 12
        '
        'txtAssignment1
        '
        Me.txtAssignment1.Location = New System.Drawing.Point(130, 65)
        Me.txtAssignment1.MaxLength = 3
        Me.txtAssignment1.Name = "txtAssignment1"
        Me.txtAssignment1.Size = New System.Drawing.Size(100, 23)
        Me.txtAssignment1.TabIndex = 11
        '
        'lblAssignment1
        '
        Me.lblAssignment1.AutoSize = True
        Me.lblAssignment1.Location = New System.Drawing.Point(17, 68)
        Me.lblAssignment1.Name = "lblAssignment1"
        Me.lblAssignment1.Size = New System.Drawing.Size(50, 15)
        Me.lblAssignment1.TabIndex = 2
        Me.lblAssignment1.Text = "Week 1"
        '
        'btnFinals
        '
        Me.btnFinals.ForeColor = System.Drawing.Color.Black
        Me.btnFinals.Location = New System.Drawing.Point(10, 486)
        Me.btnFinals.Name = "btnFinals"
        Me.btnFinals.Size = New System.Drawing.Size(162, 23)
        Me.btnFinals.TabIndex = 5
        Me.btnFinals.Text = "Click to &Add Final Project"
        Me.btnFinals.UseVisualStyleBackColor = True
        '
        'lblFinals
        '
        Me.lblFinals.AutoSize = True
        Me.lblFinals.Location = New System.Drawing.Point(183, 493)
        Me.lblFinals.Name = "lblFinals"
        Me.lblFinals.Size = New System.Drawing.Size(77, 15)
        Me.lblFinals.TabIndex = 11
        Me.lblFinals.Text = "Finals points:"
        '
        'txtFinals
        '
        Me.txtFinals.Enabled = False
        Me.txtFinals.Location = New System.Drawing.Point(272, 485)
        Me.txtFinals.Name = "txtFinals"
        Me.txtFinals.Size = New System.Drawing.Size(64, 23)
        Me.txtFinals.TabIndex = 12
        Me.txtFinals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpForums
        '
        Me.grpForums.Controls.Add(Me.lblForum8)
        Me.grpForums.Controls.Add(Me.lblForum7)
        Me.grpForums.Controls.Add(Me.lblForum6)
        Me.grpForums.Controls.Add(Me.lblForum5)
        Me.grpForums.Controls.Add(Me.lblForum4)
        Me.grpForums.Controls.Add(Me.lblForum3)
        Me.grpForums.Controls.Add(Me.lblForum2)
        Me.grpForums.Controls.Add(Me.txtForum8)
        Me.grpForums.Controls.Add(Me.txtForum7)
        Me.grpForums.Controls.Add(Me.txtForum6)
        Me.grpForums.Controls.Add(Me.txtForum5)
        Me.grpForums.Controls.Add(Me.txtForum4)
        Me.grpForums.Controls.Add(Me.txtForum3)
        Me.grpForums.Controls.Add(Me.txtForum2)
        Me.grpForums.Controls.Add(Me.txtForum1)
        Me.grpForums.Controls.Add(Me.lblPointsForum)
        Me.grpForums.Controls.Add(Me.lblForum1)
        Me.grpForums.Controls.Add(Me.lblForumWeight)
        Me.grpForums.Controls.Add(Me.lblSectionForum)
        Me.grpForums.Location = New System.Drawing.Point(9, 93)
        Me.grpForums.Name = "grpForums"
        Me.grpForums.Size = New System.Drawing.Size(241, 380)
        Me.grpForums.TabIndex = 3
        Me.grpForums.TabStop = False
        '
        'grpAssignment
        '
        Me.grpAssignment.Controls.Add(Me.lblAssignment6)
        Me.grpAssignment.Controls.Add(Me.lblAssignment5)
        Me.grpAssignment.Controls.Add(Me.lblAssignment4)
        Me.grpAssignment.Controls.Add(Me.lblAssignment3)
        Me.grpAssignment.Controls.Add(Me.lblAssignment2)
        Me.grpAssignment.Controls.Add(Me.lblAssignment7)
        Me.grpAssignment.Controls.Add(Me.txtAssignment7)
        Me.grpAssignment.Controls.Add(Me.txtAssignment6)
        Me.grpAssignment.Controls.Add(Me.lblAssignment8)
        Me.grpAssignment.Controls.Add(Me.txtAssignment5)
        Me.grpAssignment.Controls.Add(Me.txtAssignment8)
        Me.grpAssignment.Controls.Add(Me.txtAssignment4)
        Me.grpAssignment.Controls.Add(Me.txtAssignment3)
        Me.grpAssignment.Controls.Add(Me.txtAssignment2)
        Me.grpAssignment.Controls.Add(Me.txtAssignment1)
        Me.grpAssignment.Controls.Add(Me.lblAssignment1)
        Me.grpAssignment.Controls.Add(Me.lblPointsAssignment)
        Me.grpAssignment.Controls.Add(Me.lblAssignmentWeight)
        Me.grpAssignment.Controls.Add(Me.lblSectionAssignment)
        Me.grpAssignment.Location = New System.Drawing.Point(287, 93)
        Me.grpAssignment.Name = "grpAssignment"
        Me.grpAssignment.Size = New System.Drawing.Size(254, 380)
        Me.grpAssignment.TabIndex = 4
        Me.grpAssignment.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(10, 515)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(105, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate Grade"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(161, 587)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(105, 15)
        Me.lblPercent.TabIndex = 19
        Me.lblPercent.Text = "Total Percentage:"
        '
        'txtPercent
        '
        Me.txtPercent.Enabled = False
        Me.txtPercent.Location = New System.Drawing.Point(272, 579)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(64, 23)
        Me.txtPercent.TabIndex = 20
        Me.txtPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFinalGrade
        '
        Me.lblFinalGrade.AutoSize = True
        Me.lblFinalGrade.Location = New System.Drawing.Point(407, 587)
        Me.lblFinalGrade.Name = "lblFinalGrade"
        Me.lblFinalGrade.Size = New System.Drawing.Size(70, 15)
        Me.lblFinalGrade.TabIndex = 21
        Me.lblFinalGrade.Text = "Final grade:"
        '
        'txtFinalLetterGrade
        '
        Me.txtFinalLetterGrade.Enabled = False
        Me.txtFinalLetterGrade.Location = New System.Drawing.Point(484, 579)
        Me.txtFinalLetterGrade.Name = "txtFinalLetterGrade"
        Me.txtFinalLetterGrade.Size = New System.Drawing.Size(64, 23)
        Me.txtFinalLetterGrade.TabIndex = 22
        Me.txtFinalLetterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStartOver
        '
        Me.btnStartOver.ForeColor = System.Drawing.Color.Black
        Me.btnStartOver.Location = New System.Drawing.Point(10, 603)
        Me.btnStartOver.Name = "btnStartOver"
        Me.btnStartOver.Size = New System.Drawing.Size(87, 23)
        Me.btnStartOver.TabIndex = 9
        Me.btnStartOver.Text = "&Start over"
        Me.btnStartOver.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(10, 632)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picPencil
        '
        Me.picPencil.Image = CType(resources.GetObject("picPencil.Image"), System.Drawing.Image)
        Me.picPencil.Location = New System.Drawing.Point(136, 625)
        Me.picPencil.Name = "picPencil"
        Me.picPencil.Size = New System.Drawing.Size(381, 37)
        Me.picPencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPencil.TabIndex = 55
        Me.picPencil.TabStop = False
        '
        'lblForumPercent
        '
        Me.lblForumPercent.AutoSize = True
        Me.lblForumPercent.Location = New System.Drawing.Point(155, 537)
        Me.lblForumPercent.Name = "lblForumPercent"
        Me.lblForumPercent.Size = New System.Drawing.Size(113, 15)
        Me.lblForumPercent.TabIndex = 15
        Me.lblForumPercent.Text = "Forum Percentage:"
        '
        'lblFinalPercent
        '
        Me.lblFinalPercent.AutoSize = True
        Me.lblFinalPercent.Location = New System.Drawing.Point(375, 493)
        Me.lblFinalPercent.Name = "lblFinalPercent"
        Me.lblFinalPercent.Size = New System.Drawing.Size(107, 15)
        Me.lblFinalPercent.TabIndex = 13
        Me.lblFinalPercent.Text = "Finals Percentage:"
        '
        'txtFinalsPercent
        '
        Me.txtFinalsPercent.Enabled = False
        Me.txtFinalsPercent.Location = New System.Drawing.Point(484, 485)
        Me.txtFinalsPercent.Name = "txtFinalsPercent"
        Me.txtFinalsPercent.Size = New System.Drawing.Size(64, 23)
        Me.txtFinalsPercent.TabIndex = 14
        Me.txtFinalsPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtForumPercent
        '
        Me.txtForumPercent.Enabled = False
        Me.txtForumPercent.Location = New System.Drawing.Point(272, 530)
        Me.txtForumPercent.Name = "txtForumPercent"
        Me.txtForumPercent.Size = New System.Drawing.Size(64, 23)
        Me.txtForumPercent.TabIndex = 16
        Me.txtForumPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAssignmentPercent
        '
        Me.txtAssignmentPercent.Enabled = False
        Me.txtAssignmentPercent.Location = New System.Drawing.Point(484, 529)
        Me.txtAssignmentPercent.Name = "txtAssignmentPercent"
        Me.txtAssignmentPercent.Size = New System.Drawing.Size(64, 23)
        Me.txtAssignmentPercent.TabIndex = 18
        Me.txtAssignmentPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAssignmentPercent
        '
        Me.lblAssignmentPercent.AutoSize = True
        Me.lblAssignmentPercent.Location = New System.Drawing.Point(337, 538)
        Me.lblAssignmentPercent.Name = "lblAssignmentPercent"
        Me.lblAssignmentPercent.Size = New System.Drawing.Size(147, 15)
        Me.lblAssignmentPercent.TabIndex = 17
        Me.lblAssignmentPercent.Text = "Assignments Percentage:"
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(10, 574)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(10, 544)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmGrade
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(553, 667)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAssignmentPercent)
        Me.Controls.Add(Me.txtAssignmentPercent)
        Me.Controls.Add(Me.txtForumPercent)
        Me.Controls.Add(Me.txtFinalsPercent)
        Me.Controls.Add(Me.lblFinalPercent)
        Me.Controls.Add(Me.lblForumPercent)
        Me.Controls.Add(Me.picPencil)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStartOver)
        Me.Controls.Add(Me.txtFinalLetterGrade)
        Me.Controls.Add(Me.lblFinalGrade)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpAssignment)
        Me.Controls.Add(Me.grpForums)
        Me.Controls.Add(Me.txtFinals)
        Me.Controls.Add(Me.lblFinals)
        Me.Controls.Add(Me.btnFinals)
        Me.Controls.Add(Me.lblSchoolName)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(569, 705)
        Me.Name = "frmGrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coal Hill Secondary School"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpForums.ResumeLayout(False)
        Me.grpForums.PerformLayout()
        Me.grpAssignment.ResumeLayout(False)
        Me.grpAssignment.PerformLayout()
        CType(Me.picPencil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSchoolName As Label
    Friend WithEvents lblSectionForum As Label
    Friend WithEvents lblForumWeight As Label
    Friend WithEvents lblAssignmentWeight As Label
    Friend WithEvents lblSectionAssignment As Label
    Friend WithEvents lblForum1 As Label
    Friend WithEvents lblPointsForum As Label
    Friend WithEvents txtForum1 As TextBox
    Friend WithEvents txtForum2 As TextBox
    Friend WithEvents txtForum3 As TextBox
    Friend WithEvents txtForum4 As TextBox
    Friend WithEvents txtForum5 As TextBox
    Friend WithEvents txtForum6 As TextBox
    Friend WithEvents txtForum7 As TextBox
    Friend WithEvents txtForum8 As TextBox
    Friend WithEvents lblForum2 As Label
    Friend WithEvents lblForum3 As Label
    Friend WithEvents lblForum4 As Label
    Friend WithEvents lblForum5 As Label
    Friend WithEvents lblForum6 As Label
    Friend WithEvents lblForum7 As Label
    Friend WithEvents lblForum8 As Label
    Friend WithEvents lblPointsAssignment As Label
    Friend WithEvents lblAssignment8 As Label
    Friend WithEvents lblAssignment7 As Label
    Friend WithEvents lblAssignment6 As Label
    Friend WithEvents lblAssignment5 As Label
    Friend WithEvents lblAssignment4 As Label
    Friend WithEvents lblAssignment3 As Label
    Friend WithEvents lblAssignment2 As Label
    Friend WithEvents txtAssignment8 As TextBox
    Friend WithEvents txtAssignment7 As TextBox
    Friend WithEvents txtAssignment6 As TextBox
    Friend WithEvents txtAssignment5 As TextBox
    Friend WithEvents txtAssignment4 As TextBox
    Friend WithEvents txtAssignment3 As TextBox
    Friend WithEvents txtAssignment2 As TextBox
    Friend WithEvents txtAssignment1 As TextBox
    Friend WithEvents lblAssignment1 As Label
    Friend WithEvents btnFinals As Button
    Friend WithEvents lblFinals As Label
    Friend WithEvents txtFinals As TextBox
    Friend WithEvents grpForums As GroupBox
    Friend WithEvents grpAssignment As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblPercent As Label
    Friend WithEvents txtPercent As TextBox
    Friend WithEvents lblFinalGrade As Label
    Friend WithEvents txtFinalLetterGrade As TextBox
    Friend WithEvents btnStartOver As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picPencil As PictureBox
    Friend WithEvents lblForumPercent As Label
    Friend WithEvents lblFinalPercent As Label
    Friend WithEvents txtFinalsPercent As TextBox
    Friend WithEvents txtForumPercent As TextBox
    Friend WithEvents txtAssignmentPercent As TextBox
    Friend WithEvents lblAssignmentPercent As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
