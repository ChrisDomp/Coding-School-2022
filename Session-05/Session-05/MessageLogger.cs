using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        public Message[] Messages { get; set; }
        private int _index;
        public MessageLogger()
        {
            _index = 0;
            Message[] messages = new Message[100];       
        }
        public Message[] ReadAll()
        {
            return Messages;
        }
        public void Write(Message message)
        {
            Messages[_index++] = message;
        }
        public void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
            _index = 0;
        }
    }
}
