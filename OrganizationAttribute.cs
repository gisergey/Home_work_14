using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Home_work_14
{
    class OrganizationAttribute:Attribute
    {
        private string organization = "КФУ ИВМиИТ";
        public override string ToString()
        {
            return "организация " + organization;
        }
    }
}
