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
    public partial class udice : UserControl
    {
        public udice()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM udice";
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void velicinaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            int velicina = int.Parse(velicinaTB.Text); 
            string tip = tipTB.Text;
            string firma = firmaTB.Text;

            string query = "INSERT INTO Udice (Veličina, Tip, Firma) VALUES (@Velicina, @Tip, @Firma)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Velicina", velicina);
                    cmd.Parameters.AddWithValue("@Tip", tip);
                    cmd.Parameters.AddWithValue("@Firma", firma);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Udica je uspešno dodata.");
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri dodavanju udice.");
                    }
                    conn.Close();
                }
            }
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            int id = int.Parse(idTB.Text); // Pretpostavljam da je unos validan
            int velicina = int.Parse(velicinaTB.Text);
            string tip = tipTB.Text;
            string firma = firmaTB.Text;

            string query = "UPDATE Udice SET Veličina = @Velicina, Tip = @Tip, Firma = @Firma WHERE UdicaID = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Velicina", velicina);
                    cmd.Parameters.AddWithValue("@Tip", tip);
                    cmd.Parameters.AddWithValue("@Firma", firma);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Udica je uspešno ažurirana.");
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri ažuriranju udice.");
                    }
                    conn.Close();
                }
            }
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;";
            int id = int.Parse(idTB.Text); 

            string query = "DELETE FROM Udice WHERE UdicaID = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Udica je uspešno obrisana.");
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške pri brisanju udice.");
                    }
                    conn.Close();
                }
            }
            BindData();
        }
    }
}
