using System;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            float resultCA = (float)(Math.Round((double)context.getTotalPrice(2, "CA"), 2));
            float resultUS = (float)(Math.Round((double)context.getTotalPrice(2, "US"), 2));

            Console.WriteLine("2$ in Canadian money is : " + resultCA + " $");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("2$ in American money is : " + resultUS + " $");
            System.Threading.Thread.Sleep(3000);

        }
    }
}
