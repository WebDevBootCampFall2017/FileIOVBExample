Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Open File Dialog
        Dim ofd As OpenFileDialog = New OpenFileDialog()

        'get the file from the user
        Dim dr As DialogResult = ofd.ShowDialog()

        'Get Filename from dialog result
        Dim filename = ofd.FileName

        'get Stream Reader
        Dim fr = New StreamReader(filename)

        'Read Lines until we ge the the end of the file
        While Not fr.EndOfStream
            TextBox1.Text += fr.ReadLine()
        End While

        'Close File reader
        fr.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Branch on status of the checkbox
        If CheckBox1.Checked Then
            'If it's checked, set word wrap
            TextBox1.WordWrap = True
        Else
            'If not, set it to false
            TextBox1.WordWrap = False
        End If
    End Sub
End Class
