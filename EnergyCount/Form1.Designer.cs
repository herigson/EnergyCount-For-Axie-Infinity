
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
            this.SuspendLayout();
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndTurn.BackgroundImage")));
            this.btnEndTurn.FlatAppearance.BorderSize = 0;
            this.btnEndTurn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndTurn.Location = new System.Drawing.Point(173, 395);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(150, 43);
            this.btnEndTurn.TabIndex = 1;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.UseWaitCursor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnOneMoreEnergy
            // 
            this.btnOneMoreEnergy.AllowDrop = true;
            this.btnOneMoreEnergy.BackColor = System.Drawing.Color.Transparent;
            this.btnOneMoreEnergy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOneMoreEnergy.BackgroundImage")));
            this.btnOneMoreEnergy.FlatAppearance.BorderSize = 0;
            this.btnOneMoreEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneMoreEnergy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneMoreEnergy.ForeColor = System.Drawing.Color.Transparent;
            this.btnOneMoreEnergy.Location = new System.Drawing.Point(77, 190);
            this.btnOneMoreEnergy.Margin = new System.Windows.Forms.Padding(0);
            this.btnOneMoreEnergy.Name = "btnOneMoreEnergy";
            this.btnOneMoreEnergy.Size = new System.Drawing.Size(180, 52);
            this.btnOneMoreEnergy.TabIndex = 2;
            this.btnOneMoreEnergy.Text = "+1 Energy Used";
            this.btnOneMoreEnergy.UseVisualStyleBackColor = false;
            this.btnOneMoreEnergy.UseWaitCursor = true;
            this.btnOneMoreEnergy.Click += new System.EventHandler(this.btnOneMoreEnergy_Click);
            // 
            // btnOneLessEnergy
            // 
            this.btnOneLessEnergy.BackColor = System.Drawing.Color.Transparent;
            this.btnOneLessEnergy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOneLessEnergy.BackgroundImage")));
            this.btnOneLessEnergy.FlatAppearance.BorderSize = 0;
            this.btnOneLessEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneLessEnergy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneLessEnergy.ForeColor = System.Drawing.Color.Transparent;
            this.btnOneLessEnergy.Location = new System.Drawing.Point(77, 261);
            this.btnOneLessEnergy.Name = "btnOneLessEnergy";
            this.btnOneLessEnergy.Size = new System.Drawing.Size(180, 52);
            this.btnOneLessEnergy.TabIndex = 3;
            this.btnOneLessEnergy.Text = "+1 Energy Destroyed";
            this.btnOneLessEnergy.UseVisualStyleBackColor = false;
            this.btnOneLessEnergy.UseWaitCursor = true;
            this.btnOneLessEnergy.Click += new System.EventHandler(this.btnOneLessEnergy_Click);
            // 
            // btnOneEnergyGained
            // 
            this.btnOneEnergyGained.BackColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOneEnergyGained.BackgroundImage")));
            this.btnOneEnergyGained.FlatAppearance.BorderSize = 0;
            this.btnOneEnergyGained.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneEnergyGained.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneEnergyGained.ForeColor = System.Drawing.Color.Transparent;
            this.btnOneEnergyGained.Location = new System.Drawing.Point(77, 332);
            this.btnOneEnergyGained.Name = "btnOneEnergyGained";
            this.btnOneEnergyGained.Size = new System.Drawing.Size(180, 52);
            this.btnOneEnergyGained.TabIndex = 4;
            this.btnOneEnergyGained.Text = "+1 Energy Gained";
            this.btnOneEnergyGained.UseVisualStyleBackColor = false;
            this.btnOneEnergyGained.UseWaitCursor = true;
            this.btnOneEnergyGained.Click += new System.EventHandler(this.btnOneEnergyGained_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(12, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 43);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.UseWaitCursor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(292, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
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
            this.lblEnergy.TabIndex = 7;
            this.lblEnergy.Text = "Energy";
            this.lblEnergy.UseWaitCursor = true;
            this.lblEnergy.Click += new System.EventHandler(this.lblEnergy_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRound.ForeColor = System.Drawing.Color.Black;
            this.lblRound.Location = new System.Drawing.Point(75, 64);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(82, 35);
            this.lblRound.TabIndex = 8;
            this.lblRound.Text = "Round";
            this.lblRound.UseWaitCursor = true;
            // 
            // roundPictureBox
            // 
            this.roundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.roundPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundPictureBox.BackgroundImage")));
            this.roundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPictureBox.Location = new System.Drawing.Point(42, 64);
            this.roundPictureBox.Name = "roundPictureBox";
            this.roundPictureBox.Size = new System.Drawing.Size(27, 30);
            this.roundPictureBox.TabIndex = 9;
            this.roundPictureBox.TabStop = false;
            this.roundPictureBox.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(42, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 31);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // lblRoundCountDisplay
            // 
            this.lblRoundCountDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundCountDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRoundCountDisplay.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoundCountDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblRoundCountDisplay.Image = ((System.Drawing.Image)(resources.GetObject("lblRoundCountDisplay.Image")));
            this.lblRoundCountDisplay.Location = new System.Drawing.Point(217, 51);
            this.lblRoundCountDisplay.Name = "lblRoundCountDisplay";
            this.lblRoundCountDisplay.Size = new System.Drawing.Size(51, 51);
            this.lblRoundCountDisplay.TabIndex = 11;
            this.lblRoundCountDisplay.Text = "1";
            this.lblRoundCountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRoundCountDisplay.UseWaitCursor = true;
            // 
            // lblEnergyDisplay
            // 
            this.lblEnergyDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnergyDisplay.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblEnergyDisplay.Image = ((System.Drawing.Image)(resources.GetObject("lblEnergyDisplay.Image")));
            this.lblEnergyDisplay.Location = new System.Drawing.Point(217, 105);
            this.lblEnergyDisplay.Name = "lblEnergyDisplay";
            this.lblEnergyDisplay.Size = new System.Drawing.Size(51, 51);
            this.lblEnergyDisplay.TabIndex = 12;
            this.lblEnergyDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnergyDisplay.UseWaitCursor = true;
            this.lblEnergyDisplay.Click += new System.EventHandler(this.lblEnergyDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.UseWaitCursor = true;
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

