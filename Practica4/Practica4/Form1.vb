Public Class Form1
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""


        ' Este es el formato 24h
        If formato = True Then
            ' "08:06:56:12"
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        'Time_mod(0) = "08"
        'Time_mod(1) = "06"

        Horas.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Segundos.Text = Time_mod(2)
        Dia.Text = Day_o
        Dia.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Config.Visible = False Then
            Config.Visible = True
        ElseIf Config.Visible = True Then
            Config.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim colortxt As String = ComboBox1.SelectedItem.ToString()
        If colortxt = "Blanco" Then
            Horas.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Dia.ForeColor = Color.White
            Fecha.ForeColor = Color.White
        ElseIf colortxt = "Rojo" Then
            Horas.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Dia.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
            Segundos.ForeColor = Color.Red
        ElseIf colortxt = "Verde" Then
            Horas.ForeColor = Color.Green
            Minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Dia.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
        ElseIf colortxt = "Azul" Then
            Horas.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Dia.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
        ElseIf colortxt = "Amarillo" Then
            Horas.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Dia.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start.Click
        If formato = True Then
            Start.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Start.Text = "24h"
            formato = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Start1_Click(sender As Object, e As EventArgs) Handles Start1.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            Start1.Text = "Stop"t
            startTime = DateTime.Now
        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            Start1.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub



    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        tiempo_crono = 0
        Timer3.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono = tiempo_crono + 1
        Tiempo.Text = tiempo_crono.ToString()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Config_Paint(sender As Object, e As PaintEventArgs) Handles Config.Paint

    End Sub
End Class
