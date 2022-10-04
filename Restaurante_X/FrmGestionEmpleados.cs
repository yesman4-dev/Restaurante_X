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
    public partial class FrmGestionEmpleados : Form
    {
        DC_Restaurante_XDataContext db = new DC_Restaurante_XDataContext();

        public FrmGestionEmpleados()
        {
            InitializeComponent();
            cargarEmpleados();
            cbosexo();
            cbomuni();
            cbocargo();
            cbodepart();
        }


        private void cbosexo()
        {
            var cbosex = (from sexo in db.Sexo
                           select new { IdSex = sexo.IdSexo, Sex = sexo.Sexo1 });


            CboSexo.DataSource = cbosex;
            CboSexo.DisplayMember = "Sex";
            CboSexo.ValueMember = "IdSex";
        }

        private void cbomuni()
        {
            var cbomuni = (from muni in db.Municipio
                          select new { Idmuni = muni.IdMunicipio, Muni = muni.Municipio1 });


            CboMunicipio.DataSource = cbomuni;
            CboMunicipio.DisplayMember = "Muni";
            CboMunicipio.ValueMember = "Idmuni";
        }

        private void cbocargo()
        {
            var cbocargo = (from cargo in db.Cargo
                          select new { IdCarg = cargo.IdCargo, Carg = cargo.Cargo1 });


            CboCargo.DataSource = cbocargo;
            CboCargo.DisplayMember = "Carg";
            CboCargo.ValueMember = "IdCarg";
        }

        private void cbodepart()
        {
            var cbodepatament = (from depar in db.Departamento
                          select new { IdDepar = depar.IdDepto, Depar = depar.Departamento1 });


            CboDepartamento.DataSource = cbodepatament;
            CboDepartamento.DisplayMember = "Depar";
            CboDepartamento.ValueMember = "IdDepar";
        }

        private void cargarEmpleados()
        {
            var grid = (from empleados in db.Empleado
                        join municipio in db.Municipio
                        on empleados.IdMunicipio equals municipio.IdMunicipio
                        join Departamento in db.Departamento
                        on municipio.IdDepto equals Departamento.IdDepto
                        join cargo in db.Cargo 
                        on empleados.IdCargo equals cargo.IdCargo
                        join sexo in db.Sexo
                        on empleados.IdSexo equals sexo.IdSexo
                        select new { Identidad = empleados.IdEmpleado,
                            Nombres = empleados.Nombre,
                            Apellidos = empleados.Apellido,
                            Cargo = cargo.Cargo1,
                            Sexo = sexo.Sexo1,
                            Estado = "Estado",
                            Direccion = empleados.Direccion,
                            Telefono = empleados.Telefono,
                            Municipio = municipio.Municipio1,
                            Departamento = Departamento.Departamento1
                            });
            DgvEmpleados.DataSource = grid;
        }


        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var Identidad = DgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();

            var cod = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select _emp.CodEmpleado).FirstOrDefault();

            var id = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                       where _emp.IdEmpleado == Identidad
                       select  _emp.IdEmpleado).FirstOrDefault();

            var Nombres = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select _emp.Nombre).FirstOrDefault();
            var Apellidos = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select _emp.Apellido).FirstOrDefault();

            var Direccion = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select _emp.Direccion ).FirstOrDefault();

            var Telefono = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select _emp.Telefono).FirstOrDefault();

            var Cargo = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select  _emp.Cargo).FirstOrDefault();

            var Sexo = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select sex.Sexo1).FirstOrDefault();

            var Municipio = (from _emp in db.Empleado
                      join sex in db.Sexo
                      on _emp.IdSexo equals sex.IdSexo
                      join mun in db.Municipio
                      on _emp.IdMunicipio equals mun.IdMunicipio
                      join dep in db.Departamento
                      on mun.IdMunicipio equals dep.IdDepto
                      where _emp.IdEmpleado == Identidad
                      select mun.Municipio1 ).FirstOrDefault();

            var Departamento = (from _emp in db.Empleado
                          join sex in db.Sexo
                          on _emp.IdSexo equals sex.IdSexo
                          join mun in db.Municipio
                          on _emp.IdMunicipio equals mun.IdMunicipio
                          join dep in db.Departamento
                          on mun.IdMunicipio equals dep.IdDepto
                          where _emp.IdEmpleado == Identidad
                          select dep.Departamento1 ).FirstOrDefault();
            
            MscIdentidad.Text = id.ToString();
            TxtNombres.Text = Nombres.ToString();
            TxtApeliidos.Text = Apellidos.ToString();
            TxtDirec.Text = Direccion.ToString();
            MskNumero.Text = Telefono.ToString();
            CboCargo.Text = Cargo.ToString();
            CboEstado.Text = "Estado";
            CboSexo.Text = Sexo.ToString();
            CboMunicipio.Text = Municipio.ToString();
            CboDepartamento.Text = Departamento.ToString();

        }

        private void DgvEmpleados_CellMouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    ContextMenu m = new ContextMenu();

            //    m.MenuItems.Add(new MenuItem("Modificar"));

            //    int currentMouseOverRow = DgvEmpleados.HitTest(e.X, e.Y).RowIndex;

            //    if (currentMouseOverRow >= 0)
            //    {
            //        m.MenuItems.Add(new MenuItem(string.Format("Do someting to row {0}", currentMouseOverRow.ToString())));
            //    }

            //    m.Show(DgvEmpleados, new Point(e.X, e.Y));

            //}


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            var existIdent = (from _ident in db.Empleado
                              where _ident.IdEmpleado == MscIdentidad.Text
                              select _ident.IdEmpleado).FirstOrDefault();

            if (existIdent == MscIdentidad.Text)
            {
                MessageBox.Show("Ya se ha registrado otro empleado con ese numero de identidad");
                MscIdentidad.Focus();
            }
            else
            {

                Empleado emp = new Empleado();

                var codemp = (from emple in db.Empleado
                              select emple).Count();


                int correlativo = Convert.ToInt32(codemp + 1);

                emp.CodEmpleado = correlativo;
                emp.IdEmpleado = MscIdentidad.Text;
                emp.Nombre = TxtNombres.Text;
                emp.Apellido = TxtApeliidos.Text;
                emp.Telefono = MskNumero.Text;
                emp.Direccion = TxtDirec.Text;
                emp.IdMunicipio = 1;
                emp.IdCargo = 1;
                emp.IdSexo = 1;

                db.Empleado.InsertOnSubmit(emp);
                db.SubmitChanges();

                cargarEmpleados();
                MessageBox.Show("El Empleado se Registro Correctamente");

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ////get employee to update
            //Empleado emp = db.Empleado.FirstOrDefault(empl => empl.CodEmpleado.Equals(TxtCodEmpl.Text));

            
            //emp.IdEmpleado = MscIdentidad.Text;
            //emp.Nombre = TxtNombres.Text;
            //emp.Apellido = TxtApeliidos.Text;
            //emp.Telefono = MskNumero.Text;
            //emp.Direccion = TxtDirec.Text;
            //emp.IdMunicipio = 1;
            //emp.IdCargo = 1;
            //emp.IdSexo = 1;

            ////Save changes to Database.
            //db.SubmitChanges();

            //cargarEmpleados();

            //MessageBox.Show("El Empleado se Actualizo Correctamente");
        }
        


        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
        

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //ch.UseSystemPasswordChar = true;
        }
        

        private void TxtBuscarEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtBuscarEmp.Text == "")
            {
                cargarEmpleados();
            }
            else
            {
                if (TxtBuscarEmp.Text.Any(x => !char.IsNumber(x)))
                {
                    var buscar = (from emp in db.Empleado
                                  where emp.Nombre.StartsWith(TxtBuscarEmp.Text) || emp.Apellido.StartsWith(TxtBuscarEmp.Text)
                                  select new { Identidad = emp.IdEmpleado, Nombres = emp.Nombre, Apellidos = emp.Apellido, cargo = emp.Cargo, sexo = emp.IdSexo, Estado = 1, Direccion = emp.Direccion, Telefono = emp.Telefono, Municipio = emp.IdMunicipio });

                    DgvEmpleados.DataSource = buscar;
                }
                else
                {
                    var buscar = (from emp in db.Empleado
                                  where emp.IdEmpleado.StartsWith(TxtBuscarEmp.Text)
                                  select new { Identidad = emp.IdEmpleado, Nombres = emp.Nombre, Apellidos = emp.Apellido, cargo = emp.Cargo, sexo = emp.IdSexo, Estado = 1, Direccion = emp.Direccion, Telefono = emp.Telefono, Municipio = emp.IdMunicipio });

                    DgvEmpleados.DataSource = buscar;


                }

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
