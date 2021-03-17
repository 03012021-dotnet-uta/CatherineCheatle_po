using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
    /// <summary>
    /// Driver class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Driver
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WelcomeUser();
        }

        /// <summary>
        /// Displays stores for user to select from
        /// </summary>
        public static void WelcomeUser()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welcome to Pizza for Days!");
            Console.WriteLine("----------------------------");

            var ss = StoreSingleton.Instance;
            ss.Seeding();

            // Print stores to user for selection
            Console.WriteLine("\nPlease select a store: ");
            System.Console.WriteLine("--------------------------");

            var storeCount = 1;
            foreach(var item in ss.Stores)
            {
                System.Console.WriteLine("{0}.) {1}", storeCount, item);
                storeCount += 1;
            }

            var userInput = System.Console.ReadLine();
            // First input check --> is it a number?
            var userChoice = inputValidInt(userInput);
            // Second input check --> is the input in range of the menu options?
            userChoice = inputValidRange(userChoice, ss.Stores.Count);

            var userStore = ss.Stores[userChoice - 1];
            Console.WriteLine("\nYou have selected: {0}", userStore);

            // User cart to store pizzas
            List<APizza> Cart = new List<APizza>();

            MainMenu(Cart, userStore.Name);

        }

        /// <summary>
        /// Displays main menu for user
        /// </summary>
        /// <param name="c"></param>

        public static void MainMenu(List<APizza> c, string s)
        {
            var userChoice2 = 0;

            while(userChoice2 != 4)
            {
                System.Console.WriteLine("\n--------------------------");
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("1. Add a Pizza");
                System.Console.WriteLine("2. View Cart");
                System.Console.WriteLine("3. View Order History");
                System.Console.WriteLine("4. Exit");

                var userInput = Console.ReadLine();
                // First input check --> is it a number?
                userChoice2 = inputValidInt(userInput);
                // Second input check --> is the input in range of the menu options?
                userChoice2 = inputValidRange(userChoice2, 4);

                switch (userChoice2)
                {
                    case 1:
                        // Place Order
                        PizzaMenu(c);
                        break;
                    case 2:
                        // View Cart
                        CartPreview(c);
                        Checkout(c,s);
                        break;
                    case 3:
                        // View Order History

                        break;
                    case 4:
                        // Exit
                        System.Console.WriteLine("Thank you, have a nice day!");
                        break;
                }
            }
        }

        /// <summary>
        /// Displays Pizza Menu for user
        /// </summary>
        /// <param name="c"></param>

        public static void PizzaMenu(List<APizza> c)
        {
            var ps = PizzaSingleton.Instance;

            ps.Seeding();

            System.Console.WriteLine("\n--------------------------");
            System.Console.WriteLine("Select a Pizza");
            System.Console.WriteLine("--------------------------");

            var pizzaSelCount = 1;
            foreach(var item in ps.Pizzas)
            {
                System.Console.WriteLine("{0}.) {1}", pizzaSelCount, item);
                pizzaSelCount += 1;
            }

            var userInput = System.Console.ReadLine();
            // First input check --> is it a number?
            var userChoice = inputValidInt(userInput);
            // Second input check --> is the input in range of the menu options?
            userChoice = inputValidRange(userChoice, ps.Pizzas.Count);

            var userPizzaChoice = ps.Pizzas[userChoice-1].Name;
            //System.Console.WriteLine("\nPizza chosen: {0}", userPizzaChoice);            
            
            switch(userPizzaChoice.ToLower())
            {
                case "custom pizza":
                    var crustChoice = CrustMenu();
                    var sizeChoice = SizeMenu();
                    var toppingsChoice = ToppingsMenu();
                    CustomPizza cp = new CustomPizza(crustChoice, sizeChoice, toppingsChoice);
                    c.Add(cp);
                    Console.WriteLine("\nA {0} {1} with {2} crust has been added to your cart!", cp.Size.Name, cp.Name, cp.Crust.Name);
                    break;

                case "cheese pizza":
                    crustChoice = CrustMenu();
                    sizeChoice = SizeMenu();
                    CheesePizza userPizza = new CheesePizza (crustChoice, sizeChoice);
                    c.Add(userPizza);
                    Console.WriteLine("\nA {0} {1} with {2} crust has been added to your cart!", userPizza.Size.Name, userPizza.Name, userPizza.Crust.Name);
                    break;

                case "hawaiian pizza":
                    crustChoice = CrustMenu();
                    sizeChoice = SizeMenu();
                    HawaiianPizza hp = new HawaiianPizza (crustChoice, sizeChoice);
                    c.Add(hp);
                    Console.WriteLine("\nA {0} {1} with {2} crust has been added to your cart!", hp.Size.Name, hp.Name, hp.Crust.Name);
                    break;

                case "pepperoni pizza":
                    crustChoice = CrustMenu();
                    sizeChoice = SizeMenu();
                    PepperoniPizza pp = new PepperoniPizza (crustChoice, sizeChoice);
                    c.Add(pp);
                    Console.WriteLine("\nA {0} {1} with {2} crust has been added to your cart!", pp.Size.Name, pp.Name, pp.Crust.Name);
                    break;

                case "sausage pizza":
                    crustChoice = CrustMenu();
                    sizeChoice = SizeMenu();
                    SausagePizza sp = new SausagePizza (crustChoice, sizeChoice);
                    c.Add(sp);
                    Console.WriteLine("\nA {0} {1} with {2} crust has been added to your cart!", sp.Size.Name, sp.Name, sp.Crust.Name);
                    break;

                case "veggie pizza":
                    crustChoice = CrustMenu();
                    sizeChoice = SizeMenu();
                    VeggiePizza vp = new VeggiePizza (crustChoice, sizeChoice);
                    c.Add(vp);
                    Console.WriteLine("\nA {0} {1} with {2} crust has been added to your cart!", vp.Size.Name, vp.Name, vp.Crust.Name);
                    break;
            }

        }

        /// <summary>
        /// Displays Crust Menu
        /// </summary>
        /// <returns></returns>
        public static Crust CrustMenu()
        {
            var ps = PizzaSingleton.Instance;
            ps.Seeding();

            System.Console.WriteLine("\n--------------------------");
            System.Console.WriteLine("Pick a crust");
            System.Console.WriteLine("--------------------------");
            var crustSelCount = 1;
            foreach(var item in ps.Crusts)
            {
                System.Console.WriteLine("{0}.) {1}", crustSelCount, item.Name);
                crustSelCount += 1;
            }

            var userInput = System.Console.ReadLine();
            // First input check --> is it a number?
            var userChoice = inputValidInt(userInput);
            // Second input check --> is the input in range of the menu options?
            userChoice = inputValidRange(userChoice, ps.Crusts.Count);

            var userCrustChoice = ps.Crusts[userChoice-1];
            //System.Console.WriteLine("Crust chosen: {0}", userCrustChoice.Name);
            //System.Console.WriteLine("Crust Price: {0}", userCrustChoice.Price);

            return userCrustChoice;

        }

        /// <summary>
        /// Displays Size Menu for User
        /// </summary>
        /// <returns></returns>
        public static Size SizeMenu()
        {
            var ps = PizzaSingleton.Instance;
            ps.Seeding();

            System.Console.WriteLine("\n--------------------------");
            System.Console.WriteLine("Pick a size");
            System.Console.WriteLine("--------------------------");
            
            var sizeSelCount = 1;
            foreach(var item in ps.Sizes)
            {
                System.Console.WriteLine("{0}.) {1}", sizeSelCount, item.Name);
                sizeSelCount += 1;
            }

            var userInput = System.Console.ReadLine();
            // First input check --> is it a number?
            var userChoice = inputValidInt(userInput);
            // Second input check --> is the input in range of the menu options?
            userChoice = inputValidRange(userChoice, ps.Sizes.Count);

            var userSizeChoice = ps.Sizes[userChoice-1];
            //System.Console.WriteLine("Size chosen: {0}", userSizeChoice.Name);
            //System.Console.WriteLine("Size Price: {0}", userSizeChoice.Price);

            return userSizeChoice;
        }

        /// <summary>
        /// Displays Topping Menu for User
        /// </summary>
        public static List<Topping> ToppingsMenu()
        {
            var ps = PizzaSingleton.Instance;
            ps.Seeding();

            System.Console.WriteLine("\n--------------------------");
            System.Console.WriteLine("Choose 2-5 toppings (seperate by space)");
            System.Console.WriteLine("--------------------------");

            var toppingSelCount = 1;
            foreach(var item in ps.PizzaToppings)
            {
                System.Console.WriteLine("{0}.) {1}", toppingSelCount, item.Name);
                toppingSelCount += 1;
            }

            var userChoice = System.Console.ReadLine();
            var choices = userChoice.Split();
            List<Topping> userToppings = new List<Topping>();
            foreach(var t in choices)
            {
                var numChoice = int.Parse(t);
                //Console.WriteLine(ps.PizzaToppings[numChoice-1].Name);
                userToppings.Add(ps.PizzaToppings[numChoice-1]);
            }
            return userToppings;
        }

        /// <summary>
        /// Displays all pizzas currently in the cart
        /// </summary>
        /// <param name="cart"></param>
        public static void CartPreview(List<APizza> cart)
        {
            var pizzaTotal = 0.0;
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("List of Pizza that you ordered: ");
            Console.WriteLine("--------------------------");
            foreach(var p in cart)
            {
                p.CalculateTotal();
                pizzaTotal += p.Total;
                System.Console.WriteLine("{0} {1} with {2} crust: {3}", p.Size.Name, p.Name, p.Crust.Name, p.Total);
            }

            System.Console.WriteLine("Subtotal: {0:C}", pizzaTotal);

        }

        /// <summary>
        /// Goes through checkout process with user to place their order
        /// </summary>
        /// <param name="cart"></param>
        /// <param name="s"></param>
        public static void Checkout(List<APizza> cart, string s)
        {
            System.Console.WriteLine("\n--------------------------");
            Console.WriteLine("Would you like to checkout? \n1.) Yes \n2.) No \n3.) I want to edit my cart");
            System.Console.WriteLine("--------------------------");
            var userChoice = int.Parse(Console.ReadLine());
            if(userChoice == 1)
            {
                Console.WriteLine("Please enter your name: ");
                var custName = Console.ReadLine();
                Console.WriteLine("Please enter your email: ");
                var custEmail = Console.ReadLine();

                Customer cust = new Customer(custName, custEmail);
                Order userOrder = new Order(cart, s, cust);
                var total = userOrder.calcTotal();
                userOrder.Total = total;
                userOrder.SaveOrderToXML(userOrder);
                Console.WriteLine("\nYour total is {0:C}. Thank you {1} for ordering! " , total, custName);
                cust.Orders.Add(userOrder);

            }
            else
            {
                Console.WriteLine("Returning you to main menu...");
            }
        }

        public static void ViewOrderHistory()
        {

        }

        public static void editCart(List<APizza> cart)
        {
            
        }

        public static int inputValidInt(string s)
        {
            bool validInput = Int32.TryParse(s, out var userChoice);
            while(validInput != true)
            {
                Console.WriteLine("Sorry but you have entered an invalid input, please enter a valid number: ");
                s = System.Console.ReadLine();
                validInput = Int32.TryParse(s, out userChoice);
            }

            return userChoice;
        }

        public static int inputValidRange(int num, int listLength)
        {
            while(num < 1 || num > listLength)
            {
                Console.WriteLine("Sorry but you have entered a number out of range: ");
                var userInput = Console.ReadLine();
                num = inputValidInt(userInput);
            }

            return num;
        }
    }
}
