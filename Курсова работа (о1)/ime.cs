using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace Курсова_работа__о1_
{
    public partial class ime : Form
    {
        public ime()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchName = textBox1.Text.ToUpper();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Моля, въведете име.");
                return;
            }

            dataGridView1.Rows.Clear();

            try
            {
                using (FileStream fs = new FileStream("workers.dat", FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        string ime = br.ReadString();
                        string  dlaznost= br.ReadString();
                        string egn = br.ReadString();
                        int rabdnii = br.ReadInt32();
                        int  rabcas= br.ReadInt32();
                        double cenacas = br.ReadDouble();

                        if (ime.ToUpper() == searchName)
                        {
                            dataGridView1.Rows.Add(ime, dlaznost, egn, rabdnii, rabcas, cenacas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна грешка: " + ex.Message);
            }

            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Add("Няма данни");
            }
        
    }
    }
}

