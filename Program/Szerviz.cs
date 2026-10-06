using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private readonly List<Jarmu> jarmuvek = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine($"A {jarmu.Rendszam} jarmu megerkezett a szervizbe");
        }

        public void InformaciokListazasa()
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                jarmu.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {jarmu.Rendszam} szervizelese nem szukseges ");
                }
            }


        }
    }
}
