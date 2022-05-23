using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_DialerFIXED
{
    abstract class Phone
    {
        private string _name;
        private string _phoneNumber;
        private int _type;
        public Phone(string Name, string PhoneNumber, int Type)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _type = Type;
        }



        public virtual string Dial()
        {



            return _name + " is being dialed using " + _phoneNumber;


        }
    }
}
