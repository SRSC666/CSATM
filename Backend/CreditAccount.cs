namespace CSATM.Backend
{
    public class CreditAccount(string bankName, string number, string username, string password) : Account(bankName, number, username, password)
    {
        public override Result WithdrawMoney(decimal amount)
        {
            if (amount <= 0m)
            {
                return Result.Failure("数值必须大于0");
            }

            if (Balance - amount > -10000m)
            {
                Balance -= amount;
                return amount >= 10000m ?
                    Result.Success(new BigMoneyArgs(Number, amount)) :
                    Result.Success();
            }

            return Result.Failure("余额不足");
        }
    }
}
