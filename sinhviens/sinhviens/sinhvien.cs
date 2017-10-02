using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhviens
{
    class sinhvien
    {
        private string mssv;
        private string hoten;
        private ngaysinh t;
        private int dlt;
        private int dth;
        private int ngay;
        private int thang;
        private int nam;

        public sinhvien()
        {
            mssv = "";
            hoten = "";
            t = new ngaysinh(1990,1,1);
            dlt = 10;
            dth = 10;
        }
        public sinhvien(string mssv)
        {
            this.mssv = mssv;
            hoten = "";
            t = new ngaysinh(1990,1,1);
            dlt = 10;
            dth = 10;
        }
        public sinhvien(string mssv,string hoten)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            t = new ngaysinh(1990,1,1);
            dlt = 10;
            dth = 10;
        }
        public sinhvien(string mssv, string hoten,int dlt,int dth)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            t = new ngaysinh(1990,1,1);
            this.dlt = dlt;
            this.dth = dth;
        }
        public sinhvien(string mssv, string hoten,ngaysinh t)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.t = t;
            dlt = 10;
            dth = 10;
        }
        public sinhvien(string mssv, string hoten,ngaysinh t, int dlt, int dth)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.t = t;
            this.dlt = dlt;
            this.dth = dth;
        }
        public sinhvien(string mssv, string hoten,int nam,int thang,int ngay, int dlt, int dth)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
            t = new ngaysinh(nam, thang, ngay);
            this.dlt = dlt;
            this.dth = dth;
        }
        public sinhvien(sinhvien sv)
        {
            mssv = sv.mssv;
            hoten = sv.hoten;
            t = sv.t;
            dlt = sv.dlt;
            dth = sv.dth;
        }
        public void xuat()
        {
            Console.Write("mssv: {0}", mssv);
            Console.Write("           ho ten:{0} ", hoten);
            Console.Write("           ngay sinh  ");
            t.xuat();
            Console.Write("       dlt: {0}", dlt);
            Console.WriteLine("       dth: {0}", dth);
            Console.ReadKey();
        }
    }
}
