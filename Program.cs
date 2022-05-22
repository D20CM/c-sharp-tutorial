using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            string phrase = "boom!";
            char grade = 'A';
            int age = 21;
            double score = 3.2;
            bool isCool = true;

             
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            Book book1 = new Book("The Hitchhiker's Guide To The Galaxy", "Douglas Adams",571, "PG-13");
         
            Book book2 = new Book("The Bear Comes Home", "Rafi Zaboor",298, "NR");

            Console.WriteLine(book1.IsChunky());
            Console.WriteLine(book2.IsChunky());

            Console.WriteLine(book1.Rating);
            Console.ReadLine();
        }
    }
}
