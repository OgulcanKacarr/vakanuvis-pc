namespace vakanuviss
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.register_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vakanuvis_lbl = new System.Windows.Forms.Label();
            this.register_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signin_showpas = new System.Windows.Forms.CheckBox();
            this.gif_pctrebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif_pctrebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_email.Location = new System.Drawing.Point(340, 165);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(292, 30);
            this.textBox_email.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_password.Location = new System.Drawing.Point(340, 232);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(292, 30);
            this.textBox_password.TabIndex = 0;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_email.Location = new System.Drawing.Point(337, 142);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(57, 15);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "E-mail :";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.Location = new System.Drawing.Point(337, 211);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 15);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Şifre :";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(446, 309);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(86, 33);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "GİRİŞ";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(347, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifreni mi unuttun?";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(30, 339);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(247, 32);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Kayıt ol";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.vakanuvis_lbl);
            this.panel1.Controls.Add(this.register_lbl);
            this.panel1.Controls.Add(this.register_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 383);
            this.panel1.TabIndex = 5;
            // 
            // vakanuvis_lbl
            // 
            this.vakanuvis_lbl.AutoSize = true;
            this.vakanuvis_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vakanuvis_lbl.ForeColor = System.Drawing.Color.White;
            this.vakanuvis_lbl.Location = new System.Drawing.Point(96, 193);
            this.vakanuvis_lbl.Name = "vakanuvis_lbl";
            this.vakanuvis_lbl.Size = new System.Drawing.Size(111, 20);
            this.vakanuvis_lbl.TabIndex = 6;
            this.vakanuvis_lbl.Text = "VAKANUVİS";
            this.vakanuvis_lbl.Click += new System.EventHandler(this.vakanuvis_lbl_Click);
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_lbl.ForeColor = System.Drawing.Color.White;
            this.register_lbl.Location = new System.Drawing.Point(127, 309);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(50, 17);
            this.register_lbl.TabIndex = 5;
            this.register_lbl.Text = "Ya da";
            this.register_lbl.Click += new System.EventHandler(this.register_lbl_Click);
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_lbl.Location = new System.Drawing.Point(613, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(19, 18);
            this.exit_lbl.TabIndex = 6;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // signin_showpas
            // 
            this.signin_showpas.AutoSize = true;
            this.signin_showpas.Location = new System.Drawing.Point(552, 268);
            this.signin_showpas.Name = "signin_showpas";
            this.signin_showpas.Size = new System.Drawing.Size(88, 17);
            this.signin_showpas.TabIndex = 8;
            this.signin_showpas.Text = "Şifreyi Göster";
            this.signin_showpas.UseVisualStyleBackColor = true;
            // 
            // gif_pctrebox
            // 
            this.gif_pctrebox.Image = global::vakanuviss.Properties.Resources.logo_gif;
            this.gif_pctrebox.Location = new System.Drawing.Point(422, 30);
            this.gif_pctrebox.Name = "gif_pctrebox";
            this.gif_pctrebox.Size = new System.Drawing.Size(128, 90);
            this.gif_pctrebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif_pctrebox.TabIndex = 9;
            this.gif_pctrebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vakanuviss.Properties.Resources.tr1;
            this.pictureBox1.Location = new System.Drawing.Point(75, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 383);
            this.Controls.Add(this.gif_pctrebox);
            this.Controls.Add(this.signin_showpas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif_pctrebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox signin_showpas;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.Label vakanuvis_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gif_pctrebox;
    }
}

