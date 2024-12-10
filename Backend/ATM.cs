namespace CSATM.Backend
{
    public static class ATM
    {
        /// <summary>
        /// 数据存储文件名
        /// </summary>
        public const string FileName = "data.json";

        /// <summary>
        /// 银行表
        /// </summary>
        public static List<Bank> Banks { get; } = [];

        /// <summary>
        /// 当前操作的账户
        /// </summary>
        public static Account CurrentAccount { get; set; }

        /// <summary>
        /// 读取银行数据
        /// </summary>
        public static void LoadBankData()
        {
            
        }

        /// <summary>
        /// 保存银行数据
        /// </summary>
        public static void SaveBankData()
        {

        }
    }
}
