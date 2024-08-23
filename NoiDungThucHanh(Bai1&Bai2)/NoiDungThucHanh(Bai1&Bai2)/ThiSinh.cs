using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiDungThucHanh_Bai1_Bai2_
{
    public class ThiSinh
    {
        string mathisinh;
        string tenthisinh;
        string gioitinh;
        float diemlythuyet;
        float diemthuchanh;
        public string Mathisinh
        {
            get { return mathisinh; }
            set { mathisinh = value; }
        }
        public string Tenthisinh
        {
            get { return tenthisinh; }
            set { tenthisinh = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public float Diemlythuyet
        {
            get { return diemlythuyet; }
            set { diemlythuyet = value; }
        }
        public float Diemthuchanh
        {
            get { return diemthuchanh; }
            set { diemthuchanh = value; }
        }

        public ThiSinh() 
        {
            Mathisinh = "0";
            Tenthisinh = "NULL";
            Gioitinh = "NULL";
            Diemlythuyet = 1.0f;
            Diemthuchanh = 5.0f;
        }
        public ThiSinh(string mts,string tts,string gt,float dlt,float dth)
        {
            Mathisinh = mts;
            Tenthisinh = tts;
            Gioitinh = gt;
            Diemlythuyet = dlt;
            Diemthuchanh = dth;
        }
        public ThiSinh(ThiSinh a)
        {
            Mathisinh = a.Mathisinh;
            Tenthisinh = a.Tenthisinh;
            Gioitinh = a.Gioitinh;
            Diemlythuyet = a.Diemlythuyet;
            Diemthuchanh = a.Diemthuchanh;
        }

        public double tinhDiemTongKet ()
        {
            return (diemlythuyet + diemthuchanh) / 2;
        }

        public string XetTuyen() 
        {
            if(tinhDiemTongKet()>=5 && diemthuchanh>=5 && diemlythuyet >= 5) 
            {
                return "Dau";
            }
            else
            {
                return "Rot";
            }
        }
        public void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin thi sinh:");
            Console.Write("Nhap ma thi sinh: ");
            Mathisinh = Console.ReadLine();
            Console.Write("Nhap ten thi sinh: ");
            Tenthisinh = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            Gioitinh = Console.ReadLine();
            Console.Write("Nhap diem ly thuyet: ");
            Diemlythuyet = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            Diemthuchanh = float.Parse(Console.ReadLine());
        }
        public void InThongTin()
        {
            Console.WriteLine("{0,-20}{1,-23}{2,-12}{3,-20}{4,-20}{5,-20:f2}{6,-20}", "Ma thi sinh", "Ho Ten thi sinh", "Gioi tinh", "Diem ly thuyet", "Diem thuc hanh", "Diem Tong Ket","Ket qua xet tuyen");
            Console.WriteLine("{0,-20}{1,-23}{2,-12}{3,-20}{4,-20}{5,-20:f2}{6,-20}", Mathisinh, Tenthisinh, Gioitinh, Diemlythuyet, Diemthuchanh, tinhDiemTongKet(),XetTuyen());
        }
    }
}
