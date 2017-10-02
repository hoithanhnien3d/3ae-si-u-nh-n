using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinhviens
{
    class Program
    {
        static void Main(string[] args)
        {
            sinhvien a = new sinhvien();
            a.xuat();
            sinhvien b = new sinhvien("1264132");
            b.xuat();
            sinhvien c = new sinhvien("1264132","Nguyen Truong An");
            c.xuat();
            sinhvien d = new sinhvien("1264132", "Nguyen Truong An",7,8);
            d.xuat();
            ngaysinh ngay =new ngaysinh(1990,2,3);
            sinhvien e = new sinhvien("1264132", "Nguyen Truong An", ngay);
            e.xuat();
            sinhvien f = new sinhvien("1264132", "Nguyen Truong An", ngay,7,8);
            f.xuat();
            sinhvien g = new sinhvien("1264132", "Nguyen Truong An",1990,2,3,7,8);
            g.xuat();
            sinhvien h = new sinhvien(d);
            h.xuat();
        }
    }
}
