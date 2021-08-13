using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class QLDat
    {
        public List<KhuDat> KD = new List<KhuDat>();

        public void NhapKhuDat()
        {
               KhuDat kd = new KhuDat();

               kd.Input();

               KD.Add(kd);
        }

        public void NHapChungCu()
        {
            KhuDat kd = new ChungCu();

            kd.Input();

            KD.Add(kd);
        }

        public void NhapNhaPho()
        {
            KhuDat kd = new NhaPho();

            kd.Input();

            KD.Add(kd);
        }
        public List<KhuDat> ListKhuDat()
        {
            List<KhuDat> list = new List<KhuDat>();

            foreach(KhuDat kd in KD)
            {
                if (kd is NhaPho)
                {
                    continue;
                }
                if (kd is ChungCu)
                {
                    continue;
                }
                list.Add((KhuDat)kd);
            }
            return list;
        }

        public List<ChungCu> ListChungCu()
        {
            List<ChungCu> list = new List<ChungCu>();

            foreach (KhuDat kd in KD)
            {
                if (kd is ChungCu)
                {
                    list.Add((ChungCu)kd);
                }
            }
            return list;
        }

        public List<NhaPho> ListNhaPho()
        {
            List<NhaPho> list = new List<NhaPho>();

            foreach (KhuDat kd in KD)
            {
                if (kd is NhaPho)
                {
                    list.Add((NhaPho)kd);
                }
            }
            return list;
        }

        public void XuatDS()
        {
            int i = 1;
            foreach (KhuDat kd in KD)
            {
                Console.WriteLine(i + "." + kd.Tostring());
                i++;
            }
        }

        public void XuatDSKhuPho(List<KhuDat> list)
        {
            int i = 1;
            foreach (KhuDat kb in list)
            {
                Console.WriteLine(i + "." + kb.Tostring());
                i++;
            }
        }

        public void XuatDSNhaPho(List<NhaPho> list)
        {
            int i = 1;
            foreach (NhaPho np in list)
            {
                Console.WriteLine(i + "." + np.Tostring());
                i++;
            }
        }

        public void XuatDSChungCu(List<ChungCu> list)
        {
            int i = 1;
            foreach (ChungCu np in list)
            {
                Console.WriteLine(i + "." + np.Tostring());
                i++;
            }
        }

        public void XuatDS(List<ChungCu> list)
        {
            int i = 1;
            foreach (ChungCu cc in list)
            {
                Console.WriteLine(i + "." + cc.Tostring());
                i++;
            }
        }

        public void XuatTongGiaBanCuaCongTy()
        {
            int tong = 0;

            Console.WriteLine("KhuDat:");
            tong = ListKhuDat().Sum(p => p.giaBan);
            Console.WriteLine("TongGia = " + tong);

            Console.WriteLine("ChungCu:");
            tong = ListChungCu().Sum(p => p.giaBan);
            Console.WriteLine("TongGia = " + tong);

            Console.WriteLine("NhaPho:");
            tong = ListNhaPho().Sum(p => p.giaBan);
            Console.WriteLine("TongGia = " + tong);
        }

        public void XuatKhuDatCoDienTichLonHon100m2()
        {
            List<KhuDat> list = ListKhuDat().Where(p => p.dientich > 100).ToList();

            XuatDSKhuPho(list);
        }

        public void XuatNhaPhoDienTichLonHon60vaNamXayDungLonHonBang2020()
        {
            List<NhaPho> list = ListNhaPho().Where(p => p.dientich > 60  && p.namXayDung >= 2020).ToList();

            XuatDSNhaPho(list);
        }

        public void TimKiem(string diaDiem, int giaBan, float dientich , byte Yeucau)
        {
            switch(Yeucau)
            {
                case 1:
                    List<NhaPho> list = ListNhaPho().Where(p => p.diaDiem.ToLower().StartsWith(diaDiem.ToLower()) && p.giaBan <= giaBan && p.dientich >= dientich).ToList();

                    XuatDSNhaPho(list);
                    break;
                case 2:
                    List<ChungCu> List = ListChungCu().Where(p => p.diaDiem.ToLower().StartsWith(diaDiem.ToLower()) && p.giaBan <= giaBan && p.dientich >= dientich).ToList();

                    XuatDSChungCu(List);
                    break;
                default:
                    break;
            }
        }

    }
}
