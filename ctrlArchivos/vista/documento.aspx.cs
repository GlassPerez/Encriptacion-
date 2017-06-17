using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ctrlArchivos.Modelo;

namespace ctrlArchivos.vista
{
    public partial class documento : System.Web.UI.Page
    {

        Workmedium medium = new Workmedium();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel1.Visible = false;
                btnactualizar.Visible = false;
                btneliminar.Visible = false;
                medium.cargausuario(DropDownList3);
                medium.cargausuario(DropDownList4);
                medium.cargausuario(DropDownList5);
                medium.cargaclasificacion(DropDownList9);
            }

        }

        protected void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            medium.clasiexpediente = DropDownList9.Text;
            medium.iddocumento = TextBox1.Text;
            medium.tipodocu = DropDownList1.Text;
            medium.estatus = DropDownList2.Text;
            medium.prioridad = DropDownList8.Text;
            medium.id_remitente = DropDownList3.SelectedValue.ToString();
            medium.no_doc = TextBox3.Text;
            medium.fecha = DateTime.Parse(TextBox2.Text);
            medium.horarece = DateTime.Parse(TextBox5.Text);
            medium.iddestinatario = DropDownList4.SelectedValue.ToString();
            medium.fecharece = DateTime.Parse(TextBox4.Text);
            medium.asunto = TextBox7.Text;
            medium.obs_doc = TextBox8.Text;
            medium.desc_anexos_doc = TextBox9.Text;
            medium.no_fojas_doc = TextBox10.Text;
            medium.iddelegado = DropDownList5.SelectedValue.ToString();
            medium.estatusdelegado = DropDownList6.Text;
            medium.fechadelegado = DateTime.Parse(TextBox6.Text);
            medium.agregadocumento();
        }

        protected void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            
            Panel1.Visible = true;
            btnAgregarDoc.Visible = false;           
            medium.cargardocumentos(DropDownList11);
            TextBox1.Enabled = false;
            btneliminar.Visible = false;
            btnactualizar.Visible = false;
        }

        protected void btnEliminarDoc_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            btneliminar.Visible = true;
            btnAgregarDoc.Visible = false;

            btnactualizar.Visible = false;

        }

        protected void btnActualizarDoc_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            btnactualizar.Visible = true;
            btnAgregarDoc.Visible = false;
            btneliminar.Visible = false;
        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            medium.clasiexpediente = DropDownList9.Text;
            medium.iddocumento = TextBox1.Text;
            medium.tipodocu = DropDownList1.Text;
            medium.estatus = DropDownList2.Text;
            medium.prioridad = DropDownList8.Text;
            medium.id_remitente = DropDownList3.SelectedValue.ToString();
            medium.no_doc = TextBox3.Text;
            medium.fecha = DateTime.Parse(TextBox2.Text);
            medium.horarece = DateTime.Parse(TextBox5.Text);
            medium.iddestinatario = DropDownList4.SelectedValue.ToString();
            medium.fecharece = DateTime.Parse(TextBox4.Text);
            medium.asunto = TextBox7.Text;
            medium.obs_doc = TextBox8.Text;
            medium.desc_anexos_doc = TextBox9.Text;
            medium.no_fojas_doc = TextBox10.Text;
            medium.iddelegado = DropDownList5.SelectedValue.ToString();
            medium.estatusdelegado = DropDownList6.Text;
            medium.fechadelegado = DateTime.Parse(TextBox6.Text);
            medium.actualizadocumento();
        }

        protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
        {
            

         /*   TextBox1.Text = medium.iddocumento;
            DropDownList1.SelectedValue = medium.tipodocu;
            DropDownList2.SelectedValue = medium.estatus;
            DropDownList8.SelectedValue = medium.prioridad;
            TextBox3.Text = medium.no_doc;
            TextBox2.Text = "" + medium.fecha;
            TextBox5.Text = "" + medium.horarece;
            TextBox4.Text = "" + medium.fecharece;
            TextBox7.Text = medium.asunto;
            TextBox8.Text = medium.obs_doc;
            TextBox9.Text = medium.desc_anexos_doc;
            TextBox10.Text = medium.no_fojas_doc;
            TextBox6.Text = "" + medium.fechadelegado;*/

            //  medium.clasiexpediente = DropDownList9.Text;

            /*    medium.tipodocu = DropDownList1.Text;
                medium.estatus = DropDownList2.Text;
                medium.prioridad = DropDownList8.Text;
                medium.id_remitente = DropDownList3.SelectedValue.ToString();
                medium.no_doc = TextBox3.Text;
                medium.fecha = DateTime.Parse(TextBox2.Text);
                medium.horarece = DateTime.Parse(TextBox5.Text);
                medium.iddestinatario = DropDownList4.SelectedValue.ToString();
                medium.fecharece = DateTime.Parse(TextBox4.Text);
                medium.asunto = TextBox7.Text;
                medium.obs_doc = TextBox8.Text;
                medium.desc_anexos_doc = TextBox9.Text;
                medium.no_fojas_doc = TextBox10.Text;
                medium.iddelegado = DropDownList5.SelectedValue.ToString();
                medium.estatusdelegado = DropDownList6.Text;
                medium.fechadelegado = DateTime.Parse(TextBox6.Text);
                */

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            medium.eliminadocumento(TextBox1);
        }

        protected void DropDownList11_SelectedIndexChanged(object sender, EventArgs e)
        {
            medium.muestradocumento(DropDownList11);
            
            TextBox1.Text = medium.iddocumento;
            DropDownList1.SelectedValue = medium.tipodocu;
            DropDownList2.SelectedValue = medium.estatus;
            DropDownList8.SelectedValue = medium.prioridad;
            TextBox3.Text = medium.no_doc;
            TextBox2.Text = medium.fecha.ToString("yyy-MM-dd");
            TextBox5.Text = medium.horarece.ToShortTimeString();
            TextBox4.Text = "" + medium.fecharece.ToString("yyy-MM-dd"); 
            TextBox7.Text = medium.asunto;
            TextBox8.Text = medium.obs_doc;
            TextBox9.Text = medium.desc_anexos_doc;
            TextBox10.Text = medium.no_fojas_doc;
            TextBox6.Text = "" + medium.fechadelegado.ToString("yyy-MM-dd");
            DropDownList9.SelectedValue = medium.clasificacionexp;
            DropDownList3.SelectedValue = medium.id_remitente;
            DropDownList4.SelectedValue = medium.iddestinatario;
            DropDownList5.SelectedValue = medium.iddelegado;
            DropDownList6.SelectedValue = medium.estatusdelegado;

        }
    }
}