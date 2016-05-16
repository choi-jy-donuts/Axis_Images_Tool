using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Custom.Control;

namespace ImgMngTool_WinFrm_001
{
    public partial class WinFrm_Main : Form
    {
        ccPictureBox[] PicList = new ccPictureBox[GlobalValue.InfoLength];
        string RootDir;
        string DataDir;
        public WinFrm_Main()
        {
            RootDir = Application.StartupPath + "\\" + "Resources";
            DataDir = RootDir + "\\" + "DataInfo";
            InitializeComponent();
            Check_Exist_DefaultDir();
            for (int i = 0; i < GlobalValue.InfoLength; i++)
            {
                if (!PicList[i].AllowDrop)
                {
                    PicList[i].AllowDrop = true;
                    PicList[i].DragDrop += new System.Windows.Forms.DragEventHandler(this.Img_DragDrop);
                    PicList[i].DragEnter += new System.Windows.Forms.DragEventHandler(this.Img_DragEnter);
                }
            }

        }

        void Img_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void Img_DragDrop(object sender, DragEventArgs e)
        {
            string ctrlName = ((Control)sender).Name;
            MessageBox.Show(ctrlName);
            Image img1;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                img1 = Image.FromFile(file);
                for (int i = 0; i< GlobalValue.InfoLength; i++)
                {
                    if (ctrlName == PicList[i].Name)
                    {
                        MessageBox.Show(ctrlName + " == " + PicList[i].Name);
                        PicList[i].Image = img1;
                        PicList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        this.Controls.Add(PicList[i]);
                        PicList[i].GetSet_isChanged = true;
                        break;
                    }
                }
            }
        }

        void Check_Exist_DefaultDir()
        {
            DirectoryInfo di = new DirectoryInfo(RootDir);
            if (!di.Exists)
            {
                di.Create();
            }
            di = new DirectoryInfo(DataDir);
            if (!di.Exists)
            {
                di.Create();
            }
        }

        void Create_Folder(string FolderName)
        {
            string sDirPath = RootDir;
            sDirPath += "\\" + FolderName;
            DirectoryInfo di = new DirectoryInfo(sDirPath);
            if (!di.Exists)
            {
                di.Create();
                MessageBox.Show(sDirPath + " Was Created successfully!!!");
            }
        }

        void Init()
        {
            //TODO  :   캐릭터 리스트가 존재할 경우 파일로부터 이름을 기준으로 캐릭터정보 콤보박스로 받아옴. 없으면 생략

            //TODO  :   이하의 모든 사항은 마지막 인덱스(시간정보가 가장 최신인 파일) 기준으로 내림차순으로 정렬.
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 ICON의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 SD의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Normal의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Evol_001의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Evol_002의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Evol_003의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Plate_Name의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Plate_Skill_001의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Plate_Skill_002의 이미지 정보를 콤보박스로 받아옴, 동적 생성을 함. 없으면 생략

        }
        void Show_Char_Image()
        {
            //TODO  :   캐릭터 리스트가 존재할 경우 파일로부터 이름을 기준으로 선택 시, 이하의 동작을 수행, 판넬에 띄어줌.


            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 ICON의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 SD의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Normal의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Evol_001의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Evol_002의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Card_Evol_003의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Plate_Name의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Plate_Skill_001의 이미지 정보를 콤보박스로 받아옴. 없으면 생략
            //TODO  :   캐릭터정보 콤보박스의 이름을 기준으로 하위 폴더 Plate_Skill_002의 이미지 정보를 콤보박스로 받아옴. 없으면 생략

        }

        private void cmb_Char_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static Control FindControlAtPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null) return c;
                    else return child;
                }
            }
            return null;
        }
        public static Control FindControlAtCursor(Form form)
        {
            Point pos = Cursor.Position;
            if (form.Bounds.Contains(pos))
                return FindControlAtPoint(form, form.PointToClient(Cursor.Position));
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want Apply this Inform?","Confirm",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Exclamation,
                                                    MessageBoxDefaultButton.Button2
                                                 );
            if(result != DialogResult.Yes)
            {
                MessageBox.Show("Cancled");
                return;
            }
            MessageBox.Show("Applied");
        }
    }
}
