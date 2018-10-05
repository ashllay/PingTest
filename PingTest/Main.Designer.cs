namespace PingTest
{
    partial class Main
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
            this.Txb_IP = new System.Windows.Forms.TextBox();
            this.Txb_Port = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.LbPing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Txb_IP
            // 
            this.Txb_IP.Location = new System.Drawing.Point(12, 27);
            this.Txb_IP.Name = "Txb_IP";
            this.Txb_IP.Size = new System.Drawing.Size(100, 20);
            this.Txb_IP.TabIndex = 0;
            // 
            // Txb_Port
            // 
            this.Txb_Port.Location = new System.Drawing.Point(118, 27);
            this.Txb_Port.Name = "Txb_Port";
            this.Txb_Port.Size = new System.Drawing.Size(38, 20);
            this.Txb_Port.TabIndex = 1;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(226, 25);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(45, 23);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // LbPing
            // 
            this.LbPing.AutoSize = true;
            this.LbPing.Location = new System.Drawing.Point(162, 30);
            this.LbPing.Name = "LbPing";
            this.LbPing.Size = new System.Drawing.Size(13, 13);
            this.LbPing.TabIndex = 3;
            this.LbPing.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 138);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 203);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbPing);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Txb_Port);
            this.Controls.Add(this.Txb_IP);
            this.Name = "Main";
            this.Text = "Ping Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_IP;
        private System.Windows.Forms.TextBox Txb_Port;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label LbPing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

