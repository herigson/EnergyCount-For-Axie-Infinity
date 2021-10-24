
using System.Drawing;

namespace EnergyCount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnOneMoreEnergy = new System.Windows.Forms.Button();
            this.btnOneLessEnergy = new System.Windows.Forms.Button();
            this.btnOneEnergyGained = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.roundPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRoundCountDisplay = new System.Windows.Forms.Label();
            this.lblEnergyDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BackColor = Color.RosyBrown;
            this.TransparencyKey = Color.RosyBrown;
            this.SuspendLayout();
            // 
            // btnOneMoreEnergy
            // 
            this.btnOneMoreEnergy.AllowDrop = true;
            this.btnOneMoreEnergy.BackColor = System.Drawing.Color.Transparent;
            this.btnOneMoreEnergy.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefault.png");
            this.btnOneMoreEnergy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOneMoreEnergy.FlatAppearance.BorderSize = 0;
            this.btnOneMoreEnergy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOneMoreEnergy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOneMoreEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneMoreEnergy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneMoreEnergy.ForeColor = System.Drawing.Color.Transparent;
            this.btnOneMoreEnergy.Location = new System.Drawing.Point(77, 190);
            this.btnOneMoreEnergy.Margin = new System.Windows.Forms.Padding(0);
            this.btnOneMoreEnergy.Name = "btnOneMoreEnergy";
            this.btnOneMoreEnergy.Size = new System.Drawing.Size(180, 52);
            this.btnOneMoreEnergy.TabIndex = 1;
            this.btnOneMoreEnergy.Text = "+1 Energy Used";
            this.btnOneMoreEnergy.UseVisualStyleBackColor = false;
            this.btnOneMoreEnergy.TabStop = false;
            this.btnOneMoreEnergy.Click += new System.EventHandler(this.btnOneMoreEnergy_Click);
            this.btnOneMoreEnergy.MouseEnter += new System.EventHandler(this.btnOneMoreEnergy_MouseEnter);
            this.btnOneMoreEnergy.MouseLeave += new System.EventHandler(this.btnOneMoreEnergy_MouseLeave);
            // 
            // btnOneLessEnergy
            // 
            this.btnOneLessEnergy.BackColor = System.Drawing.Color.Transparent;
            this.btnOneLessEnergy.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefault.png");
            this.btnOneLessEnergy.FlatAppearance.BorderSize = 0;
            this.btnOneLessEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneLessEnergy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneLessEnergy.ForeColor = System.Drawing.Color.Transparent;
            this.btnOneLessEnergy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOneLessEnergy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOneLessEnergy.Location = new System.Drawing.Point(77, 261);
            this.btnOneLessEnergy.Name = "btnOneLessEnergy";
            this.btnOneLessEnergy.Size = new System.Drawing.Size(180, 52);
            this.btnOneLessEnergy.TabIndex = 2;
            this.btnOneLessEnergy.Text = "+1 Energy Destroyed";
            this.btnOneLessEnergy.UseVisualStyleBackColor = false;
            this.btnOneLessEnergy.TabStop = false;
            this.btnOneLessEnergy.Click += new System.EventHandler(this.btnOneLessEnergy_Click);
            this.btnOneLessEnergy.MouseEnter += new System.EventHandler(this.btnOneLessEnergy_MouseEnter);
            this.btnOneLessEnergy.MouseLeave += new System.EventHandler(this.btnOneLessEnergy_MouseLeave);
            // 
            // btnOneEnergyGained
            // 
            this.btnOneEnergyGained.BackColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefault.png");
            this.btnOneEnergyGained.FlatAppearance.BorderSize = 0;
            this.btnOneEnergyGained.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneEnergyGained.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneEnergyGained.ForeColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.Location = new System.Drawing.Point(77, 332);
            this.btnOneEnergyGained.Name = "btnOneEnergyGained";
            this.btnOneEnergyGained.Size = new System.Drawing.Size(180, 52);
            this.btnOneEnergyGained.TabIndex = 3;
            this.btnOneEnergyGained.Text = "+1 Energy Gained";
            this.btnOneEnergyGained.UseVisualStyleBackColor = false;
            this.btnOneEnergyGained.TabStop = false;
            this.btnOneEnergyGained.Click += new System.EventHandler(this.btnOneEnergyGained_Click);
            this.btnOneEnergyGained.MouseEnter += new System.EventHandler(this.btnOneEnergyGained_MouseEnter);
            this.btnOneEnergyGained.MouseLeave += new System.EventHandler(this.btnOneEnergyGained_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnReset.png");
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(12, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 43);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnEndTurn.png");
            this.btnEndTurn.FlatAppearance.BorderSize = 0;
            this.btnEndTurn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndTurn.Location = new System.Drawing.Point(173, 395);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(150, 43);
            this.btnEndTurn.TabIndex = 5;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.TabStop = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            this.btnEndTurn.MouseEnter += new System.EventHandler(this.btnEndTurn_MouseEnter);
            this.btnEndTurn.MouseLeave += new System.EventHandler(this.btnEndTurn_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnClose.png");
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(292, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnergy.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergy.ForeColor = System.Drawing.Color.Black;
            this.lblEnergy.Location = new System.Drawing.Point(75, 111);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(94, 35);
            this.lblEnergy.TabStop = true;
            this.lblEnergy.Text = "Energy";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRound.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRound.ForeColor = System.Drawing.Color.Black;
            this.lblRound.Location = new System.Drawing.Point(75, 64);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(82, 35);
            this.lblRound.TabStop = true;
            this.lblRound.Text = "Round";
            // 
            // roundPictureBox
            // 
            this.roundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.roundPictureBox.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\RoundImg.png");
            this.roundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPictureBox.Location = new System.Drawing.Point(42, 64);
            this.roundPictureBox.Name = "roundPictureBox";
            this.roundPictureBox.Size = new System.Drawing.Size(27, 30);
            this.roundPictureBox.TabStop = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\EnergyImg.png");
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(42, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 31);
            this.pictureBox1.TabStop = true;
            // 
            // lblRoundCountDisplay
            // 
            this.lblRoundCountDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundCountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRoundCountDisplay.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoundCountDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblRoundCountDisplay.Image = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\DisplayItemIMG.png");
            this.lblRoundCountDisplay.Location = new System.Drawing.Point(217, 51);
            this.lblRoundCountDisplay.Name = "lblRoundCountDisplay";
            this.lblRoundCountDisplay.Size = new System.Drawing.Size(51, 51);
            this.lblRoundCountDisplay.TabStop = true;
            this.lblRoundCountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRoundCountDisplay.Click += new System.EventHandler(this.lblRoundCountDisplay_Click);
            // 
            // lblEnergyDisplay
            // 
            this.lblEnergyDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnergyDisplay.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblEnergyDisplay.Image  = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\DisplayItemIMG.png");
            this.lblEnergyDisplay.Location = new System.Drawing.Point(217, 105);
            this.lblEnergyDisplay.Name = "lblEnergyDisplay";
            this.lblEnergyDisplay.Size = new System.Drawing.Size(51, 51);
            this.lblEnergyDisplay.TabStop = true;
            this.lblEnergyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\BackGround.png");
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.lblEnergyDisplay);
            this.Controls.Add(this.lblRoundCountDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundPictureBox);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOneEnergyGained);
            this.Controls.Add(this.btnOneLessEnergy);
            this.Controls.Add(this.btnOneMoreEnergy);
            this.Controls.Add(this.btnEndTurn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnOneMoreEnergy;
        private System.Windows.Forms.Button btnOneLessEnergy;
        private System.Windows.Forms.Button btnOneEnergyGained;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.PictureBox roundPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRoundCountDisplay;
        private System.Windows.Forms.Label lblEnergyDisplay;
    }
}

