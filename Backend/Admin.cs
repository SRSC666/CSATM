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
        public static Result AddBank(string name)
        {
            Bank bank = Data.GetBank(name);
            if (bank != null)
            {
                return Result.Failure("银行已经存在");
            }

            bank = new(name);
            Data.Banks.Add(bank);
            return Result.Success();
        }
    }
}
