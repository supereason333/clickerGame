using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerGame
{
    internal class rubberBand
    {
        public int upgradeAmount = 0;
        public double nextUpgradeCost = 2500;
        public double price = 0.1;
        public double upgradeAdd()
        {
            upgradeAmount++;
            recalculateAmount();
            return Math.Round(2500 * Math.Pow(2, upgradeAmount - 1), 2);
        }
        private void recalculateAmount()
        {
            nextUpgradeCost = Math.Round(2500 * Math.Pow(2, upgradeAmount), 2);
            price = Math.Round(0.1 * Math.Pow(1.5, upgradeAmount), 2);
        }
    }
}
