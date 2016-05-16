using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMngTool_WinFrm_001
{
    class Manager
    {
        static Manager MngInst;
        int[] Index = new int[GlobalValue.InfoLength];
        //Dictionary<int index, IMAGE_INFO ImgInfo, ImageInfo Obj_ImgInfo>
        LinkedList<CharInfo> CharInfo_List = new LinkedList<CharInfo>();
        Dictionary<string, CharInfo> Dic_CharInfo = new Dictionary<string, CharInfo>();

        private Manager()
        {

        }

        public static Manager Get_Inst()
        {
            if (MngInst == null)
            {
                MngInst = new Manager();
                Console.WriteLine("Manager Instance Created");
                return MngInst;
            }
            else
            {
                Console.WriteLine("Manager Instance Exist");
                return MngInst;
            }
        }

        
    }
}
