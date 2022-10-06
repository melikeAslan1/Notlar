namespace YoutubeDersleri.Data.Infrastructure.Entities
{
    public class DataResult
    {
        public DataResult(bool isSucceed, string message)
        {
            IsSucceed = isSucceed;
            Message = message;
        }

        public bool IsSucceed { get; set; }
        public string Message { get; set; }
    }
}
