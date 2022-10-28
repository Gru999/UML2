using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2 {
    internal class PizzaMenuAdmin {
        #region Instance fields
        private Dictionary<int, Pizza> _pizza;
        #endregion

        #region Constructor
        public PizzaMenuAdmin() {
            _pizza = new Dictionary<int, Pizza>();
        }
        #endregion

        #region Properties
        public int Count {
            get { return _pizza.Count; }
        }
        #endregion

        #region Methods
        public void AddPizza(Pizza aPizza) {
            if (aPizza.PizzaNumber != null)
                _pizza.Add(aPizza.PizzaNumber, aPizza);
        }

        public Pizza LookupPizza(int pizzaNumber) {
            if (_pizza.ContainsKey(pizzaNumber)) {
                return _pizza[pizzaNumber];
            }
            return null;
        }

        public void DeletePizza(int pizzaNumber) {
            if (_pizza.ContainsKey(pizzaNumber)) {
                _pizza.Remove(pizzaNumber);
            }
            Console.WriteLine("no object is deleted.");
        }


        public void PrintPizzas() {
            foreach (var value in _pizza.Values) {
                Console.WriteLine(value);
            }
        }

        public void UpdatePizza(int pizzaNumber, Pizza pizzaToUpdate) {
            _pizza[pizzaNumber] = pizzaToUpdate;
        }
        #endregion
    }
}