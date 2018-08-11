'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports System.Xml.Serialization

Namespace Classes
    Public Module SettingsManager

        Dim ConfigFilePath As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Settings.config")

        Dim Settings_ As SettingsBase
        ReadOnly Property Settings As SettingsBase
            Get
                If Settings_ Is Nothing Then
                    LoadSettings()
                End If
                Return Settings_
            End Get
        End Property


        Sub LoadSettings()
            Try
                If My.Computer.FileSystem.FileExists(ConfigFilePath) Then
                    Dim XS As New XmlSerializer(GetType(SettingsBase))
                    Settings_ = XS.Deserialize(New IO.FileStream(ConfigFilePath, IO.FileMode.Open))
                Else
                    Settings_ = New SettingsBase
                End If
            Catch ex As Exception

            End Try
        End Sub

        Sub SaveSettings()
            Try
                Dim XS As New XmlSerializer(GetType(SettingsBase))

                If Not My.Computer.FileSystem.DirectoryExists((New IO.FileInfo(ConfigFilePath)).Directory.FullName) Then
                    My.Computer.FileSystem.CreateDirectory((New IO.FileInfo(ConfigFilePath)).Directory.FullName)
                End If

                Using Stream As New IO.FileStream(ConfigFilePath, IO.FileMode.Create)
                    XS.Serialize(Stream, Settings_)
                End Using
            Catch ex As Exception

            End Try
        End Sub

        Class SettingsBase
            Property API_KEY As String
            Property BASE_URL As String
            Property COLLECTION_NAME As String
        End Class

    End Module
End Namespace