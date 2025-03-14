
Public Class Form1

    Dim Racha As Integer = 0
    Private Enum opciones
        Piedra
        Papel
        Machete
    End Enum
    Private Function DeterminarGanador(jugador As opciones, computadora As opciones) As String
        If jugador = computadora Then
            Return "Empate"
        ElseIf (jugador = opciones.Piedra AndAlso computadora = opciones.Machete) OrElse
             (jugador = opciones.Papel AndAlso computadora = opciones.Piedra) OrElse
             (jugador = opciones.Machete AndAlso computadora = opciones.Papel) Then

            Racha += 1
            LabelRachavictorias.Text = Racha
            Return "¡Ganaste!"

        Else

            Racha = 0
            LabelRachavictorias.Text = 0
            Return "¡Perdiste!"

        End If
    End Function
    Private Function OpcionComputadora() As opciones
        Dim rand As New Random()
        Return CType(rand.Next(0, 3), opciones)
    End Function

    Private Sub Jugar(opcionJugador As opciones)
        Dim opcionComp As opciones = OpcionComputadora()
        LabelResultado.Text = DeterminarGanador(opcionJugador, opcionComp)
        LabelElecciónComputadora.Text = "Computadora eligió: " & opcionComp.ToString()
    End Sub



    Private Sub btnpiedra_Click(sender As Object, e As EventArgs) Handles btnpiedra.Click
        Jugar(opciones.Piedra)
    End Sub

    Private Sub btnpapel_Click(sender As Object, e As EventArgs) Handles btnpapel.Click
        Jugar(opciones.Papel)
    End Sub

    Private Sub btnmachete_Click(sender As Object, e As EventArgs) Handles btnmachete.Click
        Jugar(opciones.Machete)
    End Sub


End Class