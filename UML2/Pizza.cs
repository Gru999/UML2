using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2 { 
    internal class Pizza {
        //Instance field
        private int _pizzaNumber;
        private string _pizzaName;
        private string _ingridients;
        private double _price;

        //Property
        public int PizzaNumber {
            get { return _pizzaNumber; }
        }
        public string PizzaName {
            get { return _pizzaName; }
        }
        public string Ingridients {
            get { return _ingridients; }
        }
        public double Price {
            get { return _price; }
        }

        //Constructor
        public Pizza(string pizzaName, int pizzaNumber, string ingridients, double price) {
            _pizzaName = pizzaName;
            _pizzaNumber = pizzaNumber;
            _ingridients = ingridients;
            _price = price;
        }

        //methode
        public override string ToString() {
            return $"\n " +
                   $"Pizza name: {_pizzaName}\n " +
                   $"----------------------------------\n " +
                   $"Pizza number: {_pizzaNumber} \n " +
                   $"----------------------------------\n " +
                   $"Ingridients: {_ingridients} \n " +
                   $"----------------------------------\n " +
                   $"Price: {_price} \n " +
                   $"----------------------------------\n ";
        }
    }
}
