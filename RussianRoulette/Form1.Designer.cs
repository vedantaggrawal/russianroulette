namespace RussianRoulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PointHeadRB = new System.Windows.Forms.RadioButton();
            this.PointAwayRB = new System.Windows.Forms.RadioButton();
            this.sHead = new System.Windows.Forms.PictureBox();
            this.sGun = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LifelineTB = new System.Windows.Forms.TextBox();
            this.FireButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.bulletCount = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SpinButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.LossLabel = new System.Windows.Forms.Label();
            this.lossCount = new System.Windows.Forms.Label();
            this.winCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PointHeadRB
            // 
            this.PointHeadRB.AutoSize = true;
            this.PointHeadRB.Location = new System.Drawing.Point(527, 32);
            this.PointHeadRB.Name = "PointHeadRB";
            this.PointHeadRB.Size = new System.Drawing.Size(90, 17);
            this.PointHeadRB.TabIndex = 0;
            this.PointHeadRB.TabStop = true;
            this.PointHeadRB.Text = "Point at Head";
            this.PointHeadRB.UseVisualStyleBackColor = true;
            // 
            // PointAwayRB
            // 
            this.PointAwayRB.AutoSize = true;
            this.PointAwayRB.Location = new System.Drawing.Point(527, 66);
            this.PointAwayRB.Name = "PointAwayRB";
            this.PointAwayRB.Size = new System.Drawing.Size(78, 17);
            this.PointAwayRB.TabIndex = 1;
            this.PointAwayRB.TabStop = true;
            this.PointAwayRB.Text = "Point Away";
            this.PointAwayRB.UseVisualStyleBackColor = true;
            this.PointAwayRB.CheckedChanged += new System.EventHandler(this.PointAwayRB_CheckedChanged);
            // 
            // sHead
            // 
            this.sHead.Image = ((System.Drawing.Image)(resources.GetObject("sHead.Image")));
            this.sHead.Location = new System.Drawing.Point(28, 32);
            this.sHead.Name = "sHead";
            this.sHead.Size = new System.Drawing.Size(195, 172);
            this.sHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sHead.TabIndex = 2;
            this.sHead.TabStop = false;
            // 
            // sGun
            // 
            this.sGun.Image = ((System.Drawing.Image)(resources.GetObject("sGun.Image")));
            this.sGun.Location = new System.Drawing.Point(229, 32);
            this.sGun.Name = "sGun";
            this.sGun.Size = new System.Drawing.Size(279, 172);
            this.sGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sGun.TabIndex = 3;
            this.sGun.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shots Fired";
            
            // 
            // LifelineTB
            // 
            this.LifelineTB.Location = new System.Drawing.Point(527, 101);
            this.LifelineTB.Name = "LifelineTB";
            this.LifelineTB.Size = new System.Drawing.Size(139, 20);
            this.LifelineTB.TabIndex = 5;
            this.LifelineTB.Text = "You have 2 chances left!";
            
            // 
            // FireButton
            // 
            this.FireButton.Enabled = false;
            this.FireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireButton.Location = new System.Drawing.Point(24, 398);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(642, 40);
            this.FireButton.TabIndex = 8;
            this.FireButton.Text = "FIRE";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(528, 134);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(140, 42);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Load Bullet";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // bulletCount
            // 
            this.bulletCount.Location = new System.Drawing.Point(12, 322);
            this.bulletCount.Maximum = 6;
            this.bulletCount.Name = "bulletCount";
            this.bulletCount.Size = new System.Drawing.Size(654, 45);
            this.bulletCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "6";
            // 
            // SpinButton
            // 
            this.SpinButton.Enabled = false;
            this.SpinButton.Location = new System.Drawing.Point(528, 192);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(140, 42);
            this.SpinButton.TabIndex = 16;
            this.SpinButton.Text = "Spin Chambers";
            this.SpinButton.UseVisualStyleBackColor = true;
            this.SpinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Enabled = false;
            this.RestartButton.Location = new System.Drawing.Point(528, 249);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(140, 42);
            this.RestartButton.TabIndex = 17;
            this.RestartButton.Text = "Play Again";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(47, 232);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(34, 13);
            this.winLabel.TabIndex = 18;
            this.winLabel.Text = "Wins:";
            // 
            // LossLabel
            // 
            this.LossLabel.AutoSize = true;
            this.LossLabel.Location = new System.Drawing.Point(47, 278);
            this.LossLabel.Name = "LossLabel";
            this.LossLabel.Size = new System.Drawing.Size(43, 13);
            this.LossLabel.TabIndex = 19;
            this.LossLabel.Text = "Losses:";
            // 
            // lossCount
            // 
            this.lossCount.AutoSize = true;
            this.lossCount.Location = new System.Drawing.Point(96, 278);
            this.lossCount.Name = "lossCount";
            this.lossCount.Size = new System.Drawing.Size(13, 13);
            this.lossCount.TabIndex = 20;
            this.lossCount.Text = "0";
            // 
            // winCount
            // 
            this.winCount.AutoSize = true;
            this.winCount.Location = new System.Drawing.Point(96, 232);
            this.winCount.Name = "winCount";
            this.winCount.Size = new System.Drawing.Size(13, 13);
            this.winCount.TabIndex = 21;
            this.winCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.winCount);
            this.Controls.Add(this.lossCount);
            this.Controls.Add(this.LossLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.SpinButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bulletCount);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.LifelineTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sGun);
            this.Controls.Add(this.sHead);
            this.Controls.Add(this.PointAwayRB);
            this.Controls.Add(this.PointHeadRB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PointHeadRB;
        private System.Windows.Forms.RadioButton PointAwayRB;
        private System.Windows.Forms.PictureBox sHead;
        private System.Windows.Forms.PictureBox sGun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LifelineTB;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TrackBar bulletCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SpinButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label LossLabel;
        private System.Windows.Forms.Label lossCount;
        private System.Windows.Forms.Label winCount;
    }
}

