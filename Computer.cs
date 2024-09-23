using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Computer : Furniture
    {
        public string Processor { get; set; }

        public Computer(string materiale, string farve, double pris, string processor)
            : base(materiale, farve, pris)
        {
            Processor = processor;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Processor: {Processor}");
        }
    }
}
