' Program:      College Registration Costs
' Developer:    Trevor Anthony Bowling
' Date:         April 16, 2014
' Purpose:      This program calculates the registration costs for a college
'               student . It aslo records the costs in a text file.

Option Strict On

Public Class frmRegistrationCostForm

    Private Sub btnCalculateCosts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateCosts.Click
        ' This Calculate Costs button click event handler edits the
        ' registration(costs) form to ensure it contains valid data.
        ' Then, after passing control to the business class, it
        ' displays the registration cost.

        Dim objStudent As Student
        Dim objOnCampusStudent As OnCampusStudent
        Dim InputError As Boolean = False

        ' Is student ID entered properly
        If txtStudentID.MaskFull = False Then
            MsgBox("Enter your Student ID in the Student ID box", , _
                   "Error")
            txtStudentID.Clear()
            txtStudentID.Focus()
            InputError = True
            ' Is student anme entered properly
        ElseIf txtStudentName.TextLength < 1 Or _ 
            txtStudentName.Text < "A" Then
            MsgBox("Enter your name in the Student Name box", , "Error")
            txtStudentName.Clear()
            txtStudentName.Focus()
            InputError = True
            ' Is number of units entered properly
        ElseIf Not IsNumeric(txtNumberOfUnits.Text) Then
            MsgBox("Enter the number of units in the Number of Units box", , _
                   "Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True
            ' Has 1-24 units been entered
        ElseIf Convert.ToInt32(txtNumberOfUnits.Text) < 1 _
            Or Convert.ToInt32(txtNumberOfUnits.Text) > 24 Then
            MsgBox("Units must be 1-24", , "Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True
            ' Has a major been selected
        ElseIf cboMajor.SelectedIndex < 0 Then
            MsgBox("Please select a major", , "Error")
            cboMajor.Focus()
            InputError = True
        End If

        ' If no input error, process the registration costs
        If Not InputError Then
            If radOffCampus.Checked Then
                objStudent = New Student(txtStudentID.Text, _
                        txtStudentName.Text, Convert.ToString(cboMajor.SelectedItem), _
                        txtNumberOfUnits.Text)
                lblCost.Visible = True
                lblCost.Text = "Total semester costs are: " _
                    & (objStudent.ComputeCosts()).ToString("C2")
            Else
                objOnCampusStudent = New OnCampusStudent(txtStudentID.Text, _
                        txtStudentName.Text, Convert.ToString(cboMajor.SelectedItem), _
                        txtNumberOfUnits.Text, radCooperDorm.Checked, _
                        radPerceyHall.Checked, radJulianSuites.Checked)
                lblCost.Visible = True
                lblCost.Text = "Total smester costs are: " _
                    & (objOnCampusStudent.ComputeCosts()).ToString("C2")

            End If
        End If

    End Sub

    Private Sub radOffCampus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOffCampus.CheckedChanged
        ' This event handler is executed when the Off Campus radio
        ' button is selected. It hides the Housing/Board radio buttons

        grpHousingBoard.Visible = False

    End Sub

    Private Sub radOnCampus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOnCampus.CheckedChanged
        ' This event handler is executed when the On Campus radio button
        ' is selected. It makes the Housing/Board radio buttons visible.

        grpHousingBoard.Visible = True

    End Sub

    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click
        ' This event handler is executed when the user clicks the
        ' Clear Form button. It resets all objects on the user interfaces.

        txtStudentID.Clear()
        txtStudentName.Clear()
        txtNumberOfUnits.Clear()
        cboMajor.SelectedIndex = -1
        cboMajor.Text = "Select a Major"
        radOffCampus.Checked = True
        radCooperDorm.Checked = True
        grpHousingBoard.Visible = False
        lblCost.Visible = False
        txtStudentID.Focus()

    End Sub
End Class
