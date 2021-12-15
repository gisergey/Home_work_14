using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_14
{
    class AuthorAttribute:Attribute
    {
        private static string name = "Гинсбург Сергей";
        public string Name{ get { return name; }}
        public override string ToString()
        {
            return "автор кода " + name;
        }
    }
}
