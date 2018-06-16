namespace GraduateApplication
{
    partial class ForgotPassword
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
            this.sendPassButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.questionLable = new System.Windows.Forms.Label();
            this.ansLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendPassButton
            // 
            this.sendPassButton.Location = new System.Drawing.Point(271, 162);
            this.sendPassButton.Name = "sendPassButton";
            this.sendPassButton.Size = new System.Drawing.Size(104, 23);
            this.sendPassButton.TabIndex = 0;
            this.sendPassButton.Text = "Send Password";
            this.sendPassButton.UseVisualStyleBackColor = true;
            this.sendPassButton.Click += new System.EventHandler(this.sendPassButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(166, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // questionLable
            // 
            this.questionLable.AutoSize = true;
            this.questionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLable.Location = new System.Drawing.Point(41, 52);
            this.questionLable.Name = "questionLable";
            this.questionLable.Size = new System.Drawing.Size(62, 15);
            this.questionLable.TabIndex = 2;
            this.questionLable.Text = "Question: ";
            // 
            // ansLable
            // 
            this.ansLable.AutoSize = true;
            this.ansLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansLable.Location = new System.Drawing.Point(41, 95);
            this.ansLable.Name = "ansLable";
            this.ansLable.Size = new System.Drawing.Size(50, 15);
            this.ansLable.TabIndex = 3;
            this.ansLable.Text = "Answer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 221);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ansLable);
            this.Controls.Add(this.questionLable);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendPassButton);
            this.Name = "ForgotPassword";
            this.Text = "Forgot your password?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendPassButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label questionLable;
        private System.Windows.Forms.Label ansLable;
        private System.Windows.Forms.TextBox textBox1;
    }
}