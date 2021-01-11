using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesDraw
{
    public partial class CanvasForm : Form
    {
        public CanvasForm()
        {
            InitializeComponent();
        }

        private void CanvasForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Pen pen = new Pen(Color.Black, 1.0f);
            Pen pen = new Pen(Color.Black, 2.0f);
            g.DrawLine(pen, 0, 0, 100, 100);
        }

    }
}
