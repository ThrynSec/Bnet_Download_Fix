Imports System.Security.Principal

Public Class FormCorrect

    Dim identity = WindowsIdentity.GetCurrent()
    Dim program = New WindowsPrincipal(identity)
    Dim isAdmin As Boolean = program.IsInRole(WindowsBuiltInRole.Administrator)
    Dim userName As String = Environment.UserName.ToString

    Private Sub FormCorrect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ProgramData, le cache principal et celui qui est majoritairement la cause des bugs, est protégé et ne peut être supprimé que par un admin

        If isAdmin = False Then
            MsgBox("Merci de relancer le programme en mode administrateur", MsgBoxStyle.Critical)
            Me.Close()
        End If

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles PatchButton.Click

        On Error Resume Next
        System.IO.Directory.Delete("C:\Users\" & userName & "\AppData\Roaming\Battle.net", True)
        PBar.Value = 20

        System.IO.Directory.Delete("C:\Users\" & userName & "\AppData\Local\Battle.net", True)
        PBar.Value = 40

        System.IO.Directory.Delete("C:\Users\" & userName & "\AppData\Local\Temp\Battle.net", True)
        PBar.Value = 65

        System.IO.Directory.Delete("C:\ProgramData\Battle.net", True)
        PBar.Value = 100
        On Error GoTo 0

        MsgBox("Suppression des caches terminée ! Relancez votre ordinateur et vous devriez pouvoir installer Battle.net correctement")

        Me.Close()

    End Sub
End Class
