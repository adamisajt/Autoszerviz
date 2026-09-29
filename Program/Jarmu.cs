using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam = "ISMERETLEN";
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;


        public string Rendszam
        {
            get => rendszam;
            set => rendszam = string.IsNullOrEmpty(value) ? "ISMERETLEN" : value;
        }
        public int Kor
        {
            get => kor;
            set => kor = Math.Clamp(value, 0, 50);
        }

        public int KilometerOra
        {
            get => kilometerOra;
            set => kilometerOra = Math.Max(0, value);
        }

        public int UzemanyagSzint
        {
            get => uzemanyagSzint;
            set => uzemanyagSzint = Math.Clamp(value, 0, 100);
        }

        public bool SzervizSzukseges => KilometerOra >= 200000;



        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam}-{Kor} eves kocsi, {KilometerOra} km-rel");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            UzemanyagSzint -= 10;
            Console.WriteLine($"a {Rendszam} jarmu szervizelese megtortent");
        }

    }
}
