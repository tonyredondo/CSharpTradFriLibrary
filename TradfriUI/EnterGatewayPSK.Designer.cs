﻿namespace TradfriUI
{
    partial class EnterGatewayPSK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterGatewayPSK));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.lblAppSecret = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(226, 343);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(363, 45);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAppSecret
            // 
            this.txtAppSecret.Location = new System.Drawing.Point(330, 203);
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.Size = new System.Drawing.Size(298, 26);
            this.txtAppSecret.TabIndex = 8;
            // 
            // lblAppSecret
            // 
            this.lblAppSecret.AutoSize = true;
            this.lblAppSecret.Location = new System.Drawing.Point(173, 206);
            this.lblAppSecret.Name = "lblAppSecret";
            this.lblAppSecret.Size = new System.Drawing.Size(139, 20);
            this.lblAppSecret.TabIndex = 7;
            this.lblAppSecret.Text = "Application secret:";
            // 
            // txtAppName
            // 
            this.txtAppName.Enabled = false;
            this.txtAppName.Location = new System.Drawing.Point(330, 118);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(298, 26);
            this.txtAppName.TabIndex = 6;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(173, 121);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(135, 20);
            this.lblAppName.TabIndex = 5;
            this.lblAppName.Text = "Application name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your application name which is written in app.config.";
            // 
            // EnterGatewayPSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAppSecret);
            this.Controls.Add(this.lblAppSecret);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.lblAppName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterGatewayPSK";
            this.Text = "Enter Original Gateway PSK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.Label lblAppSecret;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label label1;
    }
}