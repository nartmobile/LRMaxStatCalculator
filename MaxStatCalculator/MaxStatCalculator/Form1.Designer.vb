<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stat1EnterField = New System.Windows.Forms.TextBox()
        Me.stat2EnterField = New System.Windows.Forms.TextBox()
        Me.stat3EnterField = New System.Windows.Forms.TextBox()
        Me.enhanceLevelEnterField = New System.Windows.Forms.TextBox()
        Me.stat3ReturnField = New System.Windows.Forms.TextBox()
        Me.stat2ReturnField = New System.Windows.Forms.TextBox()
        Me.stat1ReturnField = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.desEnhanceLevelEnterField = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(89, 252)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(92, 36)
        Me.calculateButton.TabIndex = 0
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(201, 252)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(92, 36)
        Me.resetButton.TabIndex = 1
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(313, 252)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(92, 36)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LINE Rangers Gear Max Stat Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stat 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Stat 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stat 3:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(123, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Current Enhancement Level:"
        '
        'stat1EnterField
        '
        Me.stat1EnterField.Location = New System.Drawing.Point(119, 73)
        Me.stat1EnterField.Name = "stat1EnterField"
        Me.stat1EnterField.Size = New System.Drawing.Size(100, 29)
        Me.stat1EnterField.TabIndex = 11
        '
        'stat2EnterField
        '
        Me.stat2EnterField.Location = New System.Drawing.Point(119, 106)
        Me.stat2EnterField.Name = "stat2EnterField"
        Me.stat2EnterField.Size = New System.Drawing.Size(100, 29)
        Me.stat2EnterField.TabIndex = 12
        '
        'stat3EnterField
        '
        Me.stat3EnterField.Location = New System.Drawing.Point(119, 139)
        Me.stat3EnterField.Name = "stat3EnterField"
        Me.stat3EnterField.Size = New System.Drawing.Size(100, 29)
        Me.stat3EnterField.TabIndex = 13
        '
        'enhanceLevelEnterField
        '
        Me.enhanceLevelEnterField.Location = New System.Drawing.Point(333, 175)
        Me.enhanceLevelEnterField.Name = "enhanceLevelEnterField"
        Me.enhanceLevelEnterField.Size = New System.Drawing.Size(100, 29)
        Me.enhanceLevelEnterField.TabIndex = 17
        '
        'stat3ReturnField
        '
        Me.stat3ReturnField.Location = New System.Drawing.Point(333, 141)
        Me.stat3ReturnField.Name = "stat3ReturnField"
        Me.stat3ReturnField.ReadOnly = True
        Me.stat3ReturnField.Size = New System.Drawing.Size(100, 29)
        Me.stat3ReturnField.TabIndex = 23
        Me.stat3ReturnField.TabStop = False
        '
        'stat2ReturnField
        '
        Me.stat2ReturnField.Location = New System.Drawing.Point(333, 107)
        Me.stat2ReturnField.Name = "stat2ReturnField"
        Me.stat2ReturnField.ReadOnly = True
        Me.stat2ReturnField.Size = New System.Drawing.Size(100, 29)
        Me.stat2ReturnField.TabIndex = 22
        Me.stat2ReturnField.TabStop = False
        '
        'stat1ReturnField
        '
        Me.stat1ReturnField.Location = New System.Drawing.Point(333, 73)
        Me.stat1ReturnField.Name = "stat1ReturnField"
        Me.stat1ReturnField.ReadOnly = True
        Me.stat1ReturnField.Size = New System.Drawing.Size(100, 29)
        Me.stat1ReturnField.TabIndex = 21
        Me.stat1ReturnField.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "New Stat 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "New Stat 2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "New Stat 1:"
        '
        'desEnhanceLevelEnterField
        '
        Me.desEnhanceLevelEnterField.Location = New System.Drawing.Point(333, 209)
        Me.desEnhanceLevelEnterField.Name = "desEnhanceLevelEnterField"
        Me.desEnhanceLevelEnterField.Size = New System.Drawing.Size(100, 29)
        Me.desEnhanceLevelEnterField.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(123, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 21)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Desired Enhancement Level:"
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 311)
        Me.Controls.Add(Me.desEnhanceLevelEnterField)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.stat3ReturnField)
        Me.Controls.Add(Me.stat2ReturnField)
        Me.Controls.Add(Me.stat1ReturnField)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.enhanceLevelEnterField)
        Me.Controls.Add(Me.stat3EnterField)
        Me.Controls.Add(Me.stat2EnterField)
        Me.Controls.Add(Me.stat1EnterField)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "LINE Rangers Gear Max Stat Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calculateButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stat1EnterField As TextBox
    Friend WithEvents stat2EnterField As TextBox
    Friend WithEvents stat3EnterField As TextBox
    Friend WithEvents enhanceLevelEnterField As TextBox
    Friend WithEvents stat3ReturnField As TextBox
    Friend WithEvents stat2ReturnField As TextBox
    Friend WithEvents stat1ReturnField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents desEnhanceLevelEnterField As TextBox
    Friend WithEvents Label9 As Label
End Class
