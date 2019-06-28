namespace Ana2CSV
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
            this.TBPath = new System.Windows.Forms.TextBox();
            this.BTConvert = new System.Windows.Forms.Button();
            this.BTBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPath
            // 
            this.TBPath.Location = new System.Drawing.Point(39, 36);
            this.TBPath.Name = "TBPath";
            this.TBPath.Size = new System.Drawing.Size(638, 20);
            this.TBPath.TabIndex = 0;
            // 
            // BTConvert
            // 
            this.BTConvert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTConvert.Location = new System.Drawing.Point(39, 108);
            this.BTConvert.Name = "BTConvert";
            this.BTConvert.Size = new System.Drawing.Size(75, 23);
            this.BTConvert.TabIndex = 1;
            this.BTConvert.Text = "BTConvert";
            this.BTConvert.UseVisualStyleBackColor = true;
            this.BTConvert.Click += new System.EventHandler(this.BTConvert_Click);
            // 
            // BTBrowse
            // 
            this.BTBrowse.Location = new System.Drawing.Point(39, 62);
            this.BTBrowse.Name = "BTBrowse";
            this.BTBrowse.Size = new System.Drawing.Size(75, 23);
            this.BTBrowse.TabIndex = 2;
            this.BTBrowse.Text = "Browse";
            this.BTBrowse.UseVisualStyleBackColor = true;
            this.BTBrowse.Click += new System.EventHandler(this.BTBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 208);
            this.Controls.Add(this.BTBrowse);
            this.Controls.Add(this.BTConvert);
            this.Controls.Add(this.TBPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPath;
        internal System.Windows.Forms.Button BTConvert;
        private System.Windows.Forms.Button BTBrowse;
    }
}

