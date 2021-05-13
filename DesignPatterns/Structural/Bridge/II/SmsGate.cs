using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class SmsGate : IMessageSenderImplementation
    {
        public const int MaxLength = 10;

        public void SendMessage(string message)
        {
            IEnumerable<string> splittedMessage = PrepareMessages(message);
            foreach (var m in splittedMessage)
            {
                SendPreparedMessage(m);
            }
        }

        private static void SendPreparedMessage(string message)
        {
            Console.WriteLine($"Wiadomość została wysłana przez bramkę SMS: {message}");
        }

        private static IEnumerable<string> PrepareMessages(string message)
        {
            return Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLength))
                .Select(x => message.Substring(x * MaxLength, Math.Min(MaxLength, message.Length - x * MaxLength)));
        }
    }
}
