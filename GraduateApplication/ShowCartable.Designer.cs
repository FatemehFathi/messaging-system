namespace GraduateApplication
{
    partial class ShowCartable
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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.upcomingLable = new System.Windows.Forms.Label();
            this.listLable = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.editButton.Location = new System.Drawing.Point(636, 174);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(132, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Selected Task";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.Location = new System.Drawing.Point(636, 203);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Selected Task";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // upcomingLable
            // 
            this.upcomingLable.AutoSize = true;
            this.upcomingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upcomingLable.Location = new System.Drawing.Point(42, 65);
            this.upcomingLable.Name = "upcomingLable";
            this.upcomingLable.Size = new System.Drawing.Size(149, 17);
            this.upcomingLable.TabIndex = 6;
            this.upcomingLable.Text = "Up Coming Tasks...";
            // 
            // listLable
            // 
            this.listLable.AutoSize = true;
            this.listLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listLable.Location = new System.Drawing.Point(42, 381);
            this.listLable.Name = "listLable";
            this.listLable.Size = new System.Drawing.Size(106, 17);
            this.listLable.TabIndex = 7;
            this.listLable.Text = "List of Tasks:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(545, 251);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(45, 401);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(545, 147);
            this.listBox2.TabIndex = 11;
            // 
            // sendButton
            // 
            this.sendButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sendButton.Location = new System.Drawing.Point(636, 232);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(132, 23);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send Selected Task";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ShowCartable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(812, 590);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listLable);
            this.Controls.Add(this.upcomingLable);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ShowCartable";
            this.Text = "Cartable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label upcomingLable;
        private System.Windows.Forms.Label listLable;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button sendButton;
    }
}