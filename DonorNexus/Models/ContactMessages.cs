using System;
namespace DonorNexus.Models
{
    public class ContactMessage
    {

        private int messageID;
        private string senderName;
        private string senderEmail;
        private string subject;
        private string messageText;
        private DateTime sentDate;

        public int MessageID
        {
            get { return messageID; }
            set { messageID = value; }
        }

        public string SenderName
        {
            get { return senderName; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    senderName = value;
                }
                else
                {
                    throw new Exception("Sender Name cannot be empty.");
                }
            }
        }

        public string SenderEmail
        {
            get { return senderEmail; }

            set
            {
                if (
                    value.Contains("@") &&value.Contains(".com")
                    )
                {
                    senderEmail = value;
                }
                else
                {
                    throw new Exception("Invalid Email Address.");
                }
            }
        }


        public string Subject
        {
            get { return subject; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    subject = value;
                }
                else
                {
                    throw new Exception("Subject cannot be empty.");
                }
            }
        }

        public string MessageText
        {
            get { return messageText; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    messageText = value;
                }
                else
                {
                    throw new Exception( "Message cannot be empty.");
                }
            }
        }

        public DateTime SentDate
        {
            get { return sentDate; }

            set
            {
                if (value <= DateTime.Now)
                {
                    sentDate = value;
                }
                else
                {
                    throw new Exception( "Invalid Sent Date.");
                }
            }
        }


        public ContactMessage(int messageID,string senderName,string senderEmail,string subject, string messageText,DateTime sentDate)
        {
            MessageID = messageID;
            SenderName = senderName;
            SenderEmail = senderEmail;
            Subject = subject;
            MessageText = messageText;
            SentDate = sentDate;
        }

        public string GetMessageDetails()
        {
            return "Message ID: " + MessageID +
                   "\nSender Name: " + SenderName +
                   "\nEmail: " + SenderEmail +
                   "\nSubject: " + Subject +
                   "\nMessage: " + MessageText +
                   "\nSent Date: " +
                   SentDate.ToShortDateString();
        }
    }
}
