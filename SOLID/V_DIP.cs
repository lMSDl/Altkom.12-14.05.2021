using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.SOLID
{
    interface ISender
    {
        void Send();
    }

    class SMS : ISender
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : ISender
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    class Mail : ISender
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendMail();
        }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    class Messenger
    {
        public Messenger(IEnumerable<ISender> senders)
        {
            Senders = senders;
        }

        public IEnumerable<ISender> Senders { get; set; }

        public void SendMessage()
        {
            Senders.ToList().ForEach(SendMessage);
        }
        public void SendMessage(ISender sender)
        {
            sender.Send();
        }
    }
}
