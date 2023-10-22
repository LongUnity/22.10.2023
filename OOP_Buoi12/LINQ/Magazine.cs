using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Magazine:Document
    {
        public int ThangPH { get; set; }
        public int SoPH { get; set; }

        public Magazine() { }
        public Magazine(int matl, string tennhasx, int sobanph, int thangph, int soph)
        :base(matl, tennhasx, sobanph)
        { 
            ThangPH = thangph;
            SoPH = soph;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Tháng phát hành: ");
            ThangPH = int.Parse(Console.ReadLine());
            Console.Write("Số phát hành: ");
            SoPH = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine($"Mã tài liệu: {Matl} - Tên nhà sản xuất: {Tennhasx} - Số bản phát hành: {SoBanPH} - Tháng phát hành: {ThangPH} - Số phát hành: {SoPH}");
        }
    }
}
