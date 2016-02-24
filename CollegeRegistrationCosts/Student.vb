' Class:        Student
' Developer:    Trevor Anthony Bowling
' Date:         April 16, 2014
' Purpose:      This business class for a registering college student
'               calculates the semester costs for tuition. It also causes the
'               student costs file to be written.    

Option Strict On

Public Class Student

    ' Class variables
    Protected _strStudentID As String
    Protected _strStudentName As String
    Protected _strMajor As String
    Protected _intUnits As Integer
    Protected _decCost As Decimal
    Protected _decCostPerUnit As Decimal = 450D

    Dim objStudentCostsFile As StudentCostsFile

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, _
            ByVal strMajor As String, ByVal intUnits As String)
        ' This subprocedure is a constructor for the Student class. It is
        ' called when the object is instantiated with arguments

        ' The following code assigns the arguments to class variables
        _strStudentID = strStudentID
        _strStudentName = strStudentName
        _strMajor = strMajor
        _intUnits = Convert.ToInt32(intUnits)

    End Sub

    Overridable Function ComputeCosts() As Decimal
        ' This function computes the registration costs, writes a record
        ' in the student costs file, and returns the registration costs

        ' Calculate cost
        _decCost = _intUnits * _decCostPerUnit

        'Write the student record
        objStudentCostsFile = New StudentCostsFile(_strStudentID, _
            _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        'Return the calculated cost
        Return _decCost

    End Function

End Class
