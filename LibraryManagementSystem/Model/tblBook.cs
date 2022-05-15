using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class tblBook
    {
        public string MaSach { set; get; }
        public Decimal GiaDenBu { set; get; }
        public string TacGia { set; get; }

        public string TheLoai { set; get; }
        public string TieuDe { set; get; }
        public DateTime NgayTra { set; get; }
        public DateTime NgayMuon { set; get; }
    }
}
