namespace GraduateApplication
{
    partial class SentMail
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
            this.showButton = new System.Windows.Forms.Button();
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
            this.listLable.Text = "List of Sent Mails:";
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.Location = new System.Drawing.Point(339, 273);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 23);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showButton
            // 
            this.showButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.showButton.Location = new System.Drawing.Point(339, 244);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(132, 23);
            this.showButton.TabIndex = 22;
            this.showButton.Text = "Show Selected";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // SentMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listLable);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showButton);
            this.Name = "SentMail";
            this.Text = "Sent Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label listLable;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showButton;
    }
}