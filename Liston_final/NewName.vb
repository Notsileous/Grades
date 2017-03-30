'Name: Coal Hill School grade calculator
'Purpose: Takes points entered by user and calculates and displays the average and final grade
'Programed by: Benjamin Liston on 12/11/2015
'this window will open in response to the start over button click, it alows for a new name to be entered
Public Class frmName

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
            'close window on click, all interactions are coded in the btnStartOver click event
            Close()

        End If



    End Sub
    'allow only letters and the backspace key
    Private Sub txtStudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudent.KeyPress
        If e.KeyChar Like "[!A-Z a-z]" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


End Class