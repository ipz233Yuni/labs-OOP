using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TravelFormsClass
    {
        public static double CalculateTripCost(int travelers, int days, string country, string season, bool needGuide)
        {
            double costPerDay = 0;
            switch (country)
            {
                case "Болгарія":
                    costPerDay = season == "літо" ? 100 : 150;
                    break;
                case "Німеччина":
                    costPerDay = season == "літо" ? 160 : 200;
                    break;
                case "Польща":
                    costPerDay = season == "літо" ? 120 : 180;
                    break;
            }

            double totalCost = costPerDay * days * travelers;

            if (needGuide)
            {
                totalCost += 50 * days * travelers;
            }

            return totalCost;
        }
    }

}
