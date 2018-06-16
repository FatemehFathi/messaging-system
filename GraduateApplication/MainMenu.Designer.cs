namespace GraduateApplication
{
    partial class MainMenu
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
            this.editProfileLabel = new System.Windows.Forms.LinkLabel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.cartableButton = new System.Windows.Forms.Button();
            this.templatesButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editProfileLabel
            // 
            this.editProfileLabel.AutoSize = true;
            this.editProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editProfileLabel.Location = new System.Drawing.Point(282, 29);
            this.editProfileLabel.Name = "editProfileLabel";
            this.editProfileLabel.Size = new System.Drawing.Size(88, 17);
            this.editProfileLabel.TabIndex = 7;
            this.editProfileLabel.TabStop = true;
            this.editProfileLabel.Text = "Edit Profile";
            this.editProfileLabel.VisitedLinkColor = System.Drawing.Color.Gray;
            this.editProfileLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editProfileLabel_LinkClicked);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutLabel.Location = new System.Drawing.Point(390, 29);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(58, 17);
            this.logoutLabel.TabIndex = 6;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.VisitedLinkColor = System.Drawing.Color.Gray;
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // cartableButton
            // 
            this.cartableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartableButton.Location = new System.Drawing.Point(102, 112);
            this.cartableButton.Name = "cartableButton";
            this.cartableButton.Size = new System.Drawing.Size(283, 38);
            this.cartableButton.TabIndex = 0;
            this.cartableButton.Text = "Cartable";
            this.cartableButton.UseVisualStyleBackColor = true;
            this.cartableButton.Click += new System.EventHandler(this.cartableButton_Click);
            // 
            // templatesButton
            // 
            this.templatesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatesButton.Location = new System.Drawing.Point(102, 156);
            this.templatesButton.Name = "templatesButton";
            this.templatesButton.Size = new System.Drawing.Size(283, 39);
            this.templatesButton.TabIndex = 1;
            this.templatesButton.Text = "Templates";
            this.templatesButton.UseVisualStyleBackColor = true;
            this.templatesButton.Click += new System.EventHandler(this.templatesButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.Location = new System.Drawing.Point(102, 246);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(283, 39);
            this.groupsButton.TabIndex = 4;
            this.groupsButton.Text = "User Groups";
            this.groupsButton.UseVisualStyleBackColor = true;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveButton.Location = new System.Drawing.Point(102, 291);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(283, 39);
            this.archiveButton.TabIndex = 5;
            this.archiveButton.Text = "Sent Mail";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksButton.Location = new System.Drawing.Point(102, 201);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(283, 39);
            this.tasksButton.TabIndex = 3;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 390);
            this.Controls.Add(this.tasksButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.templatesButton);
            this.Controls.Add(this.cartableButton);
            this.Controls.Add(this.editProfileLabel);
            this.Controls.Add(this.logoutLabel);
            this.Name = "MainMenu";
            this.Text = "Welcome! This is Your Menu...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel editProfileLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Button cartableButton;
        private System.Windows.Forms.Button templatesButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button tasksButton;
    }
}