using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Book: Document
    {
        public string Tentacgia { get; set; }
        public int Sotrang { get; set; }

        public Book():base() { }

        public Book(int matl,string tennhasx, int sobanph , string tentacgia, int sotrang)
            :base(matl,tennhasx, sobanph)
            {
                Tennhasx = tentacgia;
                Sotrang = sotrang;
            }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Tên tác giả: ");
            Tentacgia = Console.ReadLine();
            Console.Write("Số trang: ");
            Sotrang = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {            
            Console.WriteLine($"Mã tài liệu: {Matl} - Tên nhà sản xuất: {Tennhasx} - Số bản phát hành: {SoBanPH} - Tên tác giả: {Tentacgia} - Số trang: {Sotrang}");
        }

    }
}
