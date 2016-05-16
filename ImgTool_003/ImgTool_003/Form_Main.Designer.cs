namespace ImgTool_003
{
    partial class Form_Main
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
            this.cPicBox_Icon = new Custom.Control.CustumPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cPicBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // cPicBox_Icon
            // 
            this.cPicBox_Icon.Location = new System.Drawing.Point(45, 12);
            this.cPicBox_Icon.Name = "cPicBox_Icon";
            this.cPicBox_Icon.Size = new System.Drawing.Size(144, 130);
            this.cPicBox_Icon.TabIndex = 0;
            this.cPicBox_Icon.TabStop = false;
            this.cPicBox_Icon.DragEnter += new System.Windows.Forms.DragEventHandler(ImgPanel_DragEnter);
            this.cPicBox_Icon.DragDrop += new System.Windows.Forms.DragEventHandler(ImgPanel_DragDrop);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.cPicBox_Icon);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.cPicBox_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.Control.CustumPictureBox cPicBox_Icon;
    }
}