<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkForm))
        Me.BtnRight = New System.Windows.Forms.Button()
        Me.BtnLeft = New System.Windows.Forms.Button()
        Me.MeneralsHendler = New System.Windows.Forms.TabControl()
        Me.Minerals = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GO = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbTempEffect = New System.Windows.Forms.CheckBox()
        Me.TOfType = New System.Windows.Forms.TextBox()
        Me.StartTemp = New System.Windows.Forms.TextBox()
        Me.EndTemp = New System.Windows.Forms.TextBox()
        Me.MolWeight = New System.Windows.Forms.TextBox()
        Me.NumberOfAt = New System.Windows.Forms.TextBox()
        Me.Tmelting = New System.Windows.Forms.TextBox()
        Me.Density = New System.Windows.Forms.TextBox()
        Me.Singinia = New System.Windows.Forms.TextBox()
        Me.NameType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstResult = New System.Windows.Forms.TextBox()
        Me.SolidTapesPage = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvListOfTypes = New System.Windows.Forms.DataGridView()

        Me.nu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lambda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBporous = New System.Windows.Forms.CheckBox()
        Me.CBtight = New System.Windows.Forms.CheckBox()
        Me.numberOf = New System.Windows.Forms.TextBox()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeplPage = New System.Windows.Forms.TabPage()
        Me.dgvHelpTable = New System.Windows.Forms.DataGridView()
        Me.Mineral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InAtom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comsistence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsOf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SaveButon = New System.Windows.Forms.Button()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.MeneralsHendler.SuspendLayout()
        Me.Minerals.SuspendLayout()
        Me.SolidTapesPage.SuspendLayout()
        CType(Me.dgvListOfTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeplPage.SuspendLayout()
        CType(Me.dgvHelpTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRight
        '
        Me.BtnRight.BackgroundImage = Global.LabHelper.My.Resources.Resources.right
        Me.BtnRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRight.FlatAppearance.BorderSize = 0
        Me.BtnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.BtnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRight.Location = New System.Drawing.Point(809, 235)
        Me.BtnRight.Name = "BtnRight"
        Me.BtnRight.Size = New System.Drawing.Size(63, 64)
        Me.BtnRight.TabIndex = 1
        Me.BtnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnRight.UseVisualStyleBackColor = False
        '
        'BtnLeft
        '
        Me.BtnLeft.BackgroundImage = CType(resources.GetObject("BtnLeft.BackgroundImage"), System.Drawing.Image)
        Me.BtnLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLeft.FlatAppearance.BorderSize = 0
        Me.BtnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.BtnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLeft.Location = New System.Drawing.Point(12, 235)
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.Size = New System.Drawing.Size(64, 64)
        Me.BtnLeft.TabIndex = 0
        Me.BtnLeft.UseVisualStyleBackColor = True
        '
        'MeneralsHendler
        '
        Me.MeneralsHendler.Controls.Add(Me.Minerals)
        Me.MeneralsHendler.Controls.Add(Me.SolidTapesPage)
        Me.MeneralsHendler.Controls.Add(Me.HeplPage)
        Me.MeneralsHendler.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MeneralsHendler.ItemSize = New System.Drawing.Size(694, 20)
        Me.MeneralsHendler.Location = New System.Drawing.Point(96, 8)
        Me.MeneralsHendler.MinimumSize = New System.Drawing.Size(600, 0)
        Me.MeneralsHendler.Multiline = True
        Me.MeneralsHendler.Name = "MeneralsHendler"
        Me.MeneralsHendler.Padding = New System.Drawing.Point(83, 3)
        Me.MeneralsHendler.SelectedIndex = 0
        Me.MeneralsHendler.Size = New System.Drawing.Size(694, 530)
        Me.MeneralsHendler.TabIndex = 2
        Me.MeneralsHendler.TabStop = False
        '
        'Minerals
        '
        Me.Minerals.AutoScroll = True
        Me.Minerals.BackColor = System.Drawing.SystemColors.Control
        Me.Minerals.Controls.Add(Me.ComboBox1)
        Me.Minerals.Controls.Add(Me.TextBox2)
        Me.Minerals.Controls.Add(Me.Button3)
        Me.Minerals.Controls.Add(Me.GO)
        Me.Minerals.Controls.Add(Me.Label19)
        Me.Minerals.Controls.Add(Me.Label18)
        Me.Minerals.Controls.Add(Me.Label17)
        Me.Minerals.Controls.Add(Me.Label16)
        Me.Minerals.Controls.Add(Me.Label15)
        Me.Minerals.Controls.Add(Me.Label14)
        Me.Minerals.Controls.Add(Me.Label13)
        Me.Minerals.Controls.Add(Me.Label12)
        Me.Minerals.Controls.Add(Me.Label11)
        Me.Minerals.Controls.Add(Me.Label10)
        Me.Minerals.Controls.Add(Me.Label2)
        Me.Minerals.Controls.Add(Me.CbTempEffect)
        Me.Minerals.Controls.Add(Me.TOfType)
        Me.Minerals.Controls.Add(Me.StartTemp)
        Me.Minerals.Controls.Add(Me.EndTemp)
        Me.Minerals.Controls.Add(Me.MolWeight)
        Me.Minerals.Controls.Add(Me.NumberOfAt)
        Me.Minerals.Controls.Add(Me.Tmelting)
        Me.Minerals.Controls.Add(Me.Density)
        Me.Minerals.Controls.Add(Me.Singinia)
        Me.Minerals.Controls.Add(Me.NameType)
        Me.Minerals.Controls.Add(Me.Label1)
        Me.Minerals.Controls.Add(Me.FirstResult)
        Me.Minerals.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Minerals.Location = New System.Drawing.Point(4, 24)
        Me.Minerals.Name = "Minerals"
        Me.Minerals.Padding = New System.Windows.Forms.Padding(3)
        Me.Minerals.Size = New System.Drawing.Size(686, 502)
        Me.Minerals.TabIndex = 0
        Me.Minerals.Text = "Минерал"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Кварц", "Магнетид", "Олигоклаз", "Ортоклаз", "Амфибол", "Биотит", "Адезид"})
        Me.ComboBox1.Location = New System.Drawing.Point(211, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(453, 240)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 27)
        Me.TextBox2.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(420, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 214)
        Me.Button3.TabIndex = 26
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GO
        '
        Me.GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GO.Location = New System.Drawing.Point(124, 463)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(117, 33)
        Me.GO.TabIndex = 24
        Me.GO.Text = "Рассчитать"
        Me.GO.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 285)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(177, 20)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Температура пород (°C)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 20)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Название минерала"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(219, 20)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Относительная молекулярная"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(136, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 20)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "масса (М)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(214, 20)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Число атомов в молекуле (N)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 20)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Плотность минерела ( кг/м³)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(208, 20)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Температура плавления (°C)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 20)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Коэфициент cингонии (As)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(17, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(207, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Температура начальная (°C)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(17, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(199, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Температура конечная (°C)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(52, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "на теплопроводность"
        '
        'CbTempEffect
        '
        Me.CbTempEffect.AutoSize = True
        Me.CbTempEffect.Enabled = False
        Me.CbTempEffect.Location = New System.Drawing.Point(34, 324)
        Me.CbTempEffect.Name = "CbTempEffect"
        Me.CbTempEffect.Size = New System.Drawing.Size(255, 24)
        Me.CbTempEffect.TabIndex = 12
        Me.CbTempEffect.Text = "Оценить влияние  температуры "
        Me.CbTempEffect.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CbTempEffect.ThreeState = True
        Me.CbTempEffect.UseVisualStyleBackColor = True
        '
        'TOfType
        '
        Me.TOfType.Location = New System.Drawing.Point(226, 282)
        Me.TOfType.Name = "TOfType"
        Me.TOfType.Size = New System.Drawing.Size(100, 27)
        Me.TOfType.TabIndex = 11
        '
        'StartTemp
        '
        Me.StartTemp.Enabled = False
        Me.StartTemp.Location = New System.Drawing.Point(226, 380)
        Me.StartTemp.Name = "StartTemp"
        Me.StartTemp.Size = New System.Drawing.Size(100, 27)
        Me.StartTemp.TabIndex = 10
        '
        'EndTemp
        '
        Me.EndTemp.Enabled = False
        Me.EndTemp.Location = New System.Drawing.Point(226, 430)
        Me.EndTemp.Name = "EndTemp"
        Me.EndTemp.Size = New System.Drawing.Size(100, 27)
        Me.EndTemp.TabIndex = 9
        '
        'MolWeight
        '
        Me.MolWeight.Location = New System.Drawing.Point(226, 61)
        Me.MolWeight.Name = "MolWeight"
        Me.MolWeight.Size = New System.Drawing.Size(100, 27)
        Me.MolWeight.TabIndex = 8
        '
        'NumberOfAt
        '
        Me.NumberOfAt.Location = New System.Drawing.Point(226, 104)
        Me.NumberOfAt.Name = "NumberOfAt"
        Me.NumberOfAt.Size = New System.Drawing.Size(100, 27)
        Me.NumberOfAt.TabIndex = 7
        '
        'Tmelting
        '
        Me.Tmelting.Location = New System.Drawing.Point(226, 194)
        Me.Tmelting.Name = "Tmelting"
        Me.Tmelting.Size = New System.Drawing.Size(100, 27)
        Me.Tmelting.TabIndex = 6
        '
        'Density
        '
        Me.Density.Location = New System.Drawing.Point(226, 152)
        Me.Density.Name = "Density"
        Me.Density.Size = New System.Drawing.Size(100, 27)
        Me.Density.TabIndex = 5
        '
        'Singinia
        '
        Me.Singinia.Location = New System.Drawing.Point(226, 240)
        Me.Singinia.Name = "Singinia"
        Me.Singinia.Size = New System.Drawing.Size(100, 27)
        Me.Singinia.TabIndex = 4
        '
        'NameType
        '
        Me.NameType.Location = New System.Drawing.Point(367, 15)
        Me.NameType.Name = "NameType"
        Me.NameType.Size = New System.Drawing.Size(100, 27)
        Me.NameType.TabIndex = 3
        Me.NameType.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Результаты"
        '
        'FirstResult
        '
        Me.FirstResult.CausesValidation = False
        Me.FirstResult.Location = New System.Drawing.Point(367, 48)
        Me.FirstResult.Multiline = True
        Me.FirstResult.Name = "FirstResult"
        Me.FirstResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FirstResult.Size = New System.Drawing.Size(294, 130)
        Me.FirstResult.TabIndex = 0
        '
        'SolidTapesPage
        '
        Me.SolidTapesPage.BackColor = System.Drawing.SystemColors.Control
        Me.SolidTapesPage.Controls.Add(Me.TextBox1)
        Me.SolidTapesPage.Controls.Add(Me.Button1)
        Me.SolidTapesPage.Controls.Add(Me.Button2)
        Me.SolidTapesPage.Controls.Add(Me.dgvListOfTypes)
        Me.SolidTapesPage.Controls.Add(Me.Label9)
        Me.SolidTapesPage.Controls.Add(Me.Label8)
        Me.SolidTapesPage.Controls.Add(Me.Label7)
        Me.SolidTapesPage.Controls.Add(Me.Label6)
        Me.SolidTapesPage.Controls.Add(Me.Label5)
        Me.SolidTapesPage.Controls.Add(Me.Label4)
        Me.SolidTapesPage.Controls.Add(Me.CBporous)
        Me.SolidTapesPage.Controls.Add(Me.CBtight)
        Me.SolidTapesPage.Controls.Add(Me.numberOf)
        Me.SolidTapesPage.Controls.Add(Me.Type)
        Me.SolidTapesPage.Controls.Add(Me.Result)
        Me.SolidTapesPage.Controls.Add(Me.Label3)
        Me.SolidTapesPage.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SolidTapesPage.Location = New System.Drawing.Point(4, 24)
        Me.SolidTapesPage.Name = "SolidTapesPage"
        Me.SolidTapesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SolidTapesPage.Size = New System.Drawing.Size(686, 502)
        Me.SolidTapesPage.TabIndex = 1
        Me.SolidTapesPage.Text = "Породы"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(457, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(420, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 214)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(124, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Рассчитать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvListOfTypes
        '
        Me.dgvListOfTypes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvListOfTypes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListOfTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nu, Me.lambda, Me.C})
        Me.dgvListOfTypes.Location = New System.Drawing.Point(23, 249)
        Me.dgvListOfTypes.Name = "dgvListOfTypes"
        Me.dgvListOfTypes.Size = New System.Drawing.Size(338, 208)
        Me.dgvListOfTypes.TabIndex = 13
        '
        'NameOf
        '

        'nu
        '
        Me.nu.FillWeight = 60.0!
        Me.nu.HeaderText = "nu"
        Me.nu.Name = "nu"
        Me.nu.Width = 60
        '
        'lambda
        '
        Me.lambda.FillWeight = 75.0!
        Me.lambda.HeaderText = "λ"
        Me.lambda.Name = "lambda"
        Me.lambda.Width = 75
        '
        'C
        '
        Me.C.FillWeight = 60.0!
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        Me.C.Width = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "С - теплоемкость (ДЖ*кг/м * К)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(331, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "nu - содерж.,%, λ  - теплопроводность(ВТ/М*к)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Минералы, составляющие породу"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "минералов данной породы"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Введите число составляющих"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Введите название породы"
        '
        'CBporous
        '
        Me.CBporous.AutoSize = True
        Me.CBporous.Location = New System.Drawing.Point(23, 92)
        Me.CBporous.Name = "CBporous"
        Me.CBporous.Size = New System.Drawing.Size(259, 24)
        Me.CBporous.TabIndex = 5
        Me.CBporous.Text = "Пористая порода (α =0.3, β = 0.7)"
        Me.CBporous.UseVisualStyleBackColor = True
        '
        'CBtight
        '
        Me.CBtight.AutoSize = True
        Me.CBtight.Location = New System.Drawing.Point(23, 62)
        Me.CBtight.Name = "CBtight"
        Me.CBtight.Size = New System.Drawing.Size(251, 24)
        Me.CBtight.TabIndex = 4
        Me.CBtight.Text = "Плотная порода (α =0.4, β = 0.6)"
        Me.CBtight.UseVisualStyleBackColor = True
        '
        'numberOf
        '
        Me.numberOf.Location = New System.Drawing.Point(245, 138)
        Me.numberOf.Name = "numberOf"
        Me.numberOf.Size = New System.Drawing.Size(100, 27)
        Me.numberOf.TabIndex = 3
        '
        'Type
        '
        Me.Type.Location = New System.Drawing.Point(245, 23)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(100, 27)
        Me.Type.TabIndex = 2
        '
        'Result
        '
        Me.Result.CausesValidation = False
        Me.Result.Location = New System.Drawing.Point(367, 48)
        Me.Result.Multiline = True
        Me.Result.Name = "Result"
        Me.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Result.Size = New System.Drawing.Size(294, 130)
        Me.Result.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Результаты"
        '
        'HeplPage
        '
        Me.HeplPage.BackColor = System.Drawing.SystemColors.Control
        Me.HeplPage.Controls.Add(Me.dgvHelpTable)
        Me.HeplPage.Controls.Add(Me.Label21)
        Me.HeplPage.Controls.Add(Me.Label20)
        Me.HeplPage.ForeColor = System.Drawing.Color.RoyalBlue
        Me.HeplPage.Location = New System.Drawing.Point(4, 24)
        Me.HeplPage.Name = "HeplPage"
        Me.HeplPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HeplPage.Size = New System.Drawing.Size(686, 502)
        Me.HeplPage.TabIndex = 2
        Me.HeplPage.Text = "Справка"
        '
        'dgvHelpTable
        '
        Me.dgvHelpTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvHelpTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHelpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHelpTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mineral, Me.Quant, Me.InAtom, Me.Comsistence, Me.TPL, Me.AsOf})
        Me.dgvHelpTable.Location = New System.Drawing.Point(30, 65)
        Me.dgvHelpTable.Name = "dgvHelpTable"
        Me.dgvHelpTable.Size = New System.Drawing.Size(650, 220)
        Me.dgvHelpTable.TabIndex = 3
        '
        'Mineral
        '
        Me.Mineral.HeaderText = "Минерал"
        Me.Mineral.Name = "Mineral"
        '
        'Quant
        '
        Me.Quant.HeaderText = "М"
        Me.Quant.Name = "Quant"
        '
        'InAtom
        '
        Me.InAtom.HeaderText = "N"
        Me.InAtom.Name = "InAtom"
        '
        'Comsistence
        '
        Me.Comsistence.HeaderText = "ρ "
        Me.Comsistence.Name = "Comsistence"
        '
        'TPL
        '
        Me.TPL.HeaderText = "ТПЛ(°C)"
        Me.TPL.Name = "TPL"
        '
        'AsOf
        '
        Me.AsOf.HeaderText = "As"
        Me.AsOf.Name = "AsOf"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(510, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "ТПЛ - температура плавления (С), As - Коэфициент сингонии кристалла"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(34, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(537, 20)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "М - молекулярный вес, N -число атомов в молекуле, ρ  - плотность породы"
        '
        'SaveButon
        '
        Me.SaveButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SaveButon.BackgroundImage = CType(resources.GetObject("SaveButon.BackgroundImage"), System.Drawing.Image)
        Me.SaveButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveButon.CausesValidation = False
        Me.SaveButon.FlatAppearance.BorderSize = 0
        Me.SaveButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButon.ForeColor = System.Drawing.Color.Transparent
        Me.SaveButon.Location = New System.Drawing.Point(12, 466)
        Me.SaveButon.Name = "SaveButon"
        Me.SaveButon.Size = New System.Drawing.Size(65, 65)
        Me.SaveButon.TabIndex = 15
        Me.SaveButon.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DownloadButton.BackgroundImage = CType(resources.GetObject("DownloadButton.BackgroundImage"), System.Drawing.Image)
        Me.DownloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DownloadButton.CausesValidation = False
        Me.DownloadButton.FlatAppearance.BorderSize = 0
        Me.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownloadButton.ForeColor = System.Drawing.Color.Transparent
        Me.DownloadButton.Location = New System.Drawing.Point(18, 399)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(65, 65)
        Me.DownloadButton.TabIndex = 16
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'WorkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(884, 547)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.SaveButon)
        Me.Controls.Add(Me.MeneralsHendler)
        Me.Controls.Add(Me.BtnRight)
        Me.Controls.Add(Me.BtnLeft)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WorkForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Теплофизические свойства"
        Me.MeneralsHendler.ResumeLayout(False)
        Me.Minerals.ResumeLayout(False)
        Me.Minerals.PerformLayout()
        Me.SolidTapesPage.ResumeLayout(False)
        Me.SolidTapesPage.PerformLayout()
        CType(Me.dgvListOfTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeplPage.ResumeLayout(False)
        Me.HeplPage.PerformLayout()
        CType(Me.dgvHelpTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnLeft As System.Windows.Forms.Button
    Friend WithEvents BtnRight As System.Windows.Forms.Button
    Friend WithEvents MeneralsHendler As System.Windows.Forms.TabControl
    Friend WithEvents Minerals As System.Windows.Forms.TabPage
    Friend WithEvents SolidTapesPage As System.Windows.Forms.TabPage
    Friend WithEvents HeplPage As System.Windows.Forms.TabPage
    Friend WithEvents TOfType As System.Windows.Forms.TextBox
    Friend WithEvents StartTemp As System.Windows.Forms.TextBox
    Friend WithEvents EndTemp As System.Windows.Forms.TextBox
    Friend WithEvents MolWeight As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfAt As System.Windows.Forms.TextBox
    Friend WithEvents Tmelting As System.Windows.Forms.TextBox
    Friend WithEvents Density As System.Windows.Forms.TextBox
    Friend WithEvents Singinia As System.Windows.Forms.TextBox
    Friend WithEvents NameType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstResult As System.Windows.Forms.TextBox
    Friend WithEvents CbTempEffect As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Result As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBporous As System.Windows.Forms.CheckBox
    Friend WithEvents CBtight As System.Windows.Forms.CheckBox
    Friend WithEvents numberOf As System.Windows.Forms.TextBox
    Friend WithEvents Type As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dgvListOfTypes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvHelpTable As System.Windows.Forms.DataGridView
    Friend WithEvents Mineral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InAtom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comsistence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsOf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GO As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveButon As System.Windows.Forms.Button
    Friend WithEvents DownloadButton As System.Windows.Forms.Button

    Friend WithEvents nu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lambda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
