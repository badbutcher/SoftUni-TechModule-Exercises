namespace _007AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal> foods = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] food = Console.ReadLine().Split('-');
                string foodName = food[0];
                decimal foodPrice = decimal.Parse(food[1]);

                if (!foods.ContainsKey(foodName))
                {
                    foods.Add(foodName, foodPrice);
                }
                else
                {
                    foods[foodName] = foodPrice;
                }
            }

            List<Customer> customers = new List<Customer>();
            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end of clients")
                {
                    break;
                }
                string[] clientInfo = info.Split('-', ',');
                string customerName = clientInfo[0];
                string product = clientInfo[1];
                int quantity = int.Parse(clientInfo[2]);

                if (foods.ContainsKey(product))
                {

                    Customer client = new Customer();
                    client.BoughtItems = new Dictionary<string, int>();
                    client.Name = clientInfo[0];
                    client.BoughtItems.Add(product, quantity);

                    if (customers.Any(c => c.Name == customerName))
                    {
                        Customer existingCustomer = customers.First(c => c.Name == customerName);
                        if (existingCustomer.BoughtItems.ContainsKey(product))
                        {
                            existingCustomer.BoughtItems[product] += quantity;
                        }
                        else
                        {
                            existingCustomer.BoughtItems[product] = quantity;
                        }
                    }
                    else
                    {
                        customers.Add(client);
                    }
                }
            }


            foreach (var customer in customers)
            {
                foreach (var item in customer.BoughtItems)
                {
                    foreach (var product in foods)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            var sort = customers.OrderBy(a => a.Name);
            decimal totalBill = 0;
            foreach (var item in sort)
            {
                Console.WriteLine(item.Name);

                foreach (var inner in item.BoughtItems)
                {
                    Console.WriteLine("-- {0} - {1}", inner.Key, inner.Value);
                }

                Console.WriteLine("Bill: {0:F2}", item.Bill);
                totalBill += item.Bill;
            }

            Console.WriteLine("Total bill: {0:F2}", totalBill);
        }
    }

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> BoughtItems { get; set; }

        public decimal Bill { get; set; }
    }
}