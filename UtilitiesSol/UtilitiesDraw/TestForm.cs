using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void LogInfo(string info)
        {
            string logFile = @"..\..\..\Resources\TestFormApp.log";
            using (StreamWriter sw = new StreamWriter(logFile, true))
            {
                sw.WriteLine(info);
            }
            //using StreamWriter sw = new StreamWriter(logFile, true)
            //// ...
        }

        private void ButtonNewMessage_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Přišla nová zpráva!";

            LogInfo("Method: ButtonNewMessage_Click");

            LogInfo(sender.GetType().FullName);
            Button senderAsButton = (Button) sender;
            LogInfo(senderAsButton.Text);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Zatím žádné zprávy";

            LogInfo("Method: ButtonClear_Click");

            LogInfo(sender.GetType().FullName);
            Button senderAsButton = (Button)sender;
            LogInfo(senderAsButton.Text);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            LogInfo("");
            LogInfo("Application started anew...");
        }

        private void PanelTest_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Kliknuto na panelTest";

            LogInfo("Method: PanelTest_Click");

            LogInfo(sender.GetType().FullName);
        }

        private void PanelTest_MouseDown(object sender, MouseEventArgs e)
        {

            LogInfo("Method: PanelTest_MouseDown");

            LogInfo(sender.GetType().FullName);

            string infoXY = $"X: {e.X}   Y: {e.Y}";
            LogInfo(infoXY);
        }
    }
}
