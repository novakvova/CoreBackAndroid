using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAndroid.Helpers
{
    public static class ImageHelper
    {
        public static Bitmap FromBase64StringToImage(this string base64String)
        {
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            using (MemoryStream memoryStream = new MemoryStream(byteBuffer))
            {
                memoryStream.Position = 0;
                Image imgReturn;
                imgReturn = Image.FromStream(memoryStream);
                memoryStream.Close();
                byteBuffer = null;
                return new Bitmap(imgReturn);
            }
            return null;

        }
    }
}
