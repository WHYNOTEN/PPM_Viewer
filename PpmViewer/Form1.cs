using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpmViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            viewBtn.Enabled = false;
            导出文件ToolStripMenuItem.Enabled = false;
        }
        PPmInfo ppm;
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\QQ下载文件\PPM图片查看器\test1.ppm";
            ppm = new PPmInfo(path);
            ppm.GetInfos();
            pictureBox1.Image = ppm.Bmp;
            Mgtxt.Text = ppm.HeadInfo;
            SizeTxt.Text = ppm.Size[0].ToString() +"*"+ ppm.Size[1].ToString();
            Typetxt.Text = ppm.Type;
            CodeTxt.Text = ppm.Encoding;
        }
        private string path;
        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ppm文件|*.ppm";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                viewBtn.Enabled = true;
            }
            导出文件ToolStripMenuItem.Enabled = true;
        }

        private void 导出文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "请选择文件路径";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string foldPath = fbd.SelectedPath;
                ppm.Pic_Save(foldPath);
                MessageBox.Show("文件已保存至" + foldPath);
            }
        }
    }
}
