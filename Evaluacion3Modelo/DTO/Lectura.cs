using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Modelo.DTO
{
    public class Lectura
    {
        private string numeroMed;
        private string fechaLec;
        private int horaLec;
        private int minutoLec;
        private string valorConsumo;

        public string NumeroMed { get => numeroMed; set => numeroMed = value; }
        public string FechaLec { get => fechaLec; set => fechaLec = value; }
        public int HoraLec { get => horaLec; set => horaLec = value; }
        public int MinutoLec { get => minutoLec; set => minutoLec = value; }
        public string ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
    }
}
