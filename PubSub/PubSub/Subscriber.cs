using System;
using System.Collections.Generic;
using System.Text;

namespace PubSub
{
    class Subscriber
    {
        private Queue<Message> _buffer = new Queue<Message>();
        private List<string> _topics = new List<string>();

        public Subscriber()
        {

        }

        public void queueMessage(Message message)
        {
            _buffer.Enqueue(message);
        }

        public void Listen(string newTopic)
        {
            _topics.Add(newTopic);
            Console.WriteLine("A subscriber added the topic \"" + newTopic + "\"");
            System.Threading.Thread.Sleep(500);
        }

        public void Print()
        {
            foreach(string topic in _topics)
            {
                while (_buffer.Count != 0)
                {
                    Message newMessage = _buffer.Dequeue();
                    Console.WriteLine("Topic : " + newMessage.getTopic() + Environment.NewLine + newMessage.getPayload());
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }

        public List<string> getTopics()
        {
            return _topics;
        }
    }
}
