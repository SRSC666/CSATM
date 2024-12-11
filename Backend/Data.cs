using System.Text.Json;

namespace CSATM.Backend
{
    /// <summary>
    /// 银行数据
    /// </summary>
    public class Data
    {
        /// <summary>
        /// 数据存储文件名
        /// </summary>
        public const string FileName = "data.json";

        /// <summary>
        /// 银行表
        /// </summary>
        public static List<Bank> Banks { get; set; } = [];

        /// <summary>
        /// 序列化选项
        /// </summary>
        public static JsonSerializerOptions SerializerOptions { get; set; } = new()
        {
            WriteIndented = true
        };

        /// <summary>
        /// 读取银行数据
        /// </summary>
        public static void LoadBankData()
        {
            //通过读取Json数据，然后反序列化为银行数据
            string jsonOfBanks = File.ReadAllText(FileName);
            Banks = JsonSerializer.Deserialize<List<Bank>>(jsonOfBanks);
        }

        /// <summary>
        /// 保存银行数据
        /// </summary>
        public static void SaveBankData()
        {
            //将银行数据序列化为Json
            string jsonOfBanks = JsonSerializer.Serialize(Banks, SerializerOptions);
            File.WriteAllText(FileName, jsonOfBanks);
        }

        /// <summary>
        /// 获取银行账户
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Account GetAccount(string bankName, string number)
        {
            Bank bank = Banks.FirstOrDefault(b => b.Name == bankName);
            if (bank == null)
            {
                return null;
            }

            return bank.Accounts.FirstOrDefault(a => a.Number == number);
        }
    }
}
