Public Class frm_Main

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Classes.SettingsManager.LoadSettings()
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Classes.SettingsManager.SaveSettings()
    End Sub

    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Classes.SettingsManager.Settings.API_KEY = "" Then
            If frm_Settings.ShowDialog <> DialogResult.OK Then
                Exit Sub
            End If
        End If
        If Not BackgroundLoader.IsBusy Then BackgroundLoader.RunWorkerAsync()
    End Sub

    Private Sub BackgroundLoader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundLoader.DoWork
        Me.Invoke(Sub()
                      rpg_Data.Enabled = False
                      ProgressPanel_Loading.Visible = True
                  End Sub)

        Dim List As List(Of Classes.Feedback) = Classes.Feedbacks.GetAll

        Do Until MainTab.TabPages.Count = 0
            Dim Page As DevExpress.XtraTab.XtraTabPage = MainTab.TabPages(0)
            Me.Invoke(Sub()
                          MainTab.TabPages.Remove(Page)
                          Page.Dispose()
                      End Sub)
        Loop

        If btn_SeparateByApp.Down Then
            For Each i As Classes.Feedback In List
                Dim Name As String = i.AppName
                Dim Tab As DevExpress.XtraTab.XtraTabPage = MainTab.TabPages.ToList.Find(Function(c) c.Text = Name)
                If Tab Is Nothing Then
                    Dim TmpList As New List(Of Classes.Feedback)
                    TmpList.Add(i)
                    Me.Invoke(Sub() AddPage(TmpList, Name))
                Else
                    Dim Control As Control = Tab.Controls(0)
                    If TypeOf Control Is Controls.FeedbacksList Then
                        Me.Invoke(Sub() CType(Control, Controls.FeedbacksList).List.Add(i))
                    End If
                End If
            Next
        Else
            Me.Invoke(Sub() AddPage(List))
        End If

        Me.Invoke(Sub()
                      rpg_Data.Enabled = True
                      ProgressPanel_Loading.Visible = False
                  End Sub)
    End Sub

    Sub AddPage(ByVal List As List(Of Classes.Feedback), Optional TabName As String = "All")
        Dim Tab As DevExpress.XtraTab.XtraTabPage = MainTab.TabPages.Add(TabName)
        Tab.Controls.Add(New Controls.FeedbacksList With {.Dock = DockStyle.Fill, .List = List, .HideAppName = Not (TabName = "All")})
    End Sub

    Private Sub btn_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        If Not BackgroundLoader.IsBusy Then BackgroundLoader.RunWorkerAsync()
    End Sub
End Class