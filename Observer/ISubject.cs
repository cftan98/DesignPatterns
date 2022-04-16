namespace Observer
{
    internal interface ISubject<T>
    {
        internal void Attach(T obj);
        internal void Detach(T obj);
        internal void Notify();
    }
}
