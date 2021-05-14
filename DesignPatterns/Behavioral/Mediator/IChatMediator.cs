using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public interface IChatMediator
    {
        void Join(ChatMember member);
        void Quit(ChatMember member);
        void Send(string from, string to, string message);
        void Send(string from, string message);
    }
}
