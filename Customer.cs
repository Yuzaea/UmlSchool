using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer
    {
        public Customer() { }
        public Customer(string id, string name, string adress)
        {
            _id = id;
            _name = name;
            _adress = adress;

        }
        private string _id;
        private string _name;
        private string _adress;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
    }
}

