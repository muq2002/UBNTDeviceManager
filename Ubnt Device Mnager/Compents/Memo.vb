Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module Memo
    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Function EncryptTEXT(ByRef plaintext As String) As String

        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "MD5"

        Dim passwordIterations As Integer = 5
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plaintext)


        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
    Public Function DecryptTEXT(ByRef encryptedtext As String) As String
        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "MD5"

        Dim passwordIterations As Integer = 5
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        ' Convert our ciphertext into a byte array.
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(encryptedtext)

        ' First, we must create a password, from which the key will be 
        ' derived. This password will be generated from the specified 
        ' passphrase and salt value. The password will be created using
        ' the specified hash algorithm. Password creation can be done in
        ' several iterations.
        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        ' Use the password to generate pseudo-random bytes for the encryption
        ' key. Specify the size of the key in bytes (instead of bits).
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        ' Create uninitialized Rijndael encryption object.
        Dim symmetricKey As New RijndaelManaged()

        ' It is reasonable to set encryption mode to Cipher Block Chaining
        ' (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC

        ' Generate decryptor from the existing key bytes and initialization 
        ' vector. Key size will be defined based on the number of the key 
        ' bytes.
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        ' Define memory stream which will be used to hold encrypted data.
        Dim memoryStream As New MemoryStream(cipherTextBytes)

        ' Define cryptographic stream (always use Read mode for encryption).
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        ' Since at this point we don't know what the size of decrypted data
        ' will be, allocate the buffer long enough to hold ciphertext;
        ' plaintext is never longer than ciphertext.
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

        ' Start decrypting.
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        ' Close both streams.
        memoryStream.Close()
        cryptoStream.Close()

        ' Convert decrypted data into a string. 
        ' Let us assume that the original plaintext string was UTF8-encoded.
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        ' Return decrypted string.   
        Return plainText
    End Function

    ' New Setting Read

    Public Function SettingRead()
        Dim Text, NewText As String
        Dim Counter As Integer
        NewText = My.Settings.IPs
        Text = My.Settings.IPs
        If Text <> "" Then
            ' Add Number 
            Counter = CounterIPs(My.Settings.IPs)
            For Row = 0 To Counter
                Main.ListSpy.Items().Add(Main.ListSpy.Items().Count + 1)
                For Col As Integer = 1 To 14
                    Main.ListSpy.Items(Row).SubItems().Add("")
                Next Col
            Next Row
            '  Add IPs Address
            For L = 0 To Counter
                If NewText.IndexOf(",") > -1 Then
                    Main.ListSpy.Items(L).SubItems(1).Text = NewText.Substring(0, Text.IndexOf(","))
                    NewText = NewText.Remove(0, Text.IndexOf(",") + 1)
                Else
                    Main.ListSpy.Items(L).SubItems(1).Text = NewText
                    Exit For
                End If
            Next
            ' Add Name Drive
            NewText = My.Settings.Devname
            For L = 0 To Counter
                If NewText.IndexOf(",") > -1 Then
                    Main.ListSpy.Items(L).SubItems(2).Text = NewText.Substring(0, NewText.IndexOf(","))
                    NewText = NewText.Remove(0, NewText.IndexOf(",") + 1)
                Else
                    Main.ListSpy.Items(L).SubItems(2).Text = NewText
                    Exit For
                End If
            Next

            ' Add Product Device Model
            NewText = My.Settings.Product

            For L = 0 To Counter
                If NewText.IndexOf(",") > -1 Then
                    Main.ListSpy.Items(L).SubItems(3).Text = NewText.Substring(0, NewText.IndexOf(","))
                    NewText = NewText.Remove(0, NewText.IndexOf(",") + 1)
                Else
                    Main.ListSpy.Items(L).SubItems(3).Text = NewText
                    Exit For
                End If
            Next

            ' Add SSID
            NewText = My.Settings.SSID
            For L = 0 To Counter
                If NewText.IndexOf(",") > -1 Then
                    Main.ListSpy.Items(L).SubItems(11).Text = NewText.Substring(0, NewText.IndexOf(","))
                    NewText = NewText.Remove(0, NewText.IndexOf(",") + 1)
                Else
                    Main.ListSpy.Items(L).SubItems(11).Text = NewText
                    Exit For
                End If
            Next

            ' Add Username
            NewText = My.Settings.User

            For L = 0 To Counter
                If NewText.IndexOf(",") > -1 Then
                    Main.ListSpy.Items(L).SubItems(12).Text = NewText.Substring(0, NewText.IndexOf(","))
                    NewText = NewText.Remove(0, NewText.IndexOf(",") + 1)
                Else
                    Main.ListSpy.Items(L).SubItems(12).Text = NewText
                    Exit For
                End If
            Next

            'Add Password
            NewText = My.Settings.Pass
            For L = 0 To Counter
                If NewText.IndexOf(",") > -1 Then
                    Main.ListSpy.Items(L).SubItems(13).Text = NewText.Substring(0, NewText.IndexOf(","))
                    NewText = NewText.Remove(0, NewText.IndexOf(",") + 1)
                Else
                    Main.ListSpy.Items(L).SubItems(13).Text = NewText
                    Exit For
                End If
            Next
        End If
    End Function

    Public Function SettingWrite()
        ' Write IP Address 
        Main.ListSpy.Focus()
        My.Settings.IPs = ""
        For L = 0 To Main.ListSpy.Items.Count - 1
            If Main.ListSpy.Items(L).SubItems(1).Text <> "" Then
                If My.Settings.IPs <> "" Then
                    My.Settings.IPs = My.Settings.IPs & "," & Main.ListSpy.Items(L).SubItems(1).Text
                Else
                    My.Settings.IPs = Main.ListSpy.Items(L).SubItems(1).Text
                End If
            End If
        Next L

        ' Write Device Name  
        My.Settings.Devname = ""
        For L = 0 To Main.ListSpy.Items.Count - 1
            If Main.ListSpy.Items(L).SubItems(2).Text <> "" Then
                If My.Settings.Devname <> "" Then
                    My.Settings.Devname = My.Settings.Devname & "," & Main.ListSpy.Items(L).SubItems(2).Text
                Else
                    My.Settings.Devname = Main.ListSpy.Items(L).SubItems(2).Text
                End If
            End If
        Next L

        ' Write Device Model
        My.Settings.Product = ""
        For L = 0 To Main.ListSpy.Items.Count - 1
            If Main.ListSpy.Items(L).SubItems(3).Text <> "" Then
                If My.Settings.Product <> "" Then
                    My.Settings.Product = My.Settings.Product & "," & Main.ListSpy.Items(L).SubItems(3).Text
                Else
                    My.Settings.Product = Main.ListSpy.Items(L).SubItems(3).Text
                End If
            End If
        Next L


        ' Write Device SSID
        My.Settings.SSID = ""
        For L = 0 To Main.ListSpy.Items.Count - 1
            If Main.ListSpy.Items(L).SubItems(11).Text <> "" Then
                If My.Settings.SSID <> "" Then
                    My.Settings.SSID = My.Settings.SSID & "," & Main.ListSpy.Items(L).SubItems(11).Text
                Else
                    My.Settings.SSID = Main.ListSpy.Items(L).SubItems(11).Text
                End If
            End If
        Next L

        ' Write Username 
        My.Settings.User = ""
        For L = 0 To Main.ListSpy.Items.Count - 1
            If Main.ListSpy.Items(L).SubItems(12).Text <> "" Then
                If My.Settings.User <> "" Then
                    My.Settings.User = My.Settings.User & "," & Main.ListSpy.Items(L).SubItems(12).Text
                Else
                    My.Settings.User = Main.ListSpy.Items(L).SubItems(12).Text
                End If
            End If
        Next L

        'Write Password
        My.Settings.Pass = ""
        For L = 0 To Main.ListSpy.Items.Count - 1
            If Main.ListSpy.Items(L).SubItems(13).Text <> "" Then
                If My.Settings.Pass <> "" Then
                    My.Settings.Pass = My.Settings.Pass & "," & Main.ListSpy.Items(L).SubItems(13).Text
                Else
                    My.Settings.Pass = Main.ListSpy.Items(L).SubItems(13).Text
                End If
            End If
        Next L

        My.Settings.Save()
    End Function

    Public Function CounterIPs(ByRef Text As String) As Integer
        For L = 0 To Text.Length
            If Text.IndexOf(",") > -1 Then
                CounterIPs = CounterIPs + 1
                Text = Text.Remove(0, Text.IndexOf(",") + 1)
            End If
        Next L
    End Function

    Public Sub Read()
        Try
            Dim objStreamReader As StreamReader
            Dim strLine, StringReader, Path As String
            Dim CounterRow As Integer = 0
            ' Load IP address
            'Pass the file path and the file name to the StreamReader constructor.
            Path = Application.StartupPath & "\list\ips.txt"
            If My.Computer.FileSystem.FileExists(Path) Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
                For L = 0 To File.ReadAllLines(Path).Length
                    Using sr As New System.IO.StreamReader(Path)
                        StringReader = fileReader.ReadLine()
                        If StringReader <> "" Then
                            Main.ListSpy.Items.Add(Main.ListSpy.Items.Count + 1)
                            Main.ListSpy.Focus()
                            Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add(StringReader)
                            If L = (File.ReadAllLines(Path).Length) - 1 Then
                                fileReader.Close()
                                Exit For
                            End If
                        End If
                    End Using
                Next
            End If

            'Load Device Name 
            Path = Application.StartupPath & "\list\devname.txt"
            If My.Computer.FileSystem.FileExists(Path) Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
                For L = 0 To File.ReadAllLines(Path).Length
                    Using sr As New System.IO.StreamReader(Path)
                        StringReader = fileReader.ReadLine()
                        If StringReader <> "" Then
                            'Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add(StringReader)
                            If L = (File.ReadAllLines(Path).Length) - 1 Then
                                fileReader.Close()
                                Exit For
                            End If
                        End If
                    End Using
                Next
            End If

            'Load Device Model
            Path = Application.StartupPath & "\list\product.txt"
            If My.Computer.FileSystem.FileExists(Path) Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
                For L = 0 To File.ReadAllLines(Path).Length
                    Using sr As New System.IO.StreamReader(Path)
                        StringReader = fileReader.ReadLine()
                        If StringReader <> "" Then
                            'Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add(StringReader)
                            If L = (File.ReadAllLines(Path).Length) - 1 Then
                                fileReader.Close()
                                Exit For
                            End If
                        End If
                    End Using
                Next
            End If
            CounterRow = 0

            'Load Usernme
            '  Jump To End 
            Try
                For Column = 0 To Main.ListSpy.Items.Count - 1
                    For Row = 2 To 11
                        Main.ListSpy.Items(Column).SubItems.Add("")
                    Next
                Next Column
            Catch ex As Exception

            End Try
            Path = Application.StartupPath & "\list\users.txt"
            If My.Computer.FileSystem.FileExists(Path) Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
                For L = 0 To File.ReadAllLines(Path).Length
                    Using sr As New System.IO.StreamReader(Path)
                        StringReader = fileReader.ReadLine()
                        If StringReader <> "" Then
                            Main.ListSpy.Focus()
                            Main.ListSpy.Items(CounterRow).SubItems.Add(StringReader)
                            CounterRow = CounterRow + 1
                            If L = (File.ReadAllLines(Path).Length) - 1 Then
                                fileReader.Close()
                                Exit For
                            End If
                        End If
                    End Using
                Next
            End If
            CounterRow = 0

            'Load Password
            Path = Application.StartupPath & "\list\passwords.txt"
            If My.Computer.FileSystem.FileExists(Path) Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
                For L = 0 To File.ReadAllLines(Path).Length
                    Using sr As New System.IO.StreamReader(Path)
                        StringReader = fileReader.ReadLine()
                        If StringReader <> "" Then
                            Main.ListSpy.Focus()
                            Main.ListSpy.Items(CounterRow).SubItems.Add(StringReader)
                            CounterRow = CounterRow + 1
                            If L = (File.ReadAllLines(Path).Length) - 1 Then
                                fileReader.Close()
                                Exit For
                            End If
                        End If
                    End Using
                Next
            End If
        Catch ex As Exception
            MsgBox("Please , Doesn't  Romove or add items manually :ERR:R1 ", vbCritical)
        End Try
    End Sub
    Public Function Write()
        Try
            Dim objStreamWriter As StreamWriter

            ' Write IP address 
            Dim IP As String
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(Application.StartupPath & "\list\ips.txt")
            'Write a line of text.
            Main.ListSpy.Focus()
            For L = 0 To Main.ListSpy.Items.Count - 1
                IP = Main.ListSpy.Items(L).SubItems(1).Text
                objStreamWriter.WriteLine(IP)
            Next L
            'Close the file.

            objStreamWriter.Close()

            ' Write Username 
            Dim User As String
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(Application.StartupPath & "\list\users.txt")
            'Write a line of text.
            For L = 0 To Main.ListSpy.Items.Count - 1
                User = Main.ListSpy.Items(L).SubItems(12).Text
                objStreamWriter.WriteLine(User)
            Next L

            'Close the file.
            objStreamWriter.Close()

            ' Write Password
            Dim Pass As String
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(Application.StartupPath & "\list\passwords.txt")
            'Write a line of text.
            For L = 0 To Main.ListSpy.Items.Count - 1
                Pass = Main.ListSpy.Items(L).SubItems(13).Text
                objStreamWriter.WriteLine(Pass)
            Next L
            'Close the file.
            objStreamWriter.Close()
        Catch ex As Exception
            MsgBox("Please , Doesn't  Romove or add items manually :ERR:W1 ", vbCritical)
        End Try
    End Function
    Public Function WriteChangeableInfo()
        Try


            Dim objStreamWriter As StreamWriter

            ' Write Device Name 
            Dim devname As String
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(Application.StartupPath & "\list\devname.txt")
            'Write a line of text.
            Main.ListSpy.Focus()
            For L = 0 To Main.ListSpy.Items.Count - 1
                devname = Main.ListSpy.Items(L).SubItems(2).Text
                objStreamWriter.WriteLine(devname)
            Next L
            'Close the file.

            objStreamWriter.Close()

            ' Write Product 
            Dim product As String
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(Application.StartupPath & "\list\product.txt")
            'Write a line of text.
            Main.ListSpy.Focus()
            For L = 0 To Main.ListSpy.Items.Count - 1
                product = Main.ListSpy.Items(L).SubItems(3).Text
                objStreamWriter.WriteLine(product)
            Next L
            'Close the file.

            objStreamWriter.Close()
        Catch ex As Exception
            MsgBox("Error In Changeable Inforamtion !", vbInformation)
        End Try
    End Function
End Module
