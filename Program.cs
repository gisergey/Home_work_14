using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Home_work_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 14.1 (1)
            bankaccount Vlad = new bankaccount(100, accounts.corrent);
            
            // task 14.2
            Rational_numbers a = new Rational_numbers(2, 3);
            Type type = typeof(Rational_numbers);
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine("Класс Rational_numbers ");
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
            // task 14.1 (2)
            type = typeof(bankaccount);
            attributes = type.GetCustomAttributes(false);
            Console.WriteLine("Класс bankaccount ");
            foreach(var attribute in attributes)
            {
                Console.Write(attribute);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
