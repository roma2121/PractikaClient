namespace ClientS
{
    partial class Client
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
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            richTextBox1.Location = new System.Drawing.Point(12, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(376, 350);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отключитьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отключитьсяToolStripMenuItem
            // 
            this.отключитьсяToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отключитьсяToolStripMenuItem.Name = "отключитьсяToolStripMenuItem";
            this.отключитьсяToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.отключитьсяToolStripMenuItem.Text = "Отключиться";
            this.отключитьсяToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяToolStripMenuItem_Click);
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            richTextBox2.Location = new System.Drawing.Point(396, 63);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(376, 350);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(12, 39);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(159, 21);
            this.input.TabIndex = 3;
            this.input.Text = "Входящие  данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(392, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Расшифрованные данные";
            // 
            // send_button
            // 
            this.send_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_button.Location = new System.Drawing.Point(628, 419);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(144, 29);
            this.send_button.TabIndex = 5;
            this.send_button.Text = "Расшифровать";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(richTextBox2);
            this.Controls.Add(richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяToolStripMenuItem;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_button;
        private static System.Windows.Forms.RichTextBox richTextBox2;
        private static System.Windows.Forms.RichTextBox richTextBox1;
    }
}