Public Class MainForm


    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cbLabChoise.TextChanged
        'обработка выпадающего списка
        If (cbLabChoise.Text = "Теплофизические свойства"
            ) Then
            'Если введено нужное значение, открываем форму расчетов
            Dim FM As New WorkForm
            FM.Show()
        Else

            Label2.Text = "Такой лабы пока нет."
            Label3.Text = "А 'Теплофизические свойcтсва' есть)."
        End If


    End Sub


   
   
End Class
