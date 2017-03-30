'Name: Coal Hill School grade calculator
'Purpose: Takes points entered by user and calculates and displays the average and final grade
'Programed by: Benjamin Liston on 12/11/2015
'this window opens upon button click to allow the user to enter in a grade for the final project
Public Class frmFinals

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'close the window when the submit button is pressed
        'all other interactions take place in the btnFinals click event in GradeForm.vb
        Close()
    End Sub

    Private Sub frmFinals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create local variable for grade point number and initialize to 0
        Dim intGrade As Integer = 0
        'begin for loop- loop 101 times adding the numbers 0-100 to the combobox items list
        For intNum As Integer = 0 To 100
            cboScore.Items.Add(intGrade)
            intGrade += 1
        Next intNum

    End Sub


End Class