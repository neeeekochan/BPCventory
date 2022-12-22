Imports System.IO.Ports
Imports System.IO

Public Class TextMessage
    Dim globalsms As String

    Public Function SendSMS(msg As String, num As String, Optional sender As String = "BPCVentory")
        Dim Serialport1 = New System.IO.Ports.SerialPort() With {
                .PortName = "COM9",
                .BaudRate = 9600,
                .Parity = Parity.None,
                .StopBits = StopBits.One,
                .DataBits = 8,
            .Handshake = Handshake.RequestToSend,
            .DtrEnable = True,
            .RtsEnable = True,
            .NewLine = vbCrLf
        }
        globalsms = "Sent By: " & sender &
            vbNewLine & vbNewLine & msg &
            vbNewLine & vbNewLine

        Try
            Serialport1.Open()
        Catch ex As Exception
            MsgBox("The modem with the port '" & Serialport1.PortName & "'is not plugged in!!" & vbCrLf & "Please plug the modem and try again.")
        End Try

        If Serialport1.IsOpen() = True Then
            Serialport1.Write("AT" & vbCrLf)
            Serialport1.Write("AT+CMGF=1" & vbCrLf)
            Serialport1.Write("AT+CMGS=" & Chr(34) & (num) & Chr(34) & vbCrLf)
            Serialport1.Write(globalsms & Chr(26))

            MessageBox.Show("Message sent.")
            Serialport1.Close()
        Else
            MessageBox.Show("Message sending unsuccessful.")

        End If
        Return 0
    End Function
End Class
