using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal abstract class SmartBanking
    {
        private string bankName;
        private int accNum;
        public void setName(string bankName)
        {
            this.bankName = bankName;
        }
        public void setAccNum(int accNum)
        {
            this.accNum = accNum;
        }
      
        public string getBankName() 
        {
            return bankName;
        }
        public int getAccNum()
        {
            return accNum;
        }
        
        public void pinChange(int pin)
        {
            if (pin == 123)
            {
                Console.WriteLine("Pin Change Successfully");
            }
            else
            {
                Console.WriteLine("Invalid Pin");
            }
        }
        abstract public void withdraw(int amt,int pin);
        abstract public void deposite(int amt,int pin);

    }
    internal class SavingsAccount : SmartBanking
    {
      double balance=1000;
        public override void deposite(int amt ,int pin)
        {
            if (amt >= 100 && pin==123)
            {
                balance += amt;
                Console.WriteLine("After deposite Balance is : " + balance);
            }
            else
            {
                Console.WriteLine("Enetr the more then are equal to $ 100");
            }
        }
        
        public override void withdraw(int amt ,int pin)
        {
            if (amt > 1 && pin==123 && balance>0)
            {
                balance -= amt;
                Console.WriteLine("After Withdraw Balance is : " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

    }
    internal class CurrentAccount : SmartBanking
    {
       
        int balance = 1000;
        public override void deposite(int amt ,int pin)
        {
            if (amt >= 100 && pin==123)
            {
                balance += amt;
                Console.WriteLine("After deposite Balance is : " + balance);
            }
            else
            {
                Console.WriteLine("Enetr the more then are equal to $ 100");
            }
        }
        public override void withdraw(int amt,int pin)
        {
            if (amt > 1 && pin == 123 && balance >= 0) 
            {
               balance -= amt;
                Console.WriteLine("After Withdraw Balance is : " + balance);
            }else
            {
                Console.WriteLine("Insufficient Balance");
            }
            
        }
    }
}
