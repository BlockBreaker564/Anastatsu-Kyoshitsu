Public Class Main_Game
    Dim direction As Integer = -10


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'follow(PictureBox2)
    End Sub
    'Sub move(p As PictureBox, x As Integer, y As Integer)
    ' p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    'End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim s As New Form3
        Select Case e.KeyCode
            Case Keys.W
                MoveTo(Karma, 0, -10)
                Console.WriteLine("W")
            Case Keys.S
                MoveTo(Karma, 0, 10)
                Console.WriteLine("S")
            Case Keys.Space
                SAAUSO_Knife.Visible = True
                SAAUSO_Knife.Location = Nagisa.Location
            Case Keys.Up
                MoveTo(Nagisa, 0, -10)
                Console.WriteLine("up")
            Case Keys.Down
                MoveTo(Nagisa, 0, 10)
                Console.WriteLine("down")

            Case Keys.PageDown
                SAAUSO_Knife.Visible = True
                SAAUSO_Knife.Location = Karma.Location

            Case Keys.Enter
                s.ShowDialog()
        End Select
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        'If p.Location.X > PictureBox1.Location.X Then
        '       x = -5
        'Else
        '       x = 5
        'End If
        '   MoveTo(p, x, 0)
        If p.Location.Y < Karma.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub
    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And (obj.Name.ToUpper.EndsWith(t.ToUpper) Or obj.Name.ToUpper.StartsWith(t.ToUpper)) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function

    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(SAAUSO_Knife, direction, 0)

    End Sub
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then

            p.Location += New Point(distx, disty)
        End If

        If p.Name = "SAAUSO_Knife" And Collision(p, "PictureBox1wall") Then
            direction = -1
        End If

        If p.Name = "SAAUSO_Knife" And Collision(p, "PictureBox2wall") Then
            direction = -1
        End If

        If p.Name = "SAAUSO_Knife" And Collision(p, "Karma") Then
            Dim f As New Form2
            Timer1.Enabled = False
            Timer2.Enabled = False
            f.ShowDialog()

            'SAAUSO_Knife.Location = PictureBox1.Location
            Return
        End If



        If p.Name = "SAAUSO_Knife" And Collision(p, "Nagisa") Then
            Dim f As New Form2
            Timer1.Enabled = False
            Timer2.Enabled = False
            f.ShowDialog()

            'SAAUSO_Knife.Location = PictureBox1.Location
            Return
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
