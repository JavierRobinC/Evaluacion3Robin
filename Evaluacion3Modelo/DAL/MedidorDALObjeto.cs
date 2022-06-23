using Evaluacion3Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Modelo.DAL
{
    public class MedidorDALObjeto : IMedidorDAL
    {

        private static List<Medidor> medidores = new List<Medidor>();

        public void AgregarMedidores(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> FiltrarMedidores(int tipoMedidor)
        {
            return medidores.FindAll(c => c.TipoMedidor == tipoMedidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
