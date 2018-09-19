using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Khoahoc
    {
        public int id
        {
            get;
            set;
        }

        public string ten
        {
            get;
            set;
        }
        public List<Sinhvien> danh_sach
        {
            get;
            set;
        }
        public string trang_thai
        {
            get;
            set;
        }
        public int max_danhsach
        {
            get;
            set;
        }
        public DateTime batdau_dangky
        {
            get;
            set;
        }
        public DateTime batdau_hoc
        {
            get;
            set;
        }
        public Khoahoc(int id, string ten, List<Sinhvien> danh_sach, int max_danhsach, DateTime batdau_dangky, DateTime batdau_hoc)
        {
            this.id = id;
            this.ten = ten;
            this.danh_sach = danh_sach;
            this.max_danhsach = max_danhsach;
            this.batdau_dangky = batdau_dangky;
            this.batdau_hoc = batdau_hoc;
            trang_thai = "Dang ky";
        }
    }
}
