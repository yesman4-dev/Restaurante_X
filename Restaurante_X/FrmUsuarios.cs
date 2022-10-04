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
    public partial class FmrUsuarios : Form
    {
        DC_Restaurante_XDataContext db = new DC_Restaurante_XDataContext();
        public int _idusuario { get; set; }
        public string _nameUsuario { get; set; }
        public FmrUsuarios()
        {
            InitializeComponent();
            
            cboestado();
            cbotipousr();
            cboemp();
        }

        private void obj_bloqueados()
        {
            TxtUsr.Enabled = false;
            TxtPass.Enabled = false;
            TxtConfirPass.Enabled = false;
            CboTipoUsr.Enabled = false;
            CboEmpleado.Enabled = false;
            CboEstadoUsr.Enabled = false;

        }

        private void obj_activados()
        {
            TxtUsr.Enabled = true;
            TxtPass.Enabled = true;
            TxtConfirPass.Enabled = true;
            CboTipoUsr.Enabled = true;
            CboEmpleado.Enabled = true;
            CboEstadoUsr.Enabled = true;

        }

        private void limpiar()
        {
            TxtUsr.Text = "";
            TxtPass.Text = "";
            TxtConfirPass.Text = "";
            CboTipoUsr.Text = "";
            CboEmpleado.Text = "";
            CboEstadoUsr.Text = "";
            TxtPassActual.Text = "";
           
            

        }


        private void cboestado()
        {
            var cboest = (from EstadoUsuario in db.EstadoUsuario
                          select new { IdEstUsr = EstadoUsuario.IdEstadoUsuario, estUsr = EstadoUsuario.EstadoUsuario1 });


            CboEstadoUsr.DataSource = cboest;
            CboEstadoUsr.DisplayMember = "estUsr";
            CboEstadoUsr.ValueMember = "IdEstUsr";
        }

        private void cbotipousr()
        {
            var cbotipousr = (from TipoUsuario in db.TipoUsuario
                          select new { IdTipoUsr = TipoUsuario.IdTipoUsuario, TipoUsr = TipoUsuario.TipoUsuario1 });


            CboTipoUsr.DataSource = cbotipousr;
            CboTipoUsr.DisplayMember = "TipoUsr";
            CboTipoUsr.ValueMember = "IdTipoUsr";
        }

        private void cboemp()
        {
            var cboemp = (from Empleado in db.Empleado
                              select new { codemp = Empleado.CodEmpleado, emp = Empleado.Nombre + ' ' + Empleado.Apellido });


            CboEmpleado.DataSource = cboemp;
            CboEmpleado.DisplayMember = "emp";
            CboEmpleado.ValueMember = "Codemp";
        }

        private void llenarUsuario()
        {
            var grid = (from user in db.Usuario

                        join emp in db.Empleado
                        on user.CodEmpleado equals emp.CodEmpleado

                        join est in db.EstadoUsuario
                        on user.IdEstadoUsuario equals est.IdEstadoUsuario

                        join tip in db.TipoUsuario
                        on user.IdTipoUsuario equals tip.IdTipoUsuario

                        select new { Usuario = user.Usuario1, Empleado = emp.Nombre, Estado = est.EstadoUsuario1, Tipo = tip.TipoUsuario1 });

            Dgvuser.DataSource = grid;


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscarUsr.Text=="")
            {
                llenarUsuario();
            }
            else
            {
                var grid = (from user in db.Usuario

                            join emp in db.Empleado
                            on user.CodEmpleado equals emp.CodEmpleado

                            join est in db.EstadoUsuario
                            on user.IdEstadoUsuario equals est.IdEstadoUsuario

                            join tip in db.TipoUsuario
                            on user.IdTipoUsuario equals tip.IdTipoUsuario

                            where user.Usuario1.StartsWith(TxtBuscarUsr.Text) || emp.Nombre.StartsWith(TxtBuscarUsr.Text)

                            select new { Usuario = user.Usuario1, Empleado = emp.Nombre, Estado = est.EstadoUsuario1, Tipo = tip.TipoUsuario1 });

                Dgvuser.DataSource = grid;
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            var existeUser = (from _user in db.Usuario
                              where _user.Usuario1 == TxtUsr.Text
                              select _user.Usuario1).FirstOrDefault();

            if (existeUser == TxtUsr.Text)
            {
                MessageBox.Show("Ese nombre de usuario ya existe");
                TxtUsr.Focus();
            }
            else
            {
                Usuario user = new Usuario();

                var iduser = (from _user in db.Usuario
                              select _user).Count();


                int correlativo = Convert.ToInt32(iduser + 1);

                user.IdUsuario = correlativo;
                user.Usuario1 = TxtUsr.Text;
                user.Contraseña = ClsCripPass.Encrypt.GetMD5(TxtConfirPass.Text);
                user.CodEmpleado = Convert.ToInt32(CboEmpleado.SelectedValue);
                user.IdEstadoUsuario = Convert.ToInt32(CboEstadoUsr.SelectedValue);
                user.IdTipoUsuario = Convert.ToInt32(CboTipoUsr.SelectedValue);

                db.Usuario.InsertOnSubmit(user);
                db.SubmitChanges();

                llenarUsuario();
                MessageBox.Show("El usuario se ingreso Correctamente");
            }



            
        }

        private void Dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nuser = Dgvuser.Rows[e.RowIndex].Cells[0].Value.ToString();


            var codigo = (from user in db.Usuario
                               join emp in db.Empleado
                               on user.CodEmpleado equals emp.CodEmpleado
                               join est in db.EstadoUsuario
                               on user.IdEstadoUsuario equals est.IdEstadoUsuario
                               join tip in db.TipoUsuario
                               on user.IdTipoUsuario equals tip.IdTipoUsuario
                               where user.Usuario1 == nuser
                               select user.IdUsuario).FirstOrDefault();


            _idusuario = Convert.ToInt32(codigo);

            var usuario = (from user in db.Usuario
                       join emp in db.Empleado
                       on user.CodEmpleado equals emp.CodEmpleado
                       join est in db.EstadoUsuario
                       on user.IdEstadoUsuario equals est.IdEstadoUsuario
                       join tip in db.TipoUsuario
                       on user.IdTipoUsuario equals tip.IdTipoUsuario
                       where user.Usuario1 == nuser
                       select user.Usuario1).FirstOrDefault();

            _nameUsuario = Convert.ToString(usuario);

            var passactual = (from user in db.Usuario
                       join emp in db.Empleado
                       on user.CodEmpleado equals emp.CodEmpleado
                       join est in db.EstadoUsuario
                       on user.IdEstadoUsuario equals est.IdEstadoUsuario
                       join tip in db.TipoUsuario
                       on user.IdTipoUsuario equals tip.IdTipoUsuario
                       where user.Usuario1 == nuser
                       select user.Contraseña).FirstOrDefault();

            var empl = (from user in db.Usuario
                              join emp in db.Empleado
                              on user.CodEmpleado equals emp.CodEmpleado
                              join est in db.EstadoUsuario
                              on user.IdEstadoUsuario equals est.IdEstadoUsuario
                              join tip in db.TipoUsuario
                              on user.IdTipoUsuario equals tip.IdTipoUsuario
                              where user.Usuario1 == nuser
                              select emp.Nombre).FirstOrDefault();

            var tp = (from user in db.Usuario
                        join emp in db.Empleado
                        on user.CodEmpleado equals emp.CodEmpleado
                        join est in db.EstadoUsuario
                        on user.IdEstadoUsuario equals est.IdEstadoUsuario
                        join tip in db.TipoUsuario
                        on user.IdTipoUsuario equals tip.IdTipoUsuario
                        where user.Usuario1 == nuser
                        select tip.TipoUsuario1).FirstOrDefault();

            var st = (from user in db.Usuario
                      join emp in db.Empleado
                      on user.CodEmpleado equals emp.CodEmpleado
                      join est in db.EstadoUsuario
                      on user.IdEstadoUsuario equals est.IdEstadoUsuario
                      join tip in db.TipoUsuario
                      on user.IdTipoUsuario equals tip.IdTipoUsuario
                      where user.Usuario1 == nuser
                      select est.EstadoUsuario1).FirstOrDefault();


            TxtUsr.Text = usuario.ToString();
            TxtPassActual.Text = passactual.ToString();
            CboEmpleado.Text = empl.ToString();
            CboTipoUsr.Text = tp.ToString();
            CboEstadoUsr.Text = st.ToString();
        }

        private void LblConfAvanzadauser_Click(object sender, EventArgs e)
        {
            FrmUssAdmin frmUssAdmin = new FrmUssAdmin();
            frmUssAdmin.ShowDialog();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            obj_activados();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            obj_bloqueados();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Usuario user = db.Usuario.FirstOrDefault(userl => userl.IdUsuario.Equals(_idusuario));



            var idusername = (from _user in db.Usuario
                              where _user.Usuario1 == TxtUsr.Text
                              select _user.IdUsuario).FirstOrDefault();

            var existeUser = (from _user in db.Usuario
                              where _user.Usuario1 == TxtUsr.Text
                              select _user.IdUsuario).Count();

            //MessageBox.Show($"{existeUser}");

            if (Convert.ToInt32(idusername) == _idusuario && TxtUsr.Text == _nameUsuario && Convert.ToInt32(existeUser) != 0)
            {
                MessageBox.Show($"{_idusuario} lol");

                llenarUsuario();


                user.Usuario1 = TxtUsr.Text;
                user.Contraseña = ClsCripPass.Encrypt.GetMD5(TxtConfirPass.Text);
                user.IdEstadoUsuario = Convert.ToInt32(CboEstadoUsr.SelectedValue);
                user.IdTipoUsuario = Convert.ToInt32(CboTipoUsr.SelectedValue);


                db.SubmitChanges();

               



                MessageBox.Show("El usuario se ingreso Correctamente");
                llenarUsuario();
            }
            else if (Convert.ToInt32(existeUser) != 0  )
            {
                MessageBox.Show("El usaername que quiere utilizar ya existe");

                TxtUsr.Focus();
            }
            else if (Convert.ToInt32(existeUser) == 0 )
            {

                user.Usuario1 = TxtUsr.Text;
                user.Contraseña = ClsCripPass.Encrypt.GetMD5(TxtConfirPass.Text);
                user.IdEstadoUsuario = Convert.ToInt32(CboEstadoUsr.SelectedValue);
                user.IdTipoUsuario = Convert.ToInt32(CboTipoUsr.SelectedValue);


                db.SubmitChanges();




                MessageBox.Show("El usuario se ingreso Correctamente");
                llenarUsuario();

                llenarUsuario();
            }







            


        }

        private void TxtConfirPass_TextChanged(object sender, EventArgs e)
        {
            if (TxtPass.Text == TxtConfirPass.Text)
            {
                PicConfirmar.Visible = true;
                PicConfirx.Visible = false;
            }
            else if (TxtPass.Text != TxtConfirPass.Text)
            {
                PicConfirmar.Visible = false;
                PicConfirx.Visible = true;
            }
            else if (TxtPass.Text == "" && TxtConfirPass.Text == "")
            {
                PicConfirmar.Visible = false;
                PicConfirx.Visible = true;
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            if (TxtPass.Text == TxtConfirPass.Text)
            {
                PicConfirmar.Visible = true;
                PicConfirx.Visible = false;
            }
            else if (TxtPass.Text != TxtConfirPass.Text)
            {
                PicConfirmar.Visible = false;
                PicConfirx.Visible = true;
            }
            else if (TxtPass.Text == "" && TxtConfirPass.Text == "")
            {
                PicConfirmar.Visible = false;
                PicConfirx.Visible = true;
            }
        }

        private void TxtBuscarUsr_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarUsr.Text == "")
            {
                llenarUsuario();
            }
            else
            {
                var grid = (from user in db.Usuario

                            join emp in db.Empleado
                            on user.CodEmpleado equals emp.CodEmpleado

                            join est in db.EstadoUsuario
                            on user.IdEstadoUsuario equals est.IdEstadoUsuario

                            join tip in db.TipoUsuario
                            on user.IdTipoUsuario equals tip.IdTipoUsuario

                            where user.Usuario1.StartsWith(TxtBuscarUsr.Text) || emp.Nombre.StartsWith(TxtBuscarUsr.Text)

                            select new { Usuario = user.Usuario1, Empleado = emp.Nombre, Estado = est.EstadoUsuario1, Tipo = tip.TipoUsuario1 });

                Dgvuser.DataSource = grid;
            }
        }
    }
}
