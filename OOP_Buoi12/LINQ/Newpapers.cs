using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Newpapers:Document
    {
        public int NgayPH { get; set; }

        public Newpapers() { }
        public Newpapers(int matl, string tennhasx, int sobanph, int ngayph)
        : base(matl, tennhasx, sobanph)
        {
            NgayPH = ngayph;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Ngày phát hành: ");
            NgayPH = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine($"Mã tài liệu: {Matl} - Tên nhà sản xuất: {Tennhasx} - Số bản phát hành: {SoBanPH} - Ngày phát hành: {NgayPH}");
        }
    }
}
