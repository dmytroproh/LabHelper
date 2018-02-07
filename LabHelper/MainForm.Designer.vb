<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Labeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLabChoise = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labeg
        '
        Me.Labeg.AutoSize = True
        Me.Labeg.Font = New System.Drawing.Font("Segoe Script", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Labeg.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Labeg.Location = New System.Drawing.Point(42, 9)
        Me.Labeg.Name = "Labeg"
        Me.Labeg.Size = New System.Drawing.Size(269, 68)
        Me.Labeg.TabIndex = 1
        Me.Labeg.Text = "Lab Helper"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'cbLabChoise
        '
        Me.cbLabChoise.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cbLabChoise.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLabChoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLabChoise.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLabChoise.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbLabChoise.FormattingEnabled = True
        Me.cbLabChoise.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cbLabChoise.Items.AddRange(New Object() {"Влажный воздух", "Геотемпературное поле", "Температурное поле вокруг выработок", "Тепловой режим горных выработок", "Теплофизические свойства"})
        Me.cbLabChoise.Location = New System.Drawing.Point(12, 88)
        Me.cbLabChoise.Name = "cbLabChoise"
        Me.cbLabChoise.Size = New System.Drawing.Size(294, 29)
        Me.cbLabChoise.Sorted = True
        Me.cbLabChoise.TabIndex = 3
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Blue
        Me.Label.Location = New System.Drawing.Point(76, 149)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(0, 21)
        Me.Label.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Выберите лабу и вперед!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Успешой работы!"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(322, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 254)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(533, 260)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.cbLabChoise)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labeg)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Исслеждование горных пород"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Labeg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbLabChoise As System.Windows.Forms.ComboBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
