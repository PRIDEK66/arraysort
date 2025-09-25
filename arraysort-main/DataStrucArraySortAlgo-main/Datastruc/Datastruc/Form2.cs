using System;
using System.Windows.Forms;

namespace Datastruc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Interval = 30; // speed of loading (ms)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2; // increment progress
            }
            else
            {
                timer1.Stop();

                // Open ArraySort form
                ArraySort mainForm = new ArraySort();
                mainForm.StartPosition = FormStartPosition.CenterScreen;
                mainForm.Show();

                // Hide loading screen
                this.Hide();
            }
        }
    }
}
