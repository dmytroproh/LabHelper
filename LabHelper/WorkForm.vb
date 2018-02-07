'Импорты, соответственно системный импорт для ввода-вывода...
Imports System.IO
'И для сохранения и ыгрузки
Imports System.Xml.Serialization
Public Class WorkForm
    'Этот метод выполняется стразу при загрузке формы
    Private Sub WorkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Заполняем таблицу справки значениями

        Dim row0 As String() = {"Кварц", "60,09", "3", _
         "2650", "1413", "2,58"}
        Dim row1 As String() = {"Магнетид", "231,55", "7", _
         "5200", "1300", "1,12"}
        Dim row2 As String() = {"Олигоклаз", "262,00", "13", _
         "2640", "1120", "2,58"}
        Dim row3 As String() = {"Ортоклаз", "278,35", "19", _
         "2600", "1200", "1,99"}
        Dim row4 As String() = {"Амфибол", "812,5", "39", _
         "3080", "1350", "1,99"}
        Dim row5 As String() = {"Биотит", "417,33", "22", _
         "3050", "1450", "1,99"}
        Dim row6 As String() = {"Адезид", "280.00", "13", _
         "2650", "1533", "2,58"}
        'Добаляем значения в таблицу
        dgvHelpTable.Rows.Add(row0)
        dgvHelpTable.Rows.Add(row1)
        dgvHelpTable.Rows.Add(row2)
        dgvHelpTable.Rows.Add(row3)
        dgvHelpTable.Rows.Add(row4)
        dgvHelpTable.Rows.Add(row5)
        dgvHelpTable.Rows.Add(row6)




    End Sub
    'Метод управления, который позволяет при нажатии на правую стрелку перейти к другому виду формы
    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles BtnRight.Click
        Dim x As Integer = (MeneralsHendler.SelectedIndex + 1) Mod 3
        MeneralsHendler.SelectTab(x)

    End Sub

    'Метод управления, который позволяет при нажатии на леую стрелку перейти к другому виду формы
    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles BtnLeft.Click
        Dim x As Integer = (MeneralsHendler.SelectedIndex + 2) Mod 3
        MeneralsHendler.SelectTab(x)
    End Sub




    'Событие нажатия на кнопку расчета
    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        Try
            'Этот блок пробует выолнить себя, если не получается - выбрасывает исключение
            FirstResult.Text += "Минерал: " + NameType.Text + Environment.NewLine
            'Этот блок отвечает за ввод и редактирование данных в чекбоксы
            Dim OtMM As Double = CDbl(MolWeight.Text)
            Dim Quant As Double = CDbl(NumberOfAt.Text)
            Dim Dens As Double = CDbl(Density.Text)
            Dim Tmel As Double = CDbl(Tmelting.Text)
            Dim Singin As Double = CDbl(Singinia.Text)
            Dim TofT As Double = CDbl(TOfType.Text)

            If (CbTempEffect.Checked = True) Then
                Dim StrartT As Integer = CInt(StartTemp.Text)
                Dim EndT As Integer = CInt(EndTemp.Text)

            Else

            End If
            'Это математический расчет теплопроводности и теплоемкости по формулам, приведенным в лабе
            Dim Resultat As Double = 0.0132 * Singin * ((Tmel + 273) / (TofT + 273)) * Math.Sqrt((Tmel + 273) * Dens / OtMM * Quant)
            Dim TeployEm As Double = 25 / OtMM * Math.Pow(Quant, 4 / 3)


            'Выод данных в чекбоксы
            FirstResult.Text += "Теплопроводность (λ) Вт/м*°C" + Environment.NewLine + Resultat.ToString() + Environment.NewLine
            'Выод данных в прибор
            TextBox2.Text = Resultat.ToString() + " Вт/м*°C" + Environment.NewLine
            FirstResult.Text += "Удельная теплоемкость (С) Дж/кг*°C" + Environment.NewLine + TeployEm.ToString() + Environment.NewLine
            FirstResult.Text += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" + Environment.NewLine


            'Обработка исключения, которое может возниконуть в блоке
        Catch efdf As Exception
            Throw
            FirstResult.Text += "Не введены все необходимые поля, введены буквы вместо цифр" + Environment.NewLine + _
                +"Используйте запятую для ввода дробных чисел"
        Finally
        End Try
    End Sub

    'Обработка корректного нажатия галочек, которые можно поставить на пористую и сплошную породу
    Private Sub CBtight_CheckedChanged(sender As Object, e As EventArgs) Handles CBtight.CheckedChanged
        CBporous.Enabled = Not CBtight.Checked()
    End Sub

    Private Sub CBporous_CheckedChanged(sender As Object, e As EventArgs) Handles CBporous.CheckedChanged
        CBtight.Enabled = Not CBporous.Checked()

    End Sub
    'Метод обработки события нажатия кнопуи на 2-й части
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Этот блок пробует выолнить себя, если не получается - выбрасывает исключение
        Try
            Result.Text += "Порода: " + Type.Text + Environment.NewLine
            'Ввод и редактирование данных
            Dim CountOfMinerals As Double = CInt(numberOf.Text)
            Dim names As New List(Of String)
            Dim nues As New List(Of String)
            Dim lambdes As New List(Of String)
            Dim Ces As New List(Of String)
            Dim alpha, beta As Double
            'Выбор характеристик для пористой и сплошной породы
            If (CBporous.Checked = True) Then
                alpha = 0.7
                beta = 0.3
            Else

                alpha = 0.6
                beta = 0.4
            End If
            'Это обработка таблицы. Добавляем в индекс столбца и индекс строки
            For i As Integer = 0 To dgvListOfTypes.Rows.Count - 2
                names.Add(dgvListOfTypes(0, i).Value)
                nues.Add(dgvListOfTypes(1, i).Value)
                lambdes.Add(dgvListOfTypes(2, i).Value)
                Ces.Add(dgvListOfTypes(3, i).Value)


            Next i
            Dim Teplopr As Double = lambdes(0)
            Dim Teploem As Double = 0

            'Рассчитываем теплопроводность по формуле из лабы

            For i As Integer = 0 To dgvListOfTypes.Rows.Count - 3
                Teplopr = alpha * Teplopr + beta * lambdes(i + 1)
                Teploem += Ces(i) * nues(i)



            Next
            'Это вывод в результат. Обращаемся к таблице по индексам
            Result.Text += "Составляющие породы: " + Environment.NewLine
            For i As Integer = 0 To dgvListOfTypes.Rows.Count - 2
                Result.Text += names(i).ToString() + Environment.NewLine



            Next
            'Это вывод в результат
            Result.Text += "Теплопроводность породы: " + Teplopr.ToString() + " Вт/м*°C" + Environment.NewLine
            Result.Text += "Теплоемкость породы: " + Teploem.ToString() + " Дж/кг*°C" + Environment.NewLine
            Result.Text += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" + Environment.NewLine
            'А это вывод в прибор
            TextBox1.Text += Teplopr.ToString() + " Вт/м*°C"
            'Обработка исключения, которое может возниконуть в блоке
        Catch efdf As Exception
            Throw


            Result.Text += "Не введены все необходимые поля, введены буквы вместо цифр" + Environment.NewLine + _
                +"Используйте запятую для ввода дробных чисел"
        Finally



        End Try

    End Sub
    'Методы сохранения и загрузки в XML

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        'Создали объект-читатель
        Dim objStreamReader As New StreamReader("Part1.xml")
        Dim x As New XmlSerializer(FirstResult.Text.GetType)
        'Прочитали данные
        FirstResult.Text = x.Deserialize(objStreamReader)
        objStreamReader.Close()
        Dim objStreamReader2 As New StreamReader("Part2.xml")
        Dim x1 As New XmlSerializer(Result.Text.GetType)
        Result.Text = x1.Deserialize(objStreamReader2)
        objStreamReader2.Close()
        'И вывели из в результат
        FirstResult.Text += Environment.NewLine + "Загрузка данных прошла успешно" + Environment.NewLine
        FirstResult.Text += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" + Environment.NewLine
        Result.Text += Environment.NewLine + "Загрузка данных прошла успешно" + Environment.NewLine
        Result.Text += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" + Environment.NewLine


    End Sub

    Private Sub SaveButon_Click(sender As Object, e As EventArgs) Handles SaveButon.Click
        'Создали объект записи
        Dim objStreamWriter As New StreamWriter("Part2.xml")
        Dim x As New XmlSerializer(Result.Text.GetType)
        x.Serialize(objStreamWriter, Result.Text)
        objStreamWriter.Close()
        'записали()
        Dim objStreamWriter2 As New StreamWriter("Part1.xml")
        Dim x1 As New XmlSerializer(FirstResult.Text.GetType)
        x1.Serialize(objStreamWriter2, FirstResult.Text)
        objStreamWriter2.Close()
        'отчитались в результате о сохранении
        FirstResult.Text += "Сохранение данных прошло успешно" + Environment.NewLine
        FirstResult.Text += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" + Environment.NewLine
        Result.Text += "Сохранение данных прошло успешно" + Environment.NewLine
        Result.Text += "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" + Environment.NewLine
    End Sub


    'Методы, которые проверяют, явлеяется ли первый символ ввода цифрой
    Private Sub TypeWarn(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True 'блокировка
            Result.Text = "Сюда можно вводить только цифры" + Environment.NewLine

        End If
    End Sub

    Private Sub TypeWarn2(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True 'блокировка
            FirstResult.Text = "Сюда можно вводить только цифры" + Environment.NewLine
        End If
    End Sub
    'События нажатия первой клавиши, при котором вызвается метод проверки
    Private Sub numberOf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numberOf.KeyPress
        TypeWarn(e)
    End Sub

    Private Sub MolWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MolWeight.KeyPress
        TypeWarn2(e)
    End Sub

    Private Sub NumberOfAt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumberOfAt.KeyPress
        TypeWarn2(e)
    End Sub

    Private Sub Density_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Density.KeyPress
        TypeWarn2(e)
    End Sub

    Private Sub Tmelting_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tmelting.KeyPress
        TypeWarn2(e)
    End Sub

    Private Sub Singinia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Singinia.KeyPress
        TypeWarn2(e)
    End Sub

    Private Sub TOfType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TOfType.KeyPress
        TypeWarn2(e)
    End Sub

    'Метод проверяет соответстие анонсированного количества минералов и введенного
    Private Sub numberOf_TextChanged(sender As Object, e As EventArgs) Handles numberOf.TextChanged
        If (Not numberOf.Text = "") Then
            If CInt(numberOf.Text) >= dgvListOfTypes.RowCount Then

                dgvListOfTypes.RowCount = CInt(numberOf.Text)
            End If
        End If
    End Sub



    'А это реализация выпадающего списка, где мы выбираем минерал
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        'Принцип прост: Проверяем на соответствие строке и заполняем текстбоксы определенными значениями
        If (ComboBox1.Text = "Кварц"
            ) Then
            NameType.Text = "Кварц"
            MolWeight.Text = "60,09"
            NumberOfAt.Text = "3"
            Density.Text = "2650"
            Tmelting.Text = "1413"
            Singinia.Text = "2,68"
            TOfType.Text = "400"
        ElseIf (ComboBox1.Text = "Магнетид"
           ) Then
            NameType.Text = "Магнетид"
            MolWeight.Text = "231,55"
            NumberOfAt.Text = "7"
            Density.Text = "5200"
            Tmelting.Text = "1300"
            Singinia.Text = "1,12"
            TOfType.Text = "300"


        ElseIf (ComboBox1.Text = "Олигоклаз"
   ) Then
            NameType.Text = "Олигоклаз"
            MolWeight.Text = "262,00"
            NumberOfAt.Text = "13"
            Density.Text = "2640"
            Tmelting.Text = "1200"
            Singinia.Text = "2,58"
            TOfType.Text = "350"


        ElseIf (ComboBox1.Text = "Оргоклаз"
   ) Then
            NameType.Text = "Ортоклаз"
            MolWeight.Text = "278,35"
            NumberOfAt.Text = "19"
            Density.Text = "2680"
            Tmelting.Text = "1200"
            Singinia.Text = "1,99"
            TOfType.Text = "380"

        ElseIf (ComboBox1.Text = "Амфибол"
   ) Then
            NameType.Text = "Амфибол"
            MolWeight.Text = "812,5"
            NumberOfAt.Text = "39"
            Density.Text = "3000"
            Tmelting.Text = "1350"
            Singinia.Text = "1,99"
            TOfType.Text = "30"


        ElseIf (ComboBox1.Text = "Биотид"
   ) Then
            NameType.Text = "Биотид"
            MolWeight.Text = "417,33"
            NumberOfAt.Text = "22"
            Density.Text = "3050"
            Tmelting.Text = "1450"
            Singinia.Text = "1,99"
            TOfType.Text = "53"

        ElseIf (ComboBox1.Text = "Адезид"
   ) Then
            NameType.Text = "Адезид"
            MolWeight.Text = "280,09"
            NumberOfAt.Text = "13"
            Density.Text = "2650"
            Tmelting.Text = "1533"
            Singinia.Text = "2,58"
            TOfType.Text = "39"

        End If
    End Sub

    
End Class