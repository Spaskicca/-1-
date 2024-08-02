using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсова_работа__о1_
{
    public partial class vhod : Form
    {
        public vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не сте въвели име");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не сте въвели Егн");
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Не сте избрали длъжност");
                return;
            }
            string data, ime, dlaznost, egn;
            int izcas, brdni;
            double cenacas;
            data = dateTimePicker1.Value.ToString();
            ime = textBox1.Text;
            dlaznost = comboBox1.Text;
            egn = textBox7.Text;
            izcas = (int)numericUpDown1.Value;
            brdni = int.Parse(textBox10.Text);
            cenacas = double.Parse(textBox9.Text);
            FileStream fp = new FileStream("workers.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fp);
            fp.Seek(0, SeekOrigin.End);
            bw.Write(data); bw.Write(ime); bw.Write(dlaznost);
            bw.Write(egn); bw.Write(izcas); bw.Write(brdni);
            bw.Write(cenacas);
            fp.Close();
            MessageBox.Show("Даните са записани");
            fp.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            int casa = (int)numericUpDown1.Value;
            double cenacas;
            try
            {
                cenacas = double.Parse(textBox9.Text);
            }
            catch
            {
                cenacas = 0;
                MessageBox.Show("Некоректна цена");
                textBox9.Text = "0";
                textBox9.Focus();
            }
            double st = casa * cenacas;
            





        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

