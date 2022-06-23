using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Modelo.DTO
{
    public class Medidor
    {
        private int nroMedidor;
        private int tipoMedidor;
        private List<Lectura> lecturas = new List<Lectura>();

        public string TipoMdr
        {
            get
            {
                string tipoMdr = "";
                switch (tipoMedidor)
                {
                    case 1:
                        tipoMdr = "Digital";
                        break;
                    case 2:
                        tipoMdr = "Analogico";
                        break;
                }
                return tipoMdr;
            }
        }

        public int NroMedidor { get => nroMedidor; set => nroMedidor = value; }
        public int TipoMedidor { get => tipoMedidor; set => tipoMedidor = value; }
        public List<Lectura> Lecturas { get => lecturas; set => lecturas = value; }

        
    }
}
