<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbxGameCover = New System.Windows.Forms.PictureBox()
        Me.lblGameDesc = New System.Windows.Forms.Label()
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxGameCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(505, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.AccessibleName = ""
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(81, 34)
        Me.mnuClose.Text = "&Close"
        '
        'pbxGameCover
        '
        Me.pbxGameCover.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxGameCover.Location = New System.Drawing.Point(12, 48)
        Me.pbxGameCover.Name = "pbxGameCover"
        Me.pbxGameCover.Size = New System.Drawing.Size(234, 358)
        Me.pbxGameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGameCover.TabIndex = 1
        Me.pbxGameCover.TabStop = False
        '
        'lblGameDesc
        '
        Me.lblGameDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGameDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGameDesc.Location = New System.Drawing.Point(262, 84)
        Me.lblGameDesc.Name = "lblGameDesc"
        Me.lblGameDesc.Size = New System.Drawing.Size(223, 322)
        Me.lblGameDesc.TabIndex = 2
        Me.lblGameDesc.Text = "Label1"
        Me.lblGameDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGameName
        '
        Me.lblGameName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGameName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGameName.Location = New System.Drawing.Point(262, 48)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(223, 24)
        Me.lblGameName.TabIndex = 3
        Me.lblGameName.Text = "Label2"
        Me.lblGameName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmGame
        '
        Me.ClientSize = New System.Drawing.Size(505, 427)
        Me.Controls.Add(Me.lblGameName)
        Me.Controls.Add(Me.lblGameDesc)
        Me.Controls.Add(Me.pbxGameCover)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxGameCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Public WithEvents lblGameDesc As Label
    Public WithEvents pbxGameCover As PictureBox
    Public WithEvents lblGameName As Label
End Class
