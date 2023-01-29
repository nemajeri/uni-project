using System;
using System.Windows.Forms;

namespace ProjekatZaFakultet
{
    public partial class Form2 : Form
    {
        private string username;

        private DateTime date;
        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
            labelUsername.Text = username;
            this.date = DateTime.Now;
            dateLabel.Text = date.ToString();
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(username);
            form3.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
