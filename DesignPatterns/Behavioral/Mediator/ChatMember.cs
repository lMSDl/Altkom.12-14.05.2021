using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        private IChatMediator chat;

        public IChatMediator Chat
        {
            get => chat;
            set
            {
                if (chat != null)
                    chat.Quit(this);
                chat = value;
                if (chat != null)
                    chat.Join(this);
            }
        }



        public string Nick { get; }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public virtual void Send(string to, string message)
        {
            chat.Send(Nick, to, message);
        }

        public virtual void Send(string message)
        {
            chat.Send(Nick, message);
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}
