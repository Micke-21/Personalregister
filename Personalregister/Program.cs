using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Personalregister");
            int counter = 0;

            Personalregister personalregister = new Personalregister();

            if (args.Length == 1 && args[0] == "test")
                personalregister.AddTestData();


            do
            {
                Console.Clear();
                Console.WriteLine("Enter emplyee # {0}", counter++);
            } while (personalregister.AddEmplyee());

            personalregister.ListEmplyees();

            Console.ReadLine();

        }
    }
}
