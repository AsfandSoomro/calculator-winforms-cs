<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnPercentage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(12, 56)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(245, 57)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Gold
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(12, 256)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(52, 34)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Gold
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.Location = New System.Drawing.Point(75, 256)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(52, 34)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.Gold
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnEqual.ForeColor = System.Drawing.Color.Black
        Me.btnEqual.Location = New System.Drawing.Point(205, 258)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(52, 76)
        Me.btnEqual.TabIndex = 3
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gold
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(205, 214)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(52, 34)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(12, 125)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(52, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "CE"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Gold
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.Location = New System.Drawing.Point(139, 256)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(52, 34)
        Me.btn3.TabIndex = 6
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Gold
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Black
        Me.btn4.Location = New System.Drawing.Point(12, 212)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(52, 34)
        Me.btn4.TabIndex = 7
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Gold
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Black
        Me.btn5.Location = New System.Drawing.Point(75, 212)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(52, 34)
        Me.btn5.TabIndex = 8
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Gold
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Black
        Me.btn6.Location = New System.Drawing.Point(139, 212)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(52, 34)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Gold
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Black
        Me.btn7.Location = New System.Drawing.Point(12, 170)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(52, 34)
        Me.btn7.TabIndex = 10
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Gold
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Black
        Me.btn8.Location = New System.Drawing.Point(75, 170)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(52, 34)
        Me.btn8.TabIndex = 11
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Gold
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Black
        Me.btn9.Location = New System.Drawing.Point(139, 170)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(52, 34)
        Me.btn9.TabIndex = 12
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.Gold
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.Black
        Me.btn0.Location = New System.Drawing.Point(75, 302)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(52, 34)
        Me.btn0.TabIndex = 13
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.Gold
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.Color.Black
        Me.btnMinus.Location = New System.Drawing.Point(205, 170)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(52, 34)
        Me.btnMinus.TabIndex = 14
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Gold
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(205, 124)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(52, 34)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "<"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.Gold
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnMultiply.ForeColor = System.Drawing.Color.Black
        Me.btnMultiply.Location = New System.Drawing.Point(139, 124)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(52, 34)
        Me.btnMultiply.TabIndex = 16
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.Gold
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnDivide.ForeColor = System.Drawing.Color.Black
        Me.btnDivide.Location = New System.Drawing.Point(75, 124)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(52, 34)
        Me.btnDivide.TabIndex = 17
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnDot
        '
        Me.btnDot.BackColor = System.Drawing.Color.Gold
        Me.btnDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnDot.ForeColor = System.Drawing.Color.Black
        Me.btnDot.Location = New System.Drawing.Point(139, 300)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(52, 34)
        Me.btnDot.TabIndex = 18
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = False
        '
        'btnPercentage
        '
        Me.btnPercentage.BackColor = System.Drawing.Color.Gold
        Me.btnPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btnPercentage.ForeColor = System.Drawing.Color.Black
        Me.btnPercentage.Location = New System.Drawing.Point(12, 302)
        Me.btnPercentage.Name = "btnPercentage"
        Me.btnPercentage.Size = New System.Drawing.Size(52, 34)
        Me.btnPercentage.TabIndex = 19
        Me.btnPercentage.Text = "%"
        Me.btnPercentage.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(269, 386)
        Me.Controls.Add(Me.btnPercentage)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtDisplay)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnPercentage As Button
End Class
