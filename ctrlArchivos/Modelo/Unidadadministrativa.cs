using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ctrlArchivos.Modelo
{
    public class Unidadadministrativa
    {

        public String idunidadadministrativa { set; get; }
        public String nombreunidadadministrativa { set; get; }
        public String telefonounidadadministrativa { set; get; }
        public String emailunidadadministrativa { set; get; }
        public String domiciliounidadadministrativa { set; get; }
        public String idunidadpertenencia { set; get; }
        public String idnivel { set; get; }

        public String clasificacionexp { set; get; }

        Usuario2 obj1 = new Usuario2();







        public int Guardar()
        {
            string consulta = "Insert into unidad_admva values('" + idunidadadministrativa + "','" + nombreunidadadministrativa + "','" + telefonounidadadministrativa + "','" + emailunidadadministrativa + "','" + domiciliounidadadministrativa + "','" + idunidadpertenencia + "','" + idnivel + "')";
            int res = obj1.Guardar(consulta);
            return res;
        }

        public int Actualiza()
        {
            string consulta = "Update unidad_admva set nombre_unid_admva='" + nombreunidadadministrativa + "',tel_unid_admva='" + telefonounidadadministrativa + "',email_unid_admva='" + emailunidadadministrativa + "',domicilio_unid_admva='" + domiciliounidadadministrativa + "',Id_unid_admva_pertenencia='" + idunidadpertenencia + "',Id_nivel_ua='" + idnivel + "' where id_unid_admva='" + idunidadadministrativa + "'";
            int res = obj1.Guardar(consulta);
            return res;
        }


        public int Eliminar()
        {
            string consulta = "Delete from unidad_admva where id_unid_admva=" + idunidadadministrativa + "";
            int res = obj1.Guardar(consulta);
            return res;
        }


        public int Guardarunidadexpeente()
        {
            string consulta = "Insert into unidadadmva_expediente values('" + clasificacionexp + "','" + idunidadadministrativa + "')";
            int res = obj1.Guardar(consulta);
            return res;
        }

        public int Actualizaunidadexpeente()
        {
            string consulta = "Update unidadadmva_expediente set clasificacion_exp='" + clasificacionexp + "',id_unid_admva='" + idunidadadministrativa + "'";
            int res = obj1.Guardar(consulta);
            return res;
        }


        public int Eliminarunidadexpeente()
        {
            string consulta = "Delete from unidadadmva_expediente where clasificacion_exp='" + clasificacionexp + "' and id_unid_admva='" + idunidadadministrativa + "'";
            int res = obj1.Guardar(consulta);
            return res;
        }

    }
}