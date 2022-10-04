namespace Restaurante_X
{
    partial class FmrUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrUsuarios));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNombreForm = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CboEstadoUsr = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBuscarUsr = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CboTipoUsr = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Dgvuser = new System.Windows.Forms.DataGridView();
            this.LblConfAvanzadauser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConfirPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPassActual = new System.Windows.Forms.TextBox();
            this.PicConfirmar = new DevExpress.XtraEditors.PictureEdit();
            this.PicConfirx = new DevExpress.XtraEditors.PictureEdit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfirmar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfirx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.LblNombreForm);
            this.panel2.Location = new System.Drawing.Point(-30, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 86);
            this.panel2.TabIndex = 3;
            // 
            // LblNombreForm
            // 
            this.LblNombreForm.AutoSize = true;
            this.LblNombreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombreForm.Location = new System.Drawing.Point(225, 17);
            this.LblNombreForm.Name = "LblNombreForm";
            this.LblNombreForm.Size = new System.Drawing.Size(356, 42);
            this.LblNombreForm.TabIndex = 3;
            this.LblNombreForm.Text = "Gestion de Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Estado";
            // 
            // CboEstadoUsr
            // 
            this.CboEstadoUsr.BackColor = System.Drawing.SystemColors.Info;
            this.CboEstadoUsr.Enabled = false;
            this.CboEstadoUsr.FormattingEnabled = true;
            this.CboEstadoUsr.Location = new System.Drawing.Point(394, 253);
            this.CboEstadoUsr.Name = "CboEstadoUsr";
            this.CboEstadoUsr.Size = new System.Drawing.Size(148, 21);
            this.CboEstadoUsr.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Empleado";
            // 
            // CboEmpleado
            // 
            this.CboEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.CboEmpleado.Enabled = false;
            this.CboEmpleado.FormattingEnabled = true;
            this.CboEmpleado.Location = new System.Drawing.Point(7, 253);
            this.CboEmpleado.Name = "CboEmpleado";
            this.CboEmpleado.Size = new System.Drawing.Size(186, 21);
            this.CboEmpleado.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nueva Constraseña:";
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPass.Enabled = false;
            this.TxtPass.Location = new System.Drawing.Point(6, 187);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(132, 20);
            this.TxtPass.TabIndex = 32;
            this.TxtPass.UseSystemPasswordChar = true;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Usuario";
            // 
            // TxtUsr
            // 
            this.TxtUsr.BackColor = System.Drawing.SystemColors.Info;
            this.TxtUsr.Enabled = false;
            this.TxtUsr.Location = new System.Drawing.Point(7, 130);
            this.TxtUsr.Name = "TxtUsr";
            this.TxtUsr.Size = new System.Drawing.Size(185, 20);
            this.TxtUsr.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.BtnNuevo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtBuscarUsr);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Location = new System.Drawing.Point(611, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 288);
            this.panel1.TabIndex = 27;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.ImageOptions.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(47, 235);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 33);
            this.BtnLimpiar.TabIndex = 29;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.ImageOptions.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(47, 116);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(98, 33);
            this.BtnNuevo.TabIndex = 28;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Bucar por nombre o usuario:";
            // 
            // TxtBuscarUsr
            // 
            this.TxtBuscarUsr.Location = new System.Drawing.Point(6, 38);
            this.TxtBuscarUsr.Name = "TxtBuscarUsr";
            this.TxtBuscarUsr.Size = new System.Drawing.Size(185, 20);
            this.TxtBuscarUsr.TabIndex = 26;
            this.TxtBuscarUsr.TextChanged += new System.EventHandler(this.TxtBuscarUsr_TextChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.ImageOptions.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(47, 156);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 33);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.ImageOptions.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(47, 196);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(98, 33);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.ImageOptions.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(47, 75);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 33);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 26;
            // 
            // CboTipoUsr
            // 
            this.CboTipoUsr.BackColor = System.Drawing.SystemColors.Info;
            this.CboTipoUsr.Enabled = false;
            this.CboTipoUsr.FormattingEnabled = true;
            this.CboTipoUsr.Location = new System.Drawing.Point(204, 253);
            this.CboTipoUsr.Name = "CboTipoUsr";
            this.CboTipoUsr.Size = new System.Drawing.Size(176, 21);
            this.CboTipoUsr.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Tipo de usuario";
            // 
            // Dgvuser
            // 
            this.Dgvuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvuser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvuser.Location = new System.Drawing.Point(6, 429);
            this.Dgvuser.MultiSelect = false;
            this.Dgvuser.Name = "Dgvuser";
            this.Dgvuser.ReadOnly = true;
            this.Dgvuser.RowHeadersVisible = false;
            this.Dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvuser.Size = new System.Drawing.Size(807, 204);
            this.Dgvuser.TabIndex = 50;
            this.Dgvuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvuser_CellClick);
            // 
            // LblConfAvanzadauser
            // 
            this.LblConfAvanzadauser.AutoSize = true;
            this.LblConfAvanzadauser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblConfAvanzadauser.Location = new System.Drawing.Point(647, 399);
            this.LblConfAvanzadauser.Name = "LblConfAvanzadauser";
            this.LblConfAvanzadauser.Size = new System.Drawing.Size(122, 13);
            this.LblConfAvanzadauser.TabIndex = 51;
            this.LblConfAvanzadauser.Text = "Configuracion avanzada";
            this.LblConfAvanzadauser.Click += new System.EventHandler(this.LblConfAvanzadauser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Validar constraseña:";
            // 
            // TxtConfirPass
            // 
            this.TxtConfirPass.BackColor = System.Drawing.SystemColors.Info;
            this.TxtConfirPass.Enabled = false;
            this.TxtConfirPass.Location = new System.Drawing.Point(153, 187);
            this.TxtConfirPass.Name = "TxtConfirPass";
            this.TxtConfirPass.Size = new System.Drawing.Size(132, 20);
            this.TxtConfirPass.TabIndex = 52;
            this.TxtConfirPass.UseSystemPasswordChar = true;
            this.TxtConfirPass.TextChanged += new System.EventHandler(this.TxtConfirPass_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Constraseña actual:";
            // 
            // TxtPassActual
            // 
            this.TxtPassActual.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPassActual.Enabled = false;
            this.TxtPassActual.Location = new System.Drawing.Point(205, 130);
            this.TxtPassActual.Name = "TxtPassActual";
            this.TxtPassActual.Size = new System.Drawing.Size(132, 20);
            this.TxtPassActual.TabIndex = 54;
            this.TxtPassActual.UseSystemPasswordChar = true;
            // 
            // PicConfirmar
            // 
            this.PicConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicConfirmar.EditValue = ((object)(resources.GetObject("PicConfirmar.EditValue")));
            this.PicConfirmar.Location = new System.Drawing.Point(289, 187);
            this.PicConfirmar.Name = "PicConfirmar";
            this.PicConfirmar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PicConfirmar.Properties.Appearance.Options.UseBackColor = true;
            this.PicConfirmar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicConfirmar.Size = new System.Drawing.Size(26, 20);
            this.PicConfirmar.TabIndex = 56;
            this.PicConfirmar.Visible = false;
            // 
            // PicConfirx
            // 
            this.PicConfirx.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicConfirx.EditValue = ((object)(resources.GetObject("PicConfirx.EditValue")));
            this.PicConfirx.Location = new System.Drawing.Point(291, 187);
            this.PicConfirx.Name = "PicConfirx";
            this.PicConfirx.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PicConfirx.Properties.Appearance.Options.UseBackColor = true;
            this.PicConfirx.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicConfirx.Size = new System.Drawing.Size(26, 20);
            this.PicConfirx.TabIndex = 57;
            this.PicConfirx.Visible = false;
            // 
            // FmrUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 641);
            this.Controls.Add(this.PicConfirx);
            this.Controls.Add(this.PicConfirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPassActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtConfirPass);
            this.Controls.Add(this.LblConfAvanzadauser);
            this.Controls.Add(this.Dgvuser);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CboTipoUsr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CboEstadoUsr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUsr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "FmrUsuarios";
            this.Text = "Gestion de Usuarios";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfirmar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConfirx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblNombreForm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboEstadoUsr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBuscarUsr;
        private DevExpress.XtraEditors.SimpleButton BtnAgregar;
        private DevExpress.XtraEditors.SimpleButton BtnModificar;
        private DevExpress.XtraEditors.SimpleButton BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTipoUsr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView Dgvuser;
        private System.Windows.Forms.Label LblConfAvanzadauser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtConfirPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPassActual;
        private DevExpress.XtraEditors.SimpleButton BtnNuevo;
        private DevExpress.XtraEditors.SimpleButton BtnLimpiar;
        private DevExpress.XtraEditors.PictureEdit PicConfirmar;
        private DevExpress.XtraEditors.PictureEdit PicConfirx;
    }
}