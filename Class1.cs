using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class RoundedButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, this.Width, this.Height);
        this.Region = new Region(path);
        base.OnPaint(pevent);
    }
}

namespace Calculator_CS
{
    class Class1
    {
    }
}
