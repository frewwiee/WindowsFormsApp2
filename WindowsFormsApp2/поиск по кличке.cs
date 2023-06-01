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
    public partial class Form3 : Form
    {
        public static string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kinologicheskiy_club.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(cn);
            myConnection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("");
            }
            else
            {
                try
                {
                    OleDbCommand cc = myConnection.CreateCommand();
                    cc.CommandType = CommandType.Text;
                    cc.CommandText = "SELECT * FROM Собаки WHERE Кличка = '" + textBox1.Text + "' ";
                    cc.ExecuteNonQuery();
                    DataTable dd = new DataTable();
                    OleDbDataAdapter data = new OleDbDataAdapter(cc);
                    data.Fill(dd);
                    dataGridView1.DataSource = dd;
                }
                catch
                { }

            }
        }
    }
}
