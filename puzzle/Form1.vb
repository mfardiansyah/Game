Public Class Form1
    Dim smt As String
    Dim acak As Integer
    Dim gambar As Object
    Dim timeleft As TimeSpan
    Dim starttime As DateTime
    Dim ttlMins As Integer
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Timer1.Enabled = True
        acak = Rnd() * 10
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Timer1.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = True
        Timer2.Interval = 1000
        Timer2.Enabled = True
        ttlMins = Integer.Parse(TextBox1.Text)
        starttime = Now.AddMinutes(ttlMins)
        timeleft = starttime.Subtract(Now)
        Label4.Text = Format(timeleft.Minutes, "#0") & " Mins" & " " & Format(timeleft.Seconds, "00") & " Secs"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button2.Text = "" Then
            gambar = Button1.BackgroundImage
            Button1.BackgroundImage = Button2.BackgroundImage
            Button2.BackgroundImage = gambar
            smt = Button1.Text
            Button1.Text = Button2.Text
            Button2.Text = smt
        ElseIf Button4.Text = "" Then
            gambar = Button1.BackgroundImage
            Button1.BackgroundImage = Button4.BackgroundImage
            Button4.BackgroundImage = gambar
            smt = Button1.Text
            Button1.Text = Button4.Text
            Button4.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button1.Text = "" Then
            gambar = Button2.BackgroundImage
            Button2.BackgroundImage = Button2.BackgroundImage
            Button1.BackgroundImage = gambar
            smt = Button2.Text
            Button2.Text = Button1.Text
            Button1.Text = smt
        ElseIf Button3.Text = "" Then
            gambar = Button2.BackgroundImage
            Button2.BackgroundImage = Button3.BackgroundImage
            Button3.BackgroundImage = gambar
            smt = Button2.Text
            Button2.Text = Button3.Text
            Button3.Text = smt
        ElseIf Button5.Text = "" Then
            gambar = Button5.BackgroundImage
            Button5.BackgroundImage = Button2.BackgroundImage
            Button2.BackgroundImage = gambar
            smt = Button5.Text
            Button5.Text = Button2.Text
            Button2.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button2.Text = "" Then
            gambar = Button3.BackgroundImage
            Button3.BackgroundImage = Button2.BackgroundImage
            Button2.BackgroundImage = gambar
            smt = Button3.Text
            Button3.Text = Button2.Text
            Button2.Text = smt
        ElseIf Button6.Text = "" Then
            gambar = Button3.BackgroundImage
            Button3.BackgroundImage = Button6.BackgroundImage
            Button6.BackgroundImage = gambar
            smt = Button3.Text
            Button3.Text = Button6.Text
            Button6.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        gambar = Button9.BackgroundImage
        Button9.BackgroundImage = Button4.BackgroundImage
        Button4.BackgroundImage = gambar
        smt = Button9.Text
        Button9.Text = Button4.Text
        Button4.Text = smt
        gambar = Button9.BackgroundImage
        Button9.BackgroundImage = Button3.BackgroundImage
        Button3.BackgroundImage = gambar
        smt = Button9.Text
        Button9.Text = Button3.Text
        Button3.Text = smt
        gambar = Button2.BackgroundImage
        Button2.BackgroundImage = Button7.BackgroundImage
        Button7.BackgroundImage = gambar
        smt = Button2.Text
        Button2.Text = Button7.Text
        Button7.Text = smt
        gambar = Button2.BackgroundImage
        Button2.BackgroundImage = Button6.BackgroundImage
        Button6.BackgroundImage = gambar
        smt = Button2.Text
        Button2.Text = Button6.Text
        Button6.Text = smt
        gambar = Button3.BackgroundImage
        Button3.BackgroundImage = Button8.BackgroundImage
        Button8.BackgroundImage = gambar
        smt = Button3.Text
        Button3.Text = Button8.Text
        Button8.Text = smt
        gambar = Button3.BackgroundImage
        Button3.BackgroundImage = Button1.BackgroundImage
        Button1.BackgroundImage = gambar
        smt = Button3.Text
        Button3.Text = Button1.Text
        Button1.Text = smt
        gambar = Button5.BackgroundImage
        Button5.BackgroundImage = Button8.BackgroundImage
        Button8.BackgroundImage = gambar
        smt = Button5.Text
        Button5.Text = Button8.Text
        Button8.Text = smt
        gambar = Button5.BackgroundImage
        Button5.BackgroundImage = Button7.BackgroundImage
        Button7.BackgroundImage = gambar
        smt = Button5.Text
        Button5.Text = Button7.Text
        Button7.Text = smt
        gambar = Button6.BackgroundImage
        Button6.BackgroundImage = Button1.BackgroundImage
        Button1.BackgroundImage = gambar
        smt = Button6.Text
        Button6.Text = Button1.Text
        Button1.Text = smt
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button1.Text = "" Then
            gambar = Button4.BackgroundImage
            Button4.BackgroundImage = Button1.BackgroundImage
            Button1.BackgroundImage = gambar
            smt = Button4.Text
            Button4.Text = Button1.Text
            Button1.Text = smt
        ElseIf Button5.Text = "" Then
            gambar = Button4.BackgroundImage
            Button4.BackgroundImage = Button5.BackgroundImage
            Button5.BackgroundImage = gambar
            smt = Button4.Text
            Button4.Text = Button5.Text
            Button5.Text = smt
        ElseIf Button7.Text = "" Then
            gambar = Button4.BackgroundImage
            Button4.BackgroundImage = Button7.BackgroundImage
            Button7.BackgroundImage = gambar
            smt = Button4.Text
            Button4.Text = Button7.Text
            Button7.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button2.Text = "" Then
            gambar = Button5.BackgroundImage
            Button5.BackgroundImage = Button2.BackgroundImage
            Button2.BackgroundImage = gambar
            smt = Button5.Text
            Button5.Text = Button2.Text
            Button2.Text = smt
        ElseIf Button4.Text = "" Then
            gambar = Button5.BackgroundImage
            Button5.BackgroundImage = Button4.BackgroundImage
            Button4.BackgroundImage = gambar
            smt = Button5.Text
            Button5.Text = Button4.Text
            Button4.Text = smt
        ElseIf Button6.Text = "" Then
            gambar = Button5.BackgroundImage
            Button5.BackgroundImage = Button6.BackgroundImage
            Button6.BackgroundImage = gambar
            smt = Button5.Text
            Button5.Text = Button6.Text
            Button6.Text = smt
        ElseIf Button8.Text = "" Then
            gambar = Button5.BackgroundImage
            Button5.BackgroundImage = Button8.BackgroundImage
            Button8.BackgroundImage = gambar
            smt = Button5.Text
            Button5.Text = Button8.Text
            Button8.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button3.Text = "" Then
            gambar = Button6.BackgroundImage
            Button6.BackgroundImage = Button3.BackgroundImage
            Button3.BackgroundImage = gambar
            smt = Button6.Text
            Button6.Text = Button3.Text
            Button3.Text = smt
        ElseIf Button5.Text = "" Then
            gambar = Button6.BackgroundImage
            Button6.BackgroundImage = Button5.BackgroundImage
            Button5.BackgroundImage = gambar
            smt = Button6.Text
            Button6.Text = Button5.Text
            Button5.Text = smt
        ElseIf Button9.Text = "" Then
            gambar = Button6.BackgroundImage
            Button6.BackgroundImage = Button9.BackgroundImage
            Button9.BackgroundImage = gambar
            smt = Button6.Text
            Button6.Text = Button9.Text
            Button9.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button4.Text = "" Then
            gambar = Button7.BackgroundImage
            Button7.BackgroundImage = Button4.BackgroundImage
            Button4.BackgroundImage = gambar
            smt = Button7.Text
            Button7.Text = Button4.Text
            Button4.Text = smt
        ElseIf Button8.Text = "" Then
            gambar = Button7.BackgroundImage
            Button7.BackgroundImage = Button8.BackgroundImage
            Button8.BackgroundImage = gambar
            smt = Button7.Text
            Button7.Text = Button8.Text
            Button8.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button7.Text = "" Then
            gambar = Button8.BackgroundImage
            Button8.BackgroundImage = Button7.BackgroundImage
            Button7.BackgroundImage = gambar
            smt = Button8.Text
            Button8.Text = Button7.Text
            Button7.Text = smt
        ElseIf Button5.Text = "" Then
            gambar = Button8.BackgroundImage
            Button8.BackgroundImage = Button5.BackgroundImage
            Button5.BackgroundImage = gambar
            smt = Button8.Text
            Button8.Text = Button5.Text
            Button5.Text = smt
        ElseIf Button9.Text = "" Then
            gambar = Button8.BackgroundImage
            Button8.BackgroundImage = Button9.BackgroundImage
            Button9.BackgroundImage = gambar
            smt = Button8.Text
            Button8.Text = Button9.Text
            Button9.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button6.Text = "" Then
            gambar = Button9.BackgroundImage
            Button9.BackgroundImage = Button6.BackgroundImage
            Button6.BackgroundImage = gambar
            smt = Button9.Text
            Button9.Text = Button6.Text
            Button6.Text = smt
        ElseIf Button8.Text = "" Then
            gambar = Button9.BackgroundImage
            Button9.BackgroundImage = Button8.BackgroundImage
            Button8.BackgroundImage = gambar
            smt = Button9.Text
            Button9.Text = Button8.Text
            Button8.Text = smt
        End If
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "" Then
            MsgBox("SELAMAT")
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Button10.Enabled = True
        Button11.Enabled = True
        Button1.BackgroundImage = puzzle.My.Resources._1
        Button2.BackgroundImage = puzzle.My.Resources._2
        Button3.BackgroundImage = puzzle.My.Resources._3
        Button4.BackgroundImage = puzzle.My.Resources._4
        Button5.BackgroundImage = puzzle.My.Resources._5
        Button6.BackgroundImage = puzzle.My.Resources._6
        Button7.BackgroundImage = puzzle.My.Resources._7
        Button8.BackgroundImage = puzzle.My.Resources._8
        Button9.BackgroundImage = puzzle.My.Resources._9
        Button1.Text = "1"
        Button2.Text = "2"
        Button3.Text = "3"
        Button4.Text = "4"
        Button5.Text = "5"
        Button6.Text = "6"
        Button7.Text = "7"
        Button8.Text = "8"
        Button9.Text = ""
        Timer2.Enabled = False
        Label1.Text = ""
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        timeLeft = startTime.Subtract(Now)
        If Not timeLeft.Milliseconds < 0 Then
            Label4.Text = Format(timeleft.Minutes, "#0") & " Mins" & " " & Format(timeleft.Seconds, "00") & " Secs"
        Else
            Timer2.Enabled = False
            If MsgBox("Wanna Try Again?", vbQuestion + vbYesNo, "Game Over!") = vbYes Then
                Button10.Enabled = True
                Button11.Enabled = True
                Button1.BackgroundImage = puzzle.My.Resources._1
                Button2.BackgroundImage = puzzle.My.Resources._2
                Button3.BackgroundImage = puzzle.My.Resources._3
                Button4.BackgroundImage = puzzle.My.Resources._4
                Button5.BackgroundImage = puzzle.My.Resources._5
                Button6.BackgroundImage = puzzle.My.Resources._6
                Button7.BackgroundImage = puzzle.My.Resources._7
                Button8.BackgroundImage = puzzle.My.Resources._8
                Button9.BackgroundImage = puzzle.My.Resources._9
                Button1.Text = "1"
                Button2.Text = "2"
                Button3.Text = "3"
                Button4.Text = "4"
                Button5.Text = "5"
                Button6.Text = "6"
                Button7.Text = "7"
                Button8.Text = "8"
                Button9.Text = ""
                Timer2.Enabled = False
                Label1.Text = ""
            Else
                Close()
            End If
        End If
    End Sub
    Private Sub TextBox1_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim a As Boolean = Char.IsDigit(e.KeyChar)
        If Not a Then e.Handled = True
    End Sub
End Class
