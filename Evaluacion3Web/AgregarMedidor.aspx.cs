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
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            int nroMedidor = Convert.ToInt32(this.numeroTxt.Text.Trim());
            int tipoMedidor = Convert.ToInt32(this.tipoRb1.SelectedItem.Value);

            Medidor medidor = new Medidor()
            {
                NroMedidor = nroMedidor,
                TipoMedidor = tipoMedidor,
            };

            medidorDAL.AgregarMedidores(medidor);

            this.mensajeLb1.Text = "Se ha ingresado un Medidor";
            Response.Redirect("VerMedidor.aspx");
        }

    }
}