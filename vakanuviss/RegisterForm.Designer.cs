namespace vakanuviss
{
    partial class RegisterForm
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
            this.register_showpas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_logo = new System.Windows.Forms.PictureBox();
            this.vakanuvis_lbl = new System.Windows.Forms.Label();
            this.register_lbl = new System.Windows.Forms.Label();
            this.signin_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_register = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_email = new System.Windows.Forms.TextBox();
            this.register_exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // register_showpas
            // 
            this.register_showpas.AutoSize = true;
            this.register_showpas.Location = new System.Drawing.Point(551, 231);
            this.register_showpas.Name = "register_showpas";
            this.register_showpas.Size = new System.Drawing.Size(88, 17);
            this.register_showpas.TabIndex = 17;
            this.register_showpas.Text = "Şifreyi Göster";
            this.register_showpas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.register_logo);
            this.panel1.Controls.Add(this.vakanuvis_lbl);
            this.panel1.Controls.Add(this.register_lbl);
            this.panel1.Controls.Add(this.signin_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 383);
            this.panel1.TabIndex = 15;
            // 
            // register_logo
            // 
            this.register_logo.Image = global::vakanuviss.Properties.Resources.tr1;
            this.register_logo.Location = new System.Drawing.Point(75, 30);
            this.register_logo.Name = "register_logo";
            this.register_logo.Size = new System.Drawing.Size(150, 150);
            this.register_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.register_logo.TabIndex = 7;
            this.register_logo.TabStop = false;
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
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signin_btn.ForeColor = System.Drawing.Color.White;
            this.signin_btn.Location = new System.Drawing.Point(30, 339);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(247, 32);
            this.signin_btn.TabIndex = 4;
            this.signin_btn.Text = "GİRİŞ YAP";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(346, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifreni mi unuttun?";
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(121)))));
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.button_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_register.ForeColor = System.Drawing.Color.White;
            this.button_register.Location = new System.Drawing.Point(339, 266);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(86, 33);
            this.button_register.TabIndex = 13;
            this.button_register.Text = "KAYIT OL";
            this.button_register.UseVisualStyleBackColor = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.Location = new System.Drawing.Point(336, 174);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 15);
            this.label_password.TabIndex = 11;
            this.label_password.Text = "Şifre :";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_email.Location = new System.Drawing.Point(336, 105);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(57, 15);
            this.label_email.TabIndex = 12;
            this.label_email.Text = "E-mail :";
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_password.Location = new System.Drawing.Point(339, 195);
            this.register_password.Multiline = true;
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(292, 30);
            this.register_password.TabIndex = 9;
            // 
            // register_email
            // 
            this.register_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_email.Location = new System.Drawing.Point(339, 128);
            this.register_email.Multiline = true;
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(292, 30);
            this.register_email.TabIndex = 10;
            // 
            // register_exit
            // 
            this.register_exit.AutoSize = true;
            this.register_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_exit.Location = new System.Drawing.Point(612, 9);
            this.register_exit.Name = "register_exit";
            this.register_exit.Size = new System.Drawing.Size(19, 18);
            this.register_exit.TabIndex = 19;
            this.register_exit.Text = "X";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 383);
            this.Controls.Add(this.register_exit);
            this.Controls.Add(this.register_showpas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox register_showpas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox register_logo;
        private System.Windows.Forms.Label vakanuvis_lbl;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.Label register_exit;
    }
}