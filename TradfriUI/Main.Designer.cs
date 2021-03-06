﻿namespace TradfriUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnOff = new System.Windows.Forms.Button();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnGWReboot = new System.Windows.Forms.Button();
            this.trbBrightness = new System.Windows.Forms.TrackBar();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(14, 659);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(115, 37);
            this.btnOff.TabIndex = 0;
            this.btnOff.Text = "Turn Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // dgvDevices
            // 
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Location = new System.Drawing.Point(12, 102);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.RowTemplate.Height = 28;
            this.dgvDevices.Size = new System.Drawing.Size(1448, 524);
            this.dgvDevices.TabIndex = 1;
            this.dgvDevices.SelectionChanged += new System.EventHandler(this.dgvDevices_SelectionChanged);
            // 
            // btnOn
            // 
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn.Location = new System.Drawing.Point(1345, 659);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(115, 37);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "Turn On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnGWReboot
            // 
            this.btnGWReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGWReboot.Location = new System.Drawing.Point(14, 43);
            this.btnGWReboot.Name = "btnGWReboot";
            this.btnGWReboot.Size = new System.Drawing.Size(212, 37);
            this.btnGWReboot.TabIndex = 3;
            this.btnGWReboot.Text = "Reboot Gateway";
            this.btnGWReboot.UseVisualStyleBackColor = true;
            this.btnGWReboot.Click += new System.EventHandler(this.btnGWReboot_Click);
            // 
            // trbBrightness
            // 
            this.trbBrightness.Location = new System.Drawing.Point(178, 659);
            this.trbBrightness.Name = "trbBrightness";
            this.trbBrightness.Size = new System.Drawing.Size(393, 69);
            this.trbBrightness.TabIndex = 4;
            this.trbBrightness.Value = 7;
            // 
            // btnBrightness
            // 
            this.btnBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrightness.Location = new System.Drawing.Point(178, 711);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(393, 37);
            this.btnBrightness.TabIndex = 5;
            this.btnBrightness.Text = "Apply Brightness";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.ItemHeight = 20;
            this.lbxLog.Location = new System.Drawing.Point(13, 768);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(1447, 224);
            this.lbxLog.TabIndex = 6;
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(631, 711);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(288, 37);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "Apply Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cmbColors
            // 
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(631, 659);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(288, 28);
            this.cmbColors.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1018);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.trbBrightness);
            this.Controls.Add(this.btnGWReboot);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.dgvDevices);
            this.Controls.Add(this.btnOff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnGWReboot;
        private System.Windows.Forms.TrackBar trbBrightness;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cmbColors;
    }
}

