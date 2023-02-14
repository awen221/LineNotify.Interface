namespace LineNotify.Interface.Data
{
    public interface IResult
    {
        int status { set; get; }
        string message { set; get; }
    }
}