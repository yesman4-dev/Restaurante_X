namespace Restaurante_X
{
    partial class FrmGestionMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionMesa));
            this.TxtIdMesa = new System.Windows.Forms.TextBox();
            this.TxtMesa = new System.Windows.Forms.TextBox();
            this.DgvMesas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBuscarMesa = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEliminarMesa = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnAgregarMesa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModificarMesa = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtObservacionMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboEstadoMesa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNombreForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMesas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIdMesa
            // 
            this.TxtIdMesa.Location = new System.Drawing.Point(9, 125);
            this.TxtIdMesa.Name = "TxtIdMesa";
            this.TxtIdMesa.Size = new System.Drawing.Size(62, 20);
            this.TxtIdMesa.TabIndex = 61;
            // 
            // TxtMesa
            // 
            this.TxtMesa.Location = new System.Drawing.Point(96, 125);
            this.TxtMesa.Name = "TxtMesa";
            this.TxtMesa.Size = new System.Drawing.Size(62, 20);
            this.TxtMesa.TabIndex = 60;
            // 
            // DgvMesas
            // 
            this.DgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMesas.Location = new System.Drawing.Point(12, 301);
            this.DgvMesas.MultiSelect = false;
            this.DgvMesas.Name = "DgvMesas";
            this.DgvMesas.ReadOnly = true;
            this.DgvMesas.RowHeadersVisible = false;
            this.DgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMesas.Size = new System.Drawing.Size(489, 178);
            this.DgvMesas.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtBuscarMesa);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.BtnEliminarMesa);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.BtnAgregarMesa);
            this.panel1.Controls.Add(this.BtnModificarMesa);
            this.panel1.Location = new System.Drawing.Point(302, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 225);
            this.panel1.TabIndex = 58;
            // 
            // TxtBuscarMesa
            // 
            this.TxtBuscarMesa.Location = new System.Drawing.Point(5, 32);
            this.TxtBuscarMesa.Name = "TxtBuscarMesa";
            this.TxtBuscarMesa.Size = new System.Drawing.Size(185, 20);
            this.TxtBuscarMesa.TabIndex = 30;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(47, 65);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 33);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "Buscar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnEliminarMesa
            // 
            this.BtnEliminarMesa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarMesa.ImageOptions.Image")));
            this.BtnEliminarMesa.Location = new System.Drawing.Point(47, 182);
            this.BtnEliminarMesa.Name = "BtnEliminarMesa";
            this.BtnEliminarMesa.Size = new System.Drawing.Size(98, 33);
            this.BtnEliminarMesa.TabIndex = 28;
            this.BtnEliminarMesa.Text = "Eliminar";
            this.BtnEliminarMesa.Click += new System.EventHandler(this.BtnEliminarMesa_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Nombres ";
            // 
            // BtnAgregarMesa
            // 
            this.BtnAgregarMesa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarMesa.ImageOptions.Image")));
            this.BtnAgregarMesa.Location = new System.Drawing.Point(47, 104);
            this.BtnAgregarMesa.Name = "BtnAgregarMesa";
            this.BtnAgregarMesa.Size = new System.Drawing.Size(98, 33);
            this.BtnAgregarMesa.TabIndex = 2;
            this.BtnAgregarMesa.Text = "Agregar";
            this.BtnAgregarMesa.Click += new System.EventHandler(this.BtnAgregarMesa_Click);
            // 
            // BtnModificarMesa
            // 
            this.BtnModificarMesa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarMesa.ImageOptions.Image")));
            this.BtnModificarMesa.Location = new System.Drawing.Point(47, 143);
            this.BtnModificarMesa.Name = "BtnModificarMesa";
            this.BtnModificarMesa.Size = new System.Drawing.Size(98, 33);
            this.BtnModificarMesa.TabIndex = 1;
            this.BtnModificarMesa.Text = "Modificar";
            this.BtnModificarMesa.Click += new System.EventHandler(this.BtnModificarMesa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Dirección";
            // 
            // TxtObservacionMesa
            // 
            this.TxtObservacionMesa.Location = new System.Drawing.Point(12, 179);
            this.TxtObservacionMesa.Multiline = true;
            this.TxtObservacionMesa.Name = "TxtObservacionMesa";
            this.TxtObservacionMesa.Size = new System.Drawing.Size(274, 59);
            this.TxtObservacionMesa.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Estado";
            // 
            // CboEstadoMesa
            // 
            this.CboEstadoMesa.FormattingEnabled = true;
            this.CboEstadoMesa.Location = new System.Drawing.Point(188, 124);
            this.CboEstadoMesa.Name = "CboEstadoMesa";
            this.CboEstadoMesa.Size = new System.Drawing.Size(98, 21);
            this.CboEstadoMesa.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Mesa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cod Mesa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.LblNombreForm);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 62);
            this.panel2.TabIndex = 51;
            // 
            // LblNombreForm
            // 
            this.LblNombreForm.AutoSize = true;
            this.LblNombreForm.BackColor = System.Drawing.Color.Navy;
            this.LblNombreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombreForm.Location = new System.Drawing.Point(89, 8);
            this.LblNombreForm.Name = "LblNombreForm";
            this.LblNombreForm.Size = new System.Drawing.Size(336, 42);
            this.LblNombreForm.TabIndex = 4;
            this.LblNombreForm.Text = "Gestion de Mesas";
            // 
            // FrmGestionMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 491);
            this.Controls.Add(this.TxtIdMesa);
            this.Controls.Add(this.TxtMesa);
            this.Controls.Add(this.DgvMesas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtObservacionMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboEstadoMesa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Name = "FrmGestionMesa";
            this.Text = "Gestion de Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMesas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdMesa;
        private System.Windows.Forms.TextBox TxtMesa;
        private System.Windows.Forms.DataGridView DgvMesas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBuscarMesa;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnEliminarMesa;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton BtnAgregarMesa;
        private DevExpress.XtraEditors.SimpleButton BtnModificarMesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtObservacionMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEstadoMesa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblNombreForm;
    }
}