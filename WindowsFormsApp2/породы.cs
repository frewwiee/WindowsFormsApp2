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
    public partial class Form6 : Form
    {
        public static string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kinologicheskiy_club.mdb";
        private OleDbConnection myConnection;
        public Form6()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(cn);
            myConnection.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.породыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Породы);
            btnRed.Click += new EventHandler(btnRed_firstClick);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string poroda = textBox2.Text;
            int kod_porodi = Convert.ToInt32(textBox1.Text);
            string qqq = " INSERT INTO Породы ([Код породы], Порода )  VALUES ('" + kod_porodi + "'," + poroda + ")";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные внесены");
            this.породыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Породы);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox1.Text);
            string qq = "DELETE FROM Породы WHERE [Код породы] = " + CodeCustomer;
            OleDbCommand command = new OleDbCommand(qq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            this.породыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Породы);
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

        private void btnRed_firstClick(object sender, EventArgs e)
        {
            btnRed.Click -= new EventHandler(btnRed_firstClick);
            btnRed.Click += new EventHandler(btnRed_secondClick);

            btnRedOK.Visible = true;

            textBox2.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label3.Visible = true;

            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "New breed code";

            }
            else
            {
                label2.Text = "Новый код породы";

            }


        }

        private void btnRed_secondClick(object sender, System.EventArgs e)
        {
            btnRedOK.Visible = false;

            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label3.Visible = false;

            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "Breed";

            }
            else
            {
                label2.Text = "Порода";

            }

            btnRed.Click += new EventHandler(btnRed_firstClick);
            btnRed.Click -= new EventHandler(btnRed_secondClick);
        }

        private void btnRedOK_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox3.Text);
            string poroda = textBox2.Text;
            string new_poroda = textBox4.Text;
            int new_kod_porodi = Convert.ToInt32(textBox3.Text);
            int kod_porodi = Convert.ToInt32(textBox1.Text);
            string qqq = " UPDATE Породы SET Порода = '" + new_poroda + "', [Код породы] = " + new_kod_porodi + " WHERE [Код породы] = " + kod_porodi + " ";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
            this.породыTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Породы);
        }
    }
}
