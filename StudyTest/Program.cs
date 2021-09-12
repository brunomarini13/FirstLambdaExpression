using System;
using System.Collections.Generic;
using System.Globalization;
using StudyTest.Entities;

namespace StudyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> myList = new List<Company>();

            Company a1 = new Company("Coca Cola", 8000000, 40000);
            Company a2 = new Company("Pepsi", 6000000, 30000);
            Company a3 = new Company("Fruki", 400000, 50000);
            Company a4 = new Company("Dolly", 2000, 500);

            myList.Add(a1);
            myList.Add(a2);
            myList.Add(a3);
            myList.Add(a4);

            /* sorting by Name */
            myList.Sort((a1, a2) => a1.Name.ToUpper().CompareTo(a2.Name.ToUpper()));

            /* sorting by MarketValue */
             myList.Sort((a1, a2) => a1.MarketValue.CompareTo(a2.MarketValue));

            /* sorting by Annual Profit */
            myList.Sort((a1, a2) => a1.LastAnnualProfit.CompareTo(a2.LastAnnualProfit));

            foreach (Company c in myList)
            {
                Console.WriteLine(c);
            }
        }
    }
}
