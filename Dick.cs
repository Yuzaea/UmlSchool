using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PizzaDick
    {
        #region Instance fields
        private Dictionary<string, Pizza> _pizza;
        #endregion

        #region Constructor
        public PizzaDick()
        {
            _pizza = new Dictionary<string, Pizza>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _pizza.Count; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method adds a single Book object 
        /// to the List of books 
        /// </summary>
        public void AddPizza(string num, Pizza aPizza)
        {
            if (!_pizza.ContainsKey(aPizza.Num))
                _pizza.Add(aPizza.Num, aPizza);
            // TODO
        }

        /// <summary>
        /// This method returns a Book object (if any) from
        /// the List of books, which has a matching ISBN number.
        /// If no such object exists, the method returns null.
        /// </summary>
        public Pizza LookupPizza(string num)
        {
            // TODO
            if (_pizza.ContainsKey(num))
                return _pizza[num];
            return null;
        }

        /// <summary>
        /// This method deletes a Book object from the List
        /// of books, specifically the object which has a
        /// matching ISBN number. If no such object exists,
        /// no object is deleted.
        /// </summary>
        public void DeletePizza(string num)
        {
            // TODO
            if (_pizza.ContainsKey(num))
                _pizza.Remove(num);
        }


        public void PrintPizza()
        {
            //TODO

            foreach (Pizza puzza in _pizza.Values)
            {
                Console.WriteLine(puzza.ToString());
            }
        }

        public void UpdatePizza(string num, Pizza PizzaToUpdate)
        {
            if (_pizza.ContainsKey(num))
                _pizza[num] = PizzaToUpdate;
        }


        #endregion


    }
}
