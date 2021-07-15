using System;
using System.Collections.Generic;
using System.Text;

namespace Your_first_program_architecture
{
    public class Bautura : Expressor
    {
        public int NivelCafeaBautura { get; set; }
        public int NivelLapteBautura { get; set; }

        public Bautura(int nivelCafeaBautura, int nivelLapteBautura)
        {
            this.NivelCafeaBautura = nivelCafeaBautura;
            this.NivelLapteBautura = nivelLapteBautura;
        }
    }
}
