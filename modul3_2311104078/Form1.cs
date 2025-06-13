using System;
using System.Windows.Forms;

namespace modul3_2311104078
{
    public partial class Form1 : Form
    {
        string angka1 = "";
        string angka2 = "";
        bool isTambah = false;

        public Form1()
        {
            InitializeComponent();

            btn0.Click += Angka_Click;
            btn1.Click += Angka_Click;
            btn2.Click += Angka_Click;
            btn3.Click += Angka_Click;
            btn4.Click += Angka_Click;
            btn5.Click += Angka_Click;
            btn6.Click += Angka_Click;
            btn7.Click += Angka_Click;
            btn8.Click += Angka_Click;
            btn9.Click += Angka_Click;

            
            btnPlus.Click += btnPlus_Click;
            btnEqual.Click += btnEqual_Click;
        }

        private void Angka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!isTambah)
            {
                angka1 += btn.Text;
                lblOutput.Text = angka1;
            }
            else
            {
                angka2 += btn.Text;
                lblOutput.Text = angka2;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            isTambah = true;
            lblOutput.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(angka1) || string.IsNullOrEmpty(angka2))
            {
                lblOutput.Text = "Isi angka dulu";
                return;
            }

            try
            {
                int hasil = int.Parse(angka1) + int.Parse(angka2);
                lblOutput.Text = hasil.ToString();

                
                angka1 = hasil.ToString();
                angka2 = "";
                isTambah = false;
            }
            catch
            {
                lblOutput.Text = "Error";
            }
        }
    }
}
