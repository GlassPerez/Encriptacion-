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
        /*-----BUENO----------------------------------------*/
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

        Criptography encrip = new Criptography();


        /*-----BUENO----------------------------------------*/




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




        /*-------   DESDE AQUI CMOIENZA EL CODIGO BUENO   --------------------------------------------------------*/


        public string Clasificación { set; get; }
        public string idFondo { set; get; }
        public string idseccion { set; get; }
        public string idserie { set; get; }
        public int no_exp { set; get; }
        public int año { set; get; }
        public string id_unid_admva_resp { set; get; }
        public string id_area_prod { set; get; }
        public string id_resp_exp { set; get; }
        public string resumen_exp { set; get; }
        public string asunto_exp { set; get; }
        public string funcion_exp { set; get; }
        public string acceso_exp { set; get; }
        public string val_prim_exp { set; get; }
        public DateTime fec_ext_ini_exp { set; get; }
        public DateTime fec_ext_fin_exp { set; get; }
        public int no_legajo_exp { set; get; }
        public int no_fojas_exp { set; get; }
        public string vinc_otro_exp { set; get; }
        public string id_exp_vincd { set; get; }
        public string formato_Soporte { set; get; }
        public int plazo_conservacion_exp { set; get; }
        public string tipo_exp { set; get; }
        public string destino_final_exp { set; get; }
        public string valores_secundarios_exp { set; get; }
        public string id_ubic_topog { set; get; }
        public string IdEdificio { set; get; }
        public string IdPisoEd { set; get; }
        public string IdPasillo { set; get; }
        public string IdEstante { set; get; }
        public string IdCharola { set; get; }
        public string IdUnidInsCaja { set; get; }
        public DateTime fecha_alta_exp { set; get; }
        public string id_capturista_exp { set; get; }
        public string id_autorizador_exp { set; get; }



        public void muestraexpediente(DropDownList clasificacion)
        {
            SqlDataReader leer = null;
            String query = "select * from expediente e inner join unidadadmva_expediente u on u.clasificacion_exp=e.clasificacion_exp where e.clasificacion_exp='" + clasificacion.Text + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            System.Windows.Forms.MessageBox.Show(m);
            if (leer != null)
            {
                while (leer.Read())
                {
                    Clasificación = leer[0] + "";
                    idFondo = leer[1] + "";
                    idseccion = leer[2] + "";
                    idserie = leer[3] + "";
                    no_exp = Convert.ToInt32(leer[4] + "");
                    año = Convert.ToInt32(leer[5] + "");
                    id_unid_admva_resp = leer[6] + "";
                    id_area_prod = leer[7] + "";
                    id_resp_exp = leer[8] + "";
                    resumen_exp =encrip.dencripta( leer[9] + "");
                    asunto_exp = encrip.dencripta(leer[10] + "");
                    funcion_exp = encrip.dencripta(leer[11] + "");
                    acceso_exp = encrip.dencripta(leer[12] + "");
                    val_prim_exp = encrip.dencripta(leer[13] + "");
                    fec_ext_ini_exp = DateTime.Parse(leer[14] + "");
                    fec_ext_fin_exp = DateTime.Parse(leer[15] + "");
                    no_legajo_exp = Convert.ToInt32(leer[16] + "");
                    no_fojas_exp = Convert.ToInt32(leer[17] + "");
                    vinc_otro_exp = leer[18] + "";
                    id_exp_vincd = leer[19] + "";
                    formato_Soporte = encrip.dencripta(leer[20] + "");
                    plazo_conservacion_exp = Convert.ToInt32(leer[21] + "");
                    tipo_exp = encrip.dencripta(leer[22] + "");
                    destino_final_exp = encrip.dencripta(leer[23] + "");
                    valores_secundarios_exp = encrip.dencripta(leer[24] + "");
                    id_ubic_topog = leer[25] + "";
                    IdEdificio = leer[26] + "";
                    IdPisoEd = leer[27] + "";
                    IdPasillo = leer[28] + "";
                    IdEstante = leer[29] + "";
                    IdCharola = leer[30] + "";
                    IdUnidInsCaja = leer[31] + "";
                    fecha_alta_exp = DateTime.Parse(leer[32] + "");
                    id_capturista_exp = leer[33] + "";
                    id_autorizador_exp = leer[34] + "";
                    
                }
            }

        }

        public void Guardar()
        {
            
            string consulta = "Insert into expediente values('"
                + Clasificación + "', '" + idFondo + "', '" + idseccion + "', '" + idserie + "'," +
                no_exp + "," + año + ", " +
                "'" + id_unid_admva_resp + "', '" + id_area_prod + "', '" + id_resp_exp + "', '" + encrip.encripta( resumen_exp) + "', '" + encrip.encripta(asunto_exp) + "','" + encrip.encripta(funcion_exp) + "', '" + encrip.encripta(acceso_exp) + "', '" + encrip.encripta(val_prim_exp) + "', " +
                "'" + fec_ext_ini_exp + "', '" + fec_ext_fin_exp + "', " +
                no_legajo_exp + ", " + no_fojas_exp + ", " +
                "'no', 'NINGUNO', '" + encrip.encripta(formato_Soporte) + "', " +
                plazo_conservacion_exp + ", " +
                "'" + encrip.encripta(tipo_exp) + "', '" + encrip.encripta(destino_final_exp) + "', '" + encrip.encripta(valores_secundarios_exp) + "', '" + id_ubic_topog + "', " +
                "'" + IdEdificio + "', '" + IdPisoEd + "', '" + IdPasillo + "', '" + IdEstante + "', '" + IdCharola + "', '" + IdUnidInsCaja + "', " +
                "'" + fecha_alta_exp + "', " +
                "'" + id_capturista_exp + "', '" + id_autorizador_exp + "')";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);

        }        

        public void agregarunidad()
        {            
            string consulta = "Insert into unidad_admva values('" + idunidadadministrativa  + "','" + encrip.encripta(nombreunidadadministrativa)  + "','" + telefonounidadadministrativa + "','" + encrip.encripta(emailunidadadministrativa)  + "','" + encrip.encripta(domiciliounidadadministrativa)  + "','" + idunidadpertenencia + "','" + idnivel + "')";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void actualizaunidad()
        {
            string consulta = "Update unidad_admva set nombre_unid_admva='" + encrip.encripta(nombreunidadadministrativa) + "',tel_unid_admva='" + telefonounidadadministrativa + "',email_unid_admva='" + encrip.encripta(emailunidadadministrativa) + "',domicilio_unid_admva='" + encrip.encripta(domiciliounidadadministrativa) + "',Id_unid_admva_pertenencia='" + idunidadpertenencia + "',Id_nivel_ua='" + idnivel + "' where id_unid_admva='" + idunidadadministrativa + "'";
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


        public void actualizaunidadexpe(String iduni)
        {
            string consulta = "Update unidadadmva_expediente set id_unidad_admva='" + iduni + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }


        public void actualizarexpediente(DropDownList clasiexpediente)
        {
            string consulta = "Update expediente set no_exp="
                + no_exp + ",año=" + año + ", id_unid_admva_resp=" +
                "'" + id_unid_admva_resp + "',id_area_prod= '" + id_area_prod + "',id_resp_exp= '" + id_resp_exp + "',resumen_exp= '" + encrip.encripta(resumen_exp) + "',asunto_exp ='" + encrip.encripta(asunto_exp) + "',funcion_exp='" + encrip.encripta(funcion_exp) + "',acceso_exp= '" + encrip.encripta(acceso_exp) + "', val_prim_exp= '" + encrip.encripta(val_prim_exp) + "',fec_ext_ini_exp= " +
                "'" + fec_ext_ini_exp + "',fec_ext_fin_exp= '" + fec_ext_fin_exp + "',no_legajo_exp= " +
                no_legajo_exp + ",no_fojas_exp= " + no_fojas_exp + ",vinc_otro_exp= " +
                "'no',id_exp_vincd= 'NINGUNO',formato_soporte= '" + encrip.encripta(formato_Soporte) + "',plazo_conservacion_exp= " +
                plazo_conservacion_exp + ",tipo_exp= " +
                "'" + encrip.encripta(tipo_exp) + "',destino_final_exp= '" + encrip.encripta(destino_final_exp) + "', valores_secundarios_exp='" + encrip.encripta(valores_secundarios_exp) + "',id_ubic_topog= '" + id_ubic_topog + "',IdEdificio= " +
                "'" + IdEdificio + "',IdPisoEd= '" + IdPisoEd + "',IdPasillo= '" + IdPasillo + "', IdEstante='" + IdEstante + "',IdCharola= '" + IdCharola + "',IdUnidInsCaja= '" + IdUnidInsCaja + "',fecha_alta_exp= " +
                "'" + fecha_alta_exp + "',id_capturista_exp= " +
                "'" + id_capturista_exp + "',id_autorizador_exp= '" + id_autorizador_exp + "' where clasificacion_exp='" + clasiexpediente.Text + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }



        public void eliminaaunidadexpe(String clasexped,String unidadadmin)
        {
            string consulta = "Delete from unidadadmva_expediente where clasificacion_exp='" + clasexped + "' and id_unidad_admva='" + clasexped + "'";
            Sqlconection.executequery(Sqlconection.Mconect(ref m), consulta, ref m);
            System.Windows.Forms.MessageBox.Show("" + m);
        }



        public void muestraunidades(DropDownList unidad)
        {
            SqlDataReader leer = null;
            String query = "select * from unidad_admva where nombre_unid_admva='" +encrip.encripta( unidad.SelectedItem.ToString()) + "'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            
            if (leer != null)
            {
                while (leer.Read())
                {                                        
                    idunidadadministrativa = leer[0] + "";
                    nombreunidadadministrativa =encrip.dencripta( leer[1] + "");
                    telefonounidadadministrativa = leer[2] + "";
                    emailunidadadministrativa =encrip.dencripta( leer[3] + "");
                    domiciliounidadadministrativa =encrip.dencripta( leer[4] + "");
                    idunidadpertenencia = leer[5] + "";
                    idnivel = leer[6] + "";

                }
            }
        }

        /*-------------------------------------------------------------------------------------------------------------------*/

        public void cargabajoexpediente(DropDownList usuario,TextBox nomusuario,TextBox cargo,TextBox telefono,TextBox email,TextBox unidad)
        {
            SqlDataReader leer = null;
            String query = "select u.nom_com_usr,u.nom_cargo_usr,u.telefono_contacto,u.email_usr,un.nombre_unid_admva from usuario u inner join unidad_admva un on un.id_unid_admva=u.id_unid_admva_pertenece where u.id_usr='"+usuario.SelectedValue+"'";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            
            if (leer != null)
            {
                while (leer.Read())
                {
                    nomusuario.Text = leer[0] + "";
                    cargo.Text = leer[1] + "";
                    telefono.Text = leer[2] + "";
                    email.Text = leer[3] + "";
                    unidad.Text = leer[4] + "";
                    
                }
            }

        }
        

        public void carganoexpediente(DropDownList ddlnoexpe)
        {
            //se generan periodos en años del 1 al 15
            ddlnoexpe.Items.Clear();
            ddlnoexpe.Items.Add("Selecciona");
            for (int i = 1; i < 30; i++)
            {
                ddlnoexpe.Items.Add(i.ToString());
            }
        }

        public void CargarPeriodoConservacion(DropDownList DdlPlazoConser)
        {
            //se generan periodos en años del 1 al 15
            DdlPlazoConser.Items.Clear();
            DdlPlazoConser.Items.Add("Selecciona");
            for (int i = 1; i < 16; i++)
            {
                DdlPlazoConser.Items.Add(i.ToString());
            }
        }

        public void GenerarAños(DropDownList ddlaño)
        {

            ddlaño.Items.Clear();
            ddlaño.Items.Add("Selecciona");
            for (int i = DateTime.Now.Year; i >= 1980; i--)
            {
                ddlaño.Items.Add(i.ToString());
            }
        }
        public void CargarGenerarFunciones(DropDownList DdlDatos)
        {
            DdlDatos.Items.Clear();
            DdlDatos.Items.Add("Selecciona");
            DdlDatos.Items.Add("Sustantiva");
            DdlDatos.Items.Add("Común");
        }
        public void CargarGenerarAcceso(DropDownList DdlDatos)
        {
            DdlDatos.Items.Clear();
            DdlDatos.Items.Add("Selecciona");
            DdlDatos.Items.Add("Público");
            DdlDatos.Items.Add("Reservado");
            DdlDatos.Items.Add("Confidencial");
        }
        public void CargarGenerarValPrim(DropDownList DdlDatos)
        {
            DdlDatos.Items.Clear();
            DdlDatos.Items.Add("Selecciona");
            DdlDatos.Items.Add("Administrativo");
            DdlDatos.Items.Add("Legal");
            DdlDatos.Items.Add("Fiscal");
        }
        public void CargarGenerarTipoExp(DropDownList DdlDatos)
        {
            DdlDatos.Items.Clear();
            DdlDatos.Items.Add("Selecciona");
            DdlDatos.Items.Add("Trámite");
            DdlDatos.Items.Add("Concentración");
            DdlDatos.Items.Add("Archivo de tramite");
        }
        public void CargarGenerarDestFin(DropDownList DdlDatos)
        {
            DdlDatos.Items.Clear();
            DdlDatos.Items.Add("Selecciona");
            DdlDatos.Items.Add("Baja documental");
            DdlDatos.Items.Add("Archivo histórico");
        }
        public void CargarGenerarValSec(DropDownList DdlDatos)
        {
            DdlDatos.Items.Clear();
            DdlDatos.Items.Add("Selecciona");
            DdlDatos.Items.Add("Evidencial");
            DdlDatos.Items.Add("Testimonial");
            DdlDatos.Items.Add("Informativo");
            DdlDatos.Items.Add("valsec");

        }



        public void cargacombonivel(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from nivel_unid_admva";
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
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }


        public void cargacombounidadperteencia(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from unidad_admva";
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
                    cb1.Items.Insert(0, new ListItem(encrip.dencripta( "" + leer[1]), "" + leer[0]));
                    i++;
                }
            }
        }

        public void combofondo(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_fondo,nombre_fondo from fondo";
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
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }



        public void comboseccion(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from seccion";
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
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void comboserie(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from serie";
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
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }



        public void combounidadadmva(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select id_unid_admva,nombre_unid_admva from unidad_admva";
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
                    cb1.Items.Insert(0, new ListItem(encrip.dencripta( "" + leer[1]), "" + leer[0]));
                    i++;
                }
            }
        }

        public void combousuario(DropDownList cb1)
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
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void comboedificio(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from edificio";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void combopiso(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Piso";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void combopasillo(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Pasillo";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void combocharola(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Charola";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void comboUnidadInstOCaja(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from UnidadInstOCaja";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }

        public void comboestante(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select * from Estante";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            if (leer != null)
            {
                int i = 0;
                while (leer.Read())
                {
                    cb1.Items.Insert(0, new ListItem("" + leer[1], "" + leer[0]));
                    i++;
                }
            }
        }


        public void cargaclasificacion(DropDownList cb1)
        {
            String temp = "";
            cb1.Items.Clear();
            SqlDataReader leer = null;
            String query = "select e.clasificacion_exp from expediente e inner join unidadadmva_expediente u on u.clasificacion_exp=e.clasificacion_exp";
            leer = Sqlconection.Queryreader(Sqlconection.Mconect(ref m), query, ref m);
            cb1.Items.Insert(0, new ListItem("seleccionar", "seleccionar"));
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



        /*--------       TERMINA CODIGO BUENO    -------------------------------------*/
        /*---------------------------------------------*/









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
            string consulta = "Insert into documento values('" + clasiexpediente + "','" + iddocumento + "','" +encrip.encripta( tipodocu) + "','" + encrip.encripta(estatus) + "','" + encrip.encripta(prioridad) + "','" + id_remitente + "','" + no_doc + "','" + fecha + "','" + iddestinatario + "','" + fecharece + "','" + horarece + "','" + encrip.encripta(asunto) + "','" + encrip.encripta(obs_doc) + "','" + encrip.encripta(desc_anexos_doc) + "'," + no_fojas_doc + ",'" + iddelegado + "','" + encrip.encripta(estatusdelegado) + "','" + fechadelegado + "')";
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
                    tipodocu = encrip.dencripta( leer[2] + "");
                    estatus = encrip.dencripta(leer[3] + "");
                    prioridad = encrip.dencripta(leer[4] + "");
                    id_remitente = leer[5] + "";
                    no_doc = leer[6] + "";
                    fecha = DateTime.Parse(leer[7] + "");
                    iddestinatario = leer[8] + "";
                    fecharece = DateTime.Parse(leer[9] + "");
                    horarece = DateTime.Parse(leer[10] + "");
                    asunto = encrip.dencripta(leer[11] + "");
                    obs_doc = encrip.dencripta(leer[12] + "");
                    desc_anexos_doc = encrip.dencripta(leer[13] + "");
                    no_fojas_doc = leer[14] + "";
                    iddelegado = leer[15] + "";
                    estatusdelegado = encrip.dencripta(leer[16] + "");
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
            string consulta = "Update documento set clasificacion_exp='" + clasiexpediente + "',tipo_doc='" +encrip.encripta( tipodocu) + "',estatus_doc='" + encrip.encripta(estatus) + "',prioridad_doc='" + encrip.encripta(prioridad) + "',id_remitente_doc='" + id_remitente + "',no_doc='" + no_doc + "',fecha_doc='" + fecha + "',id_destinatario='" + iddestinatario + "',fecha_recep_doc='" + fecharece + "',hora_recep_doc='" + horarece + "',asunto='" + encrip.encripta(asunto) + "',obs_doc='" + encrip.encripta(obs_doc) + "',desc_anexos_doc='" + encrip.encripta(desc_anexos_doc) + "',no_fojas_doc=" + no_fojas_doc + ",id_delegado_doc='" + iddelegado + "',estatus_dele_doc='" + encrip.encripta(estatusdelegado) + "',fecha_dele_doc='" + fechadelegado + "' where id_doc='" + iddocumento + "'";
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


        DataSet setglobal = new DataSet();

        public void selectexpediente(GridView d1, string consulta, string alias)
        {
            String query = consulta;
            Sqlconection.querysetrefer(ref setglobal, Sqlconection.Mconect(ref m), query, ref m, alias);
            
            d1.DataSource = setglobal.Tables[alias];
            d1.DataBind();
        }


       





    }
}