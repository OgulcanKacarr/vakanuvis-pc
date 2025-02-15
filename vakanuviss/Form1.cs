﻿using System;
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
                if (user != null)
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

    }
}
