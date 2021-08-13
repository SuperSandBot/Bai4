using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class NhaPho : KhuDat
    {
        private int NamXayDung;
        private int SoTang;

        public int namXayDung { get => NamXayDung; set => NamXayDung = value; }
        public int soTang { get => SoTang; set => SoTang = value; }

        public NhaPho() : base()
        {

        }

        public NhaPho(string diaDiem, int giaBan, float dientich,int namXayDung, int soTang): base(diaDiem,giaBan,dientich)
        {
            NamXayDung = namXayDung;
            SoTang = soTang;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Nam Xay Dung: ");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Tang: ");
            SoTang = int.Parse(Console.ReadLine());
        }

        public override string Tostring()
        {
            return base.Tostring() + " ,NamXayDung: " + NamXayDung + " ,SoTang: " + SoTang;
        }
    }

}
