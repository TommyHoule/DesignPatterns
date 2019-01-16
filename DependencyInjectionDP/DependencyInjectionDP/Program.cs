using System;

namespace DependencyInjectionDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Here, the dog informations are setup with dependency injection
            string dogName = "Fido";
            int dogAge = 0;
            Dog fido = new Dog(dogName, dogAge);

            string nameGot = fido.getDogName();
            int ageGot = fido.getDogAge();
            Console.WriteLine("With DI : " + nameGot + ", " + ageGot + " year(s)");

            System.Threading.Thread.Sleep(3000);

            //---Here, the cat informations are setup with heritage
            Cat tiMine = new Cat();

            tiMine.setAnimalName("Ti-mine");
            tiMine.setAnimalAge(3);
            string catNameGot = tiMine.getCatName();
            int catAgeGot = tiMine.getCatAge();
            Console.WriteLine("With heritage : " + catNameGot + ", " + catAgeGot + " year(s)");

            System.Threading.Thread.Sleep(3000);
        }
    }
}
