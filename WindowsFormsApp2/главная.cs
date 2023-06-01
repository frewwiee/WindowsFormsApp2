using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Globalization;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }



        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
            System.Globalization.CultureInfo.GetCultureInfo("en-US");
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                btnLang.Text = "РУС";

            }
            else
            {
                btnLang.Text = "ENG";

            }

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Главная";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            timer2.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\frewieeee\Downloads\y2mate.com-Это-Error-братка-Глад-Валакас.wav");
            simpleSound.Play();
            MessageBox.Show("тиме аут 60 секунд эррор", "ЭРРОР БРАТКА");
        }

        private void btnClub_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5(), sender);
        }

        public void btnXozyaeva_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4(), sender);
        }

        private void btnSorevn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7(), sender);
        }

        private void btnPorodi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6(), sender);
        }

        private void btnSobaki_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2(), sender);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new reg(), sender);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name == "ru-RU")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                Properties.Settings.Default.Language = "en-US";
                Properties.Settings.Default.Save();
                Form1 f1= new Form1();
                f1.Show();
                this.Hide();

            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
                Properties.Settings.Default.Language = "ru-RU";
                Properties.Settings.Default.Save();
                Form1 ff1 = new Form1();
                ff1.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Process.Start(@"https://vk.com/artist/lilfrew");
        }
    }
}
