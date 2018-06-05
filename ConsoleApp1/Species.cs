using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Species
    {
        public double Height { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }
        public bool HasTail { get; set; }
        public double Weight { get; set; } // when setting a prop like this you dont need a field, auto creates a field

        public virtual void GetInfo()
        {
            Console.WriteLine(" {0} is {1} lbs , is {2} in tall , lives in {3}", Name, Weight, Height, Habitat);
        }
        public double Sum()
        {
            double sum = this.Weight + this.Height;
            return sum;
        }
        public virtual double GetWeight(double num = 0)
        {
            
            return Weight;
        }




    } // end class
}
