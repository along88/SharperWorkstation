﻿namespace WindowsFormsApplication1
{
    partial class SharperWorkstation
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
            this.dgViewSOV = new System.Windows.Forms.DataGridView();
            this.txtControlNo = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.controlNumberLabel = new System.Windows.Forms.Label();
            this.Editbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSOV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewSOV
            // 
            this.dgViewSOV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSOV.Location = new System.Drawing.Point(0, 38);
            this.dgViewSOV.Name = "dgViewSOV";
            this.dgViewSOV.Size = new System.Drawing.Size(719, 318);
            this.dgViewSOV.TabIndex = 0;
            // 
            // txtControlNo
            // 
            this.txtControlNo.Location = new System.Drawing.Point(277, 12);
            this.txtControlNo.Name = "txtControlNo";
            this.txtControlNo.Size = new System.Drawing.Size(100, 20);
            this.txtControlNo.TabIndex = 5;
            this.txtControlNo.TextChanged += new System.EventHandler(this.txtControlNo_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(591, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // controlNumberLabel
            // 
            this.controlNumberLabel.AutoSize = true;
            this.controlNumberLabel.Location = new System.Drawing.Point(188, 15);
            this.controlNumberLabel.Name = "controlNumberLabel";
            this.controlNumberLabel.Size = new System.Drawing.Size(83, 13);
            this.controlNumberLabel.TabIndex = 7;
            this.controlNumberLabel.Text = "Control Number:";
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(520, 10);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(65, 23);
            this.Editbtn.TabIndex = 8;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // LocationComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 355);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.controlNumberLabel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtControlNo);
            this.Controls.Add(this.dgViewSOV);
            this.Name = "LocationComparison";
            this.Text = "Sharper Workstation";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSOV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewSOV;
        private System.Windows.Forms.TextBox txtControlNo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label controlNumberLabel;
        private System.Windows.Forms.Button Editbtn;
    }
}

