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

Namespace Controls
    Public Class FeedbacksList

        Property List As List(Of Classes.Feedback)
            Get
                If gc_Data.DataSource Is Nothing Then
                    gc_Data.DataSource = New List(Of Classes.Feedback)
                End If
                Return gc_Data.DataSource
            End Get
            Set(value As List(Of Classes.Feedback))
                gc_Data.DataSource = value
                gc_Data.RefreshDataSource()

                If HideAppName Then
                    gv_Data.Columns("AppName").Visible = False
                Else
                    gv_Data.Columns("AppName").Visible = True
                End If
            End Set
        End Property

        ReadOnly Property SelectedItemsCount As Integer
            Get
                Return gv_Data.SelectedRowsCount
            End Get
        End Property

        Function GetSelectedItems() As List(Of Classes.Feedback)
            Dim R As New List(Of Classes.Feedback)

            For Each i As Integer In gv_Data.GetSelectedRows
                R.Add(gv_Data.GetRow(i))
            Next

            Return R
        End Function

        Dim HideAppName_ As Boolean
        Property HideAppName As Boolean
            Get
                Return HideAppName_
            End Get
            Set(value As Boolean)
                HideAppName_ = value

                Try
                    If value Then
                        gv_Data.Columns("AppName").Visible = False
                    Else
                        gv_Data.Columns("AppName").Visible = True
                    End If
                Catch ex As Exception

                End Try
            End Set
        End Property

    End Class
End Namespace