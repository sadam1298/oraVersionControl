using _8gyak_U50QDT.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8gyak_U50QDT.Entities
{
    public class Carfactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
