using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SözlükUygulaması
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> kelimeler = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeler.Add("cat","kedi");
            kelimeler.Add("dog", "köpek");
            kelimeler.Add("car", "araba");

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            kelimeler.Add(txtboxDil1.Text, txtboxDil2.Text);
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            string degistir = comboBox1.Text;

        }

        private void txtboxDil1_TextChanged(object sender, EventArgs e)
        {
            foreach(var kelime in kelimeler)
            {
                if(kelime.Key == txtboxDil1.Text)
                {
                    txtboxDil2.Text = kelime.Value;
                    break;
                }
                else
                {
                    txtboxDil2.Text = "kelime bulunamadı";
                }
            }
        }
    }
}
