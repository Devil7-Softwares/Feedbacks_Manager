<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
    Inherits Classes.XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Key = New DevExpress.XtraEditors.TextEdit()
        Me.txt_BaseURL = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CollectionName = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Key.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BaseURL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CollectionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(80, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "API Key :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(73, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Base URL :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Collection/Table Name :"
        '
        'txt_Key
        '
        Me.txt_Key.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Key.EnterMoveNextControl = True
        Me.txt_Key.Location = New System.Drawing.Point(131, 9)
        Me.txt_Key.Name = "txt_Key"
        Me.txt_Key.Size = New System.Drawing.Size(273, 20)
        Me.txt_Key.TabIndex = 0
        '
        'txt_BaseURL
        '
        Me.txt_BaseURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BaseURL.EnterMoveNextControl = True
        Me.txt_BaseURL.Location = New System.Drawing.Point(131, 35)
        Me.txt_BaseURL.Name = "txt_BaseURL"
        Me.txt_BaseURL.Size = New System.Drawing.Size(273, 20)
        Me.txt_BaseURL.TabIndex = 1
        '
        'txt_CollectionName
        '
        Me.txt_CollectionName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CollectionName.EnterMoveNextControl = True
        Me.txt_CollectionName.Location = New System.Drawing.Point(131, 61)
        Me.txt_CollectionName.Name = "txt_CollectionName"
        Me.txt_CollectionName.Size = New System.Drawing.Size(273, 20)
        Me.txt_CollectionName.TabIndex = 2
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(329, 87)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 32)
        Me.btn_Save.TabIndex = 3
        Me.btn_Save.Text = "Save"
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 129)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_CollectionName)
        Me.Controls.Add(Me.txt_BaseURL)
        Me.Controls.Add(Me.txt_Key)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Settings"
        Me.Text = "Settings"
        CType(Me.txt_Key.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BaseURL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CollectionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Key As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_BaseURL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CollectionName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
End Class
