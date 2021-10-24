using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
            refreshEnergyDisplay();
        }


        private void refreshEnergyDisplay()
        {
            lblEnergyDisplay.Text = Energy.ToString();
            lblRoundCountDisplay.Text = Round.ToString();
        }

        private void AddEnergy(int value)
        {
            if (Energy < 10)
                Energy += value;
            if (Energy > 10)
                Energy = 10;
        }
        private void IncrementRound()
        {

            Round++;

            if (Round > 99)
                Round = 99;
        }

        private void UseEnergy()
        {
            if (Energy > 0)
            {
                UsedEnergy++;
                Energy--;
            }
        }

        private void btnEndTurn_MouseEnter(object sender, EventArgs e)
        {
            this.btnEndTurn.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnEndTurnDark20.png");
        }

        private void btnEndTurn_MouseLeave(object sender, EventArgs e)
        {
            this.btnEndTurn.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnEndTurn.png");
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            AddEnergy(2);
            IncrementRound();
            UsedEnergy = 0;
            refreshEnergyDisplay();
        }

        private void btnOneMoreEnergy_MouseEnter(object sender, EventArgs e)
        {
            this.btnOneMoreEnergy.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefaultDark20.png");
        }

        private void btnOneMoreEnergy_MouseLeave(object sender, EventArgs e)
        {
            this.btnOneMoreEnergy.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefault.png");
        }
        private void btnOneMoreEnergy_Click(object sender, EventArgs e)
        {

            UseEnergy();
            refreshEnergyDisplay();
        }
        private void btnOneLessEnergy_MouseEnter(object sender, EventArgs e)
        {
            this.btnOneLessEnergy.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefaultDark20.png");
        }

        private void btnOneLessEnergy_MouseLeave(object sender, EventArgs e)
        {
            this.btnOneLessEnergy.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefault.png");
        }
        private void btnOneLessEnergy_Click(object sender, EventArgs e)
        {
            if (Energy > 0)
            {
                Energy--;
            }

            refreshEnergyDisplay();
        }

        private void btnOneEnergyGained_MouseEnter(object sender, EventArgs e)
        {
            this.btnOneEnergyGained.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefaultDark20.png");
        }

        private void btnOneEnergyGained_MouseLeave(object sender, EventArgs e)
        {
            this.btnOneEnergyGained.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnDefault.png");
        }

        private void btnOneEnergyGained_Click(object sender, EventArgs e)
        {
            AddEnergy(1);
            refreshEnergyDisplay();
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            this.btnReset.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnResetDark20.png");
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            this.btnReset.BackgroundImage = Image.FromFile(@"C:\Users\Felipe\source\repos\EnergyCount\EnergyCount\Resources\btnReset.png");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblRoundCountDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
