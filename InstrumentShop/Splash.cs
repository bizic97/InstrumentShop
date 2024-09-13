using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentShop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            progressBar.Value = startPos;
            percentage.Text= startPos + "%";
            if(progressBar.Value==100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                WelcomePage welcome= new WelcomePage();
                this.Hide();
                welcome.Show();
            }
            else
            {

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
