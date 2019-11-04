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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void gameOverScreen(int param)
        {
            if (param == 0)
            {
                lblEnd.Text = "Oyunu bilgisayar kazandı.";
            }
            else
            {
                lblEnd.Text = "Tebrikler. Oyunu sen kazandın.";
            }

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }


    }
}
