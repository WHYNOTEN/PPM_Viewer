namespace PpmViewer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.viewBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Headlbl = new System.Windows.Forms.Label();
            this.modeLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.EncodeLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mgtxt = new System.Windows.Forms.TextBox();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.Typetxt = new System.Windows.Forms.TextBox();
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.SizeTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewBtn.Location = new System.Drawing.Point(12, 406);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(93, 42);
            this.viewBtn.TabIndex = 0;
            this.viewBtn.Text = "查看";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SizeTxt);
            this.panel1.Controls.Add(this.CodeTxt);
            this.panel1.Controls.Add(this.Typetxt);
            this.panel1.Controls.Add(this.SizeLbl);
            this.panel1.Controls.Add(this.Mgtxt);
            this.panel1.Controls.Add(this.EncodeLbl);
            this.panel1.Controls.Add(this.TypeLbl);
            this.panel1.Controls.Add(this.modeLbl);
            this.panel1.Controls.Add(this.Headlbl);
            this.panel1.Location = new System.Drawing.Point(630, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 197);
            this.panel1.TabIndex = 2;
            // 
            // Headlbl
            // 
            this.Headlbl.AutoSize = true;
            this.Headlbl.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Headlbl.ForeColor = System.Drawing.Color.Red;
            this.Headlbl.Location = new System.Drawing.Point(75, 0);
            this.Headlbl.Name = "Headlbl";
            this.Headlbl.Size = new System.Drawing.Size(110, 31);
            this.Headlbl.TabIndex = 0;
            this.Headlbl.Text = "头部信息";
            // 
            // modeLbl
            // 
            this.modeLbl.AutoSize = true;
            this.modeLbl.Location = new System.Drawing.Point(3, 45);
            this.modeLbl.Name = "modeLbl";
            this.modeLbl.Size = new System.Drawing.Size(103, 15);
            this.modeLbl.TabIndex = 1;
            this.modeLbl.Text = "Magic Number";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(4, 82);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(39, 15);
            this.TypeLbl.TabIndex = 2;
            this.TypeLbl.Text = "Type";
            // 
            // EncodeLbl
            // 
            this.EncodeLbl.AutoSize = true;
            this.EncodeLbl.Location = new System.Drawing.Point(4, 121);
            this.EncodeLbl.Name = "EncodeLbl";
            this.EncodeLbl.Size = new System.Drawing.Size(71, 15);
            this.EncodeLbl.TabIndex = 3;
            this.EncodeLbl.Text = "Encoding";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.导出文件ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 导出文件ToolStripMenuItem
            // 
            this.导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            this.导出文件ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.导出文件ToolStripMenuItem.Text = "导出文件";
            this.导出文件ToolStripMenuItem.Click += new System.EventHandler(this.导出文件ToolStripMenuItem_Click);
            // 
            // Mgtxt
            // 
            this.Mgtxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mgtxt.ForeColor = System.Drawing.Color.Red;
            this.Mgtxt.Location = new System.Drawing.Point(112, 34);
            this.Mgtxt.Multiline = true;
            this.Mgtxt.Name = "Mgtxt";
            this.Mgtxt.ReadOnly = true;
            this.Mgtxt.Size = new System.Drawing.Size(87, 33);
            this.Mgtxt.TabIndex = 4;
            this.Mgtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Location = new System.Drawing.Point(5, 164);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(39, 15);
            this.SizeLbl.TabIndex = 7;
            this.SizeLbl.Text = "Size";
            // 
            // Typetxt
            // 
            this.Typetxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Typetxt.ForeColor = System.Drawing.Color.Red;
            this.Typetxt.Location = new System.Drawing.Point(112, 75);
            this.Typetxt.Multiline = true;
            this.Typetxt.Name = "Typetxt";
            this.Typetxt.ReadOnly = true;
            this.Typetxt.Size = new System.Drawing.Size(87, 33);
            this.Typetxt.TabIndex = 8;
            this.Typetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CodeTxt
            // 
            this.CodeTxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeTxt.ForeColor = System.Drawing.Color.Red;
            this.CodeTxt.Location = new System.Drawing.Point(112, 117);
            this.CodeTxt.Multiline = true;
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.ReadOnly = true;
            this.CodeTxt.Size = new System.Drawing.Size(87, 33);
            this.CodeTxt.TabIndex = 9;
            this.CodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SizeTxt
            // 
            this.SizeTxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SizeTxt.ForeColor = System.Drawing.Color.Red;
            this.SizeTxt.Location = new System.Drawing.Point(112, 158);
            this.SizeTxt.Multiline = true;
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.ReadOnly = true;
            this.SizeTxt.Size = new System.Drawing.Size(87, 33);
            this.SizeTxt.TabIndex = 10;
            this.SizeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EncodeLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label modeLbl;
        private System.Windows.Forms.Label Headlbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出文件ToolStripMenuItem;
        private System.Windows.Forms.TextBox Mgtxt;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.TextBox SizeTxt;
        private System.Windows.Forms.TextBox CodeTxt;
        private System.Windows.Forms.TextBox Typetxt;
    }
}

