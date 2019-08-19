namespace MyGalaxy
{
    partial class OTPForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBPassword10min = new System.Windows.Forms.Label();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.BTNClearRTB1 = new System.Windows.Forms.Button();
            this.LBPassword1s = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RTB2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTP（10分钟）";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "六位动态口令";
            // 
            // LBPassword10min
            // 
            this.LBPassword10min.AutoSize = true;
            this.LBPassword10min.BackColor = System.Drawing.Color.Yellow;
            this.LBPassword10min.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPassword10min.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBPassword10min.Location = new System.Drawing.Point(111, 37);
            this.LBPassword10min.Name = "LBPassword10min";
            this.LBPassword10min.Size = new System.Drawing.Size(70, 22);
            this.LBPassword10min.TabIndex = 3;
            this.LBPassword10min.Text = "      ";
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(12, 127);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(441, 282);
            this.RTB1.TabIndex = 4;
            this.RTB1.Text = "";
            // 
            // BTNClearRTB1
            // 
            this.BTNClearRTB1.Location = new System.Drawing.Point(378, 415);
            this.BTNClearRTB1.Name = "BTNClearRTB1";
            this.BTNClearRTB1.Size = new System.Drawing.Size(75, 23);
            this.BTNClearRTB1.TabIndex = 5;
            this.BTNClearRTB1.Text = "清空显示";
            this.BTNClearRTB1.UseVisualStyleBackColor = true;
            this.BTNClearRTB1.Click += new System.EventHandler(this.BTNClearRTB1_Click);
            // 
            // LBPassword1s
            // 
            this.LBPassword1s.AutoSize = true;
            this.LBPassword1s.BackColor = System.Drawing.Color.Yellow;
            this.LBPassword1s.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPassword1s.ForeColor = System.Drawing.Color.DarkBlue;
            this.LBPassword1s.Location = new System.Drawing.Point(111, 65);
            this.LBPassword1s.Name = "LBPassword1s";
            this.LBPassword1s.Size = new System.Drawing.Size(70, 22);
            this.LBPassword1s.TabIndex = 6;
            this.LBPassword1s.Text = "      ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "OTP（one second）";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // RTB2
            // 
            this.RTB2.Location = new System.Drawing.Point(482, 127);
            this.RTB2.Name = "RTB2";
            this.RTB2.Size = new System.Drawing.Size(230, 187);
            this.RTB2.TabIndex = 8;
            this.RTB2.Text = "";
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTB2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBPassword1s);
            this.Controls.Add(this.BTNClearRTB1);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.LBPassword10min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "OTPForm";
            this.Text = "OTPForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBPassword10min;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Button BTNClearRTB1;
        private System.Windows.Forms.Label LBPassword1s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox RTB2;
    }
}