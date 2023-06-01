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
    public partial class Form2 : Form
    {
        public static string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kinologicheskiy_club.mdb";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(cn);
            myConnection.Open();
        }

        private void собакиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.собакиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinologicheskiy_clubDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.собакиTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Собаки);
            btnRed.Click += new EventHandler(btnRed_firstClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klichka = textBox2.Text;
            int kod_sobaki = Convert.ToInt32(textBox1.Text);
            int kod_cluba = Convert.ToInt32(textBox4.Text);
            int kod_pola = Convert.ToInt32(textBox6.Text);
            int kod_porodi = Convert.ToInt32(textBox5.Text);
            int kod_hozyaina = Convert.ToInt32(textBox3.Text);
            int ves = Convert.ToInt32(textBox7.Text);
            string qqq = " INSERT INTO Собаки ( [Код собаки], Кличка, [Код хозяина], [Код клуба], [Код породы], [Код пола], [Вес])  VALUES ("+ kod_sobaki +", '" + klichka + "'," + kod_hozyaina + "," + kod_cluba + "," + kod_porodi + "," + kod_pola + "," + ves + ")";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные внесены");
            this.собакиTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Собаки);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox1.Text);
            string qq = "DELETE FROM Собаки WHERE [Код собаки] = " + CodeCustomer;
            OleDbCommand command = new OleDbCommand(qq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            this.собакиTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Собаки);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void поКличкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show(this);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.собакиDataGridView.Rows[e.RowIndex];
                собакиDataGridView.CurrentRow.Selected = true;

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnRed_firstClick(object sender, EventArgs e)
        {
            btnRed.Click -= new EventHandler(btnRed_firstClick);
            btnRed.Click += new EventHandler(btnRed_secondClick);

            btnRedOK.Visible = true;

            //textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            label8.Visible = true;

            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "New nickname";
                label3.Text = "New owner code";
                label4.Text = "New club code";
                label5.Text = "New breed code";
                label6.Text = "New gender code";
                label7.Text = "New weight";

            }
            else
            {
                label2.Text = "Новая кличка";
                label3.Text = "Новый код хозяина";
                label4.Text = "Новый код клуба";
                label5.Text = "Новый код породы";
                label6.Text = "Новый код пола";
                label7.Text = "Новый вес";

            }


        }

        private void btnRed_secondClick(object sender, System.EventArgs e)
        {
            btnRedOK.Visible = false;

            //textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;

            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            label8.Visible = false;

            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                label2.Text = "Nickname";
                label3.Text = "Owner code";
                label4.Text = "Club code";
                label5.Text = "Breed code";
                label6.Text = "Gender code";
                label7.Text = "Weight";
            }
            else
            {
                label2.Text = "Кличка";
                label3.Text = "Код хозяина";
                label4.Text = "Код клуба";
                label5.Text = "Код породы";
                label6.Text = "Код пола";
                label7.Text = "Вес";
            }


            btnRed.Click += new EventHandler(btnRed_firstClick);
            btnRed.Click -= new EventHandler(btnRed_secondClick);
        }

        private void btnRedOK_Click(object sender, EventArgs e)
        {
            int CodeCustomer = Convert.ToInt32(textBox8.Text);
            int kod_dog = Convert.ToInt32(textBox1.Text);
            int new_kod_dog = Convert.ToInt32(textBox8.Text);
            string klichka = textBox2.Text;
            string new_klichka = textBox9.Text;
            int kod_xoz = Convert.ToInt32(textBox3.Text);
            int new_kod_xoz = Convert.ToInt32(textBox10.Text);
            int kod_cluba = Convert.ToInt32(textBox4.Text);
            int new_kod_cluba = Convert.ToInt32(textBox11.Text);
            int kod_porodi = Convert.ToInt32(textBox5.Text);
            int new_kod_porodi = Convert.ToInt32(textBox12.Text);
            int kod_pola = Convert.ToInt32(textBox6.Text);
            int new_kod_pola = Convert.ToInt32(textBox13.Text);
            int ves = Convert.ToInt32(textBox7.Text);
            int new_ves = Convert.ToInt32(textBox14.Text);
            string qqq = " UPDATE Собаки SET Кличка = '"+ new_klichka +"', [Код хозяина] = "+ new_kod_xoz +", [Код клуба] = "+ new_kod_cluba +", [Код породы] = "+ new_kod_porodi +", [Код пола] = "+ new_kod_pola +", Вес = "+ new_ves +", [Код собаки] = "+ new_kod_dog +" WHERE [Код собаки] = "+ kod_dog +" ";
            OleDbCommand command = new OleDbCommand(qqq, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
            this.собакиTableAdapter.Fill(this.kinologicheskiy_clubDataSet.Собаки);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void собакиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}