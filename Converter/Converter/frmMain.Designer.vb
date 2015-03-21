<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStayonTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConversion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInchtoCm = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMilstoMm = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelIntoCm = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.txtCentimetres = New System.Windows.Forms.TextBox()
        Me.panelMilstoMm = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMils = New System.Windows.Forms.TextBox()
        Me.txtMillimetres = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stripAlert = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.panelIntoCm.SuspendLayout()
        Me.panelMilstoMm.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuConversion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(212, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuStayonTop, Me.menuExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "File"
        '
        'menuStayonTop
        '
        Me.menuStayonTop.Name = "menuStayonTop"
        Me.menuStayonTop.Size = New System.Drawing.Size(137, 22)
        Me.menuStayonTop.Text = "Stay on Top"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(137, 22)
        Me.menuExit.Text = "Exit"
        '
        'menuConversion
        '
        Me.menuConversion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInchtoCm, Me.menuMilstoMm})
        Me.menuConversion.Name = "menuConversion"
        Me.menuConversion.Size = New System.Drawing.Size(79, 20)
        Me.menuConversion.Text = "Conversion"
        '
        'menuInchtoCm
        '
        Me.menuInchtoCm.Name = "menuInchtoCm"
        Me.menuInchtoCm.Size = New System.Drawing.Size(199, 22)
        Me.menuInchtoCm.Text = "Inches <-> Centimetres"
        '
        'menuMilstoMm
        '
        Me.menuMilstoMm.Name = "menuMilstoMm"
        Me.menuMilstoMm.Size = New System.Drawing.Size(183, 22)
        Me.menuMilstoMm.Text = "Mils <-> Millimetres"
        '
        'panelIntoCm
        '
        Me.panelIntoCm.Controls.Add(Me.Label6)
        Me.panelIntoCm.Controls.Add(Me.Label1)
        Me.panelIntoCm.Controls.Add(Me.Label2)
        Me.panelIntoCm.Controls.Add(Me.txtInches)
        Me.panelIntoCm.Controls.Add(Me.txtCentimetres)
        Me.panelIntoCm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelIntoCm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelIntoCm.Location = New System.Drawing.Point(0, 24)
        Me.panelIntoCm.Name = "panelIntoCm"
        Me.panelIntoCm.Size = New System.Drawing.Size(212, 66)
        Me.panelIntoCm.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Inches to Centimetres"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inches"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Centimetres"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(3, 39)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(100, 20)
        Me.txtInches.TabIndex = 0
        '
        'txtCentimetres
        '
        Me.txtCentimetres.Location = New System.Drawing.Point(109, 39)
        Me.txtCentimetres.Name = "txtCentimetres"
        Me.txtCentimetres.Size = New System.Drawing.Size(100, 20)
        Me.txtCentimetres.TabIndex = 2
        '
        'panelMilstoMm
        '
        Me.panelMilstoMm.Controls.Add(Me.Label5)
        Me.panelMilstoMm.Controls.Add(Me.Label3)
        Me.panelMilstoMm.Controls.Add(Me.Label4)
        Me.panelMilstoMm.Controls.Add(Me.txtMils)
        Me.panelMilstoMm.Controls.Add(Me.txtMillimetres)
        Me.panelMilstoMm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMilstoMm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelMilstoMm.Location = New System.Drawing.Point(0, 24)
        Me.panelMilstoMm.Name = "panelMilstoMm"
        Me.panelMilstoMm.Size = New System.Drawing.Size(212, 66)
        Me.panelMilstoMm.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mils to Millimetres"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mils"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Millimetres"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMils
        '
        Me.txtMils.Location = New System.Drawing.Point(3, 39)
        Me.txtMils.Name = "txtMils"
        Me.txtMils.Size = New System.Drawing.Size(100, 20)
        Me.txtMils.TabIndex = 0
        '
        'txtMillimetres
        '
        Me.txtMillimetres.Location = New System.Drawing.Point(109, 39)
        Me.txtMillimetres.Name = "txtMillimetres"
        Me.txtMillimetres.Size = New System.Drawing.Size(100, 20)
        Me.txtMillimetres.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripAlert})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 90)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(212, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stripAlert
        '
        Me.stripAlert.Name = "stripAlert"
        Me.stripAlert.Size = New System.Drawing.Size(0, 17)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 112)
        Me.Controls.Add(Me.panelIntoCm)
        Me.Controls.Add(Me.panelMilstoMm)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Converter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelIntoCm.ResumeLayout(False)
        Me.panelIntoCm.PerformLayout()
        Me.panelMilstoMm.ResumeLayout(False)
        Me.panelMilstoMm.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuStayonTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelIntoCm As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInches As System.Windows.Forms.TextBox
    Friend WithEvents txtCentimetres As System.Windows.Forms.TextBox
    Friend WithEvents panelMilstoMm As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMils As System.Windows.Forms.TextBox
    Friend WithEvents txtMillimetres As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stripAlert As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuConversion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInchtoCm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMilstoMm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
