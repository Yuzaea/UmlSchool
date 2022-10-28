using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CustomerList
    {

        private List<Customer> _customer;


        public CustomerList()
        {
            _customer = new List<Customer>();
        }
        public int Count
        {
            get { return _customer.Count; }
        }
        public void AddCustomer(Customer aCustomer)
        {
            Customer foundCustomer = LookUpCostumer(aCustomer.ID);
            if (foundCustomer == null)
                _customer.Add(aCustomer);
        }

        public Customer LookUpCostumer(string id)
        {
            foreach (Customer item in _customer)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }
        public void DeleteCustomer(string id)
        {
            Customer item = LookUpCostumer(id);
            _customer.Remove(item);
        }
        public void PrintCustomer()
        {
            foreach (Customer customer in _customer)
            {
                Console.WriteLine(customer);
            }
        }
        public void UpdateCustomer(string id, Customer customerToUpdate)
        {
            int d = 0;
            while (d < _customer.Count)
            {
                if (_customer[d].ID == id)
                {
                    _customer[d] = customerToUpdate;
                    break;
                }
                d++;
            }
        }
        
    }
}
