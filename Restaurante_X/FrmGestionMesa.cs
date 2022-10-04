using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_X
{
    public partial class FrmGestionMesa : Form
    {
        DC_Restaurante_XDataContext db = new DC_Restaurante_XDataContext();

        public FrmGestionMesa()
        {
            InitializeComponent();
            llenarMesa();
            cboEstadoMesa();

        }

        private void cboEstadoMesa()
        {
            var cboEstado = (from estado in db.EstadoMesa
                             select new { IdEstado = estado.IdEstadoMesa, Estado = estado.EstadoMesa1 });


            CboEstadoMesa.DataSource = cboEstado;
            CboEstadoMesa.DisplayMember = "Estado";
            CboEstadoMesa.ValueMember = "IdEstado";
        }

        private void llenarMesa()
        {
            var grid = (from mesa in db.Mesa
                        join est in db.EstadoMesa
                        on mesa.IdEstadoMesa equals est.IdEstadoMesa
                        select new { Codido = mesa.IdMesa, Mesa = mesa.Mesa1, Estado_Mesa = mesa.IdEstadoMesa, Estado = est.EstadoMesa1 });

            DgvMesas.DataSource = grid;
        }

       

       //private void DgvMesas_CellClick(Object sender, DataGridViewCellEventArgs e)
       // {
            
       // }     
        
        private void DgvMesas_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            var idmesa = DgvMesas.Rows[e.RowIndex].Cells[0].Value.ToString();
            var mesa = DgvMesas.Rows[e.RowIndex].Cells[1].Value.ToString();
            //var cboMesa = DgvMesas.Rows[e.RowIndex].Cells[2].Value.ToString();
            //var ObsMesa = DgvMesas.Rows[e.RowIndex].Cells[4].Value.ToString();

            TxtIdMesa.Text = idmesa;
            TxtMesa.Text = mesa;
        }


        
        private void TxtIdMesa_KeyPress(Object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void BtnBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Lmente");
        }

        

     

        private void TxtBuscarMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void BtnAgregarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();

            var idmesa = (from _mesa in db.Mesa
                          select mesa).Count();


            int correlativo = Convert.ToInt32(idmesa + 1);

            mesa.IdMesa = correlativo;
            mesa.Mesa1 = Convert.ToInt32(TxtMesa.Text);
            mesa.IdEstadoMesa = Convert.ToInt32(CboEstadoMesa.SelectedValue);
            mesa.IdUsuario = ClsLog.IdUsuario;
            mesa.LogTime = DateTime.Now;

            db.Mesa.InsertOnSubmit(mesa);
            db.SubmitChanges();

            llenarMesa();
            MessageBox.Show("La Mesa se Registro Correctamente");
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (TxtBuscarMesa.Text == "")
            {
                llenarMesa();
            }
            else
            {


                if (TxtBuscarMesa.Text.Any(x => !char.IsNumber(x)))
                {

                    llenarMesa();
                }
                else
                {
                    var buscar = (from mesa in db.Mesa
                                  join est in db.EstadoMesa
                                  on mesa.IdEstadoMesa equals est.IdEstadoMesa
                                  where mesa.IdMesa == Convert.ToInt32(TxtBuscarMesa.Text)
                                  select new { Codido = mesa.IdMesa, Mesa = mesa.Mesa1, Estado_Mesa = mesa.IdEstadoMesa, Estado = est.EstadoMesa1 });

                    DgvMesas.DataSource = buscar;
                }

            }
        }

        private void BtnModificarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = db.Mesa.FirstOrDefault(mesal => mesal.IdMesa.Equals(TxtIdMesa.Text));


            mesa.IdMesa = Convert.ToInt32(TxtIdMesa.Text);
            mesa.Mesa1 = Convert.ToInt32(TxtMesa.Text);
            mesa.IdEstadoMesa = Convert.ToInt32(CboEstadoMesa.SelectedValue);
            mesa.IdUsuario = ClsLog.IdUsuario;
            mesa.LogTime = DateTime.Now;

            //Save changes to Database.
            db.SubmitChanges();

            llenarMesa();

            MessageBox.Show("La mesa se Actualizo Correctamente");
        }

        private void BtnEliminarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = db.Mesa.FirstOrDefault(mesal => mesal.IdMesa.Equals(TxtIdMesa.Text));


            db.Mesa.DeleteOnSubmit(mesa);


            db.SubmitChanges();
            llenarMesa();
            MessageBox.Show("La mesa se Elimino Correctamente");
        }

        
    }
}
