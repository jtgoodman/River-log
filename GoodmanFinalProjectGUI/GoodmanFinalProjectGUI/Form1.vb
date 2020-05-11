Imports System
Imports System.IO
Imports System.Collections
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim riverName(1) As String
        Dim riverFlow(1) As String
        Dim riverDistance(1) As String
        Dim riverDate(1) As String
        Dim counter As Integer = 1
        Dim stringReader As String

        If IO.File.Exists("C:\whitewaterpaddled.txt") Then
            'good
        Else
            MsgBox("file could Not be found")
            Application.Exit()
        End If
        Dim fileReader As System.IO.StreamReader
        fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\whitewaterpaddled.txt")
        stringReader = fileReader.ReadLine()

        While (stringReader IsNot Nothing)
            'process the line
            If counter > 4 Then
                counter = counter - 4
            End If
            If counter = 1 Then
                Array.Resize(riverName, riverName.Length + 1)
                riverName(riverName.Length - 1) = stringReader
                counter += 1
            ElseIf counter = 2 Then
                Array.Resize(riverFlow, riverFlow.Length + 1)
                riverFlow(riverFlow.Length - 1) = stringReader
                counter += 1
            ElseIf counter = 3 Then
                Array.Resize(riverDistance, riverDistance.Length + 1)
                riverDistance(riverDistance.Length - 1) = stringReader
                counter += 1
            Else
                Array.Resize(riverDate, riverDate.Length + 1)
                riverDate(riverDate.Length - 1) = stringReader
                counter += 1
            End If
            stringReader = fileReader.ReadLine
        End While
        fileReader.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim riverName As String
        Dim riverFlow As Integer
        Dim riverDistance As Double
        Dim riverDate As Date
        Dim numericCheck As Boolean = False

        Try
            riverFlow = txtFlow.Text
        Catch Exception As SystemException
            MsgBox("River Flow must be numeric")
            txtFlow.Text = -1
            txtFlow.Focus()
        End Try

        Try
            riverDistance = txtDistance.Text
        Catch Exception As SystemException
            MsgBox("River Distance must be numeric")
            txtDistance.Text = -1
            txtDistance.Focus()
        End Try

        riverDate = txtDate.Text
        riverName = txtRiver.Text


        If txtRiver.Text = "" Then
            MsgBox("You must enter a river Name")
            txtRiver.Focus()
        ElseIf txtDistance.Text < 0 Then
            MsgBox("river distance must be positive number")
            txtDistance.Focus()
        ElseIf txtFlow.Text < 0 Then
            MsgBox("river flow must be positive number")
            txtFlow.Focus()
        Else
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\whitewaterpaddled.txt", True)
            file.WriteLine(riverName)
            file.WriteLine(riverFlow)
            file.WriteLine(riverDistance)
            file.WriteLine(riverDate)
            file.Close()
            MsgBox("Saved succesfully")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRiver.Clear()
        txtFlow.Clear()
        txtDistance.Clear()
        txtDate.ResetText()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ttlMile As Integer
        Dim counter As Integer = 1
        Dim ttlMile2 As Integer

        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\whitewaterpaddled.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()


        While (stringReader IsNot Nothing)
            'process the line
            If counter > 4 Then
                counter = counter - 4
            End If
            If counter = 3 Then
                ttlMile = CInt(stringReader)
                ttlMile2 += ttlMile
            End If
            stringReader = fileReader.ReadLine
            counter += 1
        End While
        fileReader.Close()
        ttlMiles.Text = "Total miles paddled: " & ttlMile2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim riverDate(0) As String
        Dim counter As Integer = 1

        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\whitewaterpaddled.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()


        While (stringReader IsNot Nothing)
            'process the line
            If counter > 4 Then
                counter = counter - 4
            End If
            If counter = 4 Then
                Array.Resize(riverDate, riverDate.Length + 1)
                riverDate(riverDate.Length - 1) = stringReader
            End If
            stringReader = fileReader.ReadLine
            counter += 1
        End While
        fileReader.Close()
        ttlRivers.Text = "Total paddling sessions: " & riverDate.Length - 1
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub
End Class
