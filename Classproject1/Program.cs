using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date1 date1 = new Date1();
            date1.AssignValue();
            Console.WriteLine(date1.DisplayValue());
        }
    }
}
