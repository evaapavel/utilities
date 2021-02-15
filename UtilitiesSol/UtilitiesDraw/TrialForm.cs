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
    public partial class TrialForm : Form
    {
        public TrialForm()
        {
            InitializeComponent();
        }

        private void ButtonNewMessage_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Přišla vám nová zpráva!";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Žádné nové zprávy...";
        }
    }
}
