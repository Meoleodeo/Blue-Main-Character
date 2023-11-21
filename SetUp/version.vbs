Option Explicit

Dim objShell
Set objShell = WScript.CreateObject("WScript.Shell")

Dim intButton
intButton = MsgBox("Welcome! Would you like to visit our site and check the new version?", vbInformation + vbOKCancel, "Blue Main Character")

If intButton = vbOK Then
    objShell.Run "https://github.com/Meoleodeo/Blue-Main-Character/releases"
Else
    MsgBox "Curent version: V2.1.", vbInformation, "Blue Main Character"
End If

Set objShell = Nothing
