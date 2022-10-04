using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;

namespace Restaurante_X
{
    public partial class MDI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MDI()
        {
            InitializeComponent();

            BsiUserName.Caption = ClsLog.Usuario;
            BsiFecha.Caption = DateTime.Now.ToLongDateString();
            BsiHora.Caption = DateTime.Now.ToLongTimeString();
        }

        private void BtnFormEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGestionEmpleados frmGestionEmpleados = new FrmGestionEmpleados();
            frmGestionEmpleados.MdiParent = this;
            frmGestionEmpleados.Show();
        }

        private void BtnFrmUsr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FmrUsuarios fmrUsuarios = new FmrUsuarios();
            fmrUsuarios.MdiParent = this;
            fmrUsuarios.Show();
        }

        private void BbiCerrarSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = false;
            
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            //this.Hide();





        }

        private void BtnFrmGestionMesas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGestionMesa frmGestionMesa = new FrmGestionMesa();
            frmGestionMesa.MdiParent = this;
            frmGestionMesa.Show();
        }

        private void barBtnEstadoMesas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEstadoMesas frmEsatdoMesas = new FrmEstadoMesas();
            frmEsatdoMesas.MdiParent = this;
            frmEsatdoMesas.Show();
        }

        private void barBtnMonitoreoMesas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMonitoreoMesas frmMonitoreoMesas = new FrmMonitoreoMesas();
            frmMonitoreoMesas.MdiParent = this;
            frmMonitoreoMesas.Show();

        }

        private void BtnGEstablecimiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEstablecimiento frmEstablecimiento = new FrmEstablecimiento();
            frmEstablecimiento.MdiParent = this;
            frmEstablecimiento.Show();
        }

        private void BtnGPuntosE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPuntoEmision frmPuntoEmision = new FrmPuntoEmision();
            frmPuntoEmision.MdiParent = this;
            frmPuntoEmision.Show();
        }

        private void BtnConfgSAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmConfSAR frmConfSAR = new FrmConfSAR();
            frmConfSAR.MdiParent = this;
            frmConfSAR.Show();
        }
    }
    
}
