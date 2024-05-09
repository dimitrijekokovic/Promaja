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

namespace pecanje
{
    public partial class udicepretraga : UserControl
    {
        public udicepretraga()
        {
            InitializeComponent();
        }
        private void PretraziUdice()
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            string id = idTB.Text.Trim();
            string velicina = velicinaTB.Text.Trim();
            string tip = tipTB.Text.Trim();
            string firma = firmaTB.Text.Trim();

            string query = @"
        SELECT * FROM Udice 
        WHERE 
            (@id = '' OR UdicaID = @id) AND 
            (@velicina = '' OR Veličina = @velicina) AND 
            (@tip = '' OR Tip LIKE '%' + @tip + '%') AND 
            (@firma = '' OR Firma LIKE '%' + @firma + '%')
    ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", string.IsNullOrEmpty(id) ? DBNull.Value : (object)int.Parse(id));
                    cmd.Parameters.AddWithValue("@velicina", string.IsNullOrEmpty(velicina) ? DBNull.Value : (object)int.Parse(velicina));
                    cmd.Parameters.AddWithValue("@tip", tip);
                    cmd.Parameters.AddWithValue("@firma", firma);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    dataGridView1.DataSource = dataTable;  
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PretraziUdice();
        }
    }
}
