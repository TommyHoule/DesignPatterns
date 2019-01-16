using System;

namespace PubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //in-memory server creation
            Console.WriteLine("--------in-memory server creation--------");
            var pubSubServ = new PubSubServ();
            Console.WriteLine("-----------------------------------------");
            System.Threading.Thread.Sleep(200);

            IPublisherService publisherService = new PublisherService(pubSubServ);

            //Publishers creation
            Console.WriteLine("--------creation of publishers--------");
            var politicianPublisher = new Polititian(publisherService);
            var soldierPublisher = new Soldier();
            Console.WriteLine("--------------------------------------");
            System.Threading.Thread.Sleep(200);

            //Subscribers creation
            Console.WriteLine("--------creation of subscribers--------");
            var politicFanSubscriber = new PoliticFan();
            var actionGuySubscriber = new ActionGuy();
            var everythingSubscriber = new EveryThingFollower();
            Console.WriteLine("---------------------------------------");
            System.Threading.Thread.Sleep(200);

            //Setting up messages from publishers (pPMsg : politician, sMsg : soldier)
            Console.WriteLine("--------creation of messages--------");
            var pPMsg = new Message("Politics", "I promise to legalize/decriminalise hacking if I get elected !!!");
            var sMsg = new Message("Actions", "I hate politics, let`s go and kick Trump out !!!");
            Console.WriteLine("------------------------------------");
            System.Threading.Thread.Sleep(2000);

            //Sending messages from publishers to the server
            Console.WriteLine("--------Publishers sending messages to server--------");
            politicianPublisher.Publish(pPMsg);
            Console.WriteLine(Environment.NewLine);
            soldierPublisher.send(sMsg, pubSubServ);
            Console.WriteLine("-----------------------------------------------------");

            //Subscribing subscribers to topics
            Console.WriteLine("--------Subscribers subscribing to topics--------");
            politicFanSubscriber.Listen("Politics");
            actionGuySubscriber.Listen("Actions");
            everythingSubscriber.Listen("Politics");
            everythingSubscriber.Listen("Actions");
            Console.WriteLine("-------------------------------------------------");

            //the next commented block dequeues messages from the server buffer. 
            //So unless we have some sort functionnality to keep track of read/unread messages, it won`t work as supposed to.

            /*
            //Testing Forward() function without subscribers linked to server
            pubSubServ.Forward();
            Console.WriteLine("politicFanSubscriber has access to the following post : ");
            politicFanSubscriber.Print();
            Console.WriteLine("actionGuySubscriber has access to the following post : ");
            actionGuySubscriber.Print();
            Console.WriteLine("everythingSubscriber has access to the following post : ");
            everythingSubscriber.Print();
            */

            //Adding Subscribers to server
            Console.WriteLine("--------Subscribers added to server--------");
            pubSubServ.registerSubscriber(politicFanSubscriber);
            pubSubServ.registerSubscriber(actionGuySubscriber);
            pubSubServ.registerSubscriber(everythingSubscriber);
            Console.WriteLine("Added 3 new subscribers : politicFanSubscriber, actionGuySubscriber and everythingSubscriber");
            Console.WriteLine("-------------------------------------------");
            System.Threading.Thread.Sleep(1000);

            //Testing Forward() function with subscribers linked to server
            pubSubServ.Forward();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("politicFanSubscriber has access to the following post : ");
            politicFanSubscriber.Print();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("actionGuySubscriber has access to the following post : ");
            actionGuySubscriber.Print();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("everythingSubscriber has access to the following post : ");
            everythingSubscriber.Print();
            Console.WriteLine("-----------------------------------------");

            System.Threading.Thread.Sleep(10000);
        }
    }
}
