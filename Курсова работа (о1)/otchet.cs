using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Курсова_работа__о1_
{
    public partial class otchet : Form
    {
        public otchet()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] imena = new string[10];
            int[] rabotnidni = new int[10];
            int[] rabotnicasa = new int[10];
            double[] cenacas = new double[10];
            double[] totalValue = new double[10];
            try
            {
                using (FileStream fs = new FileStream("workers.dat", FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    int n = 0;
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        string ime = br.ReadString();
                        string dlaznost = br.ReadString();
                        string egn = br.ReadString();
                        int dni = br.ReadInt32();
                        int casa = br.ReadInt32();
                        double rate = br.ReadDouble();

                        bool found = false;
                        for (int x = 0; x < n; x++)
                        {
                            if (imena[x] == ime)
                            {
                                rabotnidni[x] += dni;
                                rabotnicasa[x] += casa;
                                totalValue[x] += casa * rate;
                                found= true;
                            }
                        }
                        if (!found)
                        {
                            imena[n] = ime;
                            rabotnidni[n] = dni;
                            rabotnicasa[n] = casa;
                            cenacas[n] = rate;
                            totalValue[n] = casa * rate;
                            n++;
                        }
                    }
                }

                using (StreamWriter txt = new StreamWriter("report.txt"))
                {
                    txt.WriteLine("Отчет на работниците\n\n");
                    txt.WriteLine("====================================================");
                    txt.WriteLine("|{0,-20} | {1,5}| {2,5}| {3,15}| {4,-20}|", "Име", "Дни", "Часове", "Цена на час", "Стойност");
                    txt.WriteLine("====================================================");
                    for (int x = 0; x < imena.Length; x++)
                    {
                        if (imena[x] != null)
                        {
                            txt.WriteLine("|{0,-20} | {1,5}| {2,5}| {3,15:c2}| {4,20:c2}|", imena[x], rabotnidni[x], rabotnicasa[x], cenacas[x], totalValue[x]);
                        }
                    }
                    txt.WriteLine("====================================================");
                    txt.WriteLine("\n\n{0}\n\t\t\t\t\tПодпис:...............", DateTime.Now.ToString());
                }

                MessageBox.Show("Файлът е създаден !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна грешка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (File.Exists("report.txt"))
                {
                    StreamReader t = new StreamReader("report.txt");
                    listBox1.Items.Clear();
                    string line;
                    while ((line = t.ReadLine()) != null)
                        listBox1.Items.Add(line);
                    t.Close();
                }
    }
}
}
