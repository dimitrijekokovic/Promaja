using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pecanje
{
    public partial class masinicepretraga : UserControl
    {
        public masinicepretraga()
        {
            InitializeComponent();
        }
        private void PretraziMasinice()
{
    string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
    string id = idTB.Text.Trim();
    string model = modelTB.Text.Trim();
    string tip = tipTB.Text.Trim();
    string brojLezajeva = brojLezajevaTB.Text.Trim();

    string query = @"
        SELECT * FROM Masinice 
        WHERE 
            (@id = '' OR MasinicaID = @id) AND 
            (@model = '' OR Model LIKE '%' + @model + '%') AND 
            (@tip = '' OR Tip LIKE '%' + @tip + '%') AND 
            (@brojLezajeva = '' OR BrojLezajeva = @brojLezajeva)
    ";

    using (SqlConnection conn = new SqlConnection(connString))
    {
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@id", string.IsNullOrEmpty(id) ? DBNull.Value : (object)int.Parse(id));
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@tip", tip);
            cmd.Parameters.AddWithValue("@brojLezajeva", string.IsNullOrEmpty(brojLezajeva) ? DBNull.Value : (object)int.Parse(brojLezajeva));

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
            PretraziMasinice();
        }
    }
}
