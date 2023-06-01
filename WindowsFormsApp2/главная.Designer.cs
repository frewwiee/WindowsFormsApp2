
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLang = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClub = new System.Windows.Forms.Button();
            this.btnXozyaeva = new System.Windows.Forms.Button();
            this.btnSorevn = new System.Windows.Forms.Button();
            this.btnPorodi = new System.Windows.Forms.Button();
            this.btnSobaki = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelDesktopPanel);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Controls.Add(this.btnLang);
            this.panelDesktopPanel.Controls.Add(this.panelTitleBar);
            this.panelDesktopPanel.Controls.Add(this.pnlMenu);
            this.panelDesktopPanel.Controls.Add(this.label3);
            this.panelDesktopPanel.Controls.Add(this.label2);
            resources.ApplyResources(this.panelDesktopPanel, "panelDesktopPanel");
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.frew_design;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLang
            // 
            resources.ApplyResources(this.btnLang, "btnLang");
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLang.Name = "btnLang";
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.Name = "panelTitleBar";
            // 
            // btnCloseChildForm
            // 
            resources.ApplyResources(this.btnCloseChildForm, "btnCloseChildForm");
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click_1);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Name = "lblTitle";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.btnClub);
            this.pnlMenu.Controls.Add(this.btnXozyaeva);
            this.pnlMenu.Controls.Add(this.btnSorevn);
            this.pnlMenu.Controls.Add(this.btnPorodi);
            this.pnlMenu.Controls.Add(this.btnSobaki);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.label4);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // btnClub
            // 
            resources.ApplyResources(this.btnClub, "btnClub");
            this.btnClub.FlatAppearance.BorderSize = 0;
            this.btnClub.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClub.Name = "btnClub";
            this.btnClub.UseVisualStyleBackColor = true;
            this.btnClub.Click += new System.EventHandler(this.btnClub_Click);
            // 
            // btnXozyaeva
            // 
            resources.ApplyResources(this.btnXozyaeva, "btnXozyaeva");
            this.btnXozyaeva.FlatAppearance.BorderSize = 0;
            this.btnXozyaeva.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXozyaeva.Name = "btnXozyaeva";
            this.btnXozyaeva.UseVisualStyleBackColor = true;
            this.btnXozyaeva.Click += new System.EventHandler(this.btnXozyaeva_Click);
            // 
            // btnSorevn
            // 
            resources.ApplyResources(this.btnSorevn, "btnSorevn");
            this.btnSorevn.FlatAppearance.BorderSize = 0;
            this.btnSorevn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSorevn.Name = "btnSorevn";
            this.btnSorevn.UseVisualStyleBackColor = true;
            this.btnSorevn.Click += new System.EventHandler(this.btnSorevn_Click);
            // 
            // btnPorodi
            // 
            resources.ApplyResources(this.btnPorodi, "btnPorodi");
            this.btnPorodi.FlatAppearance.BorderSize = 0;
            this.btnPorodi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPorodi.Name = "btnPorodi";
            this.btnPorodi.UseVisualStyleBackColor = true;
            this.btnPorodi.Click += new System.EventHandler(this.btnPorodi_Click);
            // 
            // btnSobaki
            // 
            resources.ApplyResources(this.btnSobaki, "btnSobaki");
            this.btnSobaki.FlatAppearance.BorderSize = 0;
            this.btnSobaki.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSobaki.Name = "btnSobaki";
            this.btnSobaki.UseVisualStyleBackColor = true;
            this.btnSobaki.Click += new System.EventHandler(this.btnSobaki_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnClub;
        public System.Windows.Forms.Button btnXozyaeva;
        public System.Windows.Forms.Button btnSorevn;
        public System.Windows.Forms.Button btnPorodi;
        public System.Windows.Forms.Button btnSobaki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

