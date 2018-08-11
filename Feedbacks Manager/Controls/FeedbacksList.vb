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



End Class
