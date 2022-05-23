using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_DialerFIXED
{

    class CellPhone : Phone
    {
        protected string _name;
        protected string _phoneNumber;
        protected int _type;
        public CellPhone(string Name, string PhoneNumber, int Type) : base(Name, PhoneNumber, Type)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _type = Type;
        }
        public override string Dial()
        {
            return _name + " is being dialed using 1+" + _phoneNumber;
        }

    }
}
