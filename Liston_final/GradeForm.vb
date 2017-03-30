'Name: Coal Hill School grade calculator
'Purpose: Takes points entered by user and calculates and displays the average and final grade
'Programed by: Benjamin Liston on 12/11/2015
'this window loads in response the btnBegin click event from the welcome form
Public Class frmGrade
    'variable to hold student name from previous screen
    Private _strStudentName As String = frmWelcome.strStudentName
    'constant variable for the maximum points available for each section (forums and assignments)
    Const intPossiblePoints As Integer = 800
    'constant variables for section weight (what % of final grade it is)
    Const intAssignmentWeight As Integer = 45
    Const intForumWeight As Integer = 30
    Const intFinalsWeight As Integer = 25
    'auto implemented properties for final project function
    Public Property _intFinalsPoints As Integer = -1
    Public Property _decFinalsScore As Decimal

    Private Sub frmGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on form load close the previous form and show the student name in the designated label area
        frmWelcome.Close()
        lblName.Text = _strStudentName
    End Sub

    Private Function GetAssignmentGrade()
        'this function finds the total percentage of the forums section and returns it
        'variables to hold the values entered by the user.
        Dim intAssignmentGrade1 As Integer
        Dim intAssignmentGrade2 As Integer
        Dim intAssignmentGrade3 As Integer
        Dim intAssignmentGrade4 As Integer
        Dim intAssignmentGrade5 As Integer
        Dim intAssignmentGrade6 As Integer
        Dim intAssignmentGrade7 As Integer
        Dim intAssignmentGrade8 As Integer
        'Variable for total of all forum points
        Dim intTotalAssignmentPoints As Integer = 0
        'variable to hold the total %
        Dim decAssignmentPointsScore As Decimal = 0
        'variable to hold the total % of final grade
        Dim decAssignmentTotal As Decimal = 0
        'take the users input, tryparse to an integer and store in variables
        Integer.TryParse(txtAssignment1.Text, intAssignmentGrade1)
        Integer.TryParse(txtAssignment2.Text, intAssignmentGrade2)
        Integer.TryParse(txtAssignment3.Text, intAssignmentGrade3)
        Integer.TryParse(txtAssignment4.Text, intAssignmentGrade4)
        Integer.TryParse(txtAssignment5.Text, intAssignmentGrade5)
        Integer.TryParse(txtAssignment6.Text, intAssignmentGrade6)
        Integer.TryParse(txtAssignment7.Text, intAssignmentGrade7)
        Integer.TryParse(txtAssignment8.Text, intAssignmentGrade8)
        'check to make sure no fields are empty and numbers are less than 101
        If (txtAssignment1.Text <> "" AndAlso intAssignmentGrade1 <= 100) And (txtAssignment2.Text <> "" AndAlso intAssignmentGrade2 <= 100) And (txtAssignment3.Text <> "" AndAlso intAssignmentGrade3 <= 100) And (txtAssignment4.Text <> "" AndAlso intAssignmentGrade4 <= 100) And (txtAssignment5.Text <> "" AndAlso intAssignmentGrade5 <= 100) And (txtAssignment6.Text <> "" AndAlso intAssignmentGrade6 <= 100) And (txtAssignment7.Text <> "" AndAlso intAssignmentGrade7 <= 100) And (txtAssignment8.Text <> "" AndAlso intAssignmentGrade8 <= 100) Then
            'if fields are good add all 8 points variables and store in variable
            intTotalAssignmentPoints = intAssignmentGrade1 + intAssignmentGrade2 + intAssignmentGrade3 + intAssignmentGrade4 + intAssignmentGrade5 + intAssignmentGrade6 + intAssignmentGrade7 + intAssignmentGrade8
            'divide previous total by 800 (the value of the constant variable fore maximimum points) and assign to variable
            decAssignmentPointsScore = intTotalAssignmentPoints / intPossiblePoints
            'multiply the previous total by 45 (the value of the section weght variable) and assign to variable
            decAssignmentTotal = decAssignmentPointsScore * intAssignmentWeight
        Else
            'display error message if one or more fields are empty or contain a number higher than 100
            MessageBox.Show("Please enter a valid amount between 0 and 100 in all assignment boxes", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        'return the total of the section
        Return decAssignmentTotal

    End Function

    Private Function GetForumGrade()
        'this function finds the total grade of the assignment section and returns it

        'create variables to hold data entered by user
        Dim intForumGrade1 As Integer = 0
        Dim intForumGrade2 As Integer = 0
        Dim intForumGrade3 As Integer = 0
        Dim intForumGrade4 As Integer = 0
        Dim intForumGrade5 As Integer = 0
        Dim intForumGrade6 As Integer = 0
        Dim intForumGrade7 As Integer = 0
        Dim intForumGrade8 As Integer = 0
        'Variable for total of all forum points
        Dim intTotalForumPoints As Integer = 0
        'variable to hold the total %
        Dim decForumPointsScore As Decimal = 0
        'variable to hold the total % of final grade
        Dim decForumTotal As Decimal = 0

        'pull the user entered data from the text boxes and tryparse them into integers and store in variables
        Integer.TryParse(txtForum1.Text, intForumGrade1)
        Integer.TryParse(txtForum2.Text, intForumGrade2)
        Integer.TryParse(txtForum3.Text, intForumGrade3)
        Integer.TryParse(txtForum4.Text, intForumGrade4)
        Integer.TryParse(txtForum5.Text, intForumGrade5)
        Integer.TryParse(txtForum6.Text, intForumGrade6)
        Integer.TryParse(txtForum7.Text, intForumGrade7)
        Integer.TryParse(txtForum8.Text, intForumGrade8)
        'check to see if any textboxes are empty or contain a number higher than 100
        If (txtForum1.Text <> "" AndAlso intForumGrade1 <= 100) And (txtForum2.Text <> "" AndAlso intForumGrade2 <= 100) And (txtForum3.Text <> "" AndAlso intForumGrade3 <= 100) And (txtForum4.Text <> "" AndAlso intForumGrade4 <= 100) And (txtForum5.Text <> "" AndAlso intForumGrade5 <= 100) And (txtForum6.Text <> "" AndAlso intForumGrade6 <= 100) And (txtForum7.Text <> "" AndAlso intForumGrade7 <= 100) And (txtForum8.Text <> "" AndAlso intForumGrade8 <= 100) Then

            'if values are good, add the totals of the textbox values and store in variable
            intTotalForumPoints = intForumGrade1 + intForumGrade2 + intForumGrade3 + intForumGrade4 + intForumGrade5 + intForumGrade6 + intForumGrade7 + intForumGrade8
            'divide the previous total by the value of the maximum possible points variable
            decForumPointsScore = intTotalForumPoints / intPossiblePoints
            'multiply the previous total by the value of the section weight variable
            decForumTotal = decForumPointsScore * intForumWeight
        Else
            'show warning message if any fields are invalid
            MessageBox.Show("Please enter a valid amount between 0 and 100 in all forum boxes", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        'return the section total
        Return decForumTotal
    End Function
    Private Function GetFinalsScore()
        'constant for section weight

        'constant for amount of highest possible points
        Const intFinalsPossiblePoints = 100
        'create variable to hold the total percentage
        Dim decFinalsPointsScore As Decimal = 0
        'create variable to hold the total percentage of the section
        Dim decFinalsTotal As Decimal = 0

        'find the total percentage
        decFinalsPointsScore = _intFinalsPoints / intFinalsPossiblePoints
        'find the total percentage of the section
        decFinalsTotal = decFinalsPointsScore * intFinalsWeight

        'return the final percentage of the section
        Return decFinalsTotal
    End Function

    Private Sub GetLetterGrade(decFinalPercentGrade As Decimal)
        'create new 2 dimensional array to hold minimum scores and letter grades
        Dim strGrades(,) As String = {{"93", "A"}, {"90", "A-"}, {"88", "B+"}, {"83", "B"}, {"80", "B-"}, {"78", "C+"}, {"73", "C"}, {"70", "C-"}, {"68", "D+"}, {"63", "D"}, {"60", "D-"}, {"0", "F"}}
        'create variable to hold the value of the incomming number grade
        Dim decSearchFor As Decimal = decFinalPercentGrade * 100
        'create variable to hold the letter grade once found
        Dim strGrade As String = "No Grade"
        'create variable to hold the row number of the array
        Dim intRow As Integer = 0
        'create variable to hold the points from the array after being converted from a string to an decimal
        Dim decTempPoints As Decimal = 0

        For intNum As Integer = 0 To 11
            Decimal.TryParse(strGrades(intRow, 0), decTempPoints)
            'compare to value entered by user
            If decTempPoints <= decSearchFor Then
                'if less than or equal to value, assign the grade letter found in the same row, colum 1
                strGrade = strGrades(intRow, 1)
                'display letter grade in text box
                txtFinalLetterGrade.Text = strGrade
                'if no match, increment the array row by 1
            Else intRow += 1
            End If
            'loop again
        Next intNum
    End Sub

    Private Sub AllFormKeypress(sender As Object, e As KeyPressEventArgs) Handles txtForum1.KeyPress, txtForum2.KeyPress, txtForum3.KeyPress, txtForum4.KeyPress, txtForum5.KeyPress, txtForum6.KeyPress, txtForum7.KeyPress, txtForum8.KeyPress, txtAssignment1.KeyPress, txtAssignment2.KeyPress, txtAssignment3.KeyPress, txtAssignment4.KeyPress, txtAssignment5.KeyPress, txtAssignment6.KeyPress, txtAssignment7.KeyPress, txtAssignment8.KeyPress
        'forces all user editable text boxes to accept only numbers and the backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculation button gets and displays all scores
        'check to make sure there is a valid number value in the finals section
        If _intFinalsPoints >= 0 AndAlso _intFinalsPoints <= 100 Then
            'create variabls to hold scores to be displayed
            Dim decForumScore As Decimal = 0
            Dim decAssignmentScore As Decimal = 0
            Dim decTotalPercentage As Decimal = 0
            'variables to show scores
            Dim decAssignmentScoreShow As Decimal
            Dim decForumScoreShow As Decimal

            'call the function, divide the returned value by 100 (to display properly as a percentage) and assign to variable
            decForumScore = GetForumGrade() / 100
            decForumScoreShow = (decForumScore / intForumWeight) * 100
            'Take the previous value  and reverse calculations to get the average of the section,
            'convert to a string, formatted as a percentage and display in the text box
            txtForumPercent.Text = decForumScoreShow.ToString("p")
            'call the function, divide the returned value by 100 (to display properly as a percentage) and assign to variable
            decAssignmentScore = GetAssignmentGrade() / 100
            'Take the previous value  and reverse calculations to get the average of the section,
            'convert to a string, formatted as a percentage and display in the text box
            decAssignmentScoreShow = (decAssignmentScore / intAssignmentWeight) * 100
            txtAssignmentPercent.Text = decAssignmentScoreShow.ToString("p")
            'call the function, divide the returned value by 100 (to display properly as a percentage) and assign to variable
            decTotalPercentage = decForumScore + decAssignmentScore + _decFinalsScore
            'convert the previous value to a string, formatted as a percentage and display in the text box
            txtPercent.Text = decTotalPercentage.ToString("p")
            'call function to find the final letter grade
            GetLetterGrade(decTotalPercentage)
        Else
            'display an alert window in the case of invalid data
            MessageBox.Show("Please enter a valid amount between 0 and 100 for the final project section", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close form on button click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear button will clear all user entered data and totals but not the student name
        txtForum1.Text = String.Empty
        txtForum2.Text = String.Empty
        txtForum3.Text = String.Empty
        txtForum4.Text = String.Empty
        txtForum5.Text = String.Empty
        txtForum6.Text = String.Empty
        txtForum6.Text = String.Empty
        txtForum7.Text = String.Empty
        txtForum8.Text = String.Empty
        txtForumPercent.Text = String.Empty
        txtAssignment1.Text = String.Empty
        txtAssignment2.Text = String.Empty
        txtAssignment3.Text = String.Empty
        txtAssignment4.Text = String.Empty
        txtAssignment5.Text = String.Empty
        txtAssignment6.Text = String.Empty
        txtAssignment7.Text = String.Empty
        txtAssignment8.Text = String.Empty
        txtAssignmentPercent.Text = String.Empty
        txtFinalLetterGrade.Text = String.Empty
        txtFinals.Text = String.Empty
        txtFinalsPercent.Text = String.Empty
        txtPercent.Text = String.Empty
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'print button
        'hide all un-needed components
        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnFinals.Visible = False
        btnStartOver.Visible = False
        btnPrint.Visible = False
        picPencil.Visible = False
        picLogo.Visible = False

        'send the screen to the print preview window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        'make all hidden components visable again
        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnFinals.Visible = True
        btnStartOver.Visible = True
        btnPrint.Visible = True
        picPencil.Visible = True
        picLogo.Visible = True
    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        'will start the screen over
        'simulate pressing of the clear button -clears all text boxes
        btnClear_Click(sender, e)
        'create and display new name window
        Dim wForm As New frmName
        wForm.ShowDialog(Me)
        'get the new name entered and display it in place of the old one
        _strStudentName = wForm.strStudentName
        lblName.Text = _strStudentName

    End Sub

    Private Sub btnFinals_Click(sender As Object, e As EventArgs) Handles btnFinals.Click
        'opens a new window for the user to enter the score of the final project
        'create variable to score
        Dim decFScore As Decimal
        'create and open new FinalsForm
        Dim oForm As New frmFinals
        'create variable to hold section total for display purposes
        Dim decFinalsScoreShow As Decimal

        oForm.ShowDialog(Me)
        'on form close assign the value selected by the user to the variable
        _intFinalsPoints = oForm.cboScore.SelectedItem
        'convert value to string and display
        txtFinals.Text = _intFinalsPoints.ToString()
        'call the function, divide the returned value by 100 (to display properly as a percentage) and assign to variable
        decFScore = GetFinalsScore() / 100
        decFinalsScoreShow = (decFScore / intFinalsWeight) * 100
        'Take the previous value  and reverse calculations to get the average of the section,
        'convert to a string, formatted as a percentage and display in the text box
        txtFinalsPercent.Text = decFinalsScoreShow.ToString("p")
        'assign value to another varibale to be used in further calculations
        _decFinalsScore = decFScore
    End Sub

End Class