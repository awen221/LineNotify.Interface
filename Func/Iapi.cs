namespace LineNotify.Interface.Func
{
    using Data;

    public interface Iapi<T>
    {
        T notify(string token, string message);
    }
}
