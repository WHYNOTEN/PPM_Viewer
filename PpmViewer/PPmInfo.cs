using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PpmViewer
{
    class PPmInfo
    {
        private Dictionary<string, string> Modes = new Dictionary<string, string>();
        private string _path;
        private string _filename;
        private string _headInfo;
        private string _Encoding;
        private string _Type;
        private int[] _size= new Int32[2];
        private Bitmap _bmp;
        public string Path { get => _path; set => _path = value; }
        public string HeadInfo { get => _headInfo; set => _headInfo = value; }
        public int[] Size { get => _size; set => _size = value; }
        public Bitmap Bmp { get => _bmp; set => _bmp = value; }
        public string Filename { get => _filename; set => _filename = value; }
        public string Encoding { get => _Encoding; set => _Encoding = value; }
        public string Type { get => _Type; set => _Type = value; }

        public PPmInfo()
        {

        }
        public PPmInfo(string path)
        {
            this._path = path;
            this.Init_Dic();
        }
        public void GetInfos()
        {
            //将文件读入流
            StreamReader sr = new StreamReader(this.Path);
            string ppm_content = sr.ReadToEnd();
            //关闭文件流
            sr.Close();
            //获取文件名
            MatchCollection match = Regex.Matches(this.Path, "([^/\\\\]+).ppm");
            this.Filename = match[0].Value;
            //获取PPM文件magic number
            this.HeadInfo = ppm_content.Substring(0, 2);
            this.Encoding = this.Modes[this.HeadInfo].Split(' ')[1];
            this.Type = this.Modes[this.HeadInfo].Split(' ')[0];
            //获取图像大小
            string bmp_info = ppm_content.Substring(4, 7);
            this.Size[0] = int.Parse(bmp_info.Split(' ')[1]);
            this.Size[1] = int.Parse(bmp_info.Split(' ')[0]);
            this.Bmp = new Bitmap(this.Size[1],this.Size[0]);
            //获取图像的所有RGB元素值
            string[] a = ppm_content.Substring(18).Split(' ');
            List<Color> colors = ToColor(a);
            //colors索引变量
            int flag = 0;
            //将图像Color值填充
            for (int x = 0; x < this.Bmp.Height; x++)
            {
                for (int y = 0; y < this.Bmp.Width; y++)
                {
                    this.Bmp.SetPixel(y, x, colors[flag]);
                    flag++;
                }
            }
        }
        public void Pic_Save(string path)
        {
            this.Bmp.Save(path+@"\" + this.Filename.Split('.')[0]+".png");
        }
        private List<Color> ToColor(string[] pixels)
        {
            //将RGB元素值装配为Color
            List<Color> colors = new List<Color>();
            for (int i = 0; i < pixels.Length - 1; i += 3)
            {
                colors.Add(Color.FromArgb(int.Parse(pixels[i]), int.Parse(pixels[i + 1]), int.Parse(pixels[i + 2])));
            }
            return colors;
        }
        private void Init_Dic()
        {
            this.Modes.Add("P1", "Bitmap ASCII");
            this.Modes.Add("P2", "Graymap ASCII");
            this.Modes.Add("P3", "Pixmap ASCII");
            this.Modes.Add("P4", "Bitmap Binary");
            this.Modes.Add("P5", "Graymap Binary");
            this.Modes.Add("P6", "Pixmap Binary");
        }
    }
}
