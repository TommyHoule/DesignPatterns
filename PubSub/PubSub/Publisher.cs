using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    public interface IPublisherService
    {
        void Publish(Message message);
    }

    public class PublisherService : IPublisherService
    {
        private readonly PubSubServ _server;
        public PublisherService(PubSubServ server)
        {
            _server = server ?? throw new ArgumentNullException(nameof(server));
        }

        public void Publish(Message message)
        {
            _server.queueMessage(message);
            Console.WriteLine(
                "A publisher sent the following message to server :" + Environment.NewLine +
                "topic : " + message.getTopic() + Environment.NewLine +
                "message : " + message.getPayload());
            System.Threading.Thread.Sleep(2000);
        }

        public void Toto(){}
    }

    public class Publisher
    {
        public void send(Message message, PubSubServ serv)
        {
            serv.queueMessage(message);
            Console.WriteLine(
                "A publisher sent the following message to server :" + Environment.NewLine +
                "topic : " + message.getTopic() + Environment.NewLine +
                "message : " + message.getPayload());
            System.Threading.Thread.Sleep(2000);
        }
    }
}
