namespace Курсова_работа__о1_
{
    partial class Glavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            общиToolStripMenuItem = new ToolStripMenuItem();
            въвежданеToolStripMenuItem = new ToolStripMenuItem();
            извежданеToolStripMenuItem = new ToolStripMenuItem();
            справкиToolStripMenuItem = new ToolStripMenuItem();
            имеToolStripMenuItem = new ToolStripMenuItem();
            егнToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            изходToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AdobeStock_211443786_scaled;
            pictureBox1.Location = new Point(-4, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1186, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = Properties.Resources.AdobeStock_211443786_scaled;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { общиToolStripMenuItem, справкиToolStripMenuItem, отчетToolStripMenuItem, изходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 37);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // общиToolStripMenuItem
            // 
            общиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { въвежданеToolStripMenuItem, извежданеToolStripMenuItem });
            общиToolStripMenuItem.Font = new Font("Sitka Subheading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            общиToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            общиToolStripMenuItem.Name = "общиToolStripMenuItem";
            общиToolStripMenuItem.Size = new Size(79, 33);
            общиToolStripMenuItem.Text = "Общи";
            // 
            // въвежданеToolStripMenuItem
            // 
            въвежданеToolStripMenuItem.Name = "въвежданеToolStripMenuItem";
            въвежданеToolStripMenuItem.Size = new Size(200, 34);
            въвежданеToolStripMenuItem.Text = "Въвеждане";
            въвежданеToolStripMenuItem.Click += въвежданеToolStripMenuItem_Click;
            // 
            // извежданеToolStripMenuItem
            // 
            извежданеToolStripMenuItem.Name = "извежданеToolStripMenuItem";
            извежданеToolStripMenuItem.Size = new Size(200, 34);
            извежданеToolStripMenuItem.Text = "Извеждане";
            извежданеToolStripMenuItem.Click += извежданеToolStripMenuItem_Click;
            // 
            // справкиToolStripMenuItem
            // 
            справкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { имеToolStripMenuItem, егнToolStripMenuItem });
            справкиToolStripMenuItem.Font = new Font("Sitka Subheading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            справкиToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            справкиToolStripMenuItem.Size = new Size(102, 33);
            справкиToolStripMenuItem.Text = "Справки";
            // 
            // имеToolStripMenuItem
            // 
            имеToolStripMenuItem.Name = "имеToolStripMenuItem";
            имеToolStripMenuItem.Size = new Size(224, 34);
            имеToolStripMenuItem.Text = "Име";
            имеToolStripMenuItem.Click += имеToolStripMenuItem_Click;
            // 
            // егнToolStripMenuItem
            // 
            егнToolStripMenuItem.Name = "егнToolStripMenuItem";
            егнToolStripMenuItem.Size = new Size(224, 34);
            егнToolStripMenuItem.Text = "Егн";
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.Font = new Font("Sitka Subheading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            отчетToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(93, 33);
            отчетToolStripMenuItem.Text = "Отчет";
            отчетToolStripMenuItem.Click += отчетToolStripMenuItem_Click;
            // 
            // изходToolStripMenuItem
            // 
            изходToolStripMenuItem.Font = new Font("Sitka Subheading", 12F, FontStyle.Italic, GraphicsUnit.Point);
            изходToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            изходToolStripMenuItem.Size = new Size(81, 33);
            изходToolStripMenuItem.Text = "Изход";
            изходToolStripMenuItem.Click += изходToolStripMenuItem_Click;
            // 
            // Glavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1182, 591);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Glavna";
            Text = "Glavna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem общиToolStripMenuItem;
        private ToolStripMenuItem справкиToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem въвежданеToolStripMenuItem;
        private ToolStripMenuItem извежданеToolStripMenuItem;
        private ToolStripMenuItem имеToolStripMenuItem;
        private ToolStripMenuItem егнToolStripMenuItem;
        private ToolStripMenuItem изходToolStripMenuItem;
    }
}