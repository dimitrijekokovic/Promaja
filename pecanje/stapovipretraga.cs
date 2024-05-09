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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace pecanje
{

    public partial class stapovipretraga : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StapID", "ID Štapa");
            dataGridView1.Columns.Add("Model", "Model");
            dataGridView1.Columns.Add("Duzina", "Dužina");
            dataGridView1.Columns.Add("Tezina", "Težina");
            dataGridView1.Columns.Add("Materijal", "Materijal");

            dataGridView1.Columns["StapID"].Width = 20;
            dataGridView1.Columns["Model"].Width = 20;
            dataGridView1.Columns["Duzina"].Width = 20;
            dataGridView1.Columns["Tezina"].Width = 20;
            dataGridView1.Columns["Materijal"].Width = 20;
        }

        public stapovipretraga()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string model = textBox2.Text;
            string duzina = textBox3.Text;
            string tezina = textBox4.Text; 
            string materijal = textBox5.Text; 

            string query = "SELECT * FROM stapovi WHERE " +
                           "(@id = '' OR StapID = @id) AND " +
                           "(@model = '' OR LOWER(Model) LIKE LOWER(@model + '%')) AND " +
                           "(@duzina = '' OR LOWER(Duzina) LIKE LOWER(@duzina + '%')) AND " +
                           "(@tezina = '' OR LOWER(Tezina) LIKE LOWER(@tezina + '%')) AND " +
                           "(@materijal = '' OR LOWER(Materijal) LIKE LOWER(@materijal + '%'))";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", string.IsNullOrEmpty(id) ? DBNull.Value : (object)id);
                    cmd.Parameters.AddWithValue("@model", string.IsNullOrEmpty(model) ? DBNull.Value : (object)model);
                    cmd.Parameters.AddWithValue("@duzina", string.IsNullOrEmpty(duzina) ? DBNull.Value : (object)duzina);
                    cmd.Parameters.AddWithValue("@tezina", string.IsNullOrEmpty(tezina) ? DBNull.Value : (object)tezina);
                    cmd.Parameters.AddWithValue("@materijal", string.IsNullOrEmpty(materijal) ? DBNull.Value : (object)materijal);

                    conn.Open();

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    dataGridView1.DataSource = dataTable;

                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
