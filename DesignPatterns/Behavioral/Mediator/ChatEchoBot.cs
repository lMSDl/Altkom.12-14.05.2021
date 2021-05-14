using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class ChatEchoBot : ChatMember
    {
        public ChatEchoBot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Chat.Send(Nick, from, message);
            else
                Chat.Send(Nick, message);
        }
    }
}
