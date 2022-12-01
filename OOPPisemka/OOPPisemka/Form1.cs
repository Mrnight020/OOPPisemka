using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPisemka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monitor monitor1 = new Monitor("162vyska400sirka", "LED", textBox1.Text, "1920x900", (int)numericUpDown1.Value);
            MessageBox.Show("" +monitor1.ToString());
            Monitor monitor2 = new Monitor("302vyska600sirka", "IPS", textBox1.Text, "2000x1200", (int)numericUpDown1.Value);
            MessageBox.Show("" + monitor2.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool vodeodolnost = false;
            if (textBox3.Text == "Ano") vodeodolnost = true;

            reproduktor reproduktor1 = new reproduktor((int)numericUpDown2.Value, textBox2.Text, vodeodolnost ,(int)numericUpDown3.Value);
            MessageBox.Show("" + reproduktor1.ToString());

            reproduktor reproduktor2 = new reproduktor((int)numericUpDown2.Value, textBox2.Text, vodeodolnost, (int)numericUpDown3.Value);

            reproduktor2.zmenaceny(2000);
            reproduktor2.zmenaznacky("Lenovo");
            MessageBox.Show("" + reproduktor2.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
