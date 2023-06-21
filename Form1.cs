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
using System.Security.Cryptography.X509Certificates;

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
        private double rubberBandPrice = 0.1;
        private double rubberBand = 0;
        bool broughtNews = false;
        int newsClicked = 0;
        Random rnd = new Random();
        private void gameForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 650);
            this.CenterToScreen();
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
                if (money >= 100000)
                {
                    moneyAmountBox.Text = ("$" + money.ToString("e4"));
                }
                else
                {
                    moneyAmountBox.Text = "$" + money.ToString("N");
                }
            }
            else if (type == "rubberBand")
            {
                rubberBand = Math.Round(rubberBand, 2);
                if (rubberBand >= 100000)
                {
                    rubberBandAmountBox.Text = rubberBand.ToString("e4");
                }
                else
                {
                    rubberBandAmountBox.Text = rubberBand.ToString("N");
                }
            }
            else if (type == "idleGenerator")
            {
                workerAmountLabel.Text = Convert.ToString(worker01.amount) + " Workers";
                workerRubberBandLabel.Text = Convert.ToString(worker01.rubberBandPerSecond * worker01.amount) + " Rubber Bands Per Second";
                workerButtom.Text = "Factory Worker: $" + worker01.totalCost.ToString("N") + " To hire";

                machineAmountLabel.Text = Convert.ToString(machine01.amount) + " Machines";
                machineRubberBandLabel.Text = Convert.ToString(machine01.rubberBandPerSecond * machine01.amount) + " Rubber Bands Per Second";
                machineButton.Text = "Machine: $" + machine01.totalCost.ToString("N");

                productionLineAmountLabel.Text = Convert.ToString(productionLine01.amount) + " Production Lines";
                ProductionLineRubberBandLabel.Text = Convert.ToString(productionLine01.rubberBandPerSecond * productionLine01.amount) + " Rubber Bands Per Second";
                productionLineButton.Text = "Production Line: $" + productionLine01.totalCost.ToString("N");
            }
            else
            {
                errorLabel.Text = "Error: updateDisplay()";
            }
        }
        private int clickPerSecond = 0;
        private void clickerButton_Click(object sender, EventArgs e)
        {
            rubberBand += 1 + clickerUpgradedTimes * 2;
            updateDisplay("rubberBand");
            clickPerSecond++;
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            money += rubberBand * rubberBandPrice;
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
        private int anticheatTime = 0;
        private void idleGeneratorWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            totalPerSecond = idleMultiplier * (worker01.totalPerSecond + machine01.totalPerSecond + productionLine01.totalPerSecond) * Math.Pow(1.01, nothingAmount);
            rubberBand += totalPerSecond / 10;
            updateDisplay("rubberBand");
            if (clickPerSecond >= 25)
            {
                this.Size = new Size(136, 39);
                clickerButton.Visible = false;
                clickerButton.Visible = true;
            }
            if (anticheatTime >= 10)
            {
            rubberBandPerSecondLabel.Text = "RB/S: " + (totalPerSecond + clickPerSecond * (1 + clickerUpgradedTimes * 2)).ToString("N");
                anticheatTime = 0;
                clickPerSecond = 0;
            }
            else
            {
                anticheatTime++;
            }
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
                        rubberBandCostUpgrade.Text = "COMING SOON!";
                        rubberBandCostUpgrade.BackColor = Color.Green;
                        break;

                }
                moneyButtonLabel.Text = "1 Rubber Band = $" + rubberBandPrice;
            }
        }
        
        idleGenerator worker01 = new idleGenerator(10, 1.1, 4);
        private void workerButtom_Click(object sender, EventArgs e)
        {
            if (money >= worker01.totalCost)
            {
                money -= worker01.buy();
                updateDisplay("money");
                updateDisplay("idleGenerator");
            }
        }
        private void workerUpgradeButton_Click(object sender, EventArgs e)
        {
            if (worker01.amount >= worker01.upgradeExpCost)
            {
                worker01.amount -= worker01.upgradeExpCost;
                worker01.upgrade(1.1, "exp");
                workerUpgradeExpButton.Text = "Upgrade Worker ^ 1.1 costs " + worker01.upgradeExpCost + " workers";
                updateDisplay("idleGenerator");
                UpgradeWorkerLabel.Text = ("Worker Efficiency ^ " + Math.Pow(1.1, worker01.expUpgradeTimes));
            }
        }
        
        private void workerUpgradeAddButton_Click(object sender, EventArgs e)
        {
            if (money >= worker01.upgradeAddCost)
            {
                money -= worker01.upgradeAddCost;
                worker01.upgrade(10, "add");
                updateDisplay("money");
                updateDisplay("idleGenerator");
                workerUpgradeAddButton.Text = "Upgrade Worker +10 costs $" + worker01.upgradeAddCost.ToString("e1");
                WorkerUpgradeAddLabel.Text = "Worker + " + worker01.totalUpgradeAddAmount + " / sec";
            }
        }
        idleGenerator machine01 = new idleGenerator(270, 1.1, 70);
        private void machineButton_Click(object sender, EventArgs e)
        {
            if (money >= machine01.totalCost)
            {
                money -= machine01.buy();
                updateDisplay("money");
                updateDisplay("idleGenerator");
            }
        }

        idleGenerator productionLine01 = new idleGenerator(700, 1.1, 200);
        private void productionLineButton_Click(object sender, EventArgs e)
        {
            if (money >= productionLine01.totalCost)
            {
                money -= productionLine01.buy();
                updateDisplay("money");
                updateDisplay("idleGenerator");
            }
        }

        private void sellAllButton_Click(object sender, EventArgs e)
        {
            if (money >= 15000)
            {
                money -= 15000;
                rubberBand = 0;
                updateDisplay("money");
                updateDisplay("rubberBand");
                idleMultiplier *= 1.4;
                sellAllLabel.Text = "Production * " + idleMultiplier;
                sellAllButton.Enabled = false;

                worker01.clear();
                machine01.clear();
                productionLine01.clear();
                updateDisplay("idleGenerator");
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            //worker01.clear();
            //machine01.clear();
            //productionLine01.clear();
            updateDisplay("idleGenerator");
        }

        private void switchPanel(int panelNumber)
        {
            mainUpgradePanel.Visible = false;
            nothingPanel.Visible = false;
            rubberBandUpgradePanel.Visible = false;
            switch (panelNumber)
            {
                case 0:
                    mainUpgradePanel.Visible = true;
                    mainUpgradePanel.Location = new Point(12, 284);
                    break;
                case 1:
                    rubberBandUpgradePanel.Visible = true;
                    rubberBandUpgradePanel.Location = new Point(12, 284);
                    break;
                case 2:
                    nothingPanel.Visible = true;
                    nothingPanel.Location = new Point(12, 284);
                    break;
            }
        }

        private void panelButton00_Click(object sender, EventArgs e)
        {
            switchPanel(0);
        }

        private void panelButton01_Click(object sender, EventArgs e)
        {
            switchPanel(1);
        }

        private void panelButton02_Click(object sender, EventArgs e)
        {
            switchPanel(2);
        }

        private int clickerUpgradedTimes = 0;
        private void clickerUpgradeButton_Click(object sender, EventArgs e)
        {
            if (money >= 70 * Math.Pow(1.5, clickerUpgradedTimes))
            {
                money -= Math.Round(70 * Math.Pow(1.5, clickerUpgradedTimes), 2);
                clickerUpgradedTimes++;
                if (70 * Math.Pow(1.5, clickerUpgradedTimes) >= 50000)
                {
                    clickerUpgradeButton.Text = "More Rubber Bands / Click $" + Math.Round(70 * Math.Pow(1.5, clickerUpgradedTimes), 2).ToString("e2");
                }
                else
                {
                    clickerUpgradeButton.Text = "More Rubber Bands / Click $" + Math.Round(70 * Math.Pow(1.5, clickerUpgradedTimes), 2);
                }
                clickerButtonLabel.Text = 1 + clickerUpgradedTimes * 2 + " Rubber Bands / Click";
                updateDisplay("money");
            }
        }

        private double nothingAmount;
        private void nothingButton_Click(object sender, EventArgs e)
        {
            if (money >= 2 * Math.Pow(2, nothingAmount))
            {
                money -= 2 * Math.Pow(2, nothingAmount);
                nothingAmount++;
                if (2 * Math.Pow(2, nothingAmount) >= 10000)
                {
                    nothingButton.Text = "Purchase nothing for $" + (2 * Math.Pow(2, nothingAmount)).ToString("e2");
                }
                else
                {
                    nothingButton.Text = "Purchase nothing for $" + 2 * Math.Pow(2, nothingAmount);
                }
            }
        }
    }
    class idleGenerator
    {
        public int amount;
        public double rubberBandPerSecond;
        public double cost;
        public double totalCost;
        public double costMultiplier;
        public double totalPerSecond;
        public int upgradeExpCost;
        public double upgradeAddCost;
        public int expUpgradeTimes;
        public double totalUpgradeAddAmount;
        public idleGenerator(int _cost, double _costMultiplier, double _rubberBandPerSecond)
        {
            cost = _cost;
            totalCost = _cost;
            costMultiplier = _costMultiplier;
            rubberBandPerSecond = _rubberBandPerSecond;
            expUpgradeTimes = 0;
            upgradeAddCost = 1000;
            upgradeExpCost = 10;
            amount = 0;
        }

        public double buy()
        {
            amount++;
            totalPerSecond = rubberBandPerSecond * amount;
            recalculateAmount();
            return cost * Math.Pow(costMultiplier, amount - 1);
        }
        public bool upgrade(double _rubberBandPerSecondAdd, string _addType)
        {
            if (_addType == "mult")
            {
                rubberBandPerSecond = rubberBandPerSecond * _rubberBandPerSecondAdd;
            }
            else if (_addType == "add")
            {
                rubberBandPerSecond += _rubberBandPerSecondAdd;
                totalUpgradeAddAmount += _rubberBandPerSecondAdd;
                upgradeAddCost *= 4;

            }
            else if (_addType == "exp")
            {
                rubberBandPerSecond = Math.Pow(rubberBandPerSecond, _rubberBandPerSecondAdd);
                rubberBandPerSecond = Math.Round(rubberBandPerSecond, 2);
                upgradeExpCost = upgradeExpCost * 2 + 20;
                expUpgradeTimes++;
            }
            else
            {
                return false;
            }                
            recalculateAmount();
            return true;
        }
        public void clear()
        {   
            amount = 0;
            recalculateAmount();
        }
        public void recalculateAmount()
        {
            totalCost = Math.Round(cost * Math.Pow(costMultiplier, amount), 2);
            totalPerSecond = rubberBandPerSecond * amount;
        }
    }
}
// funny thing h
