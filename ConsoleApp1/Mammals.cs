using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mammals : Species
    {
        public Mammals(string name, string habitat,double height, double weight, bool hastail) // loaded constructor
        {
            this.Name = name;
            this.Habitat = habitat;
            this.Height = height;
            this.Weight = weight;
            this.HasTail = hastail;
        }
        public override double GetWeight(double num)
        {
            num = num + Weight;
            return num;
        }
    }
}
