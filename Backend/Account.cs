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
    }
}
