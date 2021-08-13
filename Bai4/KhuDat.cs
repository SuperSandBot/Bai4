using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class KhuDat
    {
        private string DiaDiem;
        private int GiaBan;
        private float Dientich;
        public string diaDiem { get => DiaDiem; set => DiaDiem = value; }
        public int giaBan { get => GiaBan; set => GiaBan = value; }
        public float dientich { get => Dientich; set => Dientich = value; }

        public KhuDat()
        {

        }

        public KhuDat(string diaDiem, int giaBan, float dientich)
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            Dientich = dientich;
        }

        public virtual void Input()
        {
            Console.Write("Nhap Dia Diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap Gia Ban: ");
            GiaBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap Dien Tich: ");
            Dientich = float.Parse(Console.ReadLine());
        }

        public virtual string Tostring()
        {
            return "DiaDiem: " + DiaDiem + " ,GiaBan: " + GiaBan + " VND" + " ,DienTich: " + Dientich + " m2";
        }

    }
}
