using System;
namespace Uppgift_3._14
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Har du gått ut ur gymnasiet än? (j/n)");
            string skola = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (skola == "j" && ålder <= 22 && ålder >= 19)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else if (skola == "n")
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }        
            if (ålder <= 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else if (ålder >= 22)
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
        }
    }
}