<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ftpBrowser
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("FTP Server")
        Me.lblstatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tvserver = New System.Windows.Forms.TreeView()
        Me.lblstatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblstatus
        '
        Me.lblstatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.lblstatus.Location = New System.Drawing.Point(0, 343)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(612, 25)
        Me.lblstatus.TabIndex = 10
        Me.lblstatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'tvserver
        '
        Me.tvserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvserver.Location = New System.Drawing.Point(8, 12)
        Me.tvserver.Name = "tvserver"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "FTP Server"
        Me.tvserver.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvserver.Size = New System.Drawing.Size(592, 328)
        Me.tvserver.TabIndex = 9
        Me.tvserver.Tag = ""
        '
        'ftpBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 368)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.tvserver)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ftpBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ftpBrowser"
        Me.lblstatus.ResumeLayout(False)
        Me.lblstatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tvserver As System.Windows.Forms.TreeView
End Class
