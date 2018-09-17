using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class QuanlySinhvien
    {
        private List<Sinhvien> sinhvien_list;
        private List<Khoahoc> khoahoc_list;
        public QuanlySinhvien()
        {

        }

        public void addSinhvien(Sinhvien sv)
        {
            sinhvien_list.Add(sv);

        }
    }
}
