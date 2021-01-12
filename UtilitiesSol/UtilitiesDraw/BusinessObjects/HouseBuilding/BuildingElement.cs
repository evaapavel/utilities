using System;
using System.Drawing;

using UtilitiesDraw.PaintersObjects;



namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class BuildingElement
    {



        public virtual void DrawSelf(Graphics g, CanvasContext context)
        {
            //Pen pen = new Pen(Color.Magenta, 1.0f);
            //g.DrawRectangle(pen, context.Left, context.Top, context.Width, context.Height);
            //Brush brush = new Brush();
            using (Brush brush = new SolidBrush(Color.Magenta))
            {
                g.FillRectangle(brush, context.Left, context.Top, context.Width, context.Height);
            }
        }



    }



}
