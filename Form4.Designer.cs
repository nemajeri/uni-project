namespace ProjekatZaFakultet
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxForContacts = new System.Windows.Forms.ListBox();
            this.listBoxForContactsToExport = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toExportList = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.piechartLabel = new System.Windows.Forms.Label();
            this.generateStatsButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.TextBox();
            this.updateContactField = new System.Windows.Forms.TextBox();
            this.cleanExportContactsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxForContacts
            // 
            this.listBoxForContacts.FormattingEnabled = true;
            this.listBoxForContacts.Location = new System.Drawing.Point(12, 50);
            this.listBoxForContacts.Name = "listBoxForContacts";
            this.listBoxForContacts.Size = new System.Drawing.Size(212, 173);
            this.listBoxForContacts.TabIndex = 0;
            // 
            // listBoxForContactsToExport
            // 
            this.listBoxForContactsToExport.FormattingEnabled = true;
            this.listBoxForContactsToExport.Location = new System.Drawing.Point(311, 50);
            this.listBoxForContactsToExport.Name = "listBoxForContactsToExport";
            this.listBoxForContactsToExport.Size = new System.Drawing.Size(219, 173);
            this.listBoxForContactsToExport.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 251);
            this.listBox1.TabIndex = 0;
            // 
            // toExportList
            // 
            this.toExportList.Location = new System.Drawing.Point(230, 141);
            this.toExportList.Name = "toExportList";
            this.toExportList.Size = new System.Drawing.Size(75, 44);
            this.toExportList.TabIndex = 2;
            this.toExportList.Text = "Add To Export List";
            this.toExportList.UseVisualStyleBackColor = true;
            this.toExportList.Click += new System.EventHandler(this.ToExportList_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(184, 249);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(49, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(183, 290);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(50, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 333);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(221, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(311, 249);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(219, 23);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export To File";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(13, 13);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(165, 20);
            this.searchField.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(184, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(49, 20);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contacts for Export:";
            // 
            // piechartLabel
            // 
            this.piechartLabel.AutoSize = true;
            this.piechartLabel.Location = new System.Drawing.Point(15, 382);
            this.piechartLabel.Name = "piechartLabel";
            this.piechartLabel.Size = new System.Drawing.Size(136, 13);
            this.piechartLabel.TabIndex = 12;
            this.piechartLabel.Text = "Latest Update Of Statistics:";
            // 
            // generateStatsButton
            // 
            this.generateStatsButton.Location = new System.Drawing.Point(314, 485);
            this.generateStatsButton.Name = "generateStatsButton";
            this.generateStatsButton.Size = new System.Drawing.Size(219, 23);
            this.generateStatsButton.TabIndex = 13;
            this.generateStatsButton.Text = "Generate Stats";
            this.generateStatsButton.UseVisualStyleBackColor = true;
            this.generateStatsButton.Click += new System.EventHandler(this.GenerateStatsButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(13, 249);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(165, 20);
            this.addContactButton.TabIndex = 7;
            // 
            // updateContactField
            // 
            this.updateContactField.Location = new System.Drawing.Point(15, 292);
            this.updateContactField.Name = "updateContactField";
            this.updateContactField.Size = new System.Drawing.Size(162, 20);
            this.updateContactField.TabIndex = 14;
            // 
            // cleanExportContactsList
            // 
            this.cleanExportContactsList.Location = new System.Drawing.Point(230, 72);
            this.cleanExportContactsList.Name = "cleanExportContactsList";
            this.cleanExportContactsList.Size = new System.Drawing.Size(75, 40);
            this.cleanExportContactsList.TabIndex = 15;
            this.cleanExportContactsList.Text = "Clean Export List";
            this.cleanExportContactsList.UseVisualStyleBackColor = true;
            this.cleanExportContactsList.Click += new System.EventHandler(this.CleanExportContactsList_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 626);
            this.Controls.Add(this.cleanExportContactsList);
            this.Controls.Add(this.updateContactField);
            this.Controls.Add(this.generateStatsButton);
            this.Controls.Add(this.piechartLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.toExportList);
            this.Controls.Add(this.listBoxForContactsToExport);
            this.Controls.Add(this.listBoxForContacts);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxForContacts;
        private System.Windows.Forms.ListBox listBoxForContactsToExport;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button toExportList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label piechartLabel;
        private System.Windows.Forms.Button generateStatsButton;
        private System.Windows.Forms.TextBox addContactButton;
        private System.Windows.Forms.TextBox updateContactField;
        private System.Windows.Forms.Button cleanExportContactsList;
    }
}