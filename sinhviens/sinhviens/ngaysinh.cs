using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhviens
{
    class ngaysinh
    {
        private int ngay;
        private int thang;
        private int nam;

        public ngaysinh(int nam,int thang,int ngay)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }

        public void xuat()
        {
            Console.Write("{0}/{1}/{2}", ngay, thang, nam);
        }
    }
}
