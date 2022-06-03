Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePrecionaOperador As Boolean

    Private Sub ButtonUno_Click(sender As Object, e As EventArgs) Handles ButtonUno.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "1"
    End Sub

    Private Sub ButtonDos_Click(sender As Object, e As EventArgs) Handles ButtonDos.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "2"
    End Sub

    Private Sub ButtonTres_Click(sender As Object, e As EventArgs) Handles ButtonTres.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "3"
    End Sub

    Private Sub ButtonCuatro_Click(sender As Object, e As EventArgs) Handles ButtonCuatro.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "4"
    End Sub

    Private Sub ButtonCinco_Click(sender As Object, e As EventArgs) Handles ButtonCinco.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "5"
    End Sub

    Private Sub ButtonSeis_Click(sender As Object, e As EventArgs) Handles ButtonSeis.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "6"
    End Sub

    Private Sub ButtonSiete_Click(sender As Object, e As EventArgs) Handles ButtonSiete.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "7"
    End Sub

    Private Sub ButtonOcho_Click(sender As Object, e As EventArgs) Handles ButtonOcho.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "8"
    End Sub

    Private Sub ButtonNueve_Click(sender As Object, e As EventArgs) Handles ButtonNueve.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "9"
    End Sub

    Private Sub ButtonCero_Click(sender As Object, e As EventArgs) Handles ButtonCero.Click
        EvaluateRestriccionesParaConcatener()
        Txb1.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluateRestriccionesParaConcatener()
        If InStr(Txb1.Text, ".", CompareMethod.Text) = 0 Then
            Txb1.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicaciom_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicaciom.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Txb1.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Public Sub EvaluayHazOperacion()
        SePrecionaOperador = True
        Valor2 = Val(Txb1.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            Txb1.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluateRestriccionesParaConcatener()
        If SePrecionaOperador = True Then
            Txb1.Text = ""
            SePrecionaOperador = False
        ElseIf Txb1.Text = "0" Then
            Txb1.Text = ""
        End If
    End Sub
End Class
