Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' Declare values
        Dim stat1, stat2, stat3, newStat1, newStat2, newStat3 As Decimal

        ' Assign values
        If IsNumeric(stat1EnterField.Text) = False Or IsNumeric(stat2EnterField.Text) = False Or IsNumeric(stat3EnterField.Text) = False Then
            MessageBox.Show("Please enter a numeric stat value.")
            stat1EnterField.Text = ""
            stat2EnterField.Text = ""
            stat3EnterField.Text = ""
        Else
            stat1 = stat1EnterField.Text
            stat2 = stat2EnterField.Text
            stat3 = stat3EnterField.Text
        End If

        'Error Checking
        If stat1 < 0 And stat2 < 0 And stat3 < 0 Then
            MessageBox.Show("Please enter stats greater than 0.")
            stat1EnterField.Text = ""
            stat2EnterField.Text = ""
            stat3EnterField.Text = ""
        End If

        ' Detect enhancement level
        Dim enLevel, desEnLevel As Integer

        If IsNumeric(enhanceLevelEnterField.Text) = False Or IsNumeric(desEnhanceLevelEnterField.Text) = False Then
            MessageBox.Show("Please enter a numeric enhancement value.")
            enhanceLevelEnterField.Text = ""
            desEnhanceLevelEnterField.Text = ""
        ElseIf enhanceLevelEnterField.Text < 0 Or enhanceLevelEnterField.Text > 5 Or desEnhanceLevelEnterField.Text < 0 Or desEnhanceLevelEnterField.Text > 5 Then
            MessageBox.Show("Please enter an enhancement value between 0-5.")
            enhanceLevelEnterField.Text = ""
            desEnhanceLevelEnterField.Text = ""
        Else
            enLevel = enhanceLevelEnterField.Text
            desEnLevel = desEnhanceLevelEnterField.Text
        End If

        ' Run calculations
        For ticker As Integer = 0 To 5 Step +1
            Select Case enLevel
                Case ticker
                    stat1 = stat1 / (ticker + 1)
                    stat2 = stat2 / (ticker + 1)
                    stat3 = stat3 / (ticker + 1)
                    For counter As Integer = 0 To 5 Step +1
                        Select Case desEnLevel
                            Case counter
                                stat1ReturnField.Text = stat1 + (stat1 * counter)
                                stat2ReturnField.Text = stat2 + (stat2 * counter)
                                stat3ReturnField.Text = stat3 + (stat3 * counter)
                        End Select
                    Next
            End Select
        Next
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        stat1EnterField.Text = ""
        stat2EnterField.Text = ""
        stat3EnterField.Text = ""
        enhanceLevelEnterField.Text = ""
        desEnhanceLevelEnterField.Text = ""
        stat1ReturnField.Text = ""
        stat2ReturnField.Text = ""
        stat3ReturnField.Text = ""

    End Sub
End Class
