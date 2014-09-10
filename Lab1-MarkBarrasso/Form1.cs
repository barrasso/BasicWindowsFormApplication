using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_MarkBarrasso
{
    public partial class Form1 : Form
    {
        // Default Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Paint Event Handler
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Instantiate graphics class
            Graphics g = e.Graphics;

            // Draw string with default font and solid green brush at position (100,100)
            g.DrawString("Mark Barrasso", Font, new SolidBrush (Color.Green), 100, 100);
        }
    }
}
