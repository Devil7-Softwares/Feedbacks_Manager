Public Class frm_Settings
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim Settings As Classes.SettingsManager.SettingsBase = Classes.SettingsManager.Settings
        Settings.API_KEY = Classes.Encryption.Encrypt(txt_Key.Text)
        Settings.BASE_URL = txt_BaseURL.Text
        Settings.COLLECTION_NAME = txt_CollectionName.Text

        Classes.SettingsManager.SaveSettings()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frm_Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Classes.SettingsManager.LoadSettings()
        Dim Settings As Classes.SettingsManager.SettingsBase = Classes.SettingsManager.Settings
        txt_Key.Text = Classes.Encryption.Decrypt(Settings.API_KEY)
        txt_BaseURL.Text = Settings.BASE_URL
        txt_CollectionName.Text = Settings.COLLECTION_NAME
    End Sub
End Class