using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasMakasKagitOyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        int yourC = 0;
        int comC = 0;
        //int activePicCom=0;
        int time;
        Control activePic = null;
        Control activePicCom = null;

        public int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Settings();
        }

        void Settings()
        {
            lblStatus.Text = "Lütfen seçiminizi yapınız. ";
            time = 5;
            btnAgain.Visible = false;
            yourC = 0;
            timer1.Start();

            if (activePic != null)
            {
                activePic.BackColor = Color.Transparent;
            }

            if (comC != 0)
            {
                this.Controls["pictureBox" + comC].BackColor = Color.Transparent;
            }

            ComputerChoice();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            yourC = 1; //Taş
            ChangePictureBackcolor(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            yourC = 2; // Kağıt
            ChangePictureBackcolor(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            yourC = 3; //Makas
            ChangePictureBackcolor(pictureBox3);

        }

        void ChangePictureBackcolor(Control control)
        {
            if (activePic != null)
            {
                activePic.BackColor = Color.Transparent;

            }
            activePic = control;

            control.BackColor = Color.Red;
        }

        void ComputerChoice()
        {
            comC = randomNumber(1, 3);
        }

        void Challenge()
        {
            this.Controls["pictureBox" + comC].BackColor = Color.Green;
            if (yourC == 0)
            {
                lblStatus.Text = "Seçim Yapmadın. Bilgisayar Kazandı.";
                lblComputer.Text += "X";
            }
            if (comC == yourC)
            {
                lblStatus.Text = "BERABERLİK";
            }
            else if (comC == 1 && yourC == 2)
            {
                lblStatus.Text = "Sen Kazandın.";
                lblYou.Text += "X";
            }
            else if (comC == 1 && yourC == 3)
            {
                lblStatus.Text = "Bilgisayar Kazandı.";
                lblComputer.Text += "X";
            }
            else if (comC == 2 && yourC == 1)
            {
                lblStatus.Text = "Bilgisayar Kazandı.";
                lblComputer.Text += "X";
            }
            else if (comC == 2 && yourC == 3)
            {
                lblStatus.Text = "Sen Kazandın.";
                lblYou.Text += "X";
            }
            else if (comC == 3 && yourC == 1)
            {
                lblStatus.Text = "Sen Kazandın.";
                lblYou.Text += "X";
            }
            else if (comC == 3 && yourC == 2)
            {
                lblStatus.Text = "Bilgisayar Kazandı.";
                lblComputer.Text += "X";
            }
            GameControl();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time--;

            if (time <= 0)
            {
                Challenge();
                btnAgain.Visible = true;
                timer1.Stop();
            }
            lblTimer.Text = time.ToString();
        }

        void gameOver(int param)
        {
            Form3 frms = new Form3();
            frms.Show();
            frms.gameOverScreen(param);
            this.Hide();
        }

        void GameControl()
        {
            if (lblComputer.Text.Length == 3)
            {
                gameOver(0);
            }
            else if (lblYou.Text.Length == 3)
            {
                gameOver(1);
            }

        }


    }
}
