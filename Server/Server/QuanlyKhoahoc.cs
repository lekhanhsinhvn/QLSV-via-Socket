﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class QuanlyKhoahoc
    {
        private List<Sinhvien> sinhvien_list;
        private List<Khoahoc> khoahoc_list;
        public QuanlyKhoahoc()
        {

        }
        
        public void addKhoahoc(Khoahoc kh)
        {
            khoahoc_list.Add(kh);

        }
    }
}
