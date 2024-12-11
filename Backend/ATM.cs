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
    }
}
