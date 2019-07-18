using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionSeven
{
    public class User
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void MessageToChatRoom(string message)
        {
            Chat.ShowMessageToChatRoom(this, message);
        }

        public void MessageToUser(User geterUser, string message)
        {
            Chat.ShowMessageToUser(this, geterUser, message);
        }
    }
}
