
namespace _9gyak_U50QDT
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
            this.ZaroevNUD = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.zaroevlabel = new System.Windows.Forms.Label();
            this.nepfajlLabel = new System.Windows.Forms.Label();
            this.fileTextbox = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZaroevNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ZaroevNUD
            // 
            this.ZaroevNUD.Location = new System.Drawing.Point(89, 13);
            this.ZaroevNUD.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.ZaroevNUD.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.ZaroevNUD.Name = "ZaroevNUD";
            this.ZaroevNUD.Size = new System.Drawing.Size(57, 20);
            this.ZaroevNUD.TabIndex = 0;
            this.ZaroevNUD.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 399);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // zaroevlabel
            // 
            this.zaroevlabel.AutoSize = true;
            this.zaroevlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaroevlabel.Location = new System.Drawing.Point(8, 9);
            this.zaroevlabel.Name = "zaroevlabel";
            this.zaroevlabel.Size = new System.Drawing.Size(75, 24);
            this.zaroevlabel.TabIndex = 3;
            this.zaroevlabel.Text = "Záróév";
            // 
            // nepfajlLabel
            // 
            this.nepfajlLabel.AutoSize = true;
            this.nepfajlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nepfajlLabel.Location = new System.Drawing.Point(187, 12);
            this.nepfajlLabel.Name = "nepfajlLabel";
            this.nepfajlLabel.Size = new System.Drawing.Size(137, 24);
            this.nepfajlLabel.TabIndex = 4;
            this.nepfajlLabel.Text = "Népesség fájl";
            // 
            // fileTextbox
            // 
            this.fileTextbox.Location = new System.Drawing.Point(330, 14);
            this.fileTextbox.Name = "fileTextbox";
            this.fileTextbox.Size = new System.Drawing.Size(292, 20);
            this.fileTextbox.TabIndex = 5;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(628, 10);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 6;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(709, 10);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.fileTextbox);
            this.Controls.Add(this.nepfajlLabel);
            this.Controls.Add(this.zaroevlabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ZaroevNUD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ZaroevNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ZaroevNUD;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label zaroevlabel;
        private System.Windows.Forms.Label nepfajlLabel;
        private System.Windows.Forms.TextBox fileTextbox;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnStart;
    }
}

