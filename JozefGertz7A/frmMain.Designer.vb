<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuGames = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStellaris = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDivinity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOblivion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplaySpecials = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateSpecials = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGames, Me.mnuExit, Me.SpecialsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(552, 38)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuGames
        '
        Me.mnuGames.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStellaris, Me.mnuDivinity, Me.mnuOblivion})
        Me.mnuGames.Name = "mnuGames"
        Me.mnuGames.Size = New System.Drawing.Size(94, 34)
        Me.mnuGames.Text = "&Games"
        '
        'mnuStellaris
        '
        Me.mnuStellaris.Name = "mnuStellaris"
        Me.mnuStellaris.Size = New System.Drawing.Size(395, 40)
        Me.mnuStellaris.Text = "Stellaris"
        '
        'mnuDivinity
        '
        Me.mnuDivinity.Name = "mnuDivinity"
        Me.mnuDivinity.Size = New System.Drawing.Size(395, 40)
        Me.mnuDivinity.Text = "Divinity Original Sin: 2"
        '
        'mnuOblivion
        '
        Me.mnuOblivion.Name = "mnuOblivion"
        Me.mnuOblivion.Size = New System.Drawing.Size(395, 40)
        Me.mnuOblivion.Text = "The Elder Scrolls IV: Oblivion"
        '
        'mnuExit
        '
        Me.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(64, 34)
        Me.mnuExit.Text = "&Exit"
        '
        'SpecialsToolStripMenuItem
        '
        Me.SpecialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplaySpecials, Me.mnuUpdateSpecials})
        Me.SpecialsToolStripMenuItem.Name = "SpecialsToolStripMenuItem"
        Me.SpecialsToolStripMenuItem.Size = New System.Drawing.Size(105, 34)
        Me.SpecialsToolStripMenuItem.Text = "&Specials"
        '
        'mnuDisplaySpecials
        '
        Me.mnuDisplaySpecials.Name = "mnuDisplaySpecials"
        Me.mnuDisplaySpecials.Size = New System.Drawing.Size(315, 40)
        Me.mnuDisplaySpecials.Text = "Display Specials"
        '
        'mnuUpdateSpecials
        '
        Me.mnuUpdateSpecials.Name = "mnuUpdateSpecials"
        Me.mnuUpdateSpecials.Size = New System.Drawing.Size(315, 40)
        Me.mnuUpdateSpecials.Text = "Update Specials"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(552, 582)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "2020.07"
        Me.Text = " Jozef's Game Store"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuGames As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuStellaris As ToolStripMenuItem
    Friend WithEvents mnuDivinity As ToolStripMenuItem
    Friend WithEvents mnuOblivion As ToolStripMenuItem
    Friend WithEvents SpecialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDisplaySpecials As ToolStripMenuItem
    Friend WithEvents mnuUpdateSpecials As ToolStripMenuItem
End Class
