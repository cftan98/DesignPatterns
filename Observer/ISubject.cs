namespace Observer
{
    internal interface ISubject<T>
    {
        public void Attach(T obj);
        public void Detach(T obj);
        public void Notify();
    }
}