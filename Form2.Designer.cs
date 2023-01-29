namespace ProjekatZaFakultet
{
    partial class Form2
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
            this.placeholderTextWelcome = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.placeholderTextDate = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.placeholderAppName = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.aboutProgramButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeholderTextWelcome
            // 
            this.placeholderTextWelcome.AutoSize = true;
            this.placeholderTextWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextWelcome.Location = new System.Drawing.Point(54, 21);
            this.placeholderTextWelcome.Name = "placeholderTextWelcome";
            this.placeholderTextWelcome.Size = new System.Drawing.Size(68, 16);
            this.placeholderTextWelcome.TabIndex = 0;
            this.placeholderTextWelcome.Text = "Welcome ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(125, 21);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(44, 16);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "label2";
            // 
            // placeholderTextDate
            // 
            this.placeholderTextDate.AutoSize = true;
            this.placeholderTextDate.Location = new System.Drawing.Point(37, 56);
            this.placeholderTextDate.Name = "placeholderTextDate";
            this.placeholderTextDate.Size = new System.Drawing.Size(56, 13);
            this.placeholderTextDate.TabIndex = 2;
            this.placeholderTextDate.Text = "Time now:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(108, 56);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "label3";
            // 
            // placeholderAppName
            // 
            this.placeholderAppName.AutoSize = true;
            this.placeholderAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderAppName.Location = new System.Drawing.Point(177, 21);
            this.placeholderAppName.Name = "placeholderAppName";
            this.placeholderAppName.Size = new System.Drawing.Size(90, 16);
            this.placeholderAppName.TabIndex = 4;
            this.placeholderAppName.Text = "to Imenik app!";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(87, 99);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(150, 13);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "What do you want to do?";
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Location = new System.Drawing.Point(14, 141);
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(129, 23);
            this.aboutProgramButton.TabIndex = 6;
            this.aboutProgramButton.Text = "Read About Application";
            this.aboutProgramButton.UseVisualStyleBackColor = true;
            this.aboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Contacts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aboutProgramButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.placeholderAppName);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.placeholderTextDate);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.placeholderTextWelcome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placeholderTextWelcome;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label placeholderTextDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label placeholderAppName;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button aboutProgramButton;
        private System.Windows.Forms.Button button1;
    }
}