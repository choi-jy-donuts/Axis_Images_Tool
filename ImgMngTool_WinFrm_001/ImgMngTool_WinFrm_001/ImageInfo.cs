using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgMngTool_WinFrm_001
{
    class ImageInfo
    {
        int Index;
        string CharName;        //캐릭터 이름 : 생성 단계에서 생성자로 받음.
        string ImagePath;       //이미지 경로
        DateTime UpdatedTime;   //업데이트 시간
        IMAGE_INFO Image_Info;


        public ImageInfo(string _CharName)
        {
            this.CharName = _CharName;
        }


        public int GetSet_Index
        {
            get { return Index; }
            set { Index = value; }
        }
        public string GetSet_CharName
        {
            get { return CharName; }
            set { CharName = value; }
        }
        public string GetSet_ImagePath
        {
            get { return ImagePath; }
            set { ImagePath = value; }
        }
        public DateTime GetSet_UpdatedTime
        {
            get { return UpdatedTime; }
            set { UpdatedTime = value; }
        }
        public IMAGE_INFO GetSet_Image_Info
        {
            get { return Image_Info; }
            set { Image_Info = value; }
        }

    }
}
