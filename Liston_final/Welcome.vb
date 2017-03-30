'Name: Coal Hill School grade calculator
'Purpose: Takes points entered by user and calculates and displays the average and final grade
'Programed by: Benjamin Liston on 12/11/2015

'This window loads first and captures the tudent name entered by the user
Public Class frmWelcome
    'public and private variable to hold user input
    Public Property strStudentName As String



    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        'on click
        'take the name entered by the user and store in the variable
        _strStudentName = txtStudent.Text
        'check to make sure the field is not empty
        If _strStudentName = "" Then
            'if empty, display a warning window and set focus to textbox
            MessageBox.Show("Please enter a valid name", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtStudent.Focus()
        Else
            'if string is valid create a new gradeForm object and open it
            Dim oForm As frmGrade
            oForm = New frmGrade()
            oForm.Show()
            oForm = Nothing
        End If




    End Sub
    'allow only letters and the backspace key
    Private Sub txtStudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudent.KeyPress
        If e.KeyChar Like "[!A-Z a-z]" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub




End Class