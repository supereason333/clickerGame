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

namespace clickerGame
{
    public partial class gameForm01 : Form
    {
        public gameForm01()
        {
            InitializeComponent();
        }
        private double money = 0;
        private double moneyPerRubberBand = 0.1;
        private double rubberBand = 0;
        private double rubberBandsPerClick = 1;
        bool broughtNews = false;
        int newsClicked = 0;
        Random rnd = new Random();

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
        private void newsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            newsBox.Text = Convert.ToString(rnd.Next(0, 100));
        }
        private void updateDisplay(string type)
        {
            if (type == "money")
            {
                money = Math.Round(money, 2);
                moneyAmountBox.Text = "$" + money;
            }
            else if (type == "rubberBand")
            {
                rubberBand = Math.Round(rubberBand, 2);
                rubberBandAmountBox.Text = Convert.ToString(rubberBand);
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
            money += rubberBand * moneyPerRubberBand;
            rubberBand = 0;
            updateDisplay("money");
            updateDisplay("rubberBand");
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            money += 100000;
            rubberBand += 100000;
            updateDisplay("money");
            updateDisplay("rubberBand");
        }


    }
}
