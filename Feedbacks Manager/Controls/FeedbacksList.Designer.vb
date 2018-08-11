<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedbacksList
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gc_Data = New DevExpress.XtraGrid.GridControl()
        Me.gv_Data = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gc_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_Data
        '
        Me.gc_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Data.Location = New System.Drawing.Point(0, 0)
        Me.gc_Data.MainView = Me.gv_Data
        Me.gc_Data.Name = "gc_Data"
        Me.gc_Data.Size = New System.Drawing.Size(412, 302)
        Me.gc_Data.TabIndex = 0
        Me.gc_Data.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Data})
        '
        'gv_Data
        '
        Me.gv_Data.GridControl = Me.gc_Data
        Me.gv_Data.Name = "gv_Data"
        Me.gv_Data.OptionsBehavior.ReadOnly = True
        '
        'FeedbacksList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gc_Data)
        Me.Name = "FeedbacksList"
        Me.Size = New System.Drawing.Size(412, 302)
        CType(Me.gc_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gc_Data As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Data As DevExpress.XtraGrid.Views.Grid.GridView
End Class
