using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LibraryManagement
    {
        Document doc { get; set; }
        public List<Document> ds { get; set; }
        public LibraryManagement()
        {
            ds = new List<Document>();
        }
        public void addDocuments()
        {
            Console.Write("Số tài liệu muốn thêm: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("1.Book");
                Console.WriteLine("2.Magazine");
                Console.WriteLine("3.Newpapers");
                Console.WriteLine("0.Thoát");
                Console.Write("Chọn loại tài liệu muốn thêm: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        doc = new Book();
                        doc.nhap();
                        ds.Add(doc);
                        break;
                    case 2:
                        doc = new Magazine();
                        doc.nhap();
                        ds.Add(doc);
                        break;
                    case 3:
                        doc = new Newpapers();
                        doc.nhap();
                        ds.Add(doc);
                        break;
                    case 0:
                        break;
                }

                if (i >= 1 && doc.checkID(ds[i]) == false)
                {
                    Console.WriteLine("Đã tồn tại mã tài liệu này");
                    ds.RemoveAt(i);
                }
            }
        }
        public void printDocuments()
        {
            /*foreach (var item in ds)
            {
                item.xuat();
            }*/
            //Lamda expression
            ds.ForEach(item => item.xuat());
        }
        public void showDoc()
        {

            /*foreach (var doc in ds)
            {
                if (doc is Book)
                {
                    doc.xuat();
                }
            }*/
            ds.ForEach(item => { 
                if (item is Book) 
                { 
                    item.xuat(); 
                } 
            });
        }
        
    }
}
