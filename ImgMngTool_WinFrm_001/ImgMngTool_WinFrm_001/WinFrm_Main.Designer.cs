namespace ImgMngTool_WinFrm_001
{
    partial class WinFrm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Icon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmb_Char = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ccPicBox_Icon = new Custom.Control.ccPictureBox();
            this.ccPicBox_Card_Normal = new Custom.Control.ccPictureBox();
            this.ccPicBox_Card_Evol_001 = new Custom.Control.ccPictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ccPicBox_Card_Evol_003 = new Custom.Control.ccPictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ccPicBox_Card_Evol_002 = new Custom.Control.ccPictureBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ccPicBox_SD = new Custom.Control.ccPictureBox();
            this.Cmb_SD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ccPicBox_Plate_Name = new Custom.Control.ccPictureBox();
            this.Cmb_Plate_Name = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccPicBox_Plate_Skill_001 = new Custom.Control.ccPictureBox();
            this.Cmb_Plate_Skill_1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ccPicBox_Plate_Skill_002 = new Custom.Control.ccPictureBox();
            this.Cmb_Plate_Skill_2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Evol_001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Evol_003)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Evol_002)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_SD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Plate_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Plate_Skill_001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Plate_Skill_002)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Icon";
            // 
            // cmb_Icon
            // 
            this.cmb_Icon.FormattingEnabled = true;
            this.cmb_Icon.Location = new System.Drawing.Point(12, 48);
            this.cmb_Icon.Name = "cmb_Icon";
            this.cmb_Icon.Size = new System.Drawing.Size(128, 23);
            this.cmb_Icon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CARD_NORMAL";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 364);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // cmb_Char
            // 
            this.cmb_Char.FormattingEnabled = true;
            this.cmb_Char.Location = new System.Drawing.Point(12, 0);
            this.cmb_Char.Name = "cmb_Char";
            this.cmb_Char.Size = new System.Drawing.Size(351, 23);
            this.cmb_Char.TabIndex = 0;
            this.cmb_Char.SelectedIndexChanged += new System.EventHandler(this.cmb_Char_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(369, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 24);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // ccPicBox_Icon
            // 
            PicList[(int)IMAGE_INFO.IMG_ICON] = ccPicBox_Icon;
            this.ccPicBox_Icon.Location = new System.Drawing.Point(13, 78);
            this.ccPicBox_Icon.Name = "ccPicBox_Icon";
            this.ccPicBox_Icon.Size = new System.Drawing.Size(96, 96);
            this.ccPicBox_Icon.TabIndex = 9;
            this.ccPicBox_Icon.TabStop = false;
            //this.ccPicBox_Icon.DragDrop += new System.Windows.Forms.DragEventHandler(this.Img_DragDrop);
            //this.ccPicBox_Icon.DragEnter += new System.Windows.Forms.DragEventHandler(this.Img_DragEnter);
            // 
            // ccPicBox_Card_Normal
            // 
            PicList[(int)IMAGE_INFO.IMG_CARD_NORMAL] = ccPicBox_Card_Normal;
            this.ccPicBox_Card_Normal.Location = new System.Drawing.Point(12, 393);
            this.ccPicBox_Card_Normal.Name = "ccPicBox_Card_Normal";
            this.ccPicBox_Card_Normal.Size = new System.Drawing.Size(96, 128);
            this.ccPicBox_Card_Normal.TabIndex = 10;
            this.ccPicBox_Card_Normal.TabStop = false;
            // 
            // ccPicBox_Card_Evol_001
            // 
            PicList[(int)IMAGE_INFO.IMG_CARD_EVOL_1] = ccPicBox_Card_Evol_001;
            this.ccPicBox_Card_Evol_001.Location = new System.Drawing.Point(144, 393);
            this.ccPicBox_Card_Evol_001.Name = "ccPicBox_Card_Evol_001";
            this.ccPicBox_Card_Evol_001.Size = new System.Drawing.Size(96, 128);
            this.ccPicBox_Card_Evol_001.TabIndex = 13;
            this.ccPicBox_Card_Evol_001.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "CARD_NORMAL";
            // 
            // ccPicBox_Card_Evol_003
            // 
            PicList[(int)IMAGE_INFO.IMG_CARD_EVOL_3] = ccPicBox_Card_Evol_003;
            this.ccPicBox_Card_Evol_003.Location = new System.Drawing.Point(409, 393);
            this.ccPicBox_Card_Evol_003.Name = "ccPicBox_Card_Evol_003";
            this.ccPicBox_Card_Evol_003.Size = new System.Drawing.Size(96, 128);
            this.ccPicBox_Card_Evol_003.TabIndex = 19;
            this.ccPicBox_Card_Evol_003.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(408, 364);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(128, 23);
            this.comboBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "CARD_NORMAL";
            // 
            // ccPicBox_Card_Evol_002
            // 
            PicList[(int)IMAGE_INFO.IMG_CARD_EVOL_2] = ccPicBox_Card_Evol_002;
            this.ccPicBox_Card_Evol_002.Location = new System.Drawing.Point(277, 393);
            this.ccPicBox_Card_Evol_002.Name = "ccPicBox_Card_Evol_002";
            this.ccPicBox_Card_Evol_002.Size = new System.Drawing.Size(96, 128);
            this.ccPicBox_Card_Evol_002.TabIndex = 16;
            this.ccPicBox_Card_Evol_002.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(276, 364);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(128, 23);
            this.comboBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "CARD_NORMAL";
            // 
            // ccPicBox_SD
            // 
            PicList[(int)IMAGE_INFO.IMG_SD] = ccPicBox_SD;
            this.ccPicBox_SD.Location = new System.Drawing.Point(12, 227);
            this.ccPicBox_SD.Name = "ccPicBox_SD";
            this.ccPicBox_SD.Size = new System.Drawing.Size(96, 96);
            this.ccPicBox_SD.TabIndex = 22;
            this.ccPicBox_SD.TabStop = false;
            // 
            // Cmb_SD
            // 
            this.Cmb_SD.FormattingEnabled = true;
            this.Cmb_SD.Location = new System.Drawing.Point(11, 197);
            this.Cmb_SD.Name = "Cmb_SD";
            this.Cmb_SD.Size = new System.Drawing.Size(128, 23);
            this.Cmb_SD.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "SD";
            // 
            // ccPicBox_Plate_Name
            // 
            PicList[(int)IMAGE_INFO.IMG_PLATE_NAME] = ccPicBox_Plate_Name;
            this.ccPicBox_Plate_Name.Location = new System.Drawing.Point(277, 78);
            this.ccPicBox_Plate_Name.Name = "ccPicBox_Plate_Name";
            this.ccPicBox_Plate_Name.Size = new System.Drawing.Size(175, 44);
            this.ccPicBox_Plate_Name.TabIndex = 25;
            this.ccPicBox_Plate_Name.TabStop = false;
            // 
            // Cmb_Plate_Name
            // 
            this.Cmb_Plate_Name.FormattingEnabled = true;
            this.Cmb_Plate_Name.Location = new System.Drawing.Point(277, 48);
            this.Cmb_Plate_Name.Name = "Cmb_Plate_Name";
            this.Cmb_Plate_Name.Size = new System.Drawing.Size(128, 23);
            this.Cmb_Plate_Name.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Plate_Name";
            // 
            // ccPicBox_Plate_Skill_001
            // 
            PicList[(int)IMAGE_INFO.IMG_PLATE_SKILL_1] = ccPicBox_Plate_Skill_001;
            this.ccPicBox_Plate_Skill_001.Location = new System.Drawing.Point(276, 179);
            this.ccPicBox_Plate_Skill_001.Name = "ccPicBox_Plate_Skill_001";
            this.ccPicBox_Plate_Skill_001.Size = new System.Drawing.Size(175, 44);
            this.ccPicBox_Plate_Skill_001.TabIndex = 28;
            this.ccPicBox_Plate_Skill_001.TabStop = false;
            // 
            // Cmb_Plate_Skill_1
            // 
            this.Cmb_Plate_Skill_1.FormattingEnabled = true;
            this.Cmb_Plate_Skill_1.Location = new System.Drawing.Point(276, 149);
            this.Cmb_Plate_Skill_1.Name = "Cmb_Plate_Skill_1";
            this.Cmb_Plate_Skill_1.Size = new System.Drawing.Size(128, 23);
            this.Cmb_Plate_Skill_1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Plate_Skill_1";
            // 
            // ccPicBox_Plate_Skill_002
            // 
            PicList[(int)IMAGE_INFO.IMG_PLATE_SKILL_2] = ccPicBox_Plate_Skill_002;
            this.ccPicBox_Plate_Skill_002.Location = new System.Drawing.Point(276, 285);
            this.ccPicBox_Plate_Skill_002.Name = "ccPicBox_Plate_Skill_002";
            this.ccPicBox_Plate_Skill_002.Size = new System.Drawing.Size(175, 44);
            this.ccPicBox_Plate_Skill_002.TabIndex = 31;
            this.ccPicBox_Plate_Skill_002.TabStop = false;
            // 
            // Cmb_Plate_Skill_2
            // 
            this.Cmb_Plate_Skill_2.FormattingEnabled = true;
            this.Cmb_Plate_Skill_2.Location = new System.Drawing.Point(277, 256);
            this.Cmb_Plate_Skill_2.Name = "Cmb_Plate_Skill_2";
            this.Cmb_Plate_Skill_2.Size = new System.Drawing.Size(128, 23);
            this.Cmb_Plate_Skill_2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Plate_Skill_2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinFrm_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ccPicBox_Plate_Skill_002);
            this.Controls.Add(this.Cmb_Plate_Skill_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ccPicBox_Plate_Skill_001);
            this.Controls.Add(this.Cmb_Plate_Skill_1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ccPicBox_Plate_Name);
            this.Controls.Add(this.Cmb_Plate_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ccPicBox_SD);
            this.Controls.Add(this.Cmb_SD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ccPicBox_Card_Evol_003);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ccPicBox_Card_Evol_002);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccPicBox_Card_Evol_001);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccPicBox_Card_Normal);
            this.Controls.Add(this.ccPicBox_Icon);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Char);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Icon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinFrm_Main";
            this.Text = "WinFrm_Main";
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Evol_001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Evol_003)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Card_Evol_002)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_SD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Plate_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Plate_Skill_001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccPicBox_Plate_Skill_002)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Icon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmb_Char;
        private System.Windows.Forms.Button btn_Add;
        private Custom.Control.ccPictureBox ccPicBox_Icon;
        private Custom.Control.ccPictureBox ccPicBox_Card_Normal;
        private Custom.Control.ccPictureBox ccPicBox_Card_Evol_001;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private Custom.Control.ccPictureBox ccPicBox_Card_Evol_003;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private Custom.Control.ccPictureBox ccPicBox_Card_Evol_002;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private Custom.Control.ccPictureBox ccPicBox_SD;
        private System.Windows.Forms.ComboBox Cmb_SD;
        private System.Windows.Forms.Label label6;
        private Custom.Control.ccPictureBox ccPicBox_Plate_Name;
        private System.Windows.Forms.ComboBox Cmb_Plate_Name;
        private System.Windows.Forms.Label label7;
        private Custom.Control.ccPictureBox ccPicBox_Plate_Skill_001;
        private System.Windows.Forms.ComboBox Cmb_Plate_Skill_1;
        private System.Windows.Forms.Label label8;
        private Custom.Control.ccPictureBox ccPicBox_Plate_Skill_002;
        private System.Windows.Forms.ComboBox Cmb_Plate_Skill_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}