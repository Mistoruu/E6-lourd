using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace E6_Mobile
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir toutes les informations");
                return;
            }

            string servername = "localhost";
            string dbname = "bdd_e5";
            string dbusername = "root";
            string dbpassword = "";

            string connString = $"Server={servername};Database={dbname};Uid={dbusername};Pwd={dbpassword};";

            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();

                string query = "SELECT * FROM admin WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedPassword = reader["password"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(password, storedPassword))
                    {
                        MessageBox.Show("Connexion réussie");
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Administrateur non trouvé");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
