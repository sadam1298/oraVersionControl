using _8gyak_U50QDT.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8gyak_U50QDT.Entities
{
    public class Present : Toy
    {
        public SolidBrush szalag { get; private set; }
        public SolidBrush doboz { get; private set; }

        public Present(Color ribbon,Color box)
        {
            szalag = new SolidBrush(ribbon);
            doboz = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(doboz, 0, 0, Width, Height);
            g.FillRectangle(szalag, 20, 0, Width/5, Height);
            g.FillRectangle(szalag, 0, 20, Width, Height/5);

        }
    }
}
