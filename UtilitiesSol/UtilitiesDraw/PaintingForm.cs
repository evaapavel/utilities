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
    public partial class PaintingForm : Form
    {

        private Point startPoint;
        private Point endPoint;
        private Point endPointPrevious;
        private bool isMouseDown;
        private bool isPreviousLineRemoved;

        public PaintingForm()
        {
            InitializeComponent();
            this.isMouseDown = false;
            this.isPreviousLineRemoved = false;
            this.startPoint = new Point(0, 0);
            this.endPoint = new Point(0, 0);
            this.endPointPrevious = new Point(0, 0);
        }

        private void PanelPainting_MouseDown(object sender, MouseEventArgs e)
        {
            this.isMouseDown = true;
            this.startPoint = e.Location;
            this.endPoint = new Point(0, 0);
            this.panelPainting.Refresh();
        }

        private void PanelPainting_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseDown = false;
            this.endPoint = e.Location;
            this.isPreviousLineRemoved = true;
            this.panelPainting.Refresh();
        }

        private void PanelPainting_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isPreviousLineRemoved)
            {
                this.endPointPrevious = this.endPoint;
            }
            this.endPoint = e.Location;
            this.panelPainting.Refresh();
        }

        private void PanelPainting_Paint(object sender, PaintEventArgs e)
        {
            if (this.isMouseDown)
            {
                if ((this.startPoint != new Point(0, 0)) && (this.endPoint != new Point(0, 0)))
                {
                    using (Pen penDraw = new Pen(Color.Black, 2.0f))
                    {
                        e.Graphics.DrawLine(penDraw, this.startPoint, this.endPoint);
                        this.isPreviousLineRemoved = false;
                    }
                    if (this.endPointPrevious != new Point(0, 0))
                    {
                        using (Pen penRub = new Pen(Color.White, 2.0f))
                        {
                            e.Graphics.DrawLine(penRub, this.startPoint, this.endPointPrevious);
                            this.isPreviousLineRemoved = true;
                        }
                    }
                }
            }
        }
    }
}
