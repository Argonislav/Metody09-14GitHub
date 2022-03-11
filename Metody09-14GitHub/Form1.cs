using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_14GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double x1, x2, d;
            Metody.Diskriminant(a, b, c, out x1, out x2, out d);
            if (d < 0) MessageBox.Show("Rovnice nema reseni v R");
            else if (d > 0) MessageBox.Show("Koren x1 je: " + x1 + " a koren x2 je: " + x2);
            else MessageBox.Show("Rovnice ma jedno dvojnasobne reseni " + x1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            int cifSoucet = 0, lichSoucet = 0, sudSoucet = 0;
            if (Metody.ObsahujeCislici(s, out cifSoucet, out lichSoucet, out sudSoucet))
            {
                MessageBox.Show("Obsahuje číslici");
                MessageBox.Show("Ciferný součet je " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel je " + lichSoucet);
                MessageBox.Show("Ciferný součet sudých čísel je " + sudSoucet);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox5.Text;
            int pocetSlov = Metody.PocetSlov1(ref s);
            MessageBox.Show("Počet slov je: " + pocetSlov);
            MessageBox.Show("Výsledný string je: " + s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox6.Text;
            string nejdelSislovo, nejkratsiSlovo;
            if (Metody.ObsahujeSlovo(s, out nejdelSislovo, out nejkratsiSlovo))
            {
                MessageBox.Show("Obsahuje více než jedno slovo");
                MessageBox.Show("Nejdelší slovo: " + nejdelSislovo);
                MessageBox.Show("Nejkratší slovo: " + nejkratsiSlovo);
            }
            else
            {
                MessageBox.Show("Řetězec neobsahuje ani jedno slovo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox7.Text;
            int pocetVelkych, pocetMalych, pocetJinychZnaku;
            if (Metody.JeAlfanum(s, out pocetMalych, out pocetVelkych, out pocetJinychZnaku))
            {
                MessageBox.Show("Je alfanumerický");
                MessageBox.Show("Počet malých znaků: " + pocetMalych);
                MessageBox.Show("Počet velkých znaků: " + pocetVelkych);
                MessageBox.Show("Počet jiných znaků: " + pocetJinychZnaku);
            }
            else
            {
                MessageBox.Show("Není alfanumerický");
                MessageBox.Show("Počet malých znaků: " + pocetMalych);
                MessageBox.Show("Počet velkýchznaků: " + pocetVelkych);
                MessageBox.Show("Počet jiných znaků: " + pocetJinychZnaku);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s1 = textBox8.Text;
            string s2 = textBox9.Text;
            int pocet;
            int index;
            if (Metody.Identicke(s1,s2,out pocet,out index))
            {
                MessageBox.Show("Zadaná slova jsou identicka!");
            }
            else
            {
                MessageBox.Show("Zadaná slova nejsou identická!");
                MessageBox.Show("Počet odlišností je: " + pocet);
                MessageBox.Show("První odlišnost je na indexu: " + index);
            }
        }
    }
}
