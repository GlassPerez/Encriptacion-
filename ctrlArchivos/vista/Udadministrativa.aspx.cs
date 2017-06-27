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
            if (!IsPostBack)
            {
                medium.cargacombonivel(ddlnomnivel);
                medium.cargacombounidadperteencia(ddlunipert);

                string con = "Select * From unidad_admva";
                string al = "unidad_admva";
                medium.selectexpediente(GridView1, con, al);
                lblidnivel.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void ddlniveluadm_SelectedIndexChanged(object sender, EventArgs e)
        {          
         
        }

        protected void ddlnomnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(ddlnomnivel.SelectedValue);
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            medium.idunidadadministrativa = Txtiduni.Text;
            medium.nombreunidadadministrativa = Txtnomuni.Text;
            medium.telefonounidadadministrativa = Txtteluni.Text;
            medium.emailunidadadministrativa = Txtemailuni.Text;
            medium.domiciliounidadadministrativa = Txtdomiunni.Text;
            medium.idunidadpertenencia = ddlunipert.SelectedValue;
            medium.idnivel = ddlnomnivel.SelectedValue;

            
           

            medium.agregarunidad();

        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("buscarunidad.aspx");

        }

        protected void ddlunipert_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(ddlunipert.SelectedValue);
        }

        public void mensa()
        {
            System.Windows.Forms.MessageBox.Show("hola");
        }




        protected void Txtnomuni_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("hola");

        }
    }
}