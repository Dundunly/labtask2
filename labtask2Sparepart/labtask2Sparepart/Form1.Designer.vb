<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BLOGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTACTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.STOREToolStripMenuItem, Me.BLOGToolStripMenuItem, Me.CONTACTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'STOREToolStripMenuItem
        '
        Me.STOREToolStripMenuItem.Name = "STOREToolStripMenuItem"
        Me.STOREToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.STOREToolStripMenuItem.Text = "STORE"
        '
        'BLOGToolStripMenuItem
        '
        Me.BLOGToolStripMenuItem.Name = "BLOGToolStripMenuItem"
        Me.BLOGToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.BLOGToolStripMenuItem.Text = "BLOG "
        '
        'CONTACTToolStripMenuItem
        '
        Me.CONTACTToolStripMenuItem.Name = "CONTACTToolStripMenuItem"
        Me.CONTACTToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.CONTACTToolStripMenuItem.Text = "CONTACT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 505)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BLOGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTACTToolStripMenuItem As ToolStripMenuItem
End Class
