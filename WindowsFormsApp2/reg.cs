using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2

{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "admin" && passField.Text =="admin")
            {
                Form1 f1 = new Form1();
                f1.btnClub.Visible = true;
                f1.btnXozyaeva.Visible = true;
                f1.btnSorevn.Visible = true;
                f1.btnSobaki.Visible = true;
                f1.btnPorodi.Visible = true;
                f1.button1.Visible = false;
                Form1.ActiveForm.Hide();
                f1.Show();

                if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
                {
                    MessageBox.Show("Welcome");

                }
                else
                {
                    MessageBox.Show("Добро пожаловать");

                }

            }

            else
            {
                loginField.Text = "";
                passField.Text = "";

                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }
    }
}