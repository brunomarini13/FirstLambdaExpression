using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTest.Entities
{
    class Company
    {
        public string Name { get; set; }
        public double MarketValue { get; set; }
        public double LastAnnualProfit { get; set; }

        public Company(string name, double marketValue, double lastAnnualProfit)
        {
            Name = name;
            MarketValue = marketValue;
            LastAnnualProfit = lastAnnualProfit;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine("Market value: $" + MarketValue.ToString("f2", CultureInfo.InvariantCulture));
            sb.AppendLine("Profits in last year: $" + LastAnnualProfit.ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
