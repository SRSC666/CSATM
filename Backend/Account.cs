namespace CSATM.Backend
{
    public class Account(string bankName, string number, string username, string password)
    {
        /// <summary>
        /// 银行名
        /// </summary>
        public string BankName { get; } = bankName;
        /// <summary>
        /// 卡号
        /// </summary>
        public string Number { get; } = number;

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
