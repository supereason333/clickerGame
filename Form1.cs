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
            casinoPanelChange(0);
            updateDisplay("rubberBand");
            updateDisplay("money");
            updateDisplay("idleGenerator");
        }
        private double money = 0;
        private double rubberBand = 0;
        bool broughtNews = false;
        int newsClicked = 0;
        Random rnd = new Random();
        private void gameForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(957, 650);
            this.CenterToScreen();
            rubberBandCostUpgrade.Text = "$" + Math.Round(0.1 * Math.Pow(1.5, rubberBand01.upgradeAmount), 2) + " Per band, $" + rubberBand01.nextUpgradeCost + " to buy";
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
            string toStringType = "";
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
                workerAmountLabel.Text = Convert.ToString(worker01.broughtAmount) + " Workers";
                workerRubberBandLabel.Text = Convert.ToString(Math.Round(worker01.totalRubberBandPerSecond, 2)) + " Rubber Bands Per Second";
                if (worker01.nextBuyCost >= 10000)
                {
                    toStringType = "e4";
                }
                else
                {
                    toStringType = "N";
                }
                workerButtom.Text = "Factory Worker: $" + worker01.nextBuyCost.ToString(toStringType) + " To hire";

                machineAmountLabel.Text = Convert.ToString(machine01.broughtAmount) + " Machines";
                machineRubberBandLabel.Text = Convert.ToString(Math.Round(machine01.totalRubberBandPerSecond, 2)) + " Rubber Bands Per Second";
                if (machine01.nextBuyCost >= 10000)
                {
                    toStringType = "e4";
                }
                else
                {
                    toStringType = "N";
                }
                machineButton.Text = "Machine: $" + machine01.nextBuyCost.ToString(toStringType);

                productionLineAmountLabel.Text = Convert.ToString(productionLine01.broughtAmount) + " Production Lines";
                ProductionLineRubberBandLabel.Text = Convert.ToString(Math.Round(productionLine01.totalRubberBandPerSecond, 2)) + " Rubber Bands Per Second";
                if (productionLine01.nextBuyCost >= 10000)
                {
                    toStringType = "e4";
                }
                else
                {
                    toStringType = "N";
                }
                productionLineButton.Text = "Production Line: $" + productionLine01.nextBuyCost.ToString(toStringType);
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
            money += rubberBand * rubberBand01.price;
            rubberBand = 0;
            updateDisplay("money");
            updateDisplay("rubberBand");
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            money += Convert.ToInt32(testTextBox.Text);
            rubberBand += Convert.ToInt32(testTextBox.Text);
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
            totalPerSecond = idleMultiplier * (worker01.totalRubberBandPerSecond + machine01.totalRubberBandPerSecond + productionLine01.totalRubberBandPerSecond) * Math.Pow(1.01, nothingAmount);
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
        rubberBand rubberBand01 = new rubberBand();
        private void rubberBandUpgradeButton_Click(object sender, EventArgs e)
        {
            if (money >= rubberBand01.nextUpgradeCost)
            {
                money -= rubberBand01.upgradeAdd();
                moneyButtonLabel.Text = "1 Rubber Band = $" + rubberBand01.price;
                rubberBandCostUpgrade.Text = "$" + Math.Round(0.1 * Math.Pow(1.5, rubberBand01.upgradeAmount), 2) + " Per band, $" + rubberBand01.nextUpgradeCost + " to buy";
                updateDisplay("money");
            }
        }
        
        idleGenerator worker01 = new idleGenerator(10, 10, 1000);
        private void workerButtom_Click(object sender, EventArgs e)
        {
            if (money >= worker01.nextBuyCost)
            {
                money -= worker01.buy();
                updateDisplay("money");
                updateDisplay("idleGenerator");
            }
        }
        private void workerUpgradeButton_Click(object sender, EventArgs e)
        {
            if (worker01.broughtAmount >= worker01.nextUpgradeExpCost)
            {
                worker01.upgradeExp();
                workerUpgradeExpButton.Text = "Upgrade Worker ^ 1.1 costs " + worker01.nextUpgradeExpCost + " workers";
                updateDisplay("idleGenerator");
                UpgradeWorkerLabel.Text = "Worker Efficiency ^ " + Math.Pow(1.1, worker01.upgradeExpAmount);
            }
        }
        
        private void workerUpgradeAddButton_Click(object sender, EventArgs e)
        {
            if (money >= worker01.nextUpgradeAddCost)
            {
                money -= worker01.upgradeAdd();
                updateDisplay("money");
                updateDisplay("idleGenerator");
                workerUpgradeAddButton.Text = "Upgrade Worker +10 costs $" + worker01.nextUpgradeAddCost.ToString("e2");
                WorkerUpgradeAddLabel.Text = "Worker + " + worker01.upgradeAddAmount * 10 + " / sec";
            }
        }
        idleGenerator machine01 = new idleGenerator(40, 270, 10000);
        private void machineButton_Click(object sender, EventArgs e)
        {
            if (money >= machine01.nextBuyCost)
            {
                money -= machine01.buy();
                updateDisplay("money");
                updateDisplay("idleGenerator");
            }
        }
        private void machineUpgradeExpButton_Click(object sender, EventArgs e)
        {
            if (machine01.broughtAmount >= machine01.nextUpgradeExpCost)
            {
                machine01.upgradeExp();
                machineUpgradeExpButton.Text = "Upgrade machine ^ 1.1 costs " + machine01.nextUpgradeExpCost + " machines";
                updateDisplay("idleGenerator");
                upgradeMachineLabel.Text = "machine Efficiency ^ " + Math.Pow(1.1, machine01.upgradeExpAmount);
            }
        }
        private void machineUpgradeAddButton_Click(object sender, EventArgs e)
        {
            {
                if (money >= machine01.nextUpgradeAddCost)
                {
                    money -= machine01.upgradeAdd();
                    updateDisplay("money");
                    updateDisplay("idleGenerator");
                    machineUpgradeAddButton.Text = "Upgrade machine +10 costs $" + machine01.nextUpgradeAddCost.ToString("e2");
                    machineUpgradeAddLabel.Text = "Wachine + " + machine01.upgradeAddAmount * 10 + " / sec";
                }
            }
        }
        idleGenerator productionLine01 = new idleGenerator(100, 700, 100000);
        private void productionLineButton_Click(object sender, EventArgs e)
        {
            if (money >= productionLine01.nextBuyCost)
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
            mainUpgradePanel.Visible = false; mainUpgradePanel.Location = new Point(12, 272);
            nothingPanel.Visible = false; rubberBandUpgradePanel.Location = new Point(12, 272);
            rubberBandUpgradePanel.Visible = false; nothingPanel.Location = new Point(12, 272);
            casinoPanel.Visible = false; casinoPanel.Location = new Point(12, 272);
            switch (panelNumber)
            {
                case 0:
                    mainUpgradePanel.Visible = true;
                    break;
                case 1:
                    rubberBandUpgradePanel.Visible = true;
                    break;
                case 2:
                    nothingPanel.Visible = true;
                    break;
                case 3:
                    casinoPanel.Visible = true;
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
        private void panelButton03_Click(object sender, EventArgs e)
        {
            switchPanel(3);
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
        private void casinoPanelChange(int panelNumber)
        {
            casinoPlayPanel00.Hide(); casinoPlayPanel00.Location = new Point(166, 3);
            casinoPlayPanel01.Hide(); casinoPlayPanel01.Location = new Point(166, 3);
            switch (panelNumber)
            {
                case 0:
                    casinoPlayPanel00.Show();
                    break;
                case 1:
                    casinoPlayPanel01.Show();
                    break;
            }
        }

        private void gambleButton00_Click(object sender, EventArgs e)
        {
            casinoPanelChange(0);
            casinoRandomNumberBox.Text = "Amount:";
        }

        private void gambleButton01_Click(object sender, EventArgs e)
        {
            casinoPanelChange(1);
        }

        double bettingAmount;
        double wonMoney;
        int minAmount = 8;
        private void randomNumberGambleButton_Click(object sender, EventArgs e)
        {
            if (!casinoRandomNumberBox.Text.IsNumeric())
            {
                casinoRandomNumberBox.Text = "Enter a number";
                return;
            }
            bettingAmount = Convert.ToDouble(casinoRandomNumberBox.Text);
            if (bettingAmount <= money)
            {
                money -= bettingAmount;
                wonMoney = rnd.Next(minAmount, 19) * bettingAmount / 10;
                minAmount = 0;
                money += wonMoney;
            }
            else
            {
                casinoRandomNumberBox.Text = "Not enough Money";
                return;
            }
            if (wonMoney > bettingAmount)
            {
                casinoRandomNumberBox.Text = "You won $" + (wonMoney - bettingAmount).ToString("N2");
            }
            else if (wonMoney < bettingAmount)
            {
                casinoRandomNumberBox.Text = "You lost $" + (bettingAmount - wonMoney).ToString("N2");
            }
            else
            {
                casinoRandomNumberBox.Text = "You didn't loose nor gain";
            }
            updateDisplay("money");
        }
        private void gambleAllMoneyButton_Click(object sender, EventArgs e)
        {
            casinoRandomNumberBox.Text = "" + money;
        }

        private void casinoRandomNumberBox_MouseClick(object sender, MouseEventArgs e)
        {
            casinoRandomNumberBox.Text = string.Empty;
        }
        clickerGame.catAction catAction01 = new catAction();
        private void catTextButton_Click(object sender, EventArgs e)
        {
            catTextButton.Text = catAction01.normalSpeech();
        }
    }
}
// funny thing h