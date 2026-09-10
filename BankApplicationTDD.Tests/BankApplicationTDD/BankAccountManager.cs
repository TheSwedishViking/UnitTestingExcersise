using BankApplicationTDD.Models;

namespace BankApplicationTDD
{
    internal class BankAccountManager
    {
        public BankAccountManager()
        {
        }

        public (bool, BankAccount?) CreateAccount(string vname, double balance)
        {

            if (string.IsNullOrWhiteSpace(vname)) return (false, null);

            if (balance < 0) return (false, null);

            BankAccount account = new BankAccount
            {
                CustomerName = vname,
                Balance = balance,
                AccountClearingAndStandardNumber = new Random().Next(100000, 999999)
            };
            return (true, account);
        }

        public bool GetBankAccount(int? bankAccountNumber)
        {
            if (bankAccountNumber == null) return false;

            if (bankAccountNumber == 0) return false;

            if (bankAccountNumber < 0) return false;

            return true;
        }

        internal (bool success, double bankBalanceChange) InsertBalance(object userBankAccount, object balance)
        {
            throw new NotImplementedException();
        }

        internal (bool success, double bankBalanceChange, double totalInAccount) InsertsOrWithdraws(bool userBankAccount, double currentBalance, double changeAmount)
        {
            if (userBankAccount == false)
            {
                //As showcased by the course
                return (false, 0, 0);

                //Alternative, test that fails, throws error
                throw new ArgumentNullException("No valid bank account found");
            }

            if (changeAmount == 0)
            {
                throw new InvalidDataException("Can't insert 0 of currency");
            }
            if(currentBalance == 0 || currentBalance < 0)
            {
                throw new ArgumentOutOfRangeException("Broooke lmaooooo");
            }
            if(changeAmount < 0)
            {
                if (Math.Abs(changeAmount) > currentBalance)
                {
                    throw new ArgumentOutOfRangeException("Can't withdraw more money than that's avilable in account");
                }
            }

            double effectiveChange = currentBalance + changeAmount;

            return (true, changeAmount,  effectiveChange);
        }

    }
}