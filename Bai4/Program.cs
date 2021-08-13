using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static QLDat ql = new QLDat();

        static void Main(string[] args)
        {
            

            int chon = 0;
            int chon1;
            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1.Tao DS.");
                Console.WriteLine("2.Xuat DS");
                Console.WriteLine("3.Xuat Tong Gia Ban Cua Cong Ty");
                Console.WriteLine("4.Xuat Khu Dat Co Dien Tich > 100m2 or Xuat Nha Pho Dien Tich > va Nam Xay Dung >= 2020");
                Console.WriteLine("5.Tim Kiem Danh Sach");
                Console.WriteLine("0.Exit.");
                Console.Write("Chon: ");
                Console.WriteLine("----------------------------\n");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ChonNhap();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        ql.XuatTongGiaBanCuaCongTy();
                        break;
                    case 4:
                        do
                        {                        
                            Console.WriteLine("Xuat Khu Dat Co Dien Tich > 100m2 or Xuat Nha Pho Dien Tich > va Nam Xay Dung >= 2020:");
                            Console.WriteLine("1.Xuat Khu Dat Co Dien Tich > 100m2.");
                            Console.WriteLine("2.Xuat Nha Pho Dien Tich > 60m2 va Nam Xay Dung >= 2020");
                            Console.WriteLine("0.Exit.");
                            Console.Write("Chon: ");
                            chon1 = int.Parse(Console.ReadLine());
                            switch (chon1)
                            {
                                case 1:
                                    ql.XuatKhuDatCoDienTichLonHon100m2();
                                    break;
                                case 2:
                                    ql.XuatNhaPhoDienTichLonHon60vaNamXayDungLonHonBang2020();
                                    break;
                                default:
                                    chon1 = 0;
                                    break;
                            }
                        } while (chon1 != 0);
                        break;
                    case 5:
                        Console.Write("Nhap Dia Diem: ");
                        string diadiem = Console.ReadLine();
                        Console.Write("Nhap Gia Ban: ");
                        int giaban = int.Parse(Console.ReadLine());
                        Console.Write("Nhap Dien Tich: ");
                        float dientich = float.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Xuat Khu Dat or Chung Cu:");
                            Console.WriteLine("1.Nha Nho.");
                            Console.WriteLine("2.Chung Cu");
                            Console.WriteLine("0.Exit.");
                            Console.Write("Chon: ");
                            chon1 = int.Parse(Console.ReadLine());
                            switch (chon1)
                            {
                                case 1:
                                    ql.TimKiem(diadiem, giaban, dientich, 1);
                                    break;
                                case 2:
                                    ql.TimKiem(diadiem, giaban, dientich, 2);
                                    break;
                                default:
                                    chon1 = 0;
                                    break;
                            }
                        } while (chon1 != 0);
                        break;

                    default:
                        chon= 0;
                        break;
                }
            } while (chon != 0);
        }

        static void ChonNhap()
        {
            Console.Write("Nhap So Khu Dat: ");
            int n = int.Parse(Console.ReadLine());
            int chon = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Chon loai Dat muon tao:");
                Console.WriteLine("1.Khu Dat.");
                Console.WriteLine("2.Chung Cu");
                Console.WriteLine("3.Nha Pho");
                Console.WriteLine("0.Exit.");
                Console.Write("Chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapKhuDat();
                        break;
                    case 2:
                        ql.NHapChungCu();
                        break;
                    case 3:
                        ql.NhapNhaPho();
                        break;
                    default:
                        chon = 0;
                        i--;
                        break;
                }
            }
        }
    }
}
