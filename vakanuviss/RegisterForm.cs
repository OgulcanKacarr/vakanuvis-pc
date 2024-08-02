using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vakanuviss
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void register_showpas_CheckedChanged(object sender, EventArgs e)
        {
            if (register_showpas.Checked)
            {
                register_password.UseSystemPasswordChar = false;
            }
            else
            {
                register_password.UseSystemPasswordChar = true;
            }
        }
    }
}
