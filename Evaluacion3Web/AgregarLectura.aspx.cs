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
    public partial class AgregarLectura : System.Web.UI.Page
    {

        private IMedidorDAL medidorDAL = new MedidorDALObjeto();
        private ILecturaDAL lecturaDAL = new LecturaDALObjeto();
        private List<Medidor> medidores = new List<Medidor>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.medidorDd1.DataSource = medidores;
                this.medidorDd1.DataTextField = "nroMedidor";
                this.medidorDd1.DataValueField = "tipoMdr";
                this.medidorDd1.DataBind();

                this.medidores = medidores;
            }
        }

        protected void agregarBtn2_Click(object sender, EventArgs e)
        {
            string numeroMed = this.medidorDd1.SelectedValue.ToString();
            string fechaLec = this.Calendar1.SelectedDate.ToString();
            int horaLec = Convert.ToInt32(this.horaTxt.Text.Trim());
            int minutoLec = Convert.ToInt32(this.minutosTxt.Text.Trim());
            string valorConsumo = this.consumoTxt.Text.Trim();

            string lecturaValor = this.medidorDd1.SelectedValue;
            int lecturaTexto = Convert.ToInt32(this.medidorDd1.SelectedItem.Text);

            List<Lectura> lecturas = lecturaDAL.ObtenerLecturas();
            Medidor medidor = this.medidores.Find(b => b.NroMedidor == lecturaTexto);

            List<Medidor> medidores = this.medidores;
            Lectura lectura = new Lectura()
            {
                NumeroMed = numeroMed,
                FechaLec = fechaLec,
                HoraLec = horaLec,
                MinutoLec = minutoLec,
                ValorConsumo = valorConsumo,
            };
            lecturaDAL.AgregarLectura(lectura);
            this.mensajeLb1.Text = "Se ha ingresado una Lectura";
            Response.Redirect("VerLectura.aspx");
        }
    }
}