using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgMngTool_WinFrm_001
{
    public enum IMAGE_INFO
    {
        NONE = -1,
        IMG_ICON = 0,
        IMG_SD,
        IMG_CARD_NORMAL,
        IMG_CARD_EVOL_1,
        IMG_CARD_EVOL_2,
        IMG_CARD_EVOL_3,
        IMG_PLATE_NAME,
        IMG_PLATE_SKILL_1,
        IMG_PLATE_SKILL_2,
    };
    public class GlobalValue
    {
        static public int InfoLength = 9;
        public string RootDir = Application.StartupPath + "\\Resource";
        public string Get_RootDir()
        {
            return RootDir;
        }
    }
}
