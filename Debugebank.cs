using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace Home_work_14
{

    class Debugebank
    {
        [Conditional("DEBUG_ACCOUNT")]
        public static void Debuge(bankaccount a)
        {
            Console.WriteLine("Информация о тестовом счете");
            Console.WriteLine(a.ToString());
        }
    }
}
