namespace GraduateApplication
{
    partial class AddGroup
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
            this.groupListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allGroupsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.allPersonsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupListBox
            // 
            this.groupListBox.FormattingEnabled = true;
            this.groupListBox.Location = new System.Drawing.Point(42, 137);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(193, 303);
            this.groupListBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "List of All Groups:";
            // 
            // allGroupsCheckedListBox
            // 
            this.allGroupsCheckedListBox.FormattingEnabled = true;
            this.allGroupsCheckedListBox.Location = new System.Drawing.Point(702, 136);
            this.allGroupsCheckedListBox.Name = "allGroupsCheckedListBox";
            this.allGroupsCheckedListBox.Size = new System.Drawing.Size(193, 304);
            this.allGroupsCheckedListBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "List of All Persons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "In This Group:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(282, 287);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(144, 23);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove from Group -->";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(282, 258);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "<-- Add to Group";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Group Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // allPersonsCheckedListBox
            // 
            this.allPersonsCheckedListBox.FormattingEnabled = true;
            this.allPersonsCheckedListBox.Location = new System.Drawing.Point(476, 136);
            this.allPersonsCheckedListBox.Name = "allPersonsCheckedListBox";
            this.allPersonsCheckedListBox.Size = new System.Drawing.Size(193, 304);
            this.allPersonsCheckedListBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(722, 498);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(820, 498);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 563);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allGroupsCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.allPersonsCheckedListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "AddGroup";
            this.Text = "Add New Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox allGroupsCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckedListBox allPersonsCheckedListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;


    }
}