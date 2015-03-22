<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.panelHistory = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.lblHistoryIntro = New System.Windows.Forms.Label()
        Me.lstSaved = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelSaved = New System.Windows.Forms.Panel()
        Me.panelHistory.SuspendLayout()
        Me.panelSaved.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHistory
        '
        Me.panelHistory.Controls.Add(Me.Label1)
        Me.panelHistory.Controls.Add(Me.lstHistory)
        Me.panelHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelHistory.Location = New System.Drawing.Point(0, 255)
        Me.panelHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.panelHistory.Name = "panelHistory"
        Me.panelHistory.Size = New System.Drawing.Size(214, 204)
        Me.panelHistory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "History"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstHistory
        '
        Me.lstHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.Location = New System.Drawing.Point(0, 18)
        Me.lstHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.ScrollAlwaysVisible = True
        Me.lstHistory.Size = New System.Drawing.Size(214, 186)
        Me.lstHistory.TabIndex = 7
        '
        'lblHistoryIntro
        '
        Me.lblHistoryIntro.BackColor = System.Drawing.Color.SkyBlue
        Me.lblHistoryIntro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistoryIntro.Location = New System.Drawing.Point(0, 0)
        Me.lblHistoryIntro.Name = "lblHistoryIntro"
        Me.lblHistoryIntro.Size = New System.Drawing.Size(214, 154)
        Me.lblHistoryIntro.TabIndex = 2
        Me.lblHistoryIntro.Text = resources.GetString("lblHistoryIntro.Text")
        Me.lblHistoryIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSaved
        '
        Me.lstSaved.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstSaved.FormattingEnabled = True
        Me.lstSaved.Location = New System.Drawing.Point(0, 19)
        Me.lstSaved.Margin = New System.Windows.Forms.Padding(0)
        Me.lstSaved.Name = "lstSaved"
        Me.lstSaved.ScrollAlwaysVisible = True
        Me.lstSaved.Size = New System.Drawing.Size(214, 82)
        Me.lstSaved.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SandyBrown
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Saved"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelSaved
        '
        Me.panelSaved.Controls.Add(Me.Label5)
        Me.panelSaved.Controls.Add(Me.lstSaved)
        Me.panelSaved.Location = New System.Drawing.Point(0, 154)
        Me.panelSaved.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSaved.Name = "panelSaved"
        Me.panelSaved.Size = New System.Drawing.Size(214, 101)
        Me.panelSaved.TabIndex = 0
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 459)
        Me.Controls.Add(Me.lblHistoryIntro)
        Me.Controls.Add(Me.panelHistory)
        Me.Controls.Add(Me.panelSaved)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(230, 498)
        Me.Name = "frmHistory"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "History & Saved"
        Me.panelHistory.ResumeLayout(False)
        Me.panelSaved.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelHistory As System.Windows.Forms.Panel
    Friend WithEvents lstHistory As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHistoryIntro As System.Windows.Forms.Label
    Friend WithEvents lstSaved As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panelSaved As System.Windows.Forms.Panel
End Class
