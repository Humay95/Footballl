namespace Futbol
{
    partial class ClientDashboard
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
            this.PhoneClient = new System.Windows.Forms.TextBox();
            this.LastNameClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNamecClient = new System.Windows.Forms.TextBox();
            this.AddButtonClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneClient
            // 
            this.PhoneClient.Location = new System.Drawing.Point(539, 287);
            this.PhoneClient.Multiline = true;
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.Size = new System.Drawing.Size(211, 29);
            this.PhoneClient.TabIndex = 16;
            // 
            // LastNameClient
            // 
            this.LastNameClient.Location = new System.Drawing.Point(482, 224);
            this.LastNameClient.Multiline = true;
            this.LastNameClient.Name = "LastNameClient";
            this.LastNameClient.Size = new System.Drawing.Size(211, 29);
            this.LastNameClient.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(298, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Firstname:";
            // 
            // FirstNamecClient
            // 
            this.FirstNamecClient.Location = new System.Drawing.Point(414, 166);
            this.FirstNamecClient.Multiline = true;
            this.FirstNamecClient.Name = "FirstNamecClient";
            this.FirstNamecClient.Size = new System.Drawing.Size(211, 29);
            this.FirstNamecClient.TabIndex = 13;
            // 
            // AddButtonClient
            // 
            this.AddButtonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddButtonClient.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButtonClient.ForeColor = System.Drawing.Color.White;
            this.AddButtonClient.Location = new System.Drawing.Point(599, 373);
            this.AddButtonClient.Name = "AddButtonClient";
            this.AddButtonClient.Size = new System.Drawing.Size(257, 55);
            this.AddButtonClient.TabIndex = 12;
            this.AddButtonClient.Text = "Add";
            this.AddButtonClient.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(95, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 111);
            this.panel1.TabIndex = 9;
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 653);
            this.Controls.Add(this.PhoneClient);
            this.Controls.Add(this.LastNameClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstNamecClient);
            this.Controls.Add(this.AddButtonClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientDashboard";
            this.Text = "ClientDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneClient;
        private System.Windows.Forms.TextBox LastNameClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNamecClient;
        private System.Windows.Forms.Button AddButtonClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}