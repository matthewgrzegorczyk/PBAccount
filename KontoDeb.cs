using System;

namespace PBAccount {
    public class KontoDeb : KontoHis
    {
        private double maxDeb = 0;

        public double getDeb() {
            return this.maxDeb;
        }
        public override void AddEntryToHistory(double balance) {
            base.AddEntryToHistory(balance);
            
            double sum = 0;

            foreach (double entry in this.GetHistory()) {
                sum += entry;
            }

            this.maxDeb = sum / this.GetHistorySize() * 0.5 + this.GetBalance();

        }
        public override void Withdraw(int value) {
            if (this.maxDeb < value) {
                throw new System.Exception("You don't have required amount of money. The amount of money you want to withdraw is bigger than your current account balance.");
            }
            else {
                this.SetBalance(this.GetBalance() - value);
                Console.WriteLine("this.GetBalance(): " + this.GetBalance());
                this.AddEntryToHistory(this.GetBalance());
            }
        }
        
    }
}