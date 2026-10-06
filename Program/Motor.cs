using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Motor : Jarmu
    {
        private int gumiAllapot;
        public int GumiAllapot
        {
            get => gumiAllapot;
            set => gumiAllapot = Math.Clamp(value, 0, 100)
        }
        public Motor(
             string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
             : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            GumiAllapot = 80;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine(
                $"{Rendszam}-{Kor} eves motor, " +
                $"{KilometerOra} km-rel gumi allapota: {GumiAllapot} %.");
        }
        public override void Szervizel(int dij)
        {
            base.Szervizel(dij);
            GumiAllapot += 20;
        }
    }
}