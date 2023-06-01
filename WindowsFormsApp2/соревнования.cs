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
    public partial class Form7 : Form
    {
        public static string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kinologicheskiy_club.mdb";
        private OleDbConnection myConnection;
        public Form7()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(cn);
            myConnection.Open();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.соревнованияTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Соревнования);
            btnRed.Click += new EventHandler(btnRed_firstClick);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToString(); 
            int kod_sorevnovaniya = Convert.ToInt32(textBox1.Text);
            int kod_sobaki = Convert.ToInt32(textBox2.Text);
            int bally = Convert.ToInt32(textBox3.Text);
            string qqq = " INSERT INTO Соревнования ([Код соревнования], [Дата], [Код собаки], [Набранные баллы]) " +
                "VALUES ('" + kod_sorevnovaniya + "', '" + data + "', '" + kod_sobaki + "', '" + bally + "' )";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные внесены");
            this.соревнованияTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Соревнования);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox1.Text);
            string qq = "DELETE FROM Соревнования WHERE [Код соревнования] = " + CodeCustomer;
            OleDbCommand command = new OleDbCommand(qq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            this.соревнованияTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Соревнования);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;

                textBox1.Text = row.Cells[0].Value.ToString();
                dateTimePicker1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();

            }
        }

        private void btnRed_firstClick(object sender, EventArgs e)
        {
            btnRed.Click -= new EventHandler(btnRed_firstClick);
            btnRed.Click += new EventHandler(btnRed_secondClick);

            btnRedOK.Visible = true;

            dateTimePicker1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            label5.Visible = true;
            dateTimePicker2.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "New date";
                label3.Text = "New dog code (from existing)";
                label4.Text = "New points earned";
            }
            else
            {
                label2.Text = "Новая дата";
                label3.Text = "Новый код собаки (из существующих)";
                label4.Text = "Новые набранные баллы";

            }

        }

        private void btnRed_secondClick(object sender, System.EventArgs e)
        {
            btnRedOK.Visible = false;

            dateTimePicker1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            label5.Visible = false;
            dateTimePicker2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "Date";
                label3.Text = "Dog code";
                label4.Text = "Points scored";
            }
            else
            {
                label2.Text = "Дата";
                label3.Text = "Код собаки";
                label4.Text = "Набранные баллы";

            }

            btnRed.Click += new EventHandler(btnRed_firstClick);
            btnRed.Click -= new EventHandler(btnRed_secondClick);
        }

        private void btnRedOK_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox6.Text);
            int new_kod_dog = Convert.ToInt32(textBox4.Text);
            int new_ballbl = Convert.ToInt32(textBox5.Text);
            int kod_dog = Convert.ToInt32(textBox4.Text);
            int kod_xoz = Convert.ToInt32(textBox1.Text);
            string new_date = dateTimePicker2.Value.ToString();
            int new_kod_sorevn = Convert.ToInt32(textBox6.Text);
            int kod_sorevn = Convert.ToInt32(textBox1.Text);
            string qqq = " UPDATE Соревнования SET Дата = '" + new_date + "', [Код собаки] = " + new_kod_dog + ", [Набранные баллы] = " + new_ballbl + ", [Код соревнования] = " + new_kod_sorevn + " WHERE [Код соревнования] = " + kod_sorevn + " ";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
            this.соревнованияTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Соревнования);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
