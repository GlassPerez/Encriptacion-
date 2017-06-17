using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ctrlArchivos.Modelo;

namespace ctrlArchivos.vista
{
    public partial class buscaexpediente : System.Web.UI.Page
    {
        Expediente miExp = new Expediente();
        Workmedium medium = new Workmedium();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Validate initially to force asterisks
                // to appear before the first roundtrip.
                Validate();
                miExp.cargarDatosIniciales(
                    ddlfondo,
                    ddlidfondo,
                    ddlseccion,
                    ddlidseccion,
                    ddlserie,
                    ddlidserie,
                    ddlaño,
                    ddluadmva,
                    ddlIduadmva,
                    DdlFuncion,
                    DdlAcceso,
                    DdlValPrim,
                    DdlTipExp,
                    DdlDestFin,
                    DdlValSec,
                    DdlPlazoConser,
                    DdlRespCaptura,
                    DdlIdRespCaptura
                );
                miExp.inicioOcultar(
                    DdlVincOtros

                    );
                miExp.inicioDeshabilitar(
                    TxtFrmtoSoporte
                    );
            }
        }

        protected void ddlfondo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlfondo_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ddlidfondo.Text= medium.cargaidfondo(ddlfondo);

        }

        protected void ddlseccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlidseccion.Text = medium.cargaseccion(ddlseccion);
            medium.cargaserie(ddlserie,ddlidseccion,ddlidserie);
        }

        protected void ddlserie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlidserie.Text = medium.seleccionaidserie(ddlserie);
            medium.cargaclasificacionexpe(Ddlclasifi, ddlidserie);
        }

        protected void Ddlclasifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            miExp.muestraexpediente(Ddlclasifi);

            medium.cargacombounidadadministrativa(ddlidsubuadmva, ddlsubuadmva, miExp.id_area_prod);

            medium.cargaedificio(DdlIdNoEd, DdlNoEd, miExp.IdEdificio);
            medium.cargapiso(DdlIdNoPiso, DdlNoPiso, miExp.IdPisoEd);
            medium.cargapasillo(DdlIdNoPasillo, DdlNoPasillo, miExp.IdPasillo);
            medium.cargaestante(DdlIdNoEst, DdlNoEst, miExp.IdEstante);
            medium.cargacharola(DdlIdNoChar, DdlNoChar, miExp.IdCharola);
            medium.cargaunidcaja(DdlIdNoCaja, DdlNoCaja, miExp.IdUnidInsCaja);
            medium.cargauusuario(ddlidcargoresp, ddlcargoresp, miExp.id_resp_exp);
            
            medium.cargauusuario(DdlIdRespCaptura, DdlRespCaptura, miExp.id_capturista_exp);
            medium.cargauusuario(DdlIdAutorizadorExp, DdlAutorizadorExp, miExp.id_autorizador_exp);

            ddlidfondo.Text= miExp.idFondo ;
            ddlidseccion.Text= miExp.idseccion;
            ddlidserie.Text = miExp.idserie;
            DdlNoExp.Text = miExp.no_exp.ToString();
            ddlaño.Text= miExp.año.ToString();
            ddlIduadmva.Text= miExp.id_unid_admva_resp ;
            ddlidsubuadmva.Text= miExp.id_area_prod ;
          // ddlidcargoresp.Text = miExp.id_resp_exp;
            TxtResumen.Text = miExp.resumen_exp;
            TxtAsuntoExp.Text = miExp.asunto_exp;
            DdlFuncion.Text = miExp.funcion_exp;
            DdlAcceso.Text = miExp.acceso_exp;
            DdlValPrim.Text = miExp.val_prim_exp;
            TxtFecExtIni.Text = miExp.fec_ext_ini_exp.ToString("yyy-MM-dd");
            TxtFecExtFin.Text = miExp.fec_ext_fin_exp.ToString("yyy-MM-dd");
            TxtNoLegajo.Text = miExp.no_legajo_exp+"";
            TxtNoFojas.Text = miExp.no_fojas_exp+"";

            DdlVincOtros.Text = miExp.id_exp_vincd;

            TxtFrmtoSoporte.Text = miExp.formato_Soporte;
            DdlPlazoConser.Text = miExp.plazo_conservacion_exp+"";
            DdlTipExp.Text = miExp.tipo_exp;
            DdlDestFin.Text = miExp.destino_final_exp;
            DdlValSec.Text = miExp.valores_secundarios_exp;
            LblIdUbicTopog.Text = miExp.id_ubic_topog;
           // DdlIdNoEd.Text = miExp.IdEdificio;
            DdlIdNoPiso.Text = miExp.IdPisoEd;
            DdlIdNoPasillo.Text = miExp.IdPasillo;
            DdlIdNoEst.Text = miExp.IdEstante;
            DdlIdNoChar.Text = miExp.IdCharola;
            DdlIdNoCaja.Text = miExp.IdUnidInsCaja;
            TxtFechaCaptura.Text = miExp.fecha_alta_exp.ToString("yyy-MM-dd");
          //  DdlIdRespCaptura.Text = miExp.id_capturista_exp;
          //  DdlIdAutorizadorExp.Text = miExp.id_autorizador_exp;


            /*
            
            miExp.vinc_otro_exp = "Cambiar por DDL";
           


             = ;//validar que se seleccione al menos 1 o no este vacio
             = int.Parse();
             = ;
             = ;
             = ;
             = ;
             = ;
             = ;
             = ;
            = ;
             = ;
             = ;
            = DateTime.Parse();
             = ;
             = ;*/


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            medium.eliminaexpediente(Ddlclasifi);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            miExp.idFondo = ddlidfondo.Text;
            miExp.idseccion = ddlidseccion.Text;
            miExp.idserie = ddlidserie.Text;
            miExp.no_exp = int.Parse(DdlNoExp.Text);
            miExp.año = int.Parse(ddlaño.Text);
            miExp.id_unid_admva_resp = ddlIduadmva.Text;
            miExp.id_area_prod = ddlidsubuadmva.Text;
            miExp.id_resp_exp = ddlidcargoresp.Text;
            miExp.resumen_exp = TxtResumen.Text;
            miExp.asunto_exp = TxtAsuntoExp.Text;
            miExp.funcion_exp = DdlFuncion.Text;
            miExp.acceso_exp = DdlAcceso.Text;
            miExp.val_prim_exp = DdlValPrim.Text;
            miExp.fec_ext_ini_exp = DateTime.Parse(TxtFecExtIni.Text);
            miExp.fec_ext_fin_exp = DateTime.Parse(TxtFecExtFin.Text);
            miExp.no_legajo_exp = int.Parse(TxtNoLegajo.Text);
            miExp.no_fojas_exp = int.Parse(TxtNoFojas.Text);
            miExp.vinc_otro_exp = "Cambiar por DDL";
            miExp.id_exp_vincd = DdlVincOtros.Text;
            miExp.formato_Soporte = TxtFrmtoSoporte.Text;//validar que se seleccione al menos 1 o no este vacio
            miExp.plazo_conservacion_exp = int.Parse(DdlPlazoConser.Text);
            miExp.tipo_exp = DdlTipExp.Text;
            miExp.destino_final_exp = DdlDestFin.Text;
            miExp.valores_secundarios_exp = DdlValSec.Text;
            miExp.id_ubic_topog = LblIdUbicTopog.Text;
            miExp.IdEdificio = DdlIdNoEd.Text;
            miExp.IdPisoEd = DdlIdNoPiso.Text;
            miExp.IdPasillo = DdlIdNoPasillo.Text;
            miExp.IdEstante = DdlIdNoEst.Text;
            miExp.IdCharola = DdlIdNoChar.Text;
            miExp.IdUnidInsCaja = DdlIdNoCaja.Text;
            miExp.fecha_alta_exp = DateTime.Parse(TxtFechaCaptura.Text);
            miExp.id_capturista_exp = DdlIdRespCaptura.Text;
            miExp.id_autorizador_exp = DdlIdAutorizadorExp.Text;



            miExp.actualizarexpediente(Ddlclasifi);
        }
    }
}