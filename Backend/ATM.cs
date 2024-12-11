namespace CSATM.Backend
{
    /// <summary>
    /// ATM机
    /// </summary>
    public class ATM
    {
        /// <summary>
        /// 当前操作的账户
        /// </summary>
        public static Account CurrentAccount { get; set; }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="number"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Result Login(string bankName, string number, string password)
        {
            Account account = Data.GetAccount(bankName, number);
            if (account == null)
            {
                return Result.Failure("该账户不存在");
            }

            if (password != account.Password)
            {
                return Result.Failure("密码错误");
            }

            CurrentAccount = account;
            return Result.Success();
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public static Result Logout()
        {
            CurrentAccount = null;
            return Result.Success();
        }

        /// <summary>
        /// 创建账户
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="number"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Result CreateAccount(string bankName, string number, string username, string password)
        {
            if (bankName == null || number == null || username == null || password == null ||
                bankName == string.Empty || number == string.Empty ||
                username == string.Empty || password == string.Empty)
            {
                return Result.Failure("注册信息不能为空");
            }

            Bank bank = Data.GetBank(bankName);
            if (bank == null)
            {
                return Result.Failure("银行不存在");
            }

            Account account = Data.GetAccount(bankName, number);
            if (account != null)
            {
                return Result.Failure("账户已经存在");
            }

            account = new(bankName, number, username, password);
            bank.Accounts.Add(account);
            return Result.Success();
        }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static Result SaveMoney(decimal amount) =>
            CurrentAccount != null ? CurrentAccount.SaveMoney(amount) : Result.Failure("用户未登录");

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static Result WithdrawMoney(decimal amount) =>
            CurrentAccount != null ? CurrentAccount.WithdrawMoney(amount) : Result.Failure("用户未登录");
    }
}
