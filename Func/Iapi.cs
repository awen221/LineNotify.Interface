namespace LineNotify.Interface.Func
{
    public interface Iapi<T>
    {
        T notify(string token, string message);
    }
}
