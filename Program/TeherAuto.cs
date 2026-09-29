using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;

        public int Rakomany
        {
            get => rakomany;
            set => rakomany = Math.Clamp(value, 0, 20);
        }

        public TeherAuto(
            string rendszam, int kor, int kilometerOra,int uzemanyagSzint, int rakomany)
            : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rakomany = rakomany;
        }


        public override void InformaciotAd()
        {
            Console.WriteLine(
                $"{Rendszam}-{Kor} eves teherauto" +
                $"{KilometerOra} km-rel {Rakomany} tonna");
        }

        public override void Szervizel(int dij)
        {
            Rakomany = 0;
            base.Szervizel(dij);
        }
    }
}
