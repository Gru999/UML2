using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML2;

namespace UML2 { 
    internal class CustomerAdmin {
        #region Instance fields
        private List<Customer> _customer;
        #endregion

        #region Constructor
        public CustomerAdmin() {
            _customer = new List<Customer>();
        }
        #endregion

        #region Properties
        public int Count {
            get { return _customer.Count; }
        }
        #endregion

        #region Methods
        public void AddCustomer(Customer aCustomer) {
            Customer foundCustomer = LookupCustomer(aCustomer.CustomerName);
            if (foundCustomer == null)
                _customer.Add(aCustomer);
        }

        public Customer LookupCustomer(string custName) {
            foreach (Customer item in _customer) {
                if (custName == item.CustomerName) {
                    return item;
                }
            }
            return null;
        }
        public void DeleteCustomer(string custName) {
            _customer.Remove(LookupCustomer(custName));
        }

        public void PrintCustomers() {
            foreach (Customer customer in _customer) {
                Console.WriteLine(customer);
            }
        }

        public void UpdateCustomer(string custName, Customer customerToUpdate) {
            int customerIndex = _customer.IndexOf(LookupCustomer(custName));
            _customer[customerIndex] = customerToUpdate;
        }
        #endregion
    }
}