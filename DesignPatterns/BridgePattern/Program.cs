using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailSender = new EmailSender();
            var smsSender = new SmsSender();
            var webServiceSender = new WebServiceSender();

            var systemMessage = new SystemMessage();
            systemMessage.Subject = "Internal Service Error 500";
            systemMessage.Body = "The server response with error 500.";
            systemMessage.MessageSender = webServiceSender;
            systemMessage.Send();

            systemMessage.MessageSender = emailSender;
            systemMessage.Send();

            systemMessage.MessageSender = smsSender;
            systemMessage.Send();

            var userMessage = new SystemMessage();
            userMessage.Subject = "Your account will expire soon";
            userMessage.Body = "Your account will not ";

            userMessage.MessageSender = emailSender;
            userMessage.Send();

            userMessage.MessageSender = smsSender;
            userMessage.Send();

            userMessage.MessageSender = webServiceSender;
            userMessage.Send();

            Console.ReadLine();
        }
    }

    internal abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public abstract void Send();
    }

    internal class UserMessage : Message
    {
        private string UserComments { get; set; }

        public override void Send()
        {
            var fullbody = $"{Body}\n User comments: {UserComments}";
            MessageSender.SendMessage(fullbody, Subject);
        }
    }

    internal class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Body, Subject);
        }
    }

    internal interface IMessageSender
    {
        void SendMessage(string body, string subject);
    }

    internal class EmailSender:IMessageSender
    {
        public void SendMessage(string body, string subject)
        {
            Console.WriteLine($"Email Subject:{subject} - Body: {body} {Environment.NewLine}");
        }
    }

    internal class SmsSender:IMessageSender
    {
        public void SendMessage(string body, string subject)
        {
            Console.WriteLine($"SMS Subject:{subject} - Body: {body} {Environment.NewLine}");
        }
    }

    internal class WebServiceSender:IMessageSender
    {
        public void SendMessage(string body, string subject)
        {
            Console.Write($"WebService Subject:{subject} - Body:{body} {Environment.NewLine}");
        }
    }
}
