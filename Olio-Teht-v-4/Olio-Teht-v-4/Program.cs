using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ikä;
            Console.Write("Anna ikäsi > ");
            ikä = int.Parse(Console.ReadLine());
            if (ikä < 18) Console.WriteLine("Alaikäban");
            if (ikä >= 18 && ikä <= 65) Console.WriteLine("Aikuinen");
            if (ikä > 65) Console.WriteLine("Seniori");
        }
    }
}
