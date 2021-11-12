using _8gyak_U50QDT.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8gyak_U50QDT.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color szalag { get; set; }
        public Color doboz { get; set; }
        public Toy CreateNew()
        {
            return new Present(szalag, doboz);
        }
    }
}
