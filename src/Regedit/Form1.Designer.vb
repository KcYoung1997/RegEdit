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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CURRENT_USER")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_USERS")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CURRENT_CONFIG")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.folderView = New System.Windows.Forms.TreeView()
        Me.folderIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.listView = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'folderView
        '
        Me.folderView.Dock = System.Windows.Forms.DockStyle.Left
        Me.folderView.ImageIndex = 0
        Me.folderView.ImageList = Me.folderIcons
        Me.folderView.Location = New System.Drawing.Point(0, 0)
        Me.folderView.Name = "folderView"
        TreeNode1.Name = "HKEY_CLASSES_ROOT"
        TreeNode1.Text = "HKEY_CLASSES_ROOT"
        TreeNode2.Name = "HKEY_CURRENT_USER"
        TreeNode2.Text = "HKEY_CURRENT_USER"
        TreeNode3.Name = "HKEY_LOCAL_MACHINE"
        TreeNode3.Text = "HKEY_LOCAL_MACHINE"
        TreeNode4.Name = "HKEY_USERS"
        TreeNode4.Text = "HKEY_USERS"
        TreeNode5.Name = "HKEY_CURRENT_CONFIG"
        TreeNode5.Text = "HKEY_CURRENT_CONFIG"
        Me.folderView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Me.folderView.SelectedImageIndex = 0
        Me.folderView.ShowNodeToolTips = True
        Me.folderView.Size = New System.Drawing.Size(195, 514)
        Me.folderView.TabIndex = 1
        '
        'folderIcons
        '
        Me.folderIcons.ImageStream = CType(resources.GetObject("folderIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.folderIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.folderIcons.Images.SetKeyName(0, "Folder.png")
        '
        'listView
        '
        Me.listView.AllowDrop = True
        Me.listView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3})
        Me.listView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView.FullRowSelect = True
        Me.listView.GridLines = True
        Me.listView.LabelEdit = True
        Me.listView.Location = New System.Drawing.Point(195, 0)
        Me.listView.Name = "listView"
        Me.listView.ShowItemToolTips = True
        Me.listView.Size = New System.Drawing.Size(447, 514)
        Me.listView.TabIndex = 2
        Me.listView.UseCompatibleStateImageBehavior = False
        Me.listView.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Name"
        Me.columnHeader1.Width = 150
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Type"
        Me.columnHeader2.Width = 100
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Data"
        Me.columnHeader3.Width = 521
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 514)
        Me.Controls.Add(Me.listView)
        Me.Controls.Add(Me.folderView)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Registry Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents folderView As System.Windows.Forms.TreeView
    Private WithEvents listView As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents folderIcons As System.Windows.Forms.ImageList

End Class
