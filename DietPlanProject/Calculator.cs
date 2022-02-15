using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlanProject
{
    public class Calculator
    {
        public double height;
        public double weight;
        public int age;
        public double activityLevel;

        //Mifflin St. Jeor method of calculating TDEE
        public double MiffStJeor(double weight, double height, int age, double activityLevel)
        {
            double basalMetabolicRate = (10 * weight) + (6.25 * height) + (5 * age) - 161;
            return basalMetabolicRate;

            double energyExpidenture = basalMetabolicRate * activityLevel;
            return energyExpidenture;

            Console.WriteLine($"Your TDEE is { energyExpidenture }.");

            //need to round energyExpidenture
        }
    }
}
