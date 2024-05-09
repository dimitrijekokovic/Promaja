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

namespace pecanje
{
    public partial class ribepretraga : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
        public ribepretraga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string naziv = textBox2.Text;
            string porodica = textBox3.Text;
            string statusZastite = comboBox1.SelectedItem?.ToString() ?? "";

            string query = "SELECT * FROM VrsteRiba WHERE " +
                           "(@id = '' OR RibljiID = @id) AND " +
                           "(@naziv = '' OR LOWER(Naziv) LIKE LOWER(@naziv + '%')) AND " +
                           "(@porodica = '' OR LOWER(Porodica) LIKE LOWER(@porodica + '%')) AND " +
                           "(@statusZastite = '' OR StatusZastite = @statusZastite)";




            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", string.IsNullOrEmpty(id) ? DBNull.Value : (object)id);
                    cmd.Parameters.AddWithValue("@naziv", string.IsNullOrEmpty(naziv) ? DBNull.Value : (object)($"%{naziv}%"));
                    cmd.Parameters.AddWithValue("@porodica", string.IsNullOrEmpty(porodica) ? DBNull.Value : (object)porodica); // CAST removed here
                    cmd.Parameters.AddWithValue("@statusZastite", string.IsNullOrEmpty(statusZastite) ? DBNull.Value : (object)statusZastite);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
