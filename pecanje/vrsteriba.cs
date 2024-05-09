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
    public partial class vrsteriba : UserControl
    {
        public vrsteriba()
        {
            InitializeComponent();
            this.Load += new EventHandler(vrsteriba_Load);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void vrsteriba_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void obrisi()
        {
            nazivTB.Text = string.Empty;
            opisTB.Text = string.Empty;
            StatusCB.SelectedIndex = -1;
        }

        private void BindData()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM VrsteRiba";
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO VrsteRiba (Naziv, Porodica, StatusZastite) VALUES (@Naziv, @Porodica, @StatusZastite)";
                    using (SqlCommand ubaci = new SqlCommand(query, con))
                    {                        
                        ubaci.Parameters.AddWithValue("@Naziv", nazivTB.Text);
                        ubaci.Parameters.AddWithValue("@Porodica", opisTB.Text);
                        ubaci.Parameters.AddWithValue("@StatusZastite", StatusCB.Text);
                        ubaci.ExecuteNonQuery();
                    }
                    MessageBox.Show("Uspešno ubačeno!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri ubacivanju: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            BindData();
            obrisi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM VrsteRiba WHERE RibljiID = @RibljiID";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@RibljiID", Convert.ToInt32(idTB.Text));

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Riba je uspešno obrisan.");
                            BindData();
                            obrisi();
                        }
                        else
                        {
                            MessageBox.Show("Riba sa datim ID nije pronađen.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3BJO9A6;Initial Catalog=promajafishing;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE VrsteRiba SET Naziv = @Naziv, Porodica = @Porodica, StatusZastite = @StatusZastite WHERE RibljiID = @RibljiID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@RibljiID", Convert.ToInt32(idTB.Text)); // Pretpostavka je da idTB.Text sadrži ID koji treba ažurirati
                        command.Parameters.AddWithValue("@Naziv", nazivTB.Text);
                        command.Parameters.AddWithValue("@Porodica", opisTB.Text);
                        command.Parameters.AddWithValue("@StatusZastite", StatusCB.Text);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Podaci su uspešno ažurirani.");
                            BindData();
                            obrisi();
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis sa unetim ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
