<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrationCostForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picSchool = New System.Windows.Forms.PictureBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblNumberOfUnits = New System.Windows.Forms.Label()
        Me.grpResidence = New System.Windows.Forms.GroupBox()
        Me.radOnCampus = New System.Windows.Forms.RadioButton()
        Me.radOffCampus = New System.Windows.Forms.RadioButton()
        Me.grpHousingBoard = New System.Windows.Forms.GroupBox()
        Me.radJulianSuites = New System.Windows.Forms.RadioButton()
        Me.radPerceyHall = New System.Windows.Forms.RadioButton()
        Me.radCooperDorm = New System.Windows.Forms.RadioButton()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.btnCalculateCosts = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfUnits = New System.Windows.Forms.TextBox()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.txtStudentID = New System.Windows.Forms.MaskedTextBox()
        CType(Me.picSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResidence.SuspendLayout()
        Me.grpHousingBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(246, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(310, 78)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Landelline College" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registration Costs"
        '
        'picSchool
        '
        Me.picSchool.BackgroundImage = Global.CollegeRegistrationCosts.My.Resources.Resources.college
        Me.picSchool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSchool.Location = New System.Drawing.Point(21, 26)
        Me.picSchool.Name = "picSchool"
        Me.picSchool.Size = New System.Drawing.Size(157, 100)
        Me.picSchool.TabIndex = 1
        Me.picSchool.TabStop = False
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(18, 153)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(115, 23)
        Me.lblStudentID.TabIndex = 2
        Me.lblStudentID.Text = "Student ID: "
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(18, 184)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(144, 23)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblNumberOfUnits
        '
        Me.lblNumberOfUnits.AutoSize = True
        Me.lblNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfUnits.Location = New System.Drawing.Point(18, 215)
        Me.lblNumberOfUnits.Name = "lblNumberOfUnits"
        Me.lblNumberOfUnits.Size = New System.Drawing.Size(163, 23)
        Me.lblNumberOfUnits.TabIndex = 4
        Me.lblNumberOfUnits.Text = "Number Of Units: "
        '
        'grpResidence
        '
        Me.grpResidence.Controls.Add(Me.radOnCampus)
        Me.grpResidence.Controls.Add(Me.radOffCampus)
        Me.grpResidence.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResidence.Location = New System.Drawing.Point(12, 276)
        Me.grpResidence.Name = "grpResidence"
        Me.grpResidence.Size = New System.Drawing.Size(142, 78)
        Me.grpResidence.TabIndex = 5
        Me.grpResidence.TabStop = False
        Me.grpResidence.Text = "Residence"
        '
        'radOnCampus
        '
        Me.radOnCampus.AutoSize = True
        Me.radOnCampus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOnCampus.Location = New System.Drawing.Point(6, 43)
        Me.radOnCampus.Name = "radOnCampus"
        Me.radOnCampus.Size = New System.Drawing.Size(126, 27)
        Me.radOnCampus.TabIndex = 1
        Me.radOnCampus.TabStop = True
        Me.radOnCampus.Text = "On-Campus"
        Me.radOnCampus.UseVisualStyleBackColor = True
        '
        'radOffCampus
        '
        Me.radOffCampus.AutoSize = True
        Me.radOffCampus.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOffCampus.Location = New System.Drawing.Point(7, 20)
        Me.radOffCampus.Name = "radOffCampus"
        Me.radOffCampus.Size = New System.Drawing.Size(127, 27)
        Me.radOffCampus.TabIndex = 0
        Me.radOffCampus.TabStop = True
        Me.radOffCampus.Text = "Off-Campus"
        Me.radOffCampus.UseVisualStyleBackColor = True
        '
        'grpHousingBoard
        '
        Me.grpHousingBoard.Controls.Add(Me.radJulianSuites)
        Me.grpHousingBoard.Controls.Add(Me.radPerceyHall)
        Me.grpHousingBoard.Controls.Add(Me.radCooperDorm)
        Me.grpHousingBoard.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHousingBoard.Location = New System.Drawing.Point(170, 276)
        Me.grpHousingBoard.Name = "grpHousingBoard"
        Me.grpHousingBoard.Size = New System.Drawing.Size(149, 100)
        Me.grpHousingBoard.TabIndex = 6
        Me.grpHousingBoard.TabStop = False
        Me.grpHousingBoard.Text = "Housing/Board"
        '
        'radJulianSuites
        '
        Me.radJulianSuites.AutoSize = True
        Me.radJulianSuites.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJulianSuites.Location = New System.Drawing.Point(7, 67)
        Me.radJulianSuites.Name = "radJulianSuites"
        Me.radJulianSuites.Size = New System.Drawing.Size(132, 27)
        Me.radJulianSuites.TabIndex = 2
        Me.radJulianSuites.TabStop = True
        Me.radJulianSuites.Text = "Julian Suites"
        Me.radJulianSuites.UseVisualStyleBackColor = True
        '
        'radPerceyHall
        '
        Me.radPerceyHall.AutoSize = True
        Me.radPerceyHall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPerceyHall.Location = New System.Drawing.Point(7, 43)
        Me.radPerceyHall.Name = "radPerceyHall"
        Me.radPerceyHall.Size = New System.Drawing.Size(120, 27)
        Me.radPerceyHall.TabIndex = 1
        Me.radPerceyHall.TabStop = True
        Me.radPerceyHall.Text = "Percey Hall"
        Me.radPerceyHall.UseVisualStyleBackColor = True
        '
        'radCooperDorm
        '
        Me.radCooperDorm.AutoSize = True
        Me.radCooperDorm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCooperDorm.Location = New System.Drawing.Point(7, 20)
        Me.radCooperDorm.Name = "radCooperDorm"
        Me.radCooperDorm.Size = New System.Drawing.Size(139, 27)
        Me.radCooperDorm.TabIndex = 0
        Me.radCooperDorm.TabStop = True
        Me.radCooperDorm.Text = "Cooper Dorm"
        Me.radCooperDorm.UseVisualStyleBackColor = True
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(335, 276)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(70, 23)
        Me.lblMajor.TabIndex = 7
        Me.lblMajor.Text = "Major: "
        '
        'btnCalculateCosts
        '
        Me.btnCalculateCosts.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCosts.Location = New System.Drawing.Point(122, 430)
        Me.btnCalculateCosts.Name = "btnCalculateCosts"
        Me.btnCalculateCosts.Size = New System.Drawing.Size(154, 31)
        Me.btnCalculateCosts.TabIndex = 8
        Me.btnCalculateCosts.Text = "Calculate Costs"
        Me.btnCalculateCosts.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(353, 430)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(127, 31)
        Me.btnClearForm.TabIndex = 9
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(129, 506)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(340, 23)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(210, 179)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(296, 30)
        Me.txtStudentName.TabIndex = 13
        '
        'txtNumberOfUnits
        '
        Me.txtNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfUnits.Location = New System.Drawing.Point(210, 217)
        Me.txtNumberOfUnits.Name = "txtNumberOfUnits"
        Me.txtNumberOfUnits.Size = New System.Drawing.Size(49, 30)
        Me.txtNumberOfUnits.TabIndex = 14
        '
        'cboMajor
        '
        Me.cboMajor.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Items.AddRange(New Object() {"Biology", "Business", "Chemistry", "Computer Science", "Fine Arts", "Mathematics", "Physics", "Sociology", "Theology"})
        Me.cboMajor.Location = New System.Drawing.Point(411, 268)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(179, 31)
        Me.cboMajor.TabIndex = 15
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(210, 143)
        Me.txtStudentID.Mask = "000-00-0000"
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(120, 30)
        Me.txtStudentID.TabIndex = 16
        '
        'frmRegistrationCostForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(602, 562)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.txtNumberOfUnits)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalculateCosts)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.grpHousingBoard)
        Me.Controls.Add(Me.grpResidence)
        Me.Controls.Add(Me.lblNumberOfUnits)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.picSchool)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmRegistrationCostForm"
        Me.Text = "College Registration Costs"
        CType(Me.picSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResidence.ResumeLayout(False)
        Me.grpResidence.PerformLayout()
        Me.grpHousingBoard.ResumeLayout(False)
        Me.grpHousingBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picSchool As System.Windows.Forms.PictureBox
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfUnits As System.Windows.Forms.Label
    Friend WithEvents grpResidence As System.Windows.Forms.GroupBox
    Friend WithEvents radOnCampus As System.Windows.Forms.RadioButton
    Friend WithEvents radOffCampus As System.Windows.Forms.RadioButton
    Friend WithEvents grpHousingBoard As System.Windows.Forms.GroupBox
    Friend WithEvents radJulianSuites As System.Windows.Forms.RadioButton
    Friend WithEvents radPerceyHall As System.Windows.Forms.RadioButton
    Friend WithEvents radCooperDorm As System.Windows.Forms.RadioButton
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCosts As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfUnits As System.Windows.Forms.TextBox
    Friend WithEvents cboMajor As System.Windows.Forms.ComboBox
    Friend WithEvents txtStudentID As System.Windows.Forms.MaskedTextBox

End Class
