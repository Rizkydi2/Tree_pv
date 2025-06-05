Public Class Form1
    Public Structure Student
        Public Name As String
        Public UTS As Double
        Public UAS As Double
        Public Total As Double
    End Structure

    Private students As New List(Of Student)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeData()
        DisplayData(students)
    End Sub

    Private Sub InitializeData()
        students.Add(New Student With {.Name = "Ahmad", .UTS = 85, .UAS = 90, .Total = 175})
        students.Add(New Student With {.Name = "Budi", .UTS = 78, .UAS = 82, .Total = 160})
        students.Add(New Student With {.Name = "Citra", .UTS = 92, .UAS = 88, .Total = 180})
        students.Add(New Student With {.Name = "Deni", .UTS = 65, .UAS = 70, .Total = 135})
        students.Add(New Student With {.Name = "Eka", .UTS = 88, .UAS = 94, .Total = 182})
        students.Add(New Student With {.Name = "Farah", .UTS = 72, .UAS = 76, .Total = 148})
        students.Add(New Student With {.Name = "Gilang", .UTS = 95, .UAS = 89, .Total = 184})
        students.Add(New Student With {.Name = "Hani", .UTS = 80, .UAS = 85, .Total = 165})
    End Sub

    Private Sub DisplayData(studentList As List(Of Student))
        ListBox1.Items.Clear()

        ListBox1.Items.Add("Name" & vbTab & vbTab & "UTS" & vbTab & "UAS" & vbTab & "Total")
        ListBox1.Items.Add("----------------------------------------")

        For Each student In studentList
            Dim displayText As String = student.Name & vbTab & vbTab &
                                      student.UTS.ToString() & vbTab &
                                      student.UAS.ToString() & vbTab &
                                      student.Total.ToString()
            ListBox1.Items.Add(displayText)
        Next

        UpdateSummary(studentList)
    End Sub

    Private Sub UpdateSummary(studentList As List(Of Student))
        ListBox2.Items.Clear()

        If studentList.Count > 0 Then
            Dim avgUTS As Double = studentList.Average(Function(s) s.UTS)
            Dim avgUAS As Double = studentList.Average(Function(s) s.UAS)
            Dim avgTotal As Double = studentList.Average(Function(s) s.Total)

            ListBox2.Items.Add("Summary Statistics:")
            ListBox2.Items.Add("------------------")
            ListBox2.Items.Add("Average UTS: " & Math.Round(avgUTS, 2).ToString())
            ListBox2.Items.Add("Average UAS: " & Math.Round(avgUAS, 2).ToString())
            ListBox2.Items.Add("Average Total: " & Math.Round(avgTotal, 2).ToString())
            ListBox2.Items.Add("Total Students: " & studentList.Count.ToString())
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim newStudent As New Student

            newStudent.Name = TextBox3.Text.Trim()

            If String.IsNullOrEmpty(newStudent.Name) Then
                MessageBox.Show("Silakan masukkan nama mahasiswa", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Double.TryParse(TextBox1.Text, newStudent.UTS) OrElse newStudent.UTS < 0 OrElse newStudent.UTS > 100 Then
                MessageBox.Show("Masukkan nilai UTS yang valid (0-100)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Focus()
                Return
            End If

            If Not Double.TryParse(TextBox2.Text, newStudent.UAS) OrElse newStudent.UAS < 0 OrElse newStudent.UAS > 100 Then
                MessageBox.Show("Masukkan nilai UAS yang valid (0-100)", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox2.Focus()
                Return
            End If

            ' Hitung total
            newStudent.Total = newStudent.UTS + newStudent.UAS

            students.Add(newStudent)

            TextBox3.Clear() ' Clear nama
            TextBox1.Clear() ' Clear UTS
            TextBox2.Clear() ' Clear UAS

            If RadioButton1.Checked Then
                DisplayHighestScores()
            ElseIf RadioButton2.Checked Then
                DisplayLowestScores()
            Else
                DisplayData(students)
            End If

            MessageBox.Show("Data mahasiswa berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error menambahkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            DisplayHighestScores()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DisplayLowestScores()
        End If
    End Sub

    Private Sub DisplayHighestScores()
        Dim topStudents = students.OrderByDescending(Function(s) s.Total).Take(5).ToList()
        DisplayData(topStudents)

        ListBox2.Items.Clear()
        ListBox2.Items.Add("Top 5 Highest Scores:")
        ListBox2.Items.Add("-------------------")

        For i As Integer = 0 To Math.Min(topStudents.Count - 1, 4)
            ListBox2.Items.Add($"{i + 1}. {topStudents(i).Name} - {topStudents(i).Total}")
        Next
    End Sub

    Private Sub DisplayLowestScores()
        Dim bottomStudents = students.OrderBy(Function(s) s.Total).Take(5).ToList()
        DisplayData(bottomStudents)

        ListBox2.Items.Clear()
        ListBox2.Items.Add("Top 5 Lowest Scores:")
        ListBox2.Items.Add("-------------------")

        For i As Integer = 0 To Math.Min(bottomStudents.Count - 1, 4)
            ListBox2.Items.Add($"{i + 1}. {bottomStudents(i).Name} - {bottomStudents(i).Total}")
        Next
    End Sub

    Private Sub ResetView()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        DisplayData(students)
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs)
        ResetView()
    End Sub

End Class