namespace Курсова_работа__о1_
{
    public partial class izhod : Form
    {
        public izhod()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FileStream f = new FileStream("workers.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f);
            {
                int totalEntries = 0;
                double totalWorkingHours = 0;
                int totalWorkDays = 0;

                while (f.Position < f.Length)
                {
                    string a1, a2, a3, a4; int icas, brdni; double cencas;
                    a1 = br.ReadString();
                    a2 = br.ReadString();
                    a3 = br.ReadString();
                    a4 = br.ReadString();
                    icas = br.ReadInt32();
                    brdni = br.ReadInt32();
                    cencas = br.ReadDouble();
                    totalWorkingHours += icas;
                    totalWorkDays += brdni;
                    totalEntries++;
                    dataGridView1.Rows.Add(a1, a2, a3, a4, icas, brdni, cencas, icas * cencas);
                }

            }
            f.Close();
        }
    }
}


