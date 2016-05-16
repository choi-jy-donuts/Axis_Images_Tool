using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgMngTool_WinFrm_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            WinFrm_Main _Winfrm_Main = new WinFrm_Main();
            _Winfrm_Main.ShowDialog();
            this.Close();
        }
    }
}
