' Class:        OnCampusStudent
' Developer:    Trevor Anthony Bowling
' Date:         April 16, 2014
' Purpose:      This business class for registering an on-campus college
'               student calculates the semester costs, including tuition
'               and housing. It also causes the student costs file to be written.    

Option Strict On

Public Class OnCampusStudent
    Inherits Student

    ' Class variables
    Private _Cooper As Boolean
    Private _Percey As Boolean
    Private _Julian As Boolean

    Dim objStudentCostsFile As StudentCostsFile

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, _
            ByVal strMajor As String, ByVal intUnits As String, _
            ByVal Cooper As Boolean, ByVal Percey As Boolean, _
            ByVal Julian As Boolean)
        ' This subprocedure is a constructor for the Student class. It is
        ' called when the object is instantiated with arguments

        MyBase.New(strStudentID, strStudentName, strMajor, intUnits)

        ' The following code assigns the arguments to class variables
        _Cooper = Cooper
        _Percey = Percey
        _Julian = Julian

    End Sub

    Overrides Function ComputeCosts() As Decimal
        ' This function computes the registration costs, writes a record
        ' in the student costs file, and returns the registration costs

        'Define variables
        Dim HousingCost As Decimal
        Const cdecCooperHousingCost As Decimal = 2900D
        Const cdecPerceyHousingCost As Decimal = 3400D
        Const cdecJulianHousingCost As Decimal = 4000D

        'Calculate the cost
        If _Cooper Then
            HousingCost = cdecCooperHousingCost
        ElseIf _Percey Then
            HousingCost = cdecPerceyHousingCost
        ElseIf _Julian Then
            HousingCost = cdecJulianHousingCost
        End If

        _decCost = (_intUnits * _decCostPerUnit) + HousingCost

        'Write the student record
        objStudentCostsFile = New StudentCostsFile(_strStudentID, _
            _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        'Return the calculated cost
        Return _decCost

    End Function

End Class