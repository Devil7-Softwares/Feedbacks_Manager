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

Imports RestSharp

Namespace Classes
    Module Feedbacks

        Function GetAll() As List(Of Feedback)
            Dim R As New List(Of Feedback)

            Try
                Dim client = New RestClient(Misc.GetURL)
                Dim request = New RestRequest(Method.[GET])
                request.AddHeader("cache-control", "no-cache")
                request.AddHeader("x-apikey", Encryption.Decrypt(SettingsManager.Settings.API_KEY))
                request.AddHeader("content-type", "application/json")
                Dim response As IRestResponse = client.Execute(request)
                If response.ContentType.Contains("application/json") AndAlso response.Content.ToString <> "" Then
                    R = Feedback.ParseJSonList(response.Content)
                End If
            Catch ex As Exception

            End Try

            Return R
        End Function

        Function Edit(ByVal FeedBack As Feedback) As Boolean
            Try
                Dim client = New RestClient(String.Format("{0}/{1}", GetURL.TrimEnd("/"), FeedBack._id))
                Dim request = New RestRequest(Method.PUT)
                request.AddHeader("cache-control", "no-cache")
                request.AddHeader("x-apikey", Encryption.Decrypt(SettingsManager.Settings.API_KEY))
                request.AddHeader("content-type", "application/json")
                request.AddParameter("application/json", FeedBack.ToJSon, ParameterType.RequestBody)
                Dim response As IRestResponse = client.Execute(request)
                Return (response.StatusCode = Net.HttpStatusCode.OK)
            Catch ex As Exception
                Return False
            End Try
        End Function

        Function Remove(ByVal Feedback As Feedback) As Boolean
            Try
                Dim client = New RestClient(String.Format("{0}/{1}", GetURL.TrimEnd("/"), Feedback._id))
                Dim request = New RestRequest(Method.DELETE)
                request.AddHeader("cache-control", "no-cache")
                request.AddHeader("x-apikey", Encryption.Decrypt(SettingsManager.Settings.API_KEY))
                request.AddHeader("content-type", "application/json")
                Dim response As IRestResponse = client.Execute(request)
                Return (response.StatusCode = Net.HttpStatusCode.OK)
            Catch ex As Exception
                Return False
            End Try
        End Function

    End Module
End Namespace