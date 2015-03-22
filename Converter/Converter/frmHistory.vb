Public Class frmHistory

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.HistoryInfoDismissed = True Then
            lblHistoryIntro_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub frmHistory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        frmMain.menuShowHistory.Text = "Show History and Saved Window"

        ' Put main form back in corner only if user didn't move it anywhere else.
        If frmMain.Location.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width And frmMain.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - frmMain.Height - Me.Height Then
            frmMain.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - frmMain.Width, Screen.PrimaryScreen.WorkingArea.Height - frmMain.Height)
        End If

        Me.Hide()
    End Sub

    Private Sub lstHistory_DoubleClick(sender As Object, e As EventArgs) Handles lstHistory.DoubleClick
        lstSaved.Items.Insert(0, lstHistory.SelectedItem)
    End Sub

    Private Sub lstSaved_DoubleClick(sender As Object, e As EventArgs) Handles lstSaved.DoubleClick
        lstSaved.Items.Remove(lstSaved.SelectedItem)
    End Sub

    Private Sub lblHistoryIntro_Click(sender As Object, e As EventArgs) Handles lblHistoryIntro.Click
        My.Settings.HistoryInfoDismissed = True
        My.Settings.Save()
        My.Settings.Reload()

        ' Put back in corner only if user didn't move it anywhere else.
        If frmMain.Location.X = Screen.PrimaryScreen.WorkingArea.Width - frmMain.Width And frmMain.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - frmMain.Height Then
            Me.Height = Me.Height - lblHistoryIntro.Height
            lblHistoryIntro.Hide()
            panelSaved.Dock = DockStyle.Top
            frmMain.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - frmMain.Width, Screen.PrimaryScreen.WorkingArea.Height - frmMain.Height - Me.Height)
        Else
            Me.Height = Me.Height - lblHistoryIntro.Height
            lblHistoryIntro.Hide()
            panelSaved.Dock = DockStyle.Top
        End If


    End Sub

    Private Sub frmHistory_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Location = New Point(frmMain.Location.X, frmMain.Location.Y + frmMain.Height)
    End Sub

    Private Sub lstSaved_KeyDown(sender As Object, e As KeyEventArgs) Handles lstSaved.KeyDown
        Dim selected As String = lstSaved.SelectedItem
        Dim position As Integer = lstSaved.SelectedIndex

        If e.KeyCode = Keys.Up Then
            ' Don't move if item is already at the top.
            If position > 0 Then
                lstSaved.Items.Remove(lstSaved.SelectedItem)
                lstSaved.Items.Insert(position - 1, selected)
            End If
        End If

        If e.KeyCode = Keys.Down Then
            ' Don't move if item is already at the bottom.
            If position < lstSaved.Items.Count - 1 Then
                lstSaved.Items.Remove(lstSaved.SelectedItem)
                lstSaved.Items.Insert(position + 1, selected)
                lstSaved.SetSelected(position, True)
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            lstSaved.Items.Remove(lstSaved.SelectedItem)
        End If
    End Sub
End Class