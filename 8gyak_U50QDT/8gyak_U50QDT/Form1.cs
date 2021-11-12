using _8gyak_U50QDT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8gyak_U50QDT
{
    public partial class Form1 : Form
    {
        private List<Ball> _balls = new List<Ball>();
        private BallFactory _factory;
        public BallFactory Factory 
        {
            get { return _factory; }
            set { _factory = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
