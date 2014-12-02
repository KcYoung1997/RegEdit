Public Class Form1
    Dim test As Microsoft.Win32.RegistryKey
    Dim CR = My.Computer.Registry.ClassesRoot
    Dim CRn = 18
    Dim CU = My.Computer.Registry.CurrentUser
    Dim CUn = 18
    Dim LM = My.Computer.Registry.LocalMachine
    Dim LMn = 19
    Dim US = My.Computer.Registry.Users
    Dim USn = 11
    Dim CC = My.Computer.Registry.CurrentConfig
    Dim CCn = 20
    Dim dataTypes = New String() {"", "REG_SZ", "REG_EXPAND_SZ", "REG_BINARY", "REG_DWORD", "", "", "REG_MULTI_SZ", "", "", "", "REG_QWORD"}

    Private Sub addKeys() Handles folderView.AfterSelect
        'Setup variables and clear current items
        folderView.SelectedNode.Nodes.Clear()
        Dim subKey
        Dim fullpath = folderView.SelectedNode.FullPath
        subKey = getSubKey(fullpath)

        Try
            For Each item In subKey.GetSubkeyNames
                folderView.SelectedNode.Nodes.Add(item)
            Next
        Catch e As NullReferenceException
        End Try
        listView.Items.Clear()
        addItems(subKey)
    End Sub

    Private Sub addItems(subKey)
        Dim lvi As ListViewItem
        For Each var In subKey.GetValueNames()
            If var = "" Then
                lvi = listView.Items.Add("(Default)")
                lvi.SubItems.Add(dataTypes(subKey.GetValueKind(var)))
                lvi.SubItems.Add(subKey.GetValue(var))
            Else
                lvi = listView.Items.Add(var)
                lvi.SubItems.Add(dataTypes(subKey.GetValueKind(var)))
                lvi.SubItems.Add(subKey.GetValue(var).ToString)
            End If
        Next
    End Sub


    Private Sub edit() Handles listView.DoubleClick
        Dim keyName, pathName, openKey, keyValue, newValue
        keyName = listView.SelectedItems.Item(0).Text
        pathName = folderView.SelectedNode.FullPath.ToString & "\"
        openKey = getSubKey(pathName)
        Try
            keyValue = openKey.GetValue(keyName).ToString
        Catch ex As Exception
            keyValue = ""
        End Try
        newValue = InputBox("Enter a New value for " & keyName, keyName, keyValue)
        Try
            openKey.SetValue(keyName, newValue)
        Catch ex As Exception
            MsgBox("Unable to set key, you may not have acsess")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function getSubKey(key)
        Select Case key
            Case "HKEY_CLASSES_ROOT"
                Return CR
            Case "HKEY_CURRENT_USER"
                Return CU
            Case "HKEY_LOCAL_MACHINE"
                Return LM
            Case "HKEY_USERS"
                Return US
            Case "HKEY_CURRENT_CONFIG"
                Return CC
            Case Else
                Dim location
                Dim number
                If key.Contains("HKEY_CLASSES_ROOT") Then
                    location = CR
                    number = CRn
                ElseIf key.Contains("HKEY_CURRENT_USER") Then
                    location = CU
                    number = CUn
                ElseIf key.Contains("HKEY_LOCAL_MACHINE") Then
                    location = LM
                    number = LMn
                ElseIf key.Contains("HKEY_USERS") Then
                    location = US
                    number = USn
                ElseIf key.Contains("HKEY_CURRENT_CONFIG") Then
                    location = CC
                    number = CCn
                End If
                Try
                    Dim test = location.OpenSubKey(key.Substring(number), True)
                    Return test
                Catch exc As Exception
                    MessageBox.Show("You cannot access this part of the registry without adminastrator access. If you are administrator run this application by right clicking and selecting 'Run as Administartor'")
                End Try
        End Select
    End Function

End Class