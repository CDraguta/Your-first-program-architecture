using System;
using System.Collections.Generic;
using System.Text;

namespace Your_first_program_architecture
{
    public class Expressor
    {   public bool Cana { get; set; }
        public int NivelApa { get; set; } // la o bautura se consuma 30 
        public int NivelZahar { get; set; } // 5 niveluri , -20 la fiecare
        public int NivelLapte { get; set; } //maxim este la LatteMacciato -30
        public int NivelCafea { get; set; } //cafeaua este deja macinata ; -30 pentru cafeaua normala

        public Expressor() { }
        public Expressor(bool cana, int nivelApa, int nivelZahar, int nivelLapte, int nivelCafea)
        {
            Cana = cana;
            NivelApa = nivelApa;
            NivelZahar = nivelZahar;
            NivelLapte = nivelLapte;
            NivelCafea = nivelCafea;
        }

        public void AdaugaCana() {Cana = true; }
        public void ScoateCana() { Cana = false; }
        public void AdaugaApa()  { NivelApa = 100; }
        public void AdaugaZahar() { NivelZahar = 100; }
        public void AdaugaLapte() { NivelLapte = 100; }
        public void AdaugaCafea() { NivelCafea = 100; }

    }


    
}
