using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlTypes;
using clickerGame;

namespace clickerGame
{
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();
            idleGeneratorWorker.RunWorkerAsync();
        }
        private double money = 0;
        private double totalMoney = 0;
        private double rubberBandPrice = 0.1;
        private double rubberBand = 0;
        private double totalRubberBand = 0;
        private double rubberBandsPerClick = 1;
        bool broughtNews = false;
        int newsClicked = 0;
        Random rnd = new Random();

        private void gameForm_Load(object sender, EventArgs e)
        {

        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            if (broughtNews == false)
            {
                if (money >= 1999.99)
                {
                    money -= 1999.99;
                    updateDisplay("money");
                    broughtNews = true;
                    newsBox.Text = "You have brought the news!";
                    newsButton.Text = "News:";
                    newsButton.Size = new Size(70, 23);
                    newsBox.Location = new Point(101, 18);
                    newsWorker.RunWorkerAsync();
                }
            }
            newsClicked++;
        }
        private void newsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(30000);
                newsWorker.ReportProgress(1);
            }
        }
        clickerGame.news news01 = new clickerGame.news();
        private void NewsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            newsBox.Text = news01.newsList[rnd.Next(0, news01.newsList.Length - 1)];
        }
        public void updateDisplay(string type)
        {
            if (type == "money")
            {
                money = Math.Round(money, 2);
                if (money >= 100000000)
                {
                    moneyAmountBox.Text = ("$" + money.ToString("E8"));
                }
                else
                {
                    moneyAmountBox.Text = "$" + money.ToString("N");
                }
            }
            else if (type == "rubberBand")
            {
                rubberBand = Math.Round(rubberBand, 2);
                if (rubberBand >= 100000000)
                {
                    rubberBandAmountBox.Text = rubberBand.ToString("E8");
                }
                else
                {
                    rubberBandAmountBox.Text = rubberBand.ToString("N");
                }
            }
            else
            {
                errorLabel.Text = "Error: updateDisplay()";
            }
        }
        private void clickerButton_Click(object sender, EventArgs e)
        {
            rubberBand += rubberBandsPerClick;
            updateDisplay("rubberBand");
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            money += rubberBand * rubberBandPrice;
            totalRubberBand += rubberBand;
            totalMoney += rubberBand * rubberBandPrice;
            rubberBand = 0;
            updateDisplay("money");
            updateDisplay("rubberBand");
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //money += 100000;
            //rubberBand += 100000;
            updateDisplay("money");
            updateDisplay("rubberBand");
        }

        private void idleGeneratorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(100);
                idleGeneratorWorker.ReportProgress(1);
            }
        }

        double totalPerSecond = 0;
        double idleMultiplier = 1;
        private void idleGeneratorWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            totalPerSecond = idleMultiplier * (worker01.totalPerSecond + machine01.totalPerSecond + productionLine01.totalPerSecond);
            rubberBand += totalPerSecond / 10;
            updateDisplay("rubberBand");
        }

        private double rubberBandUpgradeCost = 2600;
        private int rubberBandUpgradeAmount = 0;
        private void rubberBandUpgradeButton_Click(object sender, EventArgs e)
        {
            if (money >= rubberBandUpgradeCost)
            {
                rubberBandUpgradeAmount++;
                money -= rubberBandUpgradeCost;
                updateDisplay("money");
                switch (rubberBandUpgradeAmount)
                {
                    case 1:
                        rubberBandPrice = 0.20;
                        rubberBandUpgradeCost = 5600;
                        rubberBandCostUpgrade.Text = "orange rubber band production $0.30 per band $5,600 to buy";
                        break;
                    case 2:
                        rubberBandPrice = 0.30;
                        rubberBandUpgradeCost = 10000;
                        rubberBandCostUpgrade.Text = "extra strong rubber bands $0.35 per band $10,000 to buy";
                        break;
                    case 3:
                        rubberBandPrice = 0.35;
                        rubberBandUpgradeCost = 97000;
                        rubberBandCostUpgrade.Text = "marketing tricks $0.50 per band $97,000 to buy";
                        break;
                    case 4:
                        rubberBandPrice = 0.50;
                        rubberBandUpgradeCost = 320000;
                        rubberBandCostUpgrade.Text = "thicker materials $0.65 per band $320,000 to buy";
                        break;
                    case 5:
                        rubberBandPrice = 0.65;
                        rubberBandUpgradeCost = 500000;
                        rubberBandCostUpgrade.Text = "iBands $0.75 per band $500,000 to buy";
                        break;
                    case 6:
                        rubberBandPrice = 0.75;
                        rubberBandUpgradeCost = 700000;
                        rubberBandCostUpgrade.Text = "Nividia collab special edition rubber bands $1.00 per band $700,000 to buy";
                        break;
                    case 7:
                        rubberBandPrice = 1;
                        rubberBandUpgradeCost = 1300000;
                        rubberBandCostUpgrade.Text = "Pride month rubber bands $1.10 per band $,1300,000 to buy";
                        break;
                    case 8:
                        rubberBandPrice = 1.1;
                        rubberBandUpgradeCost = 2500000;
                        rubberBandCostUpgrade.Text = "Child proof rubber bands $1.25 per band $2,500,000 to buy";
                        break;
                    case 9:
                        rubberBandPrice = 1.25;
                        rubberBandUpgradeCost = 5200000;
                        rubberBandCostUpgrade.Text = "God tier? Rubber bands $1.40 per band $5,200,000 to buy";
                        break;
                    case 10:
                        rubberBandPrice = 1.25;
                        rubberBandUpgradeCost = 99999999.99;
                        rubberBandCostUpgrade.Text = "Elastic bands? $1.60? per band $99,999,999.99 to buy?";
                        break;
                    case 11:
                        rubberBandPrice = 1.60;
                        rubberBandUpgradeCost = 0;
                        rubberBandCostUpgrade.Text = string.Empty;
                        rubberBandCostUpgrade.BackColor = Color.Cyan;
                        break;
                    case 126:
                        rubberBandCostUpgrade.Text = "h?";
                        rubberBandCostUpgrade.BackColor = Color.Green;
                        break;

                }
                moneyButtonLabel.Text = "1 Rubber Band = $" + rubberBandPrice;
            }
        }
        
        idleGenerator worker01 = new idleGenerator(10, 1.3, 4);
        private void workerButtom_Click(object sender, EventArgs e)
        {
            if (money >= worker01.cost)
            {
                money -= worker01.buy();
                updateDisplay("money");
                workerAmountLabel.Text = Convert.ToString(worker01.amount) + " Workers";
                workerRubberBandLabel.Text = Convert.ToString(worker01.rubberBandPerSecond * worker01.amount) + " Rubber Bands Per Second";
                workerButtom.Text = "Factory Worker: $" + worker01.cost.ToString("N") + " To hire";
            }
        }

        idleGenerator machine01 = new idleGenerator(270, 1.5, 14);
        private void machineButton_Click(object sender, EventArgs e)
        {
            if (money >= machine01.cost)
            {
                money -= machine01.buy();
                updateDisplay("money");
                machineAmountLabel.Text = Convert.ToString(machine01.amount) + " Machines";
                machineRubberBandLabel.Text = Convert.ToString(machine01.rubberBandPerSecond * machine01.amount) + " Rubber Bands Per Second";
                machineButton.Text = "Machine: $" + machine01.cost.ToString("N");
            }
        }

        idleGenerator productionLine01 = new idleGenerator(700, 1.5, 30);
        private void productionLineButton_Click(object sender, EventArgs e)
        {
            if (money >= productionLine01.cost)
            {
                money -= productionLine01.buy();
                updateDisplay("money");
                productionLineAmountLabel.Text = Convert.ToString(productionLine01.amount) + " Production Lines";
                ProductionLineRubberBandLabel.Text = Convert.ToString(productionLine01.rubberBandPerSecond * productionLine01.amount) + " Rubber Bands Per Second";
                productionLineButton.Text = "Production Line: $" + productionLine01.cost.ToString("N");
            }
        }

        private void sellAllButton_Click(object sender, EventArgs e)
        {
            if (money >= 15000)
            {
                money -= 15000;
                updateDisplay("money");
                idleMultiplier = idleMultiplier * 1.4;
                sellAllLabel.Text = "Production *" + idleMultiplier;
                sellAllButton.Enabled = false;
            }
        }
    }
    class idleGenerator
    {
        public int amount;
        public double rubberBandPerSecond;
        public double cost;
        public double costMultiplier;
        public double totalPerSecond;

        public idleGenerator(int _cost, double _costMultiplier, double _rubberBandPerSecond)
        {
            cost = _cost;
            costMultiplier = _costMultiplier;
            rubberBandPerSecond = _rubberBandPerSecond;
            amount = 0;
        }

        public double buy()
        {
            amount++;
            cost = cost * costMultiplier;
            totalPerSecond = rubberBandPerSecond * amount;
            return cost / costMultiplier;
        }
    }
}
