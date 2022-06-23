using Evaluacion3Modelo.DAL;
using Evaluacion3Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3Web
{
    public partial class VerLectura : System.Web.UI.Page
    {

        private ILecturaDAL lecturaDAL = new LecturaDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Lectura> lecturas = this.lecturaDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }
        private void cargaGrilla(List<Lectura> filtrada)
        {
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }
    }
}