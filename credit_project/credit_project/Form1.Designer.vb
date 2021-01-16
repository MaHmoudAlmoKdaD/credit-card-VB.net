<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.BorrowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestAcceptedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestclientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerToolStripMenuItem, Me.SessionToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.MainToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BorrowerToolStripMenuItem
        '
        Me.BorrowerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1})
        Me.BorrowerToolStripMenuItem.Name = "BorrowerToolStripMenuItem"
        Me.BorrowerToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.BorrowerToolStripMenuItem.Text = "Person"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'SessionToolStripMenuItem
        '
        Me.SessionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem2})
        Me.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem"
        Me.SessionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SessionToolStripMenuItem.Text = "Session"
        '
        'OpenToolStripMenuItem2
        '
        Me.OpenToolStripMenuItem2.Name = "OpenToolStripMenuItem2"
        Me.OpenToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem2.Text = "Open"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem3})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'OpenToolStripMenuItem3
        '
        Me.OpenToolStripMenuItem3.Name = "OpenToolStripMenuItem3"
        Me.OpenToolStripMenuItem3.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem3.Text = "Open"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestsToolStripMenuItem, Me.RequestAcceptedToolStripMenuItem, Me.RequestclientToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportToolStripMenuItem.Text = "Reports"
        '
        'RequestsToolStripMenuItem
        '
        Me.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem"
        Me.RequestsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RequestsToolStripMenuItem.Text = "Requests"
        '
        'RequestAcceptedToolStripMenuItem
        '
        Me.RequestAcceptedToolStripMenuItem.Name = "RequestAcceptedToolStripMenuItem"
        Me.RequestAcceptedToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RequestAcceptedToolStripMenuItem.Text = "Request accepted"
        '
        'RequestclientToolStripMenuItem
        '
        Me.RequestclientToolStripMenuItem.Name = "RequestclientToolStripMenuItem"
        Me.RequestclientToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RequestclientToolStripMenuItem.Text = "Request/ Person"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "MAIN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestAcceptedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestclientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
