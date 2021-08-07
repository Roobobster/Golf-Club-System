using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;



namespace Emailing
{
    public class SMPT
    {
        public static void SendEmail(List<string> MembersEmail, string HostEmail, string HostPassword, string EmailSubject, string EmailBody, List<string> AttachmentPaths)
        {


            #region Gmail SMPT
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(HostEmail);

                //Loops for every email inputted (to send to)
                foreach (string email in MembersEmail)
                    mail.To.Add(email);
                
                //Sets the email's subject and body 
                mail.Subject = EmailSubject;
                mail.Body = EmailBody;

                Attachment attachment;
            
                //Loops for every file path in the inputted filepaths (these are the attachment filepaths)
                foreach (string path in AttachmentPaths)
                {
                    attachment = new Attachment(path);
                    mail.Attachments.Add(attachment);
                }
                
                //Gmail's SMPT Port
                SmtpServer.Port = 587;
                //Email Credentials
                SmtpServer.Credentials = new NetworkCredential(HostEmail, HostPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (System.Exception)
            {
                MessageBox.Show("The Email Ports Are Currently Blocked And The Email Can't Be Sent");
            }
            #endregion

           



        }
        
    }
}