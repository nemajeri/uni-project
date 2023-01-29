namespace ProjekatZaFakultet
{
    partial class Form3
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
            this.spaceForCopyrightText = new System.Windows.Forms.RichTextBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spaceForCopyrightText
            // 
            this.spaceForCopyrightText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceForCopyrightText.Location = new System.Drawing.Point(12, 12);
            this.spaceForCopyrightText.Name = "spaceForCopyrightText";
            this.spaceForCopyrightText.Size = new System.Drawing.Size(407, 189);
            this.spaceForCopyrightText.TabIndex = 0;
            this.spaceForCopyrightText.Text = "";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(324, 207);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(95, 23);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 242);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.spaceForCopyrightText);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox spaceForCopyrightText;
        private System.Windows.Forms.Button goBackButton;
    }
}