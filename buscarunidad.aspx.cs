using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ctrlArchivos.Modelo;

namespace ctrlArchivos.vista
{
    public partial class buscarunidad : System.Web.UI.Page
    {

        Workmedium medium = new Workmedium();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["medio"] = medium;
                medium.cargaunidad(ddlunidad);
            }
        }

        protected void btnelimina_Click(object sender, EventArgs e)
        {
            medium = (Workmedium)Session["medio"];
            medium.eliminaaunidad(Txtiduni);
            Session["medio"] = medium;
        }

        protected void ddlunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            medium = (Workmedium)Session["medio"];

            Txtiduni.Text = "";
            Txtnomuni.Text = "";
            Txtteluni.Text = "";
            Txtemailuni.Text = "";
            Txtdomiunni.Text = "";

            medium.muestraunidades(ddlunidad);
            medium.cargacombonivel(ddlnivel);
            medium.cargacombounidadperteencia(ddlunipert);

            Txtiduni.Text = medium.idunidadadministrativa;
            Txtnomuni.Text = medium.nombreunidadadministrativa;
            Txtteluni.Text = medium.telefonounidadadministrativa;
            Txtemailuni.Text = medium.emailunidadadministrativa;
            Txtdomiunni.Text = medium.domiciliounidadadministrativa;

            ddlnivel.Text = medium.idnivel;
            ddlunipert.Text = medium.idunidadpertenencia;


            Session["medio"] = medium;

        }

        protected void btnactualiza_Click(object sender, EventArgs e)
        {
            medium.idunidadadministrativa = Txtiduni.Text;
            medium.nombreunidadadministrativa = Txtnomuni.Text;
            medium.telefonounidadadministrativa = Txtteluni.Text;
            medium.emailunidadadministrativa = Txtemailuni.Text;
            medium.domiciliounidadadministrativa = Txtdomiunni.Text;
            medium.idunidadpertenencia = ddlunipert.Text;
            medium.idnivel = ddlnivel.Text;

            medium.actualizaunidad();
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("buscarunidad.aspx");
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("buscarunidad.aspx");
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("buscarunidad.aspx");
        }
    }
}