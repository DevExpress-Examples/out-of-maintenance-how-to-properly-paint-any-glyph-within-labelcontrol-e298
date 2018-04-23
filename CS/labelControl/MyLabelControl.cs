using System.Drawing;
using System.Reflection;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace DevExpress.CustomEditors
{
    public class MyLabelControl : LabelControl
    {
        //Initialize the new instance
        public MyLabelControl()
            : base()
        {
            //...
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Brush brush = Brushes.Yellow;
            Point location = new Point(e.ClipRectangle.Left + (Width - Height),
                e.ClipRectangle.Top);
            Size size = new Size(e.ClipRectangle.Height, e.ClipRectangle.Height);
            Rectangle rect = new Rectangle(location, size);
            e.Graphics.FillEllipse(brush, rect);
        }

        private bool internalChange = false;

        protected override void LayoutChanged(bool isVisualUpdate)
        {
            if (internalChange)
                return;
            internalChange = true;
            try
            {
                base.LayoutChanged(isVisualUpdate);
                if (!(AutoSizeMode == LabelAutoSizeMode.None))
                    Size = new Size(Size.Width + Size.Height, Size.Height);
            }
            finally
            {
                internalChange = false;
            }
        }
    }
}