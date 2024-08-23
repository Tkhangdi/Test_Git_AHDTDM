using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NoiDungThucHanh_Bai1_Bai2_
{
    public class DSThiSinh
    {
        List<ThiSinh> lts = new List<ThiSinh>();
        public List<ThiSinh> Lst 
        {
            get { return lts; }
            set { lts = value; }
        }

        public void docfile(string filename) 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            XmlNodeList nodelist = doc.SelectNodes("/DSThiSinh/ThiSinh");
            foreach(XmlNode node in nodelist) 
            {
                ThiSinh ts = new ThiSinh();
                ts.Mathisinh = node["MaTS"].InnerText;
                ts.Tenthisinh = node["HoTen"].InnerText;
                ts.Gioitinh = node["GTinh"].InnerText;
                ts.Diemlythuyet = float.Parse(node["DLyThuyet"].InnerText);
                ts.Diemthuchanh = float.Parse(node["DThucHanh"].InnerText);
                Lst.Add(ts);
            }
        }

        public void xuat() 
        {
            Console.WriteLine("Danh sach Thi Sinh:");
            foreach (ThiSinh ts in lts) 
            {
                ts.InThongTin();
            }
        }

        public void thisinhdatketquaDau() 
        {
            Lst = Lst.Where(t=> t.XetTuyen() == "Dau").ToList();
        }

        public int tongsothisinhDau() 
        {
             return Lst.Count(t => t.XetTuyen() == "Dau");
        }

        public int tongsothisinhRot()
        {
            return Lst.Count(t => t.XetTuyen() == "Rot");
        }

        public void ThongtinThiSinhtheoMaThiSinh(string mathisinh) 
        {

            Console.WriteLine("Thong tin thi sinh co Ma {0} :", mathisinh);
            List<ThiSinh> lts1 = new List<ThiSinh>();
            foreach(ThiSinh ts in Lst) 
            {
                if(ts.Mathisinh == mathisinh) 
                {
                    lts1.Add(ts);
                }
            }
            if (lts1.Count > 0)
            {
                foreach(ThiSinh ts in lts1) 
                {
                    ts.InThongTin();
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin");
            }

        }

        public void sapxepDSGiamdantheoDiemTK() 
        {
            Lst  = Lst.OrderByDescending(t => t.tinhDiemTongKet()).ToList();
        }

    }
}
