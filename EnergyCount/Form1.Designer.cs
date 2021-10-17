
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
            this.energyDisplay = new System.Windows.Forms.TextBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnOneMoreEnergy = new System.Windows.Forms.Button();
            this.btnOneLessEnergy = new System.Windows.Forms.Button();
            this.btnOneEnergyGained = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // energyDisplay
            // 
            this.energyDisplay.Location = new System.Drawing.Point(49, 52);
            this.energyDisplay.Name = "energyDisplay";
            this.energyDisplay.Size = new System.Drawing.Size(231, 23);
            this.energyDisplay.TabIndex = 0;
            this.energyDisplay.TextChanged += new System.EventHandler(this.energyDisplay_TextChanged);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(177, 393);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(103, 23);
            this.btnEndTurn.TabIndex = 1;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnOneMoreEnergy
            // 
            this.btnOneMoreEnergy.Location = new System.Drawing.Point(49, 127);
            this.btnOneMoreEnergy.Name = "btnOneMoreEnergy";
            this.btnOneMoreEnergy.Size = new System.Drawing.Size(231, 23);
            this.btnOneMoreEnergy.TabIndex = 2;
            this.btnOneMoreEnergy.Text = "+1 Energy Used";
            this.btnOneMoreEnergy.UseVisualStyleBackColor = true;
            this.btnOneMoreEnergy.Click += new System.EventHandler(this.btnOneMoreEnergy_Click);
            // 
            // btnOneLessEnergy
            // 
            this.btnOneLessEnergy.Location = new System.Drawing.Point(49, 192);
            this.btnOneLessEnergy.Name = "btnOneLessEnergy";
            this.btnOneLessEnergy.Size = new System.Drawing.Size(231, 23);
            this.btnOneLessEnergy.TabIndex = 3;
            this.btnOneLessEnergy.Text = "+1 Energy Destroyed";
            this.btnOneLessEnergy.UseVisualStyleBackColor = true;
            this.btnOneLessEnergy.Click += new System.EventHandler(this.btnOneLessEnergy_Click);
            // 
            // btnOneEnergyGained
            // 
            this.btnOneEnergyGained.Location = new System.Drawing.Point(49, 252);
            this.btnOneEnergyGained.Name = "btnOneEnergyGained";
            this.btnOneEnergyGained.Size = new System.Drawing.Size(231, 23);
            this.btnOneEnergyGained.TabIndex = 4;
            this.btnOneEnergyGained.Text = "+1 Energy Gained";
            this.btnOneEnergyGained.UseVisualStyleBackColor = true;
            this.btnOneEnergyGained.Click += new System.EventHandler(this.btnOneEnergyGained_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(49, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOneEnergyGained);
            this.Controls.Add(this.btnOneLessEnergy);
            this.Controls.Add(this.btnOneMoreEnergy);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.energyDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox energyDisplay;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnOneMoreEnergy;
        private System.Windows.Forms.Button btnOneLessEnergy;
        private System.Windows.Forms.Button btnOneEnergyGained;
        private System.Windows.Forms.Button btnReset;
    }
}

