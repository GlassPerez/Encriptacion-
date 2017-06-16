using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ctrlArchivos.Modelo
{
    public class Workmedium
    {

        Conectasql Sqlconection = new Conectasql();

        String m = "";
        public String idunidadadministrativa { set; get; }
        public String nombreunidadadministrativa { set; get; }
        public String telefonounidadadministrativa { set; get; }
        public String emailunidadadministrativa { set; get; }
        public String domiciliounidadadministrativa { set; get; }
        public String idunidadpertenencia { set; get; }
        public String idnivel { set; get; }

        public String clasificacionexp { set; get; }


        public void cargacombonivel(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_nivel_ua from nivel_unid_admva";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    for (int i = 0; i < 1; i++)
                    {
                        temp += leer[i] + "";
                    }
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }
        public void cargaunidad(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select nombre_unid_admva from unidad_admva";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    for (int i = 0; i < 1; i++)
                    {
                        temp += leer[i] + "";
                    }
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }


        public void cargacombounidadperteencia(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_unid_admva from unidad_admva";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    temp += leer[0] + "";
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }

        public void obtennobrenivel(Label nombrenivel, DropDownList nomnivel)
        {
            SqlDataReader leer = null;
            String query = "select id_nivel_ua from nivel_unid_admva where nombre_nivel_ua='" + nomnivel.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    nombrenivel.Text = leer[0] + "";

                }
            }
        }



        public void agregarunidad()
        {
            string consulta = "Insert into unidad_admva values('" + idunidadadministrativa + "','" + nombreunidadadministrativa + "','" + telefonounidadadministrativa + "','" + emailunidadadministrativa + "','" + domiciliounidadadministrativa + "','" + idunidadpertenencia + "','" + idnivel + "')";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void actualizaunidad()
        {
            string consulta = "Update unidad_admva set nombre_unid_admva='" + nombreunidadadministrativa + "',tel_unid_admva='" + telefonounidadadministrativa + "',email_unid_admva='" + emailunidadadministrativa + "',domicilio_unid_admva='" + domiciliounidadadministrativa + "',Id_unid_admva_pertenencia='" + idunidadpertenencia + "',Id_nivel_ua='" + idnivel + "' where id_unid_admva='" + idunidadadministrativa + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void eliminaaunidad(TextBox idunidad)
        {
            string consulta = "Delete from unidad_admva where id_unid_admva='" + idunidad.Text + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }
        

        public void agregarunidadexpe(String unidad,String expediente)
        {
            string consulta = "Insert into unidadadmva_expediente values('" + expediente + "','" + unidad + "')";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void actualizaunidadexpe()
        {
            string consulta = "Update unidadadmva_expediente set clasificacion_exp='" + clasificacionexp + "',id_unid_admva='" + idunidadadministrativa + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void eliminaaunidadexpe()
        {
            string consulta = "Delete from unidadadmva_expediente where clasificacion_exp='" + clasificacionexp + "' and id_unid_admva='" + idunidadadministrativa + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }



        public void muestraunidades(DropDownList unidad)
        {
            SqlDataReader leer = null;
            String query = "select * from unidad_admva where nombre_unid_admva='" + unidad.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    idunidadadministrativa = leer[0] + "";
                    nombreunidadadministrativa = leer[1] + "";
                    telefonounidadadministrativa = leer[2] + "";
                    emailunidadadministrativa = leer[3] + "";
                    domiciliounidadadministrativa = leer[4] + "";
                    idunidadpertenencia = leer[5] + "";
                    idnivel = leer[6] + "";
                }
            }
        }

        /*-------------------------------------------------------------------------------------------------------------------*/

        public void cargaclasificacion(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select clasificacion_exp from expediente";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    for (int i = 0; i < 1; i++)
                    {
                        temp += leer[i] + "";
                    }
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }

        public void cargardocumentos(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_doc from documento";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    for (int i = 0; i < 1; i++)
                    {
                        temp += leer[i] + "";
                    }
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }



        public void cargausuario(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_usr,nom_com_usr from usuario";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    // temp = "";
                    //for (int i = 0; i < 1; i++)
                    //{
                    //    temp += leer[i] + "";
                    //  }
                    // listauniforme.Add((int)leer[0]);
                    //  cb1.Items.Add(temp);
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[1]));
                    i++;
                }
            }
        }


        public String clasiexpediente { set; get; }
        public String iddocumento { set; get; }
        public String tipodocu { set; get; }
        public String estatus { set; get; }
        public String prioridad { set; get; }
        public String id_remitente { set; get; }
        public String no_doc { set; get; }
        public DateTime fecha { set; get; }
        public String iddestinatario { set; get; }
        public DateTime fecharece { set; get; }
        public DateTime horarece { set; get; }
        public String asunto { set; get; }
        public String obs_doc { set; get; }
        public String desc_anexos_doc { set; get; }
        public String no_fojas_doc { set; get; }
        public String iddelegado { set; get; }
        public String estatusdelegado { set; get; }
        public DateTime fechadelegado { set; get; }

       




        public void agregadocumento()
        {
            string consulta = "Insert into documento values('" + clasiexpediente + "','" + iddocumento + "','" + tipodocu + "','" + estatus + "','" + prioridad + "','" + id_remitente + "','" + no_doc + "','" + fecha + "','" + iddestinatario + "','" + fecharece + "','" + horarece + "','" + asunto + "','" + obs_doc + "','" + desc_anexos_doc + "'," + no_fojas_doc + ",'" + iddelegado + "','" + estatusdelegado + "','" + fechadelegado + "')";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);

        }


        public void muestradocumento(DropDownList ddliddocumento)
        {
            SqlDataReader leer = null;
            String query = "select * from documento where id_doc='" + ddliddocumento.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            

            if (leer != null)
            {
                while (leer.Read())
                {
                    clasiexpediente = leer[0] + "";
                    iddocumento = leer[1] + "";
                    tipodocu = leer[2] + "";
                    estatus = leer[3] + "";
                    prioridad = leer[4] + "";
                    id_remitente = leer[5] + "";
                    no_doc = leer[6] + "";
                    fecha = DateTime.Parse(leer[7] + "");
                    iddestinatario = leer[8] + "";
                    fecharece = DateTime.Parse(leer[9] + "");
                    horarece = DateTime.Parse(leer[10] + "");
                    asunto = leer[11] + "";
                    obs_doc = leer[12] + "";
                    desc_anexos_doc = leer[13] + "";
                    no_fojas_doc = leer[14] + "";
                    iddelegado = leer[15] + "";
                    estatusdelegado = leer[16] + "";
                    fechadelegado = DateTime.Parse(leer[17] + "");

                }
            }
                        
        }

        public void eliminadocumento(TextBox iddocu)
        {
            string consulta = "Delete from documento where id_doc='" + iddocu.Text + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void actualizadocumento()
        {
            string consulta = "Update documento set clasificacion_exp='" + clasiexpediente + "',tipo_doc='" + tipodocu + "',estatus_doc='" + estatus + "',prioridad_doc='" + prioridad + "',id_remitente_doc='" + id_remitente + "',no_doc='" + no_doc + "',fecha_doc='" + fecha + "',id_destinatario='" + iddestinatario + "',fecha_recep_doc='" + fecharece + "',hora_recep_doc='" + horarece + "',asunto='" + asunto + "',obs_doc='" + obs_doc + "',desc_anexos_doc='" + desc_anexos_doc + "',no_fojas_doc=" + no_fojas_doc + ",id_delegado_doc='" + iddelegado + "',estatus_dele_doc='" + estatusdelegado + "',fecha_dele_doc='" + fechadelegado + "' where id_doc='" + iddocumento + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public String cargaidfondo(DropDownList fondo)
        {
            String temp = "";
            SqlDataReader leer = null;
            String query = "select id_fondo from fondo where nombre_fondo='"+fondo.Text+"'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                
                while (leer.Read())
                {
                    temp = leer[0] + "";                    
                }
            }
            return temp;
        }


        public String cargaseccion(DropDownList seccion )
        {
            String temp = "";
            SqlDataReader leer = null;
            String query = "select id_seccion from seccion where nombre_sec='" + seccion.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {

                while (leer.Read())
                {
                    temp = leer[0] + "";
                }
            }
            return temp;
        }


        public void cargaserie(DropDownList cb1,DropDownList seccion,DropDownList serieid)
        {
            String temp = "", temp2 = "" ;
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_serie, descripcion_serie from serie where id_seccion='"+seccion.Text+"'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {

                    temp = leer[1] + "";
                    temp2 = leer[0]+"";
                    // listauniforme.Add((int)leer[0]);
                    serieid.Items.Add(temp2);
                    cb1.Items.Add(temp);
                }
            }
        }
        public void cargaidserie(DropDownList cb1, DropDownList seriedescripcion)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_serie from serie where descripcion_serie='" + seriedescripcion.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    for (int i = 0; i < 1; i++)
                    {
                        temp += leer[i] + "";
                    }
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }

        public String seleccionaidserie(DropDownList serie)
        {
            String temp = "";
            SqlDataReader leer = null;
            String query = "select id_serie from serie where descripcion_serie='" + serie.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {

                while (leer.Read())
                {
                    temp = leer[0] + "";
                }
            }
            return temp;
        }


        public void cargaclasificacionexpe(DropDownList cb1, DropDownList idserie)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select e.clasificacion_exp from expediente e inner join unidadadmva_expediente u on u.clasificacion_exp=e.clasificacion_exp where idserie='" + idserie.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            //System.Windows.Forms.MessageBox.Show(m);
            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = "";
                    for (int i = 0; i < 1; i++)
                    {
                        temp += leer[i] + "";
                    }
                    // listauniforme.Add((int)leer[0]);
                    cb1.Items.Add(temp);
                }
            }
        }
        
        public void eliminaexpediente(DropDownList clasifi)
        {
            string consulta1 = "Delete from unidadadmva_expediente where clasificacion_exp='" + clasifi.Text + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta1, ref m);
            string consulta = "Delete from expediente where clasificacion_exp='" + clasifi.Text + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);       

            System.Windows.Forms.MessageBox.Show("" + m);
        }



        public void cargaedificio(DropDownList cb1, DropDownList nomedificio,string encontraodo)
        {
            String temp = "", temp1 = "",idcomparar=""; 
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from edificio";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";
                    if(encontraodo==temp[0]+"")
                    { idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nomedificio.Items.Add(temp1);
                }
                nomedificio.Text = idcomparar;
            }
        }





        public void cargapiso(DropDownList cb1, DropDownList nombrepiso, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from piso";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";
                    if (encontraodo == temp[0] + "")
                    {
                        idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nombrepiso.Items.Add(temp1);
                }
                nombrepiso.Text = idcomparar;
            }
        }

        public void cargapasillo(DropDownList cb1, DropDownList nombrepasilllo, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Pasillo";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";
                    if (encontraodo == temp[0] + "")
                    {
                        idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nombrepasilllo.Items.Add(temp1);
                }
                nombrepasilllo.Text = idcomparar;
            }
        }


        public void cargaestante(DropDownList cb1, DropDownList nombreestante, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Estante";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";
                    if (encontraodo == temp[0] + "")
                    {
                        idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nombreestante.Items.Add(temp1);
                }
                nombreestante.Text = idcomparar;
            }
        }


        public void cargacharola(DropDownList cb1, DropDownList nombrecharola, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Charola";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";
                    if (encontraodo == temp[0] + "")
                    {
                        idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nombrecharola.Items.Add(temp1);
                }
                nombrecharola.Text = idcomparar;
            }
        }





        public void cargaunidcaja(DropDownList cb1, DropDownList nombreunidcaja, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from UnidadInstOCaja";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";
                    if (encontraodo == temp[0] + "")
                    {
                        idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nombreunidcaja.Items.Add(temp1);
                }
                nombreunidcaja.Text = idcomparar;
            }
        }

        public void cargauusuario(DropDownList cb1, DropDownList nombreusuario, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_usr,nom_com_usr from usuario";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);

            
            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";

                    if (Convert.ToString(encontraodo)== Convert.ToString(temp))
                    {
                        idcomparar = temp1;
                    }

                    cb1.Items.Add(temp);
                    nombreusuario.Items.Add(temp1);
                }
                nombreusuario.Text = idcomparar;
                System.Windows.Forms.MessageBox.Show(idcomparar);
            }
        }


        public void cargacombounidadadministrativa(DropDownList cb1, DropDownList nombreunidad, string encontraodo)
        {
            String temp = "", temp1 = "", idcomparar = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from unidad_admva";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            
            if (leer != null)
            {
                while (leer.Read())
                {
                    temp = leer[0] + "";
                    temp1 = leer[1] + "";

                    if (encontraodo == temp[0] + "")
                    {
                        idcomparar = temp1[1] + "";
                    }

                    cb1.Items.Add(temp);
                    nombreunidad.Items.Add(temp1);
                }
                nombreunidad.Text = idcomparar;
            }
        }

    }
}