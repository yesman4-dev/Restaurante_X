namespace Restaurante_X
{
    partial class FrmGestionEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBuscarEmp = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNombreForm = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApeliidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDirec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboMunicipio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CboCargo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.MscIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.MskNumero = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnNuevo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtBuscarEmp);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Location = new System.Drawing.Point(620, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 242);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.ImageOptions.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(47, 71);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(98, 33);
            this.BtnNuevo.TabIndex = 29;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Busque por Nombres, apellido, identidad: ";
            // 
            // TxtBuscarEmp
            // 
            this.TxtBuscarEmp.Location = new System.Drawing.Point(6, 38);
            this.TxtBuscarEmp.Name = "TxtBuscarEmp";
            this.TxtBuscarEmp.Size = new System.Drawing.Size(185, 20);
            this.TxtBuscarEmp.TabIndex = 26;
            this.TxtBuscarEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarEmp_KeyPress);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(47, 153);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(98, 33);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Agregar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(47, 192);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(98, 33);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Modificar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.ImageOptions.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(47, 112);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 33);
            this.BtnLimpiar.TabIndex = 0;
            this.BtnLimpiar.Text = "limpiar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.LblNombreForm);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 62);
            this.panel2.TabIndex = 2;
            // 
            // LblNombreForm
            // 
            this.LblNombreForm.AutoSize = true;
            this.LblNombreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombreForm.Location = new System.Drawing.Point(199, 11);
            this.LblNombreForm.Name = "LblNombreForm";
            this.LblNombreForm.Size = new System.Drawing.Size(396, 42);
            this.LblNombreForm.TabIndex = 3;
            this.LblNombreForm.Text = "Gestion de Empleado";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(11, 124);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(185, 20);
            this.TxtNombres.TabIndex = 3;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Location = new System.Drawing.Point(12, 366);
            this.DgvEmpleados.MultiSelect = false;
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            this.DgvEmpleados.RowHeadersVisible = false;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(807, 204);
            this.DgvEmpleados.TabIndex = 4;
            this.DgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellClick);
            this.DgvEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmpleados_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // TxtApeliidos
            // 
            this.TxtApeliidos.Location = new System.Drawing.Point(209, 124);
            this.TxtApeliidos.Name = "TxtApeliidos";
            this.TxtApeliidos.Size = new System.Drawing.Size(184, 20);
            this.TxtApeliidos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "N. Identidad del Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dirección";
            // 
            // TxtDirec
            // 
            this.TxtDirec.Location = new System.Drawing.Point(12, 279);
            this.TxtDirec.Multiline = true;
            this.TxtDirec.Name = "TxtDirec";
            this.TxtDirec.Size = new System.Drawing.Size(297, 59);
            this.TxtDirec.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefono";
            // 
            // CboMunicipio
            // 
            this.CboMunicipio.FormattingEnabled = true;
            this.CboMunicipio.Location = new System.Drawing.Point(11, 225);
            this.CboMunicipio.Name = "CboMunicipio";
            this.CboMunicipio.Size = new System.Drawing.Size(121, 21);
            this.CboMunicipio.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Municipio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Departamento";
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(150, 225);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(121, 21);
            this.CboDepartamento.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cargo";
            // 
            // CboCargo
            // 
            this.CboCargo.FormattingEnabled = true;
            this.CboCargo.Location = new System.Drawing.Point(285, 225);
            this.CboCargo.Name = "CboCargo";
            this.CboCargo.Size = new System.Drawing.Size(121, 21);
            this.CboCargo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Estado";
            // 
            // CboEstado
            // 
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(415, 225);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(121, 21);
            this.CboEstado.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Sexo";
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(359, 176);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(121, 21);
            this.CboSexo.TabIndex = 24;
            // 
            // MscIdentidad
            // 
            this.MscIdentidad.Location = new System.Drawing.Point(11, 177);
            this.MscIdentidad.Mask = "0000-0000-00000";
            this.MscIdentidad.Name = "MscIdentidad";
            this.MscIdentidad.Size = new System.Drawing.Size(129, 20);
            this.MscIdentidad.TabIndex = 27;
            // 
            // MskNumero
            // 
            this.MskNumero.Location = new System.Drawing.Point(209, 177);
            this.MskNumero.Mask = "0000-0000";
            this.MskNumero.Name = "MskNumero";
            this.MskNumero.Size = new System.Drawing.Size(129, 20);
            this.MskNumero.TabIndex = 28;
            // 
            // FrmGestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 582);
            this.Controls.Add(this.MskNumero);
            this.Controls.Add(this.MscIdentidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CboCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboDepartamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboMunicipio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDirec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApeliidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvEmpleados);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton BtnLimpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblNombreForm;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApeliidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDirec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboCargo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBuscarEmp;
        private System.Windows.Forms.MaskedTextBox MscIdentidad;
        private System.Windows.Forms.MaskedTextBox MskNumero;
        private DevExpress.XtraEditors.SimpleButton BtnNuevo;
    }
}