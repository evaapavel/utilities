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
    public partial class TrialForm : Form
    {
        public TrialForm()
        {
            InitializeComponent();
        }

        private void ButtonNewMessage_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Přišla vám nová zpráva!";

            LogInfo(sender.GetType().FullName);
            Button senderAsButton = (Button) sender;
            LogInfo(senderAsButton.Text);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.labelMessage.Text = "Žádné nové zprávy...";

            LogInfo(sender.GetType().FullName);
            Button senderAsButton = (Button)sender;
            LogInfo(senderAsButton.Text);
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            //this.labelMessage.Text = "Zobrazuji zprávu";

            //LogInfo(sender.GetType().FullName);
            //Button senderAsButton = (Button)sender;
            //LogInfo(senderAsButton.Text);

            string fileName = this.textBoxFileName.Text;
            int selectedImageFormat = this.listBoxImageFormat.SelectedIndex;
        }


        private void LogInfo(string info)
        {
            //string logFile = @"..\..\..\Resources\MyApp_v02.log";
            //using (StreamWriter sw = new StreamWriter(logFile, true))
            //{
            //    sw.WriteLine(info);
            //}
        }

        private void TrialForm_Load(object sender, EventArgs e)
        {
            LogInfo("");
            LogInfo("Nový běh aplikace.");
        }

        private void TrialForm_Click(object sender, EventArgs e)
        {
            LogInfo(sender.GetType().FullName);
        }




        private void PanelTrial_MouseDown(object sender, MouseEventArgs e)
        {
            LogInfo("Method: PanelTrial_MouseDown");
            LogInfo(sender.GetType().FullName);
            string infoXY = $"X: {e.X}  Y: {e.Y}";
            LogInfo(infoXY);
            LogInfo("");
        }

        private void PanelTrial_MouseUp(object sender, MouseEventArgs e)
        {
            LogInfo("Method: PanelTrial_MouseUp");
            LogInfo(sender.GetType().FullName);
            string infoXY = $"X: {e.X}  Y: {e.Y}";
            LogInfo(infoXY);
            LogInfo("");
        }

        private void PanelTrial_MouseMove(object sender, MouseEventArgs e)
        {
            //LogInfo("Method: PanelTrial_MouseMove");
            //LogInfo(sender.GetType().FullName);
            //string infoXY = $"X: {e.X}  Y: {e.Y}";
            //LogInfo(infoXY);
            //LogInfo("");
        }
    }
}
