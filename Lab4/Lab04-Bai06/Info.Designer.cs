namespace Lab04_Bai06
{
    partial class Info
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DetailTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.DetailTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfirmButton.Location = new System.Drawing.Point(0, 376);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(800, 74);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "OK";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.Ok_Click);
            // 
            // DetailTextBox
            // 
            this.DetailTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailTextBox.Font = new System.Drawing.Font("Merriweather", 12F);
            this.DetailTextBox.Location = new System.Drawing.Point(0, 0);
            this.DetailTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.DetailTextBox.Multiline = true;
            this.DetailTextBox.Name = "DetailTextBox";
            this.DetailTextBox.ReadOnly = true;
            this.DetailTextBox.Size = new System.Drawing.Size(800, 377);
            this.DetailTextBox.TabIndex = 0;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Info";
            this.Text = "Lab04-Bai06";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox DetailTextBox;
    }
}

