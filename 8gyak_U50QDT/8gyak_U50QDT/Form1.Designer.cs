
namespace _8gyak_U50QDT
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblNext = new System.Windows.Forms.Label();
            this.buttonBall = new System.Windows.Forms.Button();
            this.buttonCar = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonPresent = new System.Windows.Forms.Button();
            this.btnPresentBox = new System.Windows.Forms.Button();
            this.btnPresentRibbon = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnPresentRibbon);
            this.mainPanel.Controls.Add(this.btnPresentBox);
            this.mainPanel.Controls.Add(this.buttonPresent);
            this.mainPanel.Controls.Add(this.buttonColor);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.buttonBall);
            this.mainPanel.Controls.Add(this.buttonCar);
            this.mainPanel.Location = new System.Drawing.Point(3, -2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(796, 455);
            this.mainPanel.TabIndex = 0;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(287, 63);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(87, 53);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(75, 23);
            this.buttonBall.TabIndex = 1;
            this.buttonBall.Text = "BALL";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // buttonCar
            // 
            this.buttonCar.Location = new System.Drawing.Point(6, 53);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(75, 23);
            this.buttonCar.TabIndex = 0;
            this.buttonCar.Text = "CAR";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonColor.Location = new System.Drawing.Point(87, 83);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonPresent
            // 
            this.buttonPresent.Location = new System.Drawing.Point(168, 53);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(75, 23);
            this.buttonPresent.TabIndex = 4;
            this.buttonPresent.Text = "PRESENT";
            this.buttonPresent.UseVisualStyleBackColor = true;
            this.buttonPresent.Click += new System.EventHandler(this.buttonPresent_Click);
            // 
            // btnPresentBox
            // 
            this.btnPresentBox.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPresentBox.Location = new System.Drawing.Point(168, 83);
            this.btnPresentBox.Name = "btnPresentBox";
            this.btnPresentBox.Size = new System.Drawing.Size(75, 23);
            this.btnPresentBox.TabIndex = 5;
            this.btnPresentBox.UseVisualStyleBackColor = false;
            this.btnPresentBox.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // btnPresentRibbon
            // 
            this.btnPresentRibbon.BackColor = System.Drawing.Color.White;
            this.btnPresentRibbon.Location = new System.Drawing.Point(168, 112);
            this.btnPresentRibbon.Name = "btnPresentRibbon";
            this.btnPresentRibbon.Size = new System.Drawing.Size(75, 23);
            this.btnPresentRibbon.TabIndex = 6;
            this.btnPresentRibbon.UseVisualStyleBackColor = false;
            this.btnPresentRibbon.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button btnPresentRibbon;
        private System.Windows.Forms.Button btnPresentBox;
        private System.Windows.Forms.Button buttonPresent;
    }
}

