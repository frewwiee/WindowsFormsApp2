using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public static string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kinologicheskiy_club.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(cn);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.хозяеваTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Хозяева);
            btnRed.Click += new EventHandler(btnRed_firstClick);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox2.Text;
            string adres = textBox3.Text;
            int kod_hozyaina = Convert.ToInt32(textBox1.Text);
            string qqq = " INSERT INTO Хозяева ([Код хозяина], ФИО, Адрес)  VALUES (" + kod_hozyaina + ",'" + fio + "','" + adres +"')";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные внесены");
            this.хозяеваTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Хозяева);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox1.Text);
            string qq = "DELETE FROM Хозяева WHERE [Код хозяина] = " + CodeCustomer;
            OleDbCommand command = new OleDbCommand(qq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            this.хозяеваTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Хозяева);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();

            }
        }
        private void btnRed_firstClick(object sender, EventArgs e)
        {
            btnRed.Click -= new EventHandler(btnRed_firstClick);
            btnRed.Click += new EventHandler(btnRed_secondClick);
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "New Full name";
                label3.Text = "New address";

            }
            else
            {
                label2.Text = "Новое ФИО";
                label3.Text = "Новый Адрес";

            }


            label4.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            btnRedOK.Visible = true;

            textBox2.Visible = false;
            textBox3.Visible = false;


        }
        private void btnRed_secondClick(object sender, System.EventArgs e)
        {
            btnRed.Click -= new EventHandler(btnRed_firstClick);
            btnRed.Click += new EventHandler(btnRed_secondClick);
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "Full name";
                label3.Text = "Address";

            }
            else
            {
                label2.Text = "ФИО";
                label3.Text = "Адрес";

            }

            label4.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            btnRedOK.Visible = false;

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;


            btnRed.Click += new EventHandler(btnRed_firstClick);
            btnRed.Click -= new EventHandler(btnRed_secondClick);
        }

        private void btnRedOK_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox4.Text);
            string address = textBox6.Text;
            string new_fio = textBox5.Text;
            int new_code = Convert.ToInt32(textBox4.Text);
            int kod_xoz = Convert.ToInt32(textBox1.Text);
            string qqq = " UPDATE Хозяева SET Адрес = '" + address + "', ФИО = '" + new_fio + "', [Код хозяина] = " + new_code + " WHERE [Код хозяина] = " + kod_xoz + " ";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
            this.хозяеваTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Хозяева);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
