namespace Restaurante_X
{
    partial class FrmEstadoMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadoMesas));
            this.TxtEstadoMesa = new System.Windows.Forms.TextBox();
            this.DgvEstadosMesas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNombreForm = new System.Windows.Forms.Label();
            this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadosMesas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEstadoMesa
            // 
            this.TxtEstadoMesa.BackColor = System.Drawing.SystemColors.Info;
            this.TxtEstadoMesa.Enabled = false;
            this.TxtEstadoMesa.Location = new System.Drawing.Point(15, 100);
            this.TxtEstadoMesa.Name = "TxtEstadoMesa";
            this.TxtEstadoMesa.Size = new System.Drawing.Size(134, 20);
            this.TxtEstadoMesa.TabIndex = 72;
            // 
            // DgvEstadosMesas
            // 
            this.DgvEstadosMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstadosMesas.Location = new System.Drawing.Point(15, 137);
            this.DgvEstadosMesas.MultiSelect = false;
            this.DgvEstadosMesas.Name = "DgvEstadosMesas";
            this.DgvEstadosMesas.ReadOnly = true;
            this.DgvEstadosMesas.RowHeadersVisible = false;
            this.DgvEstadosMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEstadosMesas.Size = new System.Drawing.Size(183, 183);
            this.DgvEstadosMesas.TabIndex = 70;
            this.DgvEstadosMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstadosMesas_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.BtnNuevo);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Location = new System.Drawing.Point(227, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 209);
            this.panel1.TabIndex = 69;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarMesa.ImageOptions.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(14, 126);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(98, 33);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarMesa.ImageOptions.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(14, 48);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 33);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarMesa.ImageOptions.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(14, 87);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(98, 33);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Estado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.LblNombreForm);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 62);
            this.panel2.TabIndex = 62;
            // 
            // LblNombreForm
            // 
            this.LblNombreForm.AutoSize = true;
            this.LblNombreForm.BackColor = System.Drawing.Color.Navy;
            this.LblNombreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombreForm.Location = new System.Drawing.Point(57, 9);
            this.LblNombreForm.Name = "LblNombreForm";
            this.LblNombreForm.Size = new System.Drawing.Size(279, 33);
            this.LblNombreForm.TabIndex = 4;
            this.LblNombreForm.Text = " Estados de Mesas";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(14, 9);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(98, 33);
            this.BtnNuevo.TabIndex = 29;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(14, 165);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 33);
            this.BtnLimpiar.TabIndex = 30;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmEsatdoMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 334);
            this.Controls.Add(this.TxtEstadoMesa);
            this.Controls.Add(this.DgvEstadosMesas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEsatdoMesas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadosMesas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEstadoMesa;
        private System.Windows.Forms.DataGridView DgvEstadosMesas;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BtnEliminar;
        private DevExpress.XtraEditors.SimpleButton BtnAgregar;
        private DevExpress.XtraEditors.SimpleButton BtnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblNombreForm;
        private DevExpress.XtraEditors.SimpleButton BtnLimpiar;
        private DevExpress.XtraEditors.SimpleButton BtnNuevo;
    }
}