using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2 {
    internal class DialogMenu {
        private CustomerAdmin _customerAdminList;
        private PizzaMenuAdmin _pizzaMenuAdmin;
        public DialogMenu(CustomerAdmin customerAdminList, PizzaMenuAdmin pizzaMenuAdmin) {
            _customerAdminList = customerAdminList;
            _pizzaMenuAdmin = pizzaMenuAdmin;
        }

        public int UserChoice() {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input)) {
                return input;
            } else {
                return -1;
            }
        }

        public int ShowMenu() {
            Console.Clear();
            Console.WriteLine("\t===============Customer Administration===============");
            Console.WriteLine("\t1.\tAdd Customer to the list");
            Console.WriteLine("\t2.\tShow all Customers on the list");
            Console.WriteLine("\t3.\tSearch for a Customer by Name");
            Console.WriteLine("\t4.\tDelete a Customer from the list (by Name)");
            Console.WriteLine("\t5.\tUpdate a Customer from the list (by Name)");
            Console.WriteLine("\t===============Pizza Menu Administration===============");
            Console.WriteLine("\t6.\tAdd a Pizza to the list");
            Console.WriteLine("\t7.\tShow all Pizzas on the list");
            Console.WriteLine("\t8.\tSearch for a Pizza by Name");
            Console.WriteLine("\t9.\tDelete a Pizza from the list by Name");
            Console.WriteLine("\t10.\tUpdate a Pizza from the list by Name");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tPress 0 to EXIT the system");
            Console.WriteLine("\t===================================");
            Console.Write("\tPlease enter your choice:");
            return UserChoice();
        }

        public void Run() {
            Console.WriteLine("Add your Name");
            Console.WriteLine("Enter Name:");
            string custName = Console.ReadLine();
            Console.WriteLine("Enter Phone nr:");
            int custPhone = int.Parse(Console.ReadLine());
            Customer a = new Customer(custName, custPhone);
            _customerAdminList.AddCustomer(a);


            int choice1 = ShowMenu();
            while (choice1 != 0) {
                switch (choice1) {
                    //CustomerAdmin(list)
                    case 1:
                        Console.Clear();
                        AddCustomerToList();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Print Customers");
                        _customerAdminList.PrintCustomers();
                        break;
                    case 3:
                        Console.Clear();
                        SearchCustomerList();
                        break;
                    case 4:
                        Console.Clear();
                        DeleteCustomerFromList();
                        break;
                    case 5:
                        Console.Clear();
                        UpdateCustomerList();
                        break;

                    //PizzaMenuAdmin(dictionary) 
                    case 6:
                        Console.Clear();
                        AddPizzaToList();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Print Pizza Menu");
                        _pizzaMenuAdmin.PrintPizzas();
                        break;
                    case 8:
                        Console.Clear();
                        SearchPizzaList();
                        break;
                    case 9:
                        Console.Clear();
                        DeletePizzaFromList();
                        break;
                    case 10:
                        Console.Clear();
                        UpdatePizzaList();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Input Error, please try again.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                choice1 = ShowMenu();
            }

        }



        private void AddCustomerToList() {
            Console.WriteLine("Add Customer");
            Console.WriteLine("Enter Name:");
            string custName = Console.ReadLine();
            //implement an error is user does not give a name or number
            Console.WriteLine("Enter Phone nr:");
            int custPhone = int.Parse(Console.ReadLine());
            Customer a = new Customer(custName, custPhone);
            _customerAdminList.AddCustomer(a);
        }
        private void DeleteCustomerFromList() {
            Console.WriteLine("Delete Customer");
            Console.WriteLine("Enter Name:");
            string custName = Console.ReadLine();
            _customerAdminList.DeleteCustomer(custName);
        }

        private void SearchCustomerList() {
            Console.WriteLine("Search Customer");
            Console.WriteLine("Enter Name:");
            string custName = Console.ReadLine();
            Customer cust = _customerAdminList.LookupCustomer(custName);
            if (cust == null) {
                Console.WriteLine("No such Customer exist on the list");
            } else {
                Console.WriteLine(cust);
            }
            Console.ReadLine();
        }

        private void UpdateCustomerList() {
            Console.WriteLine("Update Customer");
            Console.WriteLine("Enter the name of the Customer you would like to edit");
            string custOldName = Console.ReadLine();
            Customer cust = _customerAdminList.LookupCustomer(custOldName);
            if (cust == null) {
                Console.WriteLine("No such Customer exist on the list");
            } else {
                Console.WriteLine("Update Customer");
                Console.WriteLine("Enter Name");
                string custName = Console.ReadLine();
                Console.WriteLine("Enter Phone nr:");
                int custPhone = int.Parse(Console.ReadLine());
                Customer updatedCustomer = new Customer(custName, custPhone);

                _customerAdminList.UpdateCustomer(custOldName, updatedCustomer);
                Console.WriteLine("The Customer have been updated");
                Console.ReadLine();
            }
        }

        //Dictionary part
        private void AddPizzaToList() {
            Console.WriteLine("Add Pizza");
            Console.WriteLine("Enter a Name for the Pizza:");
            string pizzaName = Console.ReadLine();
            Console.WriteLine("Enter Pizza nr:");
            int pizzaNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter toppings for the Pizza:");
            string ingridients = Console.ReadLine();
            Console.WriteLine("Enter a Price:");
            double price = double.Parse(Console.ReadLine());
            Pizza a = new Pizza(pizzaName, pizzaNumber, ingridients, price);
            _pizzaMenuAdmin.AddPizza(a);
        }
        private void DeletePizzaFromList() {
            Console.WriteLine("Delete Pizza");
            Console.WriteLine("Enter Number:");
            int pizzaNumber = int.Parse(Console.ReadLine());
            _pizzaMenuAdmin.DeletePizza(pizzaNumber);
        }

        private void SearchPizzaList() {
            Console.WriteLine("Search Pizza");
            Console.WriteLine("Enter Pizza number:");
            int pizzaNumber = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaMenuAdmin.LookupPizza(pizzaNumber);
            if (pizza == null) {
                Console.WriteLine("No such Pizza exist on the list");
            } else {
                Console.WriteLine(pizza);
            }
            Console.ReadLine();
        }

        private void UpdatePizzaList() {
            Console.WriteLine("Update Pizza");
            Console.WriteLine("Enter the Number of the Pizza you would like to edit");
            int pizzaOldNumber = int.Parse(Console.ReadLine());
            Pizza pizza = _pizzaMenuAdmin.LookupPizza(pizzaOldNumber);
            if (pizza == null) {
                Console.WriteLine("No such Pizza exist on the list");
            } else {
                Console.WriteLine("Update Pizza");
                Console.WriteLine("Enter Pizza name");
                string pizzaName = Console.ReadLine();
                Console.WriteLine("Enter Pizza nr:");
                int pizzaNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter toppings for the Pizza:");
                string ingridients = Console.ReadLine();
                Console.WriteLine("Enter a Price:");
                double price = double.Parse(Console.ReadLine());
                Pizza updatedPizza = new Pizza(pizzaName, pizzaNumber, ingridients, price);
                _pizzaMenuAdmin.UpdatePizza(pizzaOldNumber, updatedPizza);
                Console.WriteLine("The Pizza have been updated");
                Console.ReadLine();
            }
        }
        //Methode: pizza order for a given customer 
    }
}
