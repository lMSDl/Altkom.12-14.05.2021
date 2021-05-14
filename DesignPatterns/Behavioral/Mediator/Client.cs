using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new ChatMediator();

            ChatMember user = new ChatUser("Paweł");
            ChatMember bot1 = new ChatEchoBot("Paul");
            ChatMember bot2 = new ChatEchoBot("Ringo");

            user.Chat = chat;
            bot1.Chat = chat;
            bot2.Chat = chat;

            user.Send("test to all");
            user.Send("Paul", "test to Paul");
            user.Send("Ringo", "test to Ringo");
        }
        }
}
