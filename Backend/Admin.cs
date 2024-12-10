namespace CSATM.Backend
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// 添加银行
        /// </summary>
        /// <param name="name">银行名</param>
        public static void AddBank(string name)
        {
            Bank bank = new(name);
            Data.Banks.Add(bank);
        }
    }
}
