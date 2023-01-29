using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjekatZaFakultet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=NEMANJA;Initial Catalog=Imenik;Integrated Security=True";
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Korisnici " +
                "WHERE KorisnickoIme = @username AND Sifra = @password", connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string usernameInDatabase = reader["KorisnickoIme"].ToString();

                    if (username == usernameInDatabase)
                    {
                        Form2 form2 = new Form2(username);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Access denied. Please check your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
