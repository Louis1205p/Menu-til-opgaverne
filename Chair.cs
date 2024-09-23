using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Chair : Furniture
    {
        public bool HarArmlæn { get; set; }

        public Chair(string materiale, string farve, double pris, bool harArmlæn)
        : base(materiale, farve, pris)
        {
            HarArmlæn = harArmlæn;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Har Armlæn: {HarArmlæn}");
        }

    }
}