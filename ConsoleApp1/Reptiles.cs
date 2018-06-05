using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reptiles : Species
    {
        public Reptiles(string name, string habitat, double height, double weight, bool hastail) // loaded constructor
        {
            this.Name = name;
            this.Habitat = habitat;
            this.Height = height;
            this.Weight = weight;
            this.HasTail = hastail;
        }
 
    }
}
