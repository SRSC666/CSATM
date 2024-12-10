namespace CSATM.Backend
{
    public class Bank(string name)
    {
        /// <summary>
        /// 银行名称
        /// </summary>
        public string Name { get; set; } = name;

        /// <summary>
        /// 账户表
        /// </summary>
        public List<Account> Accounts { get; } = [];
    }
}
