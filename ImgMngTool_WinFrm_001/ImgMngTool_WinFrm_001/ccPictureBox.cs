using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Custom.Control
{
    class ccPictureBox : PictureBox
    {
        [Browsable(true)]
        public override bool AllowDrop { get; set; }
        private bool isChanged;

        public bool GetSet_isChanged
        {
            get { return isChanged; }
            set { isChanged = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}