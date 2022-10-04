namespace Restaurante_X
{
    partial class FrmEstablecimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstablecimiento));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.DgvAgencia = new System.Windows.Forms.DataGridView();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRTN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEstablecimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgencia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnLimpiar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Controls.Add(this.TxtBusqueda);
            this.panel2.Location = new System.Drawing.Point(739, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 227);
            this.panel2.TabIndex = 63;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(175, 28);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(24, 27);
            this.BtnBuscar.TabIndex = 46;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.ImageOptions.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(31, 62);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(119, 31);
            this.BtnNuevo.TabIndex = 23;
            this.BtnNuevo.Text = "Nuevo";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.ImageOptions.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(31, 177);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(119, 31);
            this.BtnLimpiar.TabIndex = 22;
            this.BtnLimpiar.Text = "Limpiar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Busqueda:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.ImageOptions.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(31, 140);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(119, 31);
            this.BtnActualizar.TabIndex = 5;
            this.BtnActualizar.Text = "Actualizar";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.ImageOptions.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(31, 99);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(119, 31);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(10, 32);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(160, 20);
            this.TxtBusqueda.TabIndex = 3;
            // 
            // DgvAgencia
            // 
            this.DgvAgencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgencia.Location = new System.Drawing.Point(8, 332);
            this.DgvAgencia.Name = "DgvAgencia";
            this.DgvAgencia.ReadOnly = true;
            this.DgvAgencia.Size = new System.Drawing.Size(936, 229);
            this.DgvAgencia.TabIndex = 61;
            // 
            // TxtDir
            // 
            this.TxtDir.Location = new System.Drawing.Point(433, 116);
            this.TxtDir.Multiline = true;
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(274, 83);
            this.TxtDir.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Dirección";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(220, 151);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(179, 20);
            this.TxtCorreo.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Correo de la empresa:";
            // 
            // MskTelefono
            // 
            this.MskTelefono.Location = new System.Drawing.Point(220, 202);
            this.MskTelefono.Mask = "0000-0000";
            this.MskTelefono.Name = "MskTelefono";
            this.MskTelefono.Size = new System.Drawing.Size(121, 20);
            this.MskTelefono.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Telefono:";
            // 
            // TxtCod
            // 
            this.TxtCod.BackColor = System.Drawing.SystemColors.Info;
            this.TxtCod.Enabled = false;
            this.TxtCod.Location = new System.Drawing.Point(220, 100);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(62, 20);
            this.TxtCod.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Codigo de el establecimiento:";
            // 
            // TxtRTN
            // 
            this.TxtRTN.Location = new System.Drawing.Point(19, 202);
            this.TxtRTN.Name = "TxtRTN";
            this.TxtRTN.Size = new System.Drawing.Size(179, 20);
            this.TxtRTN.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "RTN:";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(19, 151);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(179, 20);
            this.TxtEmpresa.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre de la Empresa:";
            // 
            // TxtEstablecimiento
            // 
            this.TxtEstablecimiento.Location = new System.Drawing.Point(19, 100);
            this.TxtEstablecimiento.Name = "TxtEstablecimiento";
            this.TxtEstablecimiento.Size = new System.Drawing.Size(179, 20);
            this.TxtEstablecimiento.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre del Establecimiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 68);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(362, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Establecimiento";
            // 
            // FrmEstablecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgvAgencia);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MskTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEstablecimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEstablecimiento";
            this.Text = "FrmEstablecimiento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton BtnBuscar;
        private DevExpress.XtraEditors.SimpleButton BtnNuevo;
        private DevExpress.XtraEditors.SimpleButton BtnLimpiar;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton BtnActualizar;
        private DevExpress.XtraEditors.SimpleButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView DgvAgencia;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MskTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEstablecimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}