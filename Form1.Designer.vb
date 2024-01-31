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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clear2btn = New System.Windows.Forms.Button()
        Me.clear1btn = New System.Windows.Forms.Button()
        Me.SortBtn = New System.Windows.Forms.Button()
        Me.nextStepBtn = New System.Windows.Forms.Button()
        Me.noOfElements = New System.Windows.Forms.ListBox()
        Me.arrayElements = New System.Windows.Forms.ListBox()
        Me.Inpot = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Array List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 136)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'clear2btn
        '
        Me.clear2btn.BackColor = System.Drawing.Color.Orange
        Me.clear2btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear2btn.Location = New System.Drawing.Point(371, 258)
        Me.clear2btn.Name = "clear2btn"
        Me.clear2btn.Size = New System.Drawing.Size(75, 23)
        Me.clear2btn.TabIndex = 14
        Me.clear2btn.Text = "Clear2"
        Me.clear2btn.UseVisualStyleBackColor = False
        '
        'clear1btn
        '
        Me.clear1btn.BackColor = System.Drawing.Color.Orange
        Me.clear1btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear1btn.Location = New System.Drawing.Point(371, 148)
        Me.clear1btn.Name = "clear1btn"
        Me.clear1btn.Size = New System.Drawing.Size(75, 23)
        Me.clear1btn.TabIndex = 12
        Me.clear1btn.Text = "Clear1"
        Me.clear1btn.UseVisualStyleBackColor = False
        '
        'SortBtn
        '
        Me.SortBtn.BackColor = System.Drawing.Color.Cyan
        Me.SortBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortBtn.Location = New System.Drawing.Point(167, 300)
        Me.SortBtn.Name = "SortBtn"
        Me.SortBtn.Size = New System.Drawing.Size(92, 23)
        Me.SortBtn.TabIndex = 11
        Me.SortBtn.Text = "Sort"
        Me.SortBtn.UseVisualStyleBackColor = False
        '
        'nextStepBtn
        '
        Me.nextStepBtn.BackColor = System.Drawing.Color.Yellow
        Me.nextStepBtn.Enabled = False
        Me.nextStepBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextStepBtn.Location = New System.Drawing.Point(265, 300)
        Me.nextStepBtn.Name = "nextStepBtn"
        Me.nextStepBtn.Size = New System.Drawing.Size(78, 23)
        Me.nextStepBtn.TabIndex = 10
        Me.nextStepBtn.Text = "Next Step"
        Me.nextStepBtn.UseVisualStyleBackColor = False
        '
        'noOfElements
        '
        Me.noOfElements.FormattingEnabled = True
        Me.noOfElements.Location = New System.Drawing.Point(141, 151)
        Me.noOfElements.Name = "noOfElements"
        Me.noOfElements.Size = New System.Drawing.Size(115, 43)
        Me.noOfElements.TabIndex = 19
        '
        'arrayElements
        '
        Me.arrayElements.FormattingEnabled = True
        Me.arrayElements.Location = New System.Drawing.Point(141, 238)
        Me.arrayElements.Name = "arrayElements"
        Me.arrayElements.Size = New System.Drawing.Size(224, 43)
        Me.arrayElements.TabIndex = 20
        '
        'Inpot
        '
        Me.Inpot.Location = New System.Drawing.Point(290, 148)
        Me.Inpot.Name = "Inpot"
        Me.Inpot.Size = New System.Drawing.Size(75, 43)
        Me.Inpot.TabIndex = 21
        Me.Inpot.Text = "INPUT"
        Me.Inpot.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(132, 329)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(297, 65)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 503)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Inpot)
        Me.Controls.Add(Me.arrayElements)
        Me.Controls.Add(Me.noOfElements)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear2btn)
        Me.Controls.Add(Me.clear1btn)
        Me.Controls.Add(Me.SortBtn)
        Me.Controls.Add(Me.nextStepBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear2btn As System.Windows.Forms.Button
    Friend WithEvents clear1btn As System.Windows.Forms.Button
    Friend WithEvents SortBtn As System.Windows.Forms.Button
    Friend WithEvents nextStepBtn As System.Windows.Forms.Button
    Friend WithEvents noOfElements As System.Windows.Forms.ListBox
    Friend WithEvents arrayElements As System.Windows.Forms.ListBox
    Friend WithEvents Inpot As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
