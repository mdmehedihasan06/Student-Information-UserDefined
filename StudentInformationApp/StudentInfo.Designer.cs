namespace StudentInformationApp
{
    partial class StudentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.idEntryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.allowenceEntryTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.retriveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // idEntryTextBox
            // 
            this.idEntryTextBox.Location = new System.Drawing.Point(137, 25);
            this.idEntryTextBox.Name = "idEntryTextBox";
            this.idEntryTextBox.Size = new System.Drawing.Size(234, 20);
            this.idEntryTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nick Name";
            // 
            // nameEntryTextBox
            // 
            this.nameEntryTextBox.Location = new System.Drawing.Point(137, 64);
            this.nameEntryTextBox.Name = "nameEntryTextBox";
            this.nameEntryTextBox.Size = new System.Drawing.Size(234, 20);
            this.nameEntryTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Allowence";
            // 
            // allowenceEntryTextBox
            // 
            this.allowenceEntryTextBox.Location = new System.Drawing.Point(137, 102);
            this.allowenceEntryTextBox.Name = "allowenceEntryTextBox";
            this.allowenceEntryTextBox.Size = new System.Drawing.Size(234, 20);
            this.allowenceEntryTextBox.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(75, 276);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // retriveButton
            // 
            this.retriveButton.Location = new System.Drawing.Point(255, 276);
            this.retriveButton.Name = "retriveButton";
            this.retriveButton.Size = new System.Drawing.Size(75, 23);
            this.retriveButton.TabIndex = 4;
            this.retriveButton.Text = "Retrive";
            this.retriveButton.UseVisualStyleBackColor = true;
            this.retriveButton.Click += new System.EventHandler(this.retriveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // firstNameEntryTextBox
            // 
            this.firstNameEntryTextBox.Location = new System.Drawing.Point(137, 146);
            this.firstNameEntryTextBox.Name = "firstNameEntryTextBox";
            this.firstNameEntryTextBox.Size = new System.Drawing.Size(234, 20);
            this.firstNameEntryTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // lastNameEntryTextBox
            // 
            this.lastNameEntryTextBox.Location = new System.Drawing.Point(137, 188);
            this.lastNameEntryTextBox.Name = "lastNameEntryTextBox";
            this.lastNameEntryTextBox.Size = new System.Drawing.Size(234, 20);
            this.lastNameEntryTextBox.TabIndex = 6;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 333);
            this.Controls.Add(this.lastNameEntryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameEntryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.retriveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.allowenceEntryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameEntryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idEntryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StudentInfo";
            this.Text = "Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idEntryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameEntryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox allowenceEntryTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button retriveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameEntryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameEntryTextBox;
    }
}

