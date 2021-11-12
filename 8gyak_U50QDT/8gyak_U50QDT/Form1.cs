using _8gyak_U50QDT.Abstractions;
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
        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        private Toy _nextToy;
        public IToyFactory Factory 
        {
            get { return _factory; }
            set 
                {
                _factory = value;
                DisplayNext();
                }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add((Toy)toy);
            mainPanel.Controls.Add(toy);
            toy.Left = -toy.Width;
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = (Toy)Factory.CreateNew();
            _nextToy.Top = lblNext.Top + lblNext.Height + 20;
            _nextToy.Left = lblNext.Left;
            Controls.Add(_nextToy);
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
    }
}
