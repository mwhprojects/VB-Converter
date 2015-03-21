' http://github.com/mwhprojects/VB-Converter

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stripAlert.Text = "(Press enter after entering number.)"
        menuInchtoCm.Checked = True

        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
    End Sub

    Private Sub menuStayonTop_Click(sender As Object, e As EventArgs) Handles menuStayonTop.Click
        If Me.TopMost = False Then
            Me.TopMost = True
            menuStayonTop.Checked = True
        Else
            Me.TopMost = False
            menuStayonTop.Checked = False
        End If
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub menuInchtoCm_Click(sender As Object, e As EventArgs) Handles menuInchtoCm.Click
        menuMilstoMm.Checked = False
        menuInchtoCm.Checked = True
        panelIntoCm.BringToFront()
    End Sub

    Private Sub menuMilstoMm_Click(sender As Object, e As EventArgs) Handles menuMilstoMm.Click
        menuInchtoCm.Checked = False
        menuMilstoMm.Checked = True
        panelMilstoMm.BringToFront()
    End Sub

    Private Sub txtInches_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInches.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim errorTrue As Boolean = False
            Dim cmResult As Double = Nothing

            Try
                cmResult = FormatNumber(txtInches.Text * 2.54, 4)
            Catch ex As Exception
                errorTrue = True
            End Try

            If errorTrue = True Then
                stripAlert.Text = "Error in input"
                txtInches.SelectAll()
            Else
                txtCentimetres.Text = cmResult
                stripAlert.Text = ""
            End If
        End If

    End Sub

    Private Sub txtCentimetres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCentimetres.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim errorTrue As Boolean = False
            Dim cmResult As Double = Nothing

            Try
                cmResult = FormatNumber(txtCentimetres.Text / 2.54, 4)
            Catch ex As Exception
                errorTrue = True
            End Try

            If errorTrue = True Then
                stripAlert.Text = ""
                stripAlert.Text = "Error in input"
                txtCentimetres.SelectAll()
            Else
                txtInches.Text = cmResult
                stripAlert.Text = ""
            End If
        End If
    End Sub

    Private Sub txtMils_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMils.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim errorTrue As Boolean = False
            Dim cmResult As Double = Nothing

            Try
                cmResult = FormatNumber(txtMils.Text * 0.0254, 4)
            Catch ex As Exception
                errorTrue = True
            End Try

            If errorTrue = True Then
                stripAlert.Text = ""
                stripAlert.Text = "Error in input"
                txtMils.SelectAll()
            Else
                txtMillimetres.Text = cmResult
                stripAlert.Text = ""
            End If
        End If
    End Sub

    Private Sub txtMillimetres_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMillimetres.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim errorTrue As Boolean = False
            Dim cmResult As Double = Nothing

            Try
                cmResult = FormatNumber(txtMillimetres.Text / 0.0254, 4)
            Catch ex As Exception
                errorTrue = True
            End Try

            If errorTrue = True Then
                stripAlert.Text = ""
                stripAlert.Text = "Error in input"
                txtMillimetres.SelectAll()
            Else
                txtMils.Text = cmResult
                stripAlert.Text = ""
            End If
        End If
    End Sub
End Class
