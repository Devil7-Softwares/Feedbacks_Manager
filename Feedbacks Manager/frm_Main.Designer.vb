<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btn_SeparateByApp = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Data = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Skin = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.MainTab = New DevExpress.XtraTab.XtraTabControl()
        Me.ProgressPanel_Loading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.BackgroundLoader = New System.ComponentModel.BackgroundWorker()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Refresh, Me.btn_Remove, Me.SkinRibbonGalleryBarItem1, Me.btn_SeparateByApp})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.Size = New System.Drawing.Size(442, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Caption = "Refresh"
        Me.btn_Refresh.Id = 1
        Me.btn_Refresh.ImageOptions.SvgImage = Global.Feedbacks_Manager.My.Resources.Resources.refresh
        Me.btn_Refresh.Name = "btn_Refresh"
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove Selected"
        Me.btn_Remove.Id = 2
        Me.btn_Remove.ImageOptions.SvgImage = Global.Feedbacks_Manager.My.Resources.Resources.remove
        Me.btn_Remove.Name = "btn_Remove"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 3
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btn_SeparateByApp
        '
        Me.btn_SeparateByApp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_SeparateByApp.Caption = "Separate By App"
        Me.btn_SeparateByApp.Down = True
        Me.btn_SeparateByApp.Id = 4
        Me.btn_SeparateByApp.ImageOptions.SvgImage = Global.Feedbacks_Manager.My.Resources.Resources.separate
        Me.btn_SeparateByApp.Name = "btn_SeparateByApp"
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Data, Me.rpg_Skin})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_Data
        '
        Me.rpg_Data.ItemLinks.Add(Me.btn_Refresh)
        Me.rpg_Data.ItemLinks.Add(Me.btn_SeparateByApp, True)
        Me.rpg_Data.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_Data.Name = "rpg_Data"
        Me.rpg_Data.ShowCaptionButton = False
        Me.rpg_Data.Text = "Data"
        '
        'rpg_Skin
        '
        Me.rpg_Skin.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.rpg_Skin.Name = "rpg_Skin"
        Me.rpg_Skin.Text = "Skin"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'MainTab
        '
        Me.MainTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTab.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.MainTab.Location = New System.Drawing.Point(0, 143)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Size = New System.Drawing.Size(442, 275)
        Me.MainTab.TabIndex = 2
        '
        'ProgressPanel_Loading
        '
        Me.ProgressPanel_Loading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Loading.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Loading.BarAnimationElementThickness = 2
        Me.ProgressPanel_Loading.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Loading.Description = "Loading/Refreshing Data..."
        Me.ProgressPanel_Loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Loading.Location = New System.Drawing.Point(0, 143)
        Me.ProgressPanel_Loading.Name = "ProgressPanel_Loading"
        Me.ProgressPanel_Loading.Size = New System.Drawing.Size(442, 275)
        Me.ProgressPanel_Loading.TabIndex = 5
        '
        'BackgroundLoader
        '
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.Controls.Add(Me.ProgressPanel_Loading)
        Me.Controls.Add(Me.MainTab)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frm_Main"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Data As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents MainTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rpg_Skin As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ProgressPanel_Loading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents BackgroundLoader As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_SeparateByApp As DevExpress.XtraBars.BarButtonItem
End Class
