using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace Custom.Control
{
    class CustumPictureBox : PictureBox
    {
        [Browsable(true)]
        public override bool AllowDrop { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
