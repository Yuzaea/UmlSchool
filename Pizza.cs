using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    public class Pizza
    {
        public Pizza() { }
        public Pizza(string num, string name, string price, string ingredients)
        {
            _num = num;
            _name = name;
            _price = price;
            _ingredients = ingredients;
        }
        #region Instance fields
        private string _num;
        private string _name;
        private string _price;
        private string _ingredients;
        #endregion


        public string Num
        {
            get { return _num; }
            set { _num = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Ingredients
        {
            get { return _ingredients; }
            set
            {
                _ingredients = value;
            }
        }



        //public override string ToString()
        //{
        //    return $"Number {_num} Name {_name} Price {_price} Ingredeients {_ingredients}";
        //}
        public override string ToString()
        {
            return $"{_num},{_name},{_price},{_ingredients},";
    }
    }
}
