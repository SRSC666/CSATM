
namespace CSATM.Backend
{
    /// <summary>
    /// 银行账户
    /// </summary>
    /// <param name="bankName"></param>
    /// <param name="number"></param>
    /// <param name="username"></param>
    /// <param name="password"></param>
    public class Account(string bankName, string number, string username, string password)
    {
        /// <summary>
        /// 银行名
        /// </summary>
        public string BankName { get; set; } = bankName;
        /// <summary>
        /// 卡号
        /// </summary>
        public string Number { get; set; } = number;

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Username { get; set; } = username;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; } = password;

        /// <summary>
        /// 余额
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public Result SaveMoney(decimal amount)
        {
            if (amount <= 0)
            {
                return Result.Failure("数值必须大于0");
            }
            Balance += amount;
            return Result.Success();
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual Result WithdrawMoney(decimal amount)
        {
            if (amount <= 0)
            {
                return Result.Failure("数值必须大于0");
            }

            if (Balance - amount > 0)
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
