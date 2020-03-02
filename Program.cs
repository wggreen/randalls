using System;
using System.Collections.Generic;

namespace randalls
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();
            Console.WriteLine("Add two vehicles to the database");

            for (int i = 0; i < 2; i++)
            {
                Dictionary<string, Dictionary<string, string>> sale = new Dictionary<string, Dictionary<string, string>>();
                Dictionary<string, string> vehicle = new Dictionary<string, string>();
                Dictionary<string, string> salesAgent = new Dictionary<string, string>();
                Dictionary<string, string> credit = new Dictionary<string, string>();

                Console.WriteLine("We need some information about the sale.\n\n");

                Console.WriteLine("First we need information about the vehicle itself.\n");
                Console.WriteLine("What is the year of the vehicle?");
                string year = Console.ReadLine();
                Console.WriteLine("What is the model of the vehicle?");
                string model = Console.ReadLine();
                Console.WriteLine("What is the make of the vehicle?");
                string make = Console.ReadLine();
                Console.WriteLine("What is the color of the vehicle?");
                string color = Console.ReadLine();

                vehicle.Add("year", year);
                vehicle.Add("model", model);
                vehicle.Add("make", make);
                vehicle.Add("color", color);
                sale.Add("vehicle", vehicle);

                Console.WriteLine("\n Now we need information about your sales agent.\n");
                Console.WriteLine("What is the phone number of your sales agent?");
                string mobile = Console.ReadLine();
                Console.WriteLine("What is the last name of your sales agent?");
                string lastName = Console.ReadLine();
                Console.WriteLine("What is the first name of your sales agent?");
                string firsName = Console.ReadLine();

                salesAgent.Add("mobile", mobile);
                salesAgent.Add("last_name", lastName);
                salesAgent.Add("first_name", firsName);
                sale.Add("sales_agent", salesAgent);

                Console.WriteLine("\n Now we need some information on your credit provider.\n");
                Console.WriteLine("What is the name of your credit provider?");
                string creditProvider = Console.ReadLine();
                Console.WriteLine("What is your account number at your credit provider?");
                string account = Console.ReadLine();

                credit.Add("credit_provider", creditProvider);
                credit.Add("account", account);
                sale.Add("credit", credit);
                vehicles.Add(sale);
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("\nHere are the sales you entered:");
            foreach (Dictionary<string, Dictionary<string, string>> sale in vehicles)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> salePair in sale)
                {
                    Console.WriteLine($"{salePair.Key}:");
                    foreach (KeyValuePair<string, string> section in salePair.Value)
                    {
                        if (section.Key != "color" && section.Key != "first_name" && section.Key != "account")
                        {
                            Console.Write($"{section.Key}: {section.Value}, ");
                        }
                        else
                        {
                            Console.Write($"{section.Key}: {section.Value}");
                        }
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

        }
    }
}
