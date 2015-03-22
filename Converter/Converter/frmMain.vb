' http://github.com/mwhprojects/VB-Converter

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        stripAlert.Text = "(Press enter after entering number.)"
        menuInchtoCm.Checked = True

        If My.Settings.HistoryDefaultOpen = True Then
            menuShowHistory_Click(Nothing, Nothing)
        End If

        If My.Settings.OnTopDefault = True Then
            menuStayonTop_Click(Nothing, Nothing)
        End If

        If My.Settings.Save1 <> "" Then
            frmHistory.lstSaved.Items.Insert(0, My.Settings.Save1)
        End If
        If My.Settings.Save2 <> "" Then
            frmHistory.lstSaved.Items.Insert(1, My.Settings.Save2)
        End If
        If My.Settings.Save3 <> "" Then
            frmHistory.lstSaved.Items.Insert(2, My.Settings.Save3)
        End If
        If My.Settings.Save4 <> "" Then
            frmHistory.lstSaved.Items.Insert(3, My.Settings.Save4)
        End If
        If My.Settings.Save5 <> "" Then
            frmHistory.lstSaved.Items.Insert(4, My.Settings.Save5)
        End If
        If My.Settings.Save6 <> "" Then
            frmHistory.lstSaved.Items.Insert(5, My.Settings.Save6)
        End If

    End Sub

    Private Sub menuStayonTop_Click(sender As Object, e As EventArgs) Handles menuStayonTop.Click
        If Me.TopMost = False Then
            Me.TopMost = True
            frmHistory.TopMost = True
            menuStayonTop.Checked = True
        Else
            Me.TopMost = False
            frmHistory.TopMost = False
            menuStayonTop.Checked = False
        End If
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Me.Close()
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
                frmHistory.lstHistory.Items.Insert(0, txtInches.Text & "in -> " & cmResult & "cm")
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
                frmHistory.lstHistory.Items.Insert(0, txtCentimetres.Text & "cm -> " & cmResult & "in")
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
                frmHistory.lstHistory.Items.Insert(0, txtMils.Text & "mils -> " & cmResult & "mm")
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
                frmHistory.lstHistory.Items.Insert(0, txtMillimetres.Text & "mm -> " & cmResult & "mils")
                stripAlert.Text = ""
            End If
        End If
    End Sub

    Private Sub menuShowHistory_Click(sender As Object, e As EventArgs) Handles menuShowHistory.Click
        If menuShowHistory.Text = "Show History and Saved Window" Then
            ' Show history form
            menuShowHistory.Text = "Hide History and Saved Window"

            ' Put main form back in corner only if user didn't move it anywhere else.
            If Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
                Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - frmHistory.Height)
            End If

            frmHistory.Show()
        Else
            ' Hide history form
            menuShowHistory.Text = "Show History and Saved Window"

            ' Put main form back in corner only if user didn't move it anywhere else.
            If Me.Location.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width And Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - frmHistory.Height Then
                Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
            End If

            frmHistory.Hide()
        End If

    End Sub

    Private Sub frmMain_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        frmHistory.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height)
    End Sub

    Private Sub menuPlaceinCorner_Click(sender As Object, e As EventArgs) Handles menuPlaceinCorner.Click
        If menuShowHistory.Text = "Show History and Saved Window" Then
            'History form not open
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
            frmHistory.Hide()
        Else
            'History form open
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - frmHistory.Height - Me.Height)
            frmHistory.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - frmHistory.Width, Screen.PrimaryScreen.WorkingArea.Height - frmHistory.Height)
            frmHistory.Show()
        End If
    End Sub

    Private Sub frmMain_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If WindowState = FormWindowState.Normal Then
            If menuShowHistory.Text = "Hide History and Saved Window" Then
                frmHistory.TopMost = True
                Me.TopMost = True
                frmHistory.TopMost = False
            End If

        End If
    End Sub

    Private Sub menuClearSavedData_Click(sender As Object, e As EventArgs) Handles menuClearSavedData.Click
        If MsgBox("This program currently saves:" & vbNewLine & "- If History and Saved information dialog was dismissed" & vbNewLine & "- Up to six saved conversions" & vbNewLine & "- Stay on Top was activated when program closed in last session" & vbNewLine & "- History and Saved window was open when program closed in last session" & vbNewLine & vbNewLine & "This process will reset the program to its default state, including the clearing of saves and history." & vbNewLine & vbNewLine & "Would you like to clear this data from your system?", MsgBoxStyle.YesNoCancel, "Clear Saved Program Data?") = MsgBoxResult.Yes Then
            ' Reset settings
            My.Settings.Reset()
            My.Settings.Save()
            ' Clear lists
            frmHistory.lstSaved.Items.Clear()
            frmHistory.lstHistory.Items.Clear()
            ' Clear textboxes
            txtCentimetres.Clear()
            txtInches.Clear()
            txtMillimetres.Clear()
            txtMils.Clear()
            ' Disable Stay on Top
            If menuStayonTop.Checked = True Then
                menuStayonTop_Click(Nothing, Nothing)
            End If
            ' Close Save and History window
            If menuShowHistory.Text = "Hide History and Saved Window" Then
                menuShowHistory_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If frmHistory.Visible = True Then
            My.Settings.HistoryDefaultOpen = True
        Else
            My.Settings.HistoryDefaultOpen = False
        End If

        If menuStayonTop.Checked = True Then
            My.Settings.OnTopDefault = True
        Else
            My.Settings.OnTopDefault = False
        End If

        If frmHistory.lstSaved.Items.Count > 0 Then
            My.Settings.Save1 = frmHistory.lstSaved.Items.Item(0)
        End If
        If frmHistory.lstSaved.Items.Count > 1 Then
            My.Settings.Save2 = frmHistory.lstSaved.Items.Item(1)
        End If
        If frmHistory.lstSaved.Items.Count > 2 Then
            My.Settings.Save3 = frmHistory.lstSaved.Items.Item(2)
        End If
        If frmHistory.lstSaved.Items.Count > 3 Then
            My.Settings.Save4 = frmHistory.lstSaved.Items.Item(3)
        End If
        If frmHistory.lstSaved.Items.Count > 4 Then
            My.Settings.Save5 = frmHistory.lstSaved.Items.Item(4)
        End If
        If frmHistory.lstSaved.Items.Count > 5 Then
            My.Settings.Save6 = frmHistory.lstSaved.Items.Item(5)
        End If

        My.Settings.Save()

    End Sub

    Private Sub menuShowHistoryDialog_Click(sender As Object, e As EventArgs)

    End Sub
End Class
