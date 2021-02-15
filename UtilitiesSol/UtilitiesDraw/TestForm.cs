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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void ButtonCompute_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Přišla nová zpráva!";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Zatím žádné zprávy";
        }
    }
}
