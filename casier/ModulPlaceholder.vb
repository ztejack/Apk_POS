Module ModulPlaceholder
    Private Declare Function GetWindow Lib "user32.dll" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Private Declare Auto Function SendMessageString Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
    Const GW_CHILD = 5
    Const EM_SETCUEBANNER = &H1501
    Sub SetWatermark(ByVal Ctl As TextBox, ByVal Txt As String)
        SendMessageString(Ctl.Handle, EM_SETCUEBANNER, 1, Txt)
    End Sub
    Sub SetWatermark(ByVal Ctl As ComboBox, ByVal Txt As String)
        Dim i As Integer
        i = GetWindow(Ctl.Handle, GW_CHILD)
        SendMessageString(i, EM_SETCUEBANNER, 1, Txt)
    End Sub
End Module
