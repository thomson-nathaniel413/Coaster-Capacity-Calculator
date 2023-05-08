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
End Class
