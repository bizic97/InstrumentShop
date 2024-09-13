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
    public partial class Sell : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=MusicShop;Trusted_Connection=True;MultipleActiveResultSets=True");
        public Sell()
        {
            InitializeComponent();
        }
        private void PopulateGrid()
        {
            try
            {
                //open the connection
                conn.Open();
                //sqlcommand type
                using (SqlCommand cmd = new SqlCommand("SelectSell", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Sql adapter to fill the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //set the datasource
                    insSellDGV.DataSource = dt;

                }
                conn.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("An error occured: " + Ex.Message);
            }

        }
                       
        private void Sell_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        int n = 0;
        int currencyTotal = 0;
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (insNameTxtB.Text == "" || insPriceTxtB.Text == "" || insQuantityTxtB.Text == "")
            {
                MessageBox.Show("Plese select the instrument you want to sell and add Quantity");
            }
            else
            {
                int total = Convert.ToInt32(insQuantityTxtB.Text) * Convert.ToInt32(insPriceTxtB.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(billDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = insNameTxtB.Text;
                newRow.Cells[2].Value = insPriceTxtB.Text;
                newRow.Cells[3].Value = insQuantityTxtB.Text;
                newRow.Cells[4].Value = total;
                billDGV.Rows.Add(newRow);
                n++;
                currencyTotal = currencyTotal + total;
                amountTotalLabel.Text = "" + currencyTotal;
            }
        }
        private void insSellDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            insNameTxtB.Text = insSellDGV.SelectedRows[0].Cells[0].Value.ToString();
            insPriceTxtB.Text = insSellDGV.SelectedRows[0].Cells[1].Value.ToString();

        }
                
        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcome = new WelcomePage();
            welcome.Show();
            this.Hide();
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            insNameTxtB.Text = "";
            insPriceTxtB.Text = "";
            insQuantityTxtB.Text = "";
        }
        private void insertBill()
        {
            string today;
            
            try
            {
                //open the connection
                conn.Open();
                //Sql Command type
                using (SqlCommand cmd = new SqlCommand("InsertIntoBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //get the values
                    today = DateTime.Today.Date.ToString("MM/dd/yyyy");
                    currencyTotal = int.Parse(billDGV.SelectedRows[0].Cells[4].Value.ToString());
                    //Add parameters to the procedure
                    cmd.Parameters.AddWithValue("@today", today);
                    cmd.Parameters.AddWithValue("@currencyTotal", currencyTotal);
                    //Execute
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill inserted successfuly!");
                    conn.Close();
                    PopulateGrid();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occured: " + Ex.Message);
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            printDocumentBill.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("bill", 285, 600);
            if(printPreviewBill.ShowDialog()== DialogResult.OK )
            {
                printDocumentBill.Print();
            }
            insertBill();

        }
        
        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int instId, instQuantity, instPrice, total, pos = 60;
            string instName;
            e.Graphics.DrawString("Mix Music Shop", new Font("Times New Roman",12,FontStyle.Bold),Brushes.Black,new Point(80));
            e.Graphics.DrawString("-----------------------------------------------------", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(5,10));
            e.Graphics.DrawString("ID INSTRUMENT PRICE QUANTITY TOTAL", new Font("Times New Roman", 10, FontStyle.Italic), Brushes.Black, new Point(5, 30));
            foreach(DataGridViewRow row in billDGV.Rows)
            {
                instId = Convert.ToInt32(row.Cells["Column1"].Value);
                instName=""+ row.Cells["Column2"].Value;
                instPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                instQuantity = Convert.ToInt32(row.Cells["Column4"].Value);
                total= Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString(""+instId, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new Point(5,pos));
                e.Graphics.DrawString(""+instName, new Font("Times New Roman", 8, FontStyle.Regular), Brushes.Black, new Point(25, pos));
                e.Graphics.DrawString("" + instPrice, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new Point(125, pos));
                e.Graphics.DrawString(""+ instQuantity, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new Point(190, pos));
                e.Graphics.DrawString(""+total, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new Point(220, pos));
                pos = pos + 20;

            }
            int newPos = pos;
            e.Graphics.DrawString("-----------------------------------------", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(5, 520));
            e.Graphics.DrawString($"*****Total $ {currencyTotal} *****", new Font("Times New Roman", 10, FontStyle.Italic), Brushes.Black, new Point(5, 540));
            e.Graphics.DrawString("*****Mix Music Shop Became A Virtuos*****", new Font("Times New Roman", 10, FontStyle.Italic), Brushes.Black, new Point(5, 560));
            e.Graphics.DrawString("*****Thanks for Shopping!*****", new Font("Times New Roman", 10, FontStyle.Italic), Brushes.Black, new Point(5, newPos + 580));

        }

       
    }
}

