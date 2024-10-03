Imports System.Drawing.Text
Public Class Form1
    Private _pWins As Integer
    Private _cWins As Integer
    Private _numHeads As Integer
    Private _numTails As Integer
    ' 0 tails
    ' 1 heads
    Private Sub Picheads_Click(sender As Object, e As EventArgs) Handles Picheads.Click

        '    Public g_FontReg10 As Font
        '    Public g_customfont As PrivateFontCollection

        'Public Sub CreateFont()
        '    g_customfont = New PrivateFontCollection
        '    g_customfont.AddFontFile(Path.GetTempPath & "lucida grande.ttf")
        '    g_FontReg10 = New Font(g_customfont.Families(0), 10)

        Dim Toss As Integer
        'turn on timer
        TmtRestart.Start()

        PicTails.Visible = False
        Picheads.Enabled = False
        Toss = Int(Rnd() * 2)
        'will give 0 or 1 never a 2
        If Toss = 0 Then
            PicToss.Image = My.Resources.heads
            _pWins = _pWins + 1
            lblplayerwins.Text = "Player Wins: " & _pWins
            _numHeads = _numHeads + 1
            lblHeadsrolled.Text = "Heads Rolled: " & _numHeads
        Else
            PicToss.Image = My.Resources.tails
            _cWins = _cWins + 1
            _numTails = _numTails + 1
            lblcomputerwins.Text = "Computer Wins: " & _cWins
            lbltailsrolled.Text = "Tails Rolled: " & _numTails
        End If
    End Sub

    Private Sub PicTails_Click(sender As Object, e As EventArgs) Handles PicTails.Click
        Dim Toss As Integer

        'turn on timer
        TmtRestart.Start()

        Picheads.Visible = False
        PicTails.Enabled = False
        Toss = Int(Rnd() * 2)
        'will give 0 or 1 never a 2
        If Toss = 0 Then
            PicToss.Image = My.Resources.tails
            _pWins = _pWins + 1
            lblplayerwins.Text = "Player Wins: " & _pWins
            _numTails = _numTails + 1
            lbltailsrolled.Text = "Tails Rolled: " & _numTails

        Else
            PicToss.Image = My.Resources.heads
            _cWins = _cWins + 1
            _numHeads = _numHeads + 1
            lblcomputerwins.Text = "Computer Wins: " & _cWins
            lblHeadsrolled.Text = "Heads Rolled: " & _numHeads
        End If
    End Sub

    Private Sub TmtRestart_Tick(sender As Object, e As EventArgs) Handles TmtRestart.Tick
        TmtRestart.Stop()
        'make both images visible
        'remove the image from picToss
        Picheads.Visible = True
        PicTails.Visible = True
        PicToss.Image = Nothing
        Picheads.Enabled = True
        PicTails.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile("C:\Users\User\Documents\Visual Studio 2012\Projects\CoinFlip\CoinFlip\Resources\kol.ttf")
        lblplayerwins.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)

        Label1.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
        Label1.Text = "This double punch increases" & Chr(13) & Chr(10) & "attack power by 1!" & Chr(13) & Chr(10) & "Way to go!"
        Randomize()
    End Sub
End Class
