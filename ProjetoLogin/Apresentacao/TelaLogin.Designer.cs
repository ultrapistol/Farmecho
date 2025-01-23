namespace ProjetoLogin
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BttnSair = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.bttnEntrar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.bttnCadastrar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtBoxLogin1 = new ReaLTaiizor.Controls.AloneTextBox();
            this.TxtBoxSenha1 = new ReaLTaiizor.Controls.AloneTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnSair
            // 
            this.BttnSair.BackColor = System.Drawing.Color.ForestGreen;
            this.BttnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BttnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BttnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.BttnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSair.ForeColor = System.Drawing.Color.White;
            this.BttnSair.Location = new System.Drawing.Point(531, 3);
            this.BttnSair.Name = "BttnSair";
            this.BttnSair.Size = new System.Drawing.Size(20, 23);
            this.BttnSair.TabIndex = 2;
            this.BttnSair.Text = "X";
            this.BttnSair.UseVisualStyleBackColor = false;
            this.BttnSair.Click += new System.EventHandler(this.BttnSair_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Sora Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLogin.Location = new System.Drawing.Point(281, 74);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(59, 23);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login: ";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Sora Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSenha.Location = new System.Drawing.Point(280, 124);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(62, 23);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // bttnEntrar
            // 
            this.bttnEntrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.bttnEntrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.bttnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEntrar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.bttnEntrar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bttnEntrar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.bttnEntrar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.bttnEntrar.Location = new System.Drawing.Point(324, 190);
            this.bttnEntrar.Name = "bttnEntrar";
            this.bttnEntrar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.bttnEntrar.Size = new System.Drawing.Size(190, 40);
            this.bttnEntrar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.bttnEntrar.TabIndex = 8;
            this.bttnEntrar.Text = "Entrar";
            this.bttnEntrar.TextColor = System.Drawing.Color.White;
            this.bttnEntrar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.bttnEntrar.Click += new System.EventHandler(this.bttnEntrar_Click_1);
            // 
            // bttnCadastrar
            // 
            this.bttnCadastrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.bttnCadastrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.bttnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCadastrar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.bttnCadastrar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bttnCadastrar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.bttnCadastrar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.bttnCadastrar.Location = new System.Drawing.Point(324, 245);
            this.bttnCadastrar.Name = "bttnCadastrar";
            this.bttnCadastrar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.bttnCadastrar.Size = new System.Drawing.Size(190, 40);
            this.bttnCadastrar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.bttnCadastrar.TabIndex = 9;
            this.bttnCadastrar.Text = "Cadastre-se";
            this.bttnCadastrar.TextColor = System.Drawing.Color.White;
            this.bttnCadastrar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.bttnCadastrar.Click += new System.EventHandler(this.bttnCadastrar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 355);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 352);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TxtBoxLogin1
            // 
            this.TxtBoxLogin1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtBoxLogin1.EnabledCalc = true;
            this.TxtBoxLogin1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBoxLogin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.TxtBoxLogin1.Location = new System.Drawing.Point(346, 74);
            this.TxtBoxLogin1.MaxLength = 32767;
            this.TxtBoxLogin1.MultiLine = false;
            this.TxtBoxLogin1.Name = "TxtBoxLogin1";
            this.TxtBoxLogin1.ReadOnly = false;
            this.TxtBoxLogin1.Size = new System.Drawing.Size(168, 29);
            this.TxtBoxLogin1.TabIndex = 11;
            this.TxtBoxLogin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxLogin1.UseSystemPasswordChar = false;
            this.TxtBoxLogin1.TextChanged += new System.EventHandler(this.TxtBoxLogin1_TextChanged);
            // 
            // TxtBoxSenha1
            // 
            this.TxtBoxSenha1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtBoxSenha1.EnabledCalc = true;
            this.TxtBoxSenha1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBoxSenha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.TxtBoxSenha1.Location = new System.Drawing.Point(348, 124);
            this.TxtBoxSenha1.MaxLength = 32767;
            this.TxtBoxSenha1.MultiLine = false;
            this.TxtBoxSenha1.Name = "TxtBoxSenha1";
            this.TxtBoxSenha1.ReadOnly = false;
            this.TxtBoxSenha1.Size = new System.Drawing.Size(166, 29);
            this.TxtBoxSenha1.TabIndex = 12;
            this.TxtBoxSenha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBoxSenha1.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(556, 349);
            this.Controls.Add(this.TxtBoxSenha1);
            this.Controls.Add(this.TxtBoxLogin1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnCadastrar);
            this.Controls.Add(this.bttnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.BttnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BttnSair;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private ReaLTaiizor.Controls.HopeRoundButton bttnEntrar;
        private ReaLTaiizor.Controls.HopeRoundButton bttnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.AloneTextBox TxtBoxLogin1;
        private ReaLTaiizor.Controls.AloneTextBox TxtBoxSenha1;
    }
}

