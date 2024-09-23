using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Bil
    {
        private double gasTank = 10.0;

        public void StartMotor()
        {
            Console.WriteLine("Motoren er startet.");
        }

        public void StopMotor()
        {
            Console.WriteLine("Motoren er slukket.");
        }

        public void FillGas(double liters, bool isDiesel)
        {
            Console.WriteLine($"Filled tank with: {liters} liters");
            gasTank += liters; // Opdaterer gasniveauet
        }

        public double RemainingGas()
        {
            return gasTank;
        }
    }

}