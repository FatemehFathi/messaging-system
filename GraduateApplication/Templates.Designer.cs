namespace GraduateApplication
{
    partial class Templates
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.composeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 355);
            this.listBox1.TabIndex = 20;
            // 
            // listLable
            // 
            this.listLable.AutoSize = true;
            this.listLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listLable.Location = new System.Drawing.Point(38, 66);
            this.listLable.Name = "listLable";
            this.listLable.Size = new System.Drawing.Size(138, 17);
            this.listLable.TabIndex = 24;
            this.listLable.Text = "List of Templates:";
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.Location = new System.Drawing.Point(331, 283);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(140, 23);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete Selected Template";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.editButton.Location = new System.Drawing.Point(331, 254);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(140, 23);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit Selected Template";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // composeButton
            // 
            this.composeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.composeButton.Location = new System.Drawing.Point(331, 225);
            this.composeButton.Name = "composeButton";
            this.composeButton.Size = new System.Drawing.Size(140, 23);
            this.composeButton.TabIndex = 21;
            this.composeButton.Text = "Create New Template";
            this.composeButton.UseVisualStyleBackColor = true;
            this.composeButton.Click += new System.EventHandler(this.composeButton_Click);
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listLable);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.composeButton);
            this.Name = "Templates";
            this.Text = "Templates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label listLable;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button composeButton;
    }
}