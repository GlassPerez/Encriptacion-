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

              //  medium.cargacombonivel(ddlnivel);
              //  medium.cargacombounidadperteencia(ddlunipert);
                medium.cargacombounidadperteencia(ddlunidad);

            }
        }

        protected void btnelimina_Click(object sender, EventArgs e)
        {           
            medium.eliminaaunidad(Txtiduni);            
        }

        protected void ddlunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            medium.muestraunidades(ddlunidad);

            medium.cargacombonivel(ddlnivel);
            medium.cargacombounidadperteencia(ddlunipert);

            Txtiduni.Text = medium.idunidadadministrativa;
            Txtnomuni.Text = medium.nombreunidadadministrativa;
            Txtteluni.Text = medium.telefonounidadadministrativa;
            Txtemailuni.Text = medium.emailunidadadministrativa;
            Txtdomiunni.Text = medium.domiciliounidadadministrativa;

            ddlnivel.SelectedValue = medium.idnivel;
            ddlunipert.SelectedValue = medium.idunidadpertenencia;           

        }

        protected void btnactualiza_Click(object sender, EventArgs e)
        {
            medium.idunidadadministrativa = Txtiduni.Text;
            medium.nombreunidadadministrativa = Txtnomuni.Text;
            medium.telefonounidadadministrativa = Txtteluni.Text;
            medium.emailunidadadministrativa = Txtemailuni.Text;
            medium.domiciliounidadadministrativa = Txtdomiunni.Text;
            medium.idunidadpertenencia = ddlunipert.SelectedValue;
            medium.idnivel = ddlnivel.SelectedValue;
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