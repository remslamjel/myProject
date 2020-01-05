using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newR
{
     public class CircularPicture: PictureBox
    {
         protected override void OnPaint(PaintEventArgs p)
         {
             GraphicsPath g = new GraphicsPath();
             g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
             this.Region = new System.Drawing.Region(g);
             base.OnPaint(p);


         }
    }
}
