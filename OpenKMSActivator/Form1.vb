Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private isWindowsMode As Boolean = True

    Private Sub ActivateButton_Click(sender As Object, e As EventArgs) Handles ActivateButton.Click
        If isWindowsMode Then
            ActivateWindows()
        Else
            ActivateOffice()
        End If
    End Sub

    Private Sub WindowsButton_Click(sender As Object, e As EventArgs) Handles WindowsButton.Click
        isWindowsMode = True
        LogTextBox.Text = "Прехвърлен към режим Windows."
    End Sub

    Private Sub OfficeButton_Click(sender As Object, e As EventArgs) Handles OfficeButton.Click
        isWindowsMode = False
        LogTextBox.Text = "Прехвърлен към режим Office."
    End Sub

    Private Sub ActivateWindows()
        Dim version As String = GetWindowsVersion()

        Dim kmsKey As String = GetKmsKey(version)
        If String.IsNullOrEmpty(kmsKey) Then
            LogTextBox.Text = "Unable to find a matching KMS key for the Windows version and edition."
            Return
        End If

        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = "cscript"
        processInfo.Arguments = $"/nologo slmgr.vbs /ipk {kmsKey} /skms kms8.msguides.com /ato"

        RunActivationProcess(processInfo, "Windows")
    End Sub

    Private Sub ActivateOffice()
        Dim selectedVersion As String = OfficeVersionComboBox.SelectedItem.ToString()

        Dim kmsKey As String = GetKmsKey(selectedVersion)
        If String.IsNullOrEmpty(kmsKey) Then
            LogTextBox.Text = "Unable to find a matching KMS key for the selected Office version."
            Return
        End If

        Dim osppPath As String = GetOsppVbsPath(selectedVersion)
        If String.IsNullOrEmpty(osppPath) Then
            LogTextBox.Text = "Unable to locate the ospp.vbs script for the selected Office version."
            Return
        End If

        Dim processInfo As New ProcessStartInfo()
        processInfo.FileName = "cscript"
        processInfo.Arguments = $"/nologo ""{osppPath}"" /inpkey:{kmsKey} /sethst:kms8.msguides.com /act"

        RunActivationProcess(processInfo, "Office")
    End Sub

    Private Function GetOsppVbsPath(version As String) As String
        Dim osppPaths As New Dictionary(Of String, String)()

        ' Add the Office version and the corresponding ospp.vbs script path here
        osppPaths.Add("Office 2016", "C:\Program Files\Microsoft Office\Office16\ospp.vbs")
        osppPaths.Add("Office 2013", "C:\Program Files\Microsoft Office\Office15\ospp.vbs")
        osppPaths.Add("Office 2010", "C:\Program Files\Microsoft Office\Office14\ospp.vbs")
        ' Add more versions and paths as needed

        If osppPaths.ContainsKey(version) Then
            Return osppPaths(version)
        End If

        Return String.Empty
    End Function
    Private Function GetWindowsVersion() As String
        Dim version As String = String.Empty
        Dim productKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProductName"
        Dim productName As Object = My.Computer.Registry.GetValue(productKey, "", Nothing)
        If productName IsNot Nothing Then
            version = productName.ToString()
        End If
        Return version
    End Function

    Private Function GetKmsKey(version As String) As String
        Dim kmsKeys As New Dictionary(Of String, String)()

        ' Add your KMS keys and their corresponding versions and editions here
        kmsKeys.Add("Windows 10 Pro", "W269N-WFGWX-YVC9B-4J6C9-T83GX")
        kmsKeys.Add("Windows 11 Pro", "W269N-WFGWX-YVC9B-4J6C9-T83GX")
        kmsKeys.Add("Windows 10 Pro N", "MH37W-N47XK-V7XM9-C7227-GCQG9")
        kmsKeys.Add("Windows 11 Pro N", "MH37W-N47XK-V7XM9-C7227-GCQG9")
        kmsKeys.Add("Windows 10 Enterprise", "NPPR9-FWDCX-D2C8J-H872K-2YT43")
        kmsKeys.Add("Windows 11 Enterprise", "NPPR9-FWDCX-D2C8J-H872K-2YT43")
        kmsKeys.Add("Windows 11 Enterprise N", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW43")
        kmsKeys.Add("Windows 11 Enterprise G", "YYVX9-NTFWV-6MDM3-9PT4T-4M68B")
        kmsKeys.Add("Windows 10 Enterprise G", "YYVX9-NTFWV-6MDM3-9PT4T-4M68B")
        kmsKeys.Add("Windows 10 Enterprise N", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW43")
        kmsKeys.Add("Windows 10 Enterprise G N", "44RPN-FTY23-9VTTB-MP9BX-T84FV")
        kmsKeys.Add("Windows 11 Enterprise G N", "44RPN-FTY23-9VTTB-MP9BX-T84FV")
        kmsKeys.Add("Windows 8.1 Enterprise N", "TT4HM-HN7YT-62K67-RGRQJ-JFFXW")
        kmsKeys.Add("Windows 8.1 Enterprise", "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7")
        kmsKeys.Add("Windows 8.1 Pro", "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9")
        kmsKeys.Add("Windows 8.1 Pro N", "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY")
        kmsKeys.Add("Windows 7 Enterprise N", "YDRBP-3D83W-TY26F-D46B2-XCKRJ")
        kmsKeys.Add("Windows 7 Enterprise", "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH")
        kmsKeys.Add("Windows 7 Professional", "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4")
        kmsKeys.Add("Windows 7 Professional N", "MRPKT-YTG23-K7D7T-X2JMM-QY7MG")
        kmsKeys.Add("Windows 7 Enterprise E", "C29WB-22CC8-VJ326-GHFJW-H9DH4+")
        kmsKeys.Add("Windows 7 Professional E", "W82YF-2Q76Y-63HXB-FGJG9-GF7QX")
        kmsKeys.Add("Office 2016", "XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99") ' Pro Plus
        kmsKeys.Add("Office 2013", "YC7DK-G2NP3-2QQC3-J6H88-GVGXT") ' Pro Plus
        kmsKeys.Add("Office 2010", "VYBBJ-TRJPB-QFQRF-QFT4D-H3GVB") ' Pro Pluss
        ' Add more keys as needed

        If isWindowsMode Then
            Dim key As String = $"{version}"
            If kmsKeys.ContainsKey(key) Then
                Return kmsKeys(key)
            End If
        Else
            If kmsKeys.ContainsKey(version) Then
                Return kmsKeys(version)
            End If
        End If

        Return String.Empty
    End Function

    Private Sub RunActivationProcess(processInfo As ProcessStartInfo, productName As String)
        LogTextBox.Text = $"Activating {productName}..."
        LogTextBox.AppendText(Environment.NewLine)

        processInfo.RedirectStandardOutput = True
        processInfo.UseShellExecute = False
        processInfo.CreateNoWindow = True

        Dim process As Process = Process.Start(processInfo)
        Dim output As String = process.StandardOutput.ReadToEnd()
        process.WaitForExit()

        If process.ExitCode = 0 Then
            LogTextBox.AppendText(output)
            LogTextBox.AppendText(Environment.NewLine)
            LogTextBox.AppendText($"{productName} activation successful!")
        Else
            LogTextBox.AppendText(output)
            LogTextBox.AppendText(Environment.NewLine)
            LogTextBox.AppendText($"{productName} activation failed!")
        End If
    End Sub
End Class
