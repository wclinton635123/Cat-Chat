Public Class Chat_Screen

    Public Sub Chat_Screen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("You are connected to " & Connect_Screen.TextBox2.Text & ", Your Nickname is " & Connect_Screen.TextBox1.Text & ".")

    End Sub
End Class
