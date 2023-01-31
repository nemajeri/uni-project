using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjekatZaFakultet
{
    public partial class Form4 : Form
    {
        private readonly List<string> emails = new List<string>();

        private string connectionString = "Data Source=NEMANJA;Initial Catalog=Imenik;Integrated Security=True";

        private string username;

        Chart chart;

        public Form4(string username)
        {
            InitializeComponent();
            TextWriterTraceListener listener = new TextWriterTraceListener(@"C:\Users\pk\Desktop\logfile.txt");
            Trace.Listeners.Add(listener);
            this.username = username;
            this.FormClosing += new FormClosingEventHandler(OnClosing);
            CheckIfAdmin();

            chart = new Chart();
            chart.ChartAreas.Add("ChartArea1");
            chart.Series.Add("Series1");
            chart.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart.Location = new Point(15, 405);
            chart.Size = new Size(230, 210);
            this.Controls.Add(chart);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Email FROM Kontakti";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string email = reader["Email"].ToString();
                                emails.Add(email);
                            }
                            listBoxForContacts.DataSource = emails;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Trace.TraceError(string.Format("{0} - Error in Method: {1} - Message: {2}",
                DateTime.Now,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                ex.Message));
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchField.Text;
            if (searchTerm.Length == 0)
            {
                MessageBox.Show("Please enter the search term in search box", "Error", MessageBoxButtons.OK);
                listBoxForContacts.DataSource = emails;
            }
            else
            {
                List<string> filteredEmails = emails.Where(email => email.ToLower().StartsWith(searchTerm)).Distinct().ToList();
                listBoxForContacts.DataSource = filteredEmails;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string contactToAdd = addContactButton.Text;

            try
            {
                if (!emails.Contains(contactToAdd) && Regex.IsMatch(contactToAdd, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$"))
                {
                    emails.Add(contactToAdd);
                    addContactButton.Text = null;
                }
                else if (contactToAdd.Length == 0 || emails.Contains(contactToAdd))
                {
                    MessageBox.Show("Please enter a valid contact", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Inputed contact is not valid", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(string.Format("{0} - Error in Method: {1} - Message: {2}",
                DateTime.Now,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                ex.Message));
            }
            finally
            {
                listBoxForContacts.DataSource = null;
                listBoxForContacts.DataSource = emails;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxForContacts.SelectedItems != null)
                {
                    string selectedContact = (string)listBoxForContacts.SelectedItem;

                    emails.Remove(selectedContact);
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(string.Format("{0} - Error in Method: {1} - Message: {2}",
                DateTime.Now,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                ex.Message));
            }
            finally
            {
                listBoxForContacts.DataSource = null;
                listBoxForContacts.DataSource = emails;
            }
        }



        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string selectedContactForUpdating = (string)listBoxForContacts.SelectedItem;

            string updatedContact = updateContactField.Text;

            if (!Regex.IsMatch(updatedContact, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$") || updatedContact.Equals(selectedContactForUpdating))
            {
                MessageBox.Show("Please enter a valid contact", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int index = emails.FindIndex(x => x == selectedContactForUpdating);
                    emails.RemoveAt(index);
                    emails.Insert(index, updatedContact);
                }
                catch (Exception ex)
                {
                    Trace.TraceError(string.Format("{0} - Error in Method: {1} - Message: {2}",
                    DateTime.Now,
                    System.Reflection.MethodBase.GetCurrentMethod().Name,
                    ex.Message));
                }
                finally
                {
                    listBoxForContacts.DataSource = null;
                    listBoxForContacts.DataSource = emails;
                }
            }
        }

        private void ToExportList_Click(object sender, EventArgs e)
        {
            string selectedContactForExporting = (string)listBoxForContacts.SelectedItem;

            listBoxForContactsToExport.Items.Add(selectedContactForExporting);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\pk\Desktop\Output.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string item in listBoxForContactsToExport.Items)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private void CleanExportContactsList_Click(object sender, EventArgs e)
        {
            Trace.TraceInformation("The listbox has been cleaned.");
            while (listBoxForContactsToExport.Items.Count > 0)
            {
                listBoxForContactsToExport.Items.RemoveAt(0);
            }

            Trace.Flush();
        }

        private void GenerateStatsButton_Click(object sender, EventArgs e)
        {
            chart.Series["Series1"].Points.Clear();

            Dictionary<string, int> domainCount = new Dictionary<string, int>();
            foreach (string email in emails)
            {
                string domain = email.Split('@')[1];
                if (domainCount.ContainsKey(domain))
                {
                    domainCount[domain]++;
                }
                else
                {
                    domainCount.Add(domain, 1);
                }
            }

            foreach (KeyValuePair<string, int> domain in domainCount)
            {
                chart.Series["Series1"].Points.AddXY(domain.Key, domain.Value);
            }
        }

        private void CheckIfAdmin()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT PravaPristupa FROM Korisnici " +
                "WHERE KorisnickoIme = @username", connection))
            {
                command.Parameters.AddWithValue("@username", username);


                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string rightsInDatabase = reader["PravaPristupa"].ToString();

                    if (rightsInDatabase == "korisnik")
                    {
                        deleteButton.Visible = false;
                    }
                }
                connection.Close();
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Kontakti", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Trace.TraceError(string.Format("{0} - Error in Method: {1} - Message: {2}",
                        DateTime.Now,
                        System.Reflection.MethodBase.GetCurrentMethod().Name,
                        ex.Message));
                    }
                }

                foreach (string email in emails)
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO Kontakti(Email) " +
                    "VALUES(@email)", connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Trace.TraceError(string.Format("{0} - Error in Method: {1} - Message: {2}",
                            DateTime.Now,
                            System.Reflection.MethodBase.GetCurrentMethod().Name,
                            ex.Message));
                        }
                    }
                }
            }
            Trace.Listeners[0].Close();
            base.OnClosing(e);
        }

    }
}

