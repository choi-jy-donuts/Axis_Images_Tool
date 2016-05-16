using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMngTool_WinFrm_001
{

    class CharInfo
    {
        int index;          // 캐릭터 정보 인덱스 시작값 = 0;
        string CharName;    // 캐릭터 이름. 이 기준으로 폴더 생성.
        public int GetSet_Index
        {
            get {return index; }
            set { index = value; }
        }
        public string GetSet_CharName
        {
            get { return CharName; }
            set { CharName = value; }
        }
        LinkedList<ImageInfo>[] ImageList = new LinkedList<ImageInfo>[GlobalValue.InfoLength];
        public LinkedList<ImageInfo> Get_ImageList(IMAGE_INFO _ImageInfo)
        {
            return ImageList[(int)_ImageInfo];
        }
    }
}
