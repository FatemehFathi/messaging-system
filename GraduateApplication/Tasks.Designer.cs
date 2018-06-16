namespace GraduateApplication
{
    partial class Tasks
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listLable = new System.Windows.Forms.Label();
            this.editProfileLabel = new System.Windows.Forms.LinkLabel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.composeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 355);
            this.listBox1.TabIndex = 1;
            // 
            // listLable
            // 
            this.listLable.AutoSize = true;
            this.listLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listLable.Location = new System.Drawing.Point(33, 78);
            this.listLable.Name = "listLable";
            this.listLable.Size = new System.Drawing.Size(106, 17);
            this.listLable.TabIndex = 19;
            this.listLable.Text = "List of Tasks:";
            // 
            // editProfileLabel
            // 
            this.editProfileLabel.Location = new System.Drawing.Point(0, 0);
            this.editProfileLabel.Name = "editProfileLabel";
            this.editProfileLabel.Size = new System.Drawing.Size(100, 23);
            this.editProfileLabel.TabIndex = 20;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Location = new System.Drawing.Point(0, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(100, 23);
            this.logoutLabel.TabIndex = 21;
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.Location = new System.Drawing.Point(334, 295);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete Selected Task(s)";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.editButton.Location = new System.Drawing.Point(334, 266);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(132, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit Selected Task";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // composeButton
            // 
            this.composeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.composeButton.Location = new System.Drawing.Point(334, 237);
            this.composeButton.Name = "composeButton";
            this.composeButton.Size = new System.Drawing.Size(132, 23);
            this.composeButton.TabIndex = 2;
            this.composeButton.Text = "Create New Task";
            this.composeButton.UseVisualStyleBackColor = true;
            this.composeButton.Click += new System.EventHandler(this.composeButton_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listLable);
            this.Controls.Add(this.editProfileLabel);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.composeButton);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label listLable;
        private System.Windows.Forms.LinkLabel editProfileLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button composeButton;
    }
}