using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Furniture
    {
        public string Materiale { get; set; }
        public string Farve { get; set; }
        public double Pris { get; set; }

        public Furniture(string materiale, string farve, double pris)
        {
            Materiale = materiale;
            Farve = farve;
            Pris = pris;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Materiale: {Materiale}, Farve: {Farve}, Pris: {Pris}");
        }

    }
}
