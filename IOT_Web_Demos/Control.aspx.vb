Imports System.Net.Sockets
Imports System.Net

Public Class Control
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

    End Sub

    Protected Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Try
            Dim bytes(1024) As Byte
            Dim bytesBack(3) As Byte
            Dim s2 = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim localEndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024)
            s2.Connect(localEndPoint)
            s2.Send(Encoding.Unicode.GetBytes(TextBox1.Text))
            s2.Receive(bytesBack)
            TextBox2.Text = Encoding.Unicode.GetString(bytesBack)
            s2.Close()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub BtnLed_Click(sender As Object, e As EventArgs) Handles BtnLed.Click
        Try
            Dim sendStr_1 As String
            sendStr_1 = "L"
            Dim bytes(1024) As Byte
            Dim bytesBack(3) As Byte
            Dim s2 = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim localEndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024)
            s2.Connect(localEndPoint)
            s2.Send(Encoding.Unicode.GetBytes(sendStr_1))
            's2.Receive(bytesBack)
            'TextBox2.Text = Encoding.Unicode.GetString(bytesBack)
            s2.Close()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub BtnRelay_Click(sender As Object, e As EventArgs) Handles BtnRelay.Click
        Try
            Dim sendStr_2 As String
            sendStr_2 = "R"
            Dim bytes(1024) As Byte
            Dim bytesBack(3) As Byte
            Dim s2 = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim localEndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024)
            s2.Connect(localEndPoint)
            s2.Send(Encoding.Unicode.GetBytes(sendStr_2))
            's2.Receive(bytesBack)
            'TextBox2.Text = Encoding.Unicode.GetString(bytesBack)
            s2.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class