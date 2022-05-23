using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_DialerFIXED
{
    class HomePhone : Phone
    {
        protected string _name;
        protected string _phoneNumber;
        protected int _type;
        public HomePhone(string Name, string PhoneNumber, int Type) : base(Name, PhoneNumber, Type)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _type = Type;
        }



    }
}
