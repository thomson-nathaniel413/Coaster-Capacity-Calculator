<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapacity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapacity))
        Me.picCoaster = New System.Windows.Forms.PictureBox()
        Me.lblCapacityCalculator = New System.Windows.Forms.Label()
        Me.lblRPTIndicator = New System.Windows.Forms.Label()
        Me.lblTrainCountIndicator = New System.Windows.Forms.Label()
        Me.lblRideLengthIndicator = New System.Windows.Forms.Label()
        Me.grpStationType = New System.Windows.Forms.GroupBox()
        Me.grpUnload = New System.Windows.Forms.GroupBox()
        Me.grpPropType = New System.Windows.Forms.GroupBox()
        Me.grpRestraintType = New System.Windows.Forms.GroupBox()
        Me.lblPropLengthIndicator = New System.Windows.Forms.Label()
        Me.lblPropRateIndicator = New System.Windows.Forms.Label()
        Me.lblLaunchCountIndicator = New System.Windows.Forms.Label()
        Me.txtRPT = New System.Windows.Forms.TextBox()
        Me.txtTrainCount = New System.Windows.Forms.TextBox()
        Me.txtRideLength = New System.Windows.Forms.TextBox()
        Me.txtPropLength = New System.Windows.Forms.TextBox()
        Me.txtPropRate = New System.Windows.Forms.TextBox()
        Me.txtLaunchCount = New System.Windows.Forms.TextBox()
        Me.radSingleStation = New System.Windows.Forms.RadioButton()
        Me.radDoubleStation = New System.Windows.Forms.RadioButton()
        Me.radSepUnload = New System.Windows.Forms.RadioButton()
        Me.radNoUnload = New System.Windows.Forms.RadioButton()
        Me.radLift = New System.Windows.Forms.RadioButton()
        Me.radLaunch = New System.Windows.Forms.RadioButton()
        Me.radLapBar = New System.Windows.Forms.RadioButton()
        Me.radOTS = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.picCoaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStationType.SuspendLayout()
        Me.grpUnload.SuspendLayout()
        Me.grpPropType.SuspendLayout()
        Me.grpRestraintType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCoaster
        '
        Me.picCoaster.Image = CType(resources.GetObject("picCoaster.Image"), System.Drawing.Image)
        Me.picCoaster.Location = New System.Drawing.Point(0, 0)
        Me.picCoaster.Margin = New System.Windows.Forms.Padding(2)
        Me.picCoaster.Name = "picCoaster"
        Me.picCoaster.Size = New System.Drawing.Size(246, 354)
        Me.picCoaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoaster.TabIndex = 0
        Me.picCoaster.TabStop = False
        '
        'lblCapacityCalculator
        '
        Me.lblCapacityCalculator.AutoSize = True
        Me.lblCapacityCalculator.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacityCalculator.Location = New System.Drawing.Point(371, 20)
        Me.lblCapacityCalculator.Name = "lblCapacityCalculator"
        Me.lblCapacityCalculator.Size = New System.Drawing.Size(279, 19)
        Me.lblCapacityCalculator.TabIndex = 1
        Me.lblCapacityCalculator.Text = "Calculate Capacity of Roller Coasters"
        '
        'lblRPTIndicator
        '
        Me.lblRPTIndicator.AutoSize = True
        Me.lblRPTIndicator.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPTIndicator.Location = New System.Drawing.Point(259, 59)
        Me.lblRPTIndicator.Name = "lblRPTIndicator"
        Me.lblRPTIndicator.Size = New System.Drawing.Size(91, 12)
        Me.lblRPTIndicator.TabIndex = 2
        Me.lblRPTIndicator.Text = "Riders Per Train:"
        '
        'lblTrainCountIndicator
        '
        Me.lblTrainCountIndicator.AutoSize = True
        Me.lblTrainCountIndicator.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainCountIndicator.Location = New System.Drawing.Point(259, 79)
        Me.lblTrainCountIndicator.Name = "lblTrainCountIndicator"
        Me.lblTrainCountIndicator.Size = New System.Drawing.Size(97, 12)
        Me.lblTrainCountIndicator.TabIndex = 3
        Me.lblTrainCountIndicator.Text = "Number of Trains:"
        '
        'lblRideLengthIndicator
        '
        Me.lblRideLengthIndicator.AutoSize = True
        Me.lblRideLengthIndicator.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRideLengthIndicator.Location = New System.Drawing.Point(258, 99)
        Me.lblRideLengthIndicator.Name = "lblRideLengthIndicator"
        Me.lblRideLengthIndicator.Size = New System.Drawing.Size(120, 12)
        Me.lblRideLengthIndicator.TabIndex = 4
        Me.lblRideLengthIndicator.Text = "Ride Length (seconds):"
        '
        'grpStationType
        '
        Me.grpStationType.Controls.Add(Me.radDoubleStation)
        Me.grpStationType.Controls.Add(Me.radSingleStation)
        Me.grpStationType.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStationType.Location = New System.Drawing.Point(273, 119)
        Me.grpStationType.Name = "grpStationType"
        Me.grpStationType.Size = New System.Drawing.Size(200, 100)
        Me.grpStationType.TabIndex = 5
        Me.grpStationType.TabStop = False
        Me.grpStationType.Text = "Station Type:"
        '
        'grpUnload
        '
        Me.grpUnload.Controls.Add(Me.radNoUnload)
        Me.grpUnload.Controls.Add(Me.radSepUnload)
        Me.grpUnload.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUnload.Location = New System.Drawing.Point(480, 119)
        Me.grpUnload.Name = "grpUnload"
        Me.grpUnload.Size = New System.Drawing.Size(200, 100)
        Me.grpUnload.TabIndex = 6
        Me.grpUnload.TabStop = False
        Me.grpUnload.Text = "Unload Station:"
        '
        'grpPropType
        '
        Me.grpPropType.Controls.Add(Me.radLaunch)
        Me.grpPropType.Controls.Add(Me.radLift)
        Me.grpPropType.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPropType.Location = New System.Drawing.Point(273, 226)
        Me.grpPropType.Name = "grpPropType"
        Me.grpPropType.Size = New System.Drawing.Size(200, 100)
        Me.grpPropType.TabIndex = 7
        Me.grpPropType.TabStop = False
        Me.grpPropType.Text = "Propulsion Type:"
        '
        'grpRestraintType
        '
        Me.grpRestraintType.Controls.Add(Me.radOTS)
        Me.grpRestraintType.Controls.Add(Me.radLapBar)
        Me.grpRestraintType.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRestraintType.Location = New System.Drawing.Point(480, 226)
        Me.grpRestraintType.Name = "grpRestraintType"
        Me.grpRestraintType.Size = New System.Drawing.Size(200, 100)
        Me.grpRestraintType.TabIndex = 8
        Me.grpRestraintType.TabStop = False
        Me.grpRestraintType.Text = "Restraint Type:"
        '
        'lblPropLengthIndicator
        '
        Me.lblPropLengthIndicator.AutoSize = True
        Me.lblPropLengthIndicator.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropLengthIndicator.Location = New System.Drawing.Point(448, 59)
        Me.lblPropLengthIndicator.Name = "lblPropLengthIndicator"
        Me.lblPropLengthIndicator.Size = New System.Drawing.Size(176, 12)
        Me.lblPropLengthIndicator.TabIndex = 9
        Me.lblPropLengthIndicator.Text = "Length of Propulsion Track (feet):"
        '
        'lblPropRateIndicator
        '
        Me.lblPropRateIndicator.AutoSize = True
        Me.lblPropRateIndicator.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropRateIndicator.Location = New System.Drawing.Point(448, 80)
        Me.lblPropRateIndicator.Name = "lblPropRateIndicator"
        Me.lblPropRateIndicator.Size = New System.Drawing.Size(280, 12)
        Me.lblPropRateIndicator.TabIndex = 10
        Me.lblPropRateIndicator.Text = "Acceleration Rate of Propulsion (feet/second/second):"
        '
        'lblLaunchCountIndicator
        '
        Me.lblLaunchCountIndicator.AutoSize = True
        Me.lblLaunchCountIndicator.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaunchCountIndicator.Location = New System.Drawing.Point(347, 347)
        Me.lblLaunchCountIndicator.Name = "lblLaunchCountIndicator"
        Me.lblLaunchCountIndicator.Size = New System.Drawing.Size(115, 12)
        Me.lblLaunchCountIndicator.TabIndex = 11
        Me.lblLaunchCountIndicator.Text = "Number of Launches: "
        '
        'txtRPT
        '
        Me.txtRPT.Location = New System.Drawing.Point(362, 56)
        Me.txtRPT.Name = "txtRPT"
        Me.txtRPT.Size = New System.Drawing.Size(48, 20)
        Me.txtRPT.TabIndex = 12
        '
        'txtTrainCount
        '
        Me.txtTrainCount.Location = New System.Drawing.Point(362, 76)
        Me.txtTrainCount.Name = "txtTrainCount"
        Me.txtTrainCount.Size = New System.Drawing.Size(48, 20)
        Me.txtTrainCount.TabIndex = 13
        '
        'txtRideLength
        '
        Me.txtRideLength.Location = New System.Drawing.Point(389, 96)
        Me.txtRideLength.Name = "txtRideLength"
        Me.txtRideLength.Size = New System.Drawing.Size(48, 20)
        Me.txtRideLength.TabIndex = 14
        '
        'txtPropLength
        '
        Me.txtPropLength.Location = New System.Drawing.Point(630, 56)
        Me.txtPropLength.Name = "txtPropLength"
        Me.txtPropLength.Size = New System.Drawing.Size(75, 20)
        Me.txtPropLength.TabIndex = 15
        '
        'txtPropRate
        '
        Me.txtPropRate.Location = New System.Drawing.Point(734, 75)
        Me.txtPropRate.Name = "txtPropRate"
        Me.txtPropRate.Size = New System.Drawing.Size(48, 20)
        Me.txtPropRate.TabIndex = 16
        '
        'txtLaunchCount
        '
        Me.txtLaunchCount.Location = New System.Drawing.Point(462, 344)
        Me.txtLaunchCount.Name = "txtLaunchCount"
        Me.txtLaunchCount.Size = New System.Drawing.Size(48, 20)
        Me.txtLaunchCount.TabIndex = 17
        '
        'radSingleStation
        '
        Me.radSingleStation.AutoSize = True
        Me.radSingleStation.Location = New System.Drawing.Point(7, 20)
        Me.radSingleStation.Name = "radSingleStation"
        Me.radSingleStation.Size = New System.Drawing.Size(85, 16)
        Me.radSingleStation.TabIndex = 0
        Me.radSingleStation.TabStop = True
        Me.radSingleStation.Text = "Single Sided"
        Me.radSingleStation.UseVisualStyleBackColor = True
        '
        'radDoubleStation
        '
        Me.radDoubleStation.AutoSize = True
        Me.radDoubleStation.Location = New System.Drawing.Point(7, 44)
        Me.radDoubleStation.Name = "radDoubleStation"
        Me.radDoubleStation.Size = New System.Drawing.Size(91, 16)
        Me.radDoubleStation.TabIndex = 1
        Me.radDoubleStation.TabStop = True
        Me.radDoubleStation.Text = "Double Sided"
        Me.radDoubleStation.UseVisualStyleBackColor = True
        '
        'radSepUnload
        '
        Me.radSepUnload.AutoSize = True
        Me.radSepUnload.Location = New System.Drawing.Point(7, 20)
        Me.radSepUnload.Name = "radSepUnload"
        Me.radSepUnload.Size = New System.Drawing.Size(166, 16)
        Me.radSepUnload.TabIndex = 0
        Me.radSepUnload.TabStop = True
        Me.radSepUnload.Text = "Has Separate Unload Station"
        Me.radSepUnload.UseVisualStyleBackColor = True
        '
        'radNoUnload
        '
        Me.radNoUnload.AutoSize = True
        Me.radNoUnload.Location = New System.Drawing.Point(7, 44)
        Me.radNoUnload.Name = "radNoUnload"
        Me.radNoUnload.Size = New System.Drawing.Size(160, 16)
        Me.radNoUnload.TabIndex = 1
        Me.radNoUnload.TabStop = True
        Me.radNoUnload.Text = "No Separate Unload Station"
        Me.radNoUnload.UseVisualStyleBackColor = True
        '
        'radLift
        '
        Me.radLift.AutoSize = True
        Me.radLift.Location = New System.Drawing.Point(7, 20)
        Me.radLift.Name = "radLift"
        Me.radLift.Size = New System.Drawing.Size(59, 16)
        Me.radLift.TabIndex = 0
        Me.radLift.TabStop = True
        Me.radLift.Text = "Lift Hill"
        Me.radLift.UseVisualStyleBackColor = True
        '
        'radLaunch
        '
        Me.radLaunch.AutoSize = True
        Me.radLaunch.Location = New System.Drawing.Point(7, 44)
        Me.radLaunch.Name = "radLaunch"
        Me.radLaunch.Size = New System.Drawing.Size(61, 16)
        Me.radLaunch.TabIndex = 1
        Me.radLaunch.TabStop = True
        Me.radLaunch.Text = "Launch"
        Me.radLaunch.UseVisualStyleBackColor = True
        '
        'radLapBar
        '
        Me.radLapBar.AutoSize = True
        Me.radLapBar.Location = New System.Drawing.Point(7, 20)
        Me.radLapBar.Name = "radLapBar"
        Me.radLapBar.Size = New System.Drawing.Size(62, 16)
        Me.radLapBar.TabIndex = 0
        Me.radLapBar.TabStop = True
        Me.radLapBar.Text = "Lap Bar"
        Me.radLapBar.UseVisualStyleBackColor = True
        '
        'radOTS
        '
        Me.radOTS.AutoSize = True
        Me.radOTS.Location = New System.Drawing.Point(7, 44)
        Me.radOTS.Name = "radOTS"
        Me.radOTS.Size = New System.Drawing.Size(143, 16)
        Me.radOTS.TabIndex = 1
        Me.radOTS.TabStop = True
        Me.radOTS.Text = "Over the Shoulder/Vest"
        Me.radOTS.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(462, 519)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 30)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(630, 519)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 30)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(578, 337)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 30)
        Me.btnCalculate.TabIndex = 20
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmCapacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(834, 561)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtLaunchCount)
        Me.Controls.Add(Me.txtPropRate)
        Me.Controls.Add(Me.txtPropLength)
        Me.Controls.Add(Me.txtRideLength)
        Me.Controls.Add(Me.txtTrainCount)
        Me.Controls.Add(Me.txtRPT)
        Me.Controls.Add(Me.lblLaunchCountIndicator)
        Me.Controls.Add(Me.lblPropRateIndicator)
        Me.Controls.Add(Me.lblPropLengthIndicator)
        Me.Controls.Add(Me.grpRestraintType)
        Me.Controls.Add(Me.grpPropType)
        Me.Controls.Add(Me.grpUnload)
        Me.Controls.Add(Me.grpStationType)
        Me.Controls.Add(Me.lblRideLengthIndicator)
        Me.Controls.Add(Me.lblTrainCountIndicator)
        Me.Controls.Add(Me.lblRPTIndicator)
        Me.Controls.Add(Me.lblCapacityCalculator)
        Me.Controls.Add(Me.picCoaster)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCapacity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coaster Capacity Calculator"
        CType(Me.picCoaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStationType.ResumeLayout(False)
        Me.grpStationType.PerformLayout()
        Me.grpUnload.ResumeLayout(False)
        Me.grpUnload.PerformLayout()
        Me.grpPropType.ResumeLayout(False)
        Me.grpPropType.PerformLayout()
        Me.grpRestraintType.ResumeLayout(False)
        Me.grpRestraintType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCoaster As PictureBox
    Friend WithEvents lblCapacityCalculator As Label
    Friend WithEvents lblRPTIndicator As Label
    Friend WithEvents lblTrainCountIndicator As Label
    Friend WithEvents lblRideLengthIndicator As Label
    Friend WithEvents grpStationType As GroupBox
    Friend WithEvents grpUnload As GroupBox
    Friend WithEvents grpPropType As GroupBox
    Friend WithEvents grpRestraintType As GroupBox
    Friend WithEvents lblPropLengthIndicator As Label
    Friend WithEvents lblPropRateIndicator As Label
    Friend WithEvents lblLaunchCountIndicator As Label
    Friend WithEvents txtRPT As TextBox
    Friend WithEvents txtTrainCount As TextBox
    Friend WithEvents txtRideLength As TextBox
    Friend WithEvents txtPropLength As TextBox
    Friend WithEvents txtPropRate As TextBox
    Friend WithEvents txtLaunchCount As TextBox
    Friend WithEvents radDoubleStation As RadioButton
    Friend WithEvents radSingleStation As RadioButton
    Friend WithEvents radNoUnload As RadioButton
    Friend WithEvents radSepUnload As RadioButton
    Friend WithEvents radLaunch As RadioButton
    Friend WithEvents radLift As RadioButton
    Friend WithEvents radOTS As RadioButton
    Friend WithEvents radLapBar As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
End Class
