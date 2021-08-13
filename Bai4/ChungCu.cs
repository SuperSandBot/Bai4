using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class ChungCu : KhuDat
    {
        private int Tang;

        public int soTang { get => Tang; set => Tang = value; }

        public ChungCu() : base()
        {

        }

        public ChungCu(string diaDiem, int giaBan, float dientich,int tang) : base(diaDiem, giaBan, dientich)
        {
            Tang = tang;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Tang: ");
            Tang = int.Parse(Console.ReadLine());

        }

        public override string Tostring()
        {
            return base.Tostring() + " ,Tang: " + Tang;
        }
    }
}
