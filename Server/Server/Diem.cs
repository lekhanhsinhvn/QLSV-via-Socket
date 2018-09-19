using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Diem
    {
        public int id;
        public int idsinhvien
        {
            get;
            set;
        }
        public int idkhoahoc
        {
            get;
            set;
        }
        public float chuyen_can
        {
            get;
            set;
        }
        public float giua_ki
        {
            get;
            set;
        }
        public float cuoi_ki
        {
            get;
            set;
        }
        public float trung_binh
        {
            get;
            set;
        }
        public Diem(int id, int idsinhvien, int idkhoahoc, float chuyen_can, float giua_ki, float cuoi_ki, float trung_binh)
        {
            this.id = id;
            this.idsinhvien = idsinhvien;
            this.idkhoahoc = idkhoahoc;
            this.chuyen_can = chuyen_can;
            this.giua_ki = giua_ki;
            this.cuoi_ki = cuoi_ki;
            this.trung_binh = trung_binh;
        }
    }
}
