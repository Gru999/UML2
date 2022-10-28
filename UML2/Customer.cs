using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2 {
    internal class Customer {
        //Instance variable
        private string _custName;
        private int _custPhone;
        private int _custId = 0;

        //Property
        public string CustomerName {
            get { return _custName; }
        }
        public int CustomerPhone {
            get { return _custPhone; }
        }
        public int CustomerID {
            get { return _custId; }
        }

        //Constructor
        public Customer(string custName, int custPhone) {
            _custName = custName;
            _custPhone = custPhone;
            //_custId = custId;
        }

        //Methode
        public override string ToString() {
            return $" Customer name: {_custName}\n " +
                   $"----------------------------------\n " +
                   $"Phone Number: {_custPhone}\n " +
                   $"----------------------------------\n " +
                   $"Customer ID: {_custId}\n " +
                   $"----------------------------------\n ";
        }
    }
}