using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ctrlArchivos.Modelo;

namespace ctrlArchivos.vista
{
    public partial class archivo : System.Web.UI.Page
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
                RdbNoVinculado.Checked = true;
            }
            

        }
      
        protected void btnAgregar_Click(object sender, EventArgs e)
        {


            medium.Clasificación = lblclasexp.Text;
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
            medium.id_ubic_topog =DdlNoEd.SelectedValue+"-"+ LblIdUbicTopog.Text;
            medium.IdEdificio = DdlNoEd.SelectedValue;
            medium.IdPisoEd = DdlNoPiso.SelectedValue;
            medium.IdPasillo = DdlNoPasillo.SelectedValue;
            medium.IdEstante = DdlNoEst.SelectedValue;
            medium.IdCharola = DdlNoChar.SelectedValue;
            medium.IdUnidInsCaja = DdlNoCaja.SelectedValue;
            medium.fecha_alta_exp = DateTime.Parse(TxtFechaCaptura.Text);
            medium.id_capturista_exp = DdlRespCaptura.SelectedValue;
            medium.id_autorizador_exp = DdlAutorizadorExp.SelectedValue;

            medium.Guardar();
            medium.agregarunidadexpe(ddluadmva.SelectedValue,lblclasexp.Text);
        }

        protected void ddlfondo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            lblclasexp.Text = ""+ddlfondo.SelectedValue;

        }

        protected void ddlseccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblclasexp.Text = "" + ddlfondo.SelectedValue+"-"+ddlseccion.SelectedValue;
        }

        protected void ddlserie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblclasexp.Text = "" + ddlfondo.SelectedValue + "-" + ddlseccion.SelectedValue+"-"+ddlserie.SelectedValue;
        }

        protected void ddlaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddluadmva_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddlsubuadmva_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        protected void ddlcargoresp_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void DdlFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void DdlAcceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DdlValPrim_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void DdlDestFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DdlTipExp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void DdlValSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DdlAutorizadorExp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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

        protected void ChkOtros_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void DdlPlazoConser_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void DdlRespCaptura_SelectedIndexChanged(object sender, EventArgs e)
        {
            medium.cargabajoexpediente(DdlRespCaptura,TxtNomRespExp,TxtCargoRespExp,TxtTelRespExp,TxtEmailRespExp,TxtUnidAdmvaACargo);
        }

        protected void DdlVincOtros_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void TxtFechaCaptura_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void DdlNoEd_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue;
        }

        protected void DdlNoPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue+"-"+DdlNoPiso.SelectedValue;
        }

        protected void DdlNoPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue+"-"+DdlNoPasillo.SelectedValue;
        }

        protected void DdlNoEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue+"-"+DdlNoEst.SelectedValue;
        }

        protected void DdlNoChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue+"-"+DdlNoChar.SelectedValue;
        }

        protected void DdlNoCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblIdUbicTopog.Text = "" + DdlNoEd.SelectedValue + "-" + DdlNoPiso.SelectedValue + "-" + DdlNoPasillo.SelectedValue + "-" + DdlNoEst.SelectedValue + "-" + DdlNoChar.SelectedValue+"-"+DdlNoCaja.SelectedValue;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("buscaexpediente.aspx");
        }
    }
}