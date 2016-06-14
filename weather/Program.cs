using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather fore = new Weather();
            Console.WriteLine("Weather forecast for the week: ");
            fore.Cast();
            Console.ReadKey();
        }
    }
}
