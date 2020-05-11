Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim riverName(1) As String
        Dim riverFlow(1) As String
        Dim riverDistance(1) As String
        Dim riverDate(1) As String
        Dim counter As Integer = 1

        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader("C:\\whitewaterpaddled.txt")
        Dim stringReader As String
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

        Dim i As Integer = 1
        While (i < riverName.Length)
            logTxt.Text += "Name of river: " & riverName(i) & " - River Flow: " & riverFlow(i) & " CFS" & " - River Date: " & riverDate(i) & " - River Distance: " & riverDistance(i) & " Miles" & vbNewLine & vbNewLine
            i += 1
        End While
    End Sub
End Class