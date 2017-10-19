using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace NuGET_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(30);


            Turtle.Forward(200);


            Turtle.Rotate(120);


            Turtle.Forward(200);


            Turtle.Rotate(120);


            Turtle.Forward(200);
        }
    }
}
