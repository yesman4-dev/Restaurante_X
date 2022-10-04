namespace Restaurante_X
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.Lblpass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEntrar.ImageOptions.Image")));
            this.BtnEntrar.Location = new System.Drawing.Point(49, 186);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(123, 41);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(46, 77);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(49, 93);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(123, 20);
            this.TxtUser.TabIndex = 2;
            this.TxtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(49, 144);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(123, 20);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.UseSystemPasswordChar = true;
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // Lblpass
            // 
            this.Lblpass.AutoSize = true;
            this.Lblpass.Location = new System.Drawing.Point(46, 128);
            this.Lblpass.Name = "Lblpass";
            this.Lblpass.Size = new System.Drawing.Size(61, 13);
            this.Lblpass.TabIndex = 3;
            this.Lblpass.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 66);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.Lblpass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuletas y mas";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnEntrar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label Lblpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

