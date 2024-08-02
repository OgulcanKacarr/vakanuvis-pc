using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vakanuvis;

namespace vakanuviss
{
    public partial class Login : Form
    {
        private FirebaseService firebaseService = new FirebaseService("AIzaSyDCbIatckAFYkziLAJJjrccuEgwcxZGKB8");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void button_login_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text.Trim();
            string password = textBox_password.Text.Trim();

            // Email ve password boş değilse, kullanıcıyı giriş yapmaya çalış
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                var user = await firebaseService.LoginAsync(email, password);
                if(user != null)
                {
                    HomeForm homeForm = new HomeForm();
                    this.Hide();
                    homeForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Email ve şifre alanları doldurulmalıdır.");
            }

        }

        private void vakanuvis_lbl_Click(object sender, EventArgs e)
        {

        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_lbl_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void signin_showpas_CheckedChanged(object sender, EventArgs e)
        {
            if (signin_showpas.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }
    }
}

