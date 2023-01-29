using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjekatZaFakultet
{
    public partial class Form3 : Form
    {
        private string username;
        public Form3(string username)
        {
            InitializeComponent();
            this.username = username;
            spaceForCopyrightText.AppendText("Introducing the ultimate contact management application Imenik. " +
                "With this application, you can easily store, manage, and organize your contacts with ease. " +
                "You can add new contacts, delete existing ones, update current information, and view all your contacts in one convenient location. " +
                "Plus, with the built-in pie chart feature, you can quickly see the breakdown of your contacts by gender.\r\n\r\nCopyright (C) 2023 Nemanja All rights reserved. " +
                "This software is protected by copyright laws. The software is licensed, not sold.");
            spaceForCopyrightText.ReadOnly = true;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(username);
            form2.Show();
            this.Hide();
        }
    }
}
