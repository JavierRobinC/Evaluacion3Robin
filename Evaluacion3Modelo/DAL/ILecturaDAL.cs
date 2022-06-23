using Evaluacion3Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Modelo.DAL
{
    public interface ILecturaDAL
    {
        void AgregarLectura(Lectura lectura);
        List<Lectura> ObtenerLecturas();
    }
}
