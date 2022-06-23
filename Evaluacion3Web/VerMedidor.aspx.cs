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
    public partial class VerMedidor : System.Web.UI.Page
    {

        private IMedidorDAL medidorDAL = new MedidorDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }

        private void cargaGrilla(List<Medidor> filtrada)
        {
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }

        protected void tipoDb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDb1.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.tipoDb1.SelectedItem.Value);
                List<Medidor> filtrada = medidorDAL.FiltrarMedidores(tipo);
                cargaGrilla(filtrada);
            }
        }

    }
}