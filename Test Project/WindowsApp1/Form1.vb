Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stInput1 As String
        Dim stInput2 As Integer
        Dim stInput3 As Integer
        Dim stInput4 As Integer
        Dim stInput5 As Integer
        Dim stInput6 As Integer
        Dim sum As Integer

        stInput1 = TextBox1

        MsgBox("Grade: " & stInput1)
        stInput1 = txtTextbox1.text


    End Sub
' Orlando Abregu, CPT 341, 
' started UNIX 1663629560
'   notes: Began Structure build. Not sure about how to link text boxes
'   Let alone do the rest. Check an online guide on VB for basic functionality
' UNX 1663886590: starting to work on project. Variables announced through dim statement (Dim {name} as [data type])
'   should probably use short num data type as original problem has weird decimals.
'   can I use integer? maybe if I convert string to integer...