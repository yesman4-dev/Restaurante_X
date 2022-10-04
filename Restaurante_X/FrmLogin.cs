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
    public partial class FrmLogin : Form
    {
        DC_Restaurante_XDataContext db = new DC_Restaurante_XDataContext();

        public string Usuario { get; set; }
       

        public FrmLogin()
        {
            InitializeComponent();
            TxtUser.Focus();
        }


        private void Login()
        {

            var contra = ClsCripPass.Encrypt.GetMD5(TxtPass.Text);
            var username = TxtUser.Text;

            var existeUser = (from user in db.Usuario
                              where user.Usuario1 == username && user.Contraseña == contra
                              select user.Usuario1).Count();

           
         



            if (existeUser == 0)
            {
                MessageBox.Show("Contraseña o Usuario incorrecto");
                TxtUser.Text = TxtUser.Text;
                TxtPass.Text = "";
                TxtPass.Focus();

                
            }
            else if (existeUser != 0)
            {
                var idUser = (from user in db.Usuario
                              where user.Usuario1 == TxtUser.Text
                              select user.IdUsuario).FirstOrDefault();

                var CodEmpleado = (from user in db.Usuario
                                   where user.Usuario1 == TxtUser.Text
                                   select user.CodEmpleado).FirstOrDefault();

                var EstadoUsuario = (from user in db.Usuario
                                     where user.Usuario1 == TxtUser.Text
                                     select user.IdEstadoUsuario).FirstOrDefault();

                var TipoUsuario = (from user in db.Usuario
                                   where user.Usuario1 == TxtUser.Text
                                   select user.IdTipoUsuario).FirstOrDefault();

                //var UltimoLogin = (from user in db.Usuario
                //                   where user.Usuario1 == TxtUser.Text
                //                   select user.Ultimo_Login).FirstOrDefault();

                ClsLog.IdUsuario = idUser;
                ClsLog.Usuario = Usuario;
                ClsLog.CodEmpleado = Convert.ToInt32(CodEmpleado);
                ClsLog.Estado = Convert.ToInt32(EstadoUsuario);
                ClsLog.Tipo_de_Usuario = Convert.ToInt32(TipoUsuario);
                //ClsLog.Ultimo_Login = Convert.ToDateTime(UltimoLogin);
                ClsLog.Time_Login = DateTime.Now.ToLongTimeString();


                MDI mdi = new MDI();
                this.Hide();
                mdi.ShowDialog();
                this.Close();
            }

           
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void CkbVerPass_CheckedChanged(object sender, EventArgs e)
        {
            //if(CkbVerPass.Checked)
            //{
            //    TxtPass.UseSystemPasswordChar = false;
            //    TxtPass.PasswordChar = '\0';
            //}
            //else
            //{
            //    TxtPass.UseSystemPasswordChar = true;
            //}
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) ==13)
            {
                Login();
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Login();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }

    
}
    
