using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyCount
{
    public partial class Form1 : Form
    {
        public int Round { get; set; }
        public int Energy { get; set; }
        public int UsedEnergy { get; set; }
        public Form1()
        {
            InitializeComponent();
            setDefaultValues();
            energyDisplay.Text = Energy.ToString();
        }


        private void energyDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {

            AddEnergy(2);
            Round++;
            UsedEnergy = 0;
            refreshEnergyDisplay();


        }

        private void refreshEnergyDisplay()
        {
            energyDisplay.Text = Energy.ToString();
        }

        private void btnOneMoreEnergy_Click(object sender, EventArgs e)
        {

            UseEnergy();
            refreshEnergyDisplay();
        }

        private void btnOneLessEnergy_Click(object sender, EventArgs e)
        {
            if (Energy > 0)
            {
                Energy--;
            }

            refreshEnergyDisplay();
        }

        private void btnOneEnergyGained_Click(object sender, EventArgs e)
        {
            AddEnergy(1);
            refreshEnergyDisplay();
        }

        private void AddEnergy(int value)
        {
            if (Energy < 10)
                Energy += value;
            if (Energy > 10)
                Energy = 10;
            Round++;
        }

        private void UseEnergy()
        {
            if(Energy > 0)
            {
                UsedEnergy++;
                Energy--;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setDefaultValues();
            refreshEnergyDisplay();
        }

        private void setDefaultValues()
        {
            Energy = 3;
            Round = 1;
            UsedEnergy = 0;
        }
    }
}
