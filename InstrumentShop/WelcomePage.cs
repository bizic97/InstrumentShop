using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentShop
{
    public partial class WelcomePage : Form
    {
       
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InstrumentDetails insDet = new InstrumentDetails();
            insDet.Show();
            this.Hide();
        }

        private void continueToInventoryLabel_Click(object sender, EventArgs e)
        {
            InstrumentDetails insDet = new InstrumentDetails();
            insDet.Show();
            this.Hide();
        }

        private void continueToStoreLabel_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.Show();
            this.Hide();
        }
    }
}
