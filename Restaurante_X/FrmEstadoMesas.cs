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
    public partial class FrmEstadoMesas : Form
    {
        public int idestadomesa { get; set; }
        DC_Restaurante_XDataContext db = new DC_Restaurante_XDataContext();

        public FrmEstadoMesas()
        {
            InitializeComponent();
            llenarEstados();
        }

        private void llenarEstados()
        {
            var llenarestado = (from est in db.EstadoMesa
                                select new { Estado =  est.EstadoMesa1});

            DgvEstadosMesas.DataSource = llenarestado;
        }

        private void limpiar()
        {
            TxtEstadoMesa.Text = "";
           
        }

        private void Obj_Desactivado()
        {
            TxtEstadoMesa.Enabled = false;
            TxtEstadoMesa.BackColor = SystemColors.Info;
        }

        private void Obj_Activado()
        {
            TxtEstadoMesa.Enabled = true;
            TxtEstadoMesa.BackColor = SystemColors.Window;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            Obj_Activado();
            TxtEstadoMesa.Focus();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            Obj_Desactivado();
        }

        private void DgvEstadosMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var estado = DgvEstadosMesas.Rows[e.RowIndex].Cells[0].Value.ToString();

            TxtEstadoMesa.Text = estado;


            var id = (from est in db.EstadoMesa
                      where est.EstadoMesa1 == estado
                      select est.IdEstadoMesa).FirstOrDefault();

            idestadomesa = Convert.ToInt32( id);


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EstadoMesa estado = new EstadoMesa();

            var idest = (from _est in db.EstadoMesa
                          select _est).Count();


            int correlativo = Convert.ToInt32(idest + 1);

            estado.IdEstadoMesa = correlativo;
            estado.EstadoMesa1 =  TxtEstadoMesa.Text;
            

            db.EstadoMesa.InsertOnSubmit(estado);
            db.SubmitChanges();

            llenarEstados();
            MessageBox.Show("el estado se registro Correctamente");
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EstadoMesa estado = db.EstadoMesa.FirstOrDefault(estadol => estadol.IdEstadoMesa.Equals(idestadomesa));


            estado.EstadoMesa1 = TxtEstadoMesa.Text;
            

            //Save changes to Database.
            db.SubmitChanges();

            llenarEstados();

            MessageBox.Show("El estado se Actualizo Correctamente");
            limpiar();
            Obj_Desactivado();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {


            //get the employee to delete
            EstadoMesa estado = db.EstadoMesa.FirstOrDefault(estadol => estadol.IdEstadoMesa.Equals(idestadomesa));

            //delete the employee
            db.EstadoMesa.DeleteOnSubmit(estado);

            //save changes to database
            db.SubmitChanges();
            llenarEstados();
            limpiar();
            Obj_Desactivado();
            MessageBox.Show("El estado se Elimino Correctamente");
        }
    }
}
