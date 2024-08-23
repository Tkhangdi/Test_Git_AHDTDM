using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace NoiDungThucHanh_Bai1_Bai2_

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSThiSinh ds = new DSThiSinh();
            ds.docfile("../../../dsThiSinh.xml");
            ds.xuat();

            Console.WriteLine();
            DSThiSinh ds1 = new DSThiSinh();
            Console.WriteLine("Danh sach thi sinh dat ket qua Dau:");
            ds1.docfile("../../../dsThiSinh.xml");
            ds1.thisinhdatketquaDau();
            ds1.xuat();

            Console.WriteLine();
            Console.WriteLine("Tong so thi sinh Dau: {0}", ds.tongsothisinhDau());
            Console.WriteLine("Tong so thi sinh Rot: {0}", ds.tongsothisinhRot());

            Console.WriteLine();
            //string mts;
            //Console.Write("Nhap ma thi sinh can tim: ");
            //mts = Console.ReadLine();
            ds.ThongtinThiSinhtheoMaThiSinh("004");

            Console.WriteLine();
            Console.WriteLine("Danh sach sap xep thi sinh Giam dan theo Diem tong ket:");
            ds.sapxepDSGiamdantheoDiemTK();
            ds.xuat();

            Console.ReadLine();
        }
    }
}
