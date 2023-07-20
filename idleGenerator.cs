using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickerGame
{
    internal class idleGenerator
    {
        public double totalRubberBandPerSecond = 0;
        double rubberBandPerSecond;

        double startCost;
        double startUpgradeAddCost;
        public double broughtAmount = 0;
        public double nextBuyCost;              // next buy cost = start cost * 1.1^amount
        public double upgradeExpAmount = 0;
        public double nextUpgradeExpCost = 10;  // next exp cost = 10*2^amount + 20*amount = (10 * Math.Pow(2, upgradeExpAmount) + 20 * upgradeExpAmount)
        public double upgradeAddAmount = 0;
        public double nextUpgradeAddCost = 100; // next add cost = 100*10^amount = (100*Math.Pow(10, upgradeAddAmount))

        public idleGenerator(double _rubberBandPerSecond, int _startCost, double _startUpgradeAddCost)
        {
            rubberBandPerSecond = _rubberBandPerSecond;
            startCost = _startCost;
            startUpgradeAddCost = _startUpgradeAddCost;
            recalculateAmount();
        }
        public double buy()
        {
            broughtAmount++;
            recalculateAmount();
            return startCost * Math.Pow(1.1, broughtAmount - 1);
        }
        public void upgradeExp()
        {
            upgradeExpAmount++;
            broughtAmount -= nextUpgradeExpCost;
            recalculateAmount();
        }
        public double upgradeAdd()
        {
            upgradeAddAmount++;
            recalculateAmount();
            return startUpgradeAddCost * Math.Pow(10, upgradeAddAmount - 1);
        }
        public void clear()
        {
            broughtAmount = 0;
            recalculateAmount();
        }
        private void recalculateAmount()
        {
            totalRubberBandPerSecond = Math.Pow(rubberBandPerSecond + upgradeAddAmount * 10, Math.Pow(1.1, upgradeExpAmount)) * broughtAmount;
            nextUpgradeExpCost = 10 * Math.Pow(2, upgradeExpAmount) + 20 * upgradeExpAmount;
            nextUpgradeAddCost = startUpgradeAddCost * Math.Pow(10, upgradeAddAmount);
            nextBuyCost = startCost * Math.Pow(1.1, broughtAmount);
        }
    }
}
