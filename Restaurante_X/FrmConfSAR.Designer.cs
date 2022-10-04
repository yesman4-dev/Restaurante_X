namespace Restaurante_X
{
    partial class FrmConfSAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfSAR));
            this.TxtNumConf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRangoFinal = new System.Windows.Forms.MaskedTextBox();
            this.TxtCAI = new System.Windows.Forms.MaskedTextBox();
            this.TxtRangoInicial = new System.Windows.Forms.MaskedTextBox();
            this.CboPE = new System.Windows.Forms.ComboBox();
            this.DtpFechaLim = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.DgvConfiguracionSar = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtContador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConfiguracionSar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumConf
            // 
            this.TxtNumConf.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNumConf.Enabled = false;
            this.TxtNumConf.Location = new System.Drawing.Point(115, 73);
            this.TxtNumConf.Name = "TxtNumConf";
            this.TxtNumConf.Size = new System.Drawing.Size(39, 20);
            this.TxtNumConf.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Num. Configuracion:";
            // 
            // TxtRangoFinal
            // 
            this.TxtRangoFinal.Location = new System.Drawing.Point(21, 183);
            this.TxtRangoFinal.Mask = "00000000";
            this.TxtRangoFinal.Name = "TxtRangoFinal";
            this.TxtRangoFinal.Size = new System.Drawing.Size(59, 20);
            this.TxtRangoFinal.TabIndex = 65;
            // 
            // TxtCAI
            // 
            this.TxtCAI.Location = new System.Drawing.Point(19, 286);
            this.TxtCAI.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA-AAAAAA-AA";
            this.TxtCAI.Name = "TxtCAI";
            this.TxtCAI.Size = new System.Drawing.Size(219, 20);
            this.TxtCAI.TabIndex = 64;
            // 
            // TxtRangoInicial
            // 
            this.TxtRangoInicial.Location = new System.Drawing.Point(19, 132);
            this.TxtRangoInicial.Mask = "00000000";
            this.TxtRangoInicial.Name = "TxtRangoInicial";
            this.TxtRangoInicial.Size = new System.Drawing.Size(61, 20);
            this.TxtRangoInicial.TabIndex = 63;
            // 
            // CboPE
            // 
            this.CboPE.FormattingEnabled = true;
            this.CboPE.Location = new System.Drawing.Point(246, 183);
            this.CboPE.Name = "CboPE";
            this.CboPE.Size = new System.Drawing.Size(121, 21);
            this.CboPE.TabIndex = 62;
            // 
            // DtpFechaLim
            // 
            this.DtpFechaLim.Location = new System.Drawing.Point(19, 243);
            this.DtpFechaLim.Name = "DtpFechaLim";
            this.DtpFechaLim.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaLim.TabIndex = 61;
            this.DtpFechaLim.Value = new System.DateTime(2019, 10, 31, 16, 56, 16, 0);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnLimpiar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Controls.Add(this.TxtBusqueda);
            this.panel2.Location = new System.Drawing.Point(521, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 230);
            this.panel2.TabIndex = 60;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.ImageOptions.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(39, 60);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(119, 31);
            this.BtnNuevo.TabIndex = 48;
            this.BtnNuevo.Text = "Nuevo";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.ImageOptions.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(39, 183);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(119, 31);
            this.BtnLimpiar.TabIndex = 47;
            this.BtnLimpiar.Text = "Limpiar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Busqueda:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.ImageOptions.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(39, 144);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(119, 31);
            this.BtnActualizar.TabIndex = 5;
            this.BtnActualizar.Text = "Actualizar";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.ImageOptions.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(39, 101);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(119, 31);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(17, 32);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(179, 20);
            this.TxtBusqueda.TabIndex = 3;
            // 
            // DgvConfiguracionSar
            // 
            this.DgvConfiguracionSar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConfiguracionSar.Location = new System.Drawing.Point(9, 319);
            this.DgvConfiguracionSar.Name = "DgvConfiguracionSar";
            this.DgvConfiguracionSar.Size = new System.Drawing.Size(725, 229);
            this.DgvConfiguracionSar.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Punto de Emision:";
            // 
            // TxtContador
            // 
            this.TxtContador.BackColor = System.Drawing.SystemColors.Window;
            this.TxtContador.Location = new System.Drawing.Point(246, 132);
            this.TxtContador.Name = "TxtContador";
            this.TxtContador.Size = new System.Drawing.Size(82, 20);
            this.TxtContador.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Contador actual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "CAI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha limite de emisón:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Rango final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Rango inicial:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 68);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(242, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion SAR";
            // 
            // FrmConfSAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 555);
            this.Controls.Add(this.TxtNumConf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtRangoFinal);
            this.Controls.Add(this.TxtCAI);
            this.Controls.Add(this.TxtRangoInicial);
            this.Controls.Add(this.CboPE);
            this.Controls.Add(this.DtpFechaLim);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgvConfiguracionSar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtContador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConfSAR";
            this.Text = "FrmConfSAR";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConfiguracionSar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumConf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TxtRangoFinal;
        private System.Windows.Forms.MaskedTextBox TxtCAI;
        private System.Windows.Forms.MaskedTextBox TxtRangoInicial;
        private System.Windows.Forms.ComboBox CboPE;
        private System.Windows.Forms.DateTimePicker DtpFechaLim;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton BtnNuevo;
        private DevExpress.XtraEditors.SimpleButton BtnLimpiar;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton BtnActualizar;
        private DevExpress.XtraEditors.SimpleButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.DataGridView DgvConfiguracionSar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtContador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}