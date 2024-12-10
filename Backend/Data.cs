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
        public static List<Bank> Banks { get; } = [];

        /// <summary>
        /// 序列化选项
        /// </summary>
        public static JsonSerializerOptions SerializerOptions { get; } = new()
        {
            WriteIndented = true
        };

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
            string jsonOfBanks = JsonSerializer.Serialize(Banks, SerializerOptions);
            File.WriteAllText(FileName, jsonOfBanks);
        }
    }
}
