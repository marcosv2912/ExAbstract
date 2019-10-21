using System;
using System.Collections.Generic;
using ExAbstract.Entities;
using System.Globalization;

namespace ExAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                char IC = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (IC == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualincome, healthexpenditures));
                }
                else if (IC == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberofemployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualincome, numberofemployees));
                }
                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $" + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
