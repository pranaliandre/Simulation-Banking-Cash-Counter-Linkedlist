using System;
namespace SimulateBaking
{
    // cash cash withdraw and deposite are done
    public class Banking
    {
        // cash withdraw
        public int cashWithdraw(int cashToWithdraw, int currentBalance)
        {
            currentBalance =currentBalance - cashToWithdraw;
            return currentBalance;
        }

        // cash deposite
        public int cashDeposite(int cashToDeposite, int currentBalance)
        {
            currentBalance =currentBalance + cashToDeposite;
            return currentBalance;
        }

        public string setname()
        {
            string name = Console.ReadLine();
            return name;
        }
        public int setAccountNo()
        {
            int accountNo = Convert.ToInt32(Console.ReadLine());
            return accountNo;
        }
    }
}
