using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ctrlArchivos.Modelo;

namespace ctrlArchivos.vista
{
    public partial class Udadministrativa : System.Web.UI.Page
    {

        Workmedium medium = new Workmedium();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            medium.cargacombonivel(ddlnomnivel);

            medium.cargacombounidadperteencia(ddlunipert);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void ddlniveluadm_SelectedIndexChanged(object sender, EventArgs e)
        {          
         
        }

        protected void ddlnomnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            medium.obtennobrenivel(lblidnivel, ddlnomnivel);
            System.Windows.Forms.MessageBox.Show("nn");       
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            medium.idunidadadministrativa = Txtiduni.Text;
            medium.nombreunidadadministrativa = Txtnomuni.Text;
            medium.telefonounidadadministrativa = Txtteluni.Text;
            medium.emailunidadadministrativa = Txtemailuni.Text;
            medium.domiciliounidadadministrativa = Txtdomiunni.Text;
            medium.idunidadpertenencia = ddlunipert.Text;
            medium.idnivel = ddlnomnivel.Text;
            
            medium.agregarunidad();

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("buscarunidad.aspx");
        }
    }
}