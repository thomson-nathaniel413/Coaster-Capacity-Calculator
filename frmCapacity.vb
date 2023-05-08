Public Class frmCapacity
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' exits the program
        Close()
    End Sub

    Private Sub radLift_CheckedChanged(sender As Object, e As EventArgs) Handles radLift.CheckedChanged
        ' when lift hill is selected
        lblLaunchCountIndicator.Visible = False
        txtLaunchCount.Visible = False
        txtLaunchCount.Text = "1" ' this is used for internal calculations
    End Sub

    Private Sub radLaunch_CheckedChanged(sender As Object, e As EventArgs) Handles radLaunch.CheckedChanged
        ' when launch is selected
        lblLaunchCountIndicator.Visible = True
        txtLaunchCount.Visible = True
        txtLaunchCount.Clear() ' so the text box shows up empty
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears all input fields and sets radio buttons to default

        ' clear all text fields
        txtPropLength.Clear()
        txtPropRate.Clear()
        txtRideLength.Clear()
        txtRPT.Clear()
        txtTrainCount.Clear()

        ' select default radio buttons
        radSingleStation.Select()
        radSepUnload.Select()
        radLift.Select() ' this should also make the launch count fields invisible
        radLapBar.Select()

        ' clear output labels
        lblRPH.Text = ""
        lblRPD.Text = ""
        lblDispatchTime.Text = ""

    End Sub

    Private Sub frmCapacity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' initiate variables
        ' all of these will need input verification
        Dim intRPT As Integer
        Dim intTrainCount As Integer
        Dim intRideLength As Integer
        Dim intPropLength As Integer
        Dim intPropRate As Integer
        Dim intLaunchCount As Integer

        Dim boolVerifyLoop As Boolean = True
        Dim intVerifyLoop As Integer

        While boolVerifyLoop
            ' verifying RPT input
            intVerifyLoop = VerifyInteger(txtRPT.Text)
            If intVerifyLoop = -1 Then
                ' input verification failed; attempts to get new input
                txtRPT.Text = InputBox("Your input for the number of riders per train is invalid; please input a positive integer for this value now.", "Validation Failed", "")
            Else
                ' input verification passed
                boolVerifyLoop = False
            End If

        End While

        intRPT = intVerifyLoop
        boolVerifyLoop = True

        While boolVerifyLoop
            ' verifying train count input
            intVerifyLoop = VerifyInteger(txtTrainCount.Text)
            If intVerifyLoop = -1 Then
                ' input verification failed; attempts to get new input
                txtTrainCount.Text = InputBox("Your input for the number of trains on the track is invalid; please input a positive integer for this value now.", "Validation Failed", "")
            Else
                ' input verification passed
                boolVerifyLoop = False
            End If
        End While

        intTrainCount = intVerifyLoop
        boolVerifyLoop = True

        While boolVerifyLoop
            ' verifying ride length input
            intVerifyLoop = VerifyInteger(txtRideLength.Text)
            If intVerifyLoop = -1 Then
                ' input verification failed; attempts to get new input
                txtRideLength.Text = InputBox("Your input for the length of the ride is invalid; please input a positive integer for this value now.", "Validation Failed", "")
            Else
                ' input verification passed
                boolVerifyLoop = False
            End If
        End While

        intRideLength = intVerifyLoop
        boolVerifyLoop = True

        While boolVerifyLoop
            ' verifying propulsion length input
            intVerifyLoop = VerifyInteger(txtPropLength.Text)
            If intVerifyLoop = -1 Then
                ' input verification failed; attempts to get new input
                txtPropLength.Text = InputBox("Your input for the length of the propulsion track is invalid; please input a positive integer for this value now.", "Validation Failed", "")
            Else
                ' input verification passed
                boolVerifyLoop = False
            End If
        End While

        intPropLength = intVerifyLoop
        boolVerifyLoop = True

        While boolVerifyLoop
            ' verifying propulsion rate input
            intVerifyLoop = VerifyInteger(txtPropRate.Text)
            If intVerifyLoop = -1 Then
                ' input verification failed; attempts to get new input
                txtPropRate.Text = InputBox("Your input for the speed of the propulsion is invalid; please input a positive integer for this value now.", "Validation Failed", "")
            Else
                ' input verification passed
                boolVerifyLoop = False
            End If
        End While

        intPropRate = intVerifyLoop
        boolVerifyLoop = True

        While boolVerifyLoop
            ' verifying launch count input
            intVerifyLoop = VerifyInteger(txtLaunchCount.Text)
            If intVerifyLoop = -1 Then
                ' input verification failed; attempts to get new input
                txtLaunchCount.Text = InputBox("Your input for the number of launches is invalid; please input a positive integer for this value now.", "Validation Failed", "")
            Else
                ' input verification passed
                boolVerifyLoop = False
            End If
        End While

        intLaunchCount = intVerifyLoop

        ' if the program reaches this point, all text inputs should be verified

        ' needed variables for calculations
        Dim intLoadTime As Integer
        Dim intReturnTime As Integer
        Dim intDispatchRate As Integer
        Dim intBlockZoneClearTime As Integer
        Dim intRestraintSpeed As Integer
        Dim decStationTypeDiscount As Decimal
        Dim decUnloadStationDiscount As Decimal
        Dim intUnloadStationIncrease As Integer
        Dim intRPH As Integer
        Dim intRPD As Integer


        ' calculate the time to clear the propulsion track
        intBlockZoneClearTime = (intRideLength / intPropRate) * intLaunchCount

        ' calculate time to load and dispatch a single train

        ' get restraint type
        If radLapBar.Checked() Then
            ' lap bar
            intRestraintSpeed = 40
        ElseIf radOTS.Checked() Then
            ' OTS
            intRestraintSpeed = 50
        ElseIf radSpecRestraint.Checked() Then
            ' specialty restraing
            intRestraintSpeed = 60
        End If

        ' get station type
        If radSingleStation.Checked() Then
            ' single station
            decStationTypeDiscount = 1
        ElseIf radDoubleStation.Checked() Then
            ' double station
            decStationTypeDiscount = 0.5
        End If

        ' get unload station
        If radSepUnload.Checked() Then
            ' separate unload station
            decUnloadStationDiscount = 0.5
        ElseIf radNoUnload.Checked() Then
            decUnloadStationDiscount = 1
        End If

        intLoadTime = intRestraintSpeed * decStationTypeDiscount * decUnloadStationDiscount

        ' ensure dispatch time is not faster than propulsion block clear time
        If intLoadTime < intBlockZoneClearTime Then
            intLoadTime = intBlockZoneClearTime
        End If

        ' calculate return time (time it takes for a train to return to the station)

        ' get unload station (unload station increases return time somewhat
        If radSepUnload.Checked() Then
            ' separate unload station
            intUnloadStationIncrease = 45
        ElseIf radNoUnload.Checked() Then
            ' no separate unload station
            intUnloadStationIncrease = 0
        End If

        intReturnTime = (intRideLength / intTrainCount) + intUnloadStationIncrease

        ' calculate dispatch rate
        intDispatchRate = intLoadTime + intReturnTime

        ' calculate riders per hour
        intRPH = (3600 / intDispatchRate) * intRPT

        ' calculate riders per day; assuming a 12 hour operating day with no downtime
        intRPD = intRPH * 12

        ' display relevant output
        lblRPH.Text = intRPH.ToString()
        lblRPD.Text = intRPD.ToString()
        lblDispatchTime.Text = intDispatchRate.ToString()
    End Sub

    Private Function VerifyInteger(strInput As String) As Integer
        ' verifies that a given string can be parsed as an integer
        ' will return -1 if it cannot be, or the parsed integer if it can be
        ' also ensures integer is positive; a negative parsed integer will return -1
        Dim intInput As Integer

        ' attempt to parse the input
        Dim boolVerify As Boolean = Int32.TryParse(strInput, intInput)

        If (boolVerify) Then
            ' input parsed successfully
            If (intInput < 0) Then
                ' input is negative
                intInput = -1
            End If
        Else
            ' input failed to validate
            intInput = -1
        End If

        Return intInput
    End Function
End Class
