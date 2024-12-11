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

        /// <summary>
        /// 删除银行
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Result DeleteBank(string name)
        {
            Bank bank = Data.GetBank(name);
            if (bank == null)
            {
                return Result.Failure("银行不存在");
            }

            if (bank.Accounts.Count > 0)
            {
                return Result.Failure("该银行下有账户，不能删除");
            }

            Data.Banks.Remove(bank);
            return Result.Success();
        }
    }
}
