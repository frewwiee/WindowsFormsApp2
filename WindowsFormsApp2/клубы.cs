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
    public partial class Form5 : Form
    {
        public static string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kinologicheskiy_club.mdb";
        private OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(cn);
            myConnection.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.клубыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Клубы);
            button4.Click += new EventHandler(button4_firstClick);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazvanie = textBox2.Text;
            int kod_cluba = Convert.ToInt32(textBox1.Text);
            string qqq = " INSERT INTO Клубы ( [Код клуба], Название)  VALUES (" + kod_cluba + ", '" + nazvanie + "' )";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные внесены");
            this.клубыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Клубы);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox1.Text);
            string qq = "DELETE FROM Клубы WHERE [Код клуба] = " + CodeCustomer;
            OleDbCommand command = new OleDbCommand(qq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            this.клубыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Клубы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox4.Text);
            string newname = textBox3.Text;
            int new_code = Convert.ToInt32(textBox4.Text);
            int kod_cluba = Convert.ToInt32(textBox1.Text);
            string qqq = " UPDATE Клубы SET Название = '" + newname + "', [Код клуба] = " + new_code + " WHERE [Код клуба] = " + kod_cluba + "  ";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
            this.клубыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Клубы);
        }

        private void button4_firstClick(object sender, EventArgs e)
        {
            button4.Click -= new EventHandler(button4_firstClick);
            button4.Click += new EventHandler(button4_secondClick);


            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label1.Text = "Enter current club code";

            }
            else
            {
                label1.Text = "Введите текущий код клуба";

            }

            textBox3.Visible = true;
            textBox4.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button3.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;

        }
        private void button4_secondClick(object sender, System.EventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label1.Text = "Club code";

            }
            else
            {
                label1.Text = "Код клуба";
            }


                textBox3.Visible = false;
            textBox4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button3.Visible = false;
            textBox2.Visible = true;
            label2.Visible = true;

            button4.Click += new EventHandler(button4_firstClick);
            button4.Click -= new EventHandler(button4_secondClick);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();

            }
        }


    }
}
