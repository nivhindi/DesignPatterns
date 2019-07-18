using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionSeven
{
    public class Chat
    {
        public static void ShowMessageToChatRoom(User user, string message)
        {
            Console.WriteLine("[" + user.getName() + "] (" + DateTime.Now + "): " + message);
        }

        public static void ShowMessageToUser(User senderUser, User geterUser, string message)
        {
            Console.WriteLine("To: [" + geterUser.getName() + "]:");
            Console.WriteLine("[" + senderUser.getName() + "] (" + DateTime.Now + "): " + message);
        }
    }
}
