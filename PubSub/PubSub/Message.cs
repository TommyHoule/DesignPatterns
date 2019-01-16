using System;

namespace PubSub
{
    class Message
    {
        private string _payload;
        private string _topic;
        
        public Message(string topic, string payload)
        {
            _topic = topic;
            _payload = payload;
            Console.WriteLine("Message created for topic : " + _topic + " !!!");
        }

        public string getPayload()
        {
            return _payload;
        }

        public string getTopic()
        {
            return _topic;
        }
    }
}
