using System;
using System.Collections.Generic;

namespace PBAccount {
    public class KontoHis : Konto
    {
        private LinkedList<double> history;
        private static readonly int historySize = 20;

        public KontoHis() {
            history = new LinkedList<double>();
        }

        public override void Add(int value) {
            base.Add(value);
            this.AddEntryToHistory(this.GetBalance());
        }

        public override void Withdraw(int value) {
            base.Withdraw(value);
            this.AddEntryToHistory(this.GetBalance());
        }

        public virtual void AddEntryToHistory(double balance) {
            if (this.history.Count >= KontoHis.historySize) {
                this.history.RemoveFirst();
            }
            
            this.history.AddLast(balance);
        }

        public LinkedList<double> GetHistory() {
            return this.history;
        }

        public int GetHistorySize() {
            return this.history.Count;
        }

        public void ViewHistory() {
            Console.WriteLine();
            Console.WriteLine("Account History:");
            int index = 1;
            foreach(double entry in history) {
                Console.WriteLine(index++ + ": " + entry);
            }

            Console.WriteLine("End of account history.");
            Console.WriteLine();
        }
    }
}