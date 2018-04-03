namespace Bai02
{
    partial class Form1
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
            this.btnScan = new System.Windows.Forms.Button();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnUDPScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(340, 56);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(94, 35);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "TCP Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(100, 30);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(207, 20);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(234, 106);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(73, 20);
            this.txtTo.TabIndex = 3;
            this.txtTo.Text = "85";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(100, 106);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(75, 20);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.Text = "75";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(520, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(13, 144);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(520, 221);
            this.txtDisplay.TabIndex = 9;
            // 
            // btnUDPScan
            // 
            this.btnUDPScan.Location = new System.Drawing.Point(459, 56);
            this.btnUDPScan.Name = "btnUDPScan";
            this.btnUDPScan.Size = new System.Drawing.Size(94, 35);
            this.btnUDPScan.TabIndex = 10;
            this.btnUDPScan.Text = "UDP Scan";
            this.btnUDPScan.UseVisualStyleBackColor = true;
            this.btnUDPScan.Click += new System.EventHandler(this.btnUDPScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 422);
            this.Controls.Add(this.btnUDPScan);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnUDPScan;
    }
}

