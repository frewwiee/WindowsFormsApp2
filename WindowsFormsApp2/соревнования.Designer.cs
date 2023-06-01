
namespace WindowsFormsApp2
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.соревнованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinologicheskiy_clubDataSet = new WindowsFormsApp2.kinologicheskiy_clubDataSet();
            this.соревнованияTableAdapter = new WindowsFormsApp2.kinologicheskiy_clubDataSetTableAdapters.СоревнованияTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnRedOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.кодСоревнованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСобакиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.набранныеБаллыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соревнованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinologicheskiy_clubDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСоревнованияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.кодСобакиDataGridViewTextBoxColumn,
            this.набранныеБаллыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.соревнованияBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // соревнованияBindingSource
            // 
            this.соревнованияBindingSource.DataMember = "Соревнования";
            this.соревнованияBindingSource.DataSource = this.kinologicheskiy_clubDataSet;
            // 
            // kinologicheskiy_clubDataSet
            // 
            this.kinologicheskiy_clubDataSet.DataSetName = "kinologicheskiy_clubDataSet";
            this.kinologicheskiy_clubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // соревнованияTableAdapter
            // 
            this.соревнованияTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Name = "label4";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // btnRed
            // 
            resources.ApplyResources(this.btnRed, "btnRed");
            this.btnRed.FlatAppearance.BorderSize = 0;
            this.btnRed.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRed.Name = "btnRed";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnRedOK
            // 
            resources.ApplyResources(this.btnRedOK, "btnRedOK");
            this.btnRedOK.FlatAppearance.BorderSize = 0;
            this.btnRedOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRedOK.Name = "btnRedOK";
            this.btnRedOK.UseVisualStyleBackColor = true;
            this.btnRedOK.Click += new System.EventHandler(this.btnRedOK_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Name = "label5";
            // 
            // кодСоревнованияDataGridViewTextBoxColumn
            // 
            this.кодСоревнованияDataGridViewTextBoxColumn.DataPropertyName = "Код соревнования";
            resources.ApplyResources(this.кодСоревнованияDataGridViewTextBoxColumn, "кодСоревнованияDataGridViewTextBoxColumn");
            this.кодСоревнованияDataGridViewTextBoxColumn.Name = "кодСоревнованияDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            resources.ApplyResources(this.датаDataGridViewTextBoxColumn, "датаDataGridViewTextBoxColumn");
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // кодСобакиDataGridViewTextBoxColumn
            // 
            this.кодСобакиDataGridViewTextBoxColumn.DataPropertyName = "Код собаки";
            resources.ApplyResources(this.кодСобакиDataGridViewTextBoxColumn, "кодСобакиDataGridViewTextBoxColumn");
            this.кодСобакиDataGridViewTextBoxColumn.Name = "кодСобакиDataGridViewTextBoxColumn";
            // 
            // набранныеБаллыDataGridViewTextBoxColumn
            // 
            this.набранныеБаллыDataGridViewTextBoxColumn.DataPropertyName = "Набранные баллы";
            resources.ApplyResources(this.набранныеБаллыDataGridViewTextBoxColumn, "набранныеБаллыDataGridViewTextBoxColumn");
            this.набранныеБаллыDataGridViewTextBoxColumn.Name = "набранныеБаллыDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRedOK);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соревнованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinologicheskiy_clubDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kinologicheskiy_clubDataSet kinologicheskiy_clubDataSet;
        private System.Windows.Forms.BindingSource соревнованияBindingSource;
        private kinologicheskiy_clubDataSetTableAdapters.СоревнованияTableAdapter соревнованияTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnRedOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСоревнованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСобакиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn набранныеБаллыDataGridViewTextBoxColumn;
    }
}