namespace Курсова_работа__о1_
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте ?", "Излизане", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void въвежданеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new vhod().Show();
        }

        private void извежданеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new izhod().Show();
        }

        private void имеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ime().Show();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new otchet().Show();
        }
    }
}
