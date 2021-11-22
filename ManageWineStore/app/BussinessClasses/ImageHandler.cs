using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.app.BussinessClasses
{
    class ImageHandler
    {
        public static byte[] imageToBytes(Image imageIn)
        {
            if (imageIn == null)
            {
                return null;
            }

            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            byte[] temp = ms.ToArray();
            ms.Close();
            return temp;
        }

        public static Image bytesToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }

            return Bitmap.FromStream(StreamFromBytes(byteArrayIn));
        }

        public static Stream StreamFromBytes(byte[] DataBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(DataBytes, 0, DataBytes.Length);
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }
    }
}
