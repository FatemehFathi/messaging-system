namespace GraduateApplication
{
    partial class Groups
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
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ungroupedLable = new System.Windows.Forms.Label();
            this.groupListLable = new System.Windows.Forms.Label();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteGroupButton.Location = new System.Drawing.Point(655, 190);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(141, 23);
            this.deleteGroupButton.TabIndex = 4;
            this.deleteGroupButton.Text = "Delete Selected Group(s)";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // editGroupButton
            // 
            this.editGroupButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.editGroupButton.Location = new System.Drawing.Point(655, 161);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(141, 23);
            this.editGroupButton.TabIndex = 3;
            this.editGroupButton.Text = "Edit Selected Group";
            this.editGroupButton.UseVisualStyleBackColor = true;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
            // 
            // createGroupButton
            // 
            this.createGroupButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.createGroupButton.Location = new System.Drawing.Point(655, 132);
            this.createGroupButton.Name = "createGroupButton";
            this.createGroupButton.Size = new System.Drawing.Size(141, 23);
            this.createGroupButton.TabIndex = 2;
            this.createGroupButton.Text = "Create New Group";
            this.createGroupButton.UseVisualStyleBackColor = true;
            this.createGroupButton.Click += new System.EventHandler(this.createGroupButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(44, 338);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(564, 212);
            this.listBox2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 212);
            this.listBox1.TabIndex = 1;
            // 
            // ungroupedLable
            // 
            this.ungroupedLable.AutoSize = true;
            this.ungroupedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ungroupedLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ungroupedLable.Location = new System.Drawing.Point(41, 318);
            this.ungroupedLable.Name = "ungroupedLable";
            this.ungroupedLable.Size = new System.Drawing.Size(145, 17);
            this.ungroupedLable.TabIndex = 13;
            this.ungroupedLable.Text = "List of All Persons:";
            // 
            // groupListLable
            // 
            this.groupListLable.AutoSize = true;
            this.groupListLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupListLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupListLable.Location = new System.Drawing.Point(41, 58);
            this.groupListLable.Name = "groupListLable";
            this.groupListLable.Size = new System.Drawing.Size(155, 17);
            this.groupListLable.TabIndex = 12;
            this.groupListLable.Text = "List of User Groups:";
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deletePersonButton.Location = new System.Drawing.Point(655, 451);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(141, 23);
            this.deletePersonButton.TabIndex = 8;
            this.deletePersonButton.Text = "Delete Selected Person(s)";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // editPersonButton
            // 
            this.editPersonButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.editPersonButton.Location = new System.Drawing.Point(655, 422);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(141, 23);
            this.editPersonButton.TabIndex = 7;
            this.editPersonButton.Text = "Edit Selected Person";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addPersonButton.Location = new System.Drawing.Point(655, 393);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(141, 23);
            this.addPersonButton.TabIndex = 6;
            this.addPersonButton.Text = "Add New Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 597);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ungroupedLable);
            this.Controls.Add(this.groupListLable);
            this.Controls.Add(this.deleteGroupButton);
            this.Controls.Add(this.editGroupButton);
            this.Controls.Add(this.createGroupButton);
            this.Name = "Groups";
            this.Text = "Groups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.Button editGroupButton;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ungroupedLable;
        private System.Windows.Forms.Label groupListLable;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.Button addPersonButton;
    }
}