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
    public partial class InstrumentDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=MusicShop;Trusted_Connection=True;MultipleActiveResultSets=True");
        public InstrumentDetails()
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
                using(SqlCommand cmd = new SqlCommand("GetAllInstruments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Sql adapter to fill the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //set the datasource
                    insDetailsDGV.DataSource=dt;

                }
                conn.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("An error occured: " + Ex.Message);
            }

        }
        private void FilterByBrand()
        {
            try
            {
                //open the connection
                conn.Open();
                //sqlcommand type
                using (SqlCommand cmd = new SqlCommand("FilterByBrand", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    string insBrand = filterByBrandCB.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@InsBrand", insBrand);
                    //Sql adapter to fill the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //set the datasource
                    insDetailsDGV.DataSource = dt;

                }
                conn.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("An error occured: " + Ex.Message);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (insNameTxtB.Text == "" || insPriceTxtB.Text == "" || insQuantityTxtB.Text == "" || insBrandCOB.SelectedItem.ToString() == "" || insCategoryCOB.SelectedItem.ToString() == "") 
            {
                MessageBox.Show("Please enter all the fields");
            }
            else
            {
                try
                {
                    //open the connection
                    conn.Open();
                    //Sql Command type
                    using (SqlCommand cmd = new SqlCommand("InsertInstrument", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //get the values
                        string insName = insNameTxtB.Text;
                        string insBrand = insBrandCOB.SelectedItem.ToString();
                        int insQuantity = int.Parse(insQuantityTxtB.Text);
                        int insPrice = int.Parse(insPriceTxtB.Text);
                        string insCategory = insCategoryCOB.SelectedItem.ToString();
                        //Add parameters to the procedure
                        cmd.Parameters.AddWithValue("@InstName", insName);
                        cmd.Parameters.AddWithValue("@InsBrand", insBrand);
                        cmd.Parameters.AddWithValue("@InsQuantity", insQuantity);
                        cmd.Parameters.AddWithValue("@InsPrice", insPrice);
                        cmd.Parameters.AddWithValue("@InsCategory", insCategory);
                        //Execute
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfuly!");
                        conn.Close();
                        PopulateGrid();
                    }
                        
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occured: " + Ex.Message);
                }
               
            }
        }

        private void InstrumentDetails_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        int InstKey;
        private void insDetailsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InstKey = Convert.ToInt32(insDetailsDGV.SelectedRows[0].Cells[0].Value.ToString());
            insNameTxtB.Text = insDetailsDGV.SelectedRows[0].Cells[1].Value.ToString();
            insBrandCOB.Text= insDetailsDGV.SelectedRows[0].Cells[2].Value.ToString();
            insQuantityTxtB.Text = insDetailsDGV.SelectedRows[0].Cells[3].Value.ToString();
            insPriceTxtB.Text = insDetailsDGV.SelectedRows[0].Cells[4].Value.ToString();
            insCategoryCOB.Text= insDetailsDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
          
            if (InstKey == 0) 
            {
                MessageBox.Show("Select the instrument to be deleted");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this instrument?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DeleteInstrument", conn))
                        {
                            //Command type
                            cmd.CommandType = CommandType.StoredProcedure;
                            //get the value
                            int instKey = InstKey;
                            //Add parameter to the procedure
                            cmd.Parameters.AddWithValue("@InsKey", instKey);
                            //Execute query
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully!");
                            conn.Close();
                            PopulateGrid();


                        }

                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show("An error occured: " + Ex.Message);
                    }

                }

               
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (insNameTxtB.Text == "" || insPriceTxtB.Text == "" || insQuantityTxtB.Text == "")
            {
                MessageBox.Show("Please enter all the fields");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit information about instrument?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UpdateInstrument", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            int instKey = InstKey;
                            string instName = insNameTxtB.Text;
                            string instBrand = insBrandCOB.SelectedItem.ToString();
                            int instQuantity = int.Parse(insQuantityTxtB.Text);
                            int instPrice = int.Parse(insPriceTxtB.Text);
                            string instCategory = insCategoryCOB.SelectedItem.ToString();
                            cmd.Parameters.AddWithValue(@"InsKey", instKey);
                            cmd.Parameters.AddWithValue("@InsName", instName);
                            cmd.Parameters.AddWithValue("@InsBrand", instBrand);
                            cmd.Parameters.AddWithValue("@InsQuantity", instQuantity);
                            cmd.Parameters.AddWithValue("@InsPrice", instPrice);
                            cmd.Parameters.AddWithValue("@InsCategory", instCategory);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Instrument updated successfully");
                            conn.Close();
                            PopulateGrid();

                        }

                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show("An error occured: " + Ex.Message);
                    }
                }
                   
            }
        }

        private void filterByBrandCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByBrand();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcome = new WelcomePage();
            welcome.Show();
            this.Hide();
        }
    }
}
