using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem.Model
{
    class tblStudent
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string Address { set; get; }
        public string Email { set; get; }

        public int Type { set; get; }
        public string Password { set; get; }
        public byte[] Data { get; set; }
        public Image Img { get; set; }

        public byte[] convertImgToByte()
        {
            using (var ms = new MemoryStream())
            {
                this.Img.Save(ms, this.Img.RawFormat);
                Data = ms.ToArray();
                return Data;
            }
        }
        public void convertImgFromByte()
        {
            try
            {

                using (var ms = new MemoryStream(Data))
                {
                    Img = Image.FromStream(ms);
                    return;
                }
            }
            catch
            {
                return;
            }
        }
        public void chooseImg()
        {
            Img = null;
            Data = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Img = Image.FromFile(dialog.FileName);
                this.Data = this.convertImgToByte();
            }
        }

    }
}
