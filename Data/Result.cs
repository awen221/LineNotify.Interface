namespace LineNotify.Interface.Data
{
    public class Result : IResult
    {
        public int status { set; get; }
        public string message { set; get; } = string.Empty;
    }
}