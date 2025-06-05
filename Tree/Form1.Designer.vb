<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        ListBox2 = New ListBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(978, 289)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "[Data Entry]"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(423, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 8
        Label4.Text = "Summary :"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(423, 58)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(539, 204)
        ListBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(21, 197)
        Button1.Name = "Button1"
        Button1.Size = New Size(330, 40)
        Button1.TabIndex = 7
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(26, 58)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(325, 31)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(201, 142)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(201, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 25)
        Label3.TabIndex = 4
        Label3.Text = "UAS :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(26, 142)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(146, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 25)
        Label1.TabIndex = 2
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 25)
        Label2.TabIndex = 3
        Label2.Text = "UTS :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListBox2)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(12, 317)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(978, 179)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "[Filtering]"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(413, 30)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(549, 129)
        ListBox2.TabIndex = 8
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(205, 57)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(141, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Lowest Score"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(25, 57)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(147, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Highest Score"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 567)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label

End Class
