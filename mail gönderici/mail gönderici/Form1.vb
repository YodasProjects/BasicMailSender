
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports Microsoft.Win32
Imports System.Security.Cryptography
Imports System.Text
Imports System.Management
Imports System.CodeDom.Compiler
Imports System.Runtime.InteropServices
Imports System.Security

Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txteposta.Text, txtsifre.Text)
            Smtp_Server.Port = txtport.Text
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = txtsmtp.Text
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txteposta.Text)
            e_mail.To.Add(txtreciever.Text)
            e_mail.Subject = txttopic.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = txtbody.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Succesfully Sended")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
