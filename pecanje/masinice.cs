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
    public partial class masinice : UserControl
    {
        public masinice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            string model = modelTB.Text;
            string tip = tipTB.Text;
            int brojLezajeva = int.Parse(brojLezajevaTB.Text); 

            string query = "INSERT INTO Masinice (Model, Tip, BrojLezajeva) VALUES (@Model, @Tip, @BrojLezajeva)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Tip", tip);
                    cmd.Parameters.AddWithValue("@BrojLezajeva", brojLezajeva);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Mašinica je uspešno dodata.");
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri dodavanju mašinice.");
                    }
                    conn.Close();
                }
            }
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            int id = int.Parse(idTB.Text); 
            string model = modelTB.Text;
            string tip = tipTB.Text;
            int brojLezajeva = int.Parse(brojLezajevaTB.Text);

            string query = "UPDATE Masinice SET Model = @Model, Tip = @Tip, BrojLezajeva = @BrojLezajeva WHERE MasinicaID = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Tip", tip);
                    cmd.Parameters.AddWithValue("@BrojLezajeva", brojLezajeva);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Mašinica je uspešno ažurirana.");
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri ažuriranju mašinice.");
                    }
                    conn.Close();
                }
            }
            BindData();
        }
        private void BindData()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM masinice";
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
        private void masinice_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            int id = int.Parse(idTB.Text);

            string query = "DELETE FROM Masinice WHERE MasinicaID = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Mašinica je uspešno obrisana.");
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri brisanju mašinice.");
                    }
                    conn.Close();
                }
            }
            BindData();
        }
    }
}
