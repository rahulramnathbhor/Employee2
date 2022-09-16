using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("abc", 34000, 200);
            e1.CalculateSalary();
            Console.WriteLine(e1);
        }
    }
}
