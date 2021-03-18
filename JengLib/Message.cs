using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Message
    {
        private string content;
        public void SetContent(string content)
        {
            this.content = content;
        }
        public string send()
        {
            return this.content;
        }
    }
    public class Email : Message
    {
        private string sender;
        private string receiver;
        /*
        public void SetSender(string sender)
        {
            this.sender = sender;
        }*/
        public string Sender
        {
            get
            {
                return sender;
            }
            set
            {
                sender = value;
            }
        }
        public void SetReceiver(string receiver)
        {
            this.receiver = receiver;
        }
        public string ShowReceiver()
        {
            return receiver;
        }
    }
}
