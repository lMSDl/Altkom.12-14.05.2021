using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class ChatMediator : IChatMediator
    {

        private ICollection<ChatMember> chatMembers = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            chatMembers.Add(member);
        }

        public void Quit(ChatMember member)
        {
            chatMembers.Remove(member);
        }

        public void Send(string from, string to, string message)
        {
            chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }

        public void Send(string from, string message)
        {
            var query = chatMembers.Where(x => x.Nick != from);
            if (chatMembers.Single(x => x.Nick == from) is ChatEchoBot)
                query = query.Where(x => !(x is ChatEchoBot));
            query.ToList().ForEach(x => x.Receive(from, message, false));
        }
    }
}
