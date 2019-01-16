using System;
using System.Collections.Generic;

namespace PubSub
{
    class PubSubServ
    {
        private Queue<Message> buffer = new Queue<Message>();
        private List<Subscriber> subscribers= new List<Subscriber>();

        public PubSubServ()
        {
            Console.WriteLine("Publishing/Subscribing server created !!!");
        }

        public void registerSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public int getSubscribersCount()
        {
            return subscribers.Count;
        }

        public void queueMessage(Message message)
        {
            buffer.Enqueue(message);
        }

        public void Forward()
        {
            while (buffer.Count != 0)
            {
                Message tempMessage = buffer.Dequeue();
                foreach (Subscriber subscriber in subscribers)
                {
                    List<string> topics = subscriber.getTopics();
                    foreach (string topic in topics)
                    {
                        if(tempMessage.getTopic() == topic)
                        {
                            subscriber.queueMessage(tempMessage);
                        }
                    }
                }
            }
        }
    }
}
