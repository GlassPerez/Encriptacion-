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
        Expediente miExp = new Expediente(); //from ctrlArchivos.Modelo;
        Usuario2 obj1 = new Usuario2(); //from metodo
        Workmedium medium = new Workmedium();
        static String formato = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {
                string con = "Select * From expediente";
                string al = "expediente";
                medium.selectexpediente(GridView1, con, al);

                medium.cargaclasificacion(Ddlclasifi);
                
                ddlidfondo.Visible = false;
                ddlidseccion.Visible = false;
                ddlidserie.Visible = false;
                ddlIduadmva.Visible = false;
                ddlidsubuadmva.Visible = false;
                ddlidcargoresp.Visible = false;
                DdlIdNoEd.Visible = false;
                DdlIdNoPiso.Visible = false;
                DdlIdNoPasillo.Visible = false;
                DdlIdNoEst.Visible = false;
                DdlIdNoChar.Visible = false;
                DdlIdNoCaja.Visible = false;
                DdlIdRespCaptura.Visible = false;
                DdlIdAutorizadorExp.Visible = false;
                ChkOtros.Visible = false;
                DdlVincOtros.Visible = false;
                TxtNomFondo.Visible = false;
                TxtDirFondo.Visible = false;
                TxtObsFondo.Visible = false;
            }
        }

        protected void ddlfondo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlfondo_SelectedIndexChanged1(object sender, EventArgs e)
        {
           

        }

        protected void ddlseccion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void ddlserie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Ddlclasifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            medium.muestraexpediente(Ddlclasifi);

            medium.combofondo(ddlfondo);
            medium.comboseccion(ddlseccion);
            medium.comboserie(ddlserie);
            medium.combounidadadmva(ddluadmva);
            medium.combounidadadmva(ddlsubuadmva);
            medium.combousuario(ddlcargoresp);
            medium.comboedificio(DdlNoEd);
            medium.combopiso(DdlNoPiso);
            medium.combopasillo(DdlNoPasillo);
            medium.comboestante(DdlNoEst);
            medium.combocharola(DdlNoChar);
            medium.comboUnidadInstOCaja(DdlNoCaja);
            medium.combousuario(DdlRespCaptura);
            medium.combousuario(DdlAutorizadorExp);

            medium.GenerarAños(ddlaño);
            medium.CargarGenerarFunciones(DdlFuncion);
            medium.CargarGenerarAcceso(DdlAcceso);
            medium.CargarGenerarDestFin(DdlDestFin);
            medium.CargarGenerarTipoExp(DdlTipExp);
            medium.CargarGenerarValPrim(DdlValPrim);
            medium.CargarGenerarValSec(DdlValSec);
            medium.carganoexpediente(DdlNoExp);
            medium.CargarPeriodoConservacion(DdlPlazoConser);
            medium.cargaclasificacion(DdlVincOtros);


            
            ddlfondo.SelectedValue= medium.idFondo;
            ddlseccion.SelectedValue= medium.idseccion;
            ddlserie.SelectedValue = medium.idserie;

            System.Windows.Forms.MessageBox.Show(medium.idFondo + "");
            System.Windows.Forms.MessageBox.Show(medium.idseccion + "");
            System.Windows.Forms.MessageBox.Show(medium.idserie + "");

            DdlNoExp.Text = medium.no_exp.ToString();
            ddlaño.Text= medium.año.ToString();
            ddluadmva.SelectedValue = medium.id_unid_admva_resp ;
            ddlsubuadmva.SelectedValue = medium.id_area_prod ;
            ddlcargoresp.SelectedValue = medium.id_resp_exp;
            TxtResumen.Text = medium.resumen_exp;
            TxtAsuntoExp.Text = medium.asunto_exp;
            DdlFuncion.Text = medium.funcion_exp;
            DdlAcceso.Text = medium.acceso_exp;
            DdlValPrim.Text = medium.val_prim_exp;
            TxtFecExtIni.Text = medium.fec_ext_ini_exp.ToString("yyy-MM-dd");
            TxtFecExtFin.Text = medium.fec_ext_fin_exp.ToString("yyy-MM-dd");
            TxtNoLegajo.Text = medium.no_legajo_exp+"";
            TxtNoFojas.Text = medium.no_fojas_exp+"";

           // DdlVincOtros.Text = medium.id_exp_vincd;

            TxtFrmtoSoporte.Text = medium.formato_Soporte;
            DdlPlazoConser.Text = medium.plazo_conservacion_exp+"";
            DdlTipExp.Text = medium.tipo_exp;
            DdlDestFin.Text = medium.destino_final_exp;
            DdlValSec.Text = medium.valores_secundarios_exp;
            LblIdUbicTopog.Text = medium.id_ubic_topog;
           // DdlIdNoEd.Text = miExp.IdEdificio;
            DdlNoPiso.SelectedValue = medium.IdPisoEd;
            DdlNoPasillo.SelectedValue = medium.IdPasillo;
            DdlNoEst.SelectedValue = medium.IdEstante;
            DdlNoChar.SelectedValue = medium.IdCharola;
            DdlNoCaja.SelectedValue = medium.IdUnidInsCaja;
            DdlRespCaptura.SelectedValue = medium.id_capturista_exp;
            DdlAutorizadorExp.SelectedValue = medium.id_autorizador_exp;
            TxtFechaCaptura.Text = medium.fecha_alta_exp.ToString("yyy-MM-dd");

            if (medium.formato_Soporte== "Fotografía")
            {
                ChkFoto.Checked = true;
            }

            if (medium.formato_Soporte == "Papel")
            {
                ChkPapel.Checked = true;
            }

            if (medium.formato_Soporte == "Disco")
            {
                ChkDisco.Checked = true;
            }

            if (medium.formato_Soporte == "USB")
            {
                ChkUsb.Checked = true;
            }

            RdbNoVinculado.Checked = true;
            medium.cargabajoexpediente(DdlRespCaptura, TxtNomRespExp, TxtCargoRespExp, TxtTelRespExp, TxtEmailRespExp, TxtUnidAdmvaACargo);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            medium.eliminaaunidadexpe(Ddlclasifi.SelectedItem+"",ddluadmva.SelectedItem+"");
            medium.eliminaexpediente(Ddlclasifi);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            /*
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
            */

            
            medium.idFondo = ddlfondo.SelectedValue;
            medium.idseccion = ddlseccion.SelectedValue;
            medium.idserie = ddlserie.SelectedValue;
            medium.no_exp = int.Parse(DdlNoExp.Text);
            medium.año = int.Parse(ddlaño.Text);
            medium.id_unid_admva_resp = ddluadmva.SelectedValue;
            medium.id_area_prod = ddlsubuadmva.SelectedValue;
            medium.id_resp_exp = ddlcargoresp.SelectedValue;
            medium.resumen_exp = TxtResumen.Text;
            medium.asunto_exp = TxtAsuntoExp.Text;
            medium.funcion_exp = DdlFuncion.Text;
            medium.acceso_exp = DdlAcceso.Text;
            medium.val_prim_exp = DdlValPrim.Text;
            medium.fec_ext_ini_exp = DateTime.Parse(TxtFecExtIni.Text);
            medium.fec_ext_fin_exp = DateTime.Parse(TxtFecExtFin.Text);
            medium.no_legajo_exp = int.Parse(TxtNoLegajo.Text);
            medium.no_fojas_exp = int.Parse(TxtNoFojas.Text);
            medium.vinc_otro_exp = "Cambiar por DDL";
            medium.id_exp_vincd = DdlVincOtros.Text;
            medium.formato_Soporte = formato;//validar que se seleccione al menos 1 o no este vacio
            medium.plazo_conservacion_exp = int.Parse(DdlPlazoConser.Text);
            medium.tipo_exp = DdlTipExp.Text;
            medium.destino_final_exp = DdlDestFin.Text;
            medium.valores_secundarios_exp = DdlValSec.Text;
            medium.id_ubic_topog = DdlNoEd.SelectedValue + "-" + LblIdUbicTopog.Text;
            medium.IdEdificio = DdlNoEd.SelectedValue;
            medium.IdPisoEd = DdlNoPiso.SelectedValue;
            medium.IdPasillo = DdlNoPasillo.SelectedValue;
            medium.IdEstante = DdlNoEst.SelectedValue;
            medium.IdCharola = DdlNoChar.SelectedValue;
            medium.IdUnidInsCaja = DdlNoCaja.SelectedValue;
            medium.fecha_alta_exp = DateTime.Parse(TxtFechaCaptura.Text);
            medium.id_capturista_exp = DdlRespCaptura.SelectedValue;
            medium.id_autorizador_exp = DdlAutorizadorExp.SelectedValue;


            medium.actualizarexpediente(Ddlclasifi);
            medium.actualizaunidadexpe(ddluadmva.SelectedValue);
        }

        protected void ChkPapel_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPapel.Checked)
            {
                ChkFoto.Checked = false;
                ChkUsb.Checked = false;
                ChkDisco.Checked = false;
                formato = ChkPapel.Text;
            }
        }

        protected void ChkFoto_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFoto.Checked)
            {
                ChkPapel.Checked = false;
                ChkUsb.Checked = false;
                ChkDisco.Checked = false;
                formato = ChkFoto.Text;
            }
        }

        protected void ChkUsb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkUsb.Checked)
            {
                ChkPapel.Checked = false;
                ChkFoto.Checked = false;
                ChkDisco.Checked = false;
                formato = ChkUsb.Text;
            }
        }

        protected void ChkDisco_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDisco.Checked)
            {
                ChkPapel.Checked = false;
                ChkUsb.Checked = false;
                ChkFoto.Checked = false;
                formato = ChkDisco.Text;
            }
        }

        protected void DdlNoEd_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue + "-" + DdlNoCaja.SelectedValue;

        }

        protected void DdlNoPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue + "-" + DdlNoCaja.SelectedValue;

        }

        protected void DdlNoPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue + "-" + DdlNoCaja.SelectedValue;

        }

        protected void DdlNoEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue + "-" + DdlNoCaja.SelectedValue;

        }

        protected void DdlNoChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue + "-" + DdlNoCaja.SelectedValue;

        }

        protected void DdlNoCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue + "-" + DdlNoCaja.SelectedValue;

        }

        protected void DdlRespCaptura_SelectedIndexChanged(object sender, EventArgs e)
        {
            medium.cargabajoexpediente(DdlRespCaptura, TxtNomRespExp, TxtCargoRespExp, TxtTelRespExp, TxtEmailRespExp, TxtUnidAdmvaACargo);
        }

        protected void RdbSiVinculado_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSiVinculado.Checked)
            {
                DdlVincOtros.Visible = true;
            }
        }

        protected void RdbNoVinculado_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbNoVinculado.Checked)
            {
                DdlVincOtros.Visible = false;
            }
        }
    }
}