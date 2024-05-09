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
    public partial class stapovi : UserControl
    {
        private void BindData()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM stapovi";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške prilikom učitavanja podataka: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public stapovi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            string query = "INSERT INTO Stapovi (Model, Duzina, Tezina, Materijal) VALUES (@Model, @Duzina, @Tezina, @Materijal)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Model", modelTB.Text);
                    cmd.Parameters.AddWithValue("@Duzina", Convert.ToDecimal(duzinaTB.Text));
                    cmd.Parameters.AddWithValue("@Tezina", Convert.ToDecimal(tezinaTB.Text));
                    cmd.Parameters.AddWithValue("@Materijal", materijalTB.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    BindData();


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            string query = "UPDATE Stapovi SET Model=@Model, Duzina=@Duzina, Tezina=@Tezina, Materijal=@Materijal WHERE StapID=@StapID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StapID", Convert.ToInt32(idTB.Text));
                    cmd.Parameters.AddWithValue("@Model", modelTB.Text);

                    decimal duzinaValue;
                    decimal tezinaValue;
                    bool isDuzinaValid = decimal.TryParse(duzinaTB.Text, out duzinaValue);
                    bool isTezinaValid = decimal.TryParse(tezinaTB.Text, out tezinaValue);

                    if (!isDuzinaValid || !isTezinaValid)
                    {
                        MessageBox.Show("Unesite ispravan format za 'Duzina' i 'Tezina'.");
                        return; 
                    }

                    cmd.Parameters.AddWithValue("@Duzina", duzinaValue);
                    cmd.Parameters.AddWithValue("@Tezina", tezinaValue);

                    cmd.Parameters.AddWithValue("@Materijal", materijalTB.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Došlo je do greške: " + ex.Message);
                    }

                    BindData();
                }
            }

        }

        private void stapovi_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            string query = "DELETE FROM Stapovi WHERE StapID=@StapID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StapID", Convert.ToInt32(idTB.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            BindData();
        }
    }
}
