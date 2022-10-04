namespace Restaurante_X
{
    partial class FrmPuntoEmision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntoEmision));
            this.CboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBusq = new System.Windows.Forms.TextBox();
            this.DgvPE = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombPE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumPE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPE)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboEstablecimiento
            // 
            this.CboEstablecimiento.FormattingEnabled = true;
            this.CboEstablecimiento.Location = new System.Drawing.Point(14, 202);
            this.CboEstablecimiento.Name = "CboEstablecimiento";
            this.CboEstablecimiento.Size = new System.Drawing.Size(121, 21);
            this.CboEstablecimiento.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Controls.Add(this.TxtBusq);
            this.panel2.Location = new System.Drawing.Point(274, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 151);
            this.panel2.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Busqueda:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(34, 106);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(119, 31);
            this.BtnActualizar.TabIndex = 5;
            this.BtnActualizar.Text = "Actualizar";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(34, 65);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(119, 31);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            // 
            // TxtBusq
            // 
            this.TxtBusq.Location = new System.Drawing.Point(12, 25);
            this.TxtBusq.Name = "TxtBusq";
            this.TxtBusq.Size = new System.Drawing.Size(157, 20);
            this.TxtBusq.TabIndex = 3;
            // 
            // DgvPE
            // 
            this.DgvPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPE.Location = new System.Drawing.Point(14, 248);
            this.DgvPE.Name = "DgvPE";
            this.DgvPE.Size = new System.Drawing.Size(447, 191);
            this.DgvPE.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Establecimiento:";
            // 
            // TxtNombPE
            // 
            this.TxtNombPE.Location = new System.Drawing.Point(14, 149);
            this.TxtNombPE.Name = "TxtNombPE";
            this.TxtNombPE.Size = new System.Drawing.Size(202, 20);
            this.TxtNombPE.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nombre punto de emision:";
            // 
            // TxtNumPE
            // 
            this.TxtNumPE.Location = new System.Drawing.Point(14, 98);
            this.TxtNumPE.Name = "TxtNumPE";
            this.TxtNumPE.Size = new System.Drawing.Size(202, 20);
            this.TxtNumPE.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Numero de punto de emision:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 68);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion de Punto de Emision";
            // 
            // FrmPuntoEmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.CboEstablecimiento);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgvPE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNombPE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNumPE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPuntoEmision";
            this.Text = "FrmPuntoEmision";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboEstablecimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton BtnActualizar;
        private DevExpress.XtraEditors.SimpleButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtBusq;
        private System.Windows.Forms.DataGridView DgvPE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombPE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumPE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}