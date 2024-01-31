Imports System.Drawing
Public Class Form1
    Dim input() As Integer 'Dynamic array
    Dim intParser As Integer
    Dim inputChecker As String

    Dim num, i, j, temp As Integer

    Private Sub SelectionSort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length

        For i As Integer = 0 To n - 2
            Dim minIndex As Integer = i

            ' Find the minimum element in the unsorted part of the array
            For j As Integer = i + 1 To n - 1
                If arr(j) < arr(minIndex) Then
                    minIndex = j
                End If
            Next

            ' Swap the found minimum element with the first element
            If minIndex <> i Then
                Dim temp As Integer = arr(i)
                arr(i) = arr(minIndex)
                arr(minIndex) = temp
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inpot.Click
        arrayElements.Items.Clear()
        noOfElements.Items.Clear()
        Dim flags As Boolean
        flags = True

        While flags = True
            inputChecker = Val(InputBox("Enter the size of the array..."))
            If inputChecker = "" Then
                MessageBox.Show("This field cannot be empty. .")
                Continue While
            End If


            If Integer.TryParse(inputChecker, num) Then
                ' num successfully parsed as Integer

                If num > 20 Or num < 1 Then
                    MessageBox.Show("Enter an integral value<=20 and >=1.")
                    Continue While
                    If inputChecker = "" Then
                        Continue While
                    End If

                Else
                    flags = False

                End If
            Else
                ' num is not an Integer
                MessageBox.Show("Enter an integer .... .")
                Continue While
            End If
        End While


        noOfElements.Items.Add(num)
        ReDim input(num - 1)

        For i As Integer = 0 To num - 1

            flags = True

            While flags = True
                inputChecker = Val(InputBox("Enter the elements of the array one by one and press OK each time to clear all the fields press cancel or enter nothing NOTE DO NOT ENTER 0..."))
                If inputChecker = "" Or inputChecker = " " Or inputChecker = "0" Then
                    MessageBox.Show("This field cannot be empty. .nor can it be invalid..")
                    Continue While
                End If


                If Integer.TryParse(inputChecker, temp) Then
                    ' num successfully zparsed as Integer

                    If temp >= 100 Or temp <= -100 Then
                        MessageBox.Show("Enter a value between -99 and +99 both inclusive.")
                        Continue While


                    Else
                        input(i) = temp
                        flags = False

                    End If
                Else
                    ' num is not an Integer
                    MessageBox.Show("Enter an integer .... .")
                    Continue While

                End If
            End While
            arrayElements.Items.Add(input(i))

        Next

    End Sub


    Private Sub clear1btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear1btn.Click
        noOfElements.Items.Clear()

    End Sub

    Private Sub clear2btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear2btn.Click
        arrayElements.Items.Clear()
    End Sub

    Private Sub sortBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortBtn.Click
        RichTextBox1.Clear()


        SelectionSort(input)
        'Console.WriteLine(input(0))

        For i As Integer = 0 To num - 1
            RichTextBox1.AppendText(input(i))
            RichTextBox1.AppendText(" | ")
        Next


    End Sub

    Private Sub nextStepBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextStepBtn.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub noOfElements_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noOfElements.SelectedIndexChanged

    End Sub

    Private Sub arrayElements_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrayElements.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
