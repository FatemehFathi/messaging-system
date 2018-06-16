namespace GraduateApplication
{
    partial class SentMailShow
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
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.attachLable = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subjectLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(101, 70);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(530, 20);
            this.toTextBox.TabIndex = 64;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(101, 103);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(530, 20);
            this.subjectTextBox.TabIndex = 67;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(38, 148);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(893, 400);
            this.contentTextBox.TabIndex = 69;
            this.contentTextBox.Text = "";
            // 
            // attachLable
            // 
            this.attachLable.AutoSize = true;
            this.attachLable.Location = new System.Drawing.Point(35, 574);
            this.attachLable.Name = "attachLable";
            this.attachLable.Size = new System.Drawing.Size(69, 13);
            this.attachLable.TabIndex = 80;
            this.attachLable.Text = "Attachments:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(35, 73);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 79;
            this.toLabel.Text = "To:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(731, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 77;
            // 
            // subjectLable
            // 
            this.subjectLable.AutoSize = true;
            this.subjectLable.Location = new System.Drawing.Point(35, 106);
            this.subjectLable.Name = "subjectLable";
            this.subjectLable.Size = new System.Drawing.Size(46, 13);
            this.subjectLable.TabIndex = 78;
            this.subjectLable.Text = "Subject:";
            // 
            // SentMailShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 620);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.attachLable);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.subjectLable);
            this.Name = "SentMailShow";
            this.Text = "Sent Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Label attachLable;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label subjectLable;
    }
}