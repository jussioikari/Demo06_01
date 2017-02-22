using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give text (enter ends) : ");
            string teksti = Console.ReadLine();

            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt");
            outputFile.WriteLine(teksti);
            outputFile.Close();

            string text = System.IO.File.ReadAllText("test.txt");
            System.Console.WriteLine("Contents of test.txt: \n" + text);
        }
    }
}
