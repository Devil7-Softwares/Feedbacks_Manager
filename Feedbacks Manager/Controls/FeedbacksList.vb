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

        Public Event StatusChanged(ByVal sender As Object, ByVal StatusText As String)

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

        Sub DeleteSelected()
            Try
                If gv_Data.SelectedRowsCount > 0 Then
                    If MsgBox("Are you sure...? Do you want to delete selected rows...?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Error") = MsgBoxResult.Yes Then
                        RaiseEvent StatusChanged(Me, "Deleting items...")
                        Application.DoEvents()
                        Dim Selected As Integer() = gv_Data.GetSelectedRows
                        For Each i As Integer In Selected
                            Dim Feedback As Classes.Feedback = gv_Data.GetRow(i)
                            If Classes.Feedbacks.Remove(Feedback) Then
                                List.Remove(Feedback)
                            End If
                        Next
                        gc_Data.RefreshDataSource()
                        RaiseEvent StatusChanged(Me, "Succesfully detelted items.")
                    End If
                End If
            Catch ex As Exception
                RaiseEvent StatusChanged(Me, "Failed to delete items...!")
            End Try
        End Sub

        Private Sub gv_Data_KeyUp(sender As Object, e As KeyEventArgs) Handles gv_Data.KeyUp
            If e.KeyData = Keys.Delete Then
                DeleteSelected()
            End If
        End Sub

    End Class
End Namespace