using System;
using System.Collections.Generic;
using System.Text;

namespace PubSub
{
    public class Polititian : IPublisherService
    {
        private readonly IPublisherService _publisherService;
        public Polititian(IPublisherService publisherService)
        {
            _publisherService = publisherService ?? throw new ArgumentNullException(nameof(publisherService));
        }

        public Polititian()
        {
            Console.WriteLine("Politician publisher created !!!");
        }

        public void Publish(Message message)
        {
            _publisherService.Publish(message);
        }
    }
}
