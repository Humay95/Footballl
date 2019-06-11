namespace Futbol
{
    partial class Pitchs
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
            this.txtpcname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPitch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numptc = new System.Windows.Forms.NumericUpDown();
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.nmpicnum = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numptc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmpicnum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpcname
            // 
            this.txtpcname.Location = new System.Drawing.Point(449, 159);
            this.txtpcname.Multiline = true;
            this.txtpcname.Name = "txtpcname";
            this.txtpcname.Size = new System.Drawing.Size(219, 35);
            this.txtpcname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 125);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pitchs";
        
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 131);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pitchs name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(244, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pitchs number:";
            // 
            // btnPitch
            // 
            this.btnPitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPitch.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPitch.ForeColor = System.Drawing.Color.White;
            this.btnPitch.Location = new System.Drawing.Point(511, 334);
            this.btnPitch.Name = "btnPitch";
            this.btnPitch.Size = new System.Drawing.Size(354, 60);
            this.btnPitch.TabIndex = 6;
            this.btnPitch.Text = "Add";
            this.btnPitch.UseVisualStyleBackColor = false;
            this.btnPitch.Click += new System.EventHandler(this.BtnPitch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pitchs price:";
            // 
            // numptc
            // 
            this.numptc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numptc.Location = new System.Drawing.Point(449, 269);
            this.numptc.Name = "numptc";
            this.numptc.Size = new System.Drawing.Size(219, 31);
            this.numptc.TabIndex = 9;
            // 
            // dtgview
            // 
            this.dtgview.BackgroundColor = System.Drawing.Color.Green;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.Location = new System.Drawing.Point(-3, 400);
            this.dtgview.Name = "dtgview";
            this.dtgview.Size = new System.Drawing.Size(596, 137);
            this.dtgview.TabIndex = 10;
            // 
            // nmpicnum
            // 
            this.nmpicnum.Location = new System.Drawing.Point(459, 228);
            this.nmpicnum.Name = "nmpicnum";
            this.nmpicnum.Size = new System.Drawing.Size(120, 20);
            this.nmpicnum.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Purple;
            this.lblError.Location = new System.Drawing.Point(838, 241);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 25);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // Pitchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(996, 538);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.nmpicnum);
            this.Controls.Add(this.dtgview);
            this.Controls.Add(this.numptc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtpcname);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "Pitchs";
            this.Text = "Pitchs";
            this.Load += new System.EventHandler(this.Pitchs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numptc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmpicnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpcname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numptc;
        private System.Windows.Forms.DataGridView dtgview;
        private System.Windows.Forms.NumericUpDown nmpicnum;
        private System.Windows.Forms.Label lblError;
    }
}