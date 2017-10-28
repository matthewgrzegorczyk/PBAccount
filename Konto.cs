using System;

namespace PBAccount {
    public class Konto
    {
        private string id;
        private double balance;

        public Konto() { 
            this.id = "ABC123";
        }

        public Konto(String id) {
            this.id = id;
        }


        public virtual void Add(int value) {
            this.balance += value;
        }

        public virtual void Withdraw(int value) {
            if (this.balance < value) {
                throw new System.Exception("You don't have required amount of money. The amount of money you want to withdraw is bigger than your current account balance.");
            }
            else {
                this.balance -= value;
            }
        }

        public double GetBalance() {
            return this.balance;
        }

        protected void SetBalance(double value) {
            this.balance = value;
        }

        public string CheckBalance() {
            return "Your current account balance is $" + this.balance;
        }

        public override string ToString() {
            return this.id + " " + this.balance;
        }

    }

}