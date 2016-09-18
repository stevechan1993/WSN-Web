


Class simpleMessageList

    Public messagesList() As String = New String(50) {}
    Public messagesLast As Integer = -1
    Private messagesLock As New Object
    Public Sub addAnotherMessage(ByVal newMessage As String)
        SyncLock messagesLock
            messagesLast += 1
            messagesList(messagesLast) = newMessage
        End SyncLock
    End Sub

End Class

