using System;

namespace Delegates
{
    internal class Program
    {
        public delegate float DelegateOperation(float val1 , float val2);
        
        public static float DepositOfMoney(float quantity, float amount)
        {
            return quantity + amount;
        }

        public static float WithdrawalOfMoney(float quantity, float amount)
        {
            if (!(quantity > amount)) 
                return amount - quantity;
            Console.WriteLine("insufficient funds");
            return 0.0f;
        }

        public static float ExecuteOperation(DelegateOperation operation, float quantity, float amount)
        {
            return operation(quantity, amount);
        }
        
        public static void Main(string[] args)
        {
            DelegateOperation retirement = WithdrawalOfMoney;
            DelegateOperation deposit = DepositOfMoney;
            
            var resultRetirement = ExecuteOperation(retirement, 100, 500);
            var resultDeposit = ExecuteOperation(deposit, 100, 500);
            
            Console.WriteLine($"Retirement: {resultRetirement}");
            Console.WriteLine($"Deposit: {resultDeposit}");

            // Lambda + delegates
            DelegateOperation depositInterest = (quantity, amount) => (quantity > 100) ? quantity + amount + (amount * 0.02f) : quantity + amount;
            var resultLambda = ExecuteOperation(depositInterest, 101, 100 );
            Console.WriteLine($"Interest: {resultLambda}");
        }
    }
}