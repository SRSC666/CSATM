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
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static Result SaveMoney(decimal amount) =>
            CurrentAccount != null ? SaveMoney(amount) : Result.Failure("用户未登录");
    }
}
