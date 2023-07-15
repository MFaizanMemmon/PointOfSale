using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CosmaticProject.Source_Code
{
    public static class Common
    {
        public static byte[] ConvertImageForInsert(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }

        public static Image RetriveImage(byte[] imgPath)
        {
            MemoryStream ms = new MemoryStream(imgPath);
            return Image.FromStream(ms);

        }
    }
}
