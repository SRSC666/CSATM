namespace CSATM.Backend
{
    /// <summary>
    /// 操作结果
    /// </summary>
    /// <param name="code"></param>
    /// <param name="message"></param>
    /// <param name="data"></param>
    public class Result(int code, string message, object data)
    {
        public int Code { get; set; } = code;
        public string Message { get; set; } = message;
        public object Data { get; set; } = data;

        public static Result Success() => new(1, "Success", null);
        public static Result Success(object data) => new(1, "Success", data);
        public static Result Failure(string message) => new(0, message, null);
    }
}
