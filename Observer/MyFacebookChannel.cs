namespace Observer
{
    internal class MyFacebookChannel : ISubject<User>
    {
        private IList<User> _users = new List<User>();

        public void Attach(User obj)
        {
            _users.Add(obj);
        }

        public void Detach(User obj)
        {
            _users.Remove(obj);
        }

        public void Notify()
        {
            foreach (var user in _users)
            {
                user.Update();
            }
        }
    }
}
