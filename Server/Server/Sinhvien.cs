using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Sinhvien
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
        public string password
        {
            get;
            set;
        }
        public string gioi_tinh
        {
            get;
            set;
        }
        public int sdt
        {
            get;
            set;
        }
        public string diachi
        {
            get;
            set;
        }
        public DateTime ngay_sinh
        {
            get;
            set;
        }
        public List<Khoahoc> dang_hoc
        {
            get;
            set;
        }
        public List<Khoahoc> dang_ki
        {
            get;
            set;
        }
        public List<Khoahoc> da_hoc
        {
            get;
            set;
        }

        public Sinhvien(string ten, string password, string gioi_tinh, int sdt, string diachi, DateTime ngay_sinh)
        {
            this.ten = ten;
            this.password = password;
            this.gioi_tinh = gioi_tinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.ngay_sinh = ngay_sinh;
        }
        public Sinhvien(int id, string ten, string password, string gioi_tinh, int sdt, string diachi, DateTime ngay_sinh, List<Khoahoc> dang_hoc, List<Khoahoc> dang_ki, List<Khoahoc> da_hoc)
        {
            this.id = id;
            this.ten = ten;
            this.password = password;
            this.gioi_tinh = gioi_tinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.ngay_sinh = ngay_sinh;
            this.dang_hoc = dang_hoc;
            this.dang_ki = dang_ki;
            this.da_hoc = da_hoc;
        }
    }
}
