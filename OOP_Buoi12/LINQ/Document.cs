using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal abstract class Document
    {
        public int Matl { get; set; }
        public string Tennhasx { get; set; }
        public int SoBanPH { get; set; }

        public Document() { }
        public Document(int matl,string tennhasx,int sobanph) 
        { 
            this.Matl = matl;
            this.Tennhasx = tennhasx;
            this.SoBanPH = sobanph;
        }
         public virtual void nhap()
        {
            Console.Write("Mã tài liệu: ");
            Matl = int.Parse(Console.ReadLine());
            Console.Write("Tên nhà sản xuất: ");
            Tennhasx = Console.ReadLine();
            Console.Write("Số bản phát hành: ");
            SoBanPH = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()  
        {
            Console.WriteLine($"Mã tài liệu: {Matl} - Tên nhà sản xuất: {Tennhasx} - Số bản phát hành: {SoBanPH}");
        }
        public bool checkID(Document doc)
        {
            if (this.Matl == doc.Matl)
            {
                return false;
            }
            return true;
        }
    }
}
