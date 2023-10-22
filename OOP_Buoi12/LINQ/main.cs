using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class main
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;


            LibraryManagement lb = new LibraryManagement();

            lb.addDocuments();
            lb.printDocuments();


            Console.ReadKey();
        }
    }
}
